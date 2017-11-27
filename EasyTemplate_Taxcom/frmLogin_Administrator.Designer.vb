<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin_Administrator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin_Administrator))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPass = New DevExpress.XtraEditors.TextEdit()
        Me.btnLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(33, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(148, 18)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Administrator Login"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(33, 72)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Password :"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(102, 69)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(234, 20)
        Me.txtPass.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.Location = New System.Drawing.Point(150, 95)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(90, 23)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(246, 95)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'frmLogin_Administrator
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(390, 149)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin_Administrator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Administrator"
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
End Class
