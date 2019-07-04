Public Class rptPNL_InterestResict17

#Region "Sub17"
    Private Sub Sub17_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No1.BeforePrint
        Try
            Sub17_No1.Text = mdlProcess.GetMonthToPrint(1, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No2.BeforePrint
        Try
            Sub17_No2.Text = mdlProcess.GetMonthToPrint(2, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No3.BeforePrint
        Try
            Sub17_No3.Text = mdlProcess.GetMonthToPrint(3, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No4.BeforePrint
        Try
            Sub17_No4.Text = mdlProcess.GetMonthToPrint(4, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No5.BeforePrint
        Try
            Sub17_No5.Text = mdlProcess.GetMonthToPrint(5, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No6.BeforePrint
        Try
            Sub17_No6.Text = mdlProcess.GetMonthToPrint(6, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No7.BeforePrint
        Try
            Sub17_No7.Text = mdlProcess.GetMonthToPrint(7, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No8.BeforePrint
        Try
            Sub17_No8.Text = mdlProcess.GetMonthToPrint(8, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No9.BeforePrint
        Try
            Sub17_No9.Text = mdlProcess.GetMonthToPrint(9, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No10.BeforePrint
        Try
            Sub17_No10.Text = mdlProcess.GetMonthToPrint(10, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No11.BeforePrint
        Try
            Sub17_No11.Text = mdlProcess.GetMonthToPrint(11, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No14.BeforePrint
        Try
            Sub17_No14.Text = mdlProcess.GetMonthToPrint(12, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No13.BeforePrint
        Try
            Sub17_No13.Text = mdlProcess.GetMonthToPrint(13, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No14.BeforePrint
        Try
            Sub17_No14.Text = mdlProcess.GetMonthToPrint(14, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No15.BeforePrint
        Try
            Sub17_No15.Text = mdlProcess.GetMonthToPrint(15, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No16.BeforePrint
        Try
            Sub17_No16.Text = mdlProcess.GetMonthToPrint(16, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_No17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No17.BeforePrint
        Try
            Sub17_No17.Text = mdlProcess.GetMonthToPrint(17, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub SubBand17_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand17_BasisPeriod.BeforePrint
        Try
            Dim DateFrom As DateTime = Me.GetCurrentColumnValue("DateFrom")
            Dim DateTo As DateTime = Me.GetCurrentColumnValue("DateTo")
            SubBand17_BasisPeriod.Text = "Basis Period: " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub lblTotalYear17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear17.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3
                            lblTotalYear17.Visible = False
                        Case Else
                            lblTotalYear17.Visible = True
                    End Select
                End If
            End If

            Data = Me.GetCurrentColumnValue("TotalYear")

            If Data IsNot Nothing AndAlso IsNumeric(Data) Then
                lblTotalYear17.Text = CInt(Data).ToString("N0")
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub lblTotalYearSum17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum17.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3
                            lblTotalYearSum17.Visible = False
                        Case Else
                            lblTotalYearSum17.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub lblTotal_Title_17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotal_Title_17.BeforePrint, lblTotal_Tag_17.BeforePrint
        Try
            Dim row As Object = Me.GetCurrentColumnValue("TypeName")

            If row IsNot Nothing Then
                lblTotal_Title_17.Text = "Total " & row.ToString.Substring(2, row.ToString.Length - 2).ToLower
            End If

            row = Me.GetCurrentColumnValue("LabelTag")
            If row IsNot Nothing Then
                lblTotal_Tag_17.Text = row.ToString.Substring(0, 1).ToUpper
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTitle_EndYear_17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitle_EndYear_17.BeforePrint
        Try
            Dim row As Object = Me.GetCurrentColumnValue("TypeName")

            If row IsNot Nothing AndAlso row = "4 INTEREST EXPENSES" Then
                lblTitle_EndYear_17.Visible = True
            Else
                lblTitle_EndYear_17.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_Bot_17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_Bot_17.BeforePrint, line_Top_17.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3
                            line_Top_17.WidthF = 740.92
                            line_Bot_17.WidthF = 740.92
                        Case Else
                            line_Top_17.WidthF = 842.04
                            line_Bot_17.WidthF = 842.04
                    End Select
                End If
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Foot_17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Foot_17.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 5, 6
                            Foot_17.Visible = False
                        Case Else
                            '   Foot_Gap_17.Visible = False
                            Foot_17.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub TypeName_17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TypeName_17.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")
            If Data IsNot Nothing Then
                TypeName_17.Text = Data.Substring(2, Data.Length - 2)
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