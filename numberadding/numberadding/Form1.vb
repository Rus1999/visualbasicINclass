Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(Val(TextBox1.Text) & "+" & Val(TextBox2.Text) & "=" & Val(TextBox1.Text) + Val(TextBox2.Text))
    End Sub
End Class
