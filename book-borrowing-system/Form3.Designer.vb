﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Button3 = New Button()
        ComboBox1 = New ComboBox()
        Button4 = New Button()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 40F, FontStyle.Bold)
        Label1.Location = New Point(317, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(492, 63)
        Label1.TabIndex = 0
        Label1.Text = "Generate Barcode"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.AutoSize = True
        Button1.BackColor = SystemColors.HotTrack
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 20F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(269, 224)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(211, 95)
        Button1.TabIndex = 1
        Button1.Text = "Generate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Location = New Point(423, 476)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(300, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.AutoSize = True
        Button2.BackColor = Color.Green
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 20F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(486, 224)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(177, 95)
        Button2.TabIndex = 4
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.AutoSize = True
        Button3.BackColor = Color.Red
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial", 20F)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(669, 224)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(178, 95)
        Button3.TabIndex = 5
        Button3.Text = "Clear"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.None
        ComboBox1.Font = New Font("Arial", 16F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(486, 156)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(361, 32)
        ComboBox1.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.None
        Button4.BackColor = Color.Gray
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial", 20F)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(269, 357)
        Button4.Margin = New Padding(3, 4, 3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(578, 76)
        Button4.TabIndex = 6
        Button4.Text = "Generate All Books"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 16F)
        Label2.Location = New Point(269, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(216, 25)
        Label2.TabIndex = 21
        Label2.Text = "Scan/Select Acc. No."
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1129, 659)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(ComboBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        DoubleBuffered = True
        Font = New Font("Arial", 10F)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form3"
        Text = "Generate Barcode"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
End Class
