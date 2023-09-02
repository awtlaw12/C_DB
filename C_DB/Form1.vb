Public Class Form1
    Private Sub Personal_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Personal_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Personal_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contact_DBDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contact_DBDataSet.Personal_TB' table. You can move, or remove it, as needed.
        Me.Personal_TBTableAdapter.Fill(Me.Contact_DBDataSet.Personal_TB)

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        PersonForm.Show()
    End Sub

    Private Sub FillByP_IDToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByP_IDToolStripButton.Click
        Try
            Me.Personal_TBTableAdapter.FillByP_ID(Me.Contact_DBDataSet.Personal_TB, CType(P_IDToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Personal_TBTableAdapter.Fill(Me.Contact_DBDataSet.Personal_TB)
    End Sub

    Private Sub btnCall_Click(sender As Object, e As EventArgs) Handles btnCall.Click
        Call_details.Show()
    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        MessageForm.Show()
    End Sub
End Class
