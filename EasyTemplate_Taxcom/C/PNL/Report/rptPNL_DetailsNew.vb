Public Class rptPNL_DetailsNew
    Dim ErrorLog As ClsError
    Private Sub XrSubreport1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubrptPNL_Details1_Income.BeforePrint
        Try
            If Me.GetCurrentColumnValue("Type") = 1 Then
                Select Case Me.GetCurrentColumnValue("KeyName")
                    Case "DIVIDENDINC", "RENTALINC", "EXEMDIV"
                        SubrptPNL_Details1_Income.Visible = False
                    Case "REALFETRADE"
                        SubrptPNL_Details1_Income.Visible = True
                    Case Else
                        SubrptPNL_Details1_Income.Visible = True
                End Select

            Else
                SubrptPNL_Details1_Income.Visible = False
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
    Private Sub XrSubreport2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubrptPNL_Details1_Expenses.BeforePrint
        Try
            If Me.GetCurrentColumnValue("Type") <> 1 Then

                If IsDBNull(Me.GetCurrentColumnValue("Sch")) = False AndAlso Me.GetCurrentColumnValue("Sch") <> " " Then
                    Select Case Me.GetCurrentColumnValue("KeyName")
                        Case "EXPRENTAL"
                            SubrptPNL_Details1_Expenses.Visible = False
                        Case "PURCHASE"
                            SubrptPNL_Details1_Expenses.Visible = True
                        Case Else
                            SubrptPNL_Details1_Expenses.Visible = True
                    End Select

                Else
                    SubrptPNL_Details1_Expenses.Visible = False
                End If

            Else
                SubrptPNL_Details1_Expenses.Visible = False
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
    Private Sub XrSubreport4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubrptPNL_Details_DividendIncome.BeforePrint
        Try
            If Me.GetCurrentColumnValue("KeyName") = "DIVIDENDINC" Then
                Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()

                If dtRow IsNot Nothing AndAlso dtRow.Row IsNot Nothing Then
                    If dtRow.Row.GetChildRows("FK_DIVIDEND_INCOME").Count > 0 Then
                        SubrptPNL_Details_DividendIncome.Visible = True
                    Else
                        SubrptPNL_Details_DividendIncome.Visible = False
                    End If
                End If
            Else
                SubrptPNL_Details_DividendIncome.Visible = False
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

    Private Sub XrSubreport5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubrptPNL_Details1_RentalIncome.BeforePrint
        Try
            If Me.GetCurrentColumnValue("KeyName") = "RENTALINC" Then
                Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()

                If dtRow IsNot Nothing AndAlso dtRow.Row IsNot Nothing Then
                    If dtRow.Row.GetChildRows("FK_RENTAL_INCOME").Count > 0 Then
                        SubrptPNL_Details1_RentalIncome.Visible = True
                    Else
                        SubrptPNL_Details1_RentalIncome.Visible = False
                    End If
                End If
            Else
                SubrptPNL_Details1_RentalIncome.Visible = False
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
    Private Sub XrSubreport6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubrptPNL_Details1_ExemptDividend.BeforePrint
        Try
            If Me.GetCurrentColumnValue("KeyName") = "EXEMDIV" Then
                Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()

                If dtRow IsNot Nothing AndAlso dtRow.Row IsNot Nothing Then
                    If dtRow.Row.GetChildRows("FK_EXEMPT_DIVIDEND").Count > 0 Then
                        SubrptPNL_Details1_ExemptDividend.Visible = True
                    Else
                        SubrptPNL_Details1_ExemptDividend.Visible = False
                    End If
                End If
            Else
                SubrptPNL_Details1_ExemptDividend.Visible = False
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
    Private Sub XrSubreport7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubrptPNL_Details1_RentalExpenses.BeforePrint
        Try
            If IsDBNull(Me.GetCurrentColumnValue("Sch")) = False AndAlso Me.GetCurrentColumnValue("Sch") <> " " Then
                Select Case Me.GetCurrentColumnValue("KeyName")
                    Case "EXPRENTAL"
                        Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()

                        If dtRow IsNot Nothing AndAlso dtRow.Row IsNot Nothing Then
                            If dtRow.Row.GetChildRows("FK_EXPENSES_RENTAL").Count > 0 Then
                                SubrptPNL_Details1_RentalExpenses.Visible = True
                            Else
                                SubrptPNL_Details1_RentalExpenses.Visible = False
                            End If
                        End If
                    Case Else
                        SubrptPNL_Details1_RentalExpenses.Visible = False
                End Select

            Else
                SubrptPNL_Details1_RentalExpenses.Visible = False
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
    Private Sub rpt_Note_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubrptPNL_NoteNew.BeforePrint
        Try
            Dim KeyName As String = Me.GetCurrentColumnValue("KeyName")
            If KeyName = "EXPSALARY" Then
                Dim x As String = Nothing
            End If
            If KeyName <> "" Then
                Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()

                If dtRow IsNot Nothing AndAlso dtRow.Row IsNot Nothing Then
                    If dtRow.Row.GetChildRows("FK_NOTE").Count > 0 Then
                        SubrptPNL_NoteNew.Visible = True
                    Else
                        SubrptPNL_NoteNew.Visible = False
                    End If
                End If
            Else
                SubrptPNL_NoteNew.Visible = False
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

    Private Sub XrLabel4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubPNLInfo_KEYName.BeforePrint
        Try
            Dim KeyName As String = Me.GetCurrentColumnValue("KeyName")

            If KeyName <> "" AndAlso IsDBNull(Me.GetCurrentColumnValue("Sch")) = False AndAlso Me.GetCurrentColumnValue("Sch") <> " " Then
                Dim dtRow As System.Data.DataRowView = Me.GetCurrentRow()

                If dtRow IsNot Nothing AndAlso dtRow.Row IsNot Nothing Then
                    Select Case KeyName
                        Case "DIVIDENDINC"
                            If dtRow.Row.GetChildRows("FK_DIVIDEND_INCOME").Count > 0 Then
                                SubPNLInfo_KEYName.Visible = True
                            Else
                                SubPNLInfo_KEYName.Visible = False
                            End If
                        Case "RENTALINC"
                            If dtRow.Row.GetChildRows("FK_RENTAL_INCOME").Count > 0 Then
                                SubPNLInfo_KEYName.Visible = True
                            Else
                                SubPNLInfo_KEYName.Visible = False
                            End If
                        Case "EXEMDIV"
                            If dtRow.Row.GetChildRows("FK_EXEMPT_DIVIDEND").Count > 0 Then
                                SubPNLInfo_KEYName.Visible = True
                            Else
                                SubPNLInfo_KEYName.Visible = False
                            End If
                        Case "EXPRENTAL"
                            If dtRow.Row.GetChildRows("FK_EXPENSES_RENTAL").Count > 0 Then
                                SubPNLInfo_KEYName.Visible = True
                            Else
                                SubPNLInfo_KEYName.Visible = False
                            End If
                        Case Else
                            If dtRow.Row.GetChildRows("FK_PNL_TABLE_INFO_PNL_QUICK_DETAIL").Count > 0 Then
                                SubPNLInfo_KEYName.Visible = True
                            Else
                                SubPNLInfo_KEYName.Visible = False
                            End If
                    End Select

                End If

            Else
                SubPNLInfo_KEYName.Visible = False
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
    Private Sub lblDraft_Report_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles lblDraft_Report.PrintOnPage
        Try
            If e.PageIndex = 1 Then
                lblDraft_Report.Visible = True
            Else
                lblDraft_Report.Visible = False
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

    Private Sub lblDraft_Page_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles lblDraft_Page.PrintOnPage
        Try
            If e.PageIndex <> 1 Then
                lblDraft_Page.Visible = True
            Else
                lblDraft_Page.Visible = False
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

    Private Sub rptPNL_DetailsNew_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint

    End Sub
End Class