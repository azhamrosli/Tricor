Imports DevExpress.XtraReports.UI

Public Class rptMovementComplexNew
    Dim Total As Decimal = 0
    Dim TotalWidth As Decimal = 2556
    Dim Default_Description As Decimal = 576.15
    Dim Default_Dynamic As Decimal = 345.96
    Dim Default_Total As Decimal = 293.69
    Dim Default_AddBack As Decimal = 324.79
    Dim Default_Note As Decimal = 197.79

    Dim Dynamic1 As Boolean = False
    Dim Dynamic2 As Boolean = False
    Dim Dynamic3 As Boolean = False
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If ADO Is Nothing Then
            ADO = New clsIODatabase
        End If
    End Sub

    Private Sub xrLabel1_SummaryReset(ByVal sender As Object, ByVal e As EventArgs) Handles Total_Total.SummaryReset, General_Total.SummaryReset, Specific_Total.SummaryReset, SpecificNon_Total.SummaryReset
        ' Reset the result each time a group is printed. 
        Total = 0
    End Sub

    Private Sub xrLabel1_SummaryRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Total_Total.SummaryRowChanged, General_Total.SummaryRowChanged, Specific_Total.SummaryRowChanged, SpecificNon_Total.SummaryRowChanged
        ' Calculate a summary. 
        Total = CDec(General_Total.Text) + CDec(Specific_Total.Text) + CDec(SpecificNon_Total.Text) '+ CDec(lblTotal.Text)
    End Sub

    Private Sub xrLabel1_SummaryGetResult(ByVal sender As Object, ByVal e As SummaryGetResultEventArgs) Handles Total_Total.SummaryGetResult
        ' Round the result, so that a pack will be taken into account  
        ' even if it contains only one unit. 
        Total = CDec(General_Total.Text) + CDec(Specific_Total.Text) + CDec(SpecificNon_Total.Text) '+ CDec(lblTotal.Text)
        e.Result = Total.ToString("N0")
        e.Handled = True
    End Sub

    Private Sub lblTotal_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Total_Head.BeforePrint
        Try
            Total_Head.Text = ((General_Head.Text) + CDec(Specific_Head.Text) + CDec(SpecificNon_Head.Text)).ToString("N0")
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    'Private Sub DetailReport_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles DetailReport.BeforePrint
    '    Try
    '        Try
    '            Dim dtAdd As DataTable = clsMoveNormal.Load_MovementComplex_Add(Me.paramParentID.Value)

    '            If dtAdd IsNot Nothing Then
    '                If dtAdd.Rows.Count > 1 Then
    '                    boxAdd.Visible = True
    '                Else
    '                    boxAdd.Visible = False
    '                End If
    '            End If


    '        Catch ex As Exception
    '            Dim st As New StackTrace(True)
    '            st = New StackTrace(ex, True)

    '        End Try
    '    Catch ex As Exception
    '        Dim st As New StackTrace(True)
    '        st = New StackTrace(ex, True)

    '    End Try
    'End Sub
    'Private Sub DetailReport1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles DetailReport1.BeforePrint
    '    Try
    '        Dim dtDeduct As DataTable = clsMoveNormal.Load_MovementComplex_Deduct(Me.paramParentID.Value)

    '        If dtDeduct IsNot Nothing Then
    '            If dtDeduct.Rows.Count > 1 Then
    '                boxDeduct.Visible = True
    '            Else
    '                boxDeduct.Visible = False
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Dim st As New StackTrace(True)
    '        st = New StackTrace(ex, True)

    '    End Try
    'End Sub
#Region "TOP_BOT"

