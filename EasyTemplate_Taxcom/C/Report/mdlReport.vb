Imports DevExpress.Spreadsheet

Module mdlReport
#Region "CreateDataSetReport"
    Public Function CreateDataSetReport(ByRef ds As DataSet, ByVal Value As String, ByVal Caption As String, ByVal Cell As Integer, _
                                        ByVal Row As Integer, Optional isBold As Boolean = True, _
                                        Optional isUnderline As DevExpress.Spreadsheet.UnderlineType = UnderlineType.None, _
                                        Optional isItalic As Boolean = False, _
                                        Optional BackgroundColor As String = "", _
                                        Optional FontColor As String = "", _
                                        Optional BorderLeft As DevExpress.Spreadsheet.BorderLineStyle = BorderLineStyle.None, _
                                        Optional BorderTop As DevExpress.Spreadsheet.BorderLineStyle = BorderLineStyle.None, _
                                        Optional BorderRight As DevExpress.Spreadsheet.BorderLineStyle = BorderLineStyle.None, _
                                        Optional BorderBottom As DevExpress.Spreadsheet.BorderLineStyle = BorderLineStyle.None, _
                                        Optional Width As Integer = -1, Optional Height As Integer = -1, _
                                        Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            If ds Is Nothing Then
                ds = New dsReport_Templatexsd
            End If

            Dim dtRow As DataRow = Nothing


            dtRow = ds.Tables("dtReport").NewRow
            dtRow("Value") = Value
            dtRow("Caption") = Caption
            dtRow("Cell") = Cell
            dtRow("Row") = Row
            dtRow("isBold") = isBold
            dtRow("isUnderline") = isUnderline
            dtRow("isItalic") = isItalic
            dtRow("BackgroundColor") = BackgroundColor
            dtRow("FontColor") = FontColor
            dtRow("BorderLeft") = BorderLeft
            dtRow("BorderTop") = BorderTop
            dtRow("BorderRight") = BorderRight
            dtRow("BorderBottom") = BorderBottom
            dtRow("Width") = Width
            dtRow("Height") = Height
            ds.Tables("dtReport").Rows.Add(dtRow)

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            Return True
        End Try
    End Function
    Public Function CreateDataSetReport(ByRef ds As DataSet, ByVal Value As String, ByVal Cell As Integer, _
                                      ByVal Row As Integer, _
                                      Optional BorderLeft As DevExpress.Spreadsheet.BorderLineStyle = BorderLineStyle.None, _
                                      Optional BorderTop As DevExpress.Spreadsheet.BorderLineStyle = BorderLineStyle.None, _
                                      Optional BorderRight As DevExpress.Spreadsheet.BorderLineStyle = BorderLineStyle.None, _
                                      Optional BorderBottom As DevExpress.Spreadsheet.BorderLineStyle = BorderLineStyle.None, _
                                      Optional Width As Integer = -1, Optional Height As Integer = -1, _
                                      Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            If ds Is Nothing Then
                ds = New dsReport_Templatexsd
            End If

            Dim dtRow As DataRow = Nothing


            dtRow = ds.Tables("dtReport").NewRow
            dtRow("Value") = Value
            dtRow("Caption") = ""
            dtRow("Cell") = Cell
            dtRow("Row") = Row
            dtRow("isBold") = False
            dtRow("isUnderline") = "None"
            dtRow("isItalic") = False
            dtRow("BackgroundColor") = ""
            dtRow("FontColor") = ""
            dtRow("BorderLeft") = BorderLeft
            dtRow("BorderTop") = BorderTop
            dtRow("BorderRight") = BorderRight
            dtRow("BorderBottom") = BorderBottom
            dtRow("Width") = Width
            dtRow("Height") = Height
            ds.Tables("dtReport").Rows.Add(dtRow)

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            Return True
        End Try
    End Function
    Public Function CreateDataSetReport(ByRef ds As DataSet, ByVal Value As String, ByVal Cell As Integer, _
                                        ByVal Row As Integer, Optional isBold As Boolean = True, _
                                        Optional isUnderline As DevExpress.Spreadsheet.UnderlineType = UnderlineType.None, _
                                        Optional isItalic As Boolean = False, _
                                        Optional BackgroundColor As String = "", _
                                        Optional FontColor As String = "", _
                                        Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            If ds Is Nothing Then
                ds = New dsReport_Templatexsd
            End If

            Dim dtRow As DataRow = Nothing


            dtRow = ds.Tables("dtReport").NewRow
            dtRow("Value") = Value
            dtRow("Caption") = ""
            dtRow("Cell") = Cell
            dtRow("Row") = Row
            dtRow("isBold") = isBold
            dtRow("isUnderline") = isUnderline
            dtRow("isItalic") = isItalic
            dtRow("BackgroundColor") = BackgroundColor
            dtRow("FontColor") = FontColor
            dtRow("BorderLeft") = "None"
            dtRow("BorderTop") = "None"
            dtRow("BorderRight") = "None"
            dtRow("BorderBottom") = "None"
            dtRow("Width") = -1
            dtRow("Height") = -1
            ds.Tables("dtReport").Rows.Add(dtRow)

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            Return True
        End Try
    End Function
    Public Function CreateDataSetReport(ByRef ds As DataSet, ByVal Value As String, ByVal Cell As Integer, _
                                        ByVal Row As Integer, _
                                        Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            If ds Is Nothing Then
                ds = New dsReport_Templatexsd
            End If

            Dim dtRow As DataRow = Nothing

            dtRow = ds.Tables("dtReport").NewRow
            dtRow("Value") = Value
            dtRow("Caption") = ""
            dtRow("Cell") = Cell
            dtRow("Row") = Row
            dtRow("isBold") = False
            dtRow("isUnderline") = "None"
            dtRow("isItalic") = False
            dtRow("BackgroundColor") = ""
            dtRow("FontColor") = ""
            dtRow("BorderLeft") = "None"
            dtRow("BorderTop") = "None"
            dtRow("BorderRight") = "None"
            dtRow("BorderBottom") = "None"
            dtRow("Width") = -1
            dtRow("Height") = -1
            ds.Tables("dtReport").Rows.Add(dtRow)

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            Return True
        End Try
    End Function
    Public Function CreateDataSetReport(ByRef ds As DataSet, ByVal Value As String, ByVal Caption As String, ByVal Cell As Integer, _
                                        ByVal Row As Integer, Optional ByVal Width As Integer = -1, Optional ByVal Height As Integer = -1, _
                                        Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            If ds Is Nothing Then
                ds = New dsReport_Templatexsd
            End If

            Dim dtRow As DataRow = Nothing

            dtRow = ds.Tables("dtReport").NewRow
            dtRow("Value") = Value
            dtRow("Caption") = Caption
            dtRow("Cell") = Cell
            dtRow("Row") = Row
            dtRow("isBold") = False
            dtRow("isUnderline") = "None"
            dtRow("isItalic") = False
            dtRow("BackgroundColor") = ""
            dtRow("FontColor") = ""
            dtRow("BorderLeft") = "None"
            dtRow("BorderTop") = "None"
            dtRow("BorderRight") = "None"
            dtRow("BorderBottom") = "None"
            dtRow("Width") = Width
            dtRow("Height") = Height
            ds.Tables("dtReport").Rows.Add(dtRow)

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            Return True
        End Try
    End Function

#End Region


    Public Function GenerateXlsReport(ByRef workbook As DevExpress.Spreadsheet.Workbook, ByRef ds As DataSet, _
                                      Optional ByRef TabNo As Integer = 0, Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            If workbook Is Nothing Then
                workbook = New Workbook()
            End If
            Dim worksheet As Worksheet = workbook.Worksheets(TabNo)

            If worksheet Is Nothing Then
                If ErrorLog Is Nothing Then
                    ErrorLog = New ClsError
                End If
                With ErrorLog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "E10001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "Cannot find work sheet in index " & TabNo
                End With
                Return False
            End If

            Dim cell As Cell
            For Each rowx As DataRow In ds.Tables("dtReport").Rows
                cell = worksheet(CInt(rowx("Row")), CInt(rowx("Cell"))) ' Cell A1

                cell.Value = rowx("Value").ToString

                If CBool(rowx("isBold")) = True Then
                    cell.Font.Bold = True
                Else
                    cell.Font.Bold = False
                End If

                cell.Font.Italic = CBool(rowx("isItalic"))
                cell.Font.UnderlineType = DirectCast([Enum].Parse(GetType(DevExpress.Spreadsheet.UnderlineType), rowx("isUnderline").ToString), DevExpress.Spreadsheet.UnderlineType)
                If rowx("BackgroundColor").ToString <> "" Then
                    cell.FillColor = System.Drawing.Color.FromName(rowx("BackgroundColor").ToString)
                End If

                If rowx("FontColor").ToString <> "" Then
                    cell.Font.Color = System.Drawing.Color.FromName(rowx("FontColor").ToString)
                End If

                cell.Borders.LeftBorder.LineStyle = DirectCast([Enum].Parse(GetType(DevExpress.Spreadsheet.BorderLineStyle), rowx("BorderLeft").ToString), DevExpress.Spreadsheet.BorderLineStyle)
                cell.Borders.TopBorder.LineStyle = DirectCast([Enum].Parse(GetType(DevExpress.Spreadsheet.BorderLineStyle), rowx("BorderTop").ToString), DevExpress.Spreadsheet.BorderLineStyle)
                cell.Borders.RightBorder.LineStyle = DirectCast([Enum].Parse(GetType(DevExpress.Spreadsheet.BorderLineStyle), rowx("BorderRight").ToString), DevExpress.Spreadsheet.BorderLineStyle)
                cell.Borders.BottomBorder.LineStyle = DirectCast([Enum].Parse(GetType(DevExpress.Spreadsheet.BorderLineStyle), rowx("BorderBottom").ToString), DevExpress.Spreadsheet.BorderLineStyle)

                If CDbl(rowx("Width")) > 0 AndAlso CDbl(rowx("Width")) <= 255 Then
                    cell.ColumnWidth = CDbl(rowx("Width"))
                End If
                If CDbl(rowx("Height")) > 0 AndAlso CDbl(rowx("Height")) <= 255 Then
                    cell.RowHeight = CDbl(rowx("Height"))
                End If

            Next

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            Return False
        End Try
    End Function
End Module
