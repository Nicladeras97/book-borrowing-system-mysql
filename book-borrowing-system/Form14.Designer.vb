﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Panel1 = New Panel()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        txtUsername = New TextBox()
        btnBack = New LinkLabel()
        Label6 = New Label()
        txtConfirmPassword = New TextBox()
        Label5 = New Label()
        txtPassword = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        PasswordLabel = New Label()
        btnSignUp = New Button()
        UsernameLabel = New Label()
        txtFullName = New TextBox()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtConfirmPassword)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PasswordLabel)
        Panel1.Controls.Add(btnSignUp)
        Panel1.Controls.Add(UsernameLabel)
        Panel1.Controls.Add(txtFullName)
        Panel1.Location = New Point(450, 184)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(587, 549)
        Panel1.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 14F)
        Label2.Location = New Point(34, 461)
        Label2.Name = "Label2"
        Label2.Size = New Size(226, 22)
        Label2.TabIndex = 15
        Label2.Text = "Already have an account?"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImageLayout = ImageLayout.Center
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Location = New Point(528, 304)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(30, 22)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Location = New Point(527, 262)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(31, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Cursor = Cursors.IBeam
        txtUsername.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(227, 218)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(335, 29)
        txtUsername.TabIndex = 2
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.Bottom
        btnBack.AutoSize = True
        btnBack.BackColor = Color.Transparent
        btnBack.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(257, 461)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(64, 22)
        btnBack.TabIndex = 6
        btnBack.TabStop = True
        btnBack.Text = "Log In"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(22, 304)
        Label6.Name = "Label6"
        Label6.Size = New Size(166, 22)
        Label6.TabIndex = 12
        Label6.Text = "Confirm Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Cursor = Cursors.IBeam
        txtConfirmPassword.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtConfirmPassword.Location = New Point(227, 300)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(335, 29)
        txtConfirmPassword.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(22, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 22)
        Label5.TabIndex = 8
        Label5.Text = "Password"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(227, 259)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(335, 29)
        txtPassword.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(217, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(172, 17)
        Label4.TabIndex = 6
        Label4.Text = "Please enter your details."
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(160, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(280, 41)
        Label3.TabIndex = 5
        Label3.Text = "Create Account!"
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordLabel.Location = New Point(22, 220)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(97, 22)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Username"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = SystemColors.HotTrack
        btnSignUp.BackgroundImageLayout = ImageLayout.None
        btnSignUp.Cursor = Cursors.Hand
        btnSignUp.FlatAppearance.BorderSize = 0
        btnSignUp.FlatStyle = FlatStyle.Flat
        btnSignUp.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = Color.White
        btnSignUp.Location = New Point(24, 368)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(538, 56)
        btnSignUp.TabIndex = 5
        btnSignUp.Text = "SIGNUP"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameLabel.Location = New Point(24, 179)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(95, 22)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "Full Name"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtFullName
        ' 
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Cursor = Cursors.IBeam
        txtFullName.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFullName.Location = New Point(227, 179)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(335, 29)
        txtFullName.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1487, 93)
        Panel2.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(113, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(506, 44)
        Label1.TabIndex = 1
        Label1.Text = "Book- Management System"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.cmilogo
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(107, 91)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Form14
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1487, 776)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Font = New Font("Arial", 9F)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form14"
        Text = "Formsignup"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnBack As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
