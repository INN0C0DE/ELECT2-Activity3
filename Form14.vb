Public Class Form14
    Dim f, c As Double

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        f = TextBox1.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = (f - 32) * (5 / 9)
        TextBox2.Text = c

    End Sub
End Class