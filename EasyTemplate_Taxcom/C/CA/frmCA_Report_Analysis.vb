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

Public Class frmCA_Report_Analysis

    Dim clsNote As clsNote_CA = Nothing
    Dim ErrorLog As ClsError
    Public ID As String = ""
    Public RefNo As String = ""
    Public YA As String = ""
    Public ComName As String = ""
    Public TypeReport As Integer = 0
    Dim link As PrintableComponentLink
    Dim isFirstTime As Boolean = False
    Dim ds As dsCA
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
        Finally
            Application.DoEvents()
            If AutoBot_Allow = True AndAlso My.Computer.Name = DeveloperPCName Then
                btnPrint.PerformClick()
            End If
        End Try
    End Sub

    Private Sub LoadData()
        Try

            Dim dt As DataTable = Nothing

            Select Case TypeReport
                Case 13
                    dt = ADO.Load_CAReport_Analysis_Temp(ID)
            End Select

            ds = New dsCA
            Dim dtTable As New DataTable("CA_REPORT_ANALYSIS_PROPERTY_2")
            Dim col As DataColumn

            col = Nothing
            col = New DataColumn With {
                .ColumnName = "CA_DESCRIPTION",
                .Caption = "Description",
                .DataType = System.Type.GetType("System.String"),
                .MaxLength = 255
            }
            dtTable.Columns.Add(col)

            col = Nothing
            col = New DataColumn With {
                .ColumnName = "YA",
                .Caption = "YA",
                .DataType = System.Type.GetType("System.Int32")
            }
            dtTable.Columns.Add(col)

            col = New DataColumn With {
                .ColumnName = "CA_CATEGORY",
                .Caption = "Category",
                .DataType = System.Type.GetType("System.String"),
                .MaxLength = 255
            }
            dtTable.Columns.Add(col)

            col = Nothing
            col = New DataColumn With {
                .ColumnName = "CA_INCENTIVE_TITLE"
            }
            If dt IsNot Nothing Then
                col.Caption = IIf(IsDBNull(dt.Rows(0)("CA_INCENTIVE_TITLE")), "RA/ITA", dt.Rows(0)("CA_INCENTIVE_TITLE"))
            Else
                col.Caption = "RA/ITA"
            End If
            col.DataType = System.Type.GetType("System.String")
            dtTable.Columns.Add(col)

            col = New DataColumn With {
                .ColumnName = "CA_INCENTIVE"
            }
            If dt IsNot Nothing Then
                col.Caption = IIf(IsDBNull(dt.Rows(0)("CA_INCENTIVE_TITLE")), "RA/ITA", dt.Rows(0)("CA_INCENTIVE_TITLE"))
            Else
                col.Caption = "RA/ITA"
            End If
            col.DataType = System.Type.GetType("System.Decimal")
            dtTable.Columns.Add(col)

            col = New DataColumn With {
                .ColumnName = "CA_QUALIFYING_COST",
                .Caption = "Cost",
                .DataType = System.Type.GetType("System.Decimal")
            }
            dtTable.Columns.Add(col)

            col = New DataColumn With {
                .ColumnName = "CA_REC",
                .Caption = "Revenue Expenditure Capitalised",
                .DataType = System.Type.GetType("System.Decimal")
            }
            dtTable.Columns.Add(col)

            col = New DataColumn With {
                .ColumnName = "CA_DEFERRED",
                .Caption = "Deferred",
                .DataType = System.Type.GetType("System.Decimal")
            }
            dtTable.Columns.Add(col)

            col = Nothing
            col = New DataColumn With {
                .ColumnName = "AA_0",
                .Caption = "No Claim",
                .DataType = System.Type.GetType("System.Decimal")
            }
            dtTable.Columns.Add(col)

            Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA(True)
            Dim tmpStatus As Boolean = False
            For i As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                If ListofAA(i) <> "AA_0" Then
                    For x As Integer = 0 To dt.Rows.Count - 1
                        If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(i))) = False AndAlso dt.Rows(x)(ListofAA(i)) <> 0 Then
                            tmpStatus = True

                            col = Nothing
                            col = New DataColumn With {
                                .ColumnName = ListofAA(i),
                                .Caption = ListofAA(i) & "% RM",
                                .DataType = System.Type.GetType("System.Decimal")
                            }
                            dtTable.Columns.Add(col)
                        End If

                    Next
                End If
               

            Next

            col = New DataColumn With {
                .ColumnName = "Total",
                .Caption = "Total",
                .DataType = System.Type.GetType("System.Decimal")
            }

            dtTable.Columns.Add(col)
            Dim dtRow As DataRow = Nothing
            For i As Integer = 0 To dt.Rows.Count - 1


                dtRow = Nothing
                dtRow = dtTable.NewRow
                For x As Integer = 0 To dtTable.Columns.Count - 1

                    If IsDBNull(dt.Rows(i)(dtTable.Columns(x).ColumnName)) = False Then
                        dtRow(dtTable.Columns(x).ColumnName) = dt.Rows(i)(dtTable.Columns(x).ColumnName)
                    End If

                Next
                dtTable.Rows.Add(dtRow)
            Next

            ds.Tables.Add(dtTable)

            GridControl1.DataSource = ds.Tables("CA_REPORT_ANALYSIS_PROPERTY_2")

            GridView1.BeginSort()
            Dim col1 As GridColumn = GridView1.Columns("CA_CATEGORY")
            'Dim col2 As GridColumn = GridView1.Columns("CA_CAEEO")
            'Dim col3 As GridColumn = GridView1.Columns("CA_CATEGORY_CODE")
            Dim colDescription As GridColumn = GridView1.Columns("CA_DESCRIPTION")

            GridView1.ClearGrouping()
            col1.GroupIndex = 0
            'col2.GroupIndex = 1
            'col3.GroupIndex = 2
            GridView1.EndSort()

            colDescription.Width = 300

            GridView1.ExpandAllGroups()

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
            Dim rpt As rpt_CAAnalysis
            Dim rpt_Note As rptCA_Note
            Dim Title As String = ADO.Load_TableOfContent_Title(RefNo, YA, "rpt_CAAnalysis")

            If mdlProcess.PrintReport_CAAnalysis(ds, Title, ID, False, rpt, rpt_Note, ErrorLog) Then
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
            Else
                MsgBox("Failed to load CA analysis report.", MsgBoxStyle.Critical)
            End If

            If isExport Then
                MsgBox("Succesfully export report to " & vbCrLf & Path, MsgBoxStyle.Information)

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
    Private Sub btnExpand_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExpand.ItemClick
        Try
            '   BandedGridView1.ExpandAllGroups()

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnCollepase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCollepase.ItemClick
        Try
            ' BandedGridView1.CollapseAllGroups()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    'Private Sub BandedGridView1_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles BandedGridView1.CustomDrawCell
    '    Try
    '        If e.Column.FieldName = "AA_2" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_2.Visible = True
    '            Else
    '                colAA_2.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_3" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_3.Visible = True
    '            Else
    '                colAA_3.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_8" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_8.Visible = True
    '            Else
    '                colAA_8.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_10" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_10.Visible = True
    '            Else
    '                colAA_10.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_12" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_12.Visible = True
    '            Else
    '                colAA_12.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_14" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_14.Visible = True
    '            Else
    '                colAA_14.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_16" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_16.Visible = True
    '            Else
    '                colAA_16.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_20" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_20.Visible = True
    '            Else
    '                colAA_20.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_40" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_40.Visible = True
    '            Else
    '                colAA_40.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_50" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_50.Visible = True
    '            Else
    '                colAA_50.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_60" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_60.Visible = True
    '            Else
    '                colAA_60.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_80" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_80.Visible = True
    '            Else
    '                colAA_80.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_90" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_90.Visible = True
    '            Else
    '                colAA_90.Visible = False
    '            End If
    '        End If
    '        If e.Column.FieldName = "AA_100" Then
    '            If IsDBNull(e.CellValue) = False AndAlso IsNumeric(e.CellValue) = True AndAlso CInt(e.CellValue) <> 0 Then
    '                colAA_100.Visible = True
    '            Else
    '                colAA_100.Visible = False
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Public Sub InitBands(ByVal rep As XtraReport)
        ' Create bands
        Dim detail As New DetailBand()
        Dim pageHeader As New PageHeaderBand()
        Dim reportFooter As New ReportFooterBand()
        detail.Height = 20
        reportFooter.Height = 380
        pageHeader.Height = 20

        ' Place the bands onto a report
        rep.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {detail, pageHeader, reportFooter})
    End Sub
    Public Sub InitStyles(ByVal rep As XtraReport)
        ' Create different odd and even styles
        Dim oddStyle As New XRControlStyle()
        Dim evenStyle As New XRControlStyle()

        ' Specify the odd style appearance
        oddStyle.BackColor = Color.LightBlue
        oddStyle.StyleUsing.UseBackColor = True
        oddStyle.StyleUsing.UseBorders = False
        oddStyle.Name = "OddStyle"

        ' Specify the even style appearance
        evenStyle.BackColor = Color.LightPink
        evenStyle.StyleUsing.UseBackColor = True
        evenStyle.StyleUsing.UseBorders = False
        evenStyle.Name = "EvenStyle"

        ' Add styles to report's style sheet
        rep.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {oddStyle, evenStyle})
    End Sub

    Public Sub InitDetailsBasedOnXRLabel(ByVal rep As XtraReport)
        Dim ds As DataSet = (CType(rep.DataSource, DataSet))
        Dim colCount As Integer = ds.Tables(0).Columns.Count
        Dim colWidth As Integer = (rep.PageWidth - (rep.Margins.Left + rep.Margins.Right)) / colCount

        ' Create header captions
        For i As Integer = 0 To colCount - 1
            Dim label As New XRLabel With {
                .Location = New Point(colWidth * i, 0),
                .Size = New Size(colWidth, 20),
                .Text = ds.Tables(0).Columns(i).Caption
            }
            If i > 0 Then
                label.Borders = DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom
            Else
                label.Borders = DevExpress.XtraPrinting.BorderSide.All
            End If

            ' Place the headers onto a PageHeader band
            rep.Bands(BandKind.PageHeader).Controls.Add(label)
        Next i
        ' Create data-bound labels with different odd and even backgrounds
        For i As Integer = 0 To colCount - 1
            Dim label As New XRLabel With {
                .Location = New Point(colWidth * i, 0),
                .Size = New Size(colWidth, 20)
            }
            label.DataBindings.Add("Text", Nothing, ds.Tables(0).Columns(i).Caption)
            label.OddStyleName = "OddStyle"
            label.EvenStyleName = "EvenStyle"
            If i > 0 Then
                label.Borders = DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom
            Else
                label.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom
            End If

            ' Place the labels onto a Detail band
            rep.Bands(BandKind.Detail).Controls.Add(label)
        Next i
    End Sub
    Public Sub InitDetailsBasedonXRTable(ByVal rep As XtraReport)
        Dim ds As DataSet = (CType(rep.DataSource, DataSet))
        Dim colCount As Integer = ds.Tables(0).Columns.Count
        Dim colWidth As Integer = (rep.PageWidth - (rep.Margins.Left + rep.Margins.Right)) / colCount

        ' Create a table to represent headers
        Dim tableHeader As New XRTable With {
            .Height = 20,
            .Width = (rep.PageWidth - (rep.Margins.Left + rep.Margins.Right))
        }
        Dim headerRow As New XRTableRow With {
            .Width = tableHeader.Width
        }
        tableHeader.Rows.Add(headerRow)

        tableHeader.BeginInit()

        ' Create a table to display data
        Dim tableDetail As New XRTable With {
            .Height = 20,
            .Width = (rep.PageWidth - (rep.Margins.Left + rep.Margins.Right))
        }
        Dim detailRow As New XRTableRow With {
            .Width = tableDetail.Width
        }
        tableDetail.Rows.Add(detailRow)
        tableDetail.EvenStyleName = "EvenStyle"
        tableDetail.OddStyleName = "OddStyle"

        tableDetail.BeginInit()

        ' Create table cells, fill the header cells with text, bind the cells to data
        For i As Integer = 0 To colCount - 1
            Dim headerCell As New XRTableCell With {
                .Width = colWidth,
                .Text = ds.Tables(0).Columns(i).Caption
            }

            Dim detailCell As New XRTableCell With {
                .Width = colWidth
            }
            detailCell.DataBindings.Add("Text", Nothing, ds.Tables(0).Columns(i).Caption)
            If i = 0 Then
                headerCell.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom
                detailCell.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom
            Else
                headerCell.Borders = DevExpress.XtraPrinting.BorderSide.All
                detailCell.Borders = DevExpress.XtraPrinting.BorderSide.All
            End If

            ' Place the cells into the corresponding tables
            headerRow.Cells.Add(headerCell)
            detailRow.Cells.Add(detailCell)
        Next i
        tableHeader.EndInit()
        tableDetail.EndInit()
        ' Place the table onto a report's Detail band
        rep.Bands(BandKind.PageHeader).Controls.Add(tableHeader)
        rep.Bands(BandKind.Detail).Controls.Add(tableDetail)
    End Sub
    Public Sub InitChart(ByVal rep As XtraReport)
        Dim ds As DataSet = (CType(rep.DataSource, DataSet))

        ' Create a chart
        Dim xrChart1 As XRChart = New DevExpress.XtraReports.UI.XRChart With {
            .Location = New System.Drawing.Point(0, 0),
            .Name = "xrChart1"
        }

            ' Create chart series and bind them to data
        For i As Integer = 1 To ds.Tables(0).Columns.Count - 1
            If ds.Tables(0).Columns(i).DataType Is GetType(Integer) OrElse ds.Tables(0).Columns(i).DataType Is GetType(Double) Then
                Dim series As New DevExpress.XtraCharts.Series(ds.Tables(0).Columns(i).Caption, DevExpress.XtraCharts.ViewType.Bar) With {
                    .DataSource = ds.Tables(0),
                    .ArgumentDataMember = ds.Tables(0).Columns(0).Caption,
                    .PointOptionsTypeName = "PointOptions"
                }
                series.ValueDataMembers(0) = ds.Tables(0).Columns(i).Caption
                xrChart1.Series.Add(series)

            End If
        Next i
        ' Customize the chart appearance
        CType(xrChart1.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.Angle = 20
        CType(xrChart1.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
        CType(xrChart1.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.Antialiasing = True

        xrChart1.SeriesTemplate.PointOptionsTypeName = "PointOptions"
        xrChart1.Size = New System.Drawing.Size(650, 360)

        ' Place the chart onto a report footer
        rep.Bands(BandKind.ReportFooter).Controls.Add(xrChart1)
    End Sub
End Class