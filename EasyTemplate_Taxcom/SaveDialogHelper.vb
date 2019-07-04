Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Localization
Imports System
Imports System.Windows.Forms

Public Class SaveDialogHelper
    Private gridView As GridView
    Private outerClick As Boolean = False

    Public Sub New(ByVal provideYourGridView As GridView)
        gridView = provideYourGridView
        AddHandler gridView.MouseDown, AddressOf GridView1_MouseDown
        AddHandler gridView.ShownEditor, AddressOf GridView1_ShownEditor
        AddHandler gridView.CellValueChanged, AddressOf GridView1_CellValueChanged
        ' gridView.MouseDown += AddressOf GridView1_MouseDown
        ' gridView.ShownEditor += AddressOf GridView1_ShownEditor
        ' gridView.CellValueChanged += AddressOf GridView1_CellValueChanged
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        If Not outerClick Then
            Return
        End If

        Dim result = XtraMessageBox.Show(gridView.GridControl.FindForm(), GridLocalizer.Active.GetLocalizedString(GridStringId.EditFormSaveMessage), GridLocalizer.Active.GetLocalizedString(GridStringId.WindowWarningCaption), MessageBoxButtons.YesNo)
        If result <> DialogResult.Yes Then gridView.CancelUpdateCurrentRow()
    End Sub

    Private Sub GridView1_ShownEditor(ByVal sender As Object, ByVal e As EventArgs)
        outerClick = True
    End Sub

    Private Sub GridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        outerClick = False
    End Sub
End Class
