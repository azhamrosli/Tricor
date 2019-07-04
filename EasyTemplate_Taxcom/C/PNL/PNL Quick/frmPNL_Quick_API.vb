Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Public Class frmPNL_Quick_API
    Dim ErrorLog As ClsError = Nothing
    Dim isMappingCode As Boolean = False

    Dim WithEvents clsPNL_Quick As clsPNL_Quick

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If clsPNL_Quick Is Nothing Then
            clsPNL_Quick = New clsPNL_Quick
        End If
    End Sub
    Private Sub frmPNL_Quick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Timer1.Enabled = True
            Timer1.Start()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Timer1.Stop()
            clsPNL_Quick.RefNo = "9876543210"
            clsPNL_Quick.YA = "2016"
            '   clsPNL_Quick.Ai_Testing_Require = True
            clsPNL_Quick.Init_QuickPNL()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub clsPNL_Quick_OnChangeInfo(dsDataset_ As DataSet, Errorlog_ As ClsError) Handles clsPNL_Quick.OnChangeInfo
        Try
            If dsDataset_ IsNot Nothing Then

                PNLQUICKBindingSource.DataSource = dsDataset_.Tables("PNL_QUICK")
                PNLTABLEINFOBindingSource.DataSource = dsDataset_.Tables("PNL_TABLE_INFO")
                BUSINESSSOURCEBindingSource.DataSource = dsDataset_.Tables("BUSINESS_SOURCE")
                PNLQUICKDETAILBindingSource.DataSource = dsDataset_.Tables("PNL_QUICK_DETAIL")
                PNLTABLEINFOMAINBindingSource.DataSource = dsDataset_.Tables("PNL_TABLE_INFO_MAIN")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView4_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView4.InitNewRow
        Try
            'clsPNL_Quick.Init_NewRow(GridView2, GridView4, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView2_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GridView4.RowCellStyle, gv_Parent.RowCellStyle
        Try
            Dim view As GridView = CType(sender, GridView)
            clsPNL_Quick.Row_CellStyle(view, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView2_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles gv_Parent.RowDeleted
        Try
            clsPNL_Quick.Calculate_CategoryTotal()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView2_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv_Parent.RowUpdated
        Try
            clsPNL_Quick.Calculate_CategoryTotal()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView4_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView4.RowUpdated
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                clsPNL_Quick.Row_Updated(view, e)
                ' CalcTotal()
            End If
        Catch ex As Exception
        Finally
            clsPNL_Quick.Calculate_CategoryTotal()
        End Try
    End Sub
    Private Sub GridView2_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles gv_Parent.SelectionChanged
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.ControllerRow)

                If row IsNot Nothing AndAlso IsDBNull(row("KeyName")) = False Then

                    For i As Integer = 0 To GridView1.RowCount - 1

                        If GridView1.GetDataRow(i)("KeyName") = row("KeyName") Then
                            GridView1.SelectRow(i)
                        End If

                    Next

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView2_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GridView4.ShowingEditor, gv_Parent.ShowingEditor
        Try
            Dim view As GridView = CType(sender, GridView)
            clsPNL_Quick.Allow_ShowingEditor(view, e)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView2_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv_Parent.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("KEYNAME")) = True Then
                    e.ErrorText = "Please select category."
                    e.Valid = False
                End If
                If IsDBNull(row("SOURCE_NO")) = True Then
                    e.ErrorText = "Please select source no."
                    e.Valid = False
                End If
                If IsDBNull(row("DESCRIPTION")) = True Then
                    e.ErrorText = "Please put description."
                    e.Valid = False
                End If
                If IsDBNull(row("AMOUNT")) = True Then
                    e.ErrorText = "Please put amount."
                    e.Valid = False
                End If

            End If
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
            AddListOfError(ErrorLog)

        End Try
    End Sub
    Private Sub GridView4_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView4.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("DESCRIPTION")) = True Then
                    e.ErrorText = "Please put description."
                    e.Valid = False
                End If
                If IsDBNull(row("AMOUNT")) = True Then
                    e.ErrorText = "Please put amount."
                    e.Valid = False
                End If

            End If
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
            AddListOfError(ErrorLog)

        End Try
    End Sub
    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            clsPNL_Quick.Save_PNLQuick(False, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are sure want to remove this item?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If rslt = DialogResult.Yes Then
                Dim dgv As DevExpress.XtraGrid.Views.Grid.GridView
                For i As Integer = 0 To gv_Parent.RowCount - 1

                    dgv = gv_Parent.GetDetailView(i, 0)

                    If dgv IsNot Nothing AndAlso i = gv_Parent.FocusedRowHandle Then
                        dgv.DeleteSelectedRows()
                    ElseIf i = gv_Parent.FocusedRowHandle Then
                        gv_Parent.DeleteSelectedRows()
                    End If
                Next
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub clsPNL_Quick_OnChangeStatus(Status_ As clsPNL_Quick.EnumStatus, Errorlog_ As ClsError) Handles clsPNL_Quick.OnChangeStatus
        Try
            lblStatus.Caption = "Status : " & Status_.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub clsPNL_Quick_OnProgress(Current_ As Integer, Total_ As Integer, strSQL As String) Handles clsPNL_Quick.OnProgress
        Try
            lblProgress.Caption = Current_.ToString & "/" & Total_.ToString & " - " & strSQL
            Application.DoEvents()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub clsPNL_Quick_OnSchangeSaveStatus(Status_ As clsPNL_Quick.EnumStatus, Errorlog_ As ClsError) Handles clsPNL_Quick.OnSchangeSaveStatus
        Try
            If Status_ = EasyTemplate_Taxcom.clsPNL_Quick.EnumStatus.Done Then
                MsgBox("Successfully save profit & loss", MsgBoxStyle.Information)
            End If
            lblStatus.Caption = "Status : " & Status_.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
            Dim rslt As DialogResult = FolderBrowserDialog1.ShowDialog
            If rslt = Windows.Forms.DialogResult.OK Then
                Dim Path As String = FolderBrowserDialog1.SelectedPath

                If System.IO.Directory.Exists(Path) = False Then
                    MsgBox("Directory not exist.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                If clsPNL_Quick.Export_PNLQuick(Path) = True Then
                    MsgBox("Succesfully export data to " & Path, MsgBoxStyle.Information)
                Else
                    MsgBox("Unsuccesfully export data", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImport.ItemClick
        Try
            Dim rslt As DialogResult = OpenFileDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then
                Dim Path As String = OpenFileDialog1.FileName


                If clsPNL_Quick.Import_PNLQuick(Path, False) = True Then
                    MsgBox("Succesfully import data", MsgBoxStyle.Information)
                Else
                    MsgBox("Unsuccesfully import data", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            clsPNL_Quick.RefNo = "9876543210"
            clsPNL_Quick.YA = "2016"
            clsPNL_Quick.Ai_Testing_Require = True
            clsPNL_Quick.Init_QuickPNL()
        Catch ex As Exception

        End Try
    End Sub
End Class