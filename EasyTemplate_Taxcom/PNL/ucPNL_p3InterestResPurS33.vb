Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports System.Collections

Public Class ucPNL_p3InterestResPurS33
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public isEdit As Boolean = False

    Public Const MainTable As String = "EXEMPT_DIVIDEND" 'PLFST_SALES
    Public Const MainKey As String = "ED_EDKEY" ' PLFS_KEY
    Public Const MainAmount As String = "ED_AMOUNT" 'PLFS_AMOUNT
    Public Const MainSourceNo As String = "ED_SOURCENO" 'PLFS_SOURCENO

    Private MainViews As DataSet
    Dim ErrorLog As clsError = Nothing
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Property DataView_Main() As DataSet
        Get
            Return DsPNL1
        End Get
        Set(ByVal value As DataSet)
            DsPNL1 = value
        End Set
    End Property

    Private Sub ucPNLTest_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub


    Public Sub LoadData(Optional ByRef Errorlog As clsError = Nothing)
        Try
            mdlProcess.CreateLookUpSourceNO(DsPNL1, RefNo, YA, "BUSINESS_SOURCE", Errorlog)


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



    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmPNL_InterestResPurS33_Yearly
            frm.RefNo = RefNo
            frm.YA = YA
            frm.txtAmount = txtAmount
            frm.DataView_Main = DsPNL1
            frm.isEdit = True
            frm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

 


End Class
