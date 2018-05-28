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

Public Class frmCA_Report
    Dim clsNote As clsNote_CA = Nothing
    Dim ErrorLog As clsError = Nothing
    Public ID As String = ""
    Public RefNo As String = ""
    Public YA As String = ""
    Public ComName As String = ""
    Public TypeReport As Integer = 0
    Public isDirectPrint As Boolean = True
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
            ADO.Delete_CA_Report_TEMP(ID)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmCA_ReportList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadData()
        Try
            Dim dt As DataTable = Nothing

            Select Case TypeReport
                Case 0, 1, 2
                    dt = ADO.Load_CAReport_Temp(ID, CInt(YA))
                Case 3, 4, 5
                    dt = ADO.Load_CAReportSummary2_Temp(ID)
            End Select



            DsCA.Tables("CA_REPORT_TEMP").Rows.Clear()
            DsCA1.Tables("CA_REPORT_TEMP").Rows.Clear()
            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    DsCA.Tables("CA_REPORT_TEMP").ImportRow(dt.Rows(i))
                    DsCA1.Tables("CA_REPORT_TEMP").ImportRow(dt.Rows(i))
                Next
            End If



            Application.DoEvents()
            BandedGridView1.BeginSort()
            Select Case TypeReport
                Case 0
                    'Capital Allowance Details By Rate
                    Dim col1 As GridColumn = BandedGridView1.Columns("CA_TRANSFERROR_NAME")
                    Dim col2 As GridColumn = BandedGridView1.Columns("CA_PURCHASE_YEAR")
                    Dim col3 As GridColumn = BandedGridView1.Columns("CA_RATE_AA")

                    BandedGridView1.ClearGrouping()
                    col1.GroupIndex = 0
                    col2.GroupIndex = 1
                    col2.GroupIndex = 2
                Case 1
                    'Capital Allowance Details By Category
                    Dim col1 As GridColumn = BandedGridView1.Columns("CA_TRANSFERROR_NAME")
                    Dim col2 As GridColumn = BandedGridView1.Columns("CA_CATEGORY_CODE")
                    Dim col3 As GridColumn = BandedGridView1.Columns("CA_PURCHASE_YEAR")
                    Dim col4 As GridColumn = BandedGridView1.Columns("CA_RATE_AA")

                    BandedGridView1.ClearGrouping()
                    col1.GroupIndex = 0
                    col2.GroupIndex = 1
                    col3.GroupIndex = 2
                    col4.GroupIndex = 3

                    'BandedGridView1.SortInfo.ClearAndAddRange(New GridColumnSortInfo() {
                    '        New GridColumnSortInfo(col1, DevExpress.Data.ColumnSortOrder.Ascending),
                    '        New GridColumnSortInfo(col2, DevExpress.Data.ColumnSortOrder.Ascending)
                    '})

                Case 2, 5
                    'Capital Allowance Details By Asset
                    Dim col1 As GridColumn = BandedGridView1.Columns("CA_TRANSFERROR_NAME")
                    Dim col2 As GridColumn = BandedGridView1.Columns("YA")
                    Dim col3 As GridColumn = BandedGridView1.Columns("CA_ASSET")


                    BandedGridView1.ClearGrouping()
                    col1.GroupIndex = 0
                    col2.GroupIndex = 1

                    'BandedGridView1.SortInfo.ClearAndAddRange(New GridColumnSortInfo() {
                    '        New GridColumnSortInfo(col1, DevExpress.Data.ColumnSortOrder.Ascending),
                    '        New GridColumnSortInfo(col2, DevExpress.Data.ColumnSortOrder.Ascending)
                    '})
                Case 3
                    Dim col1 As GridColumn = BandedGridView1.Columns("CA_RATE_AA")
                    Dim col2 As GridColumn = BandedGridView1.Columns("CA_PURCHASE_YEAR")

                    BandedGridView1.ClearGrouping()
                    col1.GroupIndex = 0
                    col2.GroupIndex = 1
                Case 4
                    Dim col1 As GridColumn = BandedGridView1.Columns("CA_CATEGORY_CODE")
                    Dim col2 As GridColumn = BandedGridView1.Columns("CA_RATE_AA")
                    Dim col3 As GridColumn = BandedGridView1.Columns("CA_PURCHASE_YEAR")

                    BandedGridView1.ClearGrouping()
                    col1.GroupIndex = 0
                    col2.GroupIndex = 1
                    col3.GroupIndex = 2
            End Select
            BandedGridView1.EndSort()


            If isDirectPrint Then
                PrintExport(False)
                Application.DoEvents()

                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        PrintExport(False)
    End Sub
    Private Sub PrintExport(ByVal isExport As Boolean)
        Try
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

                Dim dtNote As DataTable = Nothing
                Dim dtNote_Child As DataTable = Nothing
                Dim tmpNoteID As Integer = 0

                Dim Ext As String = Nothing
                Dim dtRowAtt As Byte() = Nothing
                Dim i As Integer = -1


                DsCA.Tables("CA_NOTE_ATTACHMENT").Rows.Clear()
                DsCA.Tables("CA_NOTE_COLUMN").Rows.Clear()
                DsCA.Tables("CA_NOTE").Rows.Clear()


                Select Case TypeReport
                    Case 0, 3
                        'Capital Allowance Details By Rate
                        Dim rpt As rpt_CAByRate

                        If mdlProcess.PrintReport_CAByRate(DsCA, ComName, YA, rpt, errorlog) Then
                            If isExport Then
                                rpt.ExportToXlsx(Path)
                            Else
                                rpt.ShowPreview()
                            End If
                        Else
                            MsgBox("Failed to load capital allowance report.", MsgBoxStyle.Critical)
                        End If

                    Case 1, 4
                        'Capital Allowance Details By Category
                        Dim rpt As rpt_CAByCategory

                        If mdlProcess.PrintReport_CAByCategory(DsCA, ComName, YA, rpt, ErrorLog) Then
                            If isExport Then
                                rpt.ExportToXlsx(Path)
                            Else
                                rpt.ShowPreview()
                            End If
                        Else
                            MsgBox("Failed to load capital allowance report.", MsgBoxStyle.Critical)
                        End If

                    Case 2, 5
                        'Capital Allowance Details By Asset
                        Dim rpt As rptCAReport

                        If mdlProcess.PrintReport_CAByAsset(DsCA, ComName, YA, rpt, ErrorLog) Then
                            If isExport Then
                                rpt.ExportToXlsx(Path)
                            Else
                                rpt.ShowPreview()
                            End If
                        Else
                            MsgBox("Failed to load capital allowance report.", MsgBoxStyle.Critical)
                        End If
                End Select

                If isExport Then
                    MsgBox("Succesfully export report to " & vbCrLf & Path, MsgBoxStyle.Information)
                End If


            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
            PrintExport(True)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Grid_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs)
        Try
            Dim pb As PanelBrick = New PanelBrick
            pb.Rect = New RectangleF(0, 0, 111, 111)
            e.Graph.DrawBrick(pb)

        Catch ex As Exception

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

        End Try
    End Sub

    Private Sub btnCollepase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCollepase.ItemClick
        Try
            BandedGridView1.CollapseAllGroups()


        Catch ex As Exception

        End Try
    End Sub
End Class