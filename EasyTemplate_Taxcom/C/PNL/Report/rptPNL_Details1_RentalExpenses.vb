Imports DevExpress.XtraRichEdit

Public Class rptPNL_Details1_RentalExpenses
    Dim TotalCount As Integer = 0
    Dim errorLog As ClsError = Nothing
    Private Sub Detail_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint

    End Sub

    Private Sub lblAmount_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles lblAmount.BeforePrint
        Try
            Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()

            If dtRow IsNot Nothing Then

                If dtRow.Row.GetChildRows("FK_EXPENSES_RENTAL_EXPENSES_RENTAL_DETAIL").Count > 0 Then
                    lblAmount.Visible = False
                    lblPercentage.Visible = False
                Else
                    lblAmount.Visible = True
                    lblPercentage.Visible = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblAmount_Total_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles lblAmount_Total.BeforePrint, lineGrandTotal_PLFST_SALES_Top.BeforePrint, lineGrandTotal_PLFST_SALES.BeforePrint, lblPercentage_Total.BeforePrint
        Try
            If Me.Report.RowCount > 1 Then
                lblAmount_Total.Visible = True
                lblPercentage_Total.Visible = True
                lineGrandTotal_PLFST_SALES.Visible = True
                'lineGrandTotal_PLFST_SALES_Top.Visible = True
            Else
                Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()

                If dtRow IsNot Nothing AndAlso dtRow.Row IsNot Nothing Then

                    'If dtRow.Row.GetChildRows("FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB").Count > 0 Or Me.Report.RowCount > 1 Then
                    If dtRow.Row.GetChildRows("FK_EXPENSES_RENTAL_EXPENSES_RENTAL_DETAIL").Count > 0 Or Me.Report.RowCount > 1 Then
                        lblAmount_Total.Visible = True
                        lblPercentage_Total.Visible = True
                        lineGrandTotal_PLFST_SALES.Visible = True
                        ' lineGrandTotal_PLFST_SALES_Top.Visible = True
                    Else
                        lblAmount_Total.Visible = False
                        lblPercentage_Total.Visible = False
                        lineGrandTotal_PLFST_SALES.Visible = False
                        ' lineGrandTotal_PLFST_SALES_Top.Visible = False
                    End If
                Else
                    If Me.Report.RowCount > 1 Then
                        lblAmount_Total.Visible = True
                        lblPercentage_Total.Visible = True
                        lineGrandTotal_PLFST_SALES.Visible = True
                        '  lineGrandTotal_PLFST_SALES_Top.Visible = True
                    Else
                        lblAmount_Total.Visible = False
                        lblPercentage_Total.Visible = False
                        lineGrandTotal_PLFST_SALES.Visible = False
                        '  lineGrandTotal_PLFST_SALES_Top.Visible = False
                    End If
                End If
            End If

            If lblPercentage_Total.Text = " " Then
                '  lineGrandTotal_PLFST_SALES_Top.SizeF = New SizeF(89.04, 2.08)
                lineGrandTotal_PLFST_SALES.SizeF = New SizeF(89.04, 6.67)
            Else
                '   lineGrandTotal_PLFST_SALES_Top.SizeF = New SizeF(178.07, 2.08)
                lineGrandTotal_PLFST_SALES.SizeF = New SizeF(178.07, 6.67)
            End If
        Catch ex As Exception

        Finally
            Application.DoEvents()
        End Try
    End Sub
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

    Private Sub lblPercentage_Title_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles lblPercentage_Title.BeforePrint, lblPercentage_RM.BeforePrint
        Try
            If Me.GetCurrentColumnValue("TOTAL_PECENTAGE") = 0 Then
                lblPercentage_Title.Visible = False
                lblPercentage_RM.Visible = False
            Else
                lblPercentage_Title.Visible = True
                lblPercentage_RM.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub XrRichText1_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles XrRichText1.BeforePrint, XrRichText2.BeforePrint, XrRichText3.BeforePrint, XrRichText4.BeforePrint, XrRichText5.BeforePrint
        Try
            Dim obj As DevExpress.XtraReports.UI.XRRichText = Nothing

            If TypeOf sender Is DevExpress.XtraReports.UI.XRRichText Then
                obj = CType(sender, DevExpress.XtraReports.UI.XRRichText)
            Else
                Exit Sub
            End If

            Using docServer As RichEditDocumentServer = New RichEditDocumentServer()
                docServer.RtfText = obj.Rtf
                docServer.Document.DefaultCharacterProperties.FontName = "Arial"
                docServer.Document.DefaultCharacterProperties.FontSize = 9.75
                obj.Rtf = docServer.RtfText
            End Using
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblGroupTotal_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles lblGroupTotal.BeforePrint, TotalSourceNo.BeforePrint,
         lblGroupTotal_Percent.BeforePrint, lineGrandTotal_PLFST_SALES_Top.BeforePrint
        Try
            If Me.paramKeyName.Value = "DEPRECIATION" Then
                Dim x As String = Nothing
            End If

            Dim dt As DataTable = ADO.Load_PROFIT_LOSS_ACCOUNT_REPORT_SOURCE_COUNT(Me.paramID.Value, Me.paramKeyName.Value, Nothing)
            Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()
            If dt IsNot Nothing AndAlso Me.Report.RowCount > 1 Then
                If dt.Rows.Count <= 1 Then

                    ' SubBand2.Visible = False
                    lblGroupTotal.Visible = False
                    lblGroupTotal_Percent.Visible = False
                    TotalSourceNo.Visible = False
                    lineGrandTotal_PLFST_SALES_Top.Visible = True
                    If lblPercentage_Total.Text = " " Then
                        lineGrandTotal_PLFST_SALES_Top.SizeF = New SizeF(89.04, 2.08)
                    Else
                        lineGrandTotal_PLFST_SALES_Top.SizeF = New SizeF(178.07, 2.08)
                    End If

                Else
                    Dim CurrentIndex As Integer = -1
                    For Each rowx As DataRow In dt.Rows
                        CurrentIndex += 1
                        If IsDBNull(rowx("SOURCE_NO")) = False AndAlso IsDBNull(rowx("COUNTX")) = False Then
                            If rowx("SOURCE_NO") = Me.GetCurrentColumnValue("SOURCE_NO") Then
                                If CInt(rowx("COUNTX")) > 1 Then
                                    '   SubBand2.Visible = False

                                    lblGroupTotal.Visible = True
                                    TotalSourceNo.Visible = True

                                    If (dt.Rows.Count - 1) = CurrentIndex Then
                                        lineGrandTotal_PLFST_SALES_Top.Visible = False
                                        If lblPercentage_Total.Text = " " Then
                                            lineGrandTotal_PLFST_SALES_Top.SizeF = New SizeF(89.04, 2.08)
                                        Else
                                            lineGrandTotal_PLFST_SALES_Top.SizeF = New SizeF(178.07, 2.08)
                                        End If
                                    End If

                                    ' GroupFooter1.HeightF = 32.9999924
                                    If IsDBNull(rowx("SUMX")) = False AndAlso rowx("SUMX") > 0 Then
                                        lblGroupTotal_Percent.Visible = True
                                    Else
                                        lblGroupTotal_Percent.Visible = False
                                    End If

                                Else
                                    lblGroupTotal.Visible = False
                                    lblGroupTotal_Percent.Visible = False
                                    TotalSourceNo.Visible = False
                                    'SubBand2.Visible = Truetk
                                    ' GroupFooter1.HeightF = 10                                

                                    If (dt.Rows.Count - 1) = CurrentIndex Then
                                        lineGrandTotal_PLFST_SALES_Top.Visible = True
                                        If lblPercentage_Total.Text = " " Then
                                            lineGrandTotal_PLFST_SALES_Top.SizeF = New SizeF(89.04, 2.08)
                                        Else
                                            lineGrandTotal_PLFST_SALES_Top.SizeF = New SizeF(178.07, 2.08)
                                        End If
                                    End If
                                    lblGroupTotal_Percent.Visible = False
                                End If
                            End If
                        End If
                    Next
                End If
            Else
                TotalSourceNo.Visible = False
                lblGroupTotal.Visible = False
                If dtRow IsNot Nothing Then
                    If dtRow.Row.GetChildRows("FK_EXPENSES_RENTAL_EXPENSES_RENTAL_DETAIL").Count > 0 Then
                        lineGrandTotal_PLFST_SALES_Top.Visible = True
                    Else
                        lineGrandTotal_PLFST_SALES_Top.Visible = False
                    End If

                    ' GroupFooter1.HeightF = 32.9999924
                End If

            End If

            If dtRow IsNot Nothing AndAlso IsNumeric(dtRow("PecentageAmount")) AndAlso
                CDec(dtRow("PecentageAmount")) > 0 Then
                lineup.SizeF = New SizeF(178.07, 6.67)
            Else
                lineup.SizeF = New SizeF(89.04, 6.67)
            End If

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
    Private Sub lineup_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles lineup.BeforePrint, SubBand2.BeforePrint
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
                                        If dtRow.Row.GetChildRows("FK_EXPENSES_RENTAL_EXPENSES_RENTAL_DETAIL").Count > 0 Then
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

                    If dtRow.Row.GetChildRows("FK_EXPENSES_RENTAL_EXPENSES_RENTAL_DETAIL").Count > 0 Then
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

            If dtRow IsNot Nothing AndAlso IsNumeric(dtRow("PecentageAmount")) AndAlso
                CDec(dtRow("PecentageAmount")) > 0 Then
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