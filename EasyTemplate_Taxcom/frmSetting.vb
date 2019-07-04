Public Class frmSetting
    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllowCAFooterNote.CheckedChanged
        Try
            If chkAllowCAFooterNote.Checked = True Then
                My.Settings.isAlwaysShowFooterNoteCA = True
            Else
                My.Settings.isAlwaysShowFooterNoteCA = False
            End If
            My.Settings.Save()
            My.Settings.Reload()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            chkAllowCAFooterNote.Checked = My.Settings.isAlwaysShowFooterNoteCA
        Catch ex As Exception

        End Try
    End Sub
End Class