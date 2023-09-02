Public Class Call_SubForm
    Private Sub Call_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Call_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Call_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contact_DBDataSet)

    End Sub

    Private Sub Call_SubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Call_ID As String = Me.Tag
        Try
            Me.Call_TBTableAdapter.FillByC_ID(Me.Contact_DBDataSet.Call_TB,
            CType(Call_ID, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class