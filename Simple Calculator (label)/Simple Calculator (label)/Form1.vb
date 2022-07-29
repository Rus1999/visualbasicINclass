Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Single = Val(TextBox1.Text)
        Dim num2 As Single = Val(TextBox2.Text)
        Dim Sum1 As Single = num1 + num2
        Label3.Text = Sum1.ToString

        Dim num3 As Single = Val(TextBox3.Text)
        Dim num4 As Single = Val(TextBox4.Text)
        Dim Sum2 As Single = num3 - num4
        Label6.Text = Sum2.ToString

        Dim num5 As Single = Val(TextBox5.Text)
        Dim num6 As Single = Val(TextBox6.Text)
        Dim Sum3 As Single = num5 * num6
        Label9.Text = Sum3.ToString

        Dim num7 As Single = Val(TextBox7.Text)
        Dim num8 As Single = Val(TextBox8.Text)
        Dim Sum4 As Single = num7 / num8
        Label12.Text = Sum4.ToString
    End Sub


End Class
