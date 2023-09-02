Public Class MSG_SubForm
    Private Sub Message_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Message_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Message_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contact_DBDataSet)

    End Sub

    Private Sub MSG_SubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Message_ID As String = Me.Tag
        Try
            Me.Message_TBTableAdapter.FillByM_ID(Me.Contact_DBDataSet.Message_TB,
            CType(Message_ID, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class