Public Class rptPNL_InterestResict
    Private Sub Sub12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12.BeforePrint
        Try
            Dim TotalDynamicNo As Integer = 0
            Dim obj As DevExpress.XtraReports.UI.XRTableCell = Nothing
            Dim objColumn As Object = Sub12.GetCurrentColumnValue("TotalColumn")
            Dim TmpNo As Integer = 0
            If objColumn IsNot Nothing AndAlso IsNumeric(objColumn) Then
                TotalDynamicNo = CInt(objColumn)
            Else
                TotalDynamicNo = 0
            End If
            If 12 = TotalDynamicNo Then
                Sub12.Visible = True
            Else
                Sub12.Visible = False
            End If
        Catch ex As Exception
                        Dim st As New StackTrace(True)
                        st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13.BeforePrint
        Try
            Dim TotalDynamicNo As Integer = 0
            Dim obj As DevExpress.XtraReports.UI.XRTableCell = Nothing
            Dim objColumn As Object = Sub13.GetCurrentColumnValue("TotalColumn")
            Dim TmpNo As Integer = 0
            If objColumn IsNot Nothing AndAlso IsNumeric(objColumn) Then
                TotalDynamicNo = CInt(objColumn)
            Else
                TotalDynamicNo = 0
            End If
            If 13 = TotalDynamicNo Then
                Sub13.Visible = True
            Else
                Sub13.Visible = False
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub Sub14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14.BeforePrint
        Try
            Dim TotalDynamicNo As Integer = 0
            Dim obj As DevExpress.XtraReports.UI.XRTableCell = Nothing
            Dim objColumn As Object = Sub14.GetCurrentColumnValue("TotalColumn")
            Dim TmpNo As Integer = 0
            If objColumn IsNot Nothing AndAlso IsNumeric(objColumn) Then
                TotalDynamicNo = CInt(objColumn)
            Else
                TotalDynamicNo = 0
            End If
            If 14 = TotalDynamicNo Then
                Sub14.Visible = True
            Else
                Sub14.Visible = False
            End If
        Catch ex As Exception
                        Dim st As New StackTrace(True)
                        st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15.BeforePrint
        Try
            Dim TotalDynamicNo As Integer = 0
            Dim obj As DevExpress.XtraReports.UI.XRTableCell = Nothing
            Dim objColumn As Object = Sub15.GetCurrentColumnValue("TotalColumn")
            Dim TmpNo As Integer = 0
            If objColumn IsNot Nothing AndAlso IsNumeric(objColumn) Then
                TotalDynamicNo = CInt(objColumn)
            Else
                TotalDynamicNo = 0
            End If
            If 15 = TotalDynamicNo Then
                Sub15.Visible = True
            Else
                Sub15.Visible = False
            End If
        Catch ex As Exception
                        Dim st As New StackTrace(True)
                        st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16.BeforePrint
        Try
            Dim TotalDynamicNo As Integer = 0
            Dim obj As DevExpress.XtraReports.UI.XRTableCell = Nothing
            Dim objColumn As Object = Sub16.GetCurrentColumnValue("TotalColumn")
            Dim TmpNo As Integer = 0
            If objColumn IsNot Nothing AndAlso IsNumeric(objColumn) Then
                TotalDynamicNo = CInt(objColumn)
            Else
                TotalDynamicNo = 0
            End If
            If 16 = TotalDynamicNo Then
                Sub16.Visible = True
            Else
                Sub16.Visible = False
            End If
        Catch ex As Exception
                        Dim st As New StackTrace(True)
                        st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17.BeforePrint
        Try
            Dim TotalDynamicNo As Integer = 0
            Dim obj As DevExpress.XtraReports.UI.XRTableCell = Nothing
            Dim objColumn As Object = Sub17.GetCurrentColumnValue("TotalColumn")
            Dim TmpNo As Integer = 0
            If objColumn IsNot Nothing AndAlso IsNumeric(objColumn) Then
                TotalDynamicNo = CInt(objColumn)
            Else
                TotalDynamicNo = 0
            End If
            If 17 = TotalDynamicNo Then
                Sub17.Visible = True
            Else
                Sub17.Visible = False
            End If
        Catch ex As Exception
                        Dim st As New StackTrace(True)
                        st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Sub18_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18.BeforePrint
        Try
            Dim TotalDynamicNo As Integer = 0
            Dim obj As DevExpress.XtraReports.UI.XRTableCell = Nothing
            Dim objColumn As Object = Sub18.GetCurrentColumnValue("TotalColumn")
            Dim TmpNo As Integer = 0
            If objColumn IsNot Nothing AndAlso IsNumeric(objColumn) Then
                TotalDynamicNo = CInt(objColumn)
            Else
                TotalDynamicNo = 0
            End If
            If 18 = TotalDynamicNo Then
                Sub18.Visible = True
            Else
                Sub18.Visible = False
            End If

        Catch ex As Exception
                        Dim st As New StackTrace(True)
                        st = New StackTrace(ex, True)

        End Try
    End Sub

    '#Region "Sub12"
    '    Private Sub Sub12_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub12_No1.Text = GetMonthToPrint(1, Sub12)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub12_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub12_No2.Text = GetMonthToPrint(2, Sub12)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub12_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub12_No3.Text = GetMonthToPrint(3, Sub12)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub12_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub12_No4.Text = GetMonthToPrint(4, Sub12)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub12_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub12_No5.Text = GetMonthToPrint(5, Sub12)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub12_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub12_No6.Text = GetMonthToPrint(6, Sub12)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub12_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub12_No7.Text = GetMonthToPrint(7, Sub12)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub12_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub12_No8.Text = GetMonthToPrint(8, Sub12)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub12_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub12_No9.Text = GetMonthToPrint(9, Sub12)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub12_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub12_No10.Text = GetMonthToPrint(10, Sub12)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub12_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub12_No11.Text = GetMonthToPrint(11, Sub12)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub12_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub12_No12.Text = GetMonthToPrint(12, Sub12)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub SubBand12_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim DateFrom As DateTime = Sub12.GetCurrentColumnValue("DateFrom")
    '            Dim DateTo As DateTime = Sub12.GetCurrentColumnValue("DateTo")
    '            SubBand12_BasisPeriod.Text = "Basis Period: " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYear12_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim Data As String = Sub12.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYear12.Visible = False
    '                        Case Else
    '                            lblTotalYear12.Visible = True
    '                    End Select
    '                End If
    '            End If

    '            Data = Sub12.GetCurrentColumnValue("TotalYear")

    '            If Data IsNot Nothing AndAlso IsNumeric(Data) Then
    '                lblTotalYear12.Text = CInt(Data).ToString("N0")
    '            End If
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYearSum12_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim Data As String = Sub12.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYearSum12.Visible = False
    '                        Case Else
    '                            lblTotalYearSum12.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotal_Title_12_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim row As Object = Sub12.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing Then
    '                lblTotal_Title_12.Text = "Total " & row.ToString.Substring(2, row.ToString.Length - 2).ToLower
    '            End If

    '            row = Sub12.GetCurrentColumnValue("LabelTag")
    '            If row IsNot Nothing Then
    '                lblTotal_Tag_12.Text = row.ToString.Substring(0, 1).ToUpper
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub lblTitle_EndYear_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim row As Object = Sub12.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing AndAlso row = "4 INTEREST EXPENSES" Then
    '                lblTitle_EndYear_12.Visible = True
    '            Else
    '                lblTitle_EndYear_12.Visible = False
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_Bot_12_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim Data As String = Sub12.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            line_Top_12.WidthF = 740.92
    '                            line_Bot_12.WidthF = 740.92
    '                        Case Else
    '                            line_Top_12.WidthF = 842.04
    '                            line_Bot_12.WidthF = 842.04
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Foot_12_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim Data As String = Sub12.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 5, 6
    '                            Foot_12.Visible = False
    '                        Case Else
    '                            '   Foot_Gap_12.Visible = False
    '                            Foot_12.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub TypeName_12_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim Data As String = Sub12.GetCurrentColumnValue("TypeName")
    '            If Data IsNot Nothing Then
    '                TypeName_12.Text = Data.Substring(2, Data.Length - 2)
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '#End Region

    '#Region "Sub13"
    '    Private Sub Sub13_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No1.BeforePrint
    '        Try
    '            Sub13_No1.Text = GetMonthToPrint(1, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub13_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No2.BeforePrint
    '        Try
    '            Sub13_No2.Text = GetMonthToPrint(2, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub13_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No3.BeforePrint
    '        Try
    '            Sub13_No3.Text = GetMonthToPrint(3, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub13_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No4.BeforePrint
    '        Try
    '            Sub13_No4.Text = GetMonthToPrint(4, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub13_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No5.BeforePrint
    '        Try
    '            Sub13_No5.Text = GetMonthToPrint(5, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub13_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No6.BeforePrint
    '        Try
    '            Sub13_No6.Text = GetMonthToPrint(6, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub13_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No7.BeforePrint
    '        Try
    '            Sub13_No7.Text = GetMonthToPrint(7, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub13_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No8.BeforePrint
    '        Try
    '            Sub13_No8.Text = GetMonthToPrint(8, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub13_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No9.BeforePrint
    '        Try
    '            Sub13_No9.Text = GetMonthToPrint(9, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub13_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No10.BeforePrint
    '        Try
    '            Sub13_No10.Text = GetMonthToPrint(10, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub13_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No11.BeforePrint
    '        Try
    '            Sub13_No11.Text = GetMonthToPrint(11, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub13_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No12.BeforePrint
    '        Try
    '            Sub13_No13.Text = GetMonthToPrint(13, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub13_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No13.BeforePrint
    '        Try
    '            Sub13_No13.Text = GetMonthToPrint(13, Sub13)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub SubBand13_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand13_BasisPeriod.BeforePrint
    '        Try
    '            Dim DateFrom As DateTime = Sub13.GetCurrentColumnValue("DateFrom")
    '            Dim DateTo As DateTime = Sub13.GetCurrentColumnValue("DateTo")
    '            SubBand13_BasisPeriod.Text = "Basis Period: " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYear13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear13.BeforePrint
    '        Try
    '            Dim Data As String = Sub13.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYear13.Visible = False
    '                        Case Else
    '                            lblTotalYear13.Visible = True
    '                    End Select
    '                End If
    '            End If

    '            Data = Sub13.GetCurrentColumnValue("TotalYear")

    '            If Data IsNot Nothing AndAlso IsNumeric(Data) Then
    '                lblTotalYear13.Text = CInt(Data).ToString("N0")
    '            End If
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYearSum13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum13.BeforePrint
    '        Try
    '            Dim Data As String = Sub13.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYearSum13.Visible = False
    '                        Case Else
    '                            lblTotalYearSum13.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotal_Title_13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotal_Title_13.BeforePrint, lblTotal_Tag_13.BeforePrint
    '        Try
    '            Dim row As Object = Sub13.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing Then
    '                lblTotal_Title_13.Text = "Total " & row.ToString.Substring(2, row.ToString.Length - 2).ToLower
    '            End If

    '            row = Sub13.GetCurrentColumnValue("LabelTag")
    '            If row IsNot Nothing Then
    '                lblTotal_Tag_13.Text = row.ToString.Substring(0, 1).ToUpper
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub lblTitle_EndYear_13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitle_EndYear_13.BeforePrint
    '        Try
    '            Dim row As Object = Sub13.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing AndAlso row = "4 INTEREST EXPENSES" Then
    '                lblTitle_EndYear_13.Visible = True
    '            Else
    '                lblTitle_EndYear_13.Visible = False
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_Bot_13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_Bot_13.BeforePrint, line_Top_13.BeforePrint
    '        Try
    '            Dim Data As String = Sub13.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            line_Top_13.WidthF = 740.92
    '                            line_Bot_13.WidthF = 740.92
    '                        Case Else
    '                            line_Top_13.WidthF = 842.04
    '                            line_Bot_13.WidthF = 842.04
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Foot_13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Foot_13.BeforePrint
    '        Try
    '            Dim Data As String = Sub13.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 5, 6
    '                            Foot_13.Visible = False
    '                        Case Else
    '                            '   Foot_Gap_13.Visible = False
    '                            Foot_13.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub TypeName_13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TypeName_13.BeforePrint
    '        Try
    '            Dim Data As String = Sub13.GetCurrentColumnValue("TypeName")
    '            If Data IsNot Nothing Then
    '                TypeName_13.Text = Data.Substring(2, Data.Length - 2)
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '#End Region

    '#Region "Sub14"
    '    Private Sub Sub14_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No1.BeforePrint
    '        Try
    '            Sub14_No1.Text = GetMonthToPrint(1, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No2.BeforePrint
    '        Try
    '            Sub14_No2.Text = GetMonthToPrint(2, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No3.BeforePrint
    '        Try
    '            Sub14_No3.Text = GetMonthToPrint(3, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No4.BeforePrint
    '        Try
    '            Sub14_No4.Text = GetMonthToPrint(4, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No5.BeforePrint
    '        Try
    '            Sub14_No5.Text = GetMonthToPrint(5, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No6.BeforePrint
    '        Try
    '            Sub14_No6.Text = GetMonthToPrint(6, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No7.BeforePrint
    '        Try
    '            Sub14_No7.Text = GetMonthToPrint(7, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No8.BeforePrint
    '        Try
    '            Sub14_No8.Text = GetMonthToPrint(8, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No9.BeforePrint
    '        Try
    '            Sub14_No9.Text = GetMonthToPrint(9, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No10.BeforePrint
    '        Try
    '            Sub14_No10.Text = GetMonthToPrint(10, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No11.BeforePrint
    '        Try
    '            Sub14_No11.Text = GetMonthToPrint(11, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No14.BeforePrint
    '        Try
    '            Sub14_No14.Text = GetMonthToPrint(12, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No13.BeforePrint
    '        Try
    '            Sub14_No13.Text = GetMonthToPrint(13, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub14_No14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No14.BeforePrint
    '        Try
    '            Sub14_No14.Text = GetMonthToPrint(14, Sub14)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub SubBand14_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand14_BasisPeriod.BeforePrint
    '        Try
    '            Dim DateFrom As DateTime = Sub14.GetCurrentColumnValue("DateFrom")
    '            Dim DateTo As DateTime = Sub14.GetCurrentColumnValue("DateTo")
    '            SubBand14_BasisPeriod.Text = "Basis Period: " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYear14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear14.BeforePrint
    '        Try
    '            Dim Data As String = Sub14.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYear14.Visible = False
    '                        Case Else
    '                            lblTotalYear14.Visible = True
    '                    End Select
    '                End If
    '            End If
    '            Data = Sub14.GetCurrentColumnValue("TotalYear")

    '            If Data IsNot Nothing AndAlso IsNumeric(Data) Then
    '                lblTotalYear14.Text = CInt(Data).ToString("N0")
    '            End If
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYearSum14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum14.BeforePrint
    '        Try
    '            Dim Data As String = Sub14.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYearSum14.Visible = False
    '                        Case Else
    '                            lblTotalYearSum14.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotal_Title_14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotal_Title_14.BeforePrint, lblTotal_Tag_14.BeforePrint
    '        Try
    '            Dim row As Object = Sub14.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing Then
    '                lblTotal_Title_14.Text = "Total " & row.ToString.Substring(2, row.ToString.Length - 2).ToLower
    '            End If

    '            row = Sub14.GetCurrentColumnValue("LabelTag")
    '            If row IsNot Nothing Then
    '                lblTotal_Tag_14.Text = row.ToString.Substring(0, 1).ToUpper
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub lblTitle_EndYear_14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitle_EndYear_14.BeforePrint
    '        Try
    '            Dim row As Object = Sub14.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing AndAlso row = "4 INTEREST EXPENSES" Then
    '                lblTitle_EndYear_14.Visible = True
    '            Else
    '                lblTitle_EndYear_14.Visible = False
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_Bot_14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_Bot_14.BeforePrint, line_Top_14.BeforePrint
    '        Try
    '            Dim Data As String = Sub14.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            line_Top_14.WidthF = 740.92
    '                            line_Bot_14.WidthF = 740.92
    '                        Case Else
    '                            line_Top_14.WidthF = 842.04
    '                            line_Bot_14.WidthF = 842.04
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Foot_14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Foot_14.BeforePrint
    '        Try
    '            Dim Data As String = Sub14.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 5, 6
    '                            Foot_14.Visible = False
    '                        Case Else
    '                            '   Foot_Gap_14.Visible = False
    '                            Foot_14.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub TypeName_14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TypeName_14.BeforePrint
    '        Try
    '            Dim Data As String = Sub14.GetCurrentColumnValue("TypeName")
    '            If Data IsNot Nothing Then
    '                TypeName_14.Text = Data.Substring(2, Data.Length - 2)
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '#End Region

    '#Region "Sub15"
    '    Private Sub Sub15_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No1.BeforePrint
    '        Try
    '            Sub15_No1.Text = GetMonthToPrint(1, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No2.BeforePrint
    '        Try
    '            Sub15_No2.Text = GetMonthToPrint(2, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No3.BeforePrint
    '        Try
    '            Sub15_No3.Text = GetMonthToPrint(3, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No4.BeforePrint
    '        Try
    '            Sub15_No4.Text = GetMonthToPrint(4, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No5.BeforePrint
    '        Try
    '            Sub15_No5.Text = GetMonthToPrint(5, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No6.BeforePrint
    '        Try
    '            Sub15_No6.Text = GetMonthToPrint(6, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No7.BeforePrint
    '        Try
    '            Sub15_No7.Text = GetMonthToPrint(7, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No8.BeforePrint
    '        Try
    '            Sub15_No8.Text = GetMonthToPrint(8, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No9.BeforePrint
    '        Try
    '            Sub15_No9.Text = GetMonthToPrint(9, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No10.BeforePrint
    '        Try
    '            Sub15_No10.Text = GetMonthToPrint(10, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No11.BeforePrint
    '        Try
    '            Sub15_No11.Text = GetMonthToPrint(11, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No14.BeforePrint
    '        Try
    '            Sub15_No14.Text = GetMonthToPrint(12, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No13.BeforePrint
    '        Try
    '            Sub15_No13.Text = GetMonthToPrint(13, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No14.BeforePrint
    '        Try
    '            Sub15_No14.Text = GetMonthToPrint(14, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub15_No15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No15.BeforePrint
    '        Try
    '            Sub15_No15.Text = GetMonthToPrint(15, Sub15)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub SubBand15_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand15_BasisPeriod.BeforePrint
    '        Try
    '            Dim DateFrom As DateTime = Sub15.GetCurrentColumnValue("DateFrom")
    '            Dim DateTo As DateTime = Sub15.GetCurrentColumnValue("DateTo")
    '            SubBand15_BasisPeriod.Text = "Basis Period: " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYear15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear15.BeforePrint
    '        Try
    '            Dim Data As String = Sub15.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYear15.Visible = False
    '                        Case Else
    '                            lblTotalYear15.Visible = True
    '                    End Select
    '                End If
    '            End If
    '            Data = Sub15.GetCurrentColumnValue("TotalYear")

    '            If Data IsNot Nothing AndAlso IsNumeric(Data) Then
    '                lblTotalYear15.Text = CInt(Data).ToString("N0")
    '            End If
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYearSum15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum15.BeforePrint
    '        Try
    '            Dim Data As String = Sub15.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYearSum15.Visible = False
    '                        Case Else
    '                            lblTotalYearSum15.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotal_Title_15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotal_Title_15.BeforePrint, lblTotal_Tag_15.BeforePrint
    '        Try
    '            Dim row As Object = Sub15.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing Then
    '                lblTotal_Title_15.Text = "Total " & row.ToString.Substring(2, row.ToString.Length - 2).ToLower
    '            End If

    '            row = Sub15.GetCurrentColumnValue("LabelTag")
    '            If row IsNot Nothing Then
    '                lblTotal_Tag_15.Text = row.ToString.Substring(0, 1).ToUpper
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub lblTitle_EndYear_15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitle_EndYear_15.BeforePrint
    '        Try
    '            Dim row As Object = Sub15.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing AndAlso row = "4 INTEREST EXPENSES" Then
    '                lblTitle_EndYear_15.Visible = True
    '            Else
    '                lblTitle_EndYear_15.Visible = False
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_Bot_15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_Bot_15.BeforePrint, line_Top_15.BeforePrint
    '        Try
    '            Dim Data As String = Sub15.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            line_Top_15.WidthF = 740.92
    '                            line_Bot_15.WidthF = 740.92
    '                        Case Else
    '                            line_Top_15.WidthF = 842.04
    '                            line_Bot_15.WidthF = 842.04
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Foot_15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Foot_15.BeforePrint
    '        Try
    '            Dim Data As String = Sub15.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 5, 6
    '                            Foot_15.Visible = False
    '                        Case Else
    '                            '   Foot_Gap_15.Visible = False
    '                            Foot_15.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub TypeName_15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TypeName_15.BeforePrint
    '        Try
    '            Dim Data As String = Sub15.GetCurrentColumnValue("TypeName")
    '            If Data IsNot Nothing Then
    '                TypeName_15.Text = Data.Substring(2, Data.Length - 2)
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '#End Region

    '#Region "Sub16"
    '    Private Sub Sub16_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No1.BeforePrint
    '        Try
    '            Sub16_No1.Text = GetMonthToPrint(1, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No2.BeforePrint
    '        Try
    '            Sub16_No2.Text = GetMonthToPrint(2, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No3.BeforePrint
    '        Try
    '            Sub16_No3.Text = GetMonthToPrint(3, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No4.BeforePrint
    '        Try
    '            Sub16_No4.Text = GetMonthToPrint(4, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No5.BeforePrint
    '        Try
    '            Sub16_No5.Text = GetMonthToPrint(5, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No6.BeforePrint
    '        Try
    '            Sub16_No6.Text = GetMonthToPrint(6, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No7.BeforePrint
    '        Try
    '            Sub16_No7.Text = GetMonthToPrint(7, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No8.BeforePrint
    '        Try
    '            Sub16_No8.Text = GetMonthToPrint(8, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No9.BeforePrint
    '        Try
    '            Sub16_No9.Text = GetMonthToPrint(9, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No10.BeforePrint
    '        Try
    '            Sub16_No10.Text = GetMonthToPrint(10, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No11.BeforePrint
    '        Try
    '            Sub16_No11.Text = GetMonthToPrint(11, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No14.BeforePrint
    '        Try
    '            Sub16_No14.Text = GetMonthToPrint(12, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No13.BeforePrint
    '        Try
    '            Sub16_No13.Text = GetMonthToPrint(13, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No14.BeforePrint
    '        Try
    '            Sub16_No14.Text = GetMonthToPrint(14, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No15.BeforePrint
    '        Try
    '            Sub16_No15.Text = GetMonthToPrint(15, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub16_No16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No16.BeforePrint
    '        Try
    '            Sub16_No16.Text = GetMonthToPrint(16, Sub16)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub SubBand16_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand16_BasisPeriod.BeforePrint
    '        Try
    '            Dim DateFrom As DateTime = Sub16.GetCurrentColumnValue("DateFrom")
    '            Dim DateTo As DateTime = Sub16.GetCurrentColumnValue("DateTo")
    '            SubBand16_BasisPeriod.Text = "Basis Period: " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYear16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear16.BeforePrint
    '        Try
    '            Dim Data As String = Sub16.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYear16.Visible = False
    '                        Case Else
    '                            lblTotalYear16.Visible = True
    '                    End Select
    '                End If
    '            End If

    '            Data = Sub16.GetCurrentColumnValue("TotalYear")

    '            If Data IsNot Nothing AndAlso IsNumeric(Data) Then
    '                lblTotalYear16.Text = CInt(Data).ToString("N0")
    '            End If
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYearSum16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum16.BeforePrint
    '        Try
    '            Dim Data As String = Sub16.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYearSum16.Visible = False
    '                        Case Else
    '                            lblTotalYearSum16.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotal_Title_16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotal_Title_16.BeforePrint, lblTotal_Tag_16.BeforePrint
    '        Try
    '            Dim row As Object = Sub16.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing Then
    '                lblTotal_Title_16.Text = "Total " & row.ToString.Substring(2, row.ToString.Length - 2).ToLower
    '            End If

    '            row = Sub16.GetCurrentColumnValue("LabelTag")
    '            If row IsNot Nothing Then
    '                lblTotal_Tag_16.Text = row.ToString.Substring(0, 1).ToUpper
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub lblTitle_EndYear_16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitle_EndYear_16.BeforePrint
    '        Try
    '            Dim row As Object = Sub16.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing AndAlso row = "4 INTEREST EXPENSES" Then
    '                lblTitle_EndYear_16.Visible = True
    '            Else
    '                lblTitle_EndYear_16.Visible = False
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_Bot_16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_Bot_16.BeforePrint, line_Top_16.BeforePrint
    '        Try
    '            Dim Data As String = Sub16.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            line_Top_16.WidthF = 740.92
    '                            line_Bot_16.WidthF = 740.92
    '                        Case Else
    '                            line_Top_16.WidthF = 842.04
    '                            line_Bot_16.WidthF = 842.04
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Foot_16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Foot_16.BeforePrint
    '        Try
    '            Dim Data As String = Sub16.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 5, 6
    '                            Foot_16.Visible = False
    '                        Case Else
    '                            '   Foot_Gap_16.Visible = False
    '                            Foot_16.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub TypeName_16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TypeName_16.BeforePrint
    '        Try
    '            Dim Data As String = Sub16.GetCurrentColumnValue("TypeName")
    '            If Data IsNot Nothing Then
    '                TypeName_16.Text = Data.Substring(2, Data.Length - 2)
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '#End Region

    '#Region "Sub17"
    '    Private Sub Sub17_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No1.BeforePrint
    '        Try
    '            Sub17_No1.Text = GetMonthToPrint(1, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No2.BeforePrint
    '        Try
    '            Sub17_No2.Text = GetMonthToPrint(2, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No3.BeforePrint
    '        Try
    '            Sub17_No3.Text = GetMonthToPrint(3, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No4.BeforePrint
    '        Try
    '            Sub17_No4.Text = GetMonthToPrint(4, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No5.BeforePrint
    '        Try
    '            Sub17_No5.Text = GetMonthToPrint(5, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No6.BeforePrint
    '        Try
    '            Sub17_No6.Text = GetMonthToPrint(6, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No7.BeforePrint
    '        Try
    '            Sub17_No7.Text = GetMonthToPrint(7, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No8.BeforePrint
    '        Try
    '            Sub17_No8.Text = GetMonthToPrint(8, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No9.BeforePrint
    '        Try
    '            Sub17_No9.Text = GetMonthToPrint(9, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No10.BeforePrint
    '        Try
    '            Sub17_No10.Text = GetMonthToPrint(10, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No11.BeforePrint
    '        Try
    '            Sub17_No11.Text = GetMonthToPrint(11, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No14.BeforePrint
    '        Try
    '            Sub17_No14.Text = GetMonthToPrint(12, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No13.BeforePrint
    '        Try
    '            Sub17_No13.Text = GetMonthToPrint(13, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No14.BeforePrint
    '        Try
    '            Sub17_No14.Text = GetMonthToPrint(14, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No15.BeforePrint
    '        Try
    '            Sub17_No15.Text = GetMonthToPrint(15, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No16.BeforePrint
    '        Try
    '            Sub17_No16.Text = GetMonthToPrint(16, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub17_No17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No17.BeforePrint
    '        Try
    '            Sub17_No17.Text = GetMonthToPrint(17, Sub17)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub SubBand17_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand17_BasisPeriod.BeforePrint
    '        Try
    '            Dim DateFrom As DateTime = Sub17.GetCurrentColumnValue("DateFrom")
    '            Dim DateTo As DateTime = Sub17.GetCurrentColumnValue("DateTo")
    '            SubBand17_BasisPeriod.Text = "Basis Period: " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYear17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear17.BeforePrint
    '        Try
    '            Dim Data As String = Sub17.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYear17.Visible = False
    '                        Case Else
    '                            lblTotalYear17.Visible = True
    '                    End Select
    '                End If
    '            End If

    '            Data = Sub17.GetCurrentColumnValue("TotalYear")

    '            If Data IsNot Nothing AndAlso IsNumeric(Data) Then
    '                lblTotalYear17.Text = CInt(Data).ToString("N0")
    '            End If
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYearSum17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum17.BeforePrint
    '        Try
    '            Dim Data As String = Sub17.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYearSum17.Visible = False
    '                        Case Else
    '                            lblTotalYearSum17.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotal_Title_17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotal_Title_17.BeforePrint, lblTotal_Tag_17.BeforePrint
    '        Try
    '            Dim row As Object = Sub17.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing Then
    '                lblTotal_Title_17.Text = "Total " & row.ToString.Substring(2, row.ToString.Length - 2).ToLower
    '            End If

    '            row = Sub17.GetCurrentColumnValue("LabelTag")
    '            If row IsNot Nothing Then
    '                lblTotal_Tag_17.Text = row.ToString.Substring(0, 1).ToUpper
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub lblTitle_EndYear_17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitle_EndYear_17.BeforePrint
    '        Try
    '            Dim row As Object = Sub17.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing AndAlso row = "4 INTEREST EXPENSES" Then
    '                lblTitle_EndYear_17.Visible = True
    '            Else
    '                lblTitle_EndYear_17.Visible = False
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_Bot_17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_Bot_17.BeforePrint, line_Top_17.BeforePrint
    '        Try
    '            Dim Data As String = Sub17.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            line_Top_17.WidthF = 740.92
    '                            line_Bot_17.WidthF = 740.92
    '                        Case Else
    '                            line_Top_17.WidthF = 842.04
    '                            line_Bot_17.WidthF = 842.04
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Foot_17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Foot_17.BeforePrint
    '        Try
    '            Dim Data As String = Sub17.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 5, 6
    '                            Foot_17.Visible = False
    '                        Case Else
    '                            '   Foot_Gap_17.Visible = False
    '                            Foot_17.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub TypeName_17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TypeName_17.BeforePrint
    '        Try
    '            Dim Data As String = Sub17.GetCurrentColumnValue("TypeName")
    '            If Data IsNot Nothing Then
    '                TypeName_17.Text = Data.Substring(2, Data.Length - 2)
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '#End Region

    '#Region "Sub18"
    '    Private Sub Sub18_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No1.Text = GetMonthToPrint(1, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No2.Text = GetMonthToPrint(2, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No3.Text = GetMonthToPrint(3, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No4.Text = GetMonthToPrint(4, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No5.Text = GetMonthToPrint(5, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No6.Text = GetMonthToPrint(6, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No7.Text = GetMonthToPrint(7, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No8.Text = GetMonthToPrint(8, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No9.Text = GetMonthToPrint(9, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No10.Text = GetMonthToPrint(10, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No11.Text = GetMonthToPrint(11, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No12.Text = GetMonthToPrint(12, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No13.Text = GetMonthToPrint(13, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No14_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No14.Text = GetMonthToPrint(14, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No15_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No15.Text = GetMonthToPrint(15, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No16_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No16.Text = GetMonthToPrint(16, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No17_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No17.Text = GetMonthToPrint(17, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Sub18_No18_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Sub18_No18.Text = GetMonthToPrint(18, Sub18)
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub SubBand18_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim DateFrom As DateTime = Sub18.GetCurrentColumnValue("DateFrom")
    '            Dim DateTo As DateTime = Sub18.GetCurrentColumnValue("DateTo")
    '            SubBand18_BasisPeriod.Text = "Basis Period: " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYear18_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim Data As String = Sub18.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYear18.Visible = False
    '                        Case Else
    '                            lblTotalYear18.Visible = True
    '                    End Select
    '                End If
    '            End If
    '            Data = Sub18.GetCurrentColumnValue("TotalYear")

    '            If Data IsNot Nothing AndAlso IsNumeric(Data) Then
    '                lblTotalYear18.Text = CInt(Data).ToString("N0")
    '            End If
    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotalYearSum18_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim Data As String = Sub18.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            lblTotalYearSum18.Visible = False
    '                        Case Else
    '                            lblTotalYearSum18.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub lblTotal_Title_18_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim row As Object = Sub18.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing Then
    '                lblTotal_Title_18.Text = "Total " & row.ToString.Substring(2, row.ToString.Length - 2).ToLower
    '            End If

    '            row = Sub18.GetCurrentColumnValue("LabelTag")
    '            If row IsNot Nothing Then
    '                lblTotal_Tag_18.Text = row.ToString.Substring(0, 1).ToUpper
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub lblTitle_EndYear_18_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim row As Object = Sub18.GetCurrentColumnValue("TypeName")

    '            If row IsNot Nothing AndAlso row = "4 INTEREST EXPENSES" Then
    '                lblTitle_EndYear_18.Visible = True
    '            Else
    '                lblTitle_EndYear_18.Visible = False
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_Bot_18_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim Data As String = Sub18.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 1, 2, 3
    '                            line_Top_18.WidthF = 872.01
    '                            line_Bot_18.WidthF = 872.01
    '                        Case Else
    '                            line_Top_18.WidthF = 970.5
    '                            line_Bot_18.WidthF = 970.5
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    End Sub
    '    Private Sub Foot_18_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim Data As String = Sub18.GetCurrentColumnValue("TypeName")

    '            If Data IsNot Nothing Then
    '                Dim Type As String = Data.Substring(0, 1)

    '                If IsNumeric(Type) Then
    '                    Select Case CInt(Type)
    '                        Case 5, 6
    '                            Foot_18.Visible = False
    '                        Case Else
    '                            '   Foot_Gap_18.Visible = False
    '                            Foot_18.Visible = True
    '                    End Select
    '                End If
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub TypeName_18_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim Data As String = Sub18.GetCurrentColumnValue("TypeName")
    '            If Data IsNot Nothing Then
    '                TypeName_18.Text = Data.Substring(2, Data.Length - 2)
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '#End Region

End Class