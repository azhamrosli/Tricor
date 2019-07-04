Imports DevExpress.XtraPrinting
Imports DevExpress.LookAndFeel
Imports Microsoft.AspNet.SignalR.Client
Public Class frmHome
    Inherits DevExpress.XtraEditors.XtraForm

    Dim m_message As String = ""
    Dim m_name As String = ""
    Dim m_datetime As DateTime = Now
    Dim m_type As Integer = 0
    Dim m_connectionid As String = ""
    Dim m_clinetconnectionid As String = ""
    Dim m_listofUser As List(Of String)
    Dim m_listofUserConID As List(Of String)

    Dim ErrorLog As ClsError = Nothing
    Dim isChangeForm As Boolean = False
    Private Delegate Sub MyDelegate()
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
                'My.Settings.ThemeName = UserLookAndFeel.Default.SkinName
                'My.Settings.Save()
                If connection IsNot Nothing AndAlso connection.State = ConnectionState.Connected Then
                    disConnect()
                End If

                ADO.Update_Default_Theme(UserLookAndFeel.Default.SkinName)
                Application.DoEvents()

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

            Dim dtDefault As DataTable = ADO.Load_Default(ErrorLog)
            Application.DoEvents()
            LoadTreeList(dtDefault)
            Application.DoEvents()
            If dtDefault IsNot Nothing Then

                cboRefNo.EditValue = IIf(IsDBNull(dtDefault.Rows(0)("RefNo")), "", dtDefault.Rows(0)("RefNo"))
                cboYA.EditValue = IIf(IsDBNull(dtDefault.Rows(0)("YA")), Now.Year, dtDefault.Rows(0)("YA"))
                'Application.DoEvents()
                If mdlProcess.ArgParam0 = "" Then
                    mdlProcess.ArgParam0 = IIf(IsDBNull(dtDefault.Rows(0)("LastModule")), "frmpnl", dtDefault.Rows(0)("LastModule"))
                End If
                If mdlProcess.ArgParam0 = "" Then
                    mdlProcess.ArgParam0 = "frmpnl"
                End If

                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = IIf(IsDBNull(dtDefault.Rows(0)("ThemeName")), "Office 2013", dtDefault.Rows(0)("ThemeName"))
                '    FontEdit1.EditValue = IIf(IsDBNull(dtDefault.Rows(0)("FontName")), "Arial", dtDefault.Rows(0)("FontName"))
            Else
                ADO.Save_Default(mdlProcess.ArgParam2, mdlProcess.ArgParam3)
                If mdlProcess.ArgParam0 = "" Then
                    mdlProcess.ArgParam0 = "frmpnl"
                End If
            End If


            LoadData()
            RefreshData()

            If My.Computer.Name = DeveloperPCName AndAlso CheckForInternetConnection() Then
                myHub.On(Of String, String)("broadcastnotification", Sub(name As String, message As String)
                                                                         Me.m_name = name
                                                                         Me.m_message = message
                                                                         Me.m_type = 0
                                                                         Me.AppendNotificationBox()
                                                                     End Sub)

                'myHub.On(Of String, String, DateTime, String)("broadcastMessage", Sub(name As String, message As String, datetimex As DateTime, connectionid As String)
                '                                                                      Me.m_name = name
                '                                                                      Me.m_message = message
                '                                                                      Me.m_datetime = datetimex
                '                                                                      Me.m_clinetconnectionid = connectionid
                '                                                                      Me.m_type = 1
                '                                                                      If connectionid <> connection.ConnectionId Then
                '                                                                          My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
                '                                                                          isViewMessageCount += 1
                '                                                                      End If
                '                                                                      Me.AppendMessageBox()
                '                                                                  End Sub)
                myHub.On(Of List(Of String), List(Of String), String)("onConnected", Sub(ListofUser As List(Of String), ListofUserConID As List(Of String), connectionid As String)
                                                                                         Me.m_listofUser = ListofUser
                                                                                         Me.m_listofUserConID = ListofUserConID
                                                                                         Me.m_connectionid = connectionid
                                                                                         Me.AppendListConnect()
                                                                                     End Sub)
                '  connection = New HubConnection("http://localhost:8080")
                ' myHub = connection.CreateHubProxy("hitCounter")
                startConnect()

            End If
            

            btnDefaultCompanyOK.PerformClick()

            tlMenu.ExpandAll()
            DtErrorLogBindingSource.DataSource = dsDataSetErrorlog.Tables("dtErrorLog")
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
        Finally
            DeveloperOption()
        End Try

    End Sub
    Private Sub AppendNotificationBox()
        Try
            If Me.lblNotification.InvokeRequired Then
                Dim show As MyDelegate
                show = AddressOf AppendNotificationBox
                Me.lblNotification.Invoke(show)
            Else
                'Update the value of the textbox
                'lblNotification.Text = m_message.ToString
                'Dim frm As New frmNotification
                'frm.Msg = m_message.ToString
                'frm.Name = m_name.ToString
                'frm.Type = m_type
                'frm.Show()
                ToastNotificationsManager1.Notifications(0).Body = m_message.ToString
                ToastNotificationsManager1.Notifications(0).Header = m_name.ToString
                Application.DoEvents()



                ToastNotificationsManager1.ShowNotification(ToastNotificationsManager1.Notifications(0))

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub AppendListConnect()
        Try
            'If Me.lvUserOnline.InvokeRequired Then
            '    Dim show As MyDelegate
            '    show = AddressOf AppendListConnect
            '    Me.lvUserOnline.Invoke(show)
            'Else
            '    lvUserOnline.Items.Clear()
            '    If m_listofUser.Count > 0 Then
            '        Dim itm As ListViewItem
            '        Dim subitm As ListViewItem.ListViewSubItem
            '        lvUserOnline.BeginUpdate()

            '        For i As Integer = 0 To m_listofUser.Count - 1
            '            itm = New ListViewItem

            '            itm.Text = m_listofUser(i)

            '            subitm = New ListViewItem.ListViewSubItem
            '            subitm.Text = m_listofUserConID(i)
            '            itm.SubItems.Add(subitm)

            '            lvUserOnline.Items.Add(itm)
            '        Next
            '        lvUserOnline.EndUpdate()
            '    End If
            'End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub LoadTreeList(ByVal dtDefault As DataTable)
        Try
            Dim dt As DataTable = Nothing
            If dtDefault IsNot Nothing AndAlso dtDefault.Rows.Count > 0 AndAlso IsDBNull(dtDefault.Rows(0)("HasRestricted")) = False AndAlso dtDefault.Rows(0)("HasRestricted") = True Then
                dt = ADO.LoadMenuList_Tree(dtDefault.Rows(0)("LastModule"), ErrorLog)
            Else
                dt = ADO.LoadMenuList_Tree(ErrorLog)
            End If


            DsDefault.Tables("MENU_LIST_INFO").Rows.Clear()
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    DsDefault.Tables("MENU_LIST_INFO").ImportRow(rowx)
                Next
            Else
                MsgBox("Tree Menu List is nothing", MsgBoxStyle.Critical)
            End If
            MENULISTINFOBindingSource.DataSource = DsDefault.Tables("MENU_LIST_INFO")

            tlMenu.ExpandAll()

            If dt IsNot Nothing AndAlso dt.Rows.Count = 1 Then
                docMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                docDefaultCompany.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            Else
                docMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
                docDefaultCompany.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
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
        End Try
    End Sub
    Public Sub LoadData()
        Try
           
            'If My.Settings.LastModule Is Nothing OrElse My.Settings.LastModule = "" Then
            '    mdlProcess.ArgParam0 = "frmpnl"
            'Else
            '    mdlProcess.ArgParam0 = My.Settings.LastModule
            'End If

            'If My.Settings.RefNo IsNot Nothing AndAlso My.Settings.RefNo <> "" Then
            '    cboRefNo.EditValue = My.Settings.RefNo
            'End If
            'If My.Settings.YA IsNot Nothing AndAlso My.Settings.YA <> "" Then
            '    cboYA.EditValue = My.Settings.YA
            'End If

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
                Case "frmadjustedincome"
                    docMain.Controls.Clear()
                    Dim uc As New ucAdjustedIncome With {
                        .Dock = DockStyle.Fill
                    }
                    uc.txtRefNo.EditValue = mdlProcess.ArgParam2
                    uc.cboYA.EditValue = mdlProcess.ArgParam3
                    docMain.Text = "Adjusted Income"
                    docMain.Controls.Add(uc)
                Case "frmtaxcomputation"
                    Dim frm As New frmTaxComputation_Add
                    frm.ShowDialog()
                Case "frmtableofcontent_default"
                    docMain.Controls.Clear()
                    Dim uc As New ucTableOfContent_Default With {
                        .Dock = DockStyle.Fill
                    }
                    docMain.Text = "Table of Content Default"
                    docMain.Controls.Add(uc)
                Case "frmmapping_code_list"
                    docMain.Controls.Clear()
                    Dim uc As New ucMapping_Code_List With {
                        .Dock = DockStyle.Fill
                    }
                    docMain.Text = "Mapping Code List"
                    docMain.Controls.Add(uc)
                Case "frmmapping_setting"
                    docMain.Controls.Clear()
                    Dim uc As New ucMapping_Setting With {
                        .Dock = DockStyle.Fill
                    }
                    docMain.Text = "Mapping Configuration"
                    docMain.Controls.Add(uc)
                Case "frmmapping_import"
                    'docMain.Controls.Clear()
                    'Dim uc As New ucMapping_Import With {
                    '    .Dock = DockStyle.Fill
                    '}
                    'docMain.Text = "Import Account"
                    'docMain.Controls.Add(uc)
                    Dim frm As New frmMapping_Import_1
                    frm.ShowDialog()

                Case Else
                    MsgBox("Unable to find form name " & mdlProcess.ArgParam0)
                    Me.Close()
            End Select


            'If mdlProcess.ArgParam0 <> "" Then
            '    My.Settings.LastModule = mdlProcess.ArgParam0
            '    My.Settings.Save()
            'End If
            ADO.Update_Default(mdlProcess.ArgParam0)

            If YGLClient IsNot Nothing Then
                Me.Text = "Welcome to TaxOffice -" & IIf(IsDBNull(YGLClient("CompanyName")), "", YGLClient("CompanyName"))
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
        Finally
            If docMain.Visibility <> DevExpress.XtraBars.Docking.DockVisibility.Visible Then
                docMain.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            End If

            'If DeveloperPCName = My.Computer.Name Then
            '    If mdlProcess.ArgParam2.ToString <> "" Then
            '        cboRefNo.EditValue = mdlProcess.ArgParam2
            '    End If

            '    If mdlProcess.ArgParam3.ToString <> "" Then
            '        cboYA.EditValue = mdlProcess.ArgParam3
            '    End If
            'End If


        End Try
    End Sub

    Private Sub TreeList1_DoubleClick(sender As Object, e As EventArgs) Handles tlMenu.DoubleClick
        Try
            Dim val As String = tlMenu.FocusedNode.GetValue("Title") 'tlMenu.FocusedNode.GetDisplayText("Menu")

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
                    Case "Adjusted Income"
                        mdlProcess.ArgParam0 = "frmadjustedincome"
                    Case "Tax Computation"
                        mdlProcess.ArgParam0 = "frmtaxcomputation"
                    Case "A.11 Mapping Code List"
                        mdlProcess.ArgParam0 = "frmmapping_code_list"
                    Case "A.12 Mapping Configuration"
                        mdlProcess.ArgParam0 = "frmmapping_setting"
                    Case "Import Account"
                        mdlProcess.ArgParam0 = "frmmapping_import"
                    Case ""
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

            If ADO.Update_Default(cboRefNo.EditValue, CStr(cboYA.EditValue)) Then

            End If
            'My.Settings.RefNo = cboRefNo.EditValue
            'My.Settings.YA = cboYA.EditValue
            'My.Settings.Save()

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

    Private Sub btnSetting_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetting.ItemClick
        Try
            frmSetting.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim dtDefault As DataTable = ADO.Load_Default(ErrorLog)
        Application.DoEvents()
        Me.LoadTreeList(dtDefault)
    End Sub

    Private Sub BarToggleSwitchItem1_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarToggleSwitchItem1.CheckedChanged
        Try

            If BarToggleSwitchItem1.Checked = True Then
                Dim frm As New frmLogin_Administrator
                frm.ShowDialog()
                If frm.Status = True Then
                    DeveloperPCName = My.Computer.Name
                    Application.DoEvents()
                    Dim dtDefault As DataTable = ADO.Load_Default(ErrorLog)
                    Application.DoEvents()
                    LoadTreeList(dtDefault)
                Else
                    BarToggleSwitchItem1.Checked = False
                    MsgBox("You dun have permission to use this feature.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Else
                DeveloperPCName = "AZHAM-LAPTOP"
            End If
            Application.DoEvents()
            LoadData()

        Catch ex As Exception
        Finally
            DeveloperOption()
        End Try
    End Sub
    Private Sub DeveloperOption()
        Try

            If My.Computer.Name = DeveloperPCName Then
                btnCopyGoogleDrive.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                btnCopyGoogleDrive.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCopyGoogleDrive_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCopyGoogleDrive.ItemClick
        Try
            Dim ExePath As String = Application.StartupPath & "\ET_Taxcom.exe"
            Dim GoogleDrivePath As String = "C:\Users\Azham\Google Drive\TAXCOM\TaxOffice Tricor Version\Testing Full"

            If System.IO.File.Exists(ExePath) = False Then
                MsgBox("Application not exist.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If System.IO.Directory.Exists(GoogleDrivePath) = False Then
                MsgBox("Directory not exist. for 'C:\Users\Azham\Google Drive\TAXCOM\TaxOffice Tricor Version\Testing Full'", MsgBoxStyle.Critical)
                Exit Sub
            End If

            My.Computer.FileSystem.CopyFile(ExePath, GoogleDrivePath & "\ET_Taxcom.exe", Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)

            MsgBox("Done copy!!!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Failed to copy." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class