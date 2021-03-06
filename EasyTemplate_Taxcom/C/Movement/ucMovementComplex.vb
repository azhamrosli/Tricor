﻿Imports DevExpress.XtraReports.ReportGeneration
Imports DevExpress.XtraReports.UI
Public Class ucMovementComplex
    Dim ErrorLog As ClsError = Nothing
    Dim clsMovement_Note As clsNote_Movement
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If clsMovement_Note Is Nothing Then
            clsMovement_Note = New clsNote_Movement
        End If

    End Sub
    Private Sub frmMovement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.LoadData(0)

            If My.Computer.Name = DeveloperPCName Then
                btnTestPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                btnTestPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub LoadData(Optional Type As Integer = 0)
        Try
            pnlLoading.Visible = True
            Application.DoEvents()

            Dim tmpType As Integer = -1

            If CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Application.DoEvents()

            If Type = 0 Then
                If mdlProcess.ArgParam2 <> "" Then
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If
            ElseIf Type = 1 Then
                cboRefNo.EditValue = ""
                cboYA.EditValue = ""
            End If


            Dim dt As DataTable = ADO.Load_MovementComplex_Search(cboRefNo.EditValue, cboYA.EditValue, ErrorLog)

            DsMovement.Tables("MOVEMENT_COMPLEX_ADD").Rows.Clear()
            DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows.Clear()
            DsMovement.Tables("MOVEMENT_COMPLEX").Rows.Clear()

            If dt Is Nothing Then
                Exit Sub
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                DsMovement.Tables("MOVEMENT_COMPLEX").ImportRow(dt.Rows(i))
            Next


        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        Finally
            pnlLoading.Visible = False
        End Try
    End Sub
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try
            LoadData(2)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmMovementComplex_Add With {
                .isEdit = False,
                .ID = 0
            }
            frm.ShowDialog()

            Me.LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs)
        Try
            If cboRefNo IsNot Nothing AndAlso cboRefNo.EditValue IsNot Nothing AndAlso cboRefNo.EditValue <> "" Then
                txtRefNo.EditValue = cboRefNo.EditValue
                LoadData(2)
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub cboYA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYA.SelectedIndexChanged
        Try
            LoadData(2)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            cboRefNo.EditValue = ""
            Me.LoadData(2)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        Try
            cboYA.EditValue = ""
            Me.LoadData(2)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs) Handles btnAllRecord.Click
        Try
            cboRefNo.EditValue = ""
            cboYA.EditValue = ""
            LoadData(1)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            Dim ID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows(0))("MM_ID")

            Dim frm As New frmMovementComplex_Add With {
                .isEdit = True,
                .ID = ID
            }
            frm.ShowDialog()
            Me.LoadData(2)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "Movement Complex", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim tmpSts As Boolean = True
                For i As Integer = 0 To GridView1.SelectedRowsCount - 1

                    If ADO.Delete_MovementComplex(CInt(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("MM_ID")), _
                                                          CStr(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("MM_REFNO")), _
                                                          CStr(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("MM_YA")), ErrorLog) = False Then
                        tmpSts = False
                    End If
                    'MsgBox(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("CA_KEY"))
                Next
                If tmpSts Then
                    MsgBox("Succesfully remove movement complex.", MsgBoxStyle.Information)
                    Me.LoadData(2)
                Else
                    MsgBox("Some of movement complex failed to delete.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try
            btnEdit.PerformClick()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged_1(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick

        Try
            If GridView1.RowCount = 0 Then
                Exit Sub
            End If
            Dim rpt As rptMovementComplexNew
            Dim rpt_Note As rptMovement_Note
            If mdlProcess.PrintReport_MovementComplexNew(DsMovement, GridView1.GetDataRow(GridView1.FocusedRowHandle)("MM_ID"), _
                                                      GridView1.GetDataRow(GridView1.FocusedRowHandle)("MM_REFNO"), rpt, False, rpt_Note, ErrorLog) Then
                '   rpt.ShowPreview()
                Dim minPageCount As Integer = Math.Min(rpt.Pages.Count, rpt_Note.Pages.Count)

                Dim x As Integer = 0

                For Each pg As DevExpress.XtraPrinting.Page In rpt_Note.Pages
                    rpt.Pages.Add(pg)
                Next
                rpt.ShowPreview()
            Else
                MsgBox("Failed to load movement complex report.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
        Finally
            pnlLoading.Visible = False
            Application.DoEvents()
        End Try

    End Sub

    Private Sub btnTestPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTestPrint.ItemClick
        Try
            If GridView1.RowCount = 0 Then
                Exit Sub 
            End If
            Dim rpt As rptMovementComplexNew
            Dim rpt_Note As rptMovement_Note
            If mdlProcess.PrintReport_MovementComplexNew(DsMovement, GridView1.GetDataRow(GridView1.FocusedRowHandle)("MM_ID"), _
                                                      GridView1.GetDataRow(GridView1.FocusedRowHandle)("MM_REFNO"), rpt, False, rpt_Note, ErrorLog) Then
                '   rpt.ShowPreview()
                Dim minPageCount As Integer = Math.Min(rpt.Pages.Count, rpt_Note.Pages.Count)

                Dim x As Integer = 0

                For Each pg As DevExpress.XtraPrinting.Page In rpt_Note.Pages
                    rpt.Pages.Add(pg)
                Next
                rpt.ShowPreview()
            Else
                MsgBox("Failed to load movement complex report.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
        Finally
            pnlLoading.Visible = False
            Application.DoEvents()
        End Try

    End Sub
End Class
