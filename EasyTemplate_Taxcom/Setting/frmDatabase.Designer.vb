<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabase
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem9 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip10 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem10 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatabase))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtServerName = New DevExpress.XtraEditors.TextEdit()
        Me.txtUser = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.chkTAX_CA_B = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTAX_CA_C = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTAX_CA_P = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTAXCOM_B = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTAXCOM_P = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTAXCOM_C = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTAXCOM_R = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTAXOFFICE = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnViewPass = New DevExpress.XtraEditors.SimpleButton()
        Me.chkSelectAll = New DevExpress.XtraEditors.CheckEdit()
        Me.btnBackup = New DevExpress.XtraBars.BarButtonItem()
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIniDir = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTAX_CA_B.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTAX_CA_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTAX_CA_P.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTAXCOM_B.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTAXCOM_P.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTAXCOM_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTAXCOM_R.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTAXOFFICE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelectAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIniDir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnDelete, Me.btnBackup})
        Me.BarManager1.MaxItemId = 12
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(271, 130)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBackup)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "Save"
        Me.btnAdd.Glyph = CType(resources.GetObject("btnAdd.Glyph"), System.Drawing.Image)
        Me.btnAdd.Id = 0
        Me.btnAdd.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.btnAdd.LargeGlyph = CType(resources.GetObject("btnAdd.LargeGlyph"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem9.Text = "Add new record"
        ToolTipItem9.LeftIndent = 6
        ToolTipItem9.Text = "Add new record Ctrl + R"
        SuperToolTip9.Items.Add(ToolTipTitleItem9)
        SuperToolTip9.Items.Add(ToolTipItem9)
        Me.btnAdd.SuperTip = SuperToolTip9
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Close"
        Me.btnDelete.Glyph = CType(resources.GetObject("btnDelete.Glyph"), System.Drawing.Image)
        Me.btnDelete.Id = 4
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete)
        Me.btnDelete.LargeGlyph = CType(resources.GetObject("btnDelete.LargeGlyph"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem10.Text = "Delete record"
        ToolTipItem10.LeftIndent = 6
        ToolTipItem10.Text = "Delete record Ctrl + Y"
        SuperToolTip10.Items.Add(ToolTipTitleItem10)
        SuperToolTip10.Items.Add(ToolTipItem10)
        Me.btnDelete.SuperTip = SuperToolTip10
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(430, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 447)
        Me.barDockControlBottom.Size = New System.Drawing.Size(430, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 416)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(430, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 416)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "n"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.ReadOnly = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 73)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Server Name :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 99)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "User Name :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 125)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Password :"
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(100, 70)
        Me.txtServerName.MenuManager = Me.BarManager1
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(314, 20)
        Me.txtServerName.TabIndex = 7
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(100, 96)
        Me.txtUser.MenuManager = Me.BarManager1
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(314, 20)
        Me.txtUser.TabIndex = 8
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(100, 122)
        Me.txtPassword.MenuManager = Me.BarManager1
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(278, 20)
        Me.txtPassword.TabIndex = 9
        '
        'chkTAX_CA_B
        '
        Me.chkTAX_CA_B.Location = New System.Drawing.Point(12, 201)
        Me.chkTAX_CA_B.MenuManager = Me.BarManager1
        Me.chkTAX_CA_B.Name = "chkTAX_CA_B"
        Me.chkTAX_CA_B.Properties.Caption = "TAX_CA_B"
        Me.chkTAX_CA_B.Size = New System.Drawing.Size(75, 19)
        Me.chkTAX_CA_B.TabIndex = 10
        '
        'chkTAX_CA_C
        '
        Me.chkTAX_CA_C.Location = New System.Drawing.Point(12, 226)
        Me.chkTAX_CA_C.MenuManager = Me.BarManager1
        Me.chkTAX_CA_C.Name = "chkTAX_CA_C"
        Me.chkTAX_CA_C.Properties.Caption = "TAX_CA_C"
        Me.chkTAX_CA_C.Size = New System.Drawing.Size(75, 19)
        Me.chkTAX_CA_C.TabIndex = 11
        '
        'chkTAX_CA_P
        '
        Me.chkTAX_CA_P.Location = New System.Drawing.Point(12, 251)
        Me.chkTAX_CA_P.MenuManager = Me.BarManager1
        Me.chkTAX_CA_P.Name = "chkTAX_CA_P"
        Me.chkTAX_CA_P.Properties.Caption = "TAX_CA_P"
        Me.chkTAX_CA_P.Size = New System.Drawing.Size(75, 19)
        Me.chkTAX_CA_P.TabIndex = 12
        '
        'chkTAXCOM_B
        '
        Me.chkTAXCOM_B.Location = New System.Drawing.Point(12, 276)
        Me.chkTAXCOM_B.MenuManager = Me.BarManager1
        Me.chkTAXCOM_B.Name = "chkTAXCOM_B"
        Me.chkTAXCOM_B.Properties.Caption = "TAXCOM_B"
        Me.chkTAXCOM_B.Size = New System.Drawing.Size(75, 19)
        Me.chkTAXCOM_B.TabIndex = 13
        '
        'chkTAXCOM_P
        '
        Me.chkTAXCOM_P.Location = New System.Drawing.Point(12, 301)
        Me.chkTAXCOM_P.MenuManager = Me.BarManager1
        Me.chkTAXCOM_P.Name = "chkTAXCOM_P"
        Me.chkTAXCOM_P.Properties.Caption = "TAXCOM_P"
        Me.chkTAXCOM_P.Size = New System.Drawing.Size(75, 19)
        Me.chkTAXCOM_P.TabIndex = 14
        '
        'chkTAXCOM_C
        '
        Me.chkTAXCOM_C.Location = New System.Drawing.Point(12, 326)
        Me.chkTAXCOM_C.MenuManager = Me.BarManager1
        Me.chkTAXCOM_C.Name = "chkTAXCOM_C"
        Me.chkTAXCOM_C.Properties.Caption = "TAXCOM_C"
        Me.chkTAXCOM_C.Size = New System.Drawing.Size(75, 19)
        Me.chkTAXCOM_C.TabIndex = 15
        '
        'chkTAXCOM_R
        '
        Me.chkTAXCOM_R.Location = New System.Drawing.Point(12, 351)
        Me.chkTAXCOM_R.MenuManager = Me.BarManager1
        Me.chkTAXCOM_R.Name = "chkTAXCOM_R"
        Me.chkTAXCOM_R.Properties.Caption = "TAXCOM_R"
        Me.chkTAXCOM_R.Size = New System.Drawing.Size(75, 19)
        Me.chkTAXCOM_R.TabIndex = 16
        '
        'chkTAXOFFICE
        '
        Me.chkTAXOFFICE.Location = New System.Drawing.Point(12, 376)
        Me.chkTAXOFFICE.MenuManager = Me.BarManager1
        Me.chkTAXOFFICE.Name = "chkTAXOFFICE"
        Me.chkTAXOFFICE.Properties.Caption = "TAXOFFICE"
        Me.chkTAXOFFICE.Size = New System.Drawing.Size(75, 19)
        Me.chkTAXOFFICE.TabIndex = 17
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 179)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(112, 16)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Backup Database"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(12, 37)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(153, 16)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Configuration Database"
        '
        'btnViewPass
        '
        Me.btnViewPass.Image = CType(resources.GetObject("btnViewPass.Image"), System.Drawing.Image)
        Me.btnViewPass.Location = New System.Drawing.Point(384, 120)
        Me.btnViewPass.Name = "btnViewPass"
        Me.btnViewPass.Size = New System.Drawing.Size(30, 23)
        Me.btnViewPass.TabIndex = 24
        '
        'chkSelectAll
        '
        Me.chkSelectAll.Location = New System.Drawing.Point(12, 401)
        Me.chkSelectAll.MenuManager = Me.BarManager1
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Properties.Caption = "Select All"
        Me.chkSelectAll.Size = New System.Drawing.Size(75, 19)
        Me.chkSelectAll.TabIndex = 29
        '
        'btnBackup
        '
        Me.btnBackup.Caption = "Backup Database"
        Me.btnBackup.Glyph = CType(resources.GetObject("btnBackup.Glyph"), System.Drawing.Image)
        Me.btnBackup.Id = 11
        Me.btnBackup.LargeGlyph = CType(resources.GetObject("btnBackup.LargeGlyph"), System.Drawing.Image)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblStatus.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lblStatus.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblStatus.Location = New System.Drawing.Point(127, 204)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(287, 216)
        Me.lblStatus.TabIndex = 30
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(384, 146)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(30, 23)
        Me.SimpleButton1.TabIndex = 33
        '
        'txtIniDir
        '
        Me.txtIniDir.Location = New System.Drawing.Point(100, 148)
        Me.txtIniDir.MenuManager = Me.BarManager1
        Me.txtIniDir.Name = "txtIniDir"
        Me.txtIniDir.Size = New System.Drawing.Size(278, 20)
        Me.txtIniDir.TabIndex = 32
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 151)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl6.TabIndex = 31
        Me.LabelControl6.Text = "Active Directory :"
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 447)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtIniDir)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.chkSelectAll)
        Me.Controls.Add(Me.btnViewPass)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.chkTAXOFFICE)
        Me.Controls.Add(Me.chkTAXCOM_R)
        Me.Controls.Add(Me.chkTAXCOM_C)
        Me.Controls.Add(Me.chkTAXCOM_P)
        Me.Controls.Add(Me.chkTAXCOM_B)
        Me.Controls.Add(Me.chkTAX_CA_P)
        Me.Controls.Add(Me.chkTAX_CA_C)
        Me.Controls.Add(Me.chkTAX_CA_B)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Configuration"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTAX_CA_B.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTAX_CA_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTAX_CA_P.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTAXCOM_B.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTAXCOM_P.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTAXCOM_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTAXCOM_R.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTAXOFFICE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelectAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIniDir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkTAXOFFICE As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTAXCOM_R As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTAXCOM_C As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTAXCOM_P As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTAXCOM_B As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTAX_CA_P As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTAX_CA_C As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTAX_CA_B As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtServerName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnViewPass As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkSelectAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnBackup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIniDir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
