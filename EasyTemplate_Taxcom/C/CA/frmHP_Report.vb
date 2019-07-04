Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Columns
Imports System.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting.Links
Imports DevExpress.XtraPrintingLinks
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.ReportGeneration
Imports DevExpress.XtraReports.UI

Public Class frmHP_Report
    Dim clsNote As clsNote_CA = Nothing

    Dim clsErrorLog As ClsError = Nothing

    Public ID As String = ""
    Public RefNo As String = ""
    Public YA As String = ""
    Public ComName As String = ""
    Public TypeReport As Integer = 0
    Dim link As PrintableComponentLink
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If clsNote Is Nothing Then
            clsNote = New clsNote_CA
        End If
    End Sub
    Private Sub frmCA_Report_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            ADO.Delete_HP_Report_TEMP(ID)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
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

            dt = ADO.Load_HPReport_Temp(ID, CInt(YA))



            DsCA.Tables("HP_REPORT_TEMP").Rows.Clear()
            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    DsCA.Tables("HP_REPORT_TEMP").ImportRow(dt.Rows(i))
                Next
            End If



            Application.DoEvents()
            BandedGridView1.BeginSort()
            'Capital Allowance Details By Rate
            Dim col1 As GridColumn = BandedGridView1.Columns("CA_CATEGORY_CODE")
            BandedGridView1.ClearGrouping()
            col1.GroupIndex = 0
            BandedGridView1.EndSort()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        PrintExport(False)
    End Sub
    Private Sub PrintExport(ByVal isExport As Boolean)
        Try

            Dim Path As String = Nothing
            If isExport Then
                SaveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"
                Dim rslt As DialogResult = SaveFileDialog1.ShowDialog

                If rslt = Windows.Forms.DialogResult.OK Then
                    Path = SaveFileDialog1.FileName
                Else
                    Exit Sub
                End If
            End If

            'Capital Allowance Details By Rate
            Dim rpt As rpt_HP
            Dim rpt_Note As rptCA_Note
            Dim Title As String = ADO.Load_TableOfContent_Title(RefNo, YA, "rpt_HP")
            If mdlProcess.PrintReport_HP(DsCA, Title, ComName, YA, False, rpt, rpt_Note, clsErrorLog) Then
                Dim minPageCount As Integer = Math.Min(rpt.Pages.Count, rpt_Note.Pages.Count)

                Dim x As Integer = 0

                For Each pg As DevExpress.XtraPrinting.Page In rpt_Note.Pages
                    rpt.Pages.Add(pg)
                Next
                If isExport Then
                    rpt.ExportToXlsx(Path)
                Else
                    rpt.ShowPreview()
                End If

                If isExport Then
                    MsgBox("Succesfully export report to " & vbCrLf & Path, MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Failed to load hire purchase report.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
            PrintExport(True)

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Grid_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs)
        Try
            Dim pb As PanelBrick = New PanelBrick With {
                .Rect = New RectangleF(0, 0, 111, 111)
            }
            e.Graph.DrawBrick(pb)

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Link_CreateReportHeaderArea(sender As Object, e As CreateAreaEventArgs)
        Dim reportHeader As String = "Capital Allowance"
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