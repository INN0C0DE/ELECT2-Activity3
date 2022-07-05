Public Class Form21
    Dim quo, n1, n2 As Double

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        n1 = TextBox1.Text


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        n2 = TextBox2.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        quo = n1 / n2
        TextBox3.Text = quo

    End Sub
End Class