<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Personal_TBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Personal_TBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Personal_TBDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnCall = New System.Windows.Forms.Button()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.FillByP_IDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.P_IDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.P_IDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByP_IDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Personal_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contact_DBDataSet = New C_DB.Contact_DBDataSet()
        Me.Personal_TBTableAdapter = New C_DB.Contact_DBDataSetTableAdapters.Personal_TBTableAdapter()
        Me.TableAdapterManager = New C_DB.Contact_DBDataSetTableAdapters.TableAdapterManager()
        CType(Me.Personal_TBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Personal_TBBindingNavigator.SuspendLayout()
        CType(Me.Personal_TBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByP_IDToolStrip.SuspendLayout()
        CType(Me.Personal_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contact_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Personal_TBBindingNavigator
        '
        Me.Personal_TBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Personal_TBBindingNavigator.BindingSource = Me.Personal_TBBindingSource
        Me.Personal_TBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Personal_TBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Personal_TBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Personal_TBBindingNavigatorSaveItem})
        Me.Personal_TBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Personal_TBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Personal_TBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Personal_TBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Personal_TBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Personal_TBBindingNavigator.Name = "Personal_TBBindingNavigator"
        Me.Personal_TBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Personal_TBBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Personal_TBBindingNavigator.TabIndex = 0
        Me.Personal_TBBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Personal_TBBindingNavigatorSaveItem
        '
        Me.Personal_TBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Personal_TBBindingNavigatorSaveItem.Image = CType(resources.GetObject("Personal_TBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Personal_TBBindingNavigatorSaveItem.Name = "Personal_TBBindingNavigatorSaveItem"
        Me.Personal_TBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Personal_TBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Personal_TBDataGridView
        '
        Me.Personal_TBDataGridView.AutoGenerateColumns = False
        Me.Personal_TBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Personal_TBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Personal_TBDataGridView.DataSource = Me.Personal_TBBindingSource
        Me.Personal_TBDataGridView.Location = New System.Drawing.Point(0, 49)
        Me.Personal_TBDataGridView.Name = "Personal_TBDataGridView"
        Me.Personal_TBDataGridView.Size = New System.Drawing.Size(747, 220)
        Me.Personal_TBDataGridView.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(145, 323)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show  "
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnCall
        '
        Me.btnCall.Location = New System.Drawing.Point(289, 323)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.Size = New System.Drawing.Size(75, 23)
        Me.btnCall.TabIndex = 2
        Me.btnCall.Text = "Call "
        Me.btnCall.UseVisualStyleBackColor = True
        '
        'btnMessage
        '
        Me.btnMessage.Location = New System.Drawing.Point(457, 323)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(75, 23)
        Me.btnMessage.TabIndex = 2
        Me.btnMessage.Text = "Message "
        Me.btnMessage.UseVisualStyleBackColor = True
        '
        'FillByP_IDToolStrip
        '
        Me.FillByP_IDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.P_IDToolStripLabel, Me.P_IDToolStripTextBox, Me.FillByP_IDToolStripButton, Me.ToolStripButton1})
        Me.FillByP_IDToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByP_IDToolStrip.Name = "FillByP_IDToolStrip"
        Me.FillByP_IDToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.FillByP_IDToolStrip.TabIndex = 3
        Me.FillByP_IDToolStrip.Text = "FillByP_IDToolStrip"
        '
        'P_IDToolStripLabel
        '
        Me.P_IDToolStripLabel.Name = "P_IDToolStripLabel"
        Me.P_IDToolStripLabel.Size = New System.Drawing.Size(103, 22)
        Me.P_IDToolStripLabel.Text = "Enter ID to Search:"
        '
        'P_IDToolStripTextBox
        '
        Me.P_IDToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.P_IDToolStripTextBox.Name = "P_IDToolStripTextBox"
        Me.P_IDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByP_IDToolStripButton
        '
        Me.FillByP_IDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByP_IDToolStripButton.Name = "FillByP_IDToolStripButton"
        Me.FillByP_IDToolStripButton.Size = New System.Drawing.Size(49, 22)
        Me.FillByP_IDToolStripButton.Text = "Search "
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton1.Text = "View All"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "P_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "P_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DateOfBirth"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DateOfBirth"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "eMail"
        Me.DataGridViewTextBoxColumn6.HeaderText = "eMail"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Details"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Details"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Personal_TBBindingSource
        '
        Me.Personal_TBBindingSource.DataMember = "Personal_TB"
        Me.Personal_TBBindingSource.DataSource = Me.Contact_DBDataSet
        '
        'Contact_DBDataSet
        '
        Me.Contact_DBDataSet.DataSetName = "Contact_DBDataSet"
        Me.Contact_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Personal_TBTableAdapter
        '
        Me.Personal_TBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Call_TBTableAdapter = Nothing
        Me.TableAdapterManager.Message_TBTableAdapter = Nothing
        Me.TableAdapterManager.Personal_TBTableAdapter = Me.Personal_TBTableAdapter
        Me.TableAdapterManager.UpdateOrder = C_DB.Contact_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FillByP_IDToolStrip)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.btnCall)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Personal_TBDataGridView)
        Me.Controls.Add(Me.Personal_TBBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Personal_TBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Personal_TBBindingNavigator.ResumeLayout(False)
        Me.Personal_TBBindingNavigator.PerformLayout()
        CType(Me.Personal_TBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByP_IDToolStrip.ResumeLayout(False)
        Me.FillByP_IDToolStrip.PerformLayout()
        CType(Me.Personal_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contact_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Contact_DBDataSet As Contact_DBDataSet
    Friend WithEvents Personal_TBBindingSource As BindingSource
    Friend WithEvents Personal_TBTableAdapter As Contact_DBDataSetTableAdapters.Personal_TBTableAdapter
    Friend WithEvents TableAdapterManager As Contact_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Personal_TBBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Personal_TBBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Personal_TBDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents btnShow As Button
    Friend WithEvents btnCall As Button
    Friend WithEvents btnMessage As Button
    Friend WithEvents FillByP_IDToolStrip As ToolStrip
    Friend WithEvents P_IDToolStripLabel As ToolStripLabel
    Friend WithEvents P_IDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByP_IDToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
