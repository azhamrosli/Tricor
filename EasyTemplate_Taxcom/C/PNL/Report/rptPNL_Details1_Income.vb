Public Class rptPNL_Details1_Income
    Dim TotalCount As Integer = 0
    Dim CurrentSourceNo As String = ""
    Dim ErrorLog As ClsError
    Private Sub lblAmount2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblAmount.BeforePrint
        Try
            Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()

            If dtRow IsNot Nothing Then

                If dtRow.Row.GetChildRows("FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB").Count > 0 Then
                    lblAmount.Visible = False
                Else
                    lblAmount.Visible = True
                End If
            End If

            If Me.Report.RowCount = 1 Then
                lblAmount.Font = New Font("Arial", 9.75, FontStyle.Bold)
            Else
                lblAmount.Font = New Font("Arial", 9.75, FontStyle.Regular)
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
    Private Sub lblAmount_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblAmount_Total.BeforePrint, lineGrandTotal_PLFST_SALES.BeforePrint
        Try
            Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()
            If Me.Report.RowCount > 1 Then
                lblAmount_Total.Visible = True
                lineGrandTotal_PLFST_SALES.Visible = True
                lblGroupTotal.Visible = True
                ' lineGrandTotal_PLFST_SALES_Top.Visible = True
            Else
                If dtRow IsNot Nothing AndAlso dtRow.Row IsNot Nothing Then

                    If dtRow.Row.GetChildRows("FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB").Count > 0 Or Me.Report.RowCount > 1 Then
                        lblAmount_Total.Visible = True
                        lineGrandTotal_PLFST_SALES.Visible = True
                        '  lineGrandTotal_PLFST_SALES_Top.Visible = True
                        lblGroupTotal.Visible = False
                    Else
                        lblAmount_Total.Visible = False
                        lineGrandTotal_PLFST_SALES.Visible = False
                        lblGroupTotal.Visible = True
                        '  lineGrandTotal_PLFST_SALES_Top.Visible = False
                    End If
                Else
                    If Me.Report.RowCount > 1 Then
                        lblAmount_Total.Visible = True
                        lineGrandTotal_PLFST_SALES.Visible = True
                        lblGroupTotal.Visible = True
                        '  lineGrandTotal_PLFST_SALES_Top.Visible = True
                    Else
                        lblAmount_Total.Visible = False
                        '  lineup.Visible = False
                        lineGrandTotal_PLFST_SALES.Visible = False
                        lblGroupTotal.Visible = False
                        '  lineGrandTotal_PLFST_SALES_Top.Visible = False
                    End If
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
        Finally
            Application.DoEvents()
        End Try
    End Sub
    'Private Sub lineup_BeforePrint1(sender As Object, e As Printing.PrintEventArgs) Handles SubBand2.BeforePrint
    '    Try
    '        SubBand2.HeightF = 0
    '        Application.DoEvents()
    '        Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()

    '        If dtRow IsNot Nothing Then

    '            If dtRow.Row.GetChildRows("FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB").Count > 0 Then
    '                lineup.Visible = False
    '            Else
    '                If Me.Report.RowCount > 1 Then
    '                    lineup.Visible = False
    '                Else
    '                    lineup.Visible = True
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '    Finally
    '        Application.DoEvents()
    '    End Try
    'End Sub
    'Private Sub lineup_BeforePrint1(sender As Object, e As Printing.PrintEventArgs) Handles SubBand2.BeforePrint
    '    Try
    '        Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()

    '        If dtRow IsNot Nothing Then

    '            If dtRow.Row.GetChildRows("FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB").Count > 0 Then
    '                lineup.Visible = False
    '            Else
    '                If Me.Report.RowCount > 1 Then
    '                    lineup.Visible = False

    '                Else
    '                    lineup.Visible = True

    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '    Finally
    '        Application.DoEvents()
    '    End Try
    'End Sub

    'Private Sub ReportFooter_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles ReportFooter.BeforePrint
    '    Try
    '        If Me.Report.RowCount > 1 Then
    '            ReportFooter.Visible = True
    '        Else
    '            Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()

    '            If dtRow IsNot Nothing Then

    '                If dtRow.Row.GetChildRows("FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB").Count > 0 Or Me.Report.RowCount > 1 Then
    '                    ReportFooter.Visible = True
    '                Else
    '                    ReportFooter.Visible = False
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub rpt_Note_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles rpt_Note.BeforePrint
    '    Try
    '        Me.rpt_Note.Report.DataSource = Me.DsPNL_Report1
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub lblGroupTotal_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblGroupTotal.BeforePrint, GroupFooter1.BeforePrint, lineGrandTotal_PLFST_SALES_Top.BeforePrint
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
    Private Sub lineup_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lineup.BeforePrint, SubBand2.BeforePrint
        Try
            If Me.paramKeyName.Value = "DEPRECIATION" Then
                Dim x As String = Nothing
            End If
            Dim Dummy As Boolean = False
            Dim dt As DataTable = ADO.Load_PROFIT_LOSS_ACCOUNT_REPORT_SOURCE_COUNT(Me.paramID.Value, Me.paramKeyName.Value, Nothing)
            Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()
            If dt IsNot Nothing AndAlso Me.Report.RowCount > 1 Then
                If dt.Rows.Count <= 1 Then
                    ' SubBand2.Visible = False
                    Dummy = False
                Else
                    Dim CurrentIndex As Integer = -1
                    For Each rowx As DataRow In dt.Rows
                        CurrentIndex += 1
                        If IsDBNull(rowx("SOURCE_NO")) = False AndAlso IsDBNull(rowx("COUNTX")) = False Then
                            If rowx("SOURCE_NO") = Me.GetCurrentColumnValue("SOURCE_NO") Then
                                If CInt(rowx("COUNTX")) > 1 Then
                                    'SubBand2.Visible = False
                                    Dummy = False
                                Else
                                    If dtRow IsNot Nothing Then
                                        If dtRow.Row.GetChildRows("FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB").Count > 0 Then
                                            '  SubBand2.Visible = False
                                            Dummy = False
                                        Else
                                            If Me.Report.RowCount > 1 Then
                                                ' SubBand2.Visible = False
                                                Dummy = False
                                            Else
                                                ' SubBand2.Visible = True
                                                Dummy = True
                                            End If
                                        End If
                                    End If

                                End If
                            End If
                        End If
                    Next
                End If
            Else
                If dtRow IsNot Nothing Then

                    If dtRow.Row.GetChildRows("FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB").Count > 0 Then
                        'SubBand2.Visible = False
                        Dummy = False
                    Else
                        If Me.Report.RowCount > 1 Then
                            '  SubBand2.Visible = False
                            Dummy = False
                        Else
                            '    SubBand2.Visible = True
                            Dummy = True
                        End If
                    End If
                End If
            End If

            If dtRow IsNot Nothing AndAlso IsNumeric(dtRow("PECENTAGE_AMOUNT")) AndAlso
                CDec(dtRow("PECENTAGE_AMOUNT")) > 0 Then
                lineup.SizeF = New SizeF(178.07, 6.67)
            Else
                lineup.SizeF = New SizeF(89.04, 6.67)
            End If
            lineup.Visible = Dummy
            Application.DoEvents()
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