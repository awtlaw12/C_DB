Public Class PersonForm
    Private Sub Personal_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Personal_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Personal_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contact_DBDataSet)

    End Sub

    Private Sub PersonForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Personal_TB' table. You can move, or remove it, as needed.
        Me.Personal_TBTableAdapter.Fill(Me.Contact_DBDataSet.Personal_TB)

    End Sub
End Class