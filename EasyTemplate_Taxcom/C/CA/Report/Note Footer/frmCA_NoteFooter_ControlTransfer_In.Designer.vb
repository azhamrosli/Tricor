<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCA_NoteFooter_ControlTransfer_In
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
        Me.txt_CA_PURCHASE_AMOUNT = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_TWDV_BF = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_CA_TRANSFER_VAL = New DevExpress.XtraEditors.TextEdit()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_CA_PURCHASE_AMOUNT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TWDV_BF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CA_TRANSFER_VAL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_CA_PURCHASE_AMOUNT
        '
        Me.txt_CA_PURCHASE_AMOUNT.Location = New System.Drawing.Point(168, 36)
        Me.txt_CA_PURCHASE_AMOUNT.Name = "txt_CA_PURCHASE_AMOUNT"
        Me.txt_CA_PURCHASE_AMOUNT.Size = New System.Drawing.Size(373, 20)
        Me.txt_CA_PURCHASE_AMOUNT.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(21, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(121, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Original Cost Transferred"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(168, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 14)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Note"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(21, 65)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Tax WDV Transferred"
        '
        'txt_TWDV_BF
        '
        Me.txt_TWDV_BF.Location = New System.Drawing.Point(168, 62)
        Me.txt_TWDV_BF.Name = "txt_TWDV_BF"
        Me.txt_TWDV_BF.Size = New System.Drawing.Size(373, 20)
        Me.txt_TWDV_BF.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(21, 91)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Transfer Value"
        '
        'txt_CA_TRANSFER_VAL
        '
        Me.txt_CA_TRANSFER_VAL.Location = New System.Drawing.Point(168, 88)
        Me.txt_CA_TRANSFER_VAL.Name = "txt_CA_TRANSFER_VAL"
        Me.txt_CA_TRANSFER_VAL.Size = New System.Drawing.Size(373, 20)
        Me.txt_CA_TRANSFER_VAL.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(434, 114)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(321, 114)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'frmCA_NoteFooter_ControlTransfer_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 153)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_CA_TRANSFER_VAL)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_TWDV_BF)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_CA_PURCHASE_AMOUNT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCA_NoteFooter_ControlTransfer_In"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Report (Footer Notes)"
        CType(Me.txt_CA_PURCHASE_AMOUNT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TWDV_BF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CA_TRANSFER_VAL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_CA_PURCHASE_AMOUNT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_TWDV_BF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_CA_TRANSFER_VAL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
End Class
