Public Class Form11

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Text = "Radio Button 1 clicked!"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Text = "Radio Button 2 clicked!"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Text = "Radio Button 3 clicked!"
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