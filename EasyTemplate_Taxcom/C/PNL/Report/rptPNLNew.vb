Public Class rptPNLNew

    'Private Sub lblTitleExpenses_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitleExpenses.BeforePrint
    '    Try
    '        If lblTitleExpenses.Text = "0" Then
    '            P3TotalExpenses.Visible = False
    '        Else
    '            P3TotalExpenses.Visible = True
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Function ValidationRowCountTotal(ByVal ListOfTotal As List(Of Decimal)) As Boolean
        Try
            Dim RowCount As Integer = 0

            For Each Nox As Decimal In ListOfTotal

                If IsNumeric(Nox) AndAlso Nox > 0 Then
                    RowCount += 1
                End If

            Next

            If RowCount <= 1 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            Return True
        End Try
    End Function

    Private Sub Total_PRO_COST_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Total_PRO_COST.BeforePrint
        Try
            Dim ListofDec As New List(Of Decimal)

            If IsDBNull(Me.GetCurrentColumnValue("PL_PRO_COST_DPC")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_PRO_COST_DPC")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_PRO_COST_DPC"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_PRO_COST_OAE")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_PRO_COST_OAE")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_PRO_COST_OAE"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_PRO_COST_ONAE")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_PRO_COST_ONAE")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_PRO_COST_ONAE"))
            Else
                ListofDec.Add(0)
            End If

            Total_PRO_COST.Visible = ValidationRowCountTotal(ListofDec)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub P2TotalBizIncone_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles P2TotalBizIncone.BeforePrint
        Try
            Dim ListofDec As New List(Of Decimal)

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTH_IN_DIVIDEND")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTH_IN_DIVIDEND")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTH_IN_DIVIDEND"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTH_IN_INTEREST")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTH_IN_INTEREST")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTH_IN_INTEREST"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTH_IN_RENTAL")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTH_IN_RENTAL")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTH_IN_RENTAL"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTH_IN_ROYALTY")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTH_IN_ROYALTY")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTH_IN_ROYALTY"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTH_IN_OTHER")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTH_IN_OTHER")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTH_IN_OTHER"))
            Else
                ListofDec.Add(0)
            End If


            P2TotalBizIncone.Visible = ValidationRowCountTotal(ListofDec)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TOTAL_FOREIGN_OTHER_INCOME_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TOTAL_FOREIGN_OTHER_INCOME.BeforePrint
        Try
            Dim ListofDec As New List(Of Decimal)

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTH_BSIN_REALGT")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTH_BSIN_REALGT")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTH_BSIN_REALGT"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTH_BSIN")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTH_BSIN")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTH_BSIN"))
            Else
                ListofDec.Add(0)
            End If

            TOTAL_FOREIGN_OTHER_INCOME.Visible = ValidationRowCountTotal(ListofDec)
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub P2TotalNonTaxableIncome_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles P2TotalNonTaxableIncome.BeforePrint
        Try
            Dim ListofDec As New List(Of Decimal)

            If IsDBNull(Me.GetCurrentColumnValue("PL_NONTAX_IN_FA_DISP")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_NONTAX_IN_FA_DISP")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_NONTAX_IN_FA_DISP"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_NONTAX_IN_INV_DISP")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_NONTAX_IN_INV_DISP")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_NONTAX_IN_INV_DISP"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_NONTAX_IN_EXM_DIV")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_NONTAX_IN_EXM_DIV")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_NONTAX_IN_EXM_DIV"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_NONTAX_IN_FIR")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_NONTAX_IN_FIR")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_NONTAX_IN_FIR"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_NONTAX_IN_REALG")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_NONTAX_IN_REALG")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_NONTAX_IN_REALG"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTH_BSIN_UNREALGT")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTH_BSIN_UNREALGT")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTH_BSIN_UNREALGT"))
            Else
                ListofDec.Add(0)
            End If

            P2TotalNonTaxableIncome.Visible = ValidationRowCountTotal(ListofDec)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TOTAL_EXP_INTEREST_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TOTAL_EXP_INTEREST.BeforePrint
        Try
            Dim ListofDec As New List(Of Decimal)

            If IsDBNull(Me.GetCurrentColumnValue("PL_EXP_INTRESTRICT")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_EXP_INTRESTRICT")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_EXP_INTRESTRICT"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_EXP_INT")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_EXP_INT")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_EXP_INT"))
            Else
                ListofDec.Add(0)
            End If

            TOTAL_EXP_INTEREST.Visible = ValidationRowCountTotal(ListofDec)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub P3TotalExpenses_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles P3TotalExpenses.BeforePrint
        Try
            Dim ListofDec As New List(Of Decimal)

            If IsDBNull(Me.GetCurrentColumnValue("PL_LAWYER_COST")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_LAWYER_COST")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_LAWYER_COST"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_TECH_FEE")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_TECH_FEE")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_TECH_FEE"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_CONTRACT_EXP")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_CONTRACT_EXP")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_CONTRACT_EXP"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_DIRECTORS_FEE")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_DIRECTORS_FEE")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_DIRECTORS_FEE"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_EXP_SALARY")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_EXP_SALARY")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_EXP_SALARY"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_EMPL_STOCK")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_EMPL_STOCK")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_EMPL_STOCK"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_ROYALTY")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_ROYALTY")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_ROYALTY"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_EXP_RENT")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_EXP_RENT")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_EXP_RENT"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_EXP_MAINTENANCE")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_EXP_MAINTENANCE")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_EXP_MAINTENANCE"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_RND")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_RND")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_RND"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_ADVERT")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_ADVERT")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_ADVERT"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_TRAVEL")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_TRAVEL")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_TRAVEL"))
            Else
                ListofDec.Add(0)
            End If

            If isVersionLicenseType = VersionLicenseType.Tricor Then
                If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_UNREALOSS")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_UNREALOSS")) Then
                    ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_UNREALOSS"))
                Else
                    ListofDec.Add(0)
                End If
            End If
           

            If IsDBNull(Me.GetCurrentColumnValue("PL_JKDM")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_JKDM")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_JKDM"))
            Else
                ListofDec.Add(0)
            End If


            P3TotalExpenses.Visible = ValidationRowCountTotal(ListofDec)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TotalOtherExpenditure_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TotalOtherExpenditure.BeforePrint
        Try
            Dim ListofDec As New List(Of Decimal)

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_DPC")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_DPC")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_DPC"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_DNT_APP")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_DNT_APP")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_DNT_APP"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_DNT_NAPP")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_DNT_NAPP")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_DNT_NAPP"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_ZAKAT")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_ZAKAT")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_ZAKAT"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_FA_DISP")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_FA_DISP")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_FA_DISP"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_ENTM_CLNT")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_ENTM_CLNT")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_ENTM_CLNT"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_ENTM_STFF")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_ENTM_STFF")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_ENTM_STFF"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_PENALTY")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_PENALTY")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_PENALTY"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_PROV_ACC")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_PROV_ACC")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_PROV_ACC"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_LEAVE")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_LEAVE")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_LEAVE"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_FA_WO")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_FA_WO")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_FA_WO"))
            Else
                ListofDec.Add(0)
            End If

            If isVersionLicenseType = VersionLicenseType.Normal Then
                If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_UNREALOSS")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_UNREALOSS")) Then
                    ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_UNREALOSS"))
                Else
                    ListofDec.Add(0)
                End If
            End If
            
            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_REALOSS")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_REALOSS")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_REALOSS"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXRLOSSFOREIGNT")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXRLOSSFOREIGNT")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXRLOSSFOREIGNT"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_INI_SUB")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_INI_SUB")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_INI_SUB"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_CAP_EXP")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_CAP_EXP")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_CAP_EXP"))
            Else
                ListofDec.Add(0)
            End If

            If IsDBNull(Me.GetCurrentColumnValue("PL_OTHER_EXP_OTHERS")) = False AndAlso IsNumeric(Me.GetCurrentColumnValue("PL_OTHER_EXP_OTHERS")) Then
                ListofDec.Add(Me.GetCurrentColumnValue("PL_OTHER_EXP_OTHERS"))
            Else
                ListofDec.Add(0)
            End If

            TotalOtherExpenditure.Visible = ValidationRowCountTotal(ListofDec)
        Catch ex As Exception

        End Try
    End Sub
End Class