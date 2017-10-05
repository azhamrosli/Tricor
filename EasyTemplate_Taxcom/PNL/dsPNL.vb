

Partial Public Class dsPNL
    Partial Class PLFST_SALES_DETAILDataTable

        Private Sub PLFST_SALES_DETAILDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PLFSD_KEYColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
