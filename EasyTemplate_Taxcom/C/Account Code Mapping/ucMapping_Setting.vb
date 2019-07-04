Imports System.Collections.Generic
Imports DevExpress.Spreadsheet
Public Class ucMapping_Setting
    Dim ErrorLog As ClsError = Nothing
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ucMapping_Setting_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try
            Dim dt As DataTable = Nothing

            dt = ADO.Load_Mapping_Setting(ErrorLog)

            DsAccountMapping.Tables("MAPPING_SETTING").Rows.Clear()

            If dt IsNot Nothing Then

                For Each rowx As DataRow In dt.Rows
                    DsAccountMapping.Tables("MAPPING_SETTING").ImportRow(rowx)
                Next

            End If

            MAPPINGSETTINGBindingSource.DataSource = DsAccountMapping.Tables("MAPPING_SETTING")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        ViewDetails()
    End Sub
    Private Sub ViewDetails()
        Try
            Dim dtRow As DataRow = Nothing

            For i As Integer = 0 To GridView1.SelectedRowsCount - 1
                txtID.EditValue = GridView1.GetDataRow(GridView1.GetSelectedRows(i))("ID")
                txtName.EditValue = GridView1.GetDataRow(GridView1.GetSelectedRows(i))("Setting_Name")
                txtStartRow.EditValue = GridView1.GetDataRow(GridView1.GetSelectedRows(i))("Start_Row")
                txtAccCell.EditValue = GridView1.GetDataRow(GridView1.GetSelectedRows(i))("AccNo_Cell")
                txtDescriptionCell.EditValue = GridView1.GetDataRow(GridView1.GetSelectedRows(i))("Description_Cell")
                txtAmount1Cell.EditValue = GridView1.GetDataRow(GridView1.GetSelectedRows(i))("Amount_Cell_1")
                txtAmount2Cell.EditValue = GridView1.GetDataRow(GridView1.GetSelectedRows(i))("Amount_Cell_2")
                txtModifiedBy.EditValue = GridView1.GetDataRow(GridView1.GetSelectedRows(i))("ModifiedBy")
                txtModifiedDateTime.EditValue = GridView1.GetDataRow(GridView1.GetSelectedRows(i))("ModifiedDateTime")
            Next

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNew.ItemClick
        Try
            txtID.EditValue = ""
            txtName.EditValue = ""
            txtStartRow.EditValue = ""
            txtAccCell.EditValue = ""
            txtDescriptionCell.EditValue = ""
            txtAmount1Cell.EditValue = ""
            txtAmount2Cell.EditValue = ""
            txtModifiedBy.EditValue = ""
            txtModifiedDateTime.EditValue = ""
            txtName.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            ViewDetails()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            If isValid() Then

                If txtID IsNot Nothing AndAlso IsNumeric(txtID.EditValue) AndAlso CInt(txtID.EditValue) <> 0 Then
                    If ADO.Update_Mapping_Setting(txtID.EditValue, txtName.EditValue, txtStartRow.EditValue, txtAccCell.EditValue, _
                                                  txtDescriptionCell.EditValue, txtAmount1Cell.EditValue, txtAmount2Cell.EditValue, _
                                                  txtModifiedBy.EditValue, txtModifiedDateTime.EditValue) Then
                        MsgBox("Successfully saved data.", MsgBoxStyle.Information)
                        LoadData()
                    Else
                        MsgBox("Unsuccessfully save data", MsgBoxStyle.Critical)
                    End If
                Else
                    If ADO.Save_Mapping_Setting(txtID.EditValue, txtName.EditValue, txtStartRow.EditValue, txtAccCell.EditValue, _
                                                  txtDescriptionCell.EditValue, txtAmount1Cell.EditValue, txtAmount2Cell.EditValue, _
                                                  txtModifiedBy.EditValue, txtModifiedDateTime.EditValue) Then
                        MsgBox("Successfully saved data.", MsgBoxStyle.Information)
                        LoadData()
                    Else
                        MsgBox("Unsuccessfully save data", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function isValid() As Boolean
        Try
            If txtName.EditValue Is Nothing OrElse txtName.EditValue = "" Then
                MsgBox("Please enter setting name.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If txtStartRow.EditValue Is Nothing OrElse IsNumeric(txtStartRow.EditValue) = False Then
                MsgBox("Invalid start row or empty.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If txtAccCell.EditValue Is Nothing OrElse txtAccCell.EditValue = "" Then
                MsgBox("Please enter account column cell.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If txtDescriptionCell.EditValue Is Nothing OrElse txtDescriptionCell.EditValue = "" Then
                MsgBox("Please enter description column cell.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If txtAmount1Cell.EditValue Is Nothing OrElse txtAmount1Cell.EditValue = "" Then
                MsgBox("Please enter amount column cell.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If txtAmount2Cell.EditValue Is Nothing Then
                txtAmount2Cell.EditValue = ""
            End If

            If txtID.EditValue Is Nothing AndAlso txtID.EditValue = "" Then
                txtID.EditValue = "0"
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "Mapping Configuration", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim ListofID As New List(Of Integer)
                For i As Integer = 0 To GridView1.SelectedRowsCount - 1
                    ListofID.Add(CInt(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("ID")))
                Next

                If ADO.Delete_Mapping_Setting(ListofID, ErrorLog) Then
                    MsgBox("Succesfully remove data.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Failed to remove data.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtPath_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtPath.ButtonClick
        Try

            OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;"

            Dim rslt As DialogResult = OpenFileDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then

                txtPath.EditValue = OpenFileDialog1.FileName


                If txtPath.EditValue Is Nothing OrElse txtPath.EditValue = "" OrElse System.IO.File.Exists(txtPath.EditValue) = False Then
                    MsgBox("Invalid file lcoation.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                SpreadsheetControl1.LoadDocument(txtPath.EditValue)
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub SelectCell(ByVal Type As Integer)
        Try
            Dim currentSelection As IList(Of Range) = SpreadsheetControl1.GetSelectedRanges()

            For Each range As Range In currentSelection

                Select Case Type
                    Case 0
                        txtAccCell.EditValue = range.LeftColumnIndex.ToString()
                        txtAccCell_A.EditValue = range.GetReferenceA1
                    Case 1
                        txtDescriptionCell.EditValue = range.LeftColumnIndex.ToString()
                        txtDescriptionCell_A.EditValue = range.GetReferenceA1
                    Case 2
                        txtAmount1Cell.EditValue = range.LeftColumnIndex.ToString()
                        txtAmount1Cell_A.EditValue = range.GetReferenceA1
                    Case 3
                        txtAmount2Cell.EditValue = range.LeftColumnIndex.ToString()
                        txtAmount2Cell_A.EditValue = range.GetReferenceA1
                End Select
            Next
           
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnAcc_Click(sender As Object, e As EventArgs) Handles btnAcc.Click
        SelectCell(0)
    End Sub

    Private Sub btnDescription_Click(sender As Object, e As EventArgs) Handles btnDescription.Click
        SelectCell(1)
    End Sub

    Private Sub btnAmount1_Click(sender As Object, e As EventArgs) Handles btnAmount1.Click
        SelectCell(2)
    End Sub

    Private Sub btnAmount2_Click(sender As Object, e As EventArgs) Handles btnAmount2.Click
        SelectCell(3)
    End Sub

    Private Sub txtPath_EditValueChanged(sender As Object, e As EventArgs) Handles txtPath.EditValueChanged

    End Sub
End Class
