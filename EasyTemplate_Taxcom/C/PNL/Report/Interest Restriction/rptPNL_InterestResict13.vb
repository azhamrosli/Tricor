Public Class rptPNL_InterestResict13
#Region "Sub13"
    Private Sub Sub13_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No1.BeforePrint
        Try
            Sub13_No1.Text = mdlProcess.GetMonthToPrint(1, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No2.BeforePrint
        Try
            Sub13_No2.Text = mdlProcess.GetMonthToPrint(2, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No3.BeforePrint
        Try
            Sub13_No3.Text = mdlProcess.GetMonthToPrint(3, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No4.BeforePrint
        Try
            Sub13_No4.Text = mdlProcess.GetMonthToPrint(4, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No5.BeforePrint
        Try
            Sub13_No5.Text = mdlProcess.GetMonthToPrint(5, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No6.BeforePrint
        Try
            Sub13_No6.Text = mdlProcess.GetMonthToPrint(6, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No7.BeforePrint
        Try
            Sub13_No7.Text = mdlProcess.GetMonthToPrint(7, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No8.BeforePrint
        Try
            Sub13_No8.Text = mdlProcess.GetMonthToPrint(8, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No9.BeforePrint
        Try
            Sub13_No9.Text = mdlProcess.GetMonthToPrint(9, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No10.BeforePrint
        Try
            Sub13_No10.Text = mdlProcess.GetMonthToPrint(10, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No11.BeforePrint
        Try
            Sub13_No11.Text = mdlProcess.GetMonthToPrint(11, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No12.BeforePrint
        Try
            Sub13_No13.Text = mdlProcess.GetMonthToPrint(13, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No13.BeforePrint
        Try
            Sub13_No13.Text = mdlProcess.GetMonthToPrint(13, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub lblTotalYear13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear13.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3
                            lblTotalYear13.Visible = False
                        Case Else
                            lblTotalYear13.Visible = True
                    End Select
                End If
            End If

            Data = Me.GetCurrentColumnValue("TotalYear")

            If Data IsNot Nothing AndAlso IsNumeric(Data) Then
                lblTotalYear13.Text = CInt(Data).ToString("N0")
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub lblTotalYearSum13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum13.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3
                            lblTotalYearSum13.Visible = False
                        Case Else
                            lblTotalYearSum13.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub lblTotal_Title_13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotal_Title_13.BeforePrint, lblTotal_Tag_13.BeforePrint
        Try
            Dim row As Object = Me.GetCurrentColumnValue("TypeName")

            If row IsNot Nothing Then
                lblTotal_Title_13.Text = "Total " & row.ToString.Substring(2, row.ToString.Length - 2).ToLower
            End If

            row = Me.GetCurrentColumnValue("LabelTag")
            If row IsNot Nothing Then
                lblTotal_Tag_13.Text = row.ToString.Substring(0, 1).ToUpper
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTitle_EndYear_13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitle_EndYear_13.BeforePrint
        Try
            Dim row As Object = Me.GetCurrentColumnValue("TypeName")

            If row IsNot Nothing AndAlso row = "4 INTEREST EXPENSES" Then
                lblTitle_EndYear_13.Visible = True
            Else
                lblTitle_EndYear_13.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_Bot_13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_Bot_13.BeforePrint, line_Top_13.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3
                            line_Top_13.WidthF = 740.92
                            line_Bot_13.WidthF = 740.92
                        Case Else
                            line_Top_13.WidthF = 842.04
                            line_Bot_13.WidthF = 842.04
                    End Select
                End If
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Foot_13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Foot_13.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 5, 6
                            Foot_13.Visible = False
                        Case Else
                            '   Foot_Gap_13.Visible = False
                            Foot_13.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub TypeName_13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TypeName_13.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")
            If Data IsNot Nothing Then
                TypeName_13.Text = Data.Substring(2, Data.Length - 2)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblDraft_Report_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles lblDraft_Report.PrintOnPage
        Try
            If e.PageIndex = 0 Then
                lblDraft_Report.Visible = True
            Else
                lblDraft_Report.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblDraft_Page_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles lblDraft_Page.PrintOnPage
        Try
            If e.PageIndex <> 0 Then
                lblDraft_Page.Visible = True
            Else
                lblDraft_Page.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtSch_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtSch.BeforePrint
        Try
            txtSch.Text = txtSch.Text.Replace("Sch", "Schedule")
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class