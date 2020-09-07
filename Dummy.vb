Public Class Dummy
    Private Sub Dummy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Email_LocalDataSet1.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.Email_LocalDataSet1.user)
        'TODO: This line of code loads data into the 'Email_LocalDataSet1.email' table. You can move, or remove it, as needed.
        Me.EmailTableAdapter.Fill(Me.Email_LocalDataSet1.email)

    End Sub

    Private Sub UserBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles UserBindingSource.CurrentChanged

    End Sub
End Class