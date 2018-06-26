Imports DevExpress.XtraReports.UI
Public Class rpt_CASummaryQE
    Private Sub No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles table1.BeforePrint  ', No3.BeforePrint, No8.BeforePrint, No10.BeforePrint, No12.BeforePrint, No14.BeforePrint, No16.BeforePrint, No20.BeforePrint, No40.BeforePrint, No50.BeforePrint, No60.BeforePrint, No8.BeforePrint, No90.BeforePrint, No100.BeforePrint
        Try
            Dim dt As DataTable = Nothing
            dt = ADO.Load_CAReport_SummaryQE_Temp(paramID.Value)

            If dt Is Nothing Then
                Exit Sub
            End If
            Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA()

            Dim tmpStatus As Boolean = False

            Dim TotalWidth As Decimal = 1046
            Dim DynamicWidth As Decimal = 0
            Dim TotalColumn As Integer = 3

            For y As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                For x As Integer = 0 To dt.Rows.Count - 1

                    If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
                        tmpStatus = True
                        If IsNumeric(ListofAA(y).Replace("AA_", "")) Then
                            Select Case CInt(ListofAA(y).Replace("AA_", ""))
                                Case 0
                                    NoClaim.Visible = True
                                    NoClaim_Bot.Visible = True
                                    TotalColumn += 1
                                Case 2
                                    No2.Visible = True
                                    No2_Bot.Visible = True
                                    TotalColumn += 1
                                Case 3
                                    No3.Visible = True
                                    No3_Bot.Visible = True
                                    TotalColumn += 1
                                Case 8
                                    No8.Visible = True
                                    No8_Bot.Visible = True
                                    TotalColumn += 1
                                Case 10
                                    No10.Visible = True
                                    No10_Bot.Visible = True
                                    TotalColumn += 1
                                Case 12
                                    No12.Visible = True
                                    No12_Bot.Visible = True
                                    TotalColumn += 1
                                Case 14
                                    No14.Visible = True
                                    No14_Bot.Visible = True
                                    TotalColumn += 1
                                Case 16
                                    No16.Visible = True
                                    No16_Bot.Visible = True
                                    TotalColumn += 1
                                Case 20
                                    No20.Visible = True
                                    No20_Bot.Visible = True
                                    TotalColumn += 1
                                Case 40
                                    No40.Visible = True
                                    No40_Bot.Visible = True
                                    TotalColumn += 1
                                Case 50
                                    No50.Visible = True
                                    No50_Bot.Visible = True
                                    TotalColumn += 1
                                Case 60
                                    No60.Visible = True
                                    No60_Bot.Visible = True
                                    TotalColumn += 1
                                Case 80
                                    No80.Visible = True
                                    No80_Bot.Visible = True
                                    TotalColumn += 1
                                Case 90
                                    No90.Visible = True
                                    No90_Bot.Visible = True
                                    TotalColumn += 1
                                Case 100
                                    No100.Visible = True
                                    No100_Bot.Visible = True
                                    TotalColumn += 1
                            End Select
                        End If

                    End If

                Next

            Next

            Dim DynamicColumn As Integer = TotalColumn - 3
            Dim BalanceWidth As Decimal = 0

            If DynamicColumn = 0 AndAlso DynamicColumn <= 10 Then
                DynamicWidth = (TotalWidth - 580.66) / DynamicColumn
            Else
                DynamicWidth = (TotalWidth - 565.94) / DynamicColumn
            End If

            If DynamicWidth > 200 Then
                BalanceWidth = (DynamicWidth * DynamicColumn) - (200 * DynamicColumn)
                DynamicWidth = 200

            End If

            If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                NoDescription.WidthF = 304.26 '+ BalanceWidth - 50
                NoDescription_Bot.WidthF = 304.26
            Else
                NoDescription.WidthF = 215.23 '+ BalanceWidth - 50
                NoDescription_Bot.WidthF = 215.23
            End If

            If NoClaim.Visible = False Then
                NoClaim.WidthF = 0
                NoClaim_Bot.WidthF = 0
            Else
                NoClaim.WidthF = DynamicWidth
                NoClaim_Bot.WidthF = DynamicWidth
            End If

            If No2.Visible = False Then
                No2.WidthF = 0
                No2_Bot.WidthF = 0
            Else
                No2.WidthF = DynamicWidth
                No2_Bot.WidthF = DynamicWidth
            End If
            If No3.Visible = False Then
                No3.WidthF = 0
                No3_Bot.WidthF = 0
            Else
                No3.WidthF = DynamicWidth
                No3_Bot.WidthF = DynamicWidth
            End If
            If No8.Visible = False Then
                No8.WidthF = 0
                No8_Bot.WidthF = 0
            Else
                No8.WidthF = DynamicWidth
                No8_Bot.WidthF = DynamicWidth
            End If
            If No10.Visible = False Then
                No10.WidthF = 0
                No10_Bot.WidthF = 0
            Else
                No10.WidthF = DynamicWidth
                No10_Bot.WidthF = DynamicWidth
            End If
            If No12.Visible = False Then
                No12.WidthF = 0
                No12_Bot.WidthF = 0
            Else
                No12.WidthF = DynamicWidth
                No12_Bot.WidthF = DynamicWidth
            End If
            If No14.Visible = False Then
                No14.WidthF = 0
                No14_Bot.WidthF = 0
            Else
                No14.WidthF = DynamicWidth
                No14_Bot.WidthF = DynamicWidth
            End If
            If No16.Visible = False Then
                No16.WidthF = 0
                No16_Bot.WidthF = 0
            Else
                No16.WidthF = DynamicWidth
                No16_Bot.WidthF = DynamicWidth
            End If
            If No20.Visible = False Then
                No20.WidthF = 0
                No20_Bot.WidthF = 0
            Else
                No20.WidthF = DynamicWidth
                No20_Bot.WidthF = DynamicWidth
            End If
            If No40.Visible = False Then
                No40.WidthF = 0
                No40_Bot.WidthF = 0
            Else
                No40.WidthF = DynamicWidth
                No40_Bot.WidthF = DynamicWidth
            End If
            If No50.Visible = False Then
                No50.WidthF = 0
                No50_Bot.WidthF = 0
            Else
                No50.WidthF = DynamicWidth
                No50_Bot.WidthF = DynamicWidth
            End If
            If No60.Visible = False Then
                No60.WidthF = 0
                No60_Bot.WidthF = 0
            Else
                No60.WidthF = DynamicWidth
                No60_Bot.WidthF = DynamicWidth
            End If
            If No80.Visible = False Then
                No80.WidthF = 0
                No80_Bot.WidthF = 0
            Else
                No80.WidthF = DynamicWidth
                No80_Bot.WidthF = DynamicWidth
            End If
            If No90.Visible = False Then
                No90.WidthF = 0
                No90_Bot.WidthF = 0
            Else
                No90.WidthF = DynamicWidth
                No90_Bot.WidthF = DynamicWidth
            End If
            If No100.Visible = False Then
                No100.WidthF = 0
                No100_Bot.WidthF = 0
            Else
                No100.WidthF = DynamicWidth
                No100_Bot.WidthF = DynamicWidth
            End If

            If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                NoTotal.WidthF = 138.2
                NoTotal_Bot.WidthF = 138.2
            Else
                NoTotal.WidthF = 131.84
                NoTotal_Bot.WidthF = 131.84
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub table2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles table2.BeforePrint
        Try
            Dim dt As DataTable = Nothing
            dt = ADO.Load_CAReport_SummaryQE_Temp(paramID.Value)

            If dt Is Nothing Then
                Exit Sub
            End If

            Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA(True)

            Dim tmpStatus As Boolean = False

            Dim TotalWidth As Decimal = 1046
            Dim DynamicWidth As Decimal = 0
            Dim TotalColumn As Integer = 3

            For y As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                For x As Integer = 0 To dt.Rows.Count - 1

                    If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
                        tmpStatus = True
                        If IsNumeric(ListofAA(y).Replace("AA_", "")) Then
                            Select Case CInt(ListofAA(y).Replace("AA_", ""))
                                Case 0
                                    NoClaim_Details.Visible = True
                                    TotalColumn += 1
                                Case 2
                                    No2_Details.Visible = True
                                    TotalColumn += 1
                                Case 3
                                    No3_Details.Visible = True
                                    TotalColumn += 1
                                Case 8
                                    No8_Details.Visible = True
                                    TotalColumn += 1
                                Case 10
                                    No10_Details.Visible = True
                                    TotalColumn += 1
                                Case 12
                                    No12_Details.Visible = True
                                    TotalColumn += 1
                                Case 14
                                    No14_Details.Visible = True
                                    TotalColumn += 1
                                Case 16
                                    No16_Details.Visible = True
                                    TotalColumn += 1
                                Case 20
                                    No20_Details.Visible = True
                                    TotalColumn += 1
                                Case 40
                                    No40_Details.Visible = True
                                    TotalColumn += 1
                                Case 50
                                    No50_Details.Visible = True
                                    TotalColumn += 1
                                Case 60
                                    No60_Details.Visible = True
                                    TotalColumn += 1
                                Case 80
                                    No80_Details.Visible = True
                                    TotalColumn += 1
                                Case 90
                                    No90_Details.Visible = True
                                    TotalColumn += 1
                                Case 100
                                    No100_Details.Visible = True
                                    TotalColumn += 1
                            End Select
                        End If

                    End If

                Next

            Next

            Dim DynamicColumn As Integer = TotalColumn - 3
            Dim BalanceWidth As Decimal = 0

            If DynamicColumn = 0 AndAlso DynamicColumn <= 10 Then
                DynamicWidth = (TotalWidth - 580.66) / DynamicColumn
            Else
                DynamicWidth = (TotalWidth - 565.94) / DynamicColumn
            End If

            If DynamicWidth > 200 Then
                BalanceWidth = (DynamicWidth * DynamicColumn) - (200 * DynamicColumn)
                DynamicWidth = 200

            End If

            If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                NoDescription_Details.WidthF = 304.26 '+ BalanceWidth - 50
            Else
                NoDescription_Details.WidthF = 215.23 '+ BalanceWidth - 50
            End If

            If NoClaim_Details.Visible = False Then
                NoClaim_Details.WidthF = 0
            Else
                NoClaim_Details.WidthF = DynamicWidth
            End If

            If No2.Visible = False Then
                No2_Details.WidthF = 0
            Else
                No2_Details.WidthF = DynamicWidth
            End If
            If No3.Visible = False Then
                No3_Details.WidthF = 0
            Else
                No3_Details.WidthF = DynamicWidth
            End If
            If No8.Visible = False Then
                No8_Details.WidthF = 0
            Else
                No8_Details.WidthF = DynamicWidth
            End If
            If No10.Visible = False Then
                No10_Details.WidthF = 0
            Else
                No10_Details.WidthF = DynamicWidth
            End If
            If No12.Visible = False Then
                No12_Details.WidthF = 0
            Else
                No12_Details.WidthF = DynamicWidth
            End If
            If No14.Visible = False Then
                No14_Details.WidthF = 0
            Else
                No14_Details.WidthF = DynamicWidth
            End If
            If No16.Visible = False Then
                No16_Details.WidthF = 0
            Else
                No16_Details.WidthF = DynamicWidth
            End If
            If No20.Visible = False Then
                No20_Details.WidthF = 0
            Else
                No20_Details.WidthF = DynamicWidth
            End If
            If No40.Visible = False Then
                No40_Details.WidthF = 0
            Else
                No40_Details.WidthF = DynamicWidth
            End If
            If No50.Visible = False Then
                No50_Details.WidthF = 0
            Else
                No50_Details.WidthF = DynamicWidth
            End If
            If No60.Visible = False Then
                No60_Details.WidthF = 0
            Else
                No60_Details.WidthF = DynamicWidth
            End If
            If No80.Visible = False Then
                No80_Details.WidthF = 0
            Else
                No80_Details.WidthF = DynamicWidth
            End If
            If No90.Visible = False Then
                No90_Details.WidthF = 0
            Else
                No90_Details.WidthF = DynamicWidth
            End If
            If No100.Visible = False Then
                No100_Details.WidthF = 0
            Else
                No100_Details.WidthF = DynamicWidth
            End If

            If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                NoTotal_Details.WidthF = 138.2
            Else
                NoTotal_Details.WidthF = 131.84
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub table2_Report_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles table2_Report.BeforePrint
        Try
            Dim dt As DataTable = Nothing
            dt = ADO.Load_CAReport_SummaryQE_Temp(paramID.Value)

            If dt Is Nothing Then
                Exit Sub
            End If
            Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA(True)

            Dim tmpStatus As Boolean = False

            Dim TotalWidth As Decimal = 1046
            Dim DynamicWidth As Decimal = 0
            Dim TotalColumn As Integer = 3

            Dim StartCell As XRTableCell = Nothing
            Dim LasttCell As XRTableCell = Nothing
            Dim isFirst As Boolean = False
            Dim isLast As Boolean = False
            Dim TotalWith As Decimal = 0

            For y As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                For x As Integer = 0 To dt.Rows.Count - 1

                    If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
                        tmpStatus = True
                        If IsNumeric(ListofAA(y).Replace("AA_", "")) Then
                            Select Case CInt(ListofAA(y).Replace("AA_", ""))
                                Case 0
                                    NoClaim_Report.Visible = True
                                    TotalColumn += 1
                                Case 2
                                    No2_Report.Visible = True
                                    TotalColumn += 1
                                Case 3
                                    No3_Report.Visible = True
                                    TotalColumn += 1
                                Case 8
                                    No8_Report.Visible = True
                                    TotalColumn += 1
                                Case 10
                                    No10_Report.Visible = True
                                    TotalColumn += 1
                                Case 12
                                    No12_Report.Visible = True
                                    TotalColumn += 1
                                Case 14
                                    No14_Report.Visible = True
                                    TotalColumn += 1
                                Case 16
                                    No16_Report.Visible = True
                                    TotalColumn += 1
                                Case 20
                                    No20_Report.Visible = True
                                    TotalColumn += 1
                                Case 40
                                    No40_Report.Visible = True
                                    TotalColumn += 1
                                Case 50
                                    No50_Report.Visible = True
                                    TotalColumn += 1
                                Case 60
                                    No60_Report.Visible = True
                                    TotalColumn += 1
                                Case 80
                                    No80_Report.Visible = True
                                    TotalColumn += 1
                                Case 90
                                    No90_Report.Visible = True
                                    TotalColumn += 1
                                Case 100
                                    No100_Report.Visible = True
                                    TotalColumn += 1
                            End Select
                        End If

                    End If

                Next

            Next

            Dim DynamicColumn As Integer = TotalColumn - 3
            Dim BalanceWidth As Decimal = 0

            If DynamicColumn = 0 AndAlso DynamicColumn <= 10 Then
                DynamicWidth = (TotalWidth - 580.66) / DynamicColumn
            Else
                DynamicWidth = (TotalWidth - 565.94) / DynamicColumn
            End If

            If DynamicWidth > 200 Then
                BalanceWidth = (DynamicWidth * DynamicColumn) - (200 * DynamicColumn)
                DynamicWidth = 200

            End If

            If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                NoDescription_Report.WidthF = 304.26 '+ BalanceWidth - 50
            Else
                NoDescription_Report.WidthF = 215.23 '+ BalanceWidth - 50
            End If

            'If NoClaim_Report.Visible = False Then
            '    NoClaim_Report.WidthF = 0
            'Else
            '    NoClaim_Report.WidthF = DynamicWidth
            'End If

            If NoClaim_Report.Visible = False Then
                NoClaim_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = NoClaim_Report
                End If
                NoClaim_Report.WidthF = DynamicWidth
                TotalWith += NoClaim_Report.WidthF
            End If

            If No2.Visible = False Then
                No2_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No2
                End If
                No2_Report.WidthF = DynamicWidth
                TotalWith += No2_Report.WidthF
            End If
            If No3.Visible = False Then
                No3_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No3
                End If
                No3_Report.WidthF = DynamicWidth
                TotalWith += No3_Report.WidthF
            End If
            If No8.Visible = False Then
                No8_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No8
                End If
                No8_Report.WidthF = DynamicWidth
                TotalWith += No8_Report.WidthF
            End If
            If No10.Visible = False Then
                No10_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No10
                End If
                No10_Report.WidthF = DynamicWidth
                TotalWith += No10_Report.WidthF
            End If
            If No12.Visible = False Then
                No12_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No12
                End If
                No12_Report.WidthF = DynamicWidth
                TotalWith += No12_Report.WidthF
            End If
            If No14.Visible = False Then
                No14_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No14
                End If
                No14_Report.WidthF = DynamicWidth
                TotalWith += No14_Report.WidthF
            End If
            If No16.Visible = False Then
                No16_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No16
                End If
                No16_Report.WidthF = DynamicWidth
                TotalWith += No16_Report.WidthF
            End If
            If No20.Visible = False Then
                No20_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No20
                End If
                No20_Report.WidthF = DynamicWidth
                TotalWith += No20_Report.WidthF
            End If
            If No40.Visible = False Then
                No40_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No40
                End If
                No40_Report.WidthF = DynamicWidth
                TotalWith += No40_Report.WidthF
            End If
            If No50.Visible = False Then
                No50_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No50
                End If
                No50_Report.WidthF = DynamicWidth
                TotalWith += No50_Report.WidthF
            End If
            If No60.Visible = False Then
                No60_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No60
                End If
                No60_Report.WidthF = DynamicWidth
                TotalWith += No60_Report.WidthF
            End If
            If No80.Visible = False Then
                No80_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No80
                End If
                No80_Report.WidthF = DynamicWidth
                TotalWith += No80_Report.WidthF
            End If
            If No90.Visible = False Then
                No90_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No90
                End If
                No90_Report.WidthF = DynamicWidth
                TotalWith += No90_Report.WidthF
            End If
            If No100.Visible = False Then
                No100_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No100
                End If

                No100_Report.WidthF = DynamicWidth
                TotalWith += No100_Report.WidthF
            End If


            If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                NoTotal_Report.WidthF = 138.2
                TotalWith += NoTotal_Report.WidthF
            Else
                NoTotal_Report.WidthF = 131.84
                TotalWith += NoTotal_Report.WidthF
            End If

            lineReport_Top.LocationF = New PointF(NoClaim_Report.LocationF.X, NoClaim_Report.LocationF.Y)
            lineReport_Top.SizeF = New SizeF(TotalWith, 1)
            lineReport_Bot.LocationF = New PointF(NoClaim_Report.LocationF.X, NoClaim_Report.LocationF.Y + 30)
            lineReport_Bot.SizeF = New SizeF(TotalWith, 1)

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub


End Class