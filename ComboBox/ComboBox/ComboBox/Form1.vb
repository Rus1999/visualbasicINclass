Public Class Form1
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        ComboBox1.Items.Add(InputBox("Enter color you want to add: "))
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        ComboBox1.Items.Remove(ComboBox1.Items(ComboBox1.SelectedIndex))
    End Sub

    Private Sub ShowCountBtn_Click(sender As Object, e As EventArgs) Handles ShowCountBtn.Click
        ShowCountBtn.Text = "Show Count: " & Val(ComboBox1.Items.Count)
    End Sub
End Class
