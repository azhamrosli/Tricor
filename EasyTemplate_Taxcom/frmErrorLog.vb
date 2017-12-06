Imports DevExpress.XtraPrinting

Public Class frmErrorLog

    Private Sub frmErrorLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If dsDataSetErrorlog Is Nothing Then
                dsDataSetErrorlog = New dsDefault
            End If

            DtErrorLogBindingSource.DataSource = dsDataSetErrorlog.Tables("dtErrorLog")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Try
            Dim rlst As DialogResult = FolderBrowserDialog1.ShowDialog

            If rlst = Windows.Forms.DialogResult.OK Then
                grdErrorLog.ExportToXlsx(FolderBrowserDialog1.SelectedPath & "\TaxcomErrorLog_" & Format(Now, "ddMMMyyyyHHmmss") & ".xlsx")
                MsgBox("Sucessfully export errorlog to excel.", MsgBoxStyle.Information)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Try
            DsDefault.Tables("dtErrorLog").Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Try
            Dim link As New PrintableComponentLink(New PrintingSystem())

            link.Component = grdErrorLog

            link.Landscape = True

            link.ShowPreview()
        Catch ex As Exception

        End Try
    End Sub
End Class