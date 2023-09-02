Public Class MessageForm
    Private Sub Personal_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Personal_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Personal_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contact_DBDataSet)

    End Sub

    Private Sub MessageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Message_TB' table. You can move, or remove it, as needed.
        Me.Message_TBTableAdapter.Fill(Me.Contact_DBDataSet.Message_TB)
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Personal_TB' table. You can move, or remove it, as needed.
        Me.Personal_TBTableAdapter.Fill(Me.Contact_DBDataSet.Personal_TB)

    End Sub

    Private Sub Message_TBDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Message_TBDataGridView.CellContentClick
        If e.ColumnIndex = 4 Then
            ' View Call button clicked
            ' Get the ID of the selected Message
            Dim i As Integer = e.RowIndex
            Dim row As DataGridViewRow =
            Message_TBDataGridView.Rows(i)
            Dim cell As DataGridViewCell = row.Cells(1)
            Dim Call_ID As String = cell.Value
            ' Display the Form3 form
            Dim callForm As New MSG_SubForm
            callForm.Tag = Call_ID
            callForm.ShowDialog()
        End If
    End Sub
End Class