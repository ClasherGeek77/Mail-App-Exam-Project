Public Class Login

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        txtPass.PasswordChar = ""
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'cari id user sesuai dengan data yang diinput
        'jika gk ketemu munculin msgbox
        frmMain.Show()
        frmMain.lblLogInOut.Text = "Log Out"
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblCreateAcc.Click
        Create.Show()
        Me.Close()

    End Sub

    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles picClose1.Click
        Me.Close()
    End Sub

    Private Sub PicMaximize1_Click(sender As Object, e As EventArgs) Handles picMaximize1.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub PicMinimize1_Click(sender As Object, e As EventArgs) Handles picMinimize1.Click
        Me.WindowState = WindowState.Minimized
    End Sub
End Class