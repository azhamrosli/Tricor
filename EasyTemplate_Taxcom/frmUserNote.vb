Public Class frmUserNote 
    Public ID As Decimal = 0
    Dim isEdit As Boolean = False
    Dim Errorlog As ClsError = Nothing
    Private Sub frmUserNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(Errorlog)
    End Sub
    Public Sub LoadData(Optional ByRef Errorlog As ClsError = Nothing)
        Try

            txtPCName.EditValue = My.Computer.Name


            Dim dt As DataTable = ADO.Load_UserNote()

            If dt Is Nothing Then
                isEdit = False
            Else
                isEdit = True
                ID = IIf(IsDBNull(dt.Rows(0)("ID")), 0, dt.Rows(0)("ID"))
                txtName.EditValue = IIf(IsDBNull(dt.Rows(0)("Name")), "", dt.Rows(0)("Name"))
                txtLastModified.EditValue = IIf(IsDBNull(dt.Rows(0)("Datetime")), "", dt.Rows(0)("Datetime"))
                txtNote.EditValue = IIf(IsDBNull(dt.Rows(0)("Note")), "", dt.Rows(0)("Note"))
            End If



        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(Errorlog)

        End Try
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            Dim tmpID As Decimal = 0
            If isEdit = True Then
                If ADO.Update_UserNote(txtName.EditValue, txtNote.EditValue, ID, Errorlog) Then
                    MsgBox("Succesfully updated note.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Unsuccesfully update note.", MsgBoxStyle.Critical)
                End If
            Else
                If ADO.Save_UserNote(txtName.EditValue, txtNote.EditValue, tmpID, Errorlog) Then
                    MsgBox("Succesfully saved note.", MsgBoxStyle.Information)
                    isEdit = True
                    ID = tmpID
                    Me.LoadData()
                Else
                    MsgBox("Unsuccesfully save note.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
End Class