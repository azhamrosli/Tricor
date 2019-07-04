Public Class frmTaxComputation_Details 
    Public Property ObjUserControl As Object
    Public Property Title As String
    Public Property FormType As Taxcom_FormType
    Public Property rowData As DataRow
    Public WithEvents AdjustedIncome As AdjustedIncome
    Public Enum Taxcom_FormType
        ucTaxCom_Statutory_RA = 0
        ucTaxCom_Statutory_ITA = 1
    End Enum
    Private Sub frmTaxComputation_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Controls.Clear()

            If ObjUserControl IsNot Nothing Then
                Select Case FormType
                    Case Taxcom_FormType.ucTaxCom_Statutory_ITA, Taxcom_FormType.ucTaxCom_Statutory_RA
                        If TypeOf ObjUserControl Is ucTaxCom_Statutory_RAITA Then
                            Dim obj As ucTaxCom_Statutory_RAITA = CType(ObjUserControl, ucTaxCom_Statutory_RAITA)
                            If obj IsNot Nothing AndAlso AdjustedIncome IsNot Nothing Then
                                obj.AdjustedIncome = AdjustedIncome
                                Select Case FormType
                                    Case Taxcom_FormType.ucTaxCom_Statutory_ITA
                                        obj.Type = ucTaxCom_Statutory_RAITA.Type_StatutoryIncome_RAITA.ITA
                                    Case Taxcom_FormType.ucTaxCom_Statutory_RA
                                        obj.Type = ucTaxCom_Statutory_RAITA.Type_StatutoryIncome_RAITA.RA
                                End Select
                                obj.rowData = rowData
                            End If
                        Else
                            MsgBox("Invalid form name.", MsgBoxStyle.Critical)
                        End If
                End Select
                Me.Controls.Add(ObjUserControl)
            End If
            Me.Text = Title
        Catch ex As Exception

        End Try
    End Sub
End Class