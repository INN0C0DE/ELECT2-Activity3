﻿Public Class Form10

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = "Button 3 clicked!"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "Button 2 clicked!"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "Button 1 clicked!"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.Text = "Check Box 1 is clicked!"
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        If CheckBox1.Checked = False Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        TextBox2.Text = "Check Box 2 is clicked!"
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        If CheckBox2.Checked = False Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        TextBox2.Text = "Check Box 3 is clicked!"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        If CheckBox3.Checked = False Then
            TextBox2.Text = ""
        End If
    End Sub
End Class