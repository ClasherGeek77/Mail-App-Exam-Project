Public Class Create

    Private Sub picSeePass_MouseHover(sender As Object, e As EventArgs) Handles picSeePass.MouseHover
        txtPass.PasswordChar = ""
        txtConfirmPass.PasswordChar = ""
    End Sub
    Private Sub picSeePass_MouseLeave(sender As Object, e As EventArgs) Handles picSeePass.MouseLeave
        txtPass.PasswordChar = "*"
        txtConfirmPass.PasswordChar = "*"
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'masukkan data dari txtbox ke tabel User
        Login.Show()
        Me.Close()
    End Sub

End Class