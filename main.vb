Public Class frmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load databound tabel untuk receive messeage
        'cek apakah ada unread messeage jika ada tampilan msgbox
    End Sub
    Private Sub btnReceive_Click(sender As Object, e As EventArgs) Handles btnReceive.Click
        pnlOnButtonPosition.Height = btnReceive.Height
        pnlOnButtonPosition.Top = btnReceive.Top
        'load tabel untuk receive messeage
    End Sub

    Private Sub btnSent_Click(sender As Object, e As EventArgs) Handles btnSent.Click
        pnlOnButtonPosition.Height = btnSent.Height
        pnlOnButtonPosition.Top = btnSent.Top
        'load tabel untuk sent messeage
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub picMaximize_Click(sender As Object, e As EventArgs) Handles picMaximize.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If

    End Sub

    Private Sub lblLogInOut_Click(sender As Object, e As EventArgs) Handles lblLogInOut.Click
        If (lblLogInOut.Text = "Log In") Then
            Login.Show()
            'save id user ke variabel global
        Else
            lblLogInOut.Text = "Log In"
            'hapus isi variabel berisi id user menjadi NULL
        End If
    End Sub

    Private Sub picKirim_Click(sender As Object, e As EventArgs) Handles picKirim.Click
        compose.Show()
    End Sub

End Class
