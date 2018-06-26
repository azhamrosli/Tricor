Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO
Imports DevExpress.XtraRichEdit.API.Native

Public Class frmNote_AttachmentView
    Public dataArr As Byte() = Nothing
    Public Type As Integer = 0
    Public Extension As String = Nothing
    Public Title As String = Nothing
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False

    End Sub

    Private Sub frmNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TabControl.SelectedTabPageIndex = Type
            Me.Text = "Attachment " & Title
            Application.DoEvents()

            Select Case Type
                Case 0
                    'picture
                    Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(dataArr)

                    Dim image As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                    Dim gr As Graphics = Graphics.FromImage(image)
                    gr.DrawString(Title, _
                                  New Font("Tahoma", 14), _
                                  New SolidBrush(Color.Green), _
                                  10, 10)
                    gr.Dispose()

                    picbox.Image = image

                Case 1
                    'excel
                    If Extension IsNot Nothing Then
                        Dim Typx As DevExpress.Spreadsheet.DocumentFormat
                        ' Load a workbook from the stream.

                        Using ms As New System.IO.MemoryStream(dataArr)

                            Select Case Extension.ToLower
                                Case ".xls"
                                    Typx = DevExpress.Spreadsheet.DocumentFormat.Xls
                                Case ".xlsx"
                                    Typx = DevExpress.Spreadsheet.DocumentFormat.Xlsx
                                Case ".csv"
                                    Typx = DevExpress.Spreadsheet.DocumentFormat.Csv
                                Case ".openxml"
                                    Typx = DevExpress.Spreadsheet.DocumentFormat.OpenXml
                            End Select

                            SpreadsheetControl1.LoadDocument(ms, Typx)
                            SpreadsheetControl1.ActiveWorksheet.Rows.Insert(1, 3)
                            SpreadsheetControl1.ActiveWorksheet.Cells(0).Value = Title

                        End Using
                    End If
                Case 2
                    'word
                    If Extension IsNot Nothing Then
                        Dim Typx As DevExpress.XtraRichEdit.DocumentFormat
                        Using ms As New System.IO.MemoryStream(dataArr)
                            Select Case Extension.ToLower
                                Case ".docx", ".doc"
                                    Typx = DevExpress.XtraRichEdit.DocumentFormat.Doc
                                Case ".OpenDocument"
                                    Typx = DevExpress.XtraRichEdit.DocumentFormat.OpenDocument
                                Case ".Rtf"
                                    Typx = DevExpress.XtraRichEdit.DocumentFormat.Rtf
                                Case ".openxml"
                                    Typx = DevExpress.XtraRichEdit.DocumentFormat.OpenXml
                                Case ".wordml"
                                    Typx = DevExpress.XtraRichEdit.DocumentFormat.WordML
                            End Select

                            RichEditControl1.LoadDocument(ms, Typx)
                            Application.DoEvents()

                            'Dim pos As DocumentPosition = RichEditControl1.Document.CaretPosition
                            'Dim doc As SubDocument = pos.BeginUpdateDocument()
                            'doc.InsertText(pos, Title)
                            'pos.EndUpdateDocument(doc)

                        End Using

                    End If
                Case 3
                    PdfViewer1.DetachStreamAfterLoadComplete = True
                    Using ms As New System.IO.MemoryStream(dataArr)
                        PdfViewer1.LoadDocument(ms)                     
                    End Using
                    '  System.IO.File.WriteAllBytes("D:\x.pdf", dataArr)
            End Select
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
End Class