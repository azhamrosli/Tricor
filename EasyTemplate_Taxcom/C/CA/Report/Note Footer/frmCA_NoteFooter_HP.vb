Public Class frmCA_NoteFooter_HP
    Dim clsNote As clsNote_CA = Nothing

    Dim ErrorLog As ClsError = Nothing
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Dim ID As Integer = 0
    Dim isEdit As Boolean = False

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If clsNote Is Nothing Then
            clsNote = New clsNote_CA
        End If
    End Sub
    Private Sub frmCA_NoteFooter_HP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            Dim dt As DataTable = Nothing

            dt = clsNote.Load_Footer_Note_HP(RefNo, YA, ErrorLog)

            If dt Is Nothing Then
                isEdit = False
                Exit Sub
            End If

            isEdit = True
            ID = IIf(IsDBNull(dt.Rows(0)("ID")), 0, dt.Rows(0)("ID"))
            txt_BF_PRINCIPAL.EditValue = IIf(IsDBNull(dt.Rows(0)("BF_PRINCIPAL")), "", dt.Rows(0)("BF_PRINCIPAL"))
            txt_BF_INTEREST.EditValue = IIf(IsDBNull(dt.Rows(0)("BF_INTEREST")), "", dt.Rows(0)("BF_INTEREST"))
            txt_CURR_PRINCIPAL.EditValue = IIf(IsDBNull(dt.Rows(0)("CURR_PRINCIPAL")), "", dt.Rows(0)("CURR_PRINCIPAL"))
            txt_CURR_INTEREST.EditValue = IIf(IsDBNull(dt.Rows(0)("CURR_INTEREST")), "", dt.Rows(0)("CURR_INTEREST"))
            txt_CF_PRINCIPAL.EditValue = IIf(IsDBNull(dt.Rows(0)("CF_PRINCIPAL")), "", dt.Rows(0)("CF_PRINCIPAL"))
            txt_CF_INTEREST.EditValue = IIf(IsDBNull(dt.Rows(0)("CF_INTEREST")), "", dt.Rows(0)("CF_INTEREST"))


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txt_BF_PRINCIPAL.EditValue Is Nothing Then
                txt_BF_PRINCIPAL.EditValue = ""
            End If
            If txt_BF_INTEREST.EditValue Is Nothing Then
                txt_BF_INTEREST.EditValue = ""
            End If
            If txt_CURR_PRINCIPAL.EditValue Is Nothing Then
                txt_CURR_PRINCIPAL.EditValue = ""
            End If
            If txt_CURR_INTEREST.EditValue Is Nothing Then
                txt_CURR_INTEREST.EditValue = ""
            End If
            If txt_CF_PRINCIPAL.EditValue Is Nothing Then
                txt_CF_PRINCIPAL.EditValue = ""
            End If
            If txt_CF_INTEREST.EditValue Is Nothing Then
                txt_CF_INTEREST.EditValue = ""
            End If

            If isEdit Then
                If clsNote.Update_Note_HP(ID, RefNo, YA, txt_BF_PRINCIPAL.EditValue,
                                                txt_BF_INTEREST.EditValue, txt_CURR_PRINCIPAL.EditValue,
                                                txt_CURR_INTEREST.EditValue, txt_CF_PRINCIPAL.EditValue,
                                                txt_CF_INTEREST.EditValue, ErrorLog) Then
                    Me.Close()
                Else
                    MsgBox("Unsuccesfully update note.", MsgBoxStyle.Critical)
                End If
            Else
                Dim ReturnID As Integer = 0

                If clsNote.Save_Note_HP(RefNo, YA, txt_BF_PRINCIPAL.EditValue,
                                                txt_BF_INTEREST.EditValue, txt_CURR_PRINCIPAL.EditValue,
                                                txt_CURR_INTEREST.EditValue, txt_CF_PRINCIPAL.EditValue,
                                                txt_CF_INTEREST.EditValue, ReturnID, ErrorLog) Then
                    Me.Close()
                Else
                    MsgBox("Unsuccesfully save note.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class