Public Class frmCA_NoteFooter_ControlTransfer_In
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
    Private Sub frmCA_NoteFooter_ControlTransfer_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            Dim dt As DataTable = Nothing

            dt = clsNote.Load_Footer_Note_ControlTransfer_IN(RefNo, YA, ErrorLog)

            If dt Is Nothing Then
                isEdit = False
                Exit Sub
            End If

            isEdit = True
            ID = IIf(IsDBNull(dt.Rows(0)("ID")), 0, dt.Rows(0)("ID"))
            txt_CA_PURCHASE_AMOUNT.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_PURCHASE_AMOUNT")), "", dt.Rows(0)("CA_PURCHASE_AMOUNT"))
            txt_TWDV_BF.EditValue = IIf(IsDBNull(dt.Rows(0)("TWDV_BF")), "", dt.Rows(0)("TWDV_BF"))
            txt_CA_TRANSFER_VAL.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_TRANSFER_VAL")), "", dt.Rows(0)("CA_TRANSFER_VAL"))


        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txt_CA_PURCHASE_AMOUNT.EditValue Is Nothing Then
                txt_CA_PURCHASE_AMOUNT.EditValue = ""
            End If
            If txt_TWDV_BF.EditValue Is Nothing Then
                txt_TWDV_BF.EditValue = ""
            End If
            If txt_CA_TRANSFER_VAL.EditValue Is Nothing Then
                txt_CA_TRANSFER_VAL.EditValue = ""
            End If

            If isEdit Then
                If clsNote.Update_Note_ControlTransfer_IN(ID, RefNo, YA, txt_CA_PURCHASE_AMOUNT.EditValue, txt_TWDV_BF.EditValue,
                                                          txt_CA_TRANSFER_VAL.EditValue, ErrorLog) Then
                    Me.Close()
                Else
                    MsgBox("Unsuccesfully update note.", MsgBoxStyle.Critical)
                End If
            Else
                Dim ReturnID As Integer = 0

                If clsNote.Save_Note_ControlTransfer_IN(RefNo, YA, txt_CA_PURCHASE_AMOUNT.EditValue, txt_TWDV_BF.EditValue,
                                                        txt_CA_TRANSFER_VAL.EditValue, ReturnID, ErrorLog) Then
                    MsgBox("Succesfully saved note.", MsgBoxStyle.Information)
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