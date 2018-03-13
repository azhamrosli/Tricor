Public Class rptPNL_InterestResict
    ''title.BeforePrint,
    ''    No1.BeforePrint, No2.BeforePrint, No3.BeforePrint, No4.BeforePrint, No5.BeforePrint, No6.BeforePrint,
    ''    No7.BeforePrint, No8.BeforePrint, No9.BeforePrint, No10.BeforePrint, No11.BeforePrint, No14.BeforePrint,
    ''    No13.BeforePrint, No14.BeforePrint, No15.BeforePrint, No16.BeforePrint, No17.BeforePrint, No18.BeforePrint, totalthisyear.BeforePrint

    ''Private Sub Detail_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Detail.BeforePrint
    ''    Try
    ''        Dim TotalDynamicNo As Integer = 0
    ''        Dim objColumn As Object = Me.GetCurrentColumnValue("TotalColumn")

    ''        If objColumn IsNot Nothing AndAlso IsNumeric(objColumn) Then
    ''            TotalDynamicNo = CInt(objColumn)
    ''        Else
    ''            TotalDynamicNo = 0
    ''        End If
    ''        TotalDynamicNo += 3

    ''        Dim obj As DevExpress.XtraReports.UI.XRTableCell
    ''        For i As Integer = 0 To 21
    ''            obj = Nothing
    ''            Select Case i
    ''                Case 0
    ''                    obj = labelTagID
    ''                Case 1
    ''                    obj = title
    ''                Case 2
    ''                    obj = No1
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 3
    ''                    obj = No2
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 4
    ''                    obj = No3
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 5
    ''                    obj = No4
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 6
    ''                    obj = No5
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 7
    ''                    obj = No6
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 8
    ''                    obj = No7
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 9
    ''                    obj = No8
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 10
    ''                    obj = No9
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 11
    ''                    obj = No10
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 14
    ''                    obj = No11
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 13
    ''                    obj = No14
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 14
    ''                    obj = No13
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 15
    ''                    obj = No14
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 16
    ''                    obj = No15
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 17
    ''                    obj = No16
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 18
    ''                    obj = No17
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 19
    ''                    obj = No18
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 20
    ''                    obj = totalthisyear
    ''            End Select
    ''        Next

    ''    Catch ex As Exception

    ''    End Try
    ''End Sub
    ''Dim CurrLocation As Decimal = 0
    ''Private Sub Cell_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles labelTagID.BeforePrint, title.BeforePrint,
    ''    No1.BeforePrint, No2.BeforePrint, No3.BeforePrint, No4.BeforePrint, No5.BeforePrint, No6.BeforePrint,
    ''    No7.BeforePrint, No8.BeforePrint, No9.BeforePrint, No10.BeforePrint, No11.BeforePrint, No14.BeforePrint,
    ''    No13.BeforePrint, No14.BeforePrint, No15.BeforePrint, No16.BeforePrint, No17.BeforePrint, No18.BeforePrint, totalthisyear.BeforePrint
    ''    Try
    ''        Dim count As Integer = 0
    ''        Dim TotalDynamicNo As Integer = 0
    ''        Dim objColumn As Object = Me.GetCurrentColumnValue("TotalColumn")

    ''        If objColumn IsNot Nothing AndAlso IsNumeric(objColumn) Then
    ''            TotalDynamicNo = CInt(objColumn)
    ''        Else
    ''            TotalDynamicNo = 0
    ''        End If
    ''        Dim obj As DevExpress.XtraReports.UI.XRTableCell

    ''        For i As Integer = 0 To 21
    ''            obj = Nothing
    ''            Select Case i
    ''                Case 0
    ''                    obj = labelTagID
    ''                    ' TotalWidthColumnFixed += obj.WidthF
    ''                Case 1
    ''                    obj = title
    ''                    ' TotalWidthColumnFixed += obj.WidthF
    ''                Case 2
    ''                    obj = No1
    ''                Case 3
    ''                    obj = No2
    ''                Case 4
    ''                    obj = No3
    ''                Case 5
    ''                    obj = No4
    ''                Case 6
    ''                    obj = No5
    ''                Case 7
    ''                    obj = No6
    ''                Case 8
    ''                    obj = No7
    ''                Case 9
    ''                    obj = No8
    ''                Case 10
    ''                    obj = No9
    ''                Case 11
    ''                    obj = No10
    ''                Case 14
    ''                    obj = No11
    ''                Case 13
    ''                    obj = No14
    ''                Case 14
    ''                    obj = No13
    ''                Case 15
    ''                    obj = No14
    ''                Case 16
    ''                    obj = No15
    ''                Case 17
    ''                    obj = No16
    ''                Case 18
    ''                    obj = No17
    ''                Case 19
    ''                    obj = No18
    ''                Case 20
    ''            End Select

    ''            Select Case i
    ''                Case 0, 1, 20
    ''                Case Else
    ''                    count += 1
    ''                    If count > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''            End Select

    ''            If TypeOf sender Is DevExpress.XtraReports.UI.XRTableCell Then
    ''                If obj.Name = CType(sender, DevExpress.XtraReports.UI.XRTableCell).Name Then
    ''                    If obj.Visible = True Then
    ''                        ' obj.WidthF = 69
    ''                        'CurrLocation += obj.WidthF
    ''                        'obj.LocationF = New PointF(CurrLocation, obj.LocationF.Y)
    ''                        Select Case i
    ''                            Case 0, 1, 20
    ''                            Case Else
    ''                                obj.WidthF = (1048 - 228) / TotalDynamicNo
    ''                        End Select
    ''                    Else
    ''                        obj.WidthF = 0
    ''                        obj.Visible = False
    ''                        obj.LocationF = New PointF(0, obj.LocationF.Y)
    ''                    End If
    ''                    Application.DoEvents()
    ''                End If
    ''            End If
    ''            'If obj IsNot Nothing Then
    ''            '    '  TotalVisible += 1
    ''            '    If obj.Visible Then
    ''            '        TotalVisible += 1
    ''            '    End If
    ''            'End If
    ''        Next

    ''    Catch ex As Exception

    ''    End Try
    ''    'Dim PageWidth As Integer = 1048
    ''    'Dim TotalWidthColumnFixed As Integer = 3
    ''    'Dim Width As Decimal = 0
    ''    'Dim TotalDynamicNo As Integer = 0
    ''    'Dim CurrLocation As Integer = 0
    ''    'Dim TotalVisible As Integer = 0
    ''    'Dim obj As DevExpress.XtraReports.UI.XRTableCell
    ''    'Dim count As Integer = 0
    ''    'Dim objColumn As Object = Me.GetCurrentColumnValue("TotalColumn")

    ''    'If objColumn IsNot Nothing AndAlso IsNumeric(objColumn) Then
    ''    '    TotalDynamicNo = CInt(objColumn)
    ''    'Else
    ''    '    TotalDynamicNo = 0
    ''    'End If

    ''    'For i As Integer = 0 To 21
    ''    '    obj = Nothing
    ''    '    Select Case i
    ''    '        Case 0
    ''    '            obj = labelTagID
    ''    '            ' TotalWidthColumnFixed += obj.WidthF
    ''    '        Case 1
    ''    '            obj = title
    ''    '            ' TotalWidthColumnFixed += obj.WidthF
    ''    '        Case 2
    ''    '            obj = No1
    ''    '        Case 3
    ''    '            obj = No2
    ''    '        Case 4
    ''    '            obj = No3
    ''    '        Case 5
    ''    '            obj = No4
    ''    '        Case 6
    ''    '            obj = No5
    ''    '        Case 7
    ''    '            obj = No6
    ''    '        Case 8
    ''    '            obj = No7
    ''    '        Case 9
    ''    '            obj = No8
    ''    '        Case 10
    ''    '            obj = No9
    ''    '        Case 11
    ''    '            obj = No10
    ''    '        Case 14
    ''    '            obj = No11
    ''    '            '  obj.Visible = False
    ''    '        Case 13
    ''    '            obj = No14
    ''    '            'obj.Visible = False
    ''    '        Case 14
    ''    '            obj = No13
    ''    '            obj.Visible = False
    ''    '        Case 15
    ''    '            obj = No14
    ''    '            obj.Visible = False
    ''    '        Case 16
    ''    '            obj = No15
    ''    '            obj.Visible = False
    ''    '        Case 17
    ''    '            obj = No16
    ''    '            obj.Visible = False
    ''    '        Case 18
    ''    '            obj = No17
    ''    '            obj.Visible = False
    ''    '        Case 19
    ''    '            obj = No18
    ''    '            obj.Visible = False
    ''    '        Case 20
    ''    '            obj = totalthisyear
    ''    '            '  TotalWidthColumnFixed += obj.WidthF
    ''    '    End Select

    ''    '    If obj IsNot Nothing Then
    ''    '        '  TotalVisible += 1
    ''    '        If obj.Visible Then
    ''    '            TotalVisible += 1
    ''    '        End If
    ''    '    End If
    ''    'Next
    ''    'If TotalVisible > 0 Then
    ''    '    Width = PageWidth / TotalVisible
    ''    'Else
    ''    '    Width = PageWidth
    ''    'End If

    ''    'For i As Integer = 0 To 21
    ''    '    obj = Nothing
    ''    '    Select Case i
    ''    '         Case 0
    ''    '            obj = labelTagID
    ''    '        Case 1
    ''    '            obj = title
    ''    '        Case 2
    ''    '            obj = No1
    ''    '        Case 3
    ''    '            obj = No2
    ''    '        Case 4
    ''    '            obj = No3
    ''    '        Case 5
    ''    '            obj = No4
    ''    '        Case 6
    ''    '            obj = No5
    ''    '        Case 7
    ''    '            obj = No6
    ''    '        Case 8
    ''    '            obj = No7
    ''    '        Case 9
    ''    '            obj = No8
    ''    '        Case 10
    ''    '            obj = No9
    ''    '        Case 11
    ''    '            obj = No10
    ''    '        Case 14
    ''    '            obj = No11
    ''    '        Case 13
    ''    '            obj = No14
    ''    '        Case 14
    ''    '            obj = No13
    ''    '        Case 15
    ''    '            obj = No14
    ''    '        Case 16
    ''    '            obj = No15
    ''    '        Case 17
    ''    '            obj = No16
    ''    '        Case 18
    ''    '            obj = No17
    ''    '        Case 19
    ''    '            obj = No18
    ''    '        Case 20
    ''    '            obj = totalthisyear
    ''    '    End Select
    ''    '    If obj IsNot Nothing Then
    ''    '        If obj.Visible Then
    ''    '            obj.WidthF = Width
    ''    '            CurrLocation += Width
    ''    '            obj.BorderWidth = 1
    ''    '            obj.Borders = DevExpress.XtraPrinting.BorderSide.Left
    ''    '            obj.LocationF = New PointF(CurrLocation, obj.LocationF.Y)
    ''    '        Else
    ''    '            obj.WidthF = 0
    ''    '            obj.BackColor = Color.Blue
    ''    '            obj.BorderWidth = 1
    ''    '            obj.Borders = DevExpress.XtraPrinting.BorderSide.Left
    ''    '        End If

    ''    '    End If
    ''    'Next

    ''    'CurrLocation += 0
    ''    ' TotalWidthColumnFixed = labelTagID.WidthF + title.WidthF + totalthisyear.WidthF

    ''    'For i As Integer = 0 To 21
    ''    '    obj = Nothing
    ''    '    Select Case i
    ''    '        Case 0
    ''    '            obj = labelTagID
    ''    '            TotalWidthColumnFixed += obj.WidthF
    ''    '        Case 1
    ''    '            obj = title
    ''    '            TotalWidthColumnFixed += obj.WidthF
    ''    '        Case 2
    ''    '            obj = No1
    ''    '        Case 3
    ''    '            obj = No2
    ''    '        Case 4
    ''    '            obj = No3
    ''    '        Case 5
    ''    '            obj = No4
    ''    '        Case 6
    ''    '            obj = No5
    ''    '        Case 7
    ''    '            obj = No6
    ''    '        Case 8
    ''    '            obj = No7
    ''    '        Case 9
    ''    '            obj = No8
    ''    '        Case 10
    ''    '            obj = No9
    ''    '        Case 11
    ''    '            obj = No10
    ''    '        Case 14
    ''    '            obj = No11
    ''    '            obj.Visible = False
    ''    '        Case 13
    ''    '            obj = No14
    ''    '            obj.Visible = False
    ''    '        Case 14
    ''    '            obj = No13
    ''    '            obj.Visible = False
    ''    '        Case 15
    ''    '            obj = No14
    ''    '            obj.Visible = False
    ''    '        Case 16
    ''    '            obj = No15
    ''    '            obj.Visible = False
    ''    '        Case 17
    ''    '            obj = No16
    ''    '            obj.Visible = False
    ''    '        Case 18
    ''    '            obj = No17
    ''    '            obj.Visible = False
    ''    '        Case 19
    ''    '            obj = No18
    ''    '            obj.Visible = False
    ''    '        Case 20
    ''    '            obj = totalthisyear
    ''    '            TotalWidthColumnFixed += obj.WidthF
    ''    '    End Select

    ''    '    If obj IsNot Nothing Then
    ''    '        '  TotalVisible += 1
    ''    '        If obj.Visible Then
    ''    '            TotalVisible += 1
    ''    '        End If
    ''    '        'Select Case i
    ''    '        '    Case 0, 1, 20
    ''    '        '        obj.Visible = True
    ''    '        '    Case Else
    ''    '        '        count += 1
    ''    '        '        If count <= TotalDynamicNo Then
    ''    '        '            obj.Visible = True
    ''    '        '            TotalVisible += 1
    ''    '        '        Else
    ''    '        '            obj.Visible = False
    ''    '        '        End If
    ''    '        'End Select

    ''    '    End If
    ''    'Next

    ''    'If TotalVisible > 0 Then
    ''    '    Width = (PageWidth - TotalWidthColumnFixed) / TotalVisible
    ''    'Else
    ''    '    Width = PageWidth
    ''    'End If

    ''    'For i As Integer = 0 To 21
    ''    '    Select Case i
    ''    '        Case 0
    ''    '            obj = labelTagID
    ''    '        Case 1
    ''    '            obj = title
    ''    '        Case 2
    ''    '            obj = No1
    ''    '        Case 3
    ''    '            obj = No2
    ''    '        Case 4
    ''    '            obj = No3
    ''    '        Case 5
    ''    '            obj = No4
    ''    '        Case 6
    ''    '            obj = No5
    ''    '        Case 7
    ''    '            obj = No6
    ''    '        Case 8
    ''    '            obj = No7
    ''    '        Case 9
    ''    '            obj = No8
    ''    '        Case 10
    ''    '            obj = No9
    ''    '        Case 11
    ''    '            obj = No10
    ''    '        Case 14
    ''    '            obj = No11
    ''    '        Case 13
    ''    '            obj = No14
    ''    '        Case 14
    ''    '            obj = No13
    ''    '        Case 15
    ''    '            obj = No14
    ''    '        Case 16
    ''    '            obj = No15
    ''    '        Case 17
    ''    '            obj = No16
    ''    '        Case 18
    ''    '            obj = No17
    ''    '        Case 19
    ''    '            obj = No18
    ''    '        Case 20
    ''    '            obj = totalthisyear
    ''    '    End Select

    ''    '    If obj.Visible Then

    ''    '        Select Case i
    ''    '            Case 0, 1, 20

    ''    '            Case Else
    ''    '                obj.WidthF = Width
    ''    '        End Select
    ''    '        CurrLocation += obj.WidthF
    ''    '        obj.LocationF = New PointF(CurrLocation, obj.LocationF.Y)
    ''    '    Else
    ''    '        obj.Text = ""
    ''    '        obj.WidthF = 0
    ''    '    End If
    ''    '    Application.DoEvents()

    ''    'Next





    ''End Sub

    'Private Sub label_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '    Try
    '        Dim obj As DevExpress.XtraReports.UI.XRTableCell = Nothing
    '        obj = CType(sender, DevExpress.XtraReports.UI.XRTableCell)
    '        obj.WidthF = 92

    '    Catch ex As Exception

    '    End Try
    'End Sub
    'Private Sub No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles No1.BeforePrint,

    '    No10.BeforePrint, No11.BeforePrint, No14.BeforePrint,
    '   No13.BeforePrint, No14.BeforePrint, No15.BeforePrint, No16.BeforePrint, No17.BeforePrint, No18.BeforePrint
    '    Try
    '        Calc(sender)
    '    Catch ex As Exception

    '    End Try
    'End Sub
    'Private Sub Calc(ByVal sender As Object)
    '    Try
    '        Dim TotalDynamicNo As Integer = 0
    '        Dim CurrLocation As Integer = 0
    '        Dim obj As DevExpress.XtraReports.UI.XRTableCell = Nothing
    '        Dim objColumn As Object = Me.GetCurrentColumnValue("TotalColumn")
    '        Dim TmpNo As Integer = 0
    '        If objColumn IsNot Nothing AndAlso IsNumeric(objColumn) Then
    '            TotalDynamicNo = CInt(objColumn)
    '        Else
    '            TotalDynamicNo = 0
    '        End If

    '        If TypeOf sender Is DevExpress.XtraReports.UI.XRTableCell Then
    '            obj = CType(sender, DevExpress.XtraReports.UI.XRTableCell)
    '            XrTable1.WidthF = 1000
    '            Application.DoEvents()
    '            If IsNumeric(obj.Name.ToString.Replace("No", "")) Then
    '                TmpNo = obj.Name.ToString.Replace("No", "")
    '            End If

    '            If TmpNo <= TotalDynamicNo Then
    '                obj.Visible = True
    '            Else
    '                obj.Visible = False
    '            End If
    '            Application.DoEvents()

    '            If obj.Visible = True Then
    '                'obj.WidthF = Math.Round(CDec((1048 - 228) / TotalDynamicNo), System.MidpointRounding.ToEven)
    '                'Application.DoEvents()

    '                'CurrLocation = (obj.WidthF * TmpNo) + 136
    '                'obj.LocationF = New PointF(CurrLocation, obj.LocationF.Y)
    '                'CurrLocation = (10 * TmpNo) + 136
    '                'obj.LocationF = New PointF(CurrLocation, obj.LocationF.Y)
    '                obj.WidthF = 60

    '            Else
    '                obj.WidthF = 0
    '                obj.Visible = True
    '                obj.LocationF = New PointF(0, obj.LocationF.Y)
    '            End If

    '            Application.DoEvents()
    '            'ElseIf TypeOf sender Is DevExpress.XtraReports.UI.XRTable Then
    '            '    Dim objtbl As DevExpress.XtraReports.UI.XRTable = Nothing
    '            '    objtbl = CType(sender, DevExpress.XtraReports.UI.XRTable)
    '            '    objtbl.WidthF = 1048
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub XrTable1_BeforePrint(sender As Object, e As Printing.PrintEventArgs)

    'End Sub

    'Private Sub rptPNL_InterestResict_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint

    'End Sub

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
            If 12 <= TotalDynamicNo Then
                Sub12.Visible = True
            Else
                Sub12.Visible = False
            End If
        Catch ex As Exception

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
            If 13 <= TotalDynamicNo Then
                Sub13.Visible = True
            Else
                Sub13.Visible = False
            End If
        Catch ex As Exception

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
            If 14 <= TotalDynamicNo Then
                Sub14.Visible = True
            Else
                Sub14.Visible = False
            End If
        Catch ex As Exception

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
            If 15 <= TotalDynamicNo Then
                Sub15.Visible = True
            Else
                Sub15.Visible = False
            End If
        Catch ex As Exception

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
            If 16 <= TotalDynamicNo Then
                Sub16.Visible = True
            Else
                Sub16.Visible = False
            End If
        Catch ex As Exception

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
            If 17 <= TotalDynamicNo Then
                Sub17.Visible = True
            Else
                Sub17.Visible = False
            End If
        Catch ex As Exception

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
            If 18 <= TotalDynamicNo Then
                Sub18.Visible = True
            Else
                Sub18.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

