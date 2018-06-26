Public Class rpt_CAAnalysis
    Private Sub No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles table1.BeforePrint  ', No3.BeforePrint, No8.BeforePrint, No10.BeforePrint, No12.BeforePrint, No14.BeforePrint, No16.BeforePrint, No20.BeforePrint, No40.BeforePrint, No50.BeforePrint, No60.BeforePrint, No8.BeforePrint, No90.BeforePrint, No100.BeforePrint
        Try
            Dim dt As DataTable = Nothing
            dt = ADO.Load_CAReport_Analysis_Temp(paramID.Value)

            If dt Is Nothing Then
                Exit Sub
            End If
            Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA()

            Dim tmpStatus As Boolean = False

            Dim TotalWidth As Decimal = 1046
            Dim DynamicWidth As Decimal = 0
            Dim TotalColumn As Integer = 4
            Dim RAITA_Status As Boolean = False
            Dim DeferredStatus As Boolean = False
            For y As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                For x As Integer = 0 To dt.Rows.Count - 1
                    If IsDBNull(dt.Rows(0)("CA_INCENTIVE")) = False AndAlso IsNumeric(dt.Rows(0)("CA_INCENTIVE")) AndAlso CInt(dt.Rows(0)("CA_INCENTIVE")) <> 0 Then
                        RAITA_Status = True
                        NoRAITA.Text = dt.Rows(0)("CA_INCENTIVE_TITLE")
                    End If
                    If IsDBNull(dt.Rows(0)("CA_DEFERRED")) = False AndAlso IsNumeric(dt.Rows(0)("CA_DEFERRED")) AndAlso CInt(dt.Rows(0)("CA_DEFERRED")) <> 0 Then
                        DeferredStatus = True
                    End If

                    If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
                        tmpStatus = True
                        If IsNumeric(ListofAA(y).Replace("AA_", "")) Then
                            Select Case CInt(ListofAA(y).Replace("AA_", ""))
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

            If RAITA_Status Then
                NoRAITA.Visible = True
                NoRAITA_Bot.Visible = True
                TotalColumn += 1
            Else
                NoRAITA.Visible = False
                NoRAITA_Bot.Visible = False
            End If

            If DeferredStatus Then
                NoDeferred.Visible = True
                NoDeferred_Bot.Visible = True
                TotalColumn += 1
            Else
                NoDeferred.Visible = False
                NoDeferred_Bot.Visible = False
            End If


            Dim DynamicColumn As Integer = TotalColumn - 3
            Dim BalanceWidth As Decimal = 0

            If DynamicColumn = 0 AndAlso DynamicColumn <= 10 Then
                DynamicWidth = (TotalWidth - 554.26) / DynamicColumn
            Else
                DynamicWidth = (TotalWidth - 435.23) / DynamicColumn
            End If

            If DynamicWidth > 200 Then
                BalanceWidth = (DynamicWidth * DynamicColumn) - (200 * DynamicColumn)
                DynamicWidth = 200

            End If

            If DynamicColumn >= 0 AndAlso DynamicColumn <= 6 Then
                NoDescription.WidthF = 150.26 '+ BalanceWidth - 50
                NoDescription_Bot.WidthF = 150.26
                NoDescription_Top.WidthF = 150.26

                NoCost.WidthF = 80
                NoCost_Bot.WidthF = 80
                NoCost_Top.WidthF = 80

                NoREC.WidthF = 80
                NoREC_Bot.WidthF = 80
                NoREC_Top.WidthF = 80

                NoClaim.WidthF = 80
                NoClaim_Bot.WidthF = 80
                NoClaim_Top.WidthF = 80

            ElseIf DynamicColumn >= 7 AndAlso DynamicColumn <= 10 Then
                NoDescription.WidthF = 100.26 '+ BalanceWidth - 50
                NoDescription_Bot.WidthF = 100.26
                NoDescription_Top.WidthF = 100.26

                NoCost.WidthF = 70
                NoCost_Bot.WidthF = 70
                NoCost_Top.WidthF = 70

                NoREC.WidthF = 70
                NoREC_Bot.WidthF = 70
                NoREC_Top.WidthF = 70

                NoClaim.WidthF = 70
                NoClaim_Bot.WidthF = 70
                NoClaim_Top.WidthF = 70
            Else
                NoDescription.WidthF = 80.23 '+ BalanceWidth - 50
                NoDescription_Bot.WidthF = 80.23
                NoDescription_Top.WidthF = 80.23

                NoCost.WidthF = 60
                NoCost_Bot.WidthF = 60
                NoCost_Top.WidthF = 60

                NoREC.WidthF = 60
                NoREC_Bot.WidthF = 60
                NoREC_Top.WidthF = 60

                NoClaim.WidthF = 60
                NoClaim_Bot.WidthF = 60
                NoClaim_Top.WidthF = 60
            End If


            If NoRAITA.Visible = False Then
                NoRAITA.WidthF = 0
                NoRAITA_Bot.WidthF = 0
                NoRAITA_Top.WidthF = 0
            Else
                NoRAITA.WidthF = DynamicWidth
                NoRAITA_Bot.WidthF = DynamicWidth
                NoRAITA_Top.WidthF = DynamicWidth
            End If

            If NoDeferred.Visible = False Then
                NoDeferred.WidthF = 0
                NoDeferred_Bot.WidthF = 0
                NoDeferred_Top.WidthF = 0
            Else
                NoDeferred.WidthF = DynamicWidth
                NoDeferred_Bot.WidthF = DynamicWidth
                NoDeferred_Top.WidthF = DynamicWidth
            End If

            Dim TotalQF As Decimal = 0

            If No2.Visible = False Then
                No2.WidthF = 0
                No2_Bot.WidthF = 0
                TotalQF += 1
            Else
                No2.WidthF = DynamicWidth
                No2_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If


            If No3.Visible = False Then
                No3.WidthF = 0
                No3_Bot.WidthF = 0
                TotalQF += 1
            Else
                No3.WidthF = DynamicWidth
                No3_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If


            If No8.Visible = False Then
                No8.WidthF = 0
                No8_Bot.WidthF = 0
                TotalQF += 1
            Else
                No8.WidthF = DynamicWidth
                No8_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If


            If No10.Visible = False Then
                No10.WidthF = 0
                No10_Bot.WidthF = 0
                TotalQF += 1
            Else
                No10.WidthF = DynamicWidth
                No10_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If

            If No12.Visible = False Then
                No12.WidthF = 0
                No12_Bot.WidthF = 0
                TotalQF += 1
            Else
                No12.WidthF = DynamicWidth
                No12_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If

            If No14.Visible = False Then
                No14.WidthF = 0
                No14_Bot.WidthF = 0
                TotalQF += 1
            Else
                No14.WidthF = DynamicWidth
                No14_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If


            If No16.Visible = False Then
                No16.WidthF = 0
                No16_Bot.WidthF = 0
                TotalQF += 1
            Else
                No16.WidthF = DynamicWidth
                No16_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If

            If No20.Visible = False Then
                No20.WidthF = 0
                No20_Bot.WidthF = 0
                TotalQF += 1
            Else
                No20.WidthF = DynamicWidth
                No20_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If

            If No40.Visible = False Then
                No40.WidthF = 0
                No40_Bot.WidthF = 0
                TotalQF += 1
            Else
                No40.WidthF = DynamicWidth
                No40_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If

            If No50.Visible = False Then
                No50.WidthF = 0
                No50_Bot.WidthF = 0
                TotalQF += 1
            Else
                No50.WidthF = DynamicWidth
                No50_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If

            If No60.Visible = False Then
                No60.WidthF = 0
                No60_Bot.WidthF = 0
                TotalQF += 1
            Else
                No60.WidthF = DynamicWidth
                No60_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If

            If No80.Visible = False Then
                No80.WidthF = 0
                No80_Bot.WidthF = 0
                TotalQF += 1
            Else
                No80.WidthF = DynamicWidth
                No80_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If

            If No90.Visible = False Then
                No90.WidthF = 0
                No90_Bot.WidthF = 0
                TotalQF += 1
            Else
                No90.WidthF = DynamicWidth
                No90_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If

            If No100.Visible = False Then
                No100.WidthF = 0
                No100_Bot.WidthF = 0
                TotalQF += 1
            Else
                No100.WidthF = DynamicWidth
                No100_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
            End If

            NoHeader_Top.WidthF = TotalQF

            NoTotal.WidthF = 80
            NoTotal_Bot.WidthF = 80
            NoTotal_Top.WidthF = 80

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub No3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles table1_Details.BeforePrint   ', No3.BeforePrint, No8.BeforePrint, No10.BeforePrint, No12.BeforePrint, No14.BeforePrint, No16.BeforePrint, No20.BeforePrint, No40.BeforePrint, No50.BeforePrint, No60.BeforePrint, No8.BeforePrint, No90.BeforePrint, No100.BeforePrint
        Try
            Dim dt As DataTable = Nothing
            dt = ADO.Load_CAReport_Analysis_Temp(paramID.Value)

            If dt Is Nothing Then
                Exit Sub
            End If
            Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA()

            Dim tmpStatus As Boolean = False

            Dim TotalWidth As Decimal = 1046
            Dim DynamicWidth As Decimal = 0
            Dim TotalColumn As Integer = 4
            Dim RAITA_Status As Boolean = False
            Dim DeferredStatus As Boolean = False
            For y As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                For x As Integer = 0 To dt.Rows.Count - 1
                    If IsDBNull(dt.Rows(0)("CA_INCENTIVE")) = False AndAlso IsNumeric(dt.Rows(0)("CA_INCENTIVE")) AndAlso CInt(dt.Rows(0)("CA_INCENTIVE")) <> 0 Then
                        RAITA_Status = True
                        NoRAITA.Text = dt.Rows(0)("CA_INCENTIVE_TITLE")
                    End If
                    If IsDBNull(dt.Rows(0)("CA_DEFERRED")) = False AndAlso IsNumeric(dt.Rows(0)("CA_DEFERRED")) AndAlso CInt(dt.Rows(0)("CA_DEFERRED")) <> 0 Then
                        DeferredStatus = True
                    End If

                    If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
                        tmpStatus = True
                        If IsNumeric(ListofAA(y).Replace("AA_", "")) Then
                            Select Case CInt(ListofAA(y).Replace("AA_", ""))
                                Case 2
                                    No2.Visible = True
                                    No2_Details.Visible = True
                                    TotalColumn += 1
                                Case 3
                                    No3.Visible = True
                                    No3_Details.Visible = True
                                    TotalColumn += 1
                                Case 8
                                    No8.Visible = True
                                    No8_Details.Visible = True
                                    TotalColumn += 1
                                Case 10
                                    No10.Visible = True
                                    No10_Details.Visible = True
                                    TotalColumn += 1
                                Case 12
                                    No12.Visible = True
                                    No12_Details.Visible = True
                                    TotalColumn += 1
                                Case 14
                                    No14.Visible = True
                                    No14_Details.Visible = True
                                    TotalColumn += 1
                                Case 16
                                    No16.Visible = True
                                    No16_Details.Visible = True
                                    TotalColumn += 1
                                Case 20
                                    No20.Visible = True
                                    No20_Details.Visible = True
                                    TotalColumn += 1
                                Case 40
                                    No40.Visible = True
                                    No40_Details.Visible = True
                                    TotalColumn += 1
                                Case 50
                                    No50.Visible = True
                                    No50_Details.Visible = True
                                    TotalColumn += 1
                                Case 60
                                    No60.Visible = True
                                    No60_Details.Visible = True
                                    TotalColumn += 1
                                Case 80
                                    No80.Visible = True
                                    No80_Details.Visible = True
                                    TotalColumn += 1
                                Case 90
                                    No90.Visible = True
                                    No90_Details.Visible = True
                                    TotalColumn += 1
                                Case 100
                                    No100.Visible = True
                                    No100_Details.Visible = True
                                    TotalColumn += 1
                            End Select
                        End If

                    End If

                Next

            Next

            Dim obj As Object = dt.Compute("COUNT(CA_CATEGORY)", "CA_CATEGORY = '" & Me.GetCurrentColumnValue("CA_CATEGORY") & "'")
            If obj IsNot Nothing AndAlso IsNumeric(obj) AndAlso CInt(obj) > 1 Then
                Table1_Footer.Visible = True
                lineFooter_Bot.Visible = True
                lineFooter_Top.LineWidth = 1
                NoTotal_Details.Text = ""
            Else
                Table1_Footer.Visible = False
                lineFooter_Bot.Visible = False
                lineFooter_Top.LineWidth = 2

            End If

            If RAITA_Status Then
                NoRAITA.Visible = True
                NORAITA_Details.Visible = True
                TotalColumn += 1
            Else
                NoRAITA.Visible = False
                NORAITA_Details.Visible = False
            End If

            If DeferredStatus Then
                NoDeferred.Visible = True
                NoDeferred_Details.Visible = True
                TotalColumn += 1
            Else
                NoDeferred.Visible = False
                NoDeferred_Details.Visible = False
            End If


            Dim DynamicColumn As Integer = TotalColumn - 3
            Dim BalanceWidth As Decimal = 0

            If DynamicColumn = 0 AndAlso DynamicColumn <= 10 Then
                DynamicWidth = (TotalWidth - 554.26) / DynamicColumn
            Else
                DynamicWidth = (TotalWidth - 435.23) / DynamicColumn
            End If

            If DynamicWidth > 200 Then
                BalanceWidth = (DynamicWidth * DynamicColumn) - (200 * DynamicColumn)
                DynamicWidth = 200

            End If

            If DynamicColumn >= 0 AndAlso DynamicColumn <= 6 Then
                NoDescription.WidthF = 150.26 '+ BalanceWidth - 50
                NoDescription_Details.WidthF = 150.26

                If NoRAITA.Visible = False Then
                    NoRAITA.WidthF = 0
                    NORAITA_Details.WidthF = 0
                Else
                    NoRAITA.WidthF = DynamicWidth
                    NORAITA_Details.WidthF = DynamicWidth
                End If

                NoCost.WidthF = 80
                NoCost_Details.WidthF = 80
                NoREC.WidthF = 80
                NoREC_Details.WidthF = 80
                NoClaim.WidthF = 80
                NoClaim_Details.WidthF = 80
            ElseIf DynamicColumn >= 7 AndAlso DynamicColumn <= 10 Then
                NoDescription.WidthF = 100.26 '+ BalanceWidth - 50
                NoDescription_Details.WidthF = 100.26

                If NoRAITA.Visible = False Then
                    NoRAITA.WidthF = 0
                    NORAITA_Details.WidthF = 0
                Else
                    NoRAITA.WidthF = DynamicWidth
                    NORAITA_Details.WidthF = DynamicWidth
                End If

                NoCost.WidthF = 70
                NoCost_Details.WidthF = 70
                NoREC.WidthF = 70
                NoREC_Details.WidthF = 70
                NoClaim.WidthF = 70
                NoClaim_Details.WidthF = 70
            Else
                NoDescription.WidthF = 80.23 '+ BalanceWidth - 50
                NoDescription_Details.WidthF = 80.23

                If NoRAITA.Visible = False Then
                    NoRAITA.WidthF = 0
                    NORAITA_Details.WidthF = 0
                Else
                    NoRAITA.WidthF = DynamicWidth
                    NORAITA_Details.WidthF = DynamicWidth
                End If
                NoCost.WidthF = 60
                NoCost_Details.WidthF = 60
                NoREC.WidthF = 60
                NoREC_Details.WidthF = 60
                NoClaim.WidthF = 60
                NoClaim_Details.WidthF = 60
            End If

            If NoDeferred.Visible = False Then
                NoDeferred.WidthF = 0
                NoDeferred_Details.WidthF = 0
            Else
                NoDeferred.WidthF = DynamicWidth
                NoDeferred_Details.WidthF = DynamicWidth
            End If

            If No2.Visible = False Then
                No2.WidthF = 0
                No2_Details.WidthF = 0
            Else
                No2.WidthF = DynamicWidth
                No2_Details.WidthF = DynamicWidth
            End If
            If No3.Visible = False Then
                No3.WidthF = 0
                No3_Details.WidthF = 0
            Else
                No3.WidthF = DynamicWidth
                No3_Details.WidthF = DynamicWidth
            End If
            If No8.Visible = False Then
                No8.WidthF = 0
                No8_Details.WidthF = 0
            Else
                No8.WidthF = DynamicWidth
                No8_Details.WidthF = DynamicWidth
            End If
            If No10.Visible = False Then
                No10.WidthF = 0
                No10_Details.WidthF = 0
            Else
                No10.WidthF = DynamicWidth
                No10_Details.WidthF = DynamicWidth
            End If
            If No12.Visible = False Then
                No12.WidthF = 0
                No12_Details.WidthF = 0
            Else
                No12.WidthF = DynamicWidth
                No12_Details.WidthF = DynamicWidth
            End If
            If No14.Visible = False Then
                No14.WidthF = 0
                No14_Details.WidthF = 0
            Else
                No14.WidthF = DynamicWidth
                No14_Details.WidthF = DynamicWidth
            End If
            If No16.Visible = False Then
                No16.WidthF = 0
                No16_Details.WidthF = 0
            Else
                No16.WidthF = DynamicWidth
                No16_Details.WidthF = DynamicWidth
            End If
            If No20.Visible = False Then
                No20.WidthF = 0
                No20_Details.WidthF = 0
            Else
                No20.WidthF = DynamicWidth
                No20_Details.WidthF = DynamicWidth
            End If
            If No40.Visible = False Then
                No40.WidthF = 0
                No40_Details.WidthF = 0
            Else
                No40.WidthF = DynamicWidth
                No40_Details.WidthF = DynamicWidth
            End If
            If No50.Visible = False Then
                No50.WidthF = 0
                No50_Details.WidthF = 0
            Else
                No50.WidthF = DynamicWidth
                No50_Details.WidthF = DynamicWidth
            End If
            If No60.Visible = False Then
                No60.WidthF = 0
                No60_Details.WidthF = 0
            Else
                No60.WidthF = DynamicWidth
                No60_Details.WidthF = DynamicWidth
            End If
            If No80.Visible = False Then
                No80.WidthF = 0
                No80_Details.WidthF = 0
            Else
                No80.WidthF = DynamicWidth
                No80_Details.WidthF = DynamicWidth
            End If
            If No90.Visible = False Then
                No90.WidthF = 0
                No90_Details.WidthF = 0
            Else
                No90.WidthF = DynamicWidth
                No90_Details.WidthF = DynamicWidth
            End If
            If No100.Visible = False Then
                No100.WidthF = 0
                No100_Details.WidthF = 0
            Else
                No100.WidthF = DynamicWidth
                No100_Details.WidthF = DynamicWidth
            End If

            NoTotal.WidthF = 80
            NoTotal_Details.WidthF = 80


            obj = Nothing
            obj = dt.Compute("SUM(CA_REC)", "CA_CATEGORY = '" & Me.GetCurrentColumnValue("CA_CATEGORY") & "'")
            If obj IsNot Nothing AndAlso IsNumeric(obj) AndAlso CDec(obj) > 0 Then
                lblDeduct.Visible = True
                lblDeduct.LocationF = New PointF(NoREC_Details.LocationF.X, 46.91)
                lblDeduct.SizeF = New SizeF(NoREC_Details.WidthF, 23)
            Else
                lblDeduct.Visible = False
            End If


        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub No4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Table1_Footer.BeforePrint   ', No3.BeforePrint, No8.BeforePrint, No10.BeforePrint, No12.BeforePrint, No14.BeforePrint, No16.BeforePrint, No20.BeforePrint, No40.BeforePrint, No50.BeforePrint, No60.BeforePrint, No8.BeforePrint, No90.BeforePrint, No100.BeforePrint
        Try
            Dim dt As DataTable = Nothing
            dt = ADO.Load_CAReport_Analysis_Temp(paramID.Value)

            If dt Is Nothing Then
                Exit Sub
            End If
            Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA()

            Dim tmpStatus As Boolean = False

            Dim TotalWidth As Decimal = 1046
            Dim DynamicWidth As Decimal = 0
            Dim TotalColumn As Integer = 4
            Dim RAITA_Status As Boolean = False
            Dim DeferredStatus As Boolean = False
            For y As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                For x As Integer = 0 To dt.Rows.Count - 1
                    If IsDBNull(dt.Rows(0)("CA_INCENTIVE")) = False AndAlso IsNumeric(dt.Rows(0)("CA_INCENTIVE")) AndAlso CInt(dt.Rows(0)("CA_INCENTIVE")) <> 0 Then
                        RAITA_Status = True
                        NoRAITA.Text = dt.Rows(0)("CA_INCENTIVE_TITLE")
                    End If
                    If IsDBNull(dt.Rows(0)("CA_DEFERRED")) = False AndAlso IsNumeric(dt.Rows(0)("CA_DEFERRED")) AndAlso CInt(dt.Rows(0)("CA_DEFERRED")) <> 0 Then
                        DeferredStatus = True
                    End If

                    If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
                        tmpStatus = True
                        If IsNumeric(ListofAA(y).Replace("AA_", "")) Then
                            Select Case CInt(ListofAA(y).Replace("AA_", ""))
                                Case 2
                                    No2.Visible = True
                                    No2_Footer.Visible = True
                                    TotalColumn += 1
                                Case 3
                                    No3.Visible = True
                                    No3_Footer.Visible = True
                                    TotalColumn += 1
                                Case 8
                                    No8.Visible = True
                                    No8_Footer.Visible = True
                                    TotalColumn += 1
                                Case 10
                                    No10.Visible = True
                                    No10_Footer.Visible = True
                                    TotalColumn += 1
                                Case 12
                                    No12.Visible = True
                                    No12_Footer.Visible = True
                                    TotalColumn += 1
                                Case 14
                                    No14.Visible = True
                                    No14_Footer.Visible = True
                                    TotalColumn += 1
                                Case 16
                                    No16.Visible = True
                                    No16_Footer.Visible = True
                                    TotalColumn += 1
                                Case 20
                                    No20.Visible = True
                                    No20_Footer.Visible = True
                                    TotalColumn += 1
                                Case 40
                                    No40.Visible = True
                                    No40_Footer.Visible = True
                                    TotalColumn += 1
                                Case 50
                                    No50.Visible = True
                                    No50_Footer.Visible = True
                                    TotalColumn += 1
                                Case 60
                                    No60.Visible = True
                                    No60_Footer.Visible = True
                                    TotalColumn += 1
                                Case 80
                                    No80.Visible = True
                                    No80_Footer.Visible = True
                                    TotalColumn += 1
                                Case 90
                                    No90.Visible = True
                                    No90_Footer.Visible = True
                                    TotalColumn += 1
                                Case 100
                                    No100.Visible = True
                                    No100_Footer.Visible = True
                                    TotalColumn += 1
                            End Select
                        End If

                    End If

                Next

            Next

            If RAITA_Status Then
                NoRAITA.Visible = True
                NoRAITA_Footer.Visible = True
                TotalColumn += 1
            Else
                NoRAITA.Visible = False
                NoRAITA_Footer.Visible = False
            End If

            If DeferredStatus Then
                NoDeferred.Visible = True
                NoDeferred_Footer.Visible = True
                TotalColumn += 1
            Else
                NoDeferred.Visible = False
                NoDeferred_Footer.Visible = False
            End If


            Dim DynamicColumn As Integer = TotalColumn - 3
            Dim BalanceWidth As Decimal = 0
            Dim TotalWith As Decimal = 0

            If DynamicColumn = 0 AndAlso DynamicColumn <= 10 Then
                DynamicWidth = (TotalWidth - 554.26) / DynamicColumn
            Else
                DynamicWidth = (TotalWidth - 435.23) / DynamicColumn
            End If

            If DynamicWidth > 200 Then
                BalanceWidth = (DynamicWidth * DynamicColumn) - (200 * DynamicColumn)
                DynamicWidth = 200

            End If

            If DynamicColumn >= 0 AndAlso DynamicColumn <= 6 Then
                NoDescription.WidthF = 150.26 '+ BalanceWidth - 50
                NoDescription_Footer.WidthF = 150.26

                If NoRAITA.Visible = False Then
                    NoRAITA.WidthF = 0
                    NoRAITA_Footer.WidthF = 0
                Else
                    NoRAITA.WidthF = DynamicWidth
                    NoRAITA_Footer.WidthF = DynamicWidth
                End If

                NoCost.WidthF = 80
                NoCost_Footer.WidthF = 80

                NoREC.WidthF = 80
                NoREC_Footer.WidthF = 80

                NoClaim.WidthF = 80
                NoClaim_Footer.WidthF = 80
            ElseIf DynamicColumn >= 7 AndAlso DynamicColumn <= 10 Then
                NoDescription.WidthF = 100.26 '+ BalanceWidth - 50
                NoDescription_Footer.WidthF = 100.26

                If NoRAITA.Visible = False Then
                    NoRAITA.WidthF = 0
                    NoRAITA_Footer.WidthF = 0
                Else
                    NoRAITA.WidthF = DynamicWidth
                    NoRAITA_Footer.WidthF = DynamicWidth
                End If

                NoCost.WidthF = 70
                NoCost_Footer.WidthF = 70
                NoREC.WidthF = 70
                NoREC_Footer.WidthF = 70
                NoClaim.WidthF = 70
                NoClaim_Footer.WidthF = 70
            Else
                NoDescription.WidthF = 80.23 '+ BalanceWidth - 50
                NoDescription_Footer.WidthF = 80.23

                If NoRAITA.Visible = False Then
                    NoRAITA.WidthF = 0
                    NoRAITA_Footer.WidthF = 0
                Else
                    NoRAITA.WidthF = DynamicWidth
                    NoRAITA_Footer.WidthF = DynamicWidth
                End If
                NoCost.WidthF = 60
                NoCost_Footer.WidthF = 60
                NoREC.WidthF = 60
                NoREC_Footer.WidthF = 60
                NoClaim.WidthF = 60
                NoClaim_Footer.WidthF = 60
            End If
            TotalWith = NoRAITA_Footer.WidthF
            TotalWith += NoCost_Footer.WidthF
            TotalWith += NoREC_Footer.WidthF
            TotalWith += NoClaim_Footer.WidthF


            If NoDeferred.Visible = False Then
                NoDeferred.WidthF = 0
                NoDeferred_Footer.WidthF = 0
                TotalWith += 5
            Else
                NoDeferred.WidthF = DynamicWidth
                NoDeferred_Footer.WidthF = DynamicWidth
                TotalWith += NoDeferred_Footer.WidthF
            End If

            If No2.Visible = False Then
                No2.WidthF = 0
                No2_Footer.WidthF = 0
                TotalWith += 5
            Else
                No2.WidthF = DynamicWidth
                No2_Footer.WidthF = DynamicWidth
                TotalWith += No2_Footer.WidthF
            End If

            If No3.Visible = False Then
                No3.WidthF = 0
                No3_Footer.WidthF = 0
                TotalWith += 5
            Else
                No3.WidthF = DynamicWidth
                No3_Footer.WidthF = DynamicWidth
                TotalWith += No3_Footer.WidthF
            End If

            If No8.Visible = False Then
                No8.WidthF = 0
                No8_Footer.WidthF = 0
                TotalWith += 5
            Else
                No8.WidthF = DynamicWidth
                No8_Footer.WidthF = DynamicWidth
                TotalWith += No8_Footer.WidthF
            End If

            If No10.Visible = False Then
                No10.WidthF = 0
                No10_Footer.WidthF = 0
                TotalWith += 5
            Else
                No10.WidthF = DynamicWidth
                No10_Footer.WidthF = DynamicWidth
                TotalWith += No10_Footer.WidthF
            End If

            If No12.Visible = False Then
                No12.WidthF = 0
                No12_Footer.WidthF = 0
                TotalWith += 5
            Else
                No12.WidthF = DynamicWidth
                No12_Footer.WidthF = DynamicWidth
                TotalWith += No12_Footer.WidthF
            End If

            If No14.Visible = False Then
                No14.WidthF = 0
                No14_Footer.WidthF = 0
                TotalWith += 5
            Else
                No14.WidthF = DynamicWidth
                No14_Footer.WidthF = DynamicWidth
                TotalWith += No14_Footer.WidthF
            End If

            If No16.Visible = False Then
                No16.WidthF = 0
                No16_Footer.WidthF = 0
                TotalWith += 5
            Else
                No16.WidthF = DynamicWidth
                No16_Footer.WidthF = DynamicWidth
                TotalWith += No16_Footer.WidthF
            End If

            If No20.Visible = False Then
                No20.WidthF = 0
                No20_Footer.WidthF = 0
                TotalWith += 5
            Else
                No20.WidthF = DynamicWidth
                No20_Footer.WidthF = DynamicWidth
                TotalWith += No20_Footer.WidthF
            End If

            If No40.Visible = False Then
                No40.WidthF = 0
                No40_Footer.WidthF = 0
                TotalWith += 5
            Else
                No40.WidthF = DynamicWidth
                No40_Footer.WidthF = DynamicWidth
                TotalWith += No40_Footer.WidthF
            End If

            If No50.Visible = False Then
                No50.WidthF = 0
                No50_Footer.WidthF = 0
                TotalWith += 5
            Else
                No50.WidthF = DynamicWidth
                No50_Footer.WidthF = DynamicWidth
                TotalWith += No50_Footer.WidthF
            End If

            If No60.Visible = False Then
                No60.WidthF = 0
                No60_Footer.WidthF = 0
                TotalWith += 5
            Else
                No60.WidthF = DynamicWidth
                No60_Footer.WidthF = DynamicWidth
                TotalWith += No60_Footer.WidthF
            End If

            If No80.Visible = False Then
                No80.WidthF = 0
                No80_Footer.WidthF = 0
                TotalWith += 5
            Else
                No80.WidthF = DynamicWidth
                No80_Footer.WidthF = DynamicWidth
                TotalWith += No80_Footer.WidthF
            End If

            If No90.Visible = False Then
                No90.WidthF = 0
                No90_Footer.WidthF = 0
                TotalWith += 5
            Else
                No90.WidthF = DynamicWidth
                No90_Footer.WidthF = DynamicWidth
                TotalWith += No90_Footer.WidthF
            End If

            If No100.Visible = False Then
                No100.WidthF = 0
                No100_Footer.WidthF = 0
                TotalWith += 5
            Else
                No100.WidthF = DynamicWidth
                No100_Footer.WidthF = DynamicWidth
                TotalWith += No100_Footer.WidthF
            End If

            NoTotal.WidthF = 80
            NoTotal_Footer.WidthF = 80
            TotalWith += 80
            'TotalWith += NoTotal_Footer.WidthF

            lineFooter_Top.LocationF = New PointF(NoRAITA_Footer.LocationF.X, NoRAITA_Footer.LocationF.Y)
            lineFooter_Top.SizeF = New SizeF(TotalWith, 1)
            lineFooter_Bot.LocationF = New PointF(NoRAITA_Footer.LocationF.X, NoRAITA_Footer.LocationF.Y + 40)
            lineFooter_Bot.SizeF = New SizeF(TotalWith, 1)

            lblTotal.LocationF = New PointF(NoTotal_Footer.LocationF.X, 10)
            lineTotal_Top.LocationF = New PointF(NoTotal_Footer.LocationF.X, 7.92)
            lineTotal_Bot.LocationF = New PointF(NoTotal_Footer.LocationF.X, 33)

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
End Class