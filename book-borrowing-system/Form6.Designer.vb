﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        ComboBox2 = New ComboBox()
        Label5 = New Label()
        Label4 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightBlue
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(984, 53)
        Panel1.TabIndex = 5
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.notification1
        PictureBox3.Location = New Point(950, 17)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(15, 16)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 16)
        Label1.TabIndex = 1
        Label1.Text = "Book Borrowing System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(12, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 21)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(DateTimePicker2)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(38, 107)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(893, 60)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Filter Options"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(255, 21)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(144, 24)
        ComboBox2.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(212, 26)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 16)
        Label5.TabIndex = 8
        Label5.Text = "Type"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(752, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(19, 16)
        Label4.TabIndex = 6
        Label4.Text = "to"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CustomFormat = ""
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Location = New Point(772, 21)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(104, 22)
        DateTimePicker2.TabIndex = 5
        DateTimePicker2.Value = New Date(2025, 3, 17, 0, 0, 0, 0)
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = ""
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(646, 21)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(104, 22)
        DateTimePicker1.TabIndex = 4
        DateTimePicker1.Value = New Date(2025, 3, 17, 0, 0, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(563, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 16)
        Label3.TabIndex = 3
        Label3.Text = "Date Range"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(77, 21)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(129, 24)
        ComboBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(11, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 16)
        Label2.TabIndex = 0
        Label2.Text = "Category"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SkyBlue
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(771, 71)
        Button2.Name = "Button2"
        Button2.Size = New Size(69, 33)
        Button2.TabIndex = 7
        Button2.Text = "Export"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SkyBlue
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(846, 71)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 33)
        Button1.TabIndex = 2
        Button1.Text = "Generate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.Resources.back
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(14, 78)
        Button3.Name = "Button3"
        Button3.Size = New Size(15, 15)
        Button3.TabIndex = 13
        Button3.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.LightBlue
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.ControlDark
        DataGridView1.Location = New Point(38, 173)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(893, 354)
        DataGridView1.TabIndex = 14
        ' 
        ' TextBox1
        ' 
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(38, 71)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(250, 22)
        TextBox1.TabIndex = 15
        TextBox1.Text = "Search"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.SkyBlue
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(846, 71)
        Button4.Name = "Button4"
        Button4.Size = New Size(85, 33)
        Button4.TabIndex = 2
        Button4.Text = "Generate"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackgroundImage = My.Resources.Resources.back
        Button5.BackgroundImageLayout = ImageLayout.Zoom
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(14, 78)
        Button5.Name = "Button5"
        Button5.Size = New Size(15, 15)
        Button5.TabIndex = 13
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.SkyBlue
        Button6.Cursor = Cursors.Hand
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(771, 71)
        Button6.Name = "Button6"
        Button6.Size = New Size(69, 33)
        Button6.TabIndex = 7
        Button6.Text = "Export"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(984, 561)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Button6)
        Controls.Add(Button2)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(Button4)
        Controls.Add(Button1)
        Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form6"
        Text = "Book Reports"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
