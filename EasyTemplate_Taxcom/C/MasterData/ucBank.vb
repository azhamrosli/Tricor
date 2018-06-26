Public Class ucBank
    Dim ErrorLog As ClsError = Nothing
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If ADO Is Nothing Then
            ADO = New clsIODatabase
        End If
    End Sub
    Private Sub ucBank_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub LoadData()
        Try
            Dim dt As DataTable = Nothing

            DsDefault.Tables("BANK").Rows.Clear()
            DsDefault.Tables("BANK_CODE").Rows.Clear()

            dt = ADO.Load_BankCode()

            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    DsDefault.Tables("BANK_CODE").ImportRow(rowx)
                Next
            End If

            BANKCODEBindingSource.DataSource = DsDefault.Tables("BANK_CODE")

            dt = Nothing

            dt = ADO.Load_Bank

            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    DsDefault.Tables("BANK").ImportRow(rowx)
                Next
            End If

            BANKBindingSource.DataSource = DsDefault.Tables("BANK")


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

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            GridView1.DeleteSelectedRows()
            Application.DoEvents()
            DsDefault.Tables("BANK").AcceptChanges()

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Try
            If e.Column.FieldName = "BK_CODE" Then
                Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

                If row IsNot Nothing AndAlso IsDBNull(row("BK_CODE")) = False OrElse row("BK_CODE") <> "" Then

                    row("BK_DESC") = cboBank.GetDisplayText(row("BK_CODE"))

                End If

            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            If DsDefault.Tables("BANK").Rows.Count > 0 Then

                DsDefault.Tables("BANK").AcceptChanges()
                Application.DoEvents()

                If ADO.Save_Bank(DsDefault.Tables("BANK"), ErrorLog) Then
                    MsgBox("Successfully save bank.", MsgBoxStyle.Information)

                    LoadData()
                Else
                    MsgBox("Unsuccessfully save bank.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
End Class