#End Region
    Private Sub ProcessData()
        Try
            Dynamic1 = False
            Dynamic2 = False
            Dynamic3 = False

            Dim GrayColorFont As Color = Color.FromArgb(224, 224, 224)
            Dim BlackColorFont As Color = Color.Black

            Dim dt As DataTable = Nothing

            dt = ADO.Load_TotalAmount_General_Specific_MovementComplex(paramParentID.Value)

            If dt IsNot Nothing Then

                If IsDBNull(dt.Rows(0)("MM_GENERAL")) = False AndAlso CDec(dt.Rows(0)("MM_GENERAL")) > 0 Then
                    Dynamic1 = True
                Else
                    Dynamic1 = False
                End If

                If IsDBNull(dt.Rows(0)("MM_SPECIFIC_ALLOWABLE")) = False AndAlso CDec(dt.Rows(0)("MM_SPECIFIC_ALLOWABLE")) > 0 Then
                    Dynamic2 = True
                Else
                    Dynamic2 = False
                End If

                If IsDBNull(dt.Rows(0)("MM_SPECIFIC_NONALLOWABLE")) = False AndAlso CDec(dt.Rows(0)("MM_SPECIFIC_NONALLOWABLE")) > 0 Then
                    Dynamic3 = True
                Else
                    Dynamic3 = False
                End If
            End If
            Application.DoEvents()

            If Dynamic1 = True Then
                'General_Top.Visible = True
                'General_Bot.Visible = True
                'General_Head.Visible = True
                'General_ADD_Details.Visible = True
                'General_ADD_Total.Visible = True
                'General_Deduct_Details.Visible = True
                'General_Deduct_Total.Visible = True
                'General_Total.Visible = True

                General_Top.ForeColor = BlackColorFont
                General_Bot.ForeColor = BlackColorFont
                General_Head.ForeColor = BlackColorFont
                General_ADD_Details.ForeColor = BlackColorFont
                General_ADD_Total.ForeColor = BlackColorFont
                General_Deduct_Details.ForeColor = BlackColorFont
                General_Deduct_Total.ForeColor = BlackColorFont
                General_Total.ForeColor = BlackColorFont

                General_Top.WidthF = Default_Dynamic
                General_Bot.WidthF = Default_Dynamic
                General_Head.WidthF = Default_Dynamic
                General_ADD_Details.WidthF = Default_Dynamic
                General_ADD_Total.WidthF = Default_Dynamic
                General_Deduct_Details.WidthF = Default_Dynamic
                General_Deduct_Total.WidthF = Default_Dynamic
                General_Total.WidthF = Default_Dynamic
            Else
                'General_Top.Visible = False
                'General_Bot.Visible = False
                'General_Head.Visible = False
                'General_ADD_Details.Visible = False
                'General_ADD_Total.Visible = False
                'General_Deduct_Details.Visible = False
                'General_Deduct_Total.Visible = False
                'General_Total.Visible = False

                General_Top.ForeColor = GrayColorFont
                General_Bot.ForeColor = GrayColorFont
                General_Head.ForeColor = GrayColorFont
                General_ADD_Details.ForeColor = GrayColorFont
                General_ADD_Total.ForeColor = GrayColorFont
                General_Deduct_Details.ForeColor = GrayColorFont
                General_Deduct_Total.ForeColor = GrayColorFont
                General_Total.ForeColor = GrayColorFont

                General_Top.WidthF = 5
                General_Bot.WidthF = 5
                General_Head.WidthF = 5
                General_ADD_Details.WidthF = 5
                General_ADD_Total.WidthF = 5
                General_Deduct_Details.WidthF = 5
                General_Deduct_Total.WidthF = 5
                General_Total.WidthF = 5
            End If

            If Dynamic2 = True Then
                'Specific_Top.Visible = True
                'Specific_Bot.Visible = True
                'Specific_Head.Visible = True
                'Specific_ADD_Details.Visible = True
                'Specific_ADD_Total.Visible = True
                'Specific_Deduct_Details.Visible = True
                'Specific_Deduct_Total.Visible = True
                'Specific_Total.Visible = True

                Specific_Top.ForeColor = BlackColorFont
                Specific_Bot.ForeColor = BlackColorFont
                Specific_Head.ForeColor = BlackColorFont
                Specific_ADD_Details.ForeColor = BlackColorFont
                Specific_ADD_Total.ForeColor = BlackColorFont
                Specific_Deduct_Details.ForeColor = BlackColorFont
                Specific_Deduct_Total.ForeColor = BlackColorFont
                Specific_Total.ForeColor = BlackColorFont

                Specific_Top.WidthF = Default_Dynamic
                Specific_Bot.WidthF = Default_Dynamic
                Specific_Head.WidthF = Default_Dynamic
                Specific_ADD_Details.WidthF = Default_Dynamic
                Specific_ADD_Total.WidthF = Default_Dynamic
                Specific_Deduct_Details.WidthF = Default_Dynamic
                Specific_Deduct_Total.WidthF = Default_Dynamic
                Specific_Total.WidthF = Default_Dynamic
            Else
                'Specific_Top.Visible = False
                'Specific_Bot.Visible = False
                'Specific_Head.Visible = False
                'Specific_ADD_Details.Visible = False
                'Specific_ADD_Total.Visible = False
                'Specific_Deduct_Details.Visible = False
                'Specific_Deduct_Total.Visible = False
                'Specific_Total.Visible = False

                Specific_Top.ForeColor = GrayColorFont
                Specific_Bot.ForeColor = GrayColorFont
                Specific_Head.ForeColor = GrayColorFont
                Specific_ADD_Details.ForeColor = GrayColorFont
                Specific_ADD_Total.ForeColor = GrayColorFont
                Specific_Deduct_Details.ForeColor = GrayColorFont
                Specific_Deduct_Total.ForeColor = GrayColorFont
                Specific_Total.ForeColor = GrayColorFont

                Specific_Top.WidthF = 5
                Specific_Bot.WidthF = 5
                Specific_Head.WidthF = 5
                Specific_ADD_Details.WidthF = 5
                Specific_ADD_Total.WidthF = 5
                Specific_Deduct_Details.WidthF = 5
                Specific_Deduct_Total.WidthF = 5
                Specific_Total.WidthF = 5
            End If

            If Dynamic3 = True Then
                'SpecificNon_Top.Visible = True
                'SpecificNon_Bot.Visible = True
                'SpecificNon_Head.Visible = True
                'SpecificNon_ADD_Details.Visible = True
                'SpecificNon_ADD_Total.Visible = True
                'SpecificNon_Deduct_Details.Visible = True
                'SpecificNon_Deduct_Total.Visible = True
                'SpecificNon_Total.Visible = True

                SpecificNon_Top.ForeColor = BlackColorFont
                SpecificNon_Bot.ForeColor = BlackColorFont
                SpecificNon_Head.ForeColor = BlackColorFont
                SpecificNon_ADD_Details.ForeColor = BlackColorFont
                SpecificNon_ADD_Total.ForeColor = BlackColorFont
                SpecificNon_Deduct_Details.ForeColor = BlackColorFont
                SpecificNon_Deduct_Total.ForeColor = BlackColorFont
                SpecificNon_Total.ForeColor = BlackColorFont

                SpecificNon_Top.WidthF = Default_Dynamic
                SpecificNon_Bot.WidthF = Default_Dynamic
                SpecificNon_Head.WidthF = Default_Dynamic
                SpecificNon_ADD_Details.WidthF = Default_Dynamic
                SpecificNon_ADD_Total.WidthF = Default_Dynamic
                SpecificNon_Deduct_Details.WidthF = Default_Dynamic
                SpecificNon_Deduct_Total.WidthF = Default_Dynamic
                SpecificNon_Total.WidthF = Default_Dynamic
            Else
                'SpecificNon_Top.Visible = True
                'SpecificNon_Bot.Visible = True
                'SpecificNon_Head.Visible = True
                'SpecificNon_ADD_Details.Visible = True
                'SpecificNon_ADD_Total.Visible = True
                'SpecificNon_Deduct_Details.Visible = True
                'SpecificNon_Deduct_Total.Visible = True
                'SpecificNon_Total.Visible = True

                SpecificNon_Top.ForeColor = GrayColorFont
                SpecificNon_Bot.ForeColor = GrayColorFont
                SpecificNon_Head.ForeColor = GrayColorFont
                SpecificNon_ADD_Details.ForeColor = GrayColorFont
                SpecificNon_ADD_Total.ForeColor = GrayColorFont
                SpecificNon_Deduct_Details.ForeColor = GrayColorFont
                SpecificNon_Deduct_Total.ForeColor = GrayColorFont
                SpecificNon_Total.ForeColor = GrayColorFont

                SpecificNon_Top.WidthF = 5
                SpecificNon_Bot.WidthF = 5
                SpecificNon_Head.WidthF = 5
                SpecificNon_ADD_Details.WidthF = 5
                SpecificNon_ADD_Total.WidthF = 5
                SpecificNon_Deduct_Details.WidthF = 5
                SpecificNon_Deduct_Total.WidthF = 5
                SpecificNon_Total.WidthF = 5
            End If

            'Total
            Total_Top.Visible = True
            Total_Bot.Visible = True
            Total_Head.Visible = True
            Total_ADD_Details.Visible = True
            Total_ADD_Total.Visible = True
            Total_Deduct_Details.Visible = True
            Total_Deduct_Total.Visible = True
            Total_Total.Visible = True

            Total_Top.WidthF = Default_Total
            Total_Bot.WidthF = Default_Total
            Total_Head.WidthF = Default_Total
            Total_ADD_Details.WidthF = Default_Total
            Total_ADD_Total.WidthF = Default_Total
            Total_Deduct_Details.WidthF = Default_Total
            Total_Deduct_Total.WidthF = Default_Total
            Total_Total.WidthF = Default_Total

            'Add Back
            AddBack_Top.Visible = True
            AddBack_Bot.Visible = True
            AddBack_Head.Visible = True
            AddBack_ADD_Details.Visible = True
            AddBack_ADD_Total.Visible = True
            AddBack_Deduct_Details.Visible = True
            AddBack_Deduct_Total.Visible = True
            AddBack_Total.Visible = True

            AddBack_Top.WidthF = Default_AddBack
            AddBack_Bot.WidthF = Default_AddBack
            AddBack_Head.WidthF = Default_AddBack
            AddBack_ADD_Details.WidthF = Default_AddBack
            AddBack_ADD_Total.WidthF = Default_AddBack
            AddBack_Deduct_Details.WidthF = Default_AddBack
            AddBack_Deduct_Total.WidthF = Default_AddBack
            AddBack_Total.WidthF = Default_AddBack

            'Add Back
            Note_Top.Visible = True
            Note_Bot.Visible = True
            Note_Head.Visible = True
            Note_ADD_Details.Visible = True
            Note_ADD_Total.Visible = True
            Note_Deduct_Details.Visible = True
            Note_Deduct_Total.Visible = True
            Note_Total.Visible = True

            Note_Top.WidthF = Default_Note
            Note_Bot.WidthF = Default_Note
            Note_Head.WidthF = Default_Note
            Note_ADD_Details.WidthF = Default_Note
            Note_ADD_Total.WidthF = Default_Note
            Note_Deduct_Details.WidthF = Default_Note
            Note_Deduct_Total.WidthF = Default_Note
            Note_Total.WidthF = Default_Note

            Dim TotalLine As Decimal = General_Top.WidthF + Specific_Top.WidthF + SpecificNon_Top.WidthF + Total_Top.WidthF + AddBack_Top.WidthF
            line_Top.WidthF = TotalLine
            line_Bot.WidthF = TotalLine

            line_Top.LocationF = New PointF(General_Top.LocationF.X, 0)
            line_Bot.LocationF = New PointF(General_Top.LocationF.X, 89.06)

            'line_SubTop.LocationF = New PointF(General_Top.LocationF.X, 0)
            'line_SubTop.WidthF = TotalLine


            'If General_Top.Text.Contains("(") Then
            '    General_Top.Text = General_Top.Text.Replace("(", vbCrLf & "(")
            'End If
            'If Specific_Top.Text.Contains("(") Then
            '    Specific_Top.Text = Specific_Top.Text.Replace("(", vbCrLf & "(")
            'End If
            'If SpecificNon_Top.Text.Contains("(") Then
            '    SpecificNon_Top.Text = SpecificNon_Top.Text.Replace("(", vbCrLf & "(")
            'End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Top_Bot_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles General_Top.BeforePrint, General_Bot.BeforePrint,
        General_Head.BeforePrint, General_ADD_Details.BeforePrint, General_ADD_Total.BeforePrint, General_Deduct_Details.BeforePrint,
        General_Deduct_Total.BeforePrint, General_Total.BeforePrint

        Try
            ProcessData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Top_Bot2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Specific_Top.BeforePrint, Specific_Bot.BeforePrint,
        Specific_Head.BeforePrint, Specific_ADD_Details.BeforePrint, Specific_ADD_Total.BeforePrint, Specific_Deduct_Details.BeforePrint,
        Specific_Deduct_Total.BeforePrint, Specific_Total.BeforePrint

        Try
            ProcessData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Top_Bot3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles SpecificNon_Top.BeforePrint, SpecificNon_Bot.BeforePrint,
        SpecificNon_Head.BeforePrint, SpecificNon_ADD_Details.BeforePrint, SpecificNon_ADD_Total.BeforePrint, SpecificNon_Deduct_Details.BeforePrint,
        SpecificNon_Deduct_Total.BeforePrint, SpecificNon_Total.BeforePrint

        Try
            ProcessData()
        Catch ex As Exception

        End Try
    End Sub
End Class