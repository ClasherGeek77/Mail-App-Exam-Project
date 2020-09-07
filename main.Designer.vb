<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.pnlAboutUs = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.picKirim = New System.Windows.Forms.PictureBox()
        Me.picSent = New System.Windows.Forms.PictureBox()
        Me.picReceive = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlOnButtonPosition = New System.Windows.Forms.Panel()
        Me.picMaximize = New System.Windows.Forms.PictureBox()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.btnSent = New System.Windows.Forms.Button()
        Me.btnReceive = New System.Windows.Forms.Button()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.lblLogInOut = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.tabelView = New System.Windows.Forms.DataGridView()
        Me.pnlLeftSide.SuspendLayout()
        Me.pnlAboutUs.SuspendLayout()
        CType(Me.picKirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        CType(Me.tabelView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlLeftSide.Controls.Add(Me.pnlAboutUs)
        Me.pnlLeftSide.Controls.Add(Me.picKirim)
        Me.pnlLeftSide.Controls.Add(Me.picSent)
        Me.pnlLeftSide.Controls.Add(Me.picReceive)
        Me.pnlLeftSide.Controls.Add(Me.picLogo)
        Me.pnlLeftSide.Controls.Add(Me.pnlOnButtonPosition)
        Me.pnlLeftSide.Controls.Add(Me.picMaximize)
        Me.pnlLeftSide.Controls.Add(Me.picMinimize)
        Me.pnlLeftSide.Controls.Add(Me.picClose)
        Me.pnlLeftSide.Controls.Add(Me.btnSent)
        Me.pnlLeftSide.Controls.Add(Me.btnReceive)
        Me.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(200, 498)
        Me.pnlLeftSide.TabIndex = 0
        '
        'pnlAboutUs
        '
        Me.pnlAboutUs.Controls.Add(Me.Label15)
        Me.pnlAboutUs.Location = New System.Drawing.Point(200, 29)
        Me.pnlAboutUs.Name = "pnlAboutUs"
        Me.pnlAboutUs.Size = New System.Drawing.Size(683, 463)
        Me.pnlAboutUs.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(285, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 25)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Send"
        '
        'picKirim
        '
        Me.picKirim.Image = CType(resources.GetObject("picKirim.Image"), System.Drawing.Image)
        Me.picKirim.Location = New System.Drawing.Point(48, 359)
        Me.picKirim.Margin = New System.Windows.Forms.Padding(2)
        Me.picKirim.Name = "picKirim"
        Me.picKirim.Size = New System.Drawing.Size(95, 64)
        Me.picKirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKirim.TabIndex = 16
        Me.picKirim.TabStop = False
        '
        'picSent
        '
        Me.picSent.Image = CType(resources.GetObject("picSent.Image"), System.Drawing.Image)
        Me.picSent.Location = New System.Drawing.Point(19, 250)
        Me.picSent.Margin = New System.Windows.Forms.Padding(2)
        Me.picSent.Name = "picSent"
        Me.picSent.Size = New System.Drawing.Size(67, 32)
        Me.picSent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSent.TabIndex = 0
        Me.picSent.TabStop = False
        '
        'picReceive
        '
        Me.picReceive.Image = CType(resources.GetObject("picReceive.Image"), System.Drawing.Image)
        Me.picReceive.Location = New System.Drawing.Point(27, 197)
        Me.picReceive.Margin = New System.Windows.Forms.Padding(2)
        Me.picReceive.Name = "picReceive"
        Me.picReceive.Size = New System.Drawing.Size(53, 44)
        Me.picReceive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picReceive.TabIndex = 6
        Me.picReceive.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(15, 29)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(169, 161)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 15
        Me.picLogo.TabStop = False
        '
        'pnlOnButtonPosition
        '
        Me.pnlOnButtonPosition.BackColor = System.Drawing.Color.BlueViolet
        Me.pnlOnButtonPosition.Location = New System.Drawing.Point(0, 201)
        Me.pnlOnButtonPosition.Name = "pnlOnButtonPosition"
        Me.pnlOnButtonPosition.Size = New System.Drawing.Size(10, 37)
        Me.pnlOnButtonPosition.TabIndex = 1
        '
        'picMaximize
        '
        Me.picMaximize.BackgroundImage = Global.Modern_Flat_UI___Food_Application.My.Resources.Resources.btnMaximize
        Me.picMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMaximize.Location = New System.Drawing.Point(48, 6)
        Me.picMaximize.Name = "picMaximize"
        Me.picMaximize.Size = New System.Drawing.Size(18, 18)
        Me.picMaximize.TabIndex = 14
        Me.picMaximize.TabStop = False
        '
        'picMinimize
        '
        Me.picMinimize.BackgroundImage = Global.Modern_Flat_UI___Food_Application.My.Resources.Resources.btnMinimize
        Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMinimize.Location = New System.Drawing.Point(27, 6)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(18, 18)
        Me.picMinimize.TabIndex = 13
        Me.picMinimize.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackgroundImage = Global.Modern_Flat_UI___Food_Application.My.Resources.Resources.btnClose
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Location = New System.Drawing.Point(6, 6)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(18, 18)
        Me.picClose.TabIndex = 12
        Me.picClose.TabStop = False
        '
        'btnSent
        '
        Me.btnSent.FlatAppearance.BorderSize = 0
        Me.btnSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSent.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSent.Location = New System.Drawing.Point(0, 246)
        Me.btnSent.Name = "btnSent"
        Me.btnSent.Size = New System.Drawing.Size(200, 37)
        Me.btnSent.TabIndex = 8
        Me.btnSent.Text = "     Sent"
        Me.btnSent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSent.UseVisualStyleBackColor = True
        '
        'btnReceive
        '
        Me.btnReceive.FlatAppearance.BorderSize = 0
        Me.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceive.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReceive.Location = New System.Drawing.Point(0, 201)
        Me.btnReceive.Name = "btnReceive"
        Me.btnReceive.Size = New System.Drawing.Size(200, 37)
        Me.btnReceive.TabIndex = 6
        Me.btnReceive.Text = "           Receive"
        Me.btnReceive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReceive.UseVisualStyleBackColor = True
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.BlueViolet
        Me.pnlTopSide.Controls.Add(Me.lblLogInOut)
        Me.pnlTopSide.Controls.Add(Me.lblJudul)
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(200, 0)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(683, 29)
        Me.pnlTopSide.TabIndex = 1
        '
        'lblLogInOut
        '
        Me.lblLogInOut.AutoSize = True
        Me.lblLogInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogInOut.ForeColor = System.Drawing.Color.White
        Me.lblLogInOut.Location = New System.Drawing.Point(593, 6)
        Me.lblLogInOut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLogInOut.Name = "lblLogInOut"
        Me.lblLogInOut.Size = New System.Drawing.Size(47, 17)
        Me.lblLogInOut.TabIndex = 12
        Me.lblLogInOut.Text = "Log In"
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.SystemColors.Control
        Me.lblJudul.Location = New System.Drawing.Point(3, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(74, 29)
        Me.lblJudul.TabIndex = 11
        Me.lblJudul.Text = "Email"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnlTopSide
        Me.BunifuDragControl1.Vertical = True
        '
        'tabelView
        '
        Me.tabelView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.tabelView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelView.Location = New System.Drawing.Point(200, 29)
        Me.tabelView.Name = "tabelView"
        Me.tabelView.Size = New System.Drawing.Size(683, 469)
        Me.tabelView.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 498)
        Me.Controls.Add(Me.tabelView)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlAboutUs.ResumeLayout(False)
        Me.pnlAboutUs.PerformLayout()
        CType(Me.picKirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReceive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSide.ResumeLayout(False)
        Me.pnlTopSide.PerformLayout()
        CType(Me.tabelView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents pnlOnButtonPosition As Panel
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents btnSent As Button
    Friend WithEvents btnReceive As Button
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents picMaximize As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents lblJudul As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents pnlAboutUs As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents picReceive As PictureBox
    Friend WithEvents picSent As PictureBox
    Friend WithEvents picKirim As PictureBox
    Friend WithEvents lblLogInOut As Label
    Friend WithEvents tabelView As DataGridView
End Class
