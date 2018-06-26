Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Columns
Imports System.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting.Links
Imports DevExpress.XtraPrintingLinks
Imports System.Drawing.Printing

Public Class frmCA_Report_FA_Reconciliation
    Public ID As String = ""
    Public RefNo As String = ""
    Public YA As String = ""
    Public ComName As String = ""
    Public TypeReport As Integer = 0
    Dim link As PrintableComponentLink
    Private Sub frmCA_ReportList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub LoadData()
        Try
            Dim dt As DataTable = Nothing

            Select Case TypeReport
                Case 6
                    dt = ADO.Load_CAReport_FAReconciliation_Temp(ID, YA)
            End Select



            DsCA.Tables("CA_REPORT_FIXEDASSET_TEMP").Rows.Clear()
            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    DsCA.Tables("CA_REPORT_FIXEDASSET_TEMP").ImportRow(dt.Rows(i))
                Next
            End If

            ADO.Delete_CA_Report_FAReconciliation_TEMP(ID)

            Application.DoEvents()
            BandedGridView1.BeginSort()
            Select Case TypeReport
                Case 6
                    Dim col1 As GridColumn = BandedGridView1.Columns("CA_ASSET_CODE")
                    Dim col2 As GridColumn = BandedGridView1.Columns("CA_PURCHASE_YEAR")
                    Dim col3 As GridColumn = BandedGridView1.Columns("CA_RATE_AA")

                    BandedGridView1.ClearGrouping()
                    col1.GroupIndex = 0
                    col2.GroupIndex = 1
                    col3.GroupIndex = 2
            End Select
            BandedGridView1.EndSort()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Try

            'Dim str As String = vbCrLf & ComName & vbCrLf & "Reference No : C" & RefNo & vbCrLf & "Year of Assessment :" & YA
            'BandedGridView1.OptionsPrint.RtfPageHeader &= str

            '  GridControl1.PrintDialog()
            '  GridControl1.ShowPrintPreview()
            Dim link As New PrintableComponentLink(New PrintingSystem())
            AddHandler link.CreateReportHeaderArea, AddressOf Link_CreateReportHeaderArea

            link.Component = GridControl1

            link.Landscape = True

            link.ShowPreview()


        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
            Dim rslt As DialogResult = FolderBrowserDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then
                Dim Path As String = FolderBrowserDialog1.SelectedPath

                GridControl1.ExportToXlsx(Path & "\CA_REPORT_FA_" & Format(Now, "ddMMMyyyyHHmmss") & ".xlsx")
            End If



        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub Link_CreateReportHeaderArea(sender As Object, e As CreateAreaEventArgs)
        Dim reportHeader As String = "Fixed Asset Reconciliation Report"
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 16, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.Bottom)

        Dim reportHeader1 As String = ComName
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec1 As RectangleF = New RectangleF(0, 30, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader1, Color.Black, rec1, BorderSide.None)

        Dim reportHeader2 As String = "Reference No : " & RefNo
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec2 As RectangleF = New RectangleF(0, 50, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader2, Color.Black, rec2, BorderSide.None)

        Dim reportHeader3 As String = "Year of Assessment : " & YA
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec3 As RectangleF = New RectangleF(0, 70, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader3, Color.Black, rec3, BorderSide.None)
    End Sub

    Private Sub btnExpand_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExpand.ItemClick
        Try
            BandedGridView1.ExpandAllGroups()

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnCollepase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCollepase.ItemClick
        Try
            BandedGridView1.CollapseAllGroups()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
End Class