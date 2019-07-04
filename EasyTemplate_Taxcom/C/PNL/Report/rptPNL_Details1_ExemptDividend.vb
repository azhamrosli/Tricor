Public Class rptPNL_Details1_ExemptDividend
    Dim errorLog As ClsError = Nothing
    Private Sub lblGroupTotal_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblGroupTotal.BeforePrint, TotalSourceNo.BeforePrint, lineGrandTotal_PLFST_SALES_Top.BeforePrint
        Try
            If Me.paramKeyName.Value = "REALFETRADE" Then
                Dim x As String = Nothing
            End If
            Dim dt As DataTable = ADO.Load_PROFIT_LOSS_ACCOUNT_REPORT_SOURCE_COUNT(Me.paramID.Value, Me.paramKeyName.Value, Nothing)

            Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()
            If dt IsNot Nothing AndAlso Me.Report.RowCount > 1 Then
                If dt.Rows.Count <= 1 Then
                    lblGroupTotal.Visible = False
                    TotalSourceNo.Visible = False
                    ' SubBand2.Visible = False
                    lineGrandTotal_PLFST_SALES_Top.Visible = True
                Else
                    Dim CurrentIndex As Integer = -1
                    For Each rowx As DataRow In dt.Rows
                        CurrentIndex += 1
                        If IsDBNull(rowx("SOURCE_NO")) = False AndAlso IsDBNull(rowx("COUNTX")) = False Then
                            If rowx("SOURCE_NO") = Me.GetCurrentColumnValue("SOURCE_NO") Then
                                If CInt(rowx("COUNTX")) > 1 Then
                                    ' SubBand2.Visible = False
                                    ' GroupFooter1.HeightF = 32.9999924
                                    lblGroupTotal.Visible = True
                                    TotalSourceNo.Visible = True

                                    If (dt.Rows.Count - 1) = CurrentIndex Then
                                        lineGrandTotal_PLFST_SALES_Top.Visible = False
                                    End If

                                Else
                                    lblGroupTotal.Visible = False
                                    TotalSourceNo.Visible = False
                                    ' SubBand2.Visible = True

                                    If (dt.Rows.Count - 1) = CurrentIndex Then
                                        lineGrandTotal_PLFST_SALES_Top.Visible = True
                                    End If

                                    ' GroupFooter1.HeightF = 10
                                End If
                            End If
                        End If
                    Next
                End If

            Else
                TotalSourceNo.Visible = False
                lblGroupTotal.Visible = False
                If dtRow IsNot Nothing Then
                    If dtRow.Row.GetChildRows("FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB").Count > 0 Then
                        lineGrandTotal_PLFST_SALES_Top.Visible = True
                    Else
                        lineGrandTotal_PLFST_SALES_Top.Visible = False
                    End If

                    ' GroupFooter1.HeightF = 32.9999924
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If

            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
        End Try
    End Sub

End Class