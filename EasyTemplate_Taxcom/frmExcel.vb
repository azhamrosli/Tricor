Public Class frmExcel 
    Public isAutoOpen As Boolean = False
    Public Path As String = Nothing
    Dim ErrorLog As clsError = Nothing
    Private Sub frmExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(ErrorLog)
    End Sub

    Public Sub LoadData(Optional ByRef Errorlog As clsError = Nothing)
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
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(Errorlog)
        End Try
    End Sub



End Class