Imports DevExpress.XtraPrinting
Imports DevExpress.LookAndFeel

Public Class frmHome
    Inherits DevExpress.XtraEditors.XtraForm

    Dim ErrorLog As ClsError = Nothing
    Dim isChangeForm As Boolean = False
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        If My.Settings.ThemeName <> "" Then
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = My.Settings.ThemeName
        Else
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2013" ' "Office 2013"
        End If
        InitializeComponent()

        If ADO Is Nothing Then
            ADO = New clsIODatabase
        End If

        If clsMoveNormal Is Nothing Then
            clsMoveNormal = New clsMovementNormal
        End If
        'Ne
        txtPCName.Caption = My.Computer.Name & " | " & GetServerName() & " | V" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & " R = " & mdlProcess.R1
        'txtPCName.Caption = My.Computer.Name & " | " & GetServerName() & " | V" & mdlProcess.V1 & "." & mdlProcess.V2 & "." & mdlProcess.V3 & "." & mdlProcess.V4 & " R." & mdlProcess.R1
    End Sub
    Private Sub frmHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If isChangeForm = False Then
                e.Cancel = True
                My.Settings.ThemeName = UserLookAndFeel.Default.SkinName
                My.Settings.Save()
                frmStartup.Close()
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Public Sub RefreshData()
        Try
            If dsDataSetErrorlog Is Nothing Then
                dsDataSetErrorlog = New dsDefault
            End If

            If CreateLookUpTaxPayer(DsDefault, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            txtPCName.Caption = My.Computer.Name & " | " & GetServerName() & " | V" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & " R = " & mdlProcess.R1
            'txtPCName.Caption = My.Computer.Name & " | " & GetServerName() & " | V" & mdlProcess.V1 & "." & mdlProcess.V2 & "." & mdlProcess.V3 & "." & mdlProcess.V4 & " R." & mdlProcess.R1
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
            RefreshData()
          
            tlMenu.ExpandAll()
            DtErrorLogBindingSource.DataSource = dsDataSetErrorlog.Tables("dtErrorLog")
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try

    End Sub
    Public Sub LoadData()
        Try
            If mdlProcess.ArgParam0 = "" Then

                If My.Settings.LastModule Is Nothing OrElse My.Settings.LastModule = "" Then
                    mdlProcess.ArgParam0 = "frmpnl"
                Else
                    mdlProcess.ArgParam0 = My.Settings.LastModule
                End If



            End If

            Select Case mdlProcess.ArgParam0.ToLower
                Case "frmtaxpayerinformation"
                    docMain.Controls.Clear()
                    Dim uc As New ucTaxPayerInformation With {
                        .Dock = DockStyle.Fill
                    }
                    docMain.Text = "Tax payer information"
                    docMain.Controls.Add(uc)
                Case "frmbank"
                    docMain.Controls.Clear()
                    Dim uc As New ucBank With {
                        .Dock = DockStyle.Fill
                    }
                    docMain.Text = "Bank"
                    docMain.Controls.Add(uc)

                Case "frmyearassessment"
                    'docMain.Controls.Clear()
                    'Dim uc As New ucYearAssessment
                    'uc.Dock = DockStyle.Fill
                    'docMain.Text = "Year Assessment"
                    'docMain.Controls.Add(uc)
                Case "frmdeemedinterest"
                    docMain.Controls.Clear()
                    Dim uc As New ucDeemedInterest With {
                        .Dock = DockStyle.Fill
                    }
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "Deemed Interest Rate"
                    docMain.Controls.Add(uc)
                Case "frmdeemedinterest_report"
                    docMain.Controls.Clear()
                    Dim uc As New ucDeemedInterest_Report With {
                        .Dock = DockStyle.Fill
                    }
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "Print Deemed Interest Rate"
                    docMain.Controls.Add(uc)
                Case "frmca"
                    docMain.Controls.Clear()
                    Dim uc As New ucCA With {
                        .Dock = DockStyle.Fill
                    }
                    uc.cboRefNo.EditValue = mdlProcess.ArgParam2
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "Capital Allowance"
                    docMain.Controls.Add(uc)
                Case "frmhp"
                    docMain.Controls.Clear()
                    Dim uc As New ucHP With {
                        .Dock = DockStyle.Fill
                    }
                    uc.cboRefNo.EditValue = mdlProcess.ArgParam2
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "Hire Purchase"
                    docMain.Controls.Add(uc)
                Case "frmdisposal"
                    docMain.Controls.Clear()
                    Dim uc As New ucDisposal With {
                        .Dock = DockStyle.Fill
                    }
                    uc.cboRefNo.EditValue = mdlProcess.ArgParam2
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "Disposal"
                    docMain.Controls.Add(uc)
                Case "frmbalancesheet"
                    docMain.Controls.Clear()
                    Dim uc As New ucBalanceSheet With {
                        .Dock = DockStyle.Fill
                    }
                    uc.txtRefNo.EditValue = mdlProcess.ArgParam2
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "Balance Sheet"
                    docMain.Controls.Add(uc)
                Case "frmpnl"
                    docMain.Controls.Clear()
                    Dim uc As New ucPNL With {
                        .Dock = DockStyle.Fill
                    }
                    uc.txtRefNo.EditValue = mdlProcess.ArgParam2
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "Profit and Loss"
                    docMain.Controls.Add(uc)
                Case "frmmovement"
                    docMain.Controls.Clear()
                    Dim uc As New ucMovement With {
                        .Dock = DockStyle.Fill
                    }
                    uc.txtRefNo.EditValue = mdlProcess.ArgParam2
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "Movement Normal"
                    docMain.Controls.Add(uc)
                Case "frmmovementcomplex"
                    docMain.Controls.Clear()
                    Dim uc As New ucMovementComplex With {
                        .Dock = DockStyle.Fill
                    }
                    uc.txtRefNo.EditValue = mdlProcess.ArgParam2
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "Movement Complex"
                    docMain.Controls.Add(uc)
                Case "frmdeemedinterest"
                    docMain.Controls.Clear()
                    Dim uc As New ucDeemedInterest With {
                        .Dock = DockStyle.Fill
                    }
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "Deemed Interest"
                    docMain.Controls.Add(uc)
                Case "frmcp204"
                    docMain.Controls.Clear()
                    Dim uc As New ucCP204 With {
                        .Dock = DockStyle.Fill
                    }
                    uc.txtRefNo.EditValue = mdlProcess.ArgParam2
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "CP204"
                    docMain.Controls.Add(uc)
                Case "frmsqlscript"
                    docMain.Controls.Clear()
                    Dim uc As New ucSQLScript With {
                        .Dock = DockStyle.Fill
                    }
                    docMain.Text = "SQL Script"
                    docMain.Controls.Add(uc)
                Case "frmtableofcontent"
                    docMain.Controls.Clear()
                    Dim uc As New ucTableofContent With {
                        .Dock = DockStyle.Fill
                    }
                    uc.txtRefNo.EditValue = mdlProcess.ArgParam2
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "Table of Content"
                    docMain.Controls.Add(uc)
                Case "frmexemptioncalculator"
                    Dim frm As New frmExemptionCalculator
                    frm.Show()
                Case Else
                    MsgBox("Unable to find form name " & mdlProcess.ArgParam0)
                    Me.Close()
            End Select

            If mdlProcess.ArgParam0 <> "" Then
                My.Settings.LastModule = mdlProcess.ArgParam0
                My.Settings.Save()
            End If
            

            If YGLClient IsNot Nothing Then
                Me.Text = "Welcome to TaxOffice -" & IIf(IsDBNull(YGLClient("CompanyName")), "", YGLClient("CompanyName"))
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        Finally
            If docMain.Visibility <> DevExpress.XtraBars.Docking.DockVisibility.Visible Then
                docMain.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            End If

            If mdlProcess.ArgParam2.ToString <> "" Then
                cboRefNo.EditValue = mdlProcess.ArgParam2
            End If

            If mdlProcess.ArgParam3.ToString <> "" Then
                cboYA.EditValue = mdlProcess.ArgParam3
            End If

        End Try
    End Sub

    Private Sub TreeList1_DoubleClick(sender As Object, e As EventArgs) Handles tlMenu.DoubleClick
        Try
            Dim val As String = tlMenu.FocusedNode.GetDisplayText("Menu")

            If val IsNot Nothing AndAlso val <> "" Then

                Select Case val
                    Case "A.9 Tax Payer Information"
                        mdlProcess.ArgParam0 = "frmtaxpayerinformation"
                    Case "A.1 Year of Assessment"
                        mdlProcess.ArgParam0 = "frmyearassessment"
                    Case "A.1 Bank"
                        mdlProcess.ArgParam0 = "frmbank"
                    Case "A.2 Deemed Interest Rate"
                        mdlProcess.ArgParam0 = "frmdeemedinterest"
                    Case "B.1 Balance Sheet"
                        mdlProcess.ArgParam0 = "frmbalancesheet"
                    Case "B.2 Profit And Loss"
                        mdlProcess.ArgParam0 = "frmpnl"
                    Case "B.4 Movement Normal"
                        mdlProcess.ArgParam0 = "frmmovement"
                    Case "B.5 Movement Complex"
                        mdlProcess.ArgParam0 = "frmmovementcomplex"
                    Case "C.1.1 Capital Allowance"
                        mdlProcess.ArgParam0 = "frmca"
                    Case "C.1.2 Hire Purchase Schedule"
                        mdlProcess.ArgParam0 = "frmhp"
                    Case "C.1.3 Disposal"
                        mdlProcess.ArgParam0 = "frmdisposal"
                    Case "D.3 Form CP204"
                        mdlProcess.ArgParam0 = "frmcp204"
                    Case "Table of Content"
                        mdlProcess.ArgParam0 = "frmtableofcontent"
                    Case "Exemption Calculator"
                        mdlProcess.ArgParam0 = "frmexemptioncalculator"
                    Case "Deemed Interest Report"
                        mdlProcess.ArgParam0 = "frmdeemedinterest_report"

                End Select
            End If

            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub TreeList1_FocusedNodeChanged(sender As Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles tlMenu.FocusedNodeChanged
        Try

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        docMain.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        docMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub btnDefaultCompanyOK_Click(sender As Object, e As EventArgs) Handles btnDefaultCompanyOK.Click
        Try
            If cboRefNo.EditValue IsNot Nothing AndAlso cboRefNo.EditValue.ToString <> "" Then
                mdlProcess.ArgParam2 = cboRefNo.EditValue
            End If

            If cboYA.EditValue IsNot Nothing AndAlso cboYA.EditValue.ToString <> "" Then
                mdlProcess.ArgParam3 = cboYA.EditValue
            End If

            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Try
            docDefaultCompany.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        frmDatabase.Show()
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Try
            Dim rlst As DialogResult = FolderBrowserDialog1.ShowDialog

            If rlst = Windows.Forms.DialogResult.OK Then
                grdErrorLog.ExportToXlsx(FolderBrowserDialog1.SelectedPath & "\TaxcomErrorLog_" & Format(Now, "ddMMMyyyyHHmmss") & ".xlsx")
                MsgBox("Sucessfully export errorlog to excel.", MsgBoxStyle.Information)
            End If


        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Try
            Dim link As New PrintableComponentLink(New PrintingSystem()) With {
                .Component = grdErrorLog,
                .Landscape = True
            }

            link.ShowPreview()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Try
            docErrorLog.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Try
            dsDataSetErrorlog.Tables("dtErrorLog").Rows.Clear()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub docMain_Click(sender As Object, e As EventArgs) Handles docMain.Click

    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Try
            Dim frm As New frmLogin_Administrator
            frm.ShowDialog()
            If frm.Status = True Then
                mdlProcess.ArgParam0 = "frmSQLScript"

                LoadData()
            Else
                MsgBox("You dun have permission to use this feature.", MsgBoxStyle.Critical)
            End If


        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Try
            frmExcel.Show()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Try
            frmWord.Show()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Try
            frmUserNote.Show()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Try
            frmAbout.Show()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnFileCompare_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFileCompare.ItemClick
        Try
            Dim Path As String = Application.StartupPath & "\FileCompare.exe"
            If System.IO.File.Exists(Path) Then
                Dim frm As New frmLogin_Administrator
                frm.ShowDialog()
                If frm.Status = True Then
                    Process.Start(Path)
                Else
                    MsgBox("You dun have permission to use this feature.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Opss Sorry, This feature is not avaliable for temporary.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
End Class