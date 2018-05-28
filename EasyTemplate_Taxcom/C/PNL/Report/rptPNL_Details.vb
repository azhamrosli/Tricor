Public Class rptPNL_Details
    '#Region "PLST_SALES"
    '    Private Sub txtTotal_PLST_SALES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_PLST_SALES.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = PLST_SALES.GetCurrentColumnValue("PLFS_KEY")
    '            Dim countx As Integer = ADO.Load_PLFST_SALES_TOTAL_SOURCENO(PL_KEY)

    '            If countx <= 1 Then
    '                ' GF_PLST_SALES.Visible = False
    '                txtTotal_PLST_SALES.Visible = False
    '                lineTotal_PLST_SALES_top.Visible = False
    '                lineTotal_PLST_SALES_bot.Visible = False
    '            Else
    '                Dim ParentID As Integer = PLST_SALES.GetCurrentColumnValue("PLFS_PLFSKEY")
    '                Dim SourceNo As Integer = PLST_SALES.GetCurrentColumnValue("PLFS_SOURCENO")
    '                Dim countx_Item As Integer = ADO.Load_PLFST_SALES_COUNT(PL_KEY, SourceNo)
    '                If countx_Item > 1 Then
    '                    txtTotal_PLST_SALES.Visible = True
    '                    lineTotal_PLST_SALES_top.Visible = True
    '                    lineTotal_PLST_SALES_bot.Visible = True
    '                Else
    '                    txtTotal_PLST_SALES.Visible = False
    '                    lineTotal_PLST_SALES_top.Visible = False
    '                    lineTotal_PLST_SALES_bot.Visible = False
    '                End If

    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub txt_PLFST_SALES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_PLFST_SALES.BeforePrint

    '        Try
    '            Dim PL_KEY As Integer = PLST_SALES.GetCurrentColumnValue("PLFS_KEY")
    '            Dim ParentID As Integer = PLST_SALES.GetCurrentColumnValue("PLFS_PLFSKEY")
    '            Dim SourceNo As Integer = PLST_SALES.GetCurrentColumnValue("PLFS_SOURCENO")
    '            Dim LineStatus As Boolean = False
    '            txt_PLFST_SALES.Visible = Me.GetVisibility_PLFST_SALES(PL_KEY, ParentID, SourceNo, LineStatus)

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_PLFST_SALES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_PLFST_SALES.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = PLST_SALES.GetCurrentColumnValue("PLFS_KEY")
    '            Dim ParentID As Integer = PLST_SALES.GetCurrentColumnValue("PLFS_PLFSKEY")
    '            Dim SourceNo As Integer = PLST_SALES.GetCurrentColumnValue("PLFS_SOURCENO")
    '            Dim LineStatus As Boolean = False
    '            Me.GetVisibility_PLFST_SALES(PL_KEY, ParentID, SourceNo, LineStatus)
    '            line_PLFST_SALES.Visible = LineStatus
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Function GetVisibility_PLFST_SALES(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
    '        Try

    '            Dim countx_subItem As Integer = ADO.Load_PLFST_SALES_COUNT_SUBITEM(PL_KEY, ParentID)
    '            Dim count_Item As Integer = ADO.Load_PLFST_SALES_COUNT(PL_KEY, SourceNo)

    '            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
    '                LineStatus = True
    '                Return True
    '            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
    '                LineStatus = False
    '                Return True
    '            Else
    '                LineStatus = False
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            Return False
    '        End Try
    '    End Function
    '#End Region  
    '#Region "OTHER_EXPENSES"
    '    Private Sub txtTotal_OTHER_EXPENSES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXPENSES.BeforePrint, perTotal_OTHER_EXPENSES.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_KEY")
    '            Dim countx As Integer = ADO.Load_OTHER_EXPENSES_TOTAL_SOURCENO(PL_KEY)

    '            If countx <= 1 Then
    '                ' GF_OTHER_EXPENSES.Visible = False
    '                txtTotal_OTHER_EXPENSES.Visible = False
    '                perTotal_OTHER_EXPENSES.Visible = False
    '                lineTotal_OTHER_EXPENSES_top.Visible = False
    '                lineTotal_OTHER_EXPENSES_bot.Visible = False
    '            Else
    '                Dim ParentID As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_EXOKEY")
    '                Dim SourceNo As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_SOURCENO")
    '                Dim countx_Item As Integer = ADO.Load_OTHER_EXPENSES_COUNT(PL_KEY, SourceNo)
    '                If countx_Item > 1 Then
    '                    txtTotal_OTHER_EXPENSES.Visible = True
    '                    perTotal_OTHER_EXPENSES.Visible = True
    '                    lineTotal_OTHER_EXPENSES_top.Visible = True
    '                    lineTotal_OTHER_EXPENSES_bot.Visible = True
    '                Else
    '                    txtTotal_OTHER_EXPENSES.Visible = False
    '                    perTotal_OTHER_EXPENSES.Visible = False
    '                    lineTotal_OTHER_EXPENSES_top.Visible = False
    '                    lineTotal_OTHER_EXPENSES_bot.Visible = False
    '                End If

    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub txt_OTHER_EXPENSES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXPENSES.BeforePrint, per_OTHER_EXPENSES.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_KEY")
    '            Dim ParentID As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_EXOKEY")
    '            Dim SourceNo As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_SOURCENO")
    '            Dim LineStatus As Boolean = False
    '            txt_OTHER_EXPENSES.Visible = Me.GetVisibility_OTHER_EXPENSES(PL_KEY, ParentID, SourceNo, LineStatus)
    '            Application.DoEvents()
    '            per_OTHER_EXPENSES.Visible = txt_OTHER_EXPENSES.Visible

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_OTHER_EXPENSES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXPENSES.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_KEY")
    '            Dim ParentID As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_EXOKEY")
    '            Dim SourceNo As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_SOURCENO")
    '            Dim LineStatus As Boolean = False
    '            Me.GetVisibility_OTHER_EXPENSES(PL_KEY, ParentID, SourceNo, LineStatus)
    '            line_OTHER_EXPENSES.Visible = LineStatus
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Function GetVisibility_OTHER_EXPENSES(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
    '        Try

    '            Dim countx_subItem As Integer = ADO.Load_OTHER_EXPENSES_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
    '            Dim count_Item As Integer = ADO.Load_OTHER_EXPENSES_COUNT(PL_KEY, SourceNo)

    '            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
    '                LineStatus = True
    '                Return True
    '            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
    '                LineStatus = False
    '                Return True
    '            Else
    '                LineStatus = False
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            Return False
    '        End Try
    '    End Function
    '#End Region
#Region "PLFST_SALES"
    Private Sub txtTotal_PLFST_SALES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_PLFST_SALES.BeforePrint
        Try
            Dim PL_KEY As Integer = PLFST_SALES.GetCurrentColumnValue("PLFS_KEY")
            Dim countx As Integer = ADO.Load_PLFST_SALES_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_PLFST_SALES.Visible = False
                txtTotal_PLFST_SALES.Visible = False
                lineTotal_PLFST_SALES_top.Visible = False
                lineTotal_PLFST_SALES_bot.Visible = False
            Else
                Dim ParentID As Integer = PLFST_SALES.GetCurrentColumnValue("PLFS_PLFSKEY")
                Dim SourceNo As Integer = PLFST_SALES.GetCurrentColumnValue("PLFS_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_PLFST_SALES_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_PLFST_SALES.Visible = True
                    lineTotal_PLFST_SALES_top.Visible = True
                    lineTotal_PLFST_SALES_bot.Visible = True
                Else
                    txtTotal_PLFST_SALES.Visible = False
                    lineTotal_PLFST_SALES_top.Visible = False
                    lineTotal_PLFST_SALES_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_PLFST_SALES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_PLFST_SALES.BeforePrint

        Try
            Dim PL_KEY As Integer = PLFST_SALES.GetCurrentColumnValue("PLFS_KEY")
            Dim ParentID As Integer = PLFST_SALES.GetCurrentColumnValue("PLFS_PLFSKEY")
            Dim SourceNo As Integer = PLFST_SALES.GetCurrentColumnValue("PLFS_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_PLFST_SALES.Visible = Me.GetVisibility_PLFST_SALES(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_PLFST_SALES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_PLFST_SALES.BeforePrint
        Try
            Dim PL_KEY As Integer = PLFST_SALES.GetCurrentColumnValue("PLFS_KEY")
            Dim ParentID As Integer = PLFST_SALES.GetCurrentColumnValue("PLFS_PLFSKEY")
            Dim SourceNo As Integer = PLFST_SALES.GetCurrentColumnValue("PLFS_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_PLFST_SALES(PL_KEY, ParentID, SourceNo, LineStatus)
            line_PLFST_SALES.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_PLFST_SALES(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_PLFST_SALES_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_PLFST_SALES_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "PLFST_OPENSTOCK"
    Private Sub txtTotal_PLFST_OPENSTOCK_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_PLFST_OPENSTOCK.BeforePrint
        Try
            Dim PL_KEY As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_KEY")
            Dim countx As Integer = ADO.Load_PLFST_OPENSTOCK_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_PLFST_OPENSTOCK.Visible = False
                txtTotal_PLFST_OPENSTOCK.Visible = False
                lineTotal_PLFST_OPENSTOCK_top.Visible = False
                lineTotal_PLFST_OPENSTOCK_bot.Visible = False
            Else
                Dim ParentID As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_PLFOSKEY")
                Dim SourceNo As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_PLFST_OPENSTOCK_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_PLFST_OPENSTOCK.Visible = True
                    lineTotal_PLFST_OPENSTOCK_top.Visible = True
                    lineTotal_PLFST_OPENSTOCK_bot.Visible = True
                Else
                    txtTotal_PLFST_OPENSTOCK.Visible = False
                    lineTotal_PLFST_OPENSTOCK_top.Visible = False
                    lineTotal_PLFST_OPENSTOCK_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_PLFST_OPENSTOCK_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_PLFST_OPENSTOCK.BeforePrint

        Try
            Dim PL_KEY As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_KEY")
            Dim ParentID As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_PLFOSKEY")
            Dim SourceNo As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_PLFST_OPENSTOCK.Visible = Me.GetVisibility_PLFST_OPENSTOCK(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_PLFST_OPENSTOCK_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_PLFST_OPENSTOCK.BeforePrint
        Try
            Dim PL_KEY As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_KEY")
            Dim ParentID As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_PLFOSKEY")
            Dim SourceNo As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_PLFST_OPENSTOCK(PL_KEY, ParentID, SourceNo, LineStatus)
            line_PLFST_OPENSTOCK.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_PLFST_OPENSTOCK(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_PLFST_OPENSTOCK_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_PLFST_OPENSTOCK_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "PLFST_PURCHASE"
    Private Sub txtTotal_PLFST_PURCHASE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_PLFST_PURCHASE.BeforePrint
        Try
            Dim PL_KEY As Integer = PLFST_PURCHASE.GetCurrentColumnValue("PLFPUR_KEY")
            Dim countx As Integer = ADO.Load_PLFST_PURCHASE_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_PLFST_PURCHASE.Visible = False
                txtTotal_PLFST_PURCHASE.Visible = False
                lineTotal_PLFST_PURCHASE_top.Visible = False
                lineTotal_PLFST_PURCHASE_bot.Visible = False
            Else
                Dim ParentID As Integer = PLFST_PURCHASE.GetCurrentColumnValue("PLFPUR_PLFPURKEY")
                Dim SourceNo As Integer = PLFST_PURCHASE.GetCurrentColumnValue("PLFPUR_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_PLFST_PURCHASE_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_PLFST_PURCHASE.Visible = True
                    lineTotal_PLFST_PURCHASE_top.Visible = True
                    lineTotal_PLFST_PURCHASE_bot.Visible = True
                Else
                    txtTotal_PLFST_PURCHASE.Visible = False
                    lineTotal_PLFST_PURCHASE_top.Visible = False
                    lineTotal_PLFST_PURCHASE_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_PLFST_PURCHASE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_PLFST_PURCHASE.BeforePrint

        Try
            Dim PL_KEY As Integer = PLFST_PURCHASE.GetCurrentColumnValue("PLFPUR_KEY")
            Dim ParentID As Integer = PLFST_PURCHASE.GetCurrentColumnValue("PLFPUR_PLFPURKEY")
            Dim SourceNo As Integer = PLFST_PURCHASE.GetCurrentColumnValue("PLFPUR_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_PLFST_PURCHASE.Visible = Me.GetVisibility_PLFST_PURCHASE(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_PLFST_PURCHASE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_PLFST_PURCHASE.BeforePrint
        Try
            Dim PL_KEY As Integer = PLFST_PURCHASE.GetCurrentColumnValue("PLFPUR_KEY")
            Dim ParentID As Integer = PLFST_PURCHASE.GetCurrentColumnValue("PLFPUR_PLFPURKEY")
            Dim SourceNo As Integer = PLFST_PURCHASE.GetCurrentColumnValue("PLFPUR_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_PLFST_PURCHASE(PL_KEY, ParentID, SourceNo, LineStatus)
            line_PLFST_PURCHASE.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_PLFST_PURCHASE(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_PLFST_PURCHASE_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_PLFST_PURCHASE_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "PLFST_CLOSESTOCK"
    Private Sub txtTotal_PLFST_CLOSESTOCK_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_PLFST_CLOSESTOCK.BeforePrint
        Try
            Dim PL_KEY As Integer = PLFST_CLOSESTOCK.GetCurrentColumnValue("PLFCS_KEY")
            Dim countx As Integer = ADO.Load_PLFST_CLOSESTOCK_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_PLFST_CLOSESTOCK.Visible = False
                txtTotal_PLFST_CLOSESTOCK.Visible = False
                lineTotal_PLFST_CLOSESTOCK_top.Visible = False
                lineTotal_PLFST_CLOSESTOCK_bot.Visible = False
            Else
                Dim ParentID As Integer = PLFST_CLOSESTOCK.GetCurrentColumnValue("PLFCS_PLFCSKEY")
                Dim SourceNo As Integer = PLFST_CLOSESTOCK.GetCurrentColumnValue("PLFCS_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_PLFST_CLOSESTOCK_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_PLFST_CLOSESTOCK.Visible = True
                    lineTotal_PLFST_CLOSESTOCK_top.Visible = True
                    lineTotal_PLFST_CLOSESTOCK_bot.Visible = True
                Else
                    txtTotal_PLFST_CLOSESTOCK.Visible = False
                    lineTotal_PLFST_CLOSESTOCK_top.Visible = False
                    lineTotal_PLFST_CLOSESTOCK_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_PLFST_CLOSESTOCK_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_PLFST_CLOSESTOCK.BeforePrint

        Try
            Dim PL_KEY As Integer = PLFST_CLOSESTOCK.GetCurrentColumnValue("PLFCS_KEY")
            Dim ParentID As Integer = PLFST_CLOSESTOCK.GetCurrentColumnValue("PLFCS_PLFCSKEY")
            Dim SourceNo As Integer = PLFST_CLOSESTOCK.GetCurrentColumnValue("PLFCS_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_PLFST_CLOSESTOCK.Visible = Me.GetVisibility_PLFST_CLOSESTOCK(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_PLFST_CLOSESTOCK_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_PLFST_CLOSESTOCK.BeforePrint
        Try
            Dim PL_KEY As Integer = PLFST_CLOSESTOCK.GetCurrentColumnValue("PLFCS_KEY")
            Dim ParentID As Integer = PLFST_CLOSESTOCK.GetCurrentColumnValue("PLFCS_PLFCSKEY")
            Dim SourceNo As Integer = PLFST_CLOSESTOCK.GetCurrentColumnValue("PLFCS_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_PLFST_CLOSESTOCK(PL_KEY, ParentID, SourceNo, LineStatus)
            line_PLFST_CLOSESTOCK.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_PLFST_CLOSESTOCK(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_PLFST_CLOSESTOCK_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_PLFST_CLOSESTOCK_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "NONSOURCE_BUSINESSINCOME"
    Private Sub txtTotal_NONSOURCE_BUSINESSINCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_NONSOURCE_BUSINESSINCOME.BeforePrint
        Try
            Dim PL_KEY As Integer = NONSOURCE_BUSINESSINCOME.GetCurrentColumnValue("NSBI_KEY")
            Dim countx As Integer = ADO.Load_NONSOURCE_BUSINESSINCOME_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_NONSOURCE_BUSINESSINCOME.Visible = False
                txtTotal_NONSOURCE_BUSINESSINCOME.Visible = False
                lineTotal_NONSOURCE_BUSINESSINCOME_top.Visible = False
                lineTotal_NONSOURCE_BUSINESSINCOME_bot.Visible = False
            Else
                Dim ParentID As Integer = NONSOURCE_BUSINESSINCOME.GetCurrentColumnValue("NSBI_NSBIKEY")
                Dim SourceNo As Integer = NONSOURCE_BUSINESSINCOME.GetCurrentColumnValue("NSBI_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_NONSOURCE_BUSINESSINCOME_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_NONSOURCE_BUSINESSINCOME.Visible = True
                    lineTotal_NONSOURCE_BUSINESSINCOME_top.Visible = True
                    lineTotal_NONSOURCE_BUSINESSINCOME_bot.Visible = True
                Else
                    txtTotal_NONSOURCE_BUSINESSINCOME.Visible = False
                    lineTotal_NONSOURCE_BUSINESSINCOME_top.Visible = False
                    lineTotal_NONSOURCE_BUSINESSINCOME_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_NONSOURCE_BUSINESSINCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_NONSOURCE_BUSINESSINCOME.BeforePrint

        Try
            Dim PL_KEY As Integer = NONSOURCE_BUSINESSINCOME.GetCurrentColumnValue("NSBI_KEY")
            Dim ParentID As Integer = NONSOURCE_BUSINESSINCOME.GetCurrentColumnValue("NSBI_NSBIKEY")
            Dim SourceNo As Integer = NONSOURCE_BUSINESSINCOME.GetCurrentColumnValue("NSBI_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_NONSOURCE_BUSINESSINCOME.Visible = Me.GetVisibility_NONSOURCE_BUSINESSINCOME(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_NONSOURCE_BUSINESSINCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_NONSOURCE_BUSINESSINCOME.BeforePrint
        Try
            Dim PL_KEY As Integer = NONSOURCE_BUSINESSINCOME.GetCurrentColumnValue("NSBI_KEY")
            Dim ParentID As Integer = NONSOURCE_BUSINESSINCOME.GetCurrentColumnValue("NSBI_NSBIKEY")
            Dim SourceNo As Integer = NONSOURCE_BUSINESSINCOME.GetCurrentColumnValue("NSBI_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_NONSOURCE_BUSINESSINCOME(PL_KEY, ParentID, SourceNo, LineStatus)
            line_NONSOURCE_BUSINESSINCOME.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_NONSOURCE_BUSINESSINCOME(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_NONSOURCE_BUSINESSINCOME_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_NONSOURCE_BUSINESSINCOME_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "INCOME_REALFET"
    Private Sub txtTotal_INCOME_REALFET_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_INCOME_REALFET.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_REALFET.GetCurrentColumnValue("IRFET_KEY")
            Dim countx As Integer = ADO.Load_INCOME_REALFET_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_INCOME_REALFET.Visible = False
                txtTotal_INCOME_REALFET.Visible = False
                lineTotal_INCOME_REALFET_top.Visible = False
                lineTotal_INCOME_REALFET_bot.Visible = False
            Else
                Dim ParentID As Integer = INCOME_REALFET.GetCurrentColumnValue("IRFET_IRFETKEY")
                Dim SourceNo As Integer = INCOME_REALFET.GetCurrentColumnValue("IRFET_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_INCOME_REALFET_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_INCOME_REALFET.Visible = True
                    lineTotal_INCOME_REALFET_top.Visible = True
                    lineTotal_INCOME_REALFET_bot.Visible = True
                Else
                    txtTotal_INCOME_REALFET.Visible = False
                    lineTotal_INCOME_REALFET_top.Visible = False
                    lineTotal_INCOME_REALFET_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_INCOME_REALFET_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_INCOME_REALFET.BeforePrint

        Try
            Dim PL_KEY As Integer = INCOME_REALFET.GetCurrentColumnValue("IRFET_KEY")
            Dim ParentID As Integer = INCOME_REALFET.GetCurrentColumnValue("IRFET_IRFETKEY")
            Dim SourceNo As Integer = INCOME_REALFET.GetCurrentColumnValue("IRFET_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_INCOME_REALFET.Visible = Me.GetVisibility_INCOME_REALFET(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_INCOME_REALFET_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_INCOME_REALFET.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_REALFET.GetCurrentColumnValue("IRFET_KEY")
            Dim ParentID As Integer = INCOME_REALFET.GetCurrentColumnValue("IRFET_IRFETKEY")
            Dim SourceNo As Integer = INCOME_REALFET.GetCurrentColumnValue("IRFET_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_INCOME_REALFET(PL_KEY, ParentID, SourceNo, LineStatus)
            line_INCOME_REALFET.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_INCOME_REALFET(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_INCOME_REALFET_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_INCOME_REALFET_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "DIVIDEND_INCOME"

    '    Private Sub txtTotal_DIVIDEND_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_DIVIDEND_INCOME.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = DIVIDEND_INCOME.GetCurrentColumnValue("DI_KEY")
    '            Dim countx As Integer = ADO.LoadDIVIDEND_INCOME_TOTAL_SOURCENO(PL_KEY)

    '            If countx <= 1 Then
    '                ' GF_DIVIDEND_INCOME.Visible = False
    '                txtTotal_DIVIDEND_INCOME.Visible = False
    '                lineTotal_DIVIDEND_INCOME_top.Visible = False
    '                lineTotal_DIVIDEND_INCOME_bot.Visible = False
    '            Else
    '                Dim ParentID As Integer = DIVIDEND_INCOME.GetCurrentColumnValue("DI_DIVIDENDKEY")
    '                Dim SourceNo As Integer = DIVIDEND_INCOME.GetCurrentColumnValue("DI_SOURCENO")
    '                Dim countx_Item As Integer = ADO.LoadDIVIDEND_INCOME_COUNT(PL_KEY, SourceNo)
    '                If countx_Item > 1 Then
    '                    txtTotal_DIVIDEND_INCOME.Visible = True
    '                    lineTotal_DIVIDEND_INCOME_top.Visible = True
    '                    lineTotal_DIVIDEND_INCOME_bot.Visible = True
    '                Else
    '                    txtTotal_DIVIDEND_INCOME.Visible = False
    '                    lineTotal_DIVIDEND_INCOME_top.Visible = False
    '                    lineTotal_DIVIDEND_INCOME_bot.Visible = False
    '                End If

    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub txt_DIVIDEND_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_DIVIDEND_INCOME.BeforePrint

    '        Try
    '            Dim PL_KEY As Integer = DIVIDEND_INCOME.GetCurrentColumnValue("DI_KEY")
    '            Dim ParentID As Integer = DIVIDEND_INCOME.GetCurrentColumnValue("DI_DIVIDENDKEY")
    '            Dim SourceNo As Integer = DIVIDEND_INCOME.GetCurrentColumnValue("DI_SOURCENO")
    '            Dim LineStatus As Boolean = False
    '            txt_DIVIDEND_INCOME.Visible = Me.GetVisibility_DIVIDEND_INCOME(PL_KEY, ParentID, SourceNo, LineStatus)

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_DIVIDEND_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_DIVIDEND_INCOME.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = DIVIDEND_INCOME.GetCurrentColumnValue("DI_KEY")
    '            Dim ParentID As Integer = DIVIDEND_INCOME.GetCurrentColumnValue("DI_DIVIDENDKEY")
    '            Dim SourceNo As Integer = DIVIDEND_INCOME.GetCurrentColumnValue("DI_SOURCENO")
    '            Dim LineStatus As Boolean = False
    '            Me.GetVisibility_DIVIDEND_INCOME(PL_KEY, ParentID, SourceNo, LineStatus)
    '            line_DIVIDEND_INCOME.Visible = LineStatus
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Function GetVisibility_DIVIDEND_INCOME(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
    '        Try

    '            Dim countx_subItem As Integer = ADO.LoadDIVIDEND_INCOME_COUNT_SUBITEM(PL_KEY, ParentID)
    '            Dim count_Item As Integer = ADO.LoadDIVIDEND_INCOME_COUNT(PL_KEY, SourceNo)

    '            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
    '                LineStatus = True
    '                Return True
    '            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
    '                LineStatus = False
    '                Return True
    '            Else
    '                LineStatus = False
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            Return False
    '        End Try
    '    End Function
#End Region
#Region "INCOME_NBINTEREST"
    Private Sub txtTotal_INCOME_NBINTEREST_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_INCOME_NBINTEREST.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NBINTEREST.GetCurrentColumnValue("NOBII_KEY")
            Dim countx As Integer = ADO.Load_INCOME_NBINTEREST_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_INCOME_NBINTEREST.Visible = False
                txtTotal_INCOME_NBINTEREST.Visible = False
                lineTotal_INCOME_NBINTEREST_top.Visible = False
                lineTotal_INCOME_NBINTEREST_bot.Visible = False
            Else
                Dim ParentID As Integer = INCOME_NBINTEREST.GetCurrentColumnValue("NOBII_NOBIIKEY")
                Dim SourceNo As Integer = INCOME_NBINTEREST.GetCurrentColumnValue("NOBII_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_INCOME_NBINTEREST_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_INCOME_NBINTEREST.Visible = True
                    lineTotal_INCOME_NBINTEREST_top.Visible = True
                    lineTotal_INCOME_NBINTEREST_bot.Visible = True
                Else
                    txtTotal_INCOME_NBINTEREST.Visible = False
                    lineTotal_INCOME_NBINTEREST_top.Visible = False
                    lineTotal_INCOME_NBINTEREST_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_INCOME_NBINTEREST_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_INCOME_NBINTEREST.BeforePrint

        Try
            Dim PL_KEY As Integer = INCOME_NBINTEREST.GetCurrentColumnValue("NOBII_KEY")
            Dim ParentID As Integer = INCOME_NBINTEREST.GetCurrentColumnValue("NOBII_NOBIIKEY")
            Dim SourceNo As Integer = INCOME_NBINTEREST.GetCurrentColumnValue("NOBII_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_INCOME_NBINTEREST.Visible = Me.GetVisibility_INCOME_NBINTEREST(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_INCOME_NBINTEREST_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_INCOME_NBINTEREST.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NBINTEREST.GetCurrentColumnValue("NOBII_KEY")
            Dim ParentID As Integer = INCOME_NBINTEREST.GetCurrentColumnValue("NOBII_NOBIIKEY")
            Dim SourceNo As Integer = INCOME_NBINTEREST.GetCurrentColumnValue("NOBII_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_INCOME_NBINTEREST(PL_KEY, ParentID, SourceNo, LineStatus)
            line_INCOME_NBINTEREST.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_INCOME_NBINTEREST(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_INCOME_NBINTEREST_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_INCOME_NBINTEREST_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
    '#Region "RENTAL_INCOME"
    '    Private Sub txtTotal_RENTAL_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_RENTAL_INCOME.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = RENTAL_INCOME.GetCurrentColumnValue("RI_KEY")
    '            Dim countx As Integer = ADO.LoadRENTAL_INCOME_TOTAL_SOURCENO(PL_KEY)

    '            If countx <= 1 Then
    '                ' GF_RENTAL_INCOME.Visible = False
    '                txtTotal_RENTAL_INCOME.Visible = False
    '                lineTotal_RENTAL_INCOME_top.Visible = False
    '                lineTotal_RENTAL_INCOME_bot.Visible = False
    '            Else
    '                Dim ParentID As Integer = RENTAL_INCOME.GetCurrentColumnValue("RI_RENTKEY")
    '                Dim SourceNo As Integer = RENTAL_INCOME.GetCurrentColumnValue("RI_SOURCENO")
    '                Dim countx_Item As Integer = ADO.LoadRENTAL_INCOME_COUNT(PL_KEY, SourceNo)
    '                If countx_Item > 1 Then
    '                    txtTotal_RENTAL_INCOME.Visible = True
    '                    lineTotal_RENTAL_INCOME_top.Visible = True
    '                    lineTotal_RENTAL_INCOME_bot.Visible = True
    '                Else
    '                    txtTotal_RENTAL_INCOME.Visible = False
    '                    lineTotal_RENTAL_INCOME_top.Visible = False
    '                    lineTotal_RENTAL_INCOME_bot.Visible = False
    '                End If

    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub txt_RENTAL_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_RENTAL_INCOME.BeforePrint

    '        Try
    '            Dim PL_KEY As Integer = RENTAL_INCOME.GetCurrentColumnValue("RI_KEY")
    '            Dim ParentID As Integer = RENTAL_INCOME.GetCurrentColumnValue("RI_RENTKEY")
    '            Dim SourceNo As Integer = RENTAL_INCOME.GetCurrentColumnValue("RI_SOURCENO")
    '            Dim LineStatus As Boolean = False
    '            txt_RENTAL_INCOME.Visible = Me.GetVisibility_RENTAL_INCOME(PL_KEY, ParentID, SourceNo, LineStatus)

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_RENTAL_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_RENTAL_INCOME.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = RENTAL_INCOME.GetCurrentColumnValue("RI_KEY")
    '            Dim ParentID As Integer = RENTAL_INCOME.GetCurrentColumnValue("RI_RENTKEY")
    '            Dim SourceNo As Integer = RENTAL_INCOME.GetCurrentColumnValue("RI_SOURCENO")
    '            Dim LineStatus As Boolean = False
    '            Me.GetVisibility_RENTAL_INCOME(PL_KEY, ParentID, SourceNo, LineStatus)
    '            line_RENTAL_INCOME.Visible = LineStatus
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Function GetVisibility_RENTAL_INCOME(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
    '        Try

    '            Dim countx_subItem As Integer = ADO.LoadRENTAL_INCOME_COUNT_SUBITEM(PL_KEY, ParentID)
    '            Dim count_Item As Integer = ADO.LoadRENTAL_INCOME_COUNT(PL_KEY, SourceNo)

    '            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
    '                LineStatus = True
    '                Return True
    '            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
    '                LineStatus = False
    '                Return True
    '            Else
    '                LineStatus = False
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            Return False
    '        End Try
    '    End Function
    '#End Region
#Region "INCOME_NBROYALTY"
    Private Sub txtTotal_INCOME_NBROYALTY_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_INCOME_NBROYALTY.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NBROYALTY.GetCurrentColumnValue("NOBRI_KEY")
            Dim countx As Integer = ADO.Load_INCOME_NBROYALTY_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_INCOME_NBROYALTY.Visible = False
                txtTotal_INCOME_NBROYALTY.Visible = False
                lineTotal_INCOME_NBROYALTY_top.Visible = False
                lineTotal_INCOME_NBROYALTY_bot.Visible = False
            Else
                Dim ParentID As Integer = INCOME_NBROYALTY.GetCurrentColumnValue("NOBRI_NOBRIKEY")
                Dim SourceNo As Integer = INCOME_NBROYALTY.GetCurrentColumnValue("NOBRI_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_INCOME_NBROYALTY_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_INCOME_NBROYALTY.Visible = True
                    lineTotal_INCOME_NBROYALTY_top.Visible = True
                    lineTotal_INCOME_NBROYALTY_bot.Visible = True
                Else
                    txtTotal_INCOME_NBROYALTY.Visible = False
                    lineTotal_INCOME_NBROYALTY_top.Visible = False
                    lineTotal_INCOME_NBROYALTY_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_INCOME_NBROYALTY_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_INCOME_NBROYALTY.BeforePrint

        Try
            Dim PL_KEY As Integer = INCOME_NBROYALTY.GetCurrentColumnValue("NOBRI_KEY")
            Dim ParentID As Integer = INCOME_NBROYALTY.GetCurrentColumnValue("NOBRI_NOBRIKEY")
            Dim SourceNo As Integer = INCOME_NBROYALTY.GetCurrentColumnValue("NOBRI_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_INCOME_NBROYALTY.Visible = Me.GetVisibility_INCOME_NBROYALTY(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_INCOME_NBROYALTY_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_INCOME_NBROYALTY.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NBROYALTY.GetCurrentColumnValue("NOBRI_KEY")
            Dim ParentID As Integer = INCOME_NBROYALTY.GetCurrentColumnValue("NOBRI_NOBRIKEY")
            Dim SourceNo As Integer = INCOME_NBROYALTY.GetCurrentColumnValue("NOBRI_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_INCOME_NBROYALTY(PL_KEY, ParentID, SourceNo, LineStatus)
            line_INCOME_NBROYALTY.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_INCOME_NBROYALTY(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_INCOME_NBROYALTY_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_INCOME_NBROYALTY_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_INCOME"
    Private Sub txtTotal_OTHER_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_INCOME.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_INCOME.GetCurrentColumnValue("OI_KEY")
            Dim countx As Integer = ADO.Load_OTHER_INCOME_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_INCOME.Visible = False
                txtTotal_OTHER_INCOME.Visible = False
                lineTotal_OTHER_INCOME_top.Visible = False
                lineTotal_OTHER_INCOME_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_INCOME.GetCurrentColumnValue("OI_OIKEY")
                Dim SourceNo As Integer = OTHER_INCOME.GetCurrentColumnValue("OI_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_INCOME_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_INCOME.Visible = True
                    lineTotal_OTHER_INCOME_top.Visible = True
                    lineTotal_OTHER_INCOME_bot.Visible = True
                Else
                    txtTotal_OTHER_INCOME.Visible = False
                    lineTotal_OTHER_INCOME_top.Visible = False
                    lineTotal_OTHER_INCOME_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_INCOME.BeforePrint

        Try
            Dim PL_KEY As Integer = OTHER_INCOME.GetCurrentColumnValue("OI_KEY")
            Dim ParentID As Integer = OTHER_INCOME.GetCurrentColumnValue("OI_OIKEY")
            Dim SourceNo As Integer = OTHER_INCOME.GetCurrentColumnValue("OI_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_INCOME.Visible = Me.GetVisibility_OTHER_INCOME(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_INCOME.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_INCOME.GetCurrentColumnValue("OI_KEY")
            Dim ParentID As Integer = OTHER_INCOME.GetCurrentColumnValue("OI_OIKEY")
            Dim SourceNo As Integer = OTHER_INCOME.GetCurrentColumnValue("OI_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_INCOME(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_INCOME.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_INCOME(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_INCOME_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_OTHER_INCOME_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "INCOME_NTDISPOSALFA"
    Private Sub txtTotal_INCOME_NTDISPOSALFA_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_INCOME_NTDISPOSALFA.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NTDISPOSALFA.GetCurrentColumnValue("NTIDFA_KEY")
            Dim countx As Integer = ADO.Load_INCOME_NTDISPOSALFA_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_INCOME_NTDISPOSALFA.Visible = False
                txtTotal_INCOME_NTDISPOSALFA.Visible = False
                lineTotal_INCOME_NTDISPOSALFA_top.Visible = False
                lineTotal_INCOME_NTDISPOSALFA_bot.Visible = False
            Else
                Dim ParentID As Integer = INCOME_NTDISPOSALFA.GetCurrentColumnValue("NTIDFA_NTIDFAKEY")
                Dim SourceNo As Integer = INCOME_NTDISPOSALFA.GetCurrentColumnValue("NTIDFA_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_INCOME_NTDISPOSALFA_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_INCOME_NTDISPOSALFA.Visible = True
                    lineTotal_INCOME_NTDISPOSALFA_top.Visible = True
                    lineTotal_INCOME_NTDISPOSALFA_bot.Visible = True
                Else
                    txtTotal_INCOME_NTDISPOSALFA.Visible = False
                    lineTotal_INCOME_NTDISPOSALFA_top.Visible = False
                    lineTotal_INCOME_NTDISPOSALFA_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_INCOME_NTDISPOSALFA_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_INCOME_NTDISPOSALFA.BeforePrint

        Try
            Dim PL_KEY As Integer = INCOME_NTDISPOSALFA.GetCurrentColumnValue("NTIDFA_KEY")
            Dim ParentID As Integer = INCOME_NTDISPOSALFA.GetCurrentColumnValue("NTIDFA_NTIDFAKEY")
            Dim SourceNo As Integer = INCOME_NTDISPOSALFA.GetCurrentColumnValue("NTIDFA_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_INCOME_NTDISPOSALFA.Visible = Me.GetVisibility_INCOME_NTDISPOSALFA(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_INCOME_NTDISPOSALFA_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_INCOME_NTDISPOSALFA.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NTDISPOSALFA.GetCurrentColumnValue("NTIDFA_KEY")
            Dim ParentID As Integer = INCOME_NTDISPOSALFA.GetCurrentColumnValue("NTIDFA_NTIDFAKEY")
            Dim SourceNo As Integer = INCOME_NTDISPOSALFA.GetCurrentColumnValue("NTIDFA_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_INCOME_NTDISPOSALFA(PL_KEY, ParentID, SourceNo, LineStatus)
            line_INCOME_NTDISPOSALFA.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_INCOME_NTDISPOSALFA(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_INCOME_NTDISPOSALFA_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_INCOME_NTDISPOSALFA_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "INCOME_NTDISPOSALINVEST"
    Private Sub txtTotal_INCOME_NTDISPOSALINVEST_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_INCOME_NTDISPOSALINVEST.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NTDISPOSALINVEST.GetCurrentColumnValue("NTIDI_KEY")
            Dim countx As Integer = ADO.Load_INCOME_NTDISPOSALINVEST_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_INCOME_NTDISPOSALINVEST.Visible = False
                txtTotal_INCOME_NTDISPOSALINVEST.Visible = False
                lineTotal_INCOME_NTDISPOSALINVEST_top.Visible = False
                lineTotal_INCOME_NTDISPOSALINVEST_bot.Visible = False
            Else
                Dim ParentID As Integer = INCOME_NTDISPOSALINVEST.GetCurrentColumnValue("NTIDI_NTIDIKEY")
                Dim SourceNo As Integer = INCOME_NTDISPOSALINVEST.GetCurrentColumnValue("NTIDI_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_INCOME_NTDISPOSALINVEST_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_INCOME_NTDISPOSALINVEST.Visible = True
                    lineTotal_INCOME_NTDISPOSALINVEST_top.Visible = True
                    lineTotal_INCOME_NTDISPOSALINVEST_bot.Visible = True
                Else
                    txtTotal_INCOME_NTDISPOSALINVEST.Visible = False
                    lineTotal_INCOME_NTDISPOSALINVEST_top.Visible = False
                    lineTotal_INCOME_NTDISPOSALINVEST_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_INCOME_NTDISPOSALINVEST_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_INCOME_NTDISPOSALINVEST.BeforePrint

        Try
            Dim PL_KEY As Integer = INCOME_NTDISPOSALINVEST.GetCurrentColumnValue("NTIDI_KEY")
            Dim ParentID As Integer = INCOME_NTDISPOSALINVEST.GetCurrentColumnValue("NTIDI_NTIDIKEY")
            Dim SourceNo As Integer = INCOME_NTDISPOSALINVEST.GetCurrentColumnValue("NTIDI_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_INCOME_NTDISPOSALINVEST.Visible = Me.GetVisibility_INCOME_NTDISPOSALINVEST(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_INCOME_NTDISPOSALINVEST_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_INCOME_NTDISPOSALINVEST.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NTDISPOSALINVEST.GetCurrentColumnValue("NTIDI_KEY")
            Dim ParentID As Integer = INCOME_NTDISPOSALINVEST.GetCurrentColumnValue("NTIDI_NTIDIKEY")
            Dim SourceNo As Integer = INCOME_NTDISPOSALINVEST.GetCurrentColumnValue("NTIDI_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_INCOME_NTDISPOSALINVEST(PL_KEY, ParentID, SourceNo, LineStatus)
            line_INCOME_NTDISPOSALINVEST.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_INCOME_NTDISPOSALINVEST(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_INCOME_NTDISPOSALINVEST_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_INCOME_NTDISPOSALINVEST_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
    '#Region "EXEMPT_DIVIDEND"
    '    Private Sub txtTotal_EXEMPT_DIVIDEND_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXEMPT_DIVIDEND.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = EXEMPT_DIVIDEND.GetCurrentColumnValue("ED_KEY")
    '            Dim countx As Integer = ADO.LoadEXEMPT_DIVIDEND_TOTAL_SOURCENO(PL_KEY)

    '            If countx <= 1 Then
    '                ' GF_EXEMPT_DIVIDEND.Visible = False
    '                txtTotal_EXEMPT_DIVIDEND.Visible = False
    '                lineTotal_EXEMPT_DIVIDEND_top.Visible = False
    '                lineTotal_EXEMPT_DIVIDEND_bot.Visible = False
    '            Else
    '                Dim ParentID As Integer = EXEMPT_DIVIDEND.GetCurrentColumnValue("ED_EDKEY")
    '                Dim SourceNo As Integer = EXEMPT_DIVIDEND.GetCurrentColumnValue("ED_SOURCENO")
    '                Dim countx_Item As Integer = ADO.LoadEXEMPT_DIVIDEND_COUNT(PL_KEY, SourceNo)
    '                If countx_Item > 1 Then
    '                    txtTotal_EXEMPT_DIVIDEND.Visible = True
    '                    lineTotal_EXEMPT_DIVIDEND_top.Visible = True
    '                    lineTotal_EXEMPT_DIVIDEND_bot.Visible = True
    '                Else
    '                    txtTotal_EXEMPT_DIVIDEND.Visible = False
    '                    lineTotal_EXEMPT_DIVIDEND_top.Visible = False
    '                    lineTotal_EXEMPT_DIVIDEND_bot.Visible = False
    '                End If

    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub txt_EXEMPT_DIVIDEND_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXEMPT_DIVIDEND.BeforePrint

    '        Try
    '            Dim PL_KEY As Integer = EXEMPT_DIVIDEND.GetCurrentColumnValue("ED_KEY")
    '            Dim ParentID As Integer = EXEMPT_DIVIDEND.GetCurrentColumnValue("ED_EDKEY")
    '            Dim SourceNo As Integer = EXEMPT_DIVIDEND.GetCurrentColumnValue("ED_SOURCENO")
    '            Dim LineStatus As Boolean = False
    '            txt_EXEMPT_DIVIDEND.Visible = Me.GetVisibility_EXEMPT_DIVIDEND(PL_KEY, ParentID, SourceNo, LineStatus)

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_EXEMPT_DIVIDEND_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXEMPT_DIVIDEND.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = EXEMPT_DIVIDEND.GetCurrentColumnValue("ED_KEY")
    '            Dim ParentID As Integer = EXEMPT_DIVIDEND.GetCurrentColumnValue("ED_EDKEY")
    '            Dim SourceNo As Integer = EXEMPT_DIVIDEND.GetCurrentColumnValue("ED_SOURCENO")
    '            Dim LineStatus As Boolean = False
    '            Me.GetVisibility_EXEMPT_DIVIDEND(PL_KEY, ParentID, SourceNo, LineStatus)
    '            line_EXEMPT_DIVIDEND.Visible = LineStatus
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Function GetVisibility_EXEMPT_DIVIDEND(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
    '        Try

    '            Dim countx_subItem As Integer = ADO.LoadEXEMPT_DIVIDEND_COUNT_SUBITEM(PL_KEY, ParentID)
    '            Dim count_Item As Integer = ADO.LoadEXEMPT_DIVIDEND_COUNT(PL_KEY, SourceNo)

    '            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
    '                LineStatus = True
    '                Return True
    '            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
    '                LineStatus = False
    '                Return True
    '            Else
    '                LineStatus = False
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            Return False
    '        End Try
    '    End Function
    '#End Region
#Region "INCOME_NTFOREIGNINCREM"
    Private Sub txtTotal_INCOME_NTFOREIGNINCREM_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_INCOME_NTFOREIGNINCREM.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NTFOREIGNINCREM.GetCurrentColumnValue("NTIFIR_KEY")
            Dim countx As Integer = ADO.Load_INCOME_NTFOREIGNINCREM_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_INCOME_NTFOREIGNINCREM.Visible = False
                txtTotal_INCOME_NTFOREIGNINCREM.Visible = False
                lineTotal_INCOME_NTFOREIGNINCREM_top.Visible = False
                lineTotal_INCOME_NTFOREIGNINCREM_bot.Visible = False
            Else
                Dim ParentID As Integer = INCOME_NTFOREIGNINCREM.GetCurrentColumnValue("NTIFIR_NTIFIRKEY")
                Dim SourceNo As Integer = INCOME_NTFOREIGNINCREM.GetCurrentColumnValue("NTIFIR_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_INCOME_NTFOREIGNINCREM_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_INCOME_NTFOREIGNINCREM.Visible = True
                    lineTotal_INCOME_NTFOREIGNINCREM_top.Visible = True
                    lineTotal_INCOME_NTFOREIGNINCREM_bot.Visible = True
                Else
                    txtTotal_INCOME_NTFOREIGNINCREM.Visible = False
                    lineTotal_INCOME_NTFOREIGNINCREM_top.Visible = False
                    lineTotal_INCOME_NTFOREIGNINCREM_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_INCOME_NTFOREIGNINCREM_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_INCOME_NTFOREIGNINCREM.BeforePrint

        Try
            Dim PL_KEY As Integer = INCOME_NTFOREIGNINCREM.GetCurrentColumnValue("NTIFIR_KEY")
            Dim ParentID As Integer = INCOME_NTFOREIGNINCREM.GetCurrentColumnValue("NTIFIR_NTIFIRKEY")
            Dim SourceNo As Integer = INCOME_NTFOREIGNINCREM.GetCurrentColumnValue("NTIFIR_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_INCOME_NTFOREIGNINCREM.Visible = Me.GetVisibility_INCOME_NTFOREIGNINCREM(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_INCOME_NTFOREIGNINCREM_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_INCOME_NTFOREIGNINCREM.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NTFOREIGNINCREM.GetCurrentColumnValue("NTIFIR_KEY")
            Dim ParentID As Integer = INCOME_NTFOREIGNINCREM.GetCurrentColumnValue("NTIFIR_NTIFIRKEY")
            Dim SourceNo As Integer = INCOME_NTFOREIGNINCREM.GetCurrentColumnValue("NTIFIR_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_INCOME_NTFOREIGNINCREM(PL_KEY, ParentID, SourceNo, LineStatus)
            line_INCOME_NTFOREIGNINCREM.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_INCOME_NTFOREIGNINCREM(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_INCOME_NTFOREIGNINCREM_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_INCOME_NTFOREIGNINCREM_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "INCOME_NTREALFE"
    Private Sub txtTotal_INCOME_NTREALFE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_INCOME_NTREALFE.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NTREALFE.GetCurrentColumnValue("NTIRFECT_KEY")
            Dim countx As Integer = ADO.Load_INCOME_NTREALFE_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_INCOME_NTREALFE.Visible = False
                txtTotal_INCOME_NTREALFE.Visible = False
                lineTotal_INCOME_NTREALFE_top.Visible = False
                lineTotal_INCOME_NTREALFE_bot.Visible = False
            Else
                Dim ParentID As Integer = INCOME_NTREALFE.GetCurrentColumnValue("NTIRFECT_NTIRFECTKEY")
                Dim SourceNo As Integer = INCOME_NTREALFE.GetCurrentColumnValue("NTIRFECT_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_INCOME_NTREALFE_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_INCOME_NTREALFE.Visible = True
                    lineTotal_INCOME_NTREALFE_top.Visible = True
                    lineTotal_INCOME_NTREALFE_bot.Visible = True
                Else
                    txtTotal_INCOME_NTREALFE.Visible = False
                    lineTotal_INCOME_NTREALFE_top.Visible = False
                    lineTotal_INCOME_NTREALFE_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_INCOME_NTREALFE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_INCOME_NTREALFE.BeforePrint

        Try
            Dim PL_KEY As Integer = INCOME_NTREALFE.GetCurrentColumnValue("NTIRFECT_KEY")
            Dim ParentID As Integer = INCOME_NTREALFE.GetCurrentColumnValue("NTIRFECT_NTIRFECTKEY")
            Dim SourceNo As Integer = INCOME_NTREALFE.GetCurrentColumnValue("NTIRFECT_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_INCOME_NTREALFE.Visible = Me.GetVisibility_INCOME_NTREALFE(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_INCOME_NTREALFE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_INCOME_NTREALFE.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NTREALFE.GetCurrentColumnValue("NTIRFECT_KEY")
            Dim ParentID As Integer = INCOME_NTREALFE.GetCurrentColumnValue("NTIRFECT_NTIRFECTKEY")
            Dim SourceNo As Integer = INCOME_NTREALFE.GetCurrentColumnValue("NTIRFECT_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_INCOME_NTREALFE(PL_KEY, ParentID, SourceNo, LineStatus)
            line_INCOME_NTREALFE.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_INCOME_NTREALFE(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_INCOME_NTREALFE_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_INCOME_NTREALFE_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "INCOME_NTUREALFET"
    Private Sub txtTotal_INCOME_NTUREALFET_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_INCOME_NTUREALFET.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NTUREALFET.GetCurrentColumnValue("NTIUT_KEY")
            Dim countx As Integer = ADO.Load_INCOME_NTUREALFET_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_INCOME_NTUREALFET.Visible = False
                txtTotal_INCOME_NTUREALFET.Visible = False
                lineTotal_INCOME_NTUREALFET_top.Visible = False
                lineTotal_INCOME_NTUREALFET_bot.Visible = False
            Else
                Dim ParentID As Integer = INCOME_NTUREALFET.GetCurrentColumnValue("NTIUT_NTIUTKEY")
                Dim SourceNo As Integer = INCOME_NTUREALFET.GetCurrentColumnValue("NTIUT_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_INCOME_NTUREALFET_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_INCOME_NTUREALFET.Visible = True
                    lineTotal_INCOME_NTUREALFET_top.Visible = True
                    lineTotal_INCOME_NTUREALFET_bot.Visible = True
                Else
                    txtTotal_INCOME_NTUREALFET.Visible = False
                    lineTotal_INCOME_NTUREALFET_top.Visible = False
                    lineTotal_INCOME_NTUREALFET_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_INCOME_NTUREALFET_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_INCOME_NTUREALFET.BeforePrint

        Try
            Dim PL_KEY As Integer = INCOME_NTUREALFET.GetCurrentColumnValue("NTIUT_KEY")
            Dim ParentID As Integer = INCOME_NTUREALFET.GetCurrentColumnValue("NTIUT_NTIUTKEY")
            Dim SourceNo As Integer = INCOME_NTUREALFET.GetCurrentColumnValue("NTIUT_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_INCOME_NTUREALFET.Visible = Me.GetVisibility_INCOME_NTUREALFET(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_INCOME_NTUREALFET_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_INCOME_NTUREALFET.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NTUREALFET.GetCurrentColumnValue("NTIUT_KEY")
            Dim ParentID As Integer = INCOME_NTUREALFET.GetCurrentColumnValue("NTIUT_NTIUTKEY")
            Dim SourceNo As Integer = INCOME_NTUREALFET.GetCurrentColumnValue("NTIUT_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_INCOME_NTUREALFET(PL_KEY, ParentID, SourceNo, LineStatus)
            line_INCOME_NTUREALFET.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_INCOME_NTUREALFET(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_INCOME_NTUREALFET_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_INCOME_NTUREALFET_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "INCOME_NTUREALFENT"
    Private Sub txtTotal_INCOME_NTUREALFENT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_INCOME_NTUREALFENT.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NTUREALFENT.GetCurrentColumnValue("NTIUNT_KEY")
            Dim countx As Integer = ADO.Load_INCOME_NTUREALFENT_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_INCOME_NTUREALFENT.Visible = False
                txtTotal_INCOME_NTUREALFENT.Visible = False
                lineTotal_INCOME_NTUREALFENT_top.Visible = False
                lineTotal_INCOME_NTUREALFENT_bot.Visible = False
            Else
                Dim ParentID As Integer = INCOME_NTUREALFENT.GetCurrentColumnValue("NTIUNT_NTIUNTKEY")
                Dim SourceNo As Integer = INCOME_NTUREALFENT.GetCurrentColumnValue("NTIUNT_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_INCOME_NTUREALFENT_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_INCOME_NTUREALFENT.Visible = True
                    lineTotal_INCOME_NTUREALFENT_top.Visible = True
                    lineTotal_INCOME_NTUREALFENT_bot.Visible = True
                Else
                    txtTotal_INCOME_NTUREALFENT.Visible = False
                    lineTotal_INCOME_NTUREALFENT_top.Visible = False
                    lineTotal_INCOME_NTUREALFENT_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_INCOME_NTUREALFENT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_INCOME_NTUREALFENT.BeforePrint

        Try
            Dim PL_KEY As Integer = INCOME_NTUREALFENT.GetCurrentColumnValue("NTIUNT_KEY")
            Dim ParentID As Integer = INCOME_NTUREALFENT.GetCurrentColumnValue("NTIUNT_NTIUNTKEY")
            Dim SourceNo As Integer = INCOME_NTUREALFENT.GetCurrentColumnValue("NTIUNT_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_INCOME_NTUREALFENT.Visible = Me.GetVisibility_INCOME_NTUREALFENT(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_INCOME_NTUREALFENT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_INCOME_NTUREALFENT.BeforePrint
        Try
            Dim PL_KEY As Integer = INCOME_NTUREALFENT.GetCurrentColumnValue("NTIUNT_KEY")
            Dim ParentID As Integer = INCOME_NTUREALFENT.GetCurrentColumnValue("NTIUNT_NTIUNTKEY")
            Dim SourceNo As Integer = INCOME_NTUREALFENT.GetCurrentColumnValue("NTIUNT_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_INCOME_NTUREALFENT(PL_KEY, ParentID, SourceNo, LineStatus)
            line_INCOME_NTUREALFENT.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_INCOME_NTUREALFENT(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_INCOME_NTUREALFENT_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_INCOME_NTUREALFENT_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "NON_TAXABLE_INCOME"
    Private Sub txtTotal_NON_TAXABLE_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_NON_TAXABLE_INCOME.BeforePrint
        Try
            Dim PL_KEY As Integer = NON_TAXABLE_INCOME.GetCurrentColumnValue("NT_KEY")
            Dim countx As Integer = ADO.Load_NON_TAXABLE_INCOME_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_NON_TAXABLE_INCOME.Visible = False
                txtTotal_NON_TAXABLE_INCOME.Visible = False
                lineTotal_NON_TAXABLE_INCOME_top.Visible = False
                lineTotal_NON_TAXABLE_INCOME_bot.Visible = False
            Else
                Dim ParentID As Integer = NON_TAXABLE_INCOME.GetCurrentColumnValue("NT_NTKEY")
                Dim SourceNo As Integer = NON_TAXABLE_INCOME.GetCurrentColumnValue("NT_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_NON_TAXABLE_INCOME_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_NON_TAXABLE_INCOME.Visible = True
                    lineTotal_NON_TAXABLE_INCOME_top.Visible = True
                    lineTotal_NON_TAXABLE_INCOME_bot.Visible = True
                Else
                    txtTotal_NON_TAXABLE_INCOME.Visible = False
                    lineTotal_NON_TAXABLE_INCOME_top.Visible = False
                    lineTotal_NON_TAXABLE_INCOME_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_NON_TAXABLE_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_NON_TAXABLE_INCOME.BeforePrint

        Try
            Dim PL_KEY As Integer = NON_TAXABLE_INCOME.GetCurrentColumnValue("NT_KEY")
            Dim ParentID As Integer = NON_TAXABLE_INCOME.GetCurrentColumnValue("NT_NTKEY")
            Dim SourceNo As Integer = NON_TAXABLE_INCOME.GetCurrentColumnValue("NT_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_NON_TAXABLE_INCOME.Visible = Me.GetVisibility_NON_TAXABLE_INCOME(PL_KEY, ParentID, SourceNo, LineStatus)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_NON_TAXABLE_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_NON_TAXABLE_INCOME.BeforePrint
        Try
            Dim PL_KEY As Integer = NON_TAXABLE_INCOME.GetCurrentColumnValue("NT_KEY")
            Dim ParentID As Integer = NON_TAXABLE_INCOME.GetCurrentColumnValue("NT_NTKEY")
            Dim SourceNo As Integer = NON_TAXABLE_INCOME.GetCurrentColumnValue("NT_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_NON_TAXABLE_INCOME(PL_KEY, ParentID, SourceNo, LineStatus)
            line_NON_TAXABLE_INCOME.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_NON_TAXABLE_INCOME(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_NON_TAXABLE_INCOME_COUNT_SUBITEM(PL_KEY, ParentID)
            Dim count_Item As Integer = ADO.Load_NON_TAXABLE_INCOME_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
    '-------------------------------------------------------------------------------------------------------
    ' DEDUCTIBLE
    '-------------------------------------------------------------------------------------------------------
#Region "EXPENSES_DEPRECIATION"
    Private Sub txtTotal_EXPENSES_DEPRECIATION_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_DEPRECIATION.BeforePrint, perTotal_EXPENSES_DEPRECIATION.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_DEPRECIATION.GetCurrentColumnValue("EXDEP_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_DEPRECIATION_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_DEPRECIATION.Visible = False
                txtTotal_EXPENSES_DEPRECIATION.Visible = False
                perTotal_EXPENSES_DEPRECIATION.Visible = False
                lineTotal_EXPENSES_DEPRECIATION_top.Visible = False
                lineTotal_EXPENSES_DEPRECIATION_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_DEPRECIATION.GetCurrentColumnValue("EXDEP_EXDEPKEY")
                Dim SourceNo As Integer = EXPENSES_DEPRECIATION.GetCurrentColumnValue("EXDEP_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_DEPRECIATION_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_DEPRECIATION.Visible = True
                    perTotal_EXPENSES_DEPRECIATION.Visible = True
                    lineTotal_EXPENSES_DEPRECIATION_top.Visible = True
                    lineTotal_EXPENSES_DEPRECIATION_bot.Visible = True
                Else
                    txtTotal_EXPENSES_DEPRECIATION.Visible = False
                    perTotal_EXPENSES_DEPRECIATION.Visible = False
                    lineTotal_EXPENSES_DEPRECIATION_top.Visible = False
                    lineTotal_EXPENSES_DEPRECIATION_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_DEPRECIATION_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_DEPRECIATION.BeforePrint, per_EXPENSES_DEPRECIATION.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_DEPRECIATION.GetCurrentColumnValue("EXDEP_KEY")
            Dim ParentID As Integer = EXPENSES_DEPRECIATION.GetCurrentColumnValue("EXDEP_EXDEPKEY")
            Dim SourceNo As Integer = EXPENSES_DEPRECIATION.GetCurrentColumnValue("EXDEP_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_DEPRECIATION.Visible = Me.GetVisibility_EXPENSES_DEPRECIATION(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_DEPRECIATION.Visible = txt_EXPENSES_DEPRECIATION.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_DEPRECIATION_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_DEPRECIATION.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_DEPRECIATION.GetCurrentColumnValue("EXDEP_KEY")
            Dim ParentID As Integer = EXPENSES_DEPRECIATION.GetCurrentColumnValue("EXDEP_EXDEPKEY")
            Dim SourceNo As Integer = EXPENSES_DEPRECIATION.GetCurrentColumnValue("EXDEP_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_DEPRECIATION(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_DEPRECIATION.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_DEPRECIATION(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_DEPRECIATION_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_DEPRECIATION_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_ALLOW"
    Private Sub txtTotal_EXPENSES_ALLOW_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_ALLOW.BeforePrint, perTotal_EXPENSES_ALLOW.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_ALLOW.GetCurrentColumnValue("EXA_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_ALLOW_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_ALLOW.Visible = False
                txtTotal_EXPENSES_ALLOW.Visible = False
                perTotal_EXPENSES_ALLOW.Visible = False
                lineTotal_EXPENSES_ALLOW_top.Visible = False
                lineTotal_EXPENSES_ALLOW_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_ALLOW.GetCurrentColumnValue("EXA_EXAKEY")
                Dim SourceNo As Integer = EXPENSES_ALLOW.GetCurrentColumnValue("EXA_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_ALLOW_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_ALLOW.Visible = True
                    perTotal_EXPENSES_ALLOW.Visible = True
                    lineTotal_EXPENSES_ALLOW_top.Visible = True
                    lineTotal_EXPENSES_ALLOW_bot.Visible = True
                Else
                    txtTotal_EXPENSES_ALLOW.Visible = False
                    perTotal_EXPENSES_ALLOW.Visible = False
                    lineTotal_EXPENSES_ALLOW_top.Visible = False
                    lineTotal_EXPENSES_ALLOW_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_ALLOW_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_ALLOW.BeforePrint, per_EXPENSES_ALLOW.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_ALLOW.GetCurrentColumnValue("EXA_KEY")
            Dim ParentID As Integer = EXPENSES_ALLOW.GetCurrentColumnValue("EXA_EXAKEY")
            Dim SourceNo As Integer = EXPENSES_ALLOW.GetCurrentColumnValue("EXA_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_ALLOW.Visible = Me.GetVisibility_EXPENSES_ALLOW(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_ALLOW.Visible = txt_EXPENSES_ALLOW.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_ALLOW_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_ALLOW.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_ALLOW.GetCurrentColumnValue("EXA_KEY")
            Dim ParentID As Integer = EXPENSES_ALLOW.GetCurrentColumnValue("EXA_EXAKEY")
            Dim SourceNo As Integer = EXPENSES_ALLOW.GetCurrentColumnValue("EXA_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_ALLOW(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_ALLOW.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_ALLOW(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_ALLOW_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_ALLOW_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_NONALLOW"
    Private Sub txtTotal_EXPENSES_NONALLOW_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_NONALLOW.BeforePrint, perTotal_EXPENSES_NONALLOW.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_NONALLOW.GetCurrentColumnValue("EXNA_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_NONALLOW_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_NONALLOW.Visible = False
                txtTotal_EXPENSES_NONALLOW.Visible = False
                perTotal_EXPENSES_NONALLOW.Visible = False
                lineTotal_EXPENSES_NONALLOW_top.Visible = False
                lineTotal_EXPENSES_NONALLOW_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_NONALLOW.GetCurrentColumnValue("EXNA_EXNAKEY")
                Dim SourceNo As Integer = EXPENSES_NONALLOW.GetCurrentColumnValue("EXNA_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_NONALLOW_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_NONALLOW.Visible = True
                    perTotal_EXPENSES_NONALLOW.Visible = True
                    lineTotal_EXPENSES_NONALLOW_top.Visible = True
                    lineTotal_EXPENSES_NONALLOW_bot.Visible = True
                Else
                    txtTotal_EXPENSES_NONALLOW.Visible = False
                    perTotal_EXPENSES_NONALLOW.Visible = False
                    lineTotal_EXPENSES_NONALLOW_top.Visible = False
                    lineTotal_EXPENSES_NONALLOW_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_NONALLOW_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_NONALLOW.BeforePrint, per_EXPENSES_NONALLOW.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_NONALLOW.GetCurrentColumnValue("EXNA_KEY")
            Dim ParentID As Integer = EXPENSES_NONALLOW.GetCurrentColumnValue("EXNA_EXNAKEY")
            Dim SourceNo As Integer = EXPENSES_NONALLOW.GetCurrentColumnValue("EXNA_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_NONALLOW.Visible = Me.GetVisibility_EXPENSES_NONALLOW(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_NONALLOW.Visible = txt_EXPENSES_NONALLOW.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_NONALLOW_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_NONALLOW.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_NONALLOW.GetCurrentColumnValue("EXNA_KEY")
            Dim ParentID As Integer = EXPENSES_NONALLOW.GetCurrentColumnValue("EXNA_EXNAKEY")
            Dim SourceNo As Integer = EXPENSES_NONALLOW.GetCurrentColumnValue("EXNA_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_NONALLOW(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_NONALLOW.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_NONALLOW(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_NONALLOW_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_NONALLOW_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
    '#Region "EXPENSES_INTERESTRESTRICT"
    '    Private Sub txtTotal_EXPENSES_INTERESTRESTRICT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_INTERESTRESTRICT.BeforePrint, perTotal_EXPENSES_INTERESTRESTRICT.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = EXPENSES_INTERESTRESTRICT.GetCurrentColumnValue("EXIR_KEY")
    '            Dim countx As Integer = ADO.Load_EXPENSES_INTERESTRESTRICT_TOTAL_SOURCENO(PL_KEY)

    '            If countx <= 1 Then
    '                ' GF_EXPENSES_INTERESTRESTRICT.Visible = False
    '                txtTotal_EXPENSES_INTERESTRESTRICT.Visible = False
    '                perTotal_EXPENSES_INTERESTRESTRICT.Visible = False
    '                lineTotal_EXPENSES_INTERESTRESTRICT_top.Visible = False
    '                lineTotal_EXPENSES_INTERESTRESTRICT_bot.Visible = False
    '            Else
    '                Dim ParentID As Integer = EXPENSES_INTERESTRESTRICT.GetCurrentColumnValue("EXIR_EXIRKEY")
    '                Dim SourceNo As Integer = EXPENSES_INTERESTRESTRICT.GetCurrentColumnValue("EXIR_SOURCENO")
    '                Dim countx_Item As Integer = ADO.Load_EXPENSES_INTERESTRESTRICT_COUNT(PL_KEY, SourceNo)
    '                If countx_Item > 1 Then
    '                    txtTotal_EXPENSES_INTERESTRESTRICT.Visible = True
    '                    perTotal_EXPENSES_INTERESTRESTRICT.Visible = True
    '                    lineTotal_EXPENSES_INTERESTRESTRICT_top.Visible = True
    '                    lineTotal_EXPENSES_INTERESTRESTRICT_bot.Visible = True
    '                Else
    '                    txtTotal_EXPENSES_INTERESTRESTRICT.Visible = False
    '                    perTotal_EXPENSES_INTERESTRESTRICT.Visible = False
    '                    lineTotal_EXPENSES_INTERESTRESTRICT_top.Visible = False
    '                    lineTotal_EXPENSES_INTERESTRESTRICT_bot.Visible = False
    '                End If

    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub txt_EXPENSES_INTERESTRESTRICT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_INTERESTRESTRICT.BeforePrint, per_EXPENSES_INTERESTRESTRICT.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = EXPENSES_INTERESTRESTRICT.GetCurrentColumnValue("EXIR_KEY")
    '            Dim ParentID As Integer = EXPENSES_INTERESTRESTRICT.GetCurrentColumnValue("EXIR_EXIRKEY")
    '            Dim SourceNo As Integer = EXPENSES_INTERESTRESTRICT.GetCurrentColumnValue("EXIR_SOURCENO")
    '            Dim LineStatus As Boolean = False
    '            txt_EXPENSES_INTERESTRESTRICT.Visible = Me.GetVisibility_EXPENSES_INTERESTRESTRICT(PL_KEY, ParentID, SourceNo, LineStatus)
    '            Application.DoEvents()
    '            per_EXPENSES_INTERESTRESTRICT.Visible = txt_EXPENSES_INTERESTRESTRICT.Visible

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub line_EXPENSES_INTERESTRESTRICT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_INTERESTRESTRICT.BeforePrint
    '        Try
    '            Dim PL_KEY As Integer = EXPENSES_INTERESTRESTRICT.GetCurrentColumnValue("EXIR_KEY")
    '            Dim ParentID As Integer = EXPENSES_INTERESTRESTRICT.GetCurrentColumnValue("EXIR_EXIRKEY")
    '            Dim SourceNo As Integer = EXPENSES_INTERESTRESTRICT.GetCurrentColumnValue("EXIR_SOURCENO")
    '            Dim LineStatus As Boolean = False
    '            Me.GetVisibility_EXPENSES_INTERESTRESTRICT(PL_KEY, ParentID, SourceNo, LineStatus)
    '            line_EXPENSES_INTERESTRESTRICT.Visible = LineStatus
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Function GetVisibility_EXPENSES_INTERESTRESTRICT(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
    '        Try

    '            Dim countx_subItem As Integer = ADO.Load_EXPENSES_INTERESTRESTRICT_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
    '            Dim count_Item As Integer = ADO.Load_EXPENSES_INTERESTRESTRICT_COUNT(PL_KEY, SourceNo)

    '            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
    '                LineStatus = True
    '                Return True
    '            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
    '                LineStatus = False
    '                Return True
    '            Else
    '                LineStatus = False
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            Return False
    '        End Try
    '    End Function
    '#End Region
#Region "EXPENSES_INTEREST"
    Private Sub txtTotal_EXPENSES_INTEREST_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_INTEREST.BeforePrint, perTotal_EXPENSES_INTEREST.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_INTEREST.GetCurrentColumnValue("EXI_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_INTEREST_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_INTEREST.Visible = False
                txtTotal_EXPENSES_INTEREST.Visible = False
                perTotal_EXPENSES_INTEREST.Visible = False
                lineTotal_EXPENSES_INTEREST_top.Visible = False
                lineTotal_EXPENSES_INTEREST_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_INTEREST.GetCurrentColumnValue("EXI_EXIKEY")
                Dim SourceNo As Integer = EXPENSES_INTEREST.GetCurrentColumnValue("EXI_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_INTEREST_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_INTEREST.Visible = True
                    perTotal_EXPENSES_INTEREST.Visible = True
                    lineTotal_EXPENSES_INTEREST_top.Visible = True
                    lineTotal_EXPENSES_INTEREST_bot.Visible = True
                Else
                    txtTotal_EXPENSES_INTEREST.Visible = False
                    perTotal_EXPENSES_INTEREST.Visible = False
                    lineTotal_EXPENSES_INTEREST_top.Visible = False
                    lineTotal_EXPENSES_INTEREST_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_INTEREST_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_INTEREST.BeforePrint, per_EXPENSES_INTEREST.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_INTEREST.GetCurrentColumnValue("EXI_KEY")
            Dim ParentID As Integer = EXPENSES_INTEREST.GetCurrentColumnValue("EXI_EXIKEY")
            Dim SourceNo As Integer = EXPENSES_INTEREST.GetCurrentColumnValue("EXI_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_INTEREST.Visible = Me.GetVisibility_EXPENSES_INTEREST(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_INTEREST.Visible = txt_EXPENSES_INTEREST.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_INTEREST_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_INTEREST.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_INTEREST.GetCurrentColumnValue("EXI_KEY")
            Dim ParentID As Integer = EXPENSES_INTEREST.GetCurrentColumnValue("EXI_EXIKEY")
            Dim SourceNo As Integer = EXPENSES_INTEREST.GetCurrentColumnValue("EXI_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_INTEREST(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_INTEREST.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_INTEREST(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_INTEREST_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_INTEREST_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_LEGAL"
    Private Sub txtTotal_EXPENSES_LEGAL_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_LEGAL.BeforePrint, perTotal_EXPENSES_LEGAL.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_LEGAL.GetCurrentColumnValue("EXL_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_LEGAL_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_LEGAL.Visible = False
                txtTotal_EXPENSES_LEGAL.Visible = False
                perTotal_EXPENSES_LEGAL.Visible = False
                lineTotal_EXPENSES_LEGAL_top.Visible = False
                lineTotal_EXPENSES_LEGAL_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_LEGAL.GetCurrentColumnValue("EXL_EXLKEY")
                Dim SourceNo As Integer = EXPENSES_LEGAL.GetCurrentColumnValue("EXL_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_LEGAL_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_LEGAL.Visible = True
                    perTotal_EXPENSES_LEGAL.Visible = True
                    lineTotal_EXPENSES_LEGAL_top.Visible = True
                    lineTotal_EXPENSES_LEGAL_bot.Visible = True
                Else
                    txtTotal_EXPENSES_LEGAL.Visible = False
                    perTotal_EXPENSES_LEGAL.Visible = False
                    lineTotal_EXPENSES_LEGAL_top.Visible = False
                    lineTotal_EXPENSES_LEGAL_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_LEGAL_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_LEGAL.BeforePrint, per_EXPENSES_LEGAL.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_LEGAL.GetCurrentColumnValue("EXL_KEY")
            Dim ParentID As Integer = EXPENSES_LEGAL.GetCurrentColumnValue("EXL_EXLKEY")
            Dim SourceNo As Integer = EXPENSES_LEGAL.GetCurrentColumnValue("EXL_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_LEGAL.Visible = Me.GetVisibility_EXPENSES_LEGAL(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_LEGAL.Visible = txt_EXPENSES_LEGAL.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_LEGAL_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_LEGAL.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_LEGAL.GetCurrentColumnValue("EXL_KEY")
            Dim ParentID As Integer = EXPENSES_LEGAL.GetCurrentColumnValue("EXL_EXLKEY")
            Dim SourceNo As Integer = EXPENSES_LEGAL.GetCurrentColumnValue("EXL_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_LEGAL(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_LEGAL.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_LEGAL(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_LEGAL_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_LEGAL_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_TECH_FEE"
    Private Sub txtTotal_EXPENSES_TECH_FEE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_TECH_FEE.BeforePrint, perTotal_EXPENSES_TECH_FEE.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_TECH_FEE.GetCurrentColumnValue("EXTF_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_TECH_FEE_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_TECH_FEE.Visible = False
                txtTotal_EXPENSES_TECH_FEE.Visible = False
                perTotal_EXPENSES_TECH_FEE.Visible = False
                lineTotal_EXPENSES_TECH_FEE_top.Visible = False
                lineTotal_EXPENSES_TECH_FEE_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_TECH_FEE.GetCurrentColumnValue("EXTF_EXTFKEY")
                Dim SourceNo As Integer = EXPENSES_TECH_FEE.GetCurrentColumnValue("EXTF_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_TECH_FEE_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_TECH_FEE.Visible = True
                    perTotal_EXPENSES_TECH_FEE.Visible = True
                    lineTotal_EXPENSES_TECH_FEE_top.Visible = True
                    lineTotal_EXPENSES_TECH_FEE_bot.Visible = True
                Else
                    txtTotal_EXPENSES_TECH_FEE.Visible = False
                    perTotal_EXPENSES_TECH_FEE.Visible = False
                    lineTotal_EXPENSES_TECH_FEE_top.Visible = False
                    lineTotal_EXPENSES_TECH_FEE_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_TECH_FEE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_TECH_FEE.BeforePrint, per_EXPENSES_TECH_FEE.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_TECH_FEE.GetCurrentColumnValue("EXTF_KEY")
            Dim ParentID As Integer = EXPENSES_TECH_FEE.GetCurrentColumnValue("EXTF_EXTFKEY")
            Dim SourceNo As Integer = EXPENSES_TECH_FEE.GetCurrentColumnValue("EXTF_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_TECH_FEE.Visible = Me.GetVisibility_EXPENSES_TECH_FEE(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_TECH_FEE.Visible = txt_EXPENSES_TECH_FEE.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_TECH_FEE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_TECH_FEE.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_TECH_FEE.GetCurrentColumnValue("EXTF_KEY")
            Dim ParentID As Integer = EXPENSES_TECH_FEE.GetCurrentColumnValue("EXTF_EXTFKEY")
            Dim SourceNo As Integer = EXPENSES_TECH_FEE.GetCurrentColumnValue("EXTF_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_TECH_FEE(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_TECH_FEE.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_TECH_FEE(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_TECH_FEE_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_TECH_FEE_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_CONTRACT"
    Private Sub txtTotal_EXPENSES_CONTRACT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_CONTRACT.BeforePrint, perTotal_EXPENSES_CONTRACT.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_CONTRACT.GetCurrentColumnValue("EXC_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_CONTRACT_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_CONTRACT.Visible = False
                txtTotal_EXPENSES_CONTRACT.Visible = False
                perTotal_EXPENSES_CONTRACT.Visible = False
                lineTotal_EXPENSES_CONTRACT_top.Visible = False
                lineTotal_EXPENSES_CONTRACT_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_CONTRACT.GetCurrentColumnValue("EXC_EXCKEY")
                Dim SourceNo As Integer = EXPENSES_CONTRACT.GetCurrentColumnValue("EXC_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_CONTRACT_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_CONTRACT.Visible = True
                    perTotal_EXPENSES_CONTRACT.Visible = True
                    lineTotal_EXPENSES_CONTRACT_top.Visible = True
                    lineTotal_EXPENSES_CONTRACT_bot.Visible = True
                Else
                    txtTotal_EXPENSES_CONTRACT.Visible = False
                    perTotal_EXPENSES_CONTRACT.Visible = False
                    lineTotal_EXPENSES_CONTRACT_top.Visible = False
                    lineTotal_EXPENSES_CONTRACT_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_CONTRACT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_CONTRACT.BeforePrint, per_EXPENSES_CONTRACT.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_CONTRACT.GetCurrentColumnValue("EXC_KEY")
            Dim ParentID As Integer = EXPENSES_CONTRACT.GetCurrentColumnValue("EXC_EXCKEY")
            Dim SourceNo As Integer = EXPENSES_CONTRACT.GetCurrentColumnValue("EXC_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_CONTRACT.Visible = Me.GetVisibility_EXPENSES_CONTRACT(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_CONTRACT.Visible = txt_EXPENSES_CONTRACT.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_CONTRACT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_CONTRACT.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_CONTRACT.GetCurrentColumnValue("EXC_KEY")
            Dim ParentID As Integer = EXPENSES_CONTRACT.GetCurrentColumnValue("EXC_EXCKEY")
            Dim SourceNo As Integer = EXPENSES_CONTRACT.GetCurrentColumnValue("EXC_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_CONTRACT(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_CONTRACT.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_CONTRACT(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_CONTRACT_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_CONTRACT_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_DIRECTORS_FEE"
    Private Sub txtTotal_EXPENSES_DIRECTORS_FEE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_DIRECTORS_FEE.BeforePrint, perTotal_EXPENSES_DIRECTORS_FEE.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_DIRECTORS_FEE.GetCurrentColumnValue("EXDF_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_DIRECTORS_FEE_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_DIRECTORS_FEE.Visible = False
                txtTotal_EXPENSES_DIRECTORS_FEE.Visible = False
                perTotal_EXPENSES_DIRECTORS_FEE.Visible = False
                lineTotal_EXPENSES_DIRECTORS_FEE_top.Visible = False
                lineTotal_EXPENSES_DIRECTORS_FEE_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_DIRECTORS_FEE.GetCurrentColumnValue("EXDF_EXDFKEY")
                Dim SourceNo As Integer = EXPENSES_DIRECTORS_FEE.GetCurrentColumnValue("EXDF_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_DIRECTORS_FEE_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_DIRECTORS_FEE.Visible = True
                    perTotal_EXPENSES_DIRECTORS_FEE.Visible = True
                    lineTotal_EXPENSES_DIRECTORS_FEE_top.Visible = True
                    lineTotal_EXPENSES_DIRECTORS_FEE_bot.Visible = True
                Else
                    txtTotal_EXPENSES_DIRECTORS_FEE.Visible = False
                    perTotal_EXPENSES_DIRECTORS_FEE.Visible = False
                    lineTotal_EXPENSES_DIRECTORS_FEE_top.Visible = False
                    lineTotal_EXPENSES_DIRECTORS_FEE_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_DIRECTORS_FEE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_DIRECTORS_FEE.BeforePrint, per_EXPENSES_DIRECTORS_FEE.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_DIRECTORS_FEE.GetCurrentColumnValue("EXDF_KEY")
            Dim ParentID As Integer = EXPENSES_DIRECTORS_FEE.GetCurrentColumnValue("EXDF_EXDFKEY")
            Dim SourceNo As Integer = EXPENSES_DIRECTORS_FEE.GetCurrentColumnValue("EXDF_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_DIRECTORS_FEE.Visible = Me.GetVisibility_EXPENSES_DIRECTORS_FEE(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_DIRECTORS_FEE.Visible = txt_EXPENSES_DIRECTORS_FEE.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_DIRECTORS_FEE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_DIRECTORS_FEE.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_DIRECTORS_FEE.GetCurrentColumnValue("EXDF_KEY")
            Dim ParentID As Integer = EXPENSES_DIRECTORS_FEE.GetCurrentColumnValue("EXDF_EXDFKEY")
            Dim SourceNo As Integer = EXPENSES_DIRECTORS_FEE.GetCurrentColumnValue("EXDF_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_DIRECTORS_FEE(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_DIRECTORS_FEE.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_DIRECTORS_FEE(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_DIRECTORS_FEE_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_DIRECTORS_FEE_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_SALARY"
    Private Sub txtTotal_EXPENSES_SALARY_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_SALARY.BeforePrint, perTotal_EXPENSES_SALARY.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_SALARY.GetCurrentColumnValue("EXS_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_SALARY_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_SALARY.Visible = False
                txtTotal_EXPENSES_SALARY.Visible = False
                perTotal_EXPENSES_SALARY.Visible = False
                lineTotal_EXPENSES_SALARY_top.Visible = False
                lineTotal_EXPENSES_SALARY_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_SALARY.GetCurrentColumnValue("EXS_EXSKEY")
                Dim SourceNo As Integer = EXPENSES_SALARY.GetCurrentColumnValue("EXS_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_SALARY_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_SALARY.Visible = True
                    perTotal_EXPENSES_SALARY.Visible = True
                    lineTotal_EXPENSES_SALARY_top.Visible = True
                    lineTotal_EXPENSES_SALARY_bot.Visible = True
                Else
                    txtTotal_EXPENSES_SALARY.Visible = False
                    perTotal_EXPENSES_SALARY.Visible = False
                    lineTotal_EXPENSES_SALARY_top.Visible = False
                    lineTotal_EXPENSES_SALARY_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_SALARY_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_SALARY.BeforePrint, per_EXPENSES_SALARY.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_SALARY.GetCurrentColumnValue("EXS_KEY")
            Dim ParentID As Integer = EXPENSES_SALARY.GetCurrentColumnValue("EXS_EXSKEY")
            Dim SourceNo As Integer = EXPENSES_SALARY.GetCurrentColumnValue("EXS_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_SALARY.Visible = Me.GetVisibility_EXPENSES_SALARY(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_SALARY.Visible = txt_EXPENSES_SALARY.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_SALARY_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_SALARY.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_SALARY.GetCurrentColumnValue("EXS_KEY")
            Dim ParentID As Integer = EXPENSES_SALARY.GetCurrentColumnValue("EXS_EXSKEY")
            Dim SourceNo As Integer = EXPENSES_SALARY.GetCurrentColumnValue("EXS_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_SALARY(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_SALARY.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_SALARY(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_SALARY_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_SALARY_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_EMPL_STOCK"
    Private Sub txtTotal_EXPENSES_EMPL_STOCK_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_EMPL_STOCK.BeforePrint, perTotal_EXPENSES_EMPL_STOCK.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_EMPL_STOCK.GetCurrentColumnValue("EXES_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_EMPL_STOCK_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_EMPL_STOCK.Visible = False
                txtTotal_EXPENSES_EMPL_STOCK.Visible = False
                perTotal_EXPENSES_EMPL_STOCK.Visible = False
                lineTotal_EXPENSES_EMPL_STOCK_top.Visible = False
                lineTotal_EXPENSES_EMPL_STOCK_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_EMPL_STOCK.GetCurrentColumnValue("EXES_EXESKEY")
                Dim SourceNo As Integer = EXPENSES_EMPL_STOCK.GetCurrentColumnValue("EXES_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_EMPL_STOCK_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_EMPL_STOCK.Visible = True
                    perTotal_EXPENSES_EMPL_STOCK.Visible = True
                    lineTotal_EXPENSES_EMPL_STOCK_top.Visible = True
                    lineTotal_EXPENSES_EMPL_STOCK_bot.Visible = True
                Else
                    txtTotal_EXPENSES_EMPL_STOCK.Visible = False
                    perTotal_EXPENSES_EMPL_STOCK.Visible = False
                    lineTotal_EXPENSES_EMPL_STOCK_top.Visible = False
                    lineTotal_EXPENSES_EMPL_STOCK_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_EMPL_STOCK_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_EMPL_STOCK.BeforePrint, per_EXPENSES_EMPL_STOCK.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_EMPL_STOCK.GetCurrentColumnValue("EXES_KEY")
            Dim ParentID As Integer = EXPENSES_EMPL_STOCK.GetCurrentColumnValue("EXES_EXESKEY")
            Dim SourceNo As Integer = EXPENSES_EMPL_STOCK.GetCurrentColumnValue("EXES_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_EMPL_STOCK.Visible = Me.GetVisibility_EXPENSES_EMPL_STOCK(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_EMPL_STOCK.Visible = txt_EXPENSES_EMPL_STOCK.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_EMPL_STOCK_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_EMPL_STOCK.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_EMPL_STOCK.GetCurrentColumnValue("EXES_KEY")
            Dim ParentID As Integer = EXPENSES_EMPL_STOCK.GetCurrentColumnValue("EXES_EXESKEY")
            Dim SourceNo As Integer = EXPENSES_EMPL_STOCK.GetCurrentColumnValue("EXES_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_EMPL_STOCK(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_EMPL_STOCK.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_EMPL_STOCK(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_EMPL_STOCK_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_EMPL_STOCK_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_ROYALTY"
    Private Sub txtTotal_EXPENSES_ROYALTY_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_ROYALTY.BeforePrint, perTotal_EXPENSES_ROYALTY.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_ROYALTY.GetCurrentColumnValue("EXRO_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_ROYALTY_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_ROYALTY.Visible = False
                txtTotal_EXPENSES_ROYALTY.Visible = False
                perTotal_EXPENSES_ROYALTY.Visible = False
                lineTotal_EXPENSES_ROYALTY_top.Visible = False
                lineTotal_EXPENSES_ROYALTY_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_ROYALTY.GetCurrentColumnValue("EXRO_EXROKEY")
                Dim SourceNo As Integer = EXPENSES_ROYALTY.GetCurrentColumnValue("EXRO_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_ROYALTY_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_ROYALTY.Visible = True
                    perTotal_EXPENSES_ROYALTY.Visible = True
                    lineTotal_EXPENSES_ROYALTY_top.Visible = True
                    lineTotal_EXPENSES_ROYALTY_bot.Visible = True
                Else
                    txtTotal_EXPENSES_ROYALTY.Visible = False
                    perTotal_EXPENSES_ROYALTY.Visible = False
                    lineTotal_EXPENSES_ROYALTY_top.Visible = False
                    lineTotal_EXPENSES_ROYALTY_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_ROYALTY_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_ROYALTY.BeforePrint, per_EXPENSES_ROYALTY.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_ROYALTY.GetCurrentColumnValue("EXRO_KEY")
            Dim ParentID As Integer = EXPENSES_ROYALTY.GetCurrentColumnValue("EXRO_EXROKEY")
            Dim SourceNo As Integer = EXPENSES_ROYALTY.GetCurrentColumnValue("EXRO_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_ROYALTY.Visible = Me.GetVisibility_EXPENSES_ROYALTY(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_ROYALTY.Visible = txt_EXPENSES_ROYALTY.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_ROYALTY_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_ROYALTY.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_ROYALTY.GetCurrentColumnValue("EXRO_KEY")
            Dim ParentID As Integer = EXPENSES_ROYALTY.GetCurrentColumnValue("EXRO_EXROKEY")
            Dim SourceNo As Integer = EXPENSES_ROYALTY.GetCurrentColumnValue("EXRO_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_ROYALTY(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_ROYALTY.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_ROYALTY(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_ROYALTY_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_ROYALTY_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_RENTAL"
    Private Sub txtTotal_EXPENSES_RENTAL_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_RENTAL.BeforePrint, perTotal_EXPENSES_RENTAL.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_RENTAL.GetCurrentColumnValue("EXRENT_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_RENTAL_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_RENTAL.Visible = False
                txtTotal_EXPENSES_RENTAL.Visible = False
                perTotal_EXPENSES_RENTAL.Visible = False
                lineTotal_EXPENSES_RENTAL_top.Visible = False
                lineTotal_EXPENSES_RENTAL_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_RENTAL.GetCurrentColumnValue("EXRENT_EXRENTKEY")
                Dim SourceNo As Integer = EXPENSES_RENTAL.GetCurrentColumnValue("EXRENT_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_RENTAL_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_RENTAL.Visible = True
                    perTotal_EXPENSES_RENTAL.Visible = True
                    lineTotal_EXPENSES_RENTAL_top.Visible = True
                    lineTotal_EXPENSES_RENTAL_bot.Visible = True
                Else
                    txtTotal_EXPENSES_RENTAL.Visible = False
                    perTotal_EXPENSES_RENTAL.Visible = False
                    lineTotal_EXPENSES_RENTAL_top.Visible = False
                    lineTotal_EXPENSES_RENTAL_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_RENTAL_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_RENTAL.BeforePrint, per_EXPENSES_RENTAL.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_RENTAL.GetCurrentColumnValue("EXRENT_KEY")
            Dim ParentID As Integer = EXPENSES_RENTAL.GetCurrentColumnValue("EXRENT_EXRENTKEY")
            Dim SourceNo As Integer = EXPENSES_RENTAL.GetCurrentColumnValue("EXRENT_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_RENTAL.Visible = Me.GetVisibility_EXPENSES_RENTAL(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_RENTAL.Visible = txt_EXPENSES_RENTAL.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_RENTAL_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_RENTAL.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_RENTAL.GetCurrentColumnValue("EXRENT_KEY")
            Dim ParentID As Integer = EXPENSES_RENTAL.GetCurrentColumnValue("EXRENT_EXRENTKEY")
            Dim SourceNo As Integer = EXPENSES_RENTAL.GetCurrentColumnValue("EXRENT_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_RENTAL(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_RENTAL.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_RENTAL(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_RENTAL_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_RENTAL_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_REPAIR"
    Private Sub txtTotal_EXPENSES_REPAIR_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_REPAIR.BeforePrint, perTotal_EXPENSES_REPAIR.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_REPAIR.GetCurrentColumnValue("EXREP_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_REPAIR_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_REPAIR.Visible = False
                txtTotal_EXPENSES_REPAIR.Visible = False
                perTotal_EXPENSES_REPAIR.Visible = False
                lineTotal_EXPENSES_REPAIR_top.Visible = False
                lineTotal_EXPENSES_REPAIR_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_REPAIR.GetCurrentColumnValue("EXREP_EXREPKEY")
                Dim SourceNo As Integer = EXPENSES_REPAIR.GetCurrentColumnValue("EXREP_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_REPAIR_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_REPAIR.Visible = True
                    perTotal_EXPENSES_REPAIR.Visible = True
                    lineTotal_EXPENSES_REPAIR_top.Visible = True
                    lineTotal_EXPENSES_REPAIR_bot.Visible = True
                Else
                    txtTotal_EXPENSES_REPAIR.Visible = False
                    perTotal_EXPENSES_REPAIR.Visible = False
                    lineTotal_EXPENSES_REPAIR_top.Visible = False
                    lineTotal_EXPENSES_REPAIR_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_REPAIR_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_REPAIR.BeforePrint, per_EXPENSES_REPAIR.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_REPAIR.GetCurrentColumnValue("EXREP_KEY")
            Dim ParentID As Integer = EXPENSES_REPAIR.GetCurrentColumnValue("EXREP_EXREPKEY")
            Dim SourceNo As Integer = EXPENSES_REPAIR.GetCurrentColumnValue("EXREP_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_REPAIR.Visible = Me.GetVisibility_EXPENSES_REPAIR(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_REPAIR.Visible = txt_EXPENSES_REPAIR.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_REPAIR_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_REPAIR.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_REPAIR.GetCurrentColumnValue("EXREP_KEY")
            Dim ParentID As Integer = EXPENSES_REPAIR.GetCurrentColumnValue("EXREP_EXREPKEY")
            Dim SourceNo As Integer = EXPENSES_REPAIR.GetCurrentColumnValue("EXREP_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_REPAIR(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_REPAIR.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_REPAIR(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_REPAIR_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_REPAIR_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_RESEARCH"
    Private Sub txtTotal_EXPENSES_RESEARCH_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_RESEARCH.BeforePrint, perTotal_EXPENSES_RESEARCH.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_RESEARCH.GetCurrentColumnValue("EXRES_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_RESEARCH_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_RESEARCH.Visible = False
                txtTotal_EXPENSES_RESEARCH.Visible = False
                perTotal_EXPENSES_RESEARCH.Visible = False
                lineTotal_EXPENSES_RESEARCH_top.Visible = False
                lineTotal_EXPENSES_RESEARCH_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_RESEARCH.GetCurrentColumnValue("EXRES_EXRESKEY")
                Dim SourceNo As Integer = EXPENSES_RESEARCH.GetCurrentColumnValue("EXRES_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_RESEARCH_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_RESEARCH.Visible = True
                    perTotal_EXPENSES_RESEARCH.Visible = True
                    lineTotal_EXPENSES_RESEARCH_top.Visible = True
                    lineTotal_EXPENSES_RESEARCH_bot.Visible = True
                Else
                    txtTotal_EXPENSES_RESEARCH.Visible = False
                    perTotal_EXPENSES_RESEARCH.Visible = False
                    lineTotal_EXPENSES_RESEARCH_top.Visible = False
                    lineTotal_EXPENSES_RESEARCH_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_RESEARCH_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_RESEARCH.BeforePrint, per_EXPENSES_RESEARCH.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_RESEARCH.GetCurrentColumnValue("EXRES_KEY")
            Dim ParentID As Integer = EXPENSES_RESEARCH.GetCurrentColumnValue("EXRES_EXRESKEY")
            Dim SourceNo As Integer = EXPENSES_RESEARCH.GetCurrentColumnValue("EXRES_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_RESEARCH.Visible = Me.GetVisibility_EXPENSES_RESEARCH(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_RESEARCH.Visible = txt_EXPENSES_RESEARCH.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_RESEARCH_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_RESEARCH.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_RESEARCH.GetCurrentColumnValue("EXRES_KEY")
            Dim ParentID As Integer = EXPENSES_RESEARCH.GetCurrentColumnValue("EXRES_EXRESKEY")
            Dim SourceNo As Integer = EXPENSES_RESEARCH.GetCurrentColumnValue("EXRES_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_RESEARCH(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_RESEARCH.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_RESEARCH(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_RESEARCH_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_RESEARCH_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_PROMOTE"
    Private Sub txtTotal_EXPENSES_PROMOTE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_PROMOTE.BeforePrint, perTotal_EXPENSES_PROMOTE.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_PROMOTE.GetCurrentColumnValue("EXP_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_PROMOTE_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_PROMOTE.Visible = False
                txtTotal_EXPENSES_PROMOTE.Visible = False
                perTotal_EXPENSES_PROMOTE.Visible = False
                lineTotal_EXPENSES_PROMOTE_top.Visible = False
                lineTotal_EXPENSES_PROMOTE_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_PROMOTE.GetCurrentColumnValue("EXP_EXPKEY")
                Dim SourceNo As Integer = EXPENSES_PROMOTE.GetCurrentColumnValue("EXP_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_PROMOTE_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_PROMOTE.Visible = True
                    perTotal_EXPENSES_PROMOTE.Visible = True
                    lineTotal_EXPENSES_PROMOTE_top.Visible = True
                    lineTotal_EXPENSES_PROMOTE_bot.Visible = True
                Else
                    txtTotal_EXPENSES_PROMOTE.Visible = False
                    perTotal_EXPENSES_PROMOTE.Visible = False
                    lineTotal_EXPENSES_PROMOTE_top.Visible = False
                    lineTotal_EXPENSES_PROMOTE_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_PROMOTE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_PROMOTE.BeforePrint, per_EXPENSES_PROMOTE.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_PROMOTE.GetCurrentColumnValue("EXP_KEY")
            Dim ParentID As Integer = EXPENSES_PROMOTE.GetCurrentColumnValue("EXP_EXPKEY")
            Dim SourceNo As Integer = EXPENSES_PROMOTE.GetCurrentColumnValue("EXP_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_PROMOTE.Visible = Me.GetVisibility_EXPENSES_PROMOTE(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_PROMOTE.Visible = txt_EXPENSES_PROMOTE.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_PROMOTE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_PROMOTE.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_PROMOTE.GetCurrentColumnValue("EXP_KEY")
            Dim ParentID As Integer = EXPENSES_PROMOTE.GetCurrentColumnValue("EXP_EXPKEY")
            Dim SourceNo As Integer = EXPENSES_PROMOTE.GetCurrentColumnValue("EXP_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_PROMOTE(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_PROMOTE.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_PROMOTE(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_PROMOTE_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_PROMOTE_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_TRAVEL"
    Private Sub txtTotal_EXPENSES_TRAVEL_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_TRAVEL.BeforePrint, perTotal_EXPENSES_TRAVEL.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_TRAVEL.GetCurrentColumnValue("EXT_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_TRAVEL_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_TRAVEL.Visible = False
                txtTotal_EXPENSES_TRAVEL.Visible = False
                perTotal_EXPENSES_TRAVEL.Visible = False
                lineTotal_EXPENSES_TRAVEL_top.Visible = False
                lineTotal_EXPENSES_TRAVEL_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_TRAVEL.GetCurrentColumnValue("EXT_EXTKEY")
                Dim SourceNo As Integer = EXPENSES_TRAVEL.GetCurrentColumnValue("EXT_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_TRAVEL_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_TRAVEL.Visible = True
                    perTotal_EXPENSES_TRAVEL.Visible = True
                    lineTotal_EXPENSES_TRAVEL_top.Visible = True
                    lineTotal_EXPENSES_TRAVEL_bot.Visible = True
                Else
                    txtTotal_EXPENSES_TRAVEL.Visible = False
                    perTotal_EXPENSES_TRAVEL.Visible = False
                    lineTotal_EXPENSES_TRAVEL_top.Visible = False
                    lineTotal_EXPENSES_TRAVEL_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_TRAVEL_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_TRAVEL.BeforePrint, per_EXPENSES_TRAVEL.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_TRAVEL.GetCurrentColumnValue("EXT_KEY")
            Dim ParentID As Integer = EXPENSES_TRAVEL.GetCurrentColumnValue("EXT_EXTKEY")
            Dim SourceNo As Integer = EXPENSES_TRAVEL.GetCurrentColumnValue("EXT_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_TRAVEL.Visible = Me.GetVisibility_EXPENSES_TRAVEL(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_TRAVEL.Visible = txt_EXPENSES_TRAVEL.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_TRAVEL_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_TRAVEL.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_TRAVEL.GetCurrentColumnValue("EXT_KEY")
            Dim ParentID As Integer = EXPENSES_TRAVEL.GetCurrentColumnValue("EXT_EXTKEY")
            Dim SourceNo As Integer = EXPENSES_TRAVEL.GetCurrentColumnValue("EXT_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_TRAVEL(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_TRAVEL.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_TRAVEL(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_TRAVEL_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_TRAVEL_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "EXPENSES_JKDM"
    Private Sub txtTotal_EXPENSES_JKDM_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_EXPENSES_JKDM.BeforePrint, perTotal_EXPENSES_JKDM.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_JKDM.GetCurrentColumnValue("EXJK_KEY")
            Dim countx As Integer = ADO.Load_EXPENSES_JKDM_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_EXPENSES_JKDM.Visible = False
                txtTotal_EXPENSES_JKDM.Visible = False
                perTotal_EXPENSES_JKDM.Visible = False
                lineTotal_EXPENSES_JKDM_top.Visible = False
                lineTotal_EXPENSES_JKDM_bot.Visible = False
            Else
                Dim ParentID As Integer = EXPENSES_JKDM.GetCurrentColumnValue("EXJK_EXJKKEY")
                Dim SourceNo As Integer = EXPENSES_JKDM.GetCurrentColumnValue("EXJK_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_EXPENSES_JKDM_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_EXPENSES_JKDM.Visible = True
                    perTotal_EXPENSES_JKDM.Visible = True
                    lineTotal_EXPENSES_JKDM_top.Visible = True
                    lineTotal_EXPENSES_JKDM_bot.Visible = True
                Else
                    txtTotal_EXPENSES_JKDM.Visible = False
                    perTotal_EXPENSES_JKDM.Visible = False
                    lineTotal_EXPENSES_JKDM_top.Visible = False
                    lineTotal_EXPENSES_JKDM_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_EXPENSES_JKDM_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_EXPENSES_JKDM.BeforePrint, per_EXPENSES_JKDM.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_JKDM.GetCurrentColumnValue("EXJK_KEY")
            Dim ParentID As Integer = EXPENSES_JKDM.GetCurrentColumnValue("EXJK_EXJKKEY")
            Dim SourceNo As Integer = EXPENSES_JKDM.GetCurrentColumnValue("EXJK_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_EXPENSES_JKDM.Visible = Me.GetVisibility_EXPENSES_JKDM(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_EXPENSES_JKDM.Visible = txt_EXPENSES_JKDM.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_EXPENSES_JKDM_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_EXPENSES_JKDM.BeforePrint
        Try
            Dim PL_KEY As Integer = EXPENSES_JKDM.GetCurrentColumnValue("EXJK_KEY")
            Dim ParentID As Integer = EXPENSES_JKDM.GetCurrentColumnValue("EXJK_EXJKKEY")
            Dim SourceNo As Integer = EXPENSES_JKDM.GetCurrentColumnValue("EXJK_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_EXPENSES_JKDM(PL_KEY, ParentID, SourceNo, LineStatus)
            line_EXPENSES_JKDM.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_EXPENSES_JKDM(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_EXPENSES_JKDM_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_EXPENSES_JKDM_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXDEPRECIATION"
    Private Sub txtTotal_OTHER_EXDEPRECIATION_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXDEPRECIATION.BeforePrint, perTotal_OTHER_EXDEPRECIATION.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXDEPRECIATION.GetCurrentColumnValue("EXODEP_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXDEPRECIATION_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXDEPRECIATION.Visible = False
                txtTotal_OTHER_EXDEPRECIATION.Visible = False
                perTotal_OTHER_EXDEPRECIATION.Visible = False
                lineTotal_OTHER_EXDEPRECIATION_top.Visible = False
                lineTotal_OTHER_EXDEPRECIATION_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXDEPRECIATION.GetCurrentColumnValue("EXODEP_EXODEPKEY")
                Dim SourceNo As Integer = OTHER_EXDEPRECIATION.GetCurrentColumnValue("EXODEP_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXDEPRECIATION_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXDEPRECIATION.Visible = True
                    perTotal_OTHER_EXDEPRECIATION.Visible = True
                    lineTotal_OTHER_EXDEPRECIATION_top.Visible = True
                    lineTotal_OTHER_EXDEPRECIATION_bot.Visible = True
                Else
                    txtTotal_OTHER_EXDEPRECIATION.Visible = False
                    perTotal_OTHER_EXDEPRECIATION.Visible = False
                    lineTotal_OTHER_EXDEPRECIATION_top.Visible = False
                    lineTotal_OTHER_EXDEPRECIATION_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXDEPRECIATION_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXDEPRECIATION.BeforePrint, per_OTHER_EXDEPRECIATION.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXDEPRECIATION.GetCurrentColumnValue("EXODEP_KEY")
            Dim ParentID As Integer = OTHER_EXDEPRECIATION.GetCurrentColumnValue("EXODEP_EXODEPKEY")
            Dim SourceNo As Integer = OTHER_EXDEPRECIATION.GetCurrentColumnValue("EXODEP_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXDEPRECIATION.Visible = Me.GetVisibility_OTHER_EXDEPRECIATION(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXDEPRECIATION.Visible = txt_OTHER_EXDEPRECIATION.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXDEPRECIATION_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXDEPRECIATION.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXDEPRECIATION.GetCurrentColumnValue("EXODEP_KEY")
            Dim ParentID As Integer = OTHER_EXDEPRECIATION.GetCurrentColumnValue("EXODEP_EXODEPKEY")
            Dim SourceNo As Integer = OTHER_EXDEPRECIATION.GetCurrentColumnValue("EXODEP_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXDEPRECIATION(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXDEPRECIATION.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXDEPRECIATION(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXDEPRECIATION_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXDEPRECIATION_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXAPPRDONATION"
    Private Sub txtTotal_OTHER_EXAPPRDONATION_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXAPPRDONATION.BeforePrint, perTotal_OTHER_EXAPPRDONATION.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXAPPRDONATION.GetCurrentColumnValue("EXOAD_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXAPPRDONATION_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXAPPRDONATION.Visible = False
                txtTotal_OTHER_EXAPPRDONATION.Visible = False
                perTotal_OTHER_EXAPPRDONATION.Visible = False
                lineTotal_OTHER_EXAPPRDONATION_top.Visible = False
                lineTotal_OTHER_EXAPPRDONATION_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXAPPRDONATION.GetCurrentColumnValue("EXOAD_EXOADKEY")
                Dim SourceNo As Integer = OTHER_EXAPPRDONATION.GetCurrentColumnValue("EXOAD_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXAPPRDONATION_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXAPPRDONATION.Visible = True
                    perTotal_OTHER_EXAPPRDONATION.Visible = True
                    lineTotal_OTHER_EXAPPRDONATION_top.Visible = True
                    lineTotal_OTHER_EXAPPRDONATION_bot.Visible = True
                Else
                    txtTotal_OTHER_EXAPPRDONATION.Visible = False
                    perTotal_OTHER_EXAPPRDONATION.Visible = False
                    lineTotal_OTHER_EXAPPRDONATION_top.Visible = False
                    lineTotal_OTHER_EXAPPRDONATION_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXAPPRDONATION_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXAPPRDONATION.BeforePrint, per_OTHER_EXAPPRDONATION.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXAPPRDONATION.GetCurrentColumnValue("EXOAD_KEY")
            Dim ParentID As Integer = OTHER_EXAPPRDONATION.GetCurrentColumnValue("EXOAD_EXOADKEY")
            Dim SourceNo As Integer = OTHER_EXAPPRDONATION.GetCurrentColumnValue("EXOAD_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXAPPRDONATION.Visible = Me.GetVisibility_OTHER_EXAPPRDONATION(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXAPPRDONATION.Visible = txt_OTHER_EXAPPRDONATION.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXAPPRDONATION_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXAPPRDONATION.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXAPPRDONATION.GetCurrentColumnValue("EXOAD_KEY")
            Dim ParentID As Integer = OTHER_EXAPPRDONATION.GetCurrentColumnValue("EXOAD_EXOADKEY")
            Dim SourceNo As Integer = OTHER_EXAPPRDONATION.GetCurrentColumnValue("EXOAD_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXAPPRDONATION(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXAPPRDONATION.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXAPPRDONATION(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXAPPRDONATION_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXAPPRDONATION_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXNAPPRDONATION"
    Private Sub txtTotal_OTHER_EXNAPPRDONATION_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXNAPPRDONATION.BeforePrint, perTotal_OTHER_EXNAPPRDONATION.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXNAPPRDONATION.GetCurrentColumnValue("EXONAD_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXNAPPRDONATION_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXNAPPRDONATION.Visible = False
                txtTotal_OTHER_EXNAPPRDONATION.Visible = False
                perTotal_OTHER_EXNAPPRDONATION.Visible = False
                lineTotal_OTHER_EXNAPPRDONATION_top.Visible = False
                lineTotal_OTHER_EXNAPPRDONATION_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXNAPPRDONATION.GetCurrentColumnValue("EXONAD_EXONADKEY")
                Dim SourceNo As Integer = OTHER_EXNAPPRDONATION.GetCurrentColumnValue("EXONAD_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXNAPPRDONATION_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXNAPPRDONATION.Visible = True
                    perTotal_OTHER_EXNAPPRDONATION.Visible = True
                    lineTotal_OTHER_EXNAPPRDONATION_top.Visible = True
                    lineTotal_OTHER_EXNAPPRDONATION_bot.Visible = True
                Else
                    txtTotal_OTHER_EXNAPPRDONATION.Visible = False
                    perTotal_OTHER_EXNAPPRDONATION.Visible = False
                    lineTotal_OTHER_EXNAPPRDONATION_top.Visible = False
                    lineTotal_OTHER_EXNAPPRDONATION_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXNAPPRDONATION_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXNAPPRDONATION.BeforePrint, per_OTHER_EXNAPPRDONATION.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXNAPPRDONATION.GetCurrentColumnValue("EXONAD_KEY")
            Dim ParentID As Integer = OTHER_EXNAPPRDONATION.GetCurrentColumnValue("EXONAD_EXONADKEY")
            Dim SourceNo As Integer = OTHER_EXNAPPRDONATION.GetCurrentColumnValue("EXONAD_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXNAPPRDONATION.Visible = Me.GetVisibility_OTHER_EXNAPPRDONATION(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXNAPPRDONATION.Visible = txt_OTHER_EXNAPPRDONATION.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXNAPPRDONATION_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXNAPPRDONATION.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXNAPPRDONATION.GetCurrentColumnValue("EXONAD_KEY")
            Dim ParentID As Integer = OTHER_EXNAPPRDONATION.GetCurrentColumnValue("EXONAD_EXONADKEY")
            Dim SourceNo As Integer = OTHER_EXNAPPRDONATION.GetCurrentColumnValue("EXONAD_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXNAPPRDONATION(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXNAPPRDONATION.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXNAPPRDONATION(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXNAPPRDONATION_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXNAPPRDONATION_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXZAKAT"
    Private Sub txtTotal_OTHER_EXZAKAT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXZAKAT.BeforePrint, perTotal_OTHER_EXZAKAT.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXZAKAT.GetCurrentColumnValue("EXOZ_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXZAKAT_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXZAKAT.Visible = False
                txtTotal_OTHER_EXZAKAT.Visible = False
                perTotal_OTHER_EXZAKAT.Visible = False
                lineTotal_OTHER_EXZAKAT_top.Visible = False
                lineTotal_OTHER_EXZAKAT_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXZAKAT.GetCurrentColumnValue("EXOZ_EXOZKEY")
                Dim SourceNo As Integer = OTHER_EXZAKAT.GetCurrentColumnValue("EXOZ_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXZAKAT_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXZAKAT.Visible = True
                    perTotal_OTHER_EXZAKAT.Visible = True
                    lineTotal_OTHER_EXZAKAT_top.Visible = True
                    lineTotal_OTHER_EXZAKAT_bot.Visible = True
                Else
                    txtTotal_OTHER_EXZAKAT.Visible = False
                    perTotal_OTHER_EXZAKAT.Visible = False
                    lineTotal_OTHER_EXZAKAT_top.Visible = False
                    lineTotal_OTHER_EXZAKAT_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXZAKAT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXZAKAT.BeforePrint, per_OTHER_EXZAKAT.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXZAKAT.GetCurrentColumnValue("EXOZ_KEY")
            Dim ParentID As Integer = OTHER_EXZAKAT.GetCurrentColumnValue("EXOZ_EXOZKEY")
            Dim SourceNo As Integer = OTHER_EXZAKAT.GetCurrentColumnValue("EXOZ_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXZAKAT.Visible = Me.GetVisibility_OTHER_EXZAKAT(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXZAKAT.Visible = txt_OTHER_EXZAKAT.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXZAKAT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXZAKAT.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXZAKAT.GetCurrentColumnValue("EXOZ_KEY")
            Dim ParentID As Integer = OTHER_EXZAKAT.GetCurrentColumnValue("EXOZ_EXOZKEY")
            Dim SourceNo As Integer = OTHER_EXZAKAT.GetCurrentColumnValue("EXOZ_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXZAKAT(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXZAKAT.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXZAKAT(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXZAKAT_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXZAKAT_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXLOSSDISPOSALFA"
    Private Sub txtTotal_OTHER_EXLOSSDISPOSALFA_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXLOSSDISPOSALFA.BeforePrint, perTotal_OTHER_EXLOSSDISPOSALFA.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXLOSSDISPOSALFA.GetCurrentColumnValue("EXOLD_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXLOSSDISPOSALFA_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXLOSSDISPOSALFA.Visible = False
                txtTotal_OTHER_EXLOSSDISPOSALFA.Visible = False
                perTotal_OTHER_EXLOSSDISPOSALFA.Visible = False
                lineTotal_OTHER_EXLOSSDISPOSALFA_top.Visible = False
                lineTotal_OTHER_EXLOSSDISPOSALFA_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXLOSSDISPOSALFA.GetCurrentColumnValue("EXOLD_EXOLDKEY")
                Dim SourceNo As Integer = OTHER_EXLOSSDISPOSALFA.GetCurrentColumnValue("EXOLD_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXLOSSDISPOSALFA_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXLOSSDISPOSALFA.Visible = True
                    perTotal_OTHER_EXLOSSDISPOSALFA.Visible = True
                    lineTotal_OTHER_EXLOSSDISPOSALFA_top.Visible = True
                    lineTotal_OTHER_EXLOSSDISPOSALFA_bot.Visible = True
                Else
                    txtTotal_OTHER_EXLOSSDISPOSALFA.Visible = False
                    perTotal_OTHER_EXLOSSDISPOSALFA.Visible = False
                    lineTotal_OTHER_EXLOSSDISPOSALFA_top.Visible = False
                    lineTotal_OTHER_EXLOSSDISPOSALFA_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXLOSSDISPOSALFA_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXLOSSDISPOSALFA.BeforePrint, per_OTHER_EXLOSSDISPOSALFA.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXLOSSDISPOSALFA.GetCurrentColumnValue("EXOLD_KEY")
            Dim ParentID As Integer = OTHER_EXLOSSDISPOSALFA.GetCurrentColumnValue("EXOLD_EXOLDKEY")
            Dim SourceNo As Integer = OTHER_EXLOSSDISPOSALFA.GetCurrentColumnValue("EXOLD_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXLOSSDISPOSALFA.Visible = Me.GetVisibility_OTHER_EXLOSSDISPOSALFA(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXLOSSDISPOSALFA.Visible = txt_OTHER_EXLOSSDISPOSALFA.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXLOSSDISPOSALFA_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXLOSSDISPOSALFA.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXLOSSDISPOSALFA.GetCurrentColumnValue("EXOLD_KEY")
            Dim ParentID As Integer = OTHER_EXLOSSDISPOSALFA.GetCurrentColumnValue("EXOLD_EXOLDKEY")
            Dim SourceNo As Integer = OTHER_EXLOSSDISPOSALFA.GetCurrentColumnValue("EXOLD_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXLOSSDISPOSALFA(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXLOSSDISPOSALFA.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXLOSSDISPOSALFA(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXLOSSDISPOSALFA_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXLOSSDISPOSALFA_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_ENTERTAINNSTAFF"
    Private Sub txtTotal_OTHER_ENTERTAINNSTAFF_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_ENTERTAINNSTAFF.BeforePrint, perTotal_OTHER_ENTERTAINNSTAFF.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_ENTERTAINNSTAFF.GetCurrentColumnValue("EXOENS_KEY")
            Dim countx As Integer = ADO.Load_OTHER_ENTERTAINNSTAFF_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_ENTERTAINNSTAFF.Visible = False
                txtTotal_OTHER_ENTERTAINNSTAFF.Visible = False
                perTotal_OTHER_ENTERTAINNSTAFF.Visible = False
                lineTotal_OTHER_ENTERTAINNSTAFF_top.Visible = False
                lineTotal_OTHER_ENTERTAINNSTAFF_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_ENTERTAINNSTAFF.GetCurrentColumnValue("EXOENS_EXOENSKEY")
                Dim SourceNo As Integer = OTHER_ENTERTAINNSTAFF.GetCurrentColumnValue("EXOENS_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_ENTERTAINNSTAFF_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_ENTERTAINNSTAFF.Visible = True
                    perTotal_OTHER_ENTERTAINNSTAFF.Visible = True
                    lineTotal_OTHER_ENTERTAINNSTAFF_top.Visible = True
                    lineTotal_OTHER_ENTERTAINNSTAFF_bot.Visible = True
                Else
                    txtTotal_OTHER_ENTERTAINNSTAFF.Visible = False
                    perTotal_OTHER_ENTERTAINNSTAFF.Visible = False
                    lineTotal_OTHER_ENTERTAINNSTAFF_top.Visible = False
                    lineTotal_OTHER_ENTERTAINNSTAFF_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_ENTERTAINNSTAFF_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_ENTERTAINNSTAFF.BeforePrint, per_OTHER_ENTERTAINNSTAFF.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_ENTERTAINNSTAFF.GetCurrentColumnValue("EXOENS_KEY")
            Dim ParentID As Integer = OTHER_ENTERTAINNSTAFF.GetCurrentColumnValue("EXOENS_EXOENSKEY")
            Dim SourceNo As Integer = OTHER_ENTERTAINNSTAFF.GetCurrentColumnValue("EXOENS_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_ENTERTAINNSTAFF.Visible = Me.GetVisibility_OTHER_ENTERTAINNSTAFF(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_ENTERTAINNSTAFF.Visible = txt_OTHER_ENTERTAINNSTAFF.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_ENTERTAINNSTAFF_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_ENTERTAINNSTAFF.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_ENTERTAINNSTAFF.GetCurrentColumnValue("EXOENS_KEY")
            Dim ParentID As Integer = OTHER_ENTERTAINNSTAFF.GetCurrentColumnValue("EXOENS_EXOENSKEY")
            Dim SourceNo As Integer = OTHER_ENTERTAINNSTAFF.GetCurrentColumnValue("EXOENS_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_ENTERTAINNSTAFF(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_ENTERTAINNSTAFF.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_ENTERTAINNSTAFF(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_ENTERTAINNSTAFF_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_ENTERTAINNSTAFF_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_ENTERTAINSTAFF"
    Private Sub txtTotal_OTHER_ENTERTAINSTAFF_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_ENTERTAINSTAFF.BeforePrint, perTotal_OTHER_ENTERTAINSTAFF.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_ENTERTAINSTAFF.GetCurrentColumnValue("EXOES_KEY")
            Dim countx As Integer = ADO.Load_OTHER_ENTERTAINSTAFF_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_ENTERTAINSTAFF.Visible = False
                txtTotal_OTHER_ENTERTAINSTAFF.Visible = False
                perTotal_OTHER_ENTERTAINSTAFF.Visible = False
                lineTotal_OTHER_ENTERTAINSTAFF_top.Visible = False
                lineTotal_OTHER_ENTERTAINSTAFF_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_ENTERTAINSTAFF.GetCurrentColumnValue("EXOES_EXOESKEY")
                Dim SourceNo As Integer = OTHER_ENTERTAINSTAFF.GetCurrentColumnValue("EXOES_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_ENTERTAINSTAFF_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_ENTERTAINSTAFF.Visible = True
                    perTotal_OTHER_ENTERTAINSTAFF.Visible = True
                    lineTotal_OTHER_ENTERTAINSTAFF_top.Visible = True
                    lineTotal_OTHER_ENTERTAINSTAFF_bot.Visible = True
                Else
                    txtTotal_OTHER_ENTERTAINSTAFF.Visible = False
                    perTotal_OTHER_ENTERTAINSTAFF.Visible = False
                    lineTotal_OTHER_ENTERTAINSTAFF_top.Visible = False
                    lineTotal_OTHER_ENTERTAINSTAFF_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_ENTERTAINSTAFF_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_ENTERTAINSTAFF.BeforePrint, per_OTHER_ENTERTAINSTAFF.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_ENTERTAINSTAFF.GetCurrentColumnValue("EXOES_KEY")
            Dim ParentID As Integer = OTHER_ENTERTAINSTAFF.GetCurrentColumnValue("EXOES_EXOESKEY")
            Dim SourceNo As Integer = OTHER_ENTERTAINSTAFF.GetCurrentColumnValue("EXOES_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_ENTERTAINSTAFF.Visible = Me.GetVisibility_OTHER_ENTERTAINSTAFF(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_ENTERTAINSTAFF.Visible = txt_OTHER_ENTERTAINSTAFF.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_ENTERTAINSTAFF_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_ENTERTAINSTAFF.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_ENTERTAINSTAFF.GetCurrentColumnValue("EXOES_KEY")
            Dim ParentID As Integer = OTHER_ENTERTAINSTAFF.GetCurrentColumnValue("EXOES_EXOESKEY")
            Dim SourceNo As Integer = OTHER_ENTERTAINSTAFF.GetCurrentColumnValue("EXOES_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_ENTERTAINSTAFF(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_ENTERTAINSTAFF.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_ENTERTAINSTAFF(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_ENTERTAINSTAFF_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_ENTERTAINSTAFF_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXPENALTY"
    Private Sub txtTotal_OTHER_EXPENALTY_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXPENALTY.BeforePrint, perTotal_OTHER_EXPENALTY.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXPENALTY.GetCurrentColumnValue("EXOP_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXPENALTY_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXPENALTY.Visible = False
                txtTotal_OTHER_EXPENALTY.Visible = False
                perTotal_OTHER_EXPENALTY.Visible = False
                lineTotal_OTHER_EXPENALTY_top.Visible = False
                lineTotal_OTHER_EXPENALTY_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXPENALTY.GetCurrentColumnValue("EXOP_EXOPKEY")
                Dim SourceNo As Integer = OTHER_EXPENALTY.GetCurrentColumnValue("EXOP_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXPENALTY_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXPENALTY.Visible = True
                    perTotal_OTHER_EXPENALTY.Visible = True
                    lineTotal_OTHER_EXPENALTY_top.Visible = True
                    lineTotal_OTHER_EXPENALTY_bot.Visible = True
                Else
                    txtTotal_OTHER_EXPENALTY.Visible = False
                    perTotal_OTHER_EXPENALTY.Visible = False
                    lineTotal_OTHER_EXPENALTY_top.Visible = False
                    lineTotal_OTHER_EXPENALTY_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXPENALTY_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXPENALTY.BeforePrint, per_OTHER_EXPENALTY.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXPENALTY.GetCurrentColumnValue("EXOP_KEY")
            Dim ParentID As Integer = OTHER_EXPENALTY.GetCurrentColumnValue("EXOP_EXOPKEY")
            Dim SourceNo As Integer = OTHER_EXPENALTY.GetCurrentColumnValue("EXOP_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXPENALTY.Visible = Me.GetVisibility_OTHER_EXPENALTY(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXPENALTY.Visible = txt_OTHER_EXPENALTY.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXPENALTY_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXPENALTY.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXPENALTY.GetCurrentColumnValue("EXOP_KEY")
            Dim ParentID As Integer = OTHER_EXPENALTY.GetCurrentColumnValue("EXOP_EXOPKEY")
            Dim SourceNo As Integer = OTHER_EXPENALTY.GetCurrentColumnValue("EXOP_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXPENALTY(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXPENALTY.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXPENALTY(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXPENALTY_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXPENALTY_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXPROVISIONACC"
    Private Sub txtTotal_OTHER_EXPROVISIONACC_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXPROVISIONACC.BeforePrint, perTotal_OTHER_EXPROVISIONACC.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXPROVISIONACC.GetCurrentColumnValue("EXOPA_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXPROVISIONACC_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXPROVISIONACC.Visible = False
                txtTotal_OTHER_EXPROVISIONACC.Visible = False
                perTotal_OTHER_EXPROVISIONACC.Visible = False
                lineTotal_OTHER_EXPROVISIONACC_top.Visible = False
                lineTotal_OTHER_EXPROVISIONACC_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXPROVISIONACC.GetCurrentColumnValue("EXOPA_EXOPAKEY")
                Dim SourceNo As Integer = OTHER_EXPROVISIONACC.GetCurrentColumnValue("EXOPA_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXPROVISIONACC_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXPROVISIONACC.Visible = True
                    perTotal_OTHER_EXPROVISIONACC.Visible = True
                    lineTotal_OTHER_EXPROVISIONACC_top.Visible = True
                    lineTotal_OTHER_EXPROVISIONACC_bot.Visible = True
                Else
                    txtTotal_OTHER_EXPROVISIONACC.Visible = False
                    perTotal_OTHER_EXPROVISIONACC.Visible = False
                    lineTotal_OTHER_EXPROVISIONACC_top.Visible = False
                    lineTotal_OTHER_EXPROVISIONACC_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXPROVISIONACC_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXPROVISIONACC.BeforePrint, per_OTHER_EXPROVISIONACC.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXPROVISIONACC.GetCurrentColumnValue("EXOPA_KEY")
            Dim ParentID As Integer = OTHER_EXPROVISIONACC.GetCurrentColumnValue("EXOPA_EXOPAKEY")
            Dim SourceNo As Integer = OTHER_EXPROVISIONACC.GetCurrentColumnValue("EXOPA_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXPROVISIONACC.Visible = Me.GetVisibility_OTHER_EXPROVISIONACC(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXPROVISIONACC.Visible = txt_OTHER_EXPROVISIONACC.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXPROVISIONACC_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXPROVISIONACC.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXPROVISIONACC.GetCurrentColumnValue("EXOPA_KEY")
            Dim ParentID As Integer = OTHER_EXPROVISIONACC.GetCurrentColumnValue("EXOPA_EXOPAKEY")
            Dim SourceNo As Integer = OTHER_EXPROVISIONACC.GetCurrentColumnValue("EXOPA_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXPROVISIONACC(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXPROVISIONACC.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXPROVISIONACC(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXPROVISIONACC_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXPROVISIONACC_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXLEAVEPASSAGE"
    Private Sub txtTotal_OTHER_EXLEAVEPASSAGE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXLEAVEPASSAGE.BeforePrint, perTotal_OTHER_EXLEAVEPASSAGE.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXLEAVEPASSAGE.GetCurrentColumnValue("EXOLP_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXLEAVEPASSAGE_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXLEAVEPASSAGE.Visible = False
                txtTotal_OTHER_EXLEAVEPASSAGE.Visible = False
                perTotal_OTHER_EXLEAVEPASSAGE.Visible = False
                lineTotal_OTHER_EXLEAVEPASSAGE_top.Visible = False
                lineTotal_OTHER_EXLEAVEPASSAGE_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXLEAVEPASSAGE.GetCurrentColumnValue("EXOLP_EXOLPKEY")
                Dim SourceNo As Integer = OTHER_EXLEAVEPASSAGE.GetCurrentColumnValue("EXOLP_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXLEAVEPASSAGE_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXLEAVEPASSAGE.Visible = True
                    perTotal_OTHER_EXLEAVEPASSAGE.Visible = True
                    lineTotal_OTHER_EXLEAVEPASSAGE_top.Visible = True
                    lineTotal_OTHER_EXLEAVEPASSAGE_bot.Visible = True
                Else
                    txtTotal_OTHER_EXLEAVEPASSAGE.Visible = False
                    perTotal_OTHER_EXLEAVEPASSAGE.Visible = False
                    lineTotal_OTHER_EXLEAVEPASSAGE_top.Visible = False
                    lineTotal_OTHER_EXLEAVEPASSAGE_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXLEAVEPASSAGE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXLEAVEPASSAGE.BeforePrint, per_OTHER_EXLEAVEPASSAGE.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXLEAVEPASSAGE.GetCurrentColumnValue("EXOLP_KEY")
            Dim ParentID As Integer = OTHER_EXLEAVEPASSAGE.GetCurrentColumnValue("EXOLP_EXOLPKEY")
            Dim SourceNo As Integer = OTHER_EXLEAVEPASSAGE.GetCurrentColumnValue("EXOLP_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXLEAVEPASSAGE.Visible = Me.GetVisibility_OTHER_EXLEAVEPASSAGE(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXLEAVEPASSAGE.Visible = txt_OTHER_EXLEAVEPASSAGE.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXLEAVEPASSAGE_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXLEAVEPASSAGE.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXLEAVEPASSAGE.GetCurrentColumnValue("EXOLP_KEY")
            Dim ParentID As Integer = OTHER_EXLEAVEPASSAGE.GetCurrentColumnValue("EXOLP_EXOLPKEY")
            Dim SourceNo As Integer = OTHER_EXLEAVEPASSAGE.GetCurrentColumnValue("EXOLP_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXLEAVEPASSAGE(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXLEAVEPASSAGE.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXLEAVEPASSAGE(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXLEAVEPASSAGE_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXLEAVEPASSAGE_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXFAWRITTENOFF"
    Private Sub txtTotal_OTHER_EXFAWRITTENOFF_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXFAWRITTENOFF.BeforePrint, perTotal_OTHER_EXFAWRITTENOFF.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXFAWRITTENOFF.GetCurrentColumnValue("EXOWO_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXFAWRITTENOFF_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXFAWRITTENOFF.Visible = False
                txtTotal_OTHER_EXFAWRITTENOFF.Visible = False
                perTotal_OTHER_EXFAWRITTENOFF.Visible = False
                lineTotal_OTHER_EXFAWRITTENOFF_top.Visible = False
                lineTotal_OTHER_EXFAWRITTENOFF_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXFAWRITTENOFF.GetCurrentColumnValue("EXOWO_EXOWOKEY")
                Dim SourceNo As Integer = OTHER_EXFAWRITTENOFF.GetCurrentColumnValue("EXOWO_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXFAWRITTENOFF_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXFAWRITTENOFF.Visible = True
                    perTotal_OTHER_EXFAWRITTENOFF.Visible = True
                    lineTotal_OTHER_EXFAWRITTENOFF_top.Visible = True
                    lineTotal_OTHER_EXFAWRITTENOFF_bot.Visible = True
                Else
                    txtTotal_OTHER_EXFAWRITTENOFF.Visible = False
                    perTotal_OTHER_EXFAWRITTENOFF.Visible = False
                    lineTotal_OTHER_EXFAWRITTENOFF_top.Visible = False
                    lineTotal_OTHER_EXFAWRITTENOFF_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXFAWRITTENOFF_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXFAWRITTENOFF.BeforePrint, per_OTHER_EXFAWRITTENOFF.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXFAWRITTENOFF.GetCurrentColumnValue("EXOWO_KEY")
            Dim ParentID As Integer = OTHER_EXFAWRITTENOFF.GetCurrentColumnValue("EXOWO_EXOWOKEY")
            Dim SourceNo As Integer = OTHER_EXFAWRITTENOFF.GetCurrentColumnValue("EXOWO_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXFAWRITTENOFF.Visible = Me.GetVisibility_OTHER_EXFAWRITTENOFF(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXFAWRITTENOFF.Visible = txt_OTHER_EXFAWRITTENOFF.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXFAWRITTENOFF_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXFAWRITTENOFF.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXFAWRITTENOFF.GetCurrentColumnValue("EXOWO_KEY")
            Dim ParentID As Integer = OTHER_EXFAWRITTENOFF.GetCurrentColumnValue("EXOWO_EXOWOKEY")
            Dim SourceNo As Integer = OTHER_EXFAWRITTENOFF.GetCurrentColumnValue("EXOWO_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXFAWRITTENOFF(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXFAWRITTENOFF.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXFAWRITTENOFF(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXFAWRITTENOFF_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXFAWRITTENOFF_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXURLOSSFOREIGN"
    Private Sub txtTotal_OTHER_EXURLOSSFOREIGN_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXURLOSSFOREIGN.BeforePrint, perTotal_OTHER_EXURLOSSFOREIGN.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXURLOSSFOREIGN.GetCurrentColumnValue("EXOUR_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXURLOSSFOREIGN_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXURLOSSFOREIGN.Visible = False
                txtTotal_OTHER_EXURLOSSFOREIGN.Visible = False
                perTotal_OTHER_EXURLOSSFOREIGN.Visible = False
                lineTotal_OTHER_EXURLOSSFOREIGN_top.Visible = False
                lineTotal_OTHER_EXURLOSSFOREIGN_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXURLOSSFOREIGN.GetCurrentColumnValue("EXOUR_EXOURKEY")
                Dim SourceNo As Integer = OTHER_EXURLOSSFOREIGN.GetCurrentColumnValue("EXOUR_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXURLOSSFOREIGN_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXURLOSSFOREIGN.Visible = True
                    perTotal_OTHER_EXURLOSSFOREIGN.Visible = True
                    lineTotal_OTHER_EXURLOSSFOREIGN_top.Visible = True
                    lineTotal_OTHER_EXURLOSSFOREIGN_bot.Visible = True
                Else
                    txtTotal_OTHER_EXURLOSSFOREIGN.Visible = False
                    perTotal_OTHER_EXURLOSSFOREIGN.Visible = False
                    lineTotal_OTHER_EXURLOSSFOREIGN_top.Visible = False
                    lineTotal_OTHER_EXURLOSSFOREIGN_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXURLOSSFOREIGN_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXURLOSSFOREIGN.BeforePrint, per_OTHER_EXURLOSSFOREIGN.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXURLOSSFOREIGN.GetCurrentColumnValue("EXOUR_KEY")
            Dim ParentID As Integer = OTHER_EXURLOSSFOREIGN.GetCurrentColumnValue("EXOUR_EXOURKEY")
            Dim SourceNo As Integer = OTHER_EXURLOSSFOREIGN.GetCurrentColumnValue("EXOUR_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXURLOSSFOREIGN.Visible = Me.GetVisibility_OTHER_EXURLOSSFOREIGN(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXURLOSSFOREIGN.Visible = txt_OTHER_EXURLOSSFOREIGN.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXURLOSSFOREIGN_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXURLOSSFOREIGN.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXURLOSSFOREIGN.GetCurrentColumnValue("EXOUR_KEY")
            Dim ParentID As Integer = OTHER_EXURLOSSFOREIGN.GetCurrentColumnValue("EXOUR_EXOURKEY")
            Dim SourceNo As Integer = OTHER_EXURLOSSFOREIGN.GetCurrentColumnValue("EXOUR_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXURLOSSFOREIGN(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXURLOSSFOREIGN.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXURLOSSFOREIGN(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXURLOSSFOREIGN_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXURLOSSFOREIGN_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXRLOSSFOREIGNT"
    Private Sub txtTotal_OTHER_EXRLOSSFOREIGNT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXRLOSSFOREIGNT.BeforePrint, perTotal_OTHER_EXRLOSSFOREIGNT.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXRLOSSFOREIGNT.GetCurrentColumnValue("EXORT_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXRLOSSFOREIGNT_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXRLOSSFOREIGNT.Visible = False
                txtTotal_OTHER_EXRLOSSFOREIGNT.Visible = False
                perTotal_OTHER_EXRLOSSFOREIGNT.Visible = False
                lineTotal_OTHER_EXRLOSSFOREIGNT_top.Visible = False
                lineTotal_OTHER_EXRLOSSFOREIGNT_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXRLOSSFOREIGNT.GetCurrentColumnValue("EXORT_EXORTKEY")
                Dim SourceNo As Integer = OTHER_EXRLOSSFOREIGNT.GetCurrentColumnValue("EXORT_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXRLOSSFOREIGNT_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXRLOSSFOREIGNT.Visible = True
                    perTotal_OTHER_EXRLOSSFOREIGNT.Visible = True
                    lineTotal_OTHER_EXRLOSSFOREIGNT_top.Visible = True
                    lineTotal_OTHER_EXRLOSSFOREIGNT_bot.Visible = True
                Else
                    txtTotal_OTHER_EXRLOSSFOREIGNT.Visible = False
                    perTotal_OTHER_EXRLOSSFOREIGNT.Visible = False
                    lineTotal_OTHER_EXRLOSSFOREIGNT_top.Visible = False
                    lineTotal_OTHER_EXRLOSSFOREIGNT_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXRLOSSFOREIGNT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXRLOSSFOREIGNT.BeforePrint, per_OTHER_EXRLOSSFOREIGNT.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXRLOSSFOREIGNT.GetCurrentColumnValue("EXORT_KEY")
            Dim ParentID As Integer = OTHER_EXRLOSSFOREIGNT.GetCurrentColumnValue("EXORT_EXORTKEY")
            Dim SourceNo As Integer = OTHER_EXRLOSSFOREIGNT.GetCurrentColumnValue("EXORT_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXRLOSSFOREIGNT.Visible = Me.GetVisibility_OTHER_EXRLOSSFOREIGNT(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXRLOSSFOREIGNT.Visible = txt_OTHER_EXRLOSSFOREIGNT.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXRLOSSFOREIGNT_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXRLOSSFOREIGNT.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXRLOSSFOREIGNT.GetCurrentColumnValue("EXORT_KEY")
            Dim ParentID As Integer = OTHER_EXRLOSSFOREIGNT.GetCurrentColumnValue("EXORT_EXORTKEY")
            Dim SourceNo As Integer = OTHER_EXRLOSSFOREIGNT.GetCurrentColumnValue("EXORT_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXRLOSSFOREIGNT(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXRLOSSFOREIGNT.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXRLOSSFOREIGNT(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXRLOSSFOREIGNT_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXRLOSSFOREIGNT_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXRLOSSFOREIGN"
    Private Sub txtTotal_OTHER_EXRLOSSFOREIGN_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXRLOSSFOREIGN.BeforePrint, perTotal_OTHER_EXRLOSSFOREIGN.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXRLOSSFOREIGN.GetCurrentColumnValue("EXOR_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXRLOSSFOREIGN_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXRLOSSFOREIGN.Visible = False
                txtTotal_OTHER_EXRLOSSFOREIGN.Visible = False
                perTotal_OTHER_EXRLOSSFOREIGN.Visible = False
                lineTotal_OTHER_EXRLOSSFOREIGN_top.Visible = False
                lineTotal_OTHER_EXRLOSSFOREIGN_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXRLOSSFOREIGN.GetCurrentColumnValue("EXOR_EXORKEY")
                Dim SourceNo As Integer = OTHER_EXRLOSSFOREIGN.GetCurrentColumnValue("EXOR_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXRLOSSFOREIGN_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXRLOSSFOREIGN.Visible = True
                    perTotal_OTHER_EXRLOSSFOREIGN.Visible = True
                    lineTotal_OTHER_EXRLOSSFOREIGN_top.Visible = True
                    lineTotal_OTHER_EXRLOSSFOREIGN_bot.Visible = True
                Else
                    txtTotal_OTHER_EXRLOSSFOREIGN.Visible = False
                    perTotal_OTHER_EXRLOSSFOREIGN.Visible = False
                    lineTotal_OTHER_EXRLOSSFOREIGN_top.Visible = False
                    lineTotal_OTHER_EXRLOSSFOREIGN_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXRLOSSFOREIGN_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXRLOSSFOREIGN.BeforePrint, per_OTHER_EXRLOSSFOREIGN.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXRLOSSFOREIGN.GetCurrentColumnValue("EXOR_KEY")
            Dim ParentID As Integer = OTHER_EXRLOSSFOREIGN.GetCurrentColumnValue("EXOR_EXORKEY")
            Dim SourceNo As Integer = OTHER_EXRLOSSFOREIGN.GetCurrentColumnValue("EXOR_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXRLOSSFOREIGN.Visible = Me.GetVisibility_OTHER_EXRLOSSFOREIGN(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXRLOSSFOREIGN.Visible = txt_OTHER_EXRLOSSFOREIGN.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXRLOSSFOREIGN_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXRLOSSFOREIGN.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXRLOSSFOREIGN.GetCurrentColumnValue("EXOR_KEY")
            Dim ParentID As Integer = OTHER_EXRLOSSFOREIGN.GetCurrentColumnValue("EXOR_EXORKEY")
            Dim SourceNo As Integer = OTHER_EXRLOSSFOREIGN.GetCurrentColumnValue("EXOR_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXRLOSSFOREIGN(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXRLOSSFOREIGN.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXRLOSSFOREIGN(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXRLOSSFOREIGN_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXRLOSSFOREIGN_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXINITIALSUB"
    Private Sub txtTotal_OTHER_EXINITIALSUB_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXINITIALSUB.BeforePrint, perTotal_OTHER_EXINITIALSUB.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXINITIALSUB.GetCurrentColumnValue("EXOIS_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXINITIALSUB_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXINITIALSUB.Visible = False
                txtTotal_OTHER_EXINITIALSUB.Visible = False
                perTotal_OTHER_EXINITIALSUB.Visible = False
                lineTotal_OTHER_EXINITIALSUB_top.Visible = False
                lineTotal_OTHER_EXINITIALSUB_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXINITIALSUB.GetCurrentColumnValue("EXOIS_EXOISKEY")
                Dim SourceNo As Integer = OTHER_EXINITIALSUB.GetCurrentColumnValue("EXOIS_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXINITIALSUB_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXINITIALSUB.Visible = True
                    perTotal_OTHER_EXINITIALSUB.Visible = True
                    lineTotal_OTHER_EXINITIALSUB_top.Visible = True
                    lineTotal_OTHER_EXINITIALSUB_bot.Visible = True
                Else
                    txtTotal_OTHER_EXINITIALSUB.Visible = False
                    perTotal_OTHER_EXINITIALSUB.Visible = False
                    lineTotal_OTHER_EXINITIALSUB_top.Visible = False
                    lineTotal_OTHER_EXINITIALSUB_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXINITIALSUB_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXINITIALSUB.BeforePrint, per_OTHER_EXINITIALSUB.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXINITIALSUB.GetCurrentColumnValue("EXOIS_KEY")
            Dim ParentID As Integer = OTHER_EXINITIALSUB.GetCurrentColumnValue("EXOIS_EXOISKEY")
            Dim SourceNo As Integer = OTHER_EXINITIALSUB.GetCurrentColumnValue("EXOIS_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXINITIALSUB.Visible = Me.GetVisibility_OTHER_EXINITIALSUB(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXINITIALSUB.Visible = txt_OTHER_EXINITIALSUB.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXINITIALSUB_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXINITIALSUB.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXINITIALSUB.GetCurrentColumnValue("EXOIS_KEY")
            Dim ParentID As Integer = OTHER_EXINITIALSUB.GetCurrentColumnValue("EXOIS_EXOISKEY")
            Dim SourceNo As Integer = OTHER_EXINITIALSUB.GetCurrentColumnValue("EXOIS_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXINITIALSUB(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXINITIALSUB.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXINITIALSUB(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXINITIALSUB_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXINITIALSUB_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXCAPITALEXP"
    Private Sub txtTotal_OTHER_EXCAPITALEXP_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXCAPITALEXP.BeforePrint, perTotal_OTHER_EXCAPITALEXP.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXCAPITALEXP.GetCurrentColumnValue("EXOCE_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXCAPITALEXP_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXCAPITALEXP.Visible = False
                txtTotal_OTHER_EXCAPITALEXP.Visible = False
                perTotal_OTHER_EXCAPITALEXP.Visible = False
                lineTotal_OTHER_EXCAPITALEXP_top.Visible = False
                lineTotal_OTHER_EXCAPITALEXP_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXCAPITALEXP.GetCurrentColumnValue("EXOCE_EXOCEKEY")
                Dim SourceNo As Integer = OTHER_EXCAPITALEXP.GetCurrentColumnValue("EXOCE_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXCAPITALEXP_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXCAPITALEXP.Visible = True
                    perTotal_OTHER_EXCAPITALEXP.Visible = True
                    lineTotal_OTHER_EXCAPITALEXP_top.Visible = True
                    lineTotal_OTHER_EXCAPITALEXP_bot.Visible = True
                Else
                    txtTotal_OTHER_EXCAPITALEXP.Visible = False
                    perTotal_OTHER_EXCAPITALEXP.Visible = False
                    lineTotal_OTHER_EXCAPITALEXP_top.Visible = False
                    lineTotal_OTHER_EXCAPITALEXP_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXCAPITALEXP_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXCAPITALEXP.BeforePrint, per_OTHER_EXCAPITALEXP.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXCAPITALEXP.GetCurrentColumnValue("EXOCE_KEY")
            Dim ParentID As Integer = OTHER_EXCAPITALEXP.GetCurrentColumnValue("EXOCE_EXOCEKEY")
            Dim SourceNo As Integer = OTHER_EXCAPITALEXP.GetCurrentColumnValue("EXOCE_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXCAPITALEXP.Visible = Me.GetVisibility_OTHER_EXCAPITALEXP(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXCAPITALEXP.Visible = txt_OTHER_EXCAPITALEXP.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXCAPITALEXP_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXCAPITALEXP.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXCAPITALEXP.GetCurrentColumnValue("EXOCE_KEY")
            Dim ParentID As Integer = OTHER_EXCAPITALEXP.GetCurrentColumnValue("EXOCE_EXOCEKEY")
            Dim SourceNo As Integer = OTHER_EXCAPITALEXP.GetCurrentColumnValue("EXOCE_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXCAPITALEXP(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXCAPITALEXP.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXCAPITALEXP(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXCAPITALEXP_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXCAPITALEXP_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "OTHER_EXPENSES"
    Private Sub txtTotal_OTHER_EXPENSES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_OTHER_EXPENSES.BeforePrint, perTotal_OTHER_EXPENSES.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_KEY")
            Dim countx As Integer = ADO.Load_OTHER_EXPENSES_TOTAL_SOURCENO(PL_KEY)

            If countx <= 1 Then
                ' GF_OTHER_EXPENSES.Visible = False
                txtTotal_OTHER_EXPENSES.Visible = False
                perTotal_OTHER_EXPENSES.Visible = False
                lineTotal_OTHER_EXPENSES_top.Visible = False
                lineTotal_OTHER_EXPENSES_bot.Visible = False
            Else
                Dim ParentID As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_EXOKEY")
                Dim SourceNo As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_SOURCENO")
                Dim countx_Item As Integer = ADO.Load_OTHER_EXPENSES_COUNT(PL_KEY, SourceNo)
                If countx_Item > 1 Then
                    txtTotal_OTHER_EXPENSES.Visible = True
                    perTotal_OTHER_EXPENSES.Visible = True
                    lineTotal_OTHER_EXPENSES_top.Visible = True
                    lineTotal_OTHER_EXPENSES_bot.Visible = True
                Else
                    txtTotal_OTHER_EXPENSES.Visible = False
                    perTotal_OTHER_EXPENSES.Visible = False
                    lineTotal_OTHER_EXPENSES_top.Visible = False
                    lineTotal_OTHER_EXPENSES_bot.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_OTHER_EXPENSES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txt_OTHER_EXPENSES.BeforePrint, per_OTHER_EXPENSES.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_KEY")
            Dim ParentID As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_EXOKEY")
            Dim SourceNo As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_SOURCENO")
            Dim LineStatus As Boolean = False
            txt_OTHER_EXPENSES.Visible = Me.GetVisibility_OTHER_EXPENSES(PL_KEY, ParentID, SourceNo, LineStatus)
            Application.DoEvents()
            per_OTHER_EXPENSES.Visible = txt_OTHER_EXPENSES.Visible

        Catch ex As Exception

        End Try
    End Sub
    Private Sub line_OTHER_EXPENSES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles line_OTHER_EXPENSES.BeforePrint
        Try
            Dim PL_KEY As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_KEY")
            Dim ParentID As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_EXOKEY")
            Dim SourceNo As Integer = OTHER_EXPENSES.GetCurrentColumnValue("EXO_SOURCENO")
            Dim LineStatus As Boolean = False
            Me.GetVisibility_OTHER_EXPENSES(PL_KEY, ParentID, SourceNo, LineStatus)
            line_OTHER_EXPENSES.Visible = LineStatus
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetVisibility_OTHER_EXPENSES(ByVal PL_KEY As Integer, ByVal ParentID As Integer, ByVal SourceNo As Integer, ByRef LineStatus As Boolean) As Boolean
        Try

            Dim countx_subItem As Integer = ADO.Load_OTHER_EXPENSES_COUNT_SUBITEM(PL_KEY, ParentID, SourceNo)
            Dim count_Item As Integer = ADO.Load_OTHER_EXPENSES_COUNT(PL_KEY, SourceNo)

            If count_Item <= 1 AndAlso countx_subItem <= 0 Then
                LineStatus = True
                Return True
            ElseIf count_Item > 1 AndAlso countx_subItem <= 0 Then
                LineStatus = False
                Return True
            Else
                LineStatus = False
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

    Private Sub title_Dividend_Income_Transfer_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles title_Dividend_Income_Transfer.BeforePrint
        Try
            Dim TypeofIncome As String = DIVIDEND_INCOME.GetCurrentColumnValue("DI_TRANSFER")
            Dim Percentage As Decimal = DIVIDEND_INCOME.GetCurrentColumnValue("DI_Percentage")

            If TypeofIncome = "Percentage" Then
                title_Dividend_Income_Transfer.Text = "Tax Deduct (" & Percentage & "%)"
            Else
                title_Dividend_Income_Transfer.Text = "Tax Deduct"
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDividend_Income_Transfer_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtDividend_Income_Transfer.BeforePrint
        Try
            Dim TypeofIncome As String = DIVIDEND_INCOME.GetCurrentColumnValue("DI_TRANSFER")
            Dim Amount As Decimal = 0

            If IsDBNull(DIVIDEND_INCOME.GetCurrentColumnValue("DI_PercentageAmount")) = False AndAlso IsNumeric(DIVIDEND_INCOME.GetCurrentColumnValue("DI_PercentageAmount")) Then
                Amount = CDec(DIVIDEND_INCOME.GetCurrentColumnValue("DI_PercentageAmount"))
            Else
                Amount = 0
            End If
            If TypeofIncome = "Percentage" Then
                txtDividend_Income_Transfer.Text = Amount
            Else
                txtDividend_Income_Transfer.Text = TypeofIncome
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rptSubNote_DIVIDEND_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles rptSubNote_PLST_SALES.BeforePrint, _
        rptSubNote_PLST_OPENSTOCK.BeforePrint, rptSubNote_PLST_PURCHASE.BeforePrint, rptSubNote_EXPENSES_DEPRECIATION.BeforePrint, EXPENSES_ALLOW.BeforePrint, _
        rptSubNote_EXPENSES_NONALLOW.BeforePrint, rptSubNote_PLFST_CLOSESTOCK.BeforePrint, rptSubNote_NONSOURCE_BUSINESSINCOME.BeforePrint, _
        rptSubNote_INCOME_REALFET.BeforePrint, rptSubNote_DIVIDEND_INCOME.BeforePrint, rptSubNote_INCOME_NBINTEREST.BeforePrint, _
        rptSubNote_RENTAL_INCOME.BeforePrint, rptSubNote_INCOME_NBROYALTY.BeforePrint, rptSubNote_OTHER_INCOME.BeforePrint, _
        rptSubNote_INCOME_NTDISPOSALFA.BeforePrint, rptSubNote_INCOME_NTDISPOSALINVEST.BeforePrint, rptSubNote_EXEMPT_DIVIDEND.BeforePrint, _
        rptSubNote_INCOME_NTFOREIGNINCREM.BeforePrint, rptSubNote_INCOME_NTREALFE.BeforePrint, rptSubNote_INCOME_NTUREALFET.BeforePrint, _
        rptSubNote_INCOME_NTUREALFENT.BeforePrint, rptSubNote_NON_TAXABLE_INCOME.BeforePrint, rptSubNote_EXPENSES_INTERESTRESTRICT.BeforePrint, _
        rptSubNote_EXPENSES_INTEREST.BeforePrint, rptSubNote_EXPENSES_LEGAL.BeforePrint, rptSubNote_EXPENSES_TECH_FEE.BeforePrint, _
        rptSubNote_EXPENSES_CONTRACT.BeforePrint, rptSubNote_EXPENSES_DIRECTORS_FEE.BeforePrint, rptSubNote_EXPENSES_SALARY.BeforePrint, _
        rptSubNote_EXPENSES_EMPL_STOCK.BeforePrint, rptSubNote_EXPENSES_ROYALTY.BeforePrint, rptSubNote_EXPENSES_RENTAL.BeforePrint, _
        rptSubNote_EXPENSES_REPAIR.BeforePrint, rptSubNote_EXPENSES_RESEARCH.BeforePrint, rptSubNote_EXPENSES_PROMOTE.BeforePrint, _
        rptSubNote_EXPENSES_TRAVEL.BeforePrint, rptSubNote_EXPENSES_JKDM.BeforePrint, rptSubNote_OTHER_EXDEPRECIATION.BeforePrint, _
        rptSubNote_OTHER_EXAPPRDONATION.BeforePrint, rptSubNote_OTHER_EXNAPPRDONATION.BeforePrint, rptSubNote_OTHER_EXZAKAT.BeforePrint, _
        rptSubNote_OTHER_EXLOSSDISPOSALFA.BeforePrint, rptSubNote_OTHER_ENTERTAINNSTAFF.BeforePrint, rptSubNote_OTHER_ENTERTAINSTAFF.BeforePrint, _
        rptSubNote_OTHER_EXPENALTY.BeforePrint, rptSubNote_OTHER_EXPROVISIONACC.BeforePrint, rptSubNote_OTHER_EXLEAVEPASSAGE.BeforePrint, _
        rptSubNote_OTHER_EXFAWRITTENOFF.BeforePrint, rptSubNote_OTHER_EXURLOSSFOREIGN.BeforePrint, rptSubNote_OTHER_EXRLOSSFOREIGNT.BeforePrint, _
        rptSubNote_OTHER_EXRLOSSFOREIGN.BeforePrint, rptSubNote_OTHER_EXINITIALSUB.BeforePrint, rptSubNote_OTHER_EXCAPITALEXP.BeforePrint, _
        rptSubNote_OTHER_EXPENSES.BeforePrint

        Try
            If TypeOf sender Is DevExpress.XtraReports.UI.XRSubreport Then
                Dim subrpt As DevExpress.XtraReports.UI.XRSubreport = CType(sender, DevExpress.XtraReports.UI.XRSubreport)
                subrpt.ReportSource.DataSource = Me.DataSource
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class