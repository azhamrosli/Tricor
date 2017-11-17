Public Class ucDeemedInterest
    Dim Errorlog As clsError

    Private Sub frmDeemedInterest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If mdlProcess.CreateLookUpYA(cboYA, Errorlog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Application.DoEvents()

            cboYA.EditValue = mdlProcess.ArgParam3


            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try

            Dim dt As DataTable = Nothing

            If cboYA.EditValue IsNot Nothing AndAlso IsNumeric(cboYA.EditValue) = True Then
                dt = mdlProcess.LoadDeemedInterest_Rate(CInt(cboYA.EditValue), Errorlog)
            Else
                dt = mdlProcess.LoadDeemedInterest_Rate(2015, Errorlog)
            End If


            If dt Is Nothing Then
                txtJan.EditValue = 0.0
                txtFeb.EditValue = 0.0
                txtMac.EditValue = 0.0
                txtApr.EditValue = 0.0
                txtJun.EditValue = 0.0
                txtMay.EditValue = 0.0
                txtJul.EditValue = 0.0
                txtAug.EditValue = 0.0
                txtSep.EditValue = 0.0
                txtOct.EditValue = 0.0
                txtNov.EditValue = 0.0
                txtDec.EditValue = 0.0
            Else

                txtJan.EditValue = IIf(IsDBNull(dt.Rows(0)("Jan")), 0, dt.Rows(0)("Jan"))
                txtFeb.EditValue = IIf(IsDBNull(dt.Rows(0)("Feb")), 0, dt.Rows(0)("Feb"))
                txtMac.EditValue = IIf(IsDBNull(dt.Rows(0)("Mac")), 0, dt.Rows(0)("Mac"))
                txtApr.EditValue = IIf(IsDBNull(dt.Rows(0)("Apr")), 0, dt.Rows(0)("Apr"))
                txtMay.EditValue = IIf(IsDBNull(dt.Rows(0)("May")), 0, dt.Rows(0)("May"))
                txtJun.EditValue = IIf(IsDBNull(dt.Rows(0)("Jun")), 0, dt.Rows(0)("Jun"))
                txtJul.EditValue = IIf(IsDBNull(dt.Rows(0)("Jul")), 0, dt.Rows(0)("Jul"))
                txtAug.EditValue = IIf(IsDBNull(dt.Rows(0)("Aug")), 0, dt.Rows(0)("Aug"))
                txtSep.EditValue = IIf(IsDBNull(dt.Rows(0)("Sep")), 0, dt.Rows(0)("Sep"))
                txtOct.EditValue = IIf(IsDBNull(dt.Rows(0)("Oct")), 0, dt.Rows(0)("Oct"))
                txtNov.EditValue = IIf(IsDBNull(dt.Rows(0)("Nov")), 0, dt.Rows(0)("Nov"))
                txtDec.EditValue = IIf(IsDBNull(dt.Rows(0)("Dec")), 0, dt.Rows(0)("Dec"))

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            If isValid() Then

                If mdlProcess.CheckExist_DeemedInterest(cboYA.EditValue, Errorlog) Then

                    If mdlProcess.Update_DeemedInterest_Rate(cboYA.EditValue, txtJan.EditValue, txtFeb.EditValue, txtMac.EditValue, _
                                                             txtApr.EditValue, txtMay.EditValue, txtJun.EditValue, txtJul.EditValue, _
                                                             txtAug.EditValue, txtSep.EditValue, txtOct.EditValue, txtNov.EditValue, _
                                                             txtDec.EditValue, Errorlog) Then
                        MsgBox("Successfully updated deemed interest.", MsgBoxStyle.Information)
                    Else
                        MsgBox("Unsuccessfully update deemed interest.", MsgBoxStyle.Information)
                    End If
                Else
                    If mdlProcess.Save_DeemedInterest_Rate(cboYA.EditValue, txtJan.EditValue, txtFeb.EditValue, txtMac.EditValue, _
                                                           txtApr.EditValue, txtMay.EditValue, txtJun.EditValue, txtJul.EditValue, _
                                                           txtAug.EditValue, txtSep.EditValue, txtOct.EditValue, txtNov.EditValue, _
                                                           txtDec.EditValue, Errorlog) Then
                        MsgBox("Successfully saved deemed interest.", MsgBoxStyle.Information)
                    Else
                        MsgBox("Unsuccessfully save deemed interest.", MsgBoxStyle.Information)
                    End If

                End If

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Function isValid() As Boolean
        Try
            If cboYA.EditValue Is Nothing OrElse cboYA.EditValue.ToString = "" Then
                MsgBox("Please select year assessment.", MsgBoxStyle.Exclamation)
                cboYA.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function

    Private Sub cboYA_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboYA.SelectedValueChanged
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub

End Class
