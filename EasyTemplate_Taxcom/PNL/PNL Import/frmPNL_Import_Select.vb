Imports System.Data.OleDb

Public Class frmPNL_Import_Select

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Try
            txtFileUrl.ReadOnly = False

            OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;"

            Dim rslt As DialogResult = OpenFileDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then

                txtFileUrl.EditValue = OpenFileDialog1.FileName

                btnImport.PerformClick()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try

            If System.IO.File.Exists(txtFileUrl.EditValue) = False Then
                MsgBox("File not exist", MsgBoxStyle.Exclamation)
                txtFileUrl.ReadOnly = False
                Exit Sub
            Else
                txtFileUrl.ReadOnly = True
            End If

            Dim connectionString As String = ""
            If txtFileUrl.EditValue.ToString.EndsWith(".xlsx") Then            '2007 Format            
                connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=No'", txtFileUrl.EditValue)
            Else            '2003 Format            
                connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=No'", txtFileUrl.EditValue)
            End If

            Dim connExcel As New OleDbConnection(connectionString)
            Dim cmdExcel As New OleDbCommand()
            Dim oda As New OleDbDataAdapter()
            cmdExcel.Connection = connExcel
            connExcel.Open()

            Dim dt As DataTable = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Dim dtRow As DataRow = Nothing

            DsPNL2.Tables("PNLImport_TableList").Rows.Clear()
            DsPNL2.Tables("PNLImport_TableList_Select").Rows.Clear()
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i)("TABLE_NAME").ToString.Contains("FilterDatabase") = False AndAlso dt.Rows(i)("TABLE_NAME").ToString.Contains("Print_Titles") = False Then
                        dtRow = DsPNL2.Tables("PNLImport_TableList").NewRow
                        dtRow("No") = DsPNL2.Tables("PNLImport_TableList").Rows.Count + 1
                        dtRow("SheetName") = dt.Rows(i)("TABLE_NAME")
                        DsPNL2.Tables("PNLImport_TableList").Rows.Add(dtRow)
                    End If
                Next
               
            End If
            ''ds.DataSource = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)        cmbSheets.DisplayMember = "TABLE_NAME"        cmbSheets.ValueMember = "TABLE_NAME"        connExcel.Close()   


            'Dim adapter = New OleDbDataAdapter("select * from [Sheet$]", connectionString)
            'Dim ds = New DataSet()
            'Dim dsControl As DataSet
            'Dim tableName As String = "Sheet"
            'adapter.Fill(ds, tableName)

            'If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then


            'End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMoveRight1_Click(sender As Object, e As EventArgs) Handles btnMoveRight1.Click
        Try
            Dim dtRow As DataRow = Nothing
            For Each rowindx As Integer In GridView1.GetSelectedRows
                dtRow = GridView1.GetDataRow(rowindx)

                If dtRow IsNot Nothing Then
                    DsPNL2.Tables("PNLImport_TableList_Select").ImportRow(dtRow)
                End If

                GridView1.DeleteRow(rowindx)

            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMoveLeft1_Click(sender As Object, e As EventArgs) Handles btnMoveLeft1.Click
        Try
            Dim dtRow As DataRow = Nothing
            For Each rowindx As Integer In GridView2.GetSelectedRows
                dtRow = GridView2.GetDataRow(rowindx)

                If dtRow IsNot Nothing Then
                    DsPNL2.Tables("PNLImport_TableList").ImportRow(dtRow)
                End If

                GridView2.DeleteRow(rowindx)

            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMoveRight2_Click(sender As Object, e As EventArgs) Handles btnMoveRight2.Click
        Try
            Dim dtRow As DataRow = Nothing

            For i As Integer = 0 To DsPNL2.Tables("PNLImport_TableList").Rows.Count - 1
                DsPNL2.Tables("PNLImport_TableList_Select").ImportRow(DsPNL2.Tables("PNLImport_TableList").Rows(i))
            Next

            DsPNL2.Tables("PNLImport_TableList").Rows.Clear()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMoveLeft2_Click(sender As Object, e As EventArgs) Handles btnMoveLeft2.Click
        Try
            Dim dtRow As DataRow = Nothing

            For i As Integer = 0 To DsPNL2.Tables("PNLImport_TableList_Select").Rows.Count - 1
                DsPNL2.Tables("PNLImport_TableList").ImportRow(DsPNL2.Tables("PNLImport_TableList_Select").Rows(i))
            Next

            DsPNL2.Tables("PNLImport_TableList_Select").Rows.Clear()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmPNL_Import_Select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
        
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
           
            If DsPNL2.Tables("PNLImport_TableList_Select").Rows.Count = 0 Then
                MsgBox("Please select at least one sheet.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim frm As New frmPNL_Import
            frm.FileURL = txtFileUrl.EditValue
            frm.DataView_TableSheet = DsPNL2.Tables("PNLImport_TableList_Select")
            frm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

End Class