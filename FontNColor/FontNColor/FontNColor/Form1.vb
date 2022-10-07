Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            Label1.Font = FontDialog1.Font
            Label1.ForeColor = FontDialog1.Color
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        Label1.BackColor = ColorDialog1.Color
    End Sub
End Class
