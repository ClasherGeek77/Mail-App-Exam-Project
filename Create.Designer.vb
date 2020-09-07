<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Create))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.lblConPass = New System.Windows.Forms.Label()
        Me.picSeePass = New System.Windows.Forms.PictureBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSeePass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Create Account"
        '
        'picBack
        '
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(27, 20)
        Me.picBack.Margin = New System.Windows.Forms.Padding(2)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(35, 24)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBack.TabIndex = 12
        Me.picBack.TabStop = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(217, 140)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(217, 20)
        Me.txtName.TabIndex = 28
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(111, 142)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 13)
        Me.lblName.TabIndex = 26
        Me.lblName.Text = "Name :"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(217, 203)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(217, 20)
        Me.txtPass.TabIndex = 32
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(217, 173)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(217, 20)
        Me.txtUsername.TabIndex = 31
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(111, 205)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(59, 13)
        Me.lblPass.TabIndex = 30
        Me.lblPass.Text = "Password :"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(111, 175)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(61, 13)
        Me.lblUsername.TabIndex = 29
        Me.lblUsername.Text = "Username :"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Location = New System.Drawing.Point(217, 233)
        Me.txtConfirmPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.Size = New System.Drawing.Size(217, 20)
        Me.txtConfirmPass.TabIndex = 34
        '
        'lblConPass
        '
        Me.lblConPass.AutoSize = True
        Me.lblConPass.Location = New System.Drawing.Point(111, 235)
        Me.lblConPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConPass.Name = "lblConPass"
        Me.lblConPass.Size = New System.Drawing.Size(74, 13)
        Me.lblConPass.TabIndex = 33
        Me.lblConPass.Text = "Confirm Pass :"
        '
        'picSeePass
        '
        Me.picSeePass.Image = CType(resources.GetObject("picSeePass.Image"), System.Drawing.Image)
        Me.picSeePass.Location = New System.Drawing.Point(431, 200)
        Me.picSeePass.Margin = New System.Windows.Forms.Padding(2)
        Me.picSeePass.Name = "picSeePass"
        Me.picSeePass.Size = New System.Drawing.Size(33, 23)
        Me.picSeePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSeePass.TabIndex = 35
        Me.picSeePass.TabStop = False
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(365, 305)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(68, 23)
        Me.btnCreate.TabIndex = 36
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(540, 442)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.picSeePass)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.lblConPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.picBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Create"
        Me.Text = "v"
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSeePass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents picBack As PictureBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents lblConPass As Label
    Friend WithEvents picSeePass As PictureBox
    Friend WithEvents btnCreate As Button
End Class
