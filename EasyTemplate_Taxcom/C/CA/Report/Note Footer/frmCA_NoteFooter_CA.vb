Public Class frmCA_NoteFooter_CA
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
    Private Sub frmCA_NoteFooter_CA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            Dim dt As DataTable = Nothing

            dt = clsNote.Load_Footer_Note_CA(RefNo, YA, ErrorLog)

            If dt Is Nothing Then
                isEdit = False
                Exit Sub
            End If

            isEdit = True
            ID = IIf(IsDBNull(dt.Rows(0)("ID")), 0, dt.Rows(0)("ID"))
            txt_QC_BF.EditValue = IIf(IsDBNull(dt.Rows(0)("QC_BF")), "", dt.Rows(0)("QC_BF"))
            txt_QC_ADD.EditValue = IIf(IsDBNull(dt.Rows(0)("QC_ADD")), "", dt.Rows(0)("QC_ADD"))
            txt_QC_DISP.EditValue = IIf(IsDBNull(dt.Rows(0)("QC_DISP")), "", dt.Rows(0)("QC_DISP"))
            txt_QC_CF.EditValue = IIf(IsDBNull(dt.Rows(0)("QC_CF")), "", dt.Rows(0)("QC_CF"))
            txt_TWDV_BF.EditValue = IIf(IsDBNull(dt.Rows(0)("TWDV_BF")), "", dt.Rows(0)("TWDV_BF"))
            txt_TWDV_ADD.EditValue = IIf(IsDBNull(dt.Rows(0)("TWDV_ADD")), "", dt.Rows(0)("TWDV_ADD"))
            txt_TWDV_DISP.EditValue = IIf(IsDBNull(dt.Rows(0)("TWDV_DISP")), "", dt.Rows(0)("TWDV_DISP"))
            txt_TWDV_TOTAL.EditValue = IIf(IsDBNull(dt.Rows(0)("TWDV_TOTAL")), "", dt.Rows(0)("TWDV_TOTAL"))
            txt_TWDV_ADD.EditValue = IIf(IsDBNull(dt.Rows(0)("TWDV_ADD")), "", dt.Rows(0)("TWDV_ADD"))
            txt_TWDV_AI.EditValue = IIf(IsDBNull(dt.Rows(0)("TWDV_AI")), "", dt.Rows(0)("TWDV_AI"))
            txt_TWDV_AA.EditValue = IIf(IsDBNull(dt.Rows(0)("TWDV_AA")), "", dt.Rows(0)("TWDV_AA"))
            txt_TWDV_CF.EditValue = IIf(IsDBNull(dt.Rows(0)("TWDV_CF")), "", dt.Rows(0)("TWDV_CF"))


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txt_QC_BF.EditValue Is Nothing Then
                txt_QC_BF.EditValue = ""
            End If
            If txt_QC_ADD.EditValue Is Nothing Then
                txt_QC_ADD.EditValue = ""
            End If
            If txt_QC_DISP.EditValue Is Nothing Then
                txt_QC_DISP.EditValue = ""
            End If
            If txt_QC_CF.EditValue Is Nothing Then
                txt_QC_CF.EditValue = ""
            End If
            If txt_TWDV_BF.EditValue Is Nothing Then
                txt_TWDV_BF.EditValue = ""
            End If
            If txt_TWDV_ADD.EditValue Is Nothing Then
                txt_TWDV_ADD.EditValue = ""
            End If
            If txt_TWDV_DISP.EditValue Is Nothing Then
                txt_TWDV_DISP.EditValue = ""
            End If
            If txt_TWDV_TOTAL.EditValue Is Nothing Then
                txt_TWDV_TOTAL.EditValue = ""
            End If
            If txt_TWDV_AI.EditValue Is Nothing Then
                txt_TWDV_AI.EditValue = ""
            End If
            If txt_TWDV_AA.EditValue Is Nothing Then
                txt_TWDV_AA.EditValue = ""
            End If
            If txt_TWDV_CF.EditValue Is Nothing Then
                txt_TWDV_CF.EditValue = ""
            End If

            If isEdit Then
                If clsNote.Update_Note_CA(ID, RefNo, YA, txt_QC_BF.EditValue,
                                                txt_QC_ADD.EditValue, txt_QC_DISP.EditValue,
                                                txt_QC_CF.EditValue, txt_TWDV_BF.EditValue,
                                                txt_TWDV_ADD.EditValue,
                                                txt_TWDV_DISP.EditValue, txt_TWDV_TOTAL.EditValue,
                                                txt_TWDV_AI.EditValue, txt_TWDV_AA.EditValue, txt_TWDV_CF.EditValue, ErrorLog) Then
                    Me.Close()
                Else
                    MsgBox("Unsuccesfully update note.", MsgBoxStyle.Critical)
                End If
            Else
                Dim ReturnID As Integer = 0

                If clsNote.Save_Note_CA(RefNo, YA, txt_QC_BF.EditValue,
                                                txt_QC_ADD.EditValue, txt_QC_DISP.EditValue,
                                                txt_QC_CF.EditValue, txt_TWDV_BF.EditValue,
                                                txt_TWDV_ADD.EditValue,
                                                txt_TWDV_DISP.EditValue, txt_TWDV_TOTAL.EditValue,
                                                txt_TWDV_AI.EditValue, txt_TWDV_AA.EditValue, txt_TWDV_CF.EditValue,
                                                ReturnID, ErrorLog) Then
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