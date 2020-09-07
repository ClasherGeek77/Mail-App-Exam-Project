<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dummy
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
        Me.Email_LocalDataSet1 = New Modern_Flat_UI___Food_Application.Email_LocalDataSet()
        Me.EmailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailTableAdapter = New Modern_Flat_UI___Food_Application.Email_LocalDataSetTableAdapters.emailTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IduserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New Modern_Flat_UI___Food_Application.Email_LocalDataSetTableAdapters.userTableAdapter()
        CType(Me.Email_LocalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Email_LocalDataSet1
        '
        Me.Email_LocalDataSet1.DataSetName = "Email_LocalDataSet"
        Me.Email_LocalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmailBindingSource
        '
        Me.EmailBindingSource.DataMember = "email"
        Me.EmailBindingSource.DataSource = Me.Email_LocalDataSet1
        '
        'EmailTableAdapter
        '
        Me.EmailTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IduserDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.UserBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(476, 150)
        Me.DataGridView2.TabIndex = 1
        '
        'IduserDataGridViewTextBoxColumn
        '
        Me.IduserDataGridViewTextBoxColumn.DataPropertyName = "id_user"
        Me.IduserDataGridViewTextBoxColumn.HeaderText = "id_user"
        Me.IduserDataGridViewTextBoxColumn.Name = "IduserDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.Email_LocalDataSet1
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'Dummy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "Dummy"
        Me.Text = "dummy"
        CType(Me.Email_LocalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Email_LocalDataSet1 As Email_LocalDataSet
    Friend WithEvents EmailBindingSource As BindingSource
    Friend WithEvents EmailTableAdapter As Email_LocalDataSetTableAdapters.emailTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As Email_LocalDataSetTableAdapters.userTableAdapter
    Friend WithEvents IduserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
