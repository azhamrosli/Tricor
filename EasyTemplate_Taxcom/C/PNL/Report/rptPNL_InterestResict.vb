Public Class rptPNL_InterestResict
    ''title.BeforePrint,
    ''    No1.BeforePrint, No2.BeforePrint, No3.BeforePrint, No4.BeforePrint, No5.BeforePrint, No6.BeforePrint,
    ''    No7.BeforePrint, No8.BeforePrint, No9.BeforePrint, No10.BeforePrint, No11.BeforePrint, No12.BeforePrint,
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
    ''                Case 12
    ''                    obj = No11
    ''                    If i > TotalDynamicNo Then
    ''                        obj.Visible = False
    ''                    End If
    ''                Case 13
    ''                    obj = No12
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
    ''    No7.BeforePrint, No8.BeforePrint, No9.BeforePrint, No10.BeforePrint, No11.BeforePrint, No12.BeforePrint,
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
    ''                Case 12
    ''                    obj = No11
    ''                Case 13
    ''                    obj = No12
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
    ''    '        Case 12
    ''    '            obj = No11
    ''    '            '  obj.Visible = False
    ''    '        Case 13
    ''    '            obj = No12
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
    ''    '        Case 12
    ''    '            obj = No11
    ''    '        Case 13
    ''    '            obj = No12
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
    ''    '        Case 12
    ''    '            obj = No11
    ''    '            obj.Visible = False
    ''    '        Case 13
    ''    '            obj = No12
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
    ''    '        Case 12
    ''    '            obj = No11
    ''    '        Case 13
    ''    '            obj = No12
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

    '    No10.BeforePrint, No11.BeforePrint, No12.BeforePrint,
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
            Dim objColumn As Object = Me.GetCurrentColumnValue("TotalColumn")
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
            Dim objColumn As Object = Me.GetCurrentColumnValue("TotalColumn")
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
            Dim objColumn As Object = Me.GetCurrentColumnValue("TotalColumn")
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
            Dim objColumn As Object = Me.GetCurrentColumnValue("TotalColumn")
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
            Dim objColumn As Object = Me.GetCurrentColumnValue("TotalColumn")
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
            Dim objColumn As Object = Me.GetCurrentColumnValue("TotalColumn")
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
            Dim objColumn As Object = Me.GetCurrentColumnValue("TotalColumn")
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
End Class