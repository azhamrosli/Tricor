﻿Public Class rptPNL_InterestResict16
#Region "Sub16"
    Private Sub Sub16_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No1.BeforePrint
        Try
            Sub16_No1.Text = mdlProcess.GetMonthToPrint(1, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No2.BeforePrint
        Try
            Sub16_No2.Text = mdlProcess.GetMonthToPrint(2, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No3.BeforePrint
        Try
            Sub16_No3.Text = mdlProcess.GetMonthToPrint(3, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No4.BeforePrint
        Try
            Sub16_No4.Text = mdlProcess.GetMonthToPrint(4, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No5.BeforePrint
        Try
            Sub16_No5.Text = mdlProcess.GetMonthToPrint(5, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No6.BeforePrint
        Try
            Sub16_No6.Text = mdlProcess.GetMonthToPrint(6, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No7.BeforePrint
        Try
            Sub16_No7.Text = mdlProcess.GetMonthToPrint(7, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No8.BeforePrint
        Try
            Sub16_No8.Text = mdlProcess.GetMonthToPrint(8, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No9.BeforePrint
        Try
            Sub16_No9.Text = mdlProcess.GetMonthToPrint(9, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No10.BeforePrint
        Try
            Sub16_No10.Text = mdlProcess.GetMonthToPrint(10, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No11.BeforePrint
        Try
            Sub16_No11.Text = mdlProcess.GetMonthToPrint(11, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No14.BeforePrint
        Try
            Sub16_No14.Text = mdlProcess.GetMonthToPrint(12, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No13.BeforePrint
        Try
            Sub16_No13.Text = mdlProcess.GetMonthToPrint(13, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No14.BeforePrint
        Try
            Sub16_No14.Text = mdlProcess.GetMonthToPrint(14, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No15.BeforePrint
        Try
            Sub16_No15.Text = mdlProcess.GetMonthToPrint(15, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_No16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No16.BeforePrint
        Try
            Sub16_No16.Text = mdlProcess.GetMonthToPrint(16, Me)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub SubBand16_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand16_BasisPeriod.BeforePrint
        Try
            Dim DateFrom As DateTime = Me.GetCurrentColumnValue("DateFrom")
            Dim DateTo As DateTime = Me.GetCurrentColumnValue("DateTo")
            SubBand16_BasisPeriod.Text = "Basis Period: " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub lblTotalYear16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear16.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3
                            lblTotalYear16.Visible = False
                        Case Else
                            lblTotalYear16.Visible = True
                    End Select
                End If
            End If

            Data = Me.GetCurrentColumnValue("TotalYear")

            If Data IsNot Nothing AndAlso IsNumeric(Data) Then
                lblTotalYear16.Text = CInt(Data).ToString("N0")
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub lblTotalYearSum16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum16.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3
                            lblTotalYearSum16.Visible = False
                        Case Else
                            lblTotalYearSum16.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub lblTotal_Title_16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotal_Title_16.BeforePrint, lblTotal_Tag_16.BeforePrint
        Try
            Dim row As Object = Me.GetCurrentColumnValue("TypeName")

            If row IsNot Nothing Then
                lblTotal_Title_16.Text = "Total " & row.ToString.Substring(2, row.ToString.Length - 2).ToLower
            End If

            row = Me.GetCurrentColumnValue("LabelTag")
            If row IsNot Nothing Then
                lblTotal_Tag_16.Text = row.ToString.Substring(0, 1).ToUpper
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTitle_EndYear_16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitle_EndYear_16.BeforePrint
        Try
            Dim row As Object = Me.GetCurrentColumnValue("TypeName")

            If row IsNot Nothing AndAlso row = "4 INTEREST EXPENSES" Then
                lblTitle_EndYear_16.Visible = True
            Else
                lblTitle_EndYear_16.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_Bot_16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_Bot_16.BeforePrint, line_Top_16.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3
                            line_Top_16.WidthF = 740.92
                            line_Bot_16.WidthF = 740.92
                        Case Else
                            line_Top_16.WidthF = 842.04
                            line_Bot_16.WidthF = 842.04
                    End Select
                End If
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Foot_16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Foot_16.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 5, 6
                            Foot_16.Visible = False
                        Case Else
                            '   Foot_Gap_16.Visible = False
                            Foot_16.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub TypeName_16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TypeName_16.BeforePrint
        Try
            Dim Data As String = Me.GetCurrentColumnValue("TypeName")
            If Data IsNot Nothing Then
                TypeName_16.Text = Data.Substring(2, Data.Length - 2)
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