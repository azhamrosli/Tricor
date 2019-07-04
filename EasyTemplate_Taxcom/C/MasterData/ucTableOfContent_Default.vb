Public Class ucTableOfContent_Default
    Dim ErrorLog As ClsError = Nothing
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If ADO Is Nothing Then
            ADO = New clsIODatabase
        End If
    End Sub
    Private Sub ucTableOfContent_Default_Load(sender As Object, e As EventArgs) Handles Me.Load
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

            DsReport_Templatexsd.Tables("TABLE_CONTENT_DEFAULT").Rows.Clear()

            dt = ADO.Load_TableofContent_Default()

            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    DsReport_Templatexsd.Tables("TABLE_CONTENT_DEFAULT").ImportRow(rowx)
                Next
            End If

            TABLECONTENTDEFAULTBindingSource.DataSource = DsReport_Templatexsd.Tables("TABLE_CONTENT_DEFAULT")

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
            DsReport_Templatexsd.Tables("TABLE_CONTENT_DEFAULT").AcceptChanges()

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            If DsReport_Templatexsd.Tables("TABLE_CONTENT_DEFAULT").Rows.Count > 0 Then

                DsReport_Templatexsd.Tables("TABLE_CONTENT_DEFAULT").AcceptChanges()
                Application.DoEvents()

                If ADO.Save_TableofContent_Default(DsReport_Templatexsd.Tables("TABLE_CONTENT_DEFAULT"), ErrorLog) Then
                    MsgBox("Successfully save table of content default.", MsgBoxStyle.Information)

                    LoadData()
                Else
                    MsgBox("Unsuccessfully save table of content default.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
End Class