#Region "Sub12"
    Private Sub Sub12_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12_No1.BeforePrint
        Try
            Sub12_No1.Text = GetMonthToPrint(1, Sub12)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub12_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12_No2.BeforePrint
        Try
            Sub12_No2.Text = GetMonthToPrint(2, Sub12)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub12_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12_No3.BeforePrint
        Try
            Sub12_No3.Text = GetMonthToPrint(3, Sub12)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub12_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12_No4.BeforePrint
        Try
            Sub12_No4.Text = GetMonthToPrint(4, Sub12)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub12_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12_No5.BeforePrint
        Try
            Sub12_No5.Text = GetMonthToPrint(5, Sub12)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub12_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12_No6.BeforePrint
        Try
            Sub12_No6.Text = GetMonthToPrint(6, Sub12)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub12_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12_No7.BeforePrint
        Try
            Sub12_No7.Text = GetMonthToPrint(7, Sub12)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub12_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12_No8.BeforePrint
        Try
            Sub12_No8.Text = GetMonthToPrint(8, Sub12)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub12_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12_No9.BeforePrint
        Try
            Sub12_No9.Text = GetMonthToPrint(9, Sub12)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub12_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12_No10.BeforePrint
        Try
            Sub12_No10.Text = GetMonthToPrint(10, Sub12)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub12_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12_No11.BeforePrint
        Try
            Sub12_No11.Text = GetMonthToPrint(11, Sub12)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub12_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub12_No12.BeforePrint
        Try
            Sub12_No12.Text = GetMonthToPrint(12, Sub12)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SubBand12_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand12_BasisPeriod.BeforePrint
        Try
            Dim DateFrom As DateTime = Sub12.GetCurrentColumnValue("DateFrom")
            Dim DateTo As DateTime = Sub12.GetCurrentColumnValue("DateTo")
            SubBand12_BasisPeriod.Text = "Basis Period " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYear12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear12.BeforePrint
        Try
            Dim Data As String = Sub12.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYear12.Visible = False
                        Case Else
                            lblTotalYear12.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYearSum12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum12.BeforePrint
        Try
            Dim Data As String = Sub12.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYearSum12.Visible = False
                        Case Else
                            lblTotalYearSum12.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Sub13"
    Private Sub Sub13_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No1.BeforePrint
        Try
            Sub13_No1.Text = GetMonthToPrint(1, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub13_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No2.BeforePrint
        Try
            Sub13_No2.Text = GetMonthToPrint(2, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub13_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No3.BeforePrint
        Try
            Sub13_No3.Text = GetMonthToPrint(3, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub13_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No4.BeforePrint
        Try
            Sub13_No4.Text = GetMonthToPrint(4, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub13_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No5.BeforePrint
        Try
            Sub13_No5.Text = GetMonthToPrint(5, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub13_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No6.BeforePrint
        Try
            Sub13_No6.Text = GetMonthToPrint(6, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub13_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No7.BeforePrint
        Try
            Sub13_No7.Text = GetMonthToPrint(7, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub13_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No8.BeforePrint
        Try
            Sub13_No8.Text = GetMonthToPrint(8, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub13_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No9.BeforePrint
        Try
            Sub13_No9.Text = GetMonthToPrint(9, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub13_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No10.BeforePrint
        Try
            Sub13_No10.Text = GetMonthToPrint(10, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub13_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No11.BeforePrint
        Try
            Sub13_No11.Text = GetMonthToPrint(11, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub13_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No12.BeforePrint
        Try
            Sub13_No13.Text = GetMonthToPrint(14, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub13_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub13_No13.BeforePrint
        Try
            Sub13_No13.Text = GetMonthToPrint(13, Sub13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SubBand13_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand13_BasisPeriod.BeforePrint
        Try
            Dim DateFrom As DateTime = Sub13.GetCurrentColumnValue("DateFrom")
            Dim DateTo As DateTime = Sub13.GetCurrentColumnValue("DateTo")
            SubBand13_BasisPeriod.Text = "Basis Period " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYear13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear13.BeforePrint
        Try
            Dim Data As String = Sub13.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYear13.Visible = False
                        Case Else
                            lblTotalYear13.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYearSum13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum13.BeforePrint
        Try
            Dim Data As String = Sub13.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYearSum13.Visible = False
                        Case Else
                            lblTotalYearSum13.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Sub14"
    Private Sub Sub14_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No1.BeforePrint
        Try
            Sub14_No1.Text = GetMonthToPrint(1, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No2.BeforePrint
        Try
            Sub14_No2.Text = GetMonthToPrint(2, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No3.BeforePrint
        Try
            Sub14_No3.Text = GetMonthToPrint(3, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No4.BeforePrint
        Try
            Sub14_No4.Text = GetMonthToPrint(4, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No5.BeforePrint
        Try
            Sub14_No5.Text = GetMonthToPrint(5, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No6.BeforePrint
        Try
            Sub14_No6.Text = GetMonthToPrint(6, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No7.BeforePrint
        Try
            Sub14_No7.Text = GetMonthToPrint(7, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No8.BeforePrint
        Try
            Sub14_No8.Text = GetMonthToPrint(8, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No9.BeforePrint
        Try
            Sub14_No9.Text = GetMonthToPrint(9, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No10.BeforePrint
        Try
            Sub14_No10.Text = GetMonthToPrint(10, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No11.BeforePrint
        Try
            Sub14_No11.Text = GetMonthToPrint(11, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No14.BeforePrint
        Try
            Sub14_No14.Text = GetMonthToPrint(14, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No13.BeforePrint
        Try
            Sub14_No13.Text = GetMonthToPrint(13, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub14_No14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub14_No14.BeforePrint
        Try
            Sub14_No14.Text = GetMonthToPrint(14, Sub14)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SubBand14_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand14_BasisPeriod.BeforePrint
        Try
            Dim DateFrom As DateTime = Sub14.GetCurrentColumnValue("DateFrom")
            Dim DateTo As DateTime = Sub14.GetCurrentColumnValue("DateTo")
            SubBand14_BasisPeriod.Text = "Basis Period " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYear14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear14.BeforePrint
        Try
            Dim Data As String = Sub14.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYear14.Visible = False
                        Case Else
                            lblTotalYear14.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYearSum14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum14.BeforePrint
        Try
            Dim Data As String = Sub14.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYearSum14.Visible = False
                        Case Else
                            lblTotalYearSum14.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Sub15"
    Private Sub Sub15_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No1.BeforePrint
        Try
            Sub15_No1.Text = GetMonthToPrint(1, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No2.BeforePrint
        Try
            Sub15_No2.Text = GetMonthToPrint(2, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No3.BeforePrint
        Try
            Sub15_No3.Text = GetMonthToPrint(3, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No4.BeforePrint
        Try
            Sub15_No4.Text = GetMonthToPrint(4, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No5.BeforePrint
        Try
            Sub15_No5.Text = GetMonthToPrint(5, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No6.BeforePrint
        Try
            Sub15_No6.Text = GetMonthToPrint(6, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No7.BeforePrint
        Try
            Sub15_No7.Text = GetMonthToPrint(7, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No8.BeforePrint
        Try
            Sub15_No8.Text = GetMonthToPrint(8, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No9.BeforePrint
        Try
            Sub15_No9.Text = GetMonthToPrint(9, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No10.BeforePrint
        Try
            Sub15_No10.Text = GetMonthToPrint(10, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No11.BeforePrint
        Try
            Sub15_No11.Text = GetMonthToPrint(11, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No14.BeforePrint
        Try
            Sub15_No14.Text = GetMonthToPrint(14, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No13.BeforePrint
        Try
            Sub15_No13.Text = GetMonthToPrint(13, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No14.BeforePrint
        Try
            Sub15_No14.Text = GetMonthToPrint(14, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub15_No15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub15_No15.BeforePrint
        Try
            Sub15_No15.Text = GetMonthToPrint(15, Sub15)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SubBand15_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand15_BasisPeriod.BeforePrint
        Try
            Dim DateFrom As DateTime = Sub15.GetCurrentColumnValue("DateFrom")
            Dim DateTo As DateTime = Sub15.GetCurrentColumnValue("DateTo")
            SubBand15_BasisPeriod.Text = "Basis Period " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYear15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear15.BeforePrint
        Try
            Dim Data As String = Sub15.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYear15.Visible = False
                        Case Else
                            lblTotalYear15.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYearSum15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum15.BeforePrint
        Try
            Dim Data As String = Sub15.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYearSum15.Visible = False
                        Case Else
                            lblTotalYearSum15.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Sub16"
    Private Sub Sub16_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No1.BeforePrint
        Try
            Sub16_No1.Text = GetMonthToPrint(1, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No2.BeforePrint
        Try
            Sub16_No2.Text = GetMonthToPrint(2, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No3.BeforePrint
        Try
            Sub16_No3.Text = GetMonthToPrint(3, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No4.BeforePrint
        Try
            Sub16_No4.Text = GetMonthToPrint(4, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No5.BeforePrint
        Try
            Sub16_No5.Text = GetMonthToPrint(5, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No6.BeforePrint
        Try
            Sub16_No6.Text = GetMonthToPrint(6, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No7.BeforePrint
        Try
            Sub16_No7.Text = GetMonthToPrint(7, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No8.BeforePrint
        Try
            Sub16_No8.Text = GetMonthToPrint(8, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No9.BeforePrint
        Try
            Sub16_No9.Text = GetMonthToPrint(9, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No10.BeforePrint
        Try
            Sub16_No10.Text = GetMonthToPrint(10, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No11.BeforePrint
        Try
            Sub16_No11.Text = GetMonthToPrint(11, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No14.BeforePrint
        Try
            Sub16_No14.Text = GetMonthToPrint(14, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No13.BeforePrint
        Try
            Sub16_No13.Text = GetMonthToPrint(13, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No14.BeforePrint
        Try
            Sub16_No14.Text = GetMonthToPrint(14, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No15.BeforePrint
        Try
            Sub16_No15.Text = GetMonthToPrint(15, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub16_No16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub16_No16.BeforePrint
        Try
            Sub16_No16.Text = GetMonthToPrint(16, Sub16)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SubBand16_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand16_BasisPeriod.BeforePrint
        Try
            Dim DateFrom As DateTime = Sub16.GetCurrentColumnValue("DateFrom")
            Dim DateTo As DateTime = Sub16.GetCurrentColumnValue("DateTo")
            SubBand16_BasisPeriod.Text = "Basis Period " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYear16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear16.BeforePrint
        Try
            Dim Data As String = Sub16.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYear16.Visible = False
                        Case Else
                            lblTotalYear16.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYearSum16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum16.BeforePrint
        Try
            Dim Data As String = Sub16.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYearSum16.Visible = False
                        Case Else
                            lblTotalYearSum16.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Sub17"
    Private Sub Sub17_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No1.BeforePrint
        Try
            Sub17_No1.Text = GetMonthToPrint(1, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No2.BeforePrint
        Try
            Sub17_No2.Text = GetMonthToPrint(2, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No3.BeforePrint
        Try
            Sub17_No3.Text = GetMonthToPrint(3, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No4.BeforePrint
        Try
            Sub17_No4.Text = GetMonthToPrint(4, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No5.BeforePrint
        Try
            Sub17_No5.Text = GetMonthToPrint(5, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No6.BeforePrint
        Try
            Sub17_No6.Text = GetMonthToPrint(6, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No7.BeforePrint
        Try
            Sub17_No7.Text = GetMonthToPrint(7, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No8.BeforePrint
        Try
            Sub17_No8.Text = GetMonthToPrint(8, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No9.BeforePrint
        Try
            Sub17_No9.Text = GetMonthToPrint(9, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No10.BeforePrint
        Try
            Sub17_No10.Text = GetMonthToPrint(10, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No11.BeforePrint
        Try
            Sub17_No11.Text = GetMonthToPrint(11, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No14.BeforePrint
        Try
            Sub17_No14.Text = GetMonthToPrint(14, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No13.BeforePrint
        Try
            Sub17_No13.Text = GetMonthToPrint(13, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No14.BeforePrint
        Try
            Sub17_No14.Text = GetMonthToPrint(14, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No15.BeforePrint
        Try
            Sub17_No15.Text = GetMonthToPrint(15, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No16.BeforePrint
        Try
            Sub17_No16.Text = GetMonthToPrint(16, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub17_No17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub17_No17.BeforePrint
        Try
            Sub17_No17.Text = GetMonthToPrint(17, Sub17)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SubBand17_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand17_BasisPeriod.BeforePrint
        Try
            Dim DateFrom As DateTime = Sub17.GetCurrentColumnValue("DateFrom")
            Dim DateTo As DateTime = Sub17.GetCurrentColumnValue("DateTo")
            SubBand17_BasisPeriod.Text = "Basis Period " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYear17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear17.BeforePrint
        Try
            Dim Data As String = Sub17.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYear17.Visible = False
                        Case Else
                            lblTotalYear17.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYearSum17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum17.BeforePrint
        Try
            Dim Data As String = Sub17.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYearSum17.Visible = False
                        Case Else
                            lblTotalYearSum17.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Sub18"
    Private Sub Sub18_No1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No1.BeforePrint
        Try
            Sub18_No1.Text = GetMonthToPrint(1, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No2.BeforePrint
        Try
            Sub18_No2.Text = GetMonthToPrint(2, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No3.BeforePrint
        Try
            Sub18_No3.Text = GetMonthToPrint(3, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No4.BeforePrint
        Try
            Sub18_No4.Text = GetMonthToPrint(4, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No5.BeforePrint
        Try
            Sub18_No5.Text = GetMonthToPrint(5, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No6.BeforePrint
        Try
            Sub18_No6.Text = GetMonthToPrint(6, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No7_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No7.BeforePrint
        Try
            Sub18_No7.Text = GetMonthToPrint(7, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No8.BeforePrint
        Try
            Sub18_No8.Text = GetMonthToPrint(8, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No9.BeforePrint
        Try
            Sub18_No9.Text = GetMonthToPrint(9, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No10.BeforePrint
        Try
            Sub18_No10.Text = GetMonthToPrint(10, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No11.BeforePrint
        Try
            Sub18_No11.Text = GetMonthToPrint(11, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No12_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No14.BeforePrint
        Try
            Sub18_No14.Text = GetMonthToPrint(14, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No13_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No13.BeforePrint
        Try
            Sub18_No13.Text = GetMonthToPrint(13, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No14_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No14.BeforePrint
        Try
            Sub18_No14.Text = GetMonthToPrint(14, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No15.BeforePrint
        Try
            Sub18_No15.Text = GetMonthToPrint(15, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No16.BeforePrint
        Try
            Sub18_No16.Text = GetMonthToPrint(16, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No17_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No17.BeforePrint
        Try
            Sub18_No17.Text = GetMonthToPrint(17, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Sub18_No18_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Sub18_No18.BeforePrint
        Try
            Sub18_No18.Text = GetMonthToPrint(18, Sub18)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SubBand18_BasisPeriod_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SubBand18_BasisPeriod.BeforePrint
        Try
            Dim DateFrom As DateTime = Sub18.GetCurrentColumnValue("DateFrom")
            Dim DateTo As DateTime = Sub18.GetCurrentColumnValue("DateTo")
            SubBand18_BasisPeriod.Text = "Basis Period " & Format(DateFrom, "dd.MM.yyyy") & " - " & Format(DateTo, "dd.MM.yyyy")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYear18_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYear18.BeforePrint
        Try
            Dim Data As String = Sub18.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYear18.Visible = False
                        Case Else
                            lblTotalYear18.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblTotalYearSum18_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalYearSum18.BeforePrint
        Try
            Dim Data As String = Sub18.GetCurrentColumnValue("TypeName")

            If Data IsNot Nothing Then
                Dim Type As String = Data.Substring(0, 1)

                If IsNumeric(Type) Then
                    Select Case CInt(Type)
                        Case 1, 2, 3, 4
                            lblTotalYearSum18.Visible = False
                        Case Else
                            lblTotalYearSum18.Visible = True
                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region


    Private Function GetMonthToPrint(ByVal No As Integer, ByVal SubBand As DevExpress.XtraReports.UI.DetailReportBand) As String
        Try


            Dim DateFrom As DateTime = SubBand.GetCurrentColumnValue("DateFrom")
            Dim DateTo As DateTime = SubBand.GetCurrentColumnValue("DateTo")


            Select Case No
                Case 1
                    Return Format(DateFrom, "MMM")
                Case Else
                    Return Format(DateFrom.AddMonths(+(No - 1)), "MMM")
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Class