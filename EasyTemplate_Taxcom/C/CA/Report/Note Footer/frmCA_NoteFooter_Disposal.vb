Public Class frmCA_NoteFooter_Disposal
    Dim clsNote As clsNote_CA = Nothing

    Dim ErrorLog As ClsError = Nothing
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public Type As Integer = 0
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

    Private Sub frmCA_NoteFooter_Disposal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            Dim dt As DataTable = Nothing

            dt = clsNote.Load_Footer_Note_Disposal(RefNo, YA, Type, ErrorLog)

            If dt Is Nothing Then
                isEdit = False
                Exit Sub
            End If

            isEdit = True
            ID = IIf(IsDBNull(dt.Rows(0)("ID")), 0, dt.Rows(0)("ID"))
            txt_CA_QUALIFYING_COST.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_QUALIFYING_COST")), "", dt.Rows(0)("CA_QUALIFYING_COST"))
            txt_DISP_DEPRECIATION.EditValue = IIf(IsDBNull(dt.Rows(0)("DISP_DEPRECIATION")), "", dt.Rows(0)("DISP_DEPRECIATION"))
            txt_DISP_WDV.EditValue = IIf(IsDBNull(dt.Rows(0)("DISP_WDV")), "", dt.Rows(0)("DISP_WDV"))
            txt_DISP_DISPOSAL_VALUE.EditValue = IIf(IsDBNull(dt.Rows(0)("DISP_DISPOSAL_VALUE")), "", dt.Rows(0)("DISP_DISPOSAL_VALUE"))
            txt_DISP_PNL.EditValue = IIf(IsDBNull(dt.Rows(0)("DISP_PNL")), "", dt.Rows(0)("DISP_PNL"))
            txt_DISP_TWDV.EditValue = IIf(IsDBNull(dt.Rows(0)("DISP_TWDV")), "", dt.Rows(0)("DISP_TWDV"))
            txt_DISP_BABC.EditValue = IIf(IsDBNull(dt.Rows(0)("DISP_BABC")), "", dt.Rows(0)("DISP_BABC"))


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txt_CA_QUALIFYING_COST.EditValue Is Nothing Then
                txt_CA_QUALIFYING_COST.EditValue = ""
            End If
            If txt_DISP_DEPRECIATION.EditValue Is Nothing Then
                txt_DISP_DEPRECIATION.EditValue = ""
            End If
            If txt_DISP_WDV.EditValue Is Nothing Then
                txt_DISP_WDV.EditValue = ""
            End If
            If txt_DISP_DISPOSAL_VALUE.EditValue Is Nothing Then
                txt_DISP_DISPOSAL_VALUE.EditValue = ""
            End If
            If txt_DISP_PNL.EditValue Is Nothing Then
                txt_DISP_PNL.EditValue = ""
            End If
            If txt_DISP_TWDV.EditValue Is Nothing Then
                txt_DISP_TWDV.EditValue = ""
            End If
            If txt_DISP_BABC.EditValue Is Nothing Then
                txt_DISP_BABC.EditValue = ""
            End If

            If isEdit Then
                If clsNote.Update_Note_Disposal(ID, RefNo, YA, Type, txt_CA_QUALIFYING_COST.EditValue,
                                                txt_DISP_DEPRECIATION.EditValue, txt_DISP_WDV.EditValue,
                                                txt_DISP_DISPOSAL_VALUE.EditValue, txt_DISP_PNL.EditValue,
                                                txt_DISP_TWDV.EditValue, txt_DISP_BABC.EditValue, ErrorLog) Then
                    Me.Close()
                Else
                    MsgBox("Unsuccesfully update note.", MsgBoxStyle.Critical)
                End If
            Else
                Dim ReturnID As Integer = 0

                If clsNote.Save_Note_Disposal(RefNo, YA, Type, txt_CA_QUALIFYING_COST.EditValue,
                                                txt_DISP_DEPRECIATION.EditValue, txt_DISP_WDV.EditValue,
                                                txt_DISP_DISPOSAL_VALUE.EditValue, txt_DISP_PNL.EditValue,
                                                txt_DISP_TWDV.EditValue, txt_DISP_BABC.EditValue, ReturnID, ErrorLog) Then
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