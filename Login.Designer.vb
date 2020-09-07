<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.picMail = New System.Windows.Forms.PictureBox()
        Me.picMaximize1 = New System.Windows.Forms.PictureBox()
        Me.picMinimize1 = New System.Windows.Forms.PictureBox()
        Me.picClose1 = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblCreate = New System.Windows.Forms.Label()
        Me.lblCreateAcc = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.picMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMaximize1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMail
        '
        Me.picMail.Image = CType(resources.GetObject("picMail.Image"), System.Drawing.Image)
        Me.picMail.Location = New System.Drawing.Point(214, 57)
        Me.picMail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picMail.Name = "picMail"
        Me.picMail.Size = New System.Drawing.Size(124, 116)
        Me.picMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMail.TabIndex = 16
        Me.picMail.TabStop = False
        '
        'picMaximize1
        '
        Me.picMaximize1.BackgroundImage = Global.Modern_Flat_UI___Food_Application.My.Resources.Resources.btnMaximize
        Me.picMaximize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMaximize1.Location = New System.Drawing.Point(49, 6)
        Me.picMaximize1.Name = "picMaximize1"
        Me.picMaximize1.Size = New System.Drawing.Size(18, 18)
        Me.picMaximize1.TabIndex = 19
        Me.picMaximize1.TabStop = False
        '
        'picMinimize1
        '
        Me.picMinimize1.BackgroundImage = Global.Modern_Flat_UI___Food_Application.My.Resources.Resources.btnMinimize
        Me.picMinimize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMinimize1.Location = New System.Drawing.Point(28, 6)
        Me.picMinimize1.Name = "picMinimize1"
        Me.picMinimize1.Size = New System.Drawing.Size(18, 18)
        Me.picMinimize1.TabIndex = 18
        Me.picMinimize1.TabStop = False
        '
        'picClose1
        '
        Me.picClose1.BackgroundImage = Global.Modern_Flat_UI___Food_Application.My.Resources.Resources.btnClose
        Me.picClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose1.Location = New System.Drawing.Point(7, 6)
        Me.picClose1.Name = "picClose1"
        Me.picClose1.Size = New System.Drawing.Size(18, 18)
        Me.picClose1.TabIndex = 17
        Me.picClose1.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(86, 203)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(61, 13)
        Me.lblUser.TabIndex = 20
        Me.lblUser.Text = "Username :"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(86, 233)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(59, 13)
        Me.lblPass.TabIndex = 21
        Me.lblPass.Text = "Password :"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(155, 17)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(258, 26)
        Me.lblWelcome.TabIndex = 22
        Me.lblWelcome.Text = "Welcome, Login First !!"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(173, 201)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(217, 20)
        Me.txtuser.TabIndex = 23
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(173, 231)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(217, 20)
        Me.txtPass.TabIndex = 24
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(325, 262)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(64, 25)
        Me.btnLogin.TabIndex = 25
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblCreate
        '
        Me.lblCreate.AutoSize = True
        Me.lblCreate.Location = New System.Drawing.Point(223, 307)
        Me.lblCreate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(110, 13)
        Me.lblCreate.TabIndex = 26
        Me.lblCreate.Text = "Don't have account ?"
        '
        'lblCreateAcc
        '
        Me.lblCreateAcc.AutoSize = True
        Me.lblCreateAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCreateAcc.Location = New System.Drawing.Point(228, 326)
        Me.lblCreateAcc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCreateAcc.Name = "lblCreateAcc"
        Me.lblCreateAcc.Size = New System.Drawing.Size(95, 13)
        Me.lblCreateAcc.TabIndex = 27
        Me.lblCreateAcc.Text = "Create Account"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(395, 229)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(549, 426)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblCreateAcc)
        Me.Controls.Add(Me.lblCreate)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.picMaximize1)
        Me.Controls.Add(Me.picMinimize1)
        Me.Controls.Add(Me.picClose1)
        Me.Controls.Add(Me.picMail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Login"
        Me.Text = "Form3"
        CType(Me.picMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMaximize1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMail As PictureBox
    Friend WithEvents picMaximize1 As PictureBox
    Friend WithEvents picMinimize1 As PictureBox
    Friend WithEvents picClose1 As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblCreate As Label
    Friend WithEvents lblCreateAcc As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
