﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        btnSendNewsletter = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnSendNewsletter
        ' 
        btnSendNewsletter.Anchor = AnchorStyles.None
        btnSendNewsletter.BackColor = Color.IndianRed
        btnSendNewsletter.Cursor = Cursors.Hand
        btnSendNewsletter.FlatStyle = FlatStyle.Flat
        btnSendNewsletter.Font = New Font("Arial", 28F)
        btnSendNewsletter.ForeColor = Color.White
        btnSendNewsletter.Location = New Point(387, 399)
        btnSendNewsletter.Margin = New Padding(4, 3, 4, 3)
        btnSendNewsletter.Name = "btnSendNewsletter"
        btnSendNewsletter.Size = New Size(240, 75)
        btnSendNewsletter.TabIndex = 22
        btnSendNewsletter.Text = "SEND"
        btnSendNewsletter.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.Font = New Font("Arial", 25F)
        Label1.Location = New Point(206, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(611, 163)
        Label1.TabIndex = 23
        Label1.Text = "Inform all borrowers that new book/s have been added to the Library! Click the Button to send to all Borrowers." & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 40F, FontStyle.Bold)
        Label2.Location = New Point(345, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(317, 63)
        Label2.TabIndex = 24
        Label2.Text = "Send Email"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1029, 540)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSendNewsletter)
        Font = New Font("Arial", 12F)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSendNewsletter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
