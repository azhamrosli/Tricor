Public Class frmPNL_InterestResPurS33_Yearly 
    Public ID_PNL As Decimal = 0
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public isEdit As Boolean = False

    Private Sub frmPNL_InterestResPurS33_Yearly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub LoadData(Optional ByRef Errorlog As clsError = Nothing)
        Try
            mdlProcess.CreateLookUpSourceNO(DsPNL, RefNo, YA, "BUSINESS_SOURCE", Errorlog)


            If isEdit Then

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
        End Try
    End Sub
End Class