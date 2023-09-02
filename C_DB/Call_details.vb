Public Class Call_details
    Private Sub Personal_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Personal_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Personal_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contact_DBDataSet)

    End Sub

    Private Sub Call_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Call_TB' table. You can move, or remove it, as needed.
        Me.Call_TBTableAdapter.Fill(Me.Contact_DBDataSet.Call_TB)
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Personal_TB' table. You can move, or remove it, as needed.
        Me.Personal_TBTableAdapter.Fill(Me.Contact_DBDataSet.Personal_TB)

    End Sub

    Private Sub Call_TBDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Call_TBDataGridView.CellContentClick
        If e.ColumnIndex = 5 Then
            ' View Call button clicked
            ' Get the ID of the selected Message
            Dim i As Integer = e.RowIndex
            Dim row As DataGridViewRow =
            Call_TBDataGridView.Rows(i)
            Dim cell As DataGridViewCell = row.Cells(1)
            Dim Call_ID As String = cell.Value
            ' Display the Form3 form
            Dim callForm As New Call_SubForm
            callForm.Tag = Call_ID
            callForm.ShowDialog()
        End If
    End Sub
End Class