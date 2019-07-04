Imports System.Data.OleDb
Public Class frmMapping_Code_List_Import
    Public dtReturn As DataTable = Nothing
    Public isFirstHasColumnName As Boolean = False
    Private Sub txtPath_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtPath.ButtonClick
        Try

            OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;"

            Dim rslt As DialogResult = OpenFileDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then

                txtPath.EditValue = OpenFileDialog1.FileName

            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            dtReturn = Nothing

            If txtPath.EditValue = "" OrElse System.IO.File.Exists(txtPath.EditValue) = False Then
                MsgBox("Invalid file name.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            StatusUpdate("Ready import.")

            Dim tableName As String = "Sheet"
            Dim adapter As OleDbDataAdapter
            Dim strSQL As String = Nothing
            Dim dtRow As DataRow = Nothing
            Dim connectionString As String = ""
            Dim dtSheets As DataTable = Nothing

            If txtPath.EditValue.ToString.EndsWith(".xlsx") Then            '2007 Format            
                connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=No'", txtPath.EditValue)
            Else            '2003 Format            
                connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=No'", txtPath.EditValue)
            End If
            StatusUpdate("Trying import")
            Dim conn As New OleDbConnection(connectionString)
            conn.Open()
            Application.DoEvents()
            If conn.State = ConnectionState.Open Then
                dtSheets = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

                If dtSheets IsNot Nothing AndAlso dtSheets.Rows.Count > 0 Then
                    tableName = dtSheets.Rows(0)("TABLE_NAME")
                Else
                    StatusUpdate("Failed to open sheet.")
                    Exit Sub
                End If
            Else
                StatusUpdate("Failed to open excel.")
                Exit Sub
            End If


            Dim ds = New DataSet()
            strSQL = "select * from [" & tableName & "]"
            adapter = New OleDbDataAdapter(strSQL, connectionString)
            adapter.Fill(ds, "Sheet")

            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                StatusUpdate("Record found(s) " & ds.Tables(0).Rows.Count & ".")


                If chkFirstHasName.Checked Then
                    isFirstHasColumnName = True
                Else
                    isFirstHasColumnName = False
                End If
                dtReturn = ds.Tables("Sheet")
                Me.Close()
            Else
                StatusUpdate("Import done, no record found.")
            End If
        Catch ex As Exception
            StatusUpdate("Failed import.")
        End Try
    End Sub
    Private Sub StatusUpdate(ByVal Status As String)
        Try
            lblStatus.Text = Status
            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPath_EditValueChanged(sender As Object, e As EventArgs) Handles txtPath.EditValueChanged

    End Sub
End Class