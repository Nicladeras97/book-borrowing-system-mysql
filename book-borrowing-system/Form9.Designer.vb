﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Label2 = New Label()
        Back = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label21 = New Label()
        Label22 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label9 = New Label()
        Label23 = New Label()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label11 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        Label8 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        Label29 = New Label()
        Label6 = New Label()
        Label30 = New Label()
        Label31 = New Label()
        Label10 = New Label()
        Label12 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightBlue
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1482, 57)
        Panel1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 19)
        Label1.TabIndex = 1
        Label1.Text = "Book Borrowing System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(12, 16)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 22)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(971, 658)
        Button1.Name = "Button1"
        Button1.Size = New Size(205, 47)
        Button1.TabIndex = 37
        Button1.Text = "Return Good"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(80, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(1096, 105)
        Label2.TabIndex = 21
        Label2.Text = "Book Title"
        ' 
        ' Back
        ' 
        Back.BackgroundImage = My.Resources.Resources.back
        Back.BackgroundImageLayout = ImageLayout.Zoom
        Back.Cursor = Cursors.Hand
        Back.FlatAppearance.BorderSize = 0
        Back.FlatStyle = FlatStyle.Flat
        Back.Location = New Point(14, 78)
        Back.Name = "Back"
        Back.Size = New Size(15, 16)
        Back.TabIndex = 40
        Back.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.HotTrack
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(735, 658)
        Button2.Name = "Button2"
        Button2.Size = New Size(205, 47)
        Button2.TabIndex = 44
        Button2.Text = "Return Damaged"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.HotTrack
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(1211, 658)
        Button3.Name = "Button3"
        Button3.Size = New Size(205, 47)
        Button3.TabIndex = 45
        Button3.Text = "Return Lost"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(77, 406)
        Label21.Name = "Label21"
        Label21.Size = New Size(90, 23)
        Label21.TabIndex = 60
        Label21.Text = "Publisher"
        Label21.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label22
        ' 
        Label22.BackColor = SystemColors.ButtonFace
        Label22.BorderStyle = BorderStyle.Fixed3D
        Label22.FlatStyle = FlatStyle.Flat
        Label22.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(258, 407)
        Label22.Name = "Label22"
        Label22.Size = New Size(438, 25)
        Label22.TabIndex = 59
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(77, 357)
        Label19.Name = "Label19"
        Label19.Size = New Size(141, 23)
        Label19.TabIndex = 58
        Label19.Text = "Year Published"
        Label19.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label20
        ' 
        Label20.BackColor = SystemColors.ButtonFace
        Label20.BorderStyle = BorderStyle.Fixed3D
        Label20.FlatStyle = FlatStyle.Flat
        Label20.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(258, 357)
        Label20.Name = "Label20"
        Label20.Size = New Size(438, 25)
        Label20.TabIndex = 57
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(77, 308)
        Label17.Name = "Label17"
        Label17.Size = New Size(67, 23)
        Label17.TabIndex = 56
        Label17.Text = "Author"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label18
        ' 
        Label18.BackColor = SystemColors.ButtonFace
        Label18.BorderStyle = BorderStyle.Fixed3D
        Label18.FlatStyle = FlatStyle.Flat
        Label18.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(258, 307)
        Label18.Name = "Label18"
        Label18.Size = New Size(438, 25)
        Label18.TabIndex = 55
        ' 
        ' Label15
        ' 
        Label15.BackColor = SystemColors.ButtonFace
        Label15.BorderStyle = BorderStyle.Fixed3D
        Label15.FlatStyle = FlatStyle.Flat
        Label15.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(258, 514)
        Label15.Name = "Label15"
        Label15.Size = New Size(438, 23)
        Label15.TabIndex = 54
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(77, 516)
        Label16.Name = "Label16"
        Label16.Size = New Size(55, 23)
        Label16.TabIndex = 53
        Label16.Text = "Rack"
        ' 
        ' Label14
        ' 
        Label14.BackColor = SystemColors.ButtonFace
        Label14.BorderStyle = BorderStyle.Fixed3D
        Label14.FlatStyle = FlatStyle.Flat
        Label14.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(258, 564)
        Label14.Name = "Label14"
        Label14.Size = New Size(438, 23)
        Label14.TabIndex = 52
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(77, 566)
        Label13.Name = "Label13"
        Label13.Size = New Size(110, 23)
        Label13.TabIndex = 51
        Label13.Text = "LC Call No."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(80, 256)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 23)
        Label9.TabIndex = 50
        Label9.Text = "ISBN"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label23
        ' 
        Label23.BackColor = SystemColors.ButtonFace
        Label23.BorderStyle = BorderStyle.Fixed3D
        Label23.FlatStyle = FlatStyle.Flat
        Label23.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(258, 256)
        Label23.Name = "Label23"
        Label23.Size = New Size(438, 25)
        Label23.TabIndex = 48
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(724, 464)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 23)
        Label3.TabIndex = 72
        Label3.Text = "Email"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Cursor = Cursors.Hand
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(934, 511)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(482, 26)
        DateTimePicker1.TabIndex = 70
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(724, 514)
        Label7.Name = "Label7"
        Label7.Size = New Size(122, 23)
        Label7.TabIndex = 68
        Label7.Text = "Borrow Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(724, 257)
        Label5.Name = "Label5"
        Label5.Size = New Size(172, 23)
        Label5.TabIndex = 64
        Label5.Text = "Name of Borrower"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(724, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 23)
        Label4.TabIndex = 62
        Label4.Text = "ID Number"
        ' 
        ' Label11
        ' 
        Label11.BackColor = SystemColors.ButtonFace
        Label11.BorderStyle = BorderStyle.Fixed3D
        Label11.FlatStyle = FlatStyle.Flat
        Label11.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(934, 308)
        Label11.Name = "Label11"
        Label11.Size = New Size(482, 25)
        Label11.TabIndex = 76
        ' 
        ' Label24
        ' 
        Label24.BackColor = SystemColors.ButtonFace
        Label24.BorderStyle = BorderStyle.Fixed3D
        Label24.FlatStyle = FlatStyle.Flat
        Label24.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(934, 257)
        Label24.Name = "Label24"
        Label24.Size = New Size(482, 25)
        Label24.TabIndex = 75
        ' 
        ' Label25
        ' 
        Label25.BackColor = SystemColors.ButtonFace
        Label25.BorderStyle = BorderStyle.Fixed3D
        Label25.FlatStyle = FlatStyle.Flat
        Label25.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(934, 207)
        Label25.Name = "Label25"
        Label25.Size = New Size(242, 25)
        Label25.TabIndex = 74
        ' 
        ' Label26
        ' 
        Label26.BackColor = SystemColors.ButtonFace
        Label26.BorderStyle = BorderStyle.Fixed3D
        Label26.FlatStyle = FlatStyle.Flat
        Label26.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(934, 462)
        Label26.Name = "Label26"
        Label26.Size = New Size(482, 25)
        Label26.TabIndex = 73
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(77, 209)
        Label8.Name = "Label8"
        Label8.Size = New Size(85, 23)
        Label8.TabIndex = 78
        Label8.Text = "Acc. No."
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label27
        ' 
        Label27.BackColor = SystemColors.ButtonFace
        Label27.BorderStyle = BorderStyle.Fixed3D
        Label27.FlatStyle = FlatStyle.Flat
        Label27.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(258, 207)
        Label27.Name = "Label27"
        Label27.Size = New Size(438, 25)
        Label27.TabIndex = 77
        ' 
        ' Label28
        ' 
        Label28.BackColor = SystemColors.ButtonFace
        Label28.BorderStyle = BorderStyle.Fixed3D
        Label28.FlatStyle = FlatStyle.Flat
        Label28.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label28.Location = New Point(934, 407)
        Label28.Name = "Label28"
        Label28.Size = New Size(482, 25)
        Label28.TabIndex = 80
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label29.Location = New Point(724, 406)
        Label29.Name = "Label29"
        Label29.Size = New Size(152, 23)
        Label29.TabIndex = 79
        Label29.Text = "Contact Number"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(724, 307)
        Label6.Name = "Label6"
        Label6.Size = New Size(160, 23)
        Label6.TabIndex = 81
        Label6.Text = "Yr and Sec/Pos."
        ' 
        ' Label30
        ' 
        Label30.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(724, 357)
        Label30.Name = "Label30"
        Label30.Size = New Size(193, 24)
        Label30.TabIndex = 83
        Label30.Text = "Course/Department"
        ' 
        ' Label31
        ' 
        Label31.BackColor = SystemColors.ButtonFace
        Label31.BorderStyle = BorderStyle.Fixed3D
        Label31.FlatStyle = FlatStyle.Flat
        Label31.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(934, 357)
        Label31.Name = "Label31"
        Label31.Size = New Size(482, 26)
        Label31.TabIndex = 82
        ' 
        ' Label10
        ' 
        Label10.BackColor = SystemColors.ButtonFace
        Label10.BorderStyle = BorderStyle.Fixed3D
        Label10.FlatStyle = FlatStyle.Flat
        Label10.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(258, 463)
        Label10.Name = "Label10"
        Label10.Size = New Size(438, 23)
        Label10.TabIndex = 85
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(77, 462)
        Label12.Name = "Label12"
        Label12.Size = New Size(75, 23)
        Label12.TabIndex = 84
        Label12.Text = "Section"
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1482, 753)
        ControlBox = False
        Controls.Add(Label10)
        Controls.Add(Label12)
        Controls.Add(Label30)
        Controls.Add(Label31)
        Controls.Add(Label6)
        Controls.Add(Label28)
        Controls.Add(Label29)
        Controls.Add(Label8)
        Controls.Add(Label27)
        Controls.Add(Label11)
        Controls.Add(Label24)
        Controls.Add(Label25)
        Controls.Add(Label26)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label21)
        Controls.Add(Label22)
        Controls.Add(Label19)
        Controls.Add(Label20)
        Controls.Add(Label17)
        Controls.Add(Label18)
        Controls.Add(Label15)
        Controls.Add(Label16)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label9)
        Controls.Add(Label23)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Back)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form9"
        Text = "    "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Back As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
End Class
