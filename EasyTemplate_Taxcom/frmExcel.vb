Public Class frmExcel 
    Public isAutoOpen As Boolean = False
    Public Path As String = Nothing
    Dim ErrorLog As ClsError = Nothing
    Private Sub frmExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(ErrorLog)
    End Sub

    Public Sub LoadData(Optional ByRef Errorlog As ClsError = Nothing)
        Try
            If isAutoOpen Then

                If Path <> "" Then

                    If System.IO.File.Exists(Path) = False Then
                        MsgBox("Failed to load file." & vbCrLf & Path, MsgBoxStyle.Critical)
                        Me.Close()
                    End If


                    SpreadsheetControl1.LoadDocument(Path)

                End If

            End If

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
            AddListOfError(Errorlog)
        End Try
    End Sub



    Private Sub SpreadsheetCommandBarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SpreadsheetCommandBarButtonItem2.ItemClick

    End Sub
End Class