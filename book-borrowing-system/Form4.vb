﻿Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim back As New Form11
        back.Show
        Hide
    End Sub
    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click, Label2.Click, PictureBox4.Click
        Dim manageBooks As New Form5
        manageBooks.Show()
        Me.Hide()
    End Sub
    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click, Label3.Click, PictureBox5.Click
        Dim bookReport As New Report
        bookReport.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim back As New Form11
        back.Show()
        Me.Hide()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class