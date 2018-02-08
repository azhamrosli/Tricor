Public Class frmCA_Quick 
    Dim ErrorLog As clsError = Nothing

    Public Const MainTable As String = "CA"
    Private Sub frmCA_Quick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try
            If CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CreateLookUpYA(cboYA, ErrorLog) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If CreateLookUpCategory(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive category.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If mdlProcess.ArgParam2 <> "" Then
                cboRefNo.EditValue = mdlProcess.ArgParam2

            End If

            If mdlProcess.ArgParam3 <> "" Then
                cboYA.EditValue = mdlProcess.ArgParam3
             
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cboYE_EditValueChanged(sender As Object, e As EventArgs) Handles cboYA.EditValueChanged, cboRefNo.EditValueChanged
        Try
            DefaultTaxPayer()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DefaultTaxPayer()
        Try
            If cboRefNo IsNot Nothing AndAlso cboRefNo.EditValue.ToString <> "" Then

                'Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
                'Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
                'Dim value As Object = row("CompanyName")
 
                If mdlProcess.CreateLookUpSourceNO(cboSourceNo, cboRefNo.EditValue.ToString, cboYA.EditValue.ToString, ErrorLog) = False Then
                    cboSourceNo.EditValue = ""
                    Exit Sub
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            GridView1.GetDataRow(e.RowHandle)("CA_CTRL_TRANSFER") = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Duplicate1xToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Duplicate1xToolStripMenuItem.Click
        Try
            Dim dtrow As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

            If dtrow IsNot Nothing Then

                Dim newdtRow As DataRow = Nothing

                newdtRow = DsCA.Tables(MainTable).NewRow

                For i As Integer = 0 To DsCA.Tables(MainTable).Columns.Count - 1
                    If DsCA.Tables(MainTable).Columns(i).ColumnName <> "CA_KEY" Then

                        newdtRow(DsCA.Tables(MainTable).Columns(i).ColumnName) = dtrow(DsCA.Tables(MainTable).Columns(i).ColumnName)

                    End If
                Next


                DsCA.Tables(MainTable).Rows.Add(newdtRow)


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Duplicate3xToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Duplicate3xToolStripMenuItem.Click
        Try
            Dim dtrow As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

            If dtrow IsNot Nothing Then

                Dim newdtRow As DataRow = Nothing

                For x As Integer = 0 To 2
                    newdtRow = DsCA.Tables(MainTable).NewRow

                    For i As Integer = 0 To DsCA.Tables(MainTable).Columns.Count - 1
                        If DsCA.Tables(MainTable).Columns(i).ColumnName <> "CA_KEY" Then

                            newdtRow(DsCA.Tables(MainTable).Columns(i).ColumnName) = dtrow(DsCA.Tables(MainTable).Columns(i).ColumnName)

                        End If
                    Next


                    DsCA.Tables(MainTable).Rows.Add(newdtRow)
                Next
               
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Duplicate5xToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Duplicate5xToolStripMenuItem.Click
        Try
            Dim dtrow As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

            If dtrow IsNot Nothing Then

                Dim newdtRow As DataRow = Nothing

                For x As Integer = 0 To 4
                    newdtRow = DsCA.Tables(MainTable).NewRow

                    For i As Integer = 0 To DsCA.Tables(MainTable).Columns.Count - 1
                        If DsCA.Tables(MainTable).Columns(i).ColumnName <> "CA_KEY" Then

                            newdtRow(DsCA.Tables(MainTable).Columns(i).ColumnName) = dtrow(DsCA.Tables(MainTable).Columns(i).ColumnName)

                        End If
                    Next


                    DsCA.Tables(MainTable).Rows.Add(newdtRow)
                Next

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            GridView1.DeleteSelectedRows()
            DsCA.Tables(MainTable).AcceptChanges()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            If ADO.Save_CA_Quick(DsCA.Tables(MainTable), ErrorLog) Then
                MsgBox("Successfully saved capital allowance.", MsgBoxStyle.Information)
                Me.Close()
            Else
                MsgBox("Unsuccessfully save capital allowance.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImport.ItemClick
        Try
            OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;"

            Dim rslt As DialogResult = OpenFileDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then

                Dim Path As String = OpenFileDialog1.FileName

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
            Dim rslt As DialogResult = FolderBrowserDialog1.ShowDialog
            If rslt = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXlsx(FolderBrowserDialog1.SelectedPath & "\CA" & Format(Now, "ddMMMyyyyHHmmss") & ".xls")
                MsgBox("Successfully export data to " & FolderBrowserDialog1.SelectedPath, MsgBoxStyle.Information)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLoad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoad.ItemClick
        Try
            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue.ToString = "" Then
                MsgBox("Please select reference number.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim dt As DataTable = ADO.LoadCA_Search(cboRefNo.EditValue.ToString, "", -1, "")

            If dt IsNot Nothing Then
                CABindingSource.DataSource = dt
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class