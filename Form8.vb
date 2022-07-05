Public Class Form8

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox1.Text = "Check Box 1 is clicked!"
        If CheckBox1.Checked = False Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        TextBox2.Text = "Check Box 2 is clicked!"
        If CheckBox2.Checked = False Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        TextBox3.Text = "Check Box 3 is clicked!"
        If CheckBox3.Checked = False Then
            TextBox3.Text = ""
        End If
    End Sub
End Class