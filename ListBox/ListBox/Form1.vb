Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim input = InputBox("Eenter a color you want to add: ")
        ListBox1.Items.Add(input)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles RmBtn.Click
        Dim input = InputBox("Enter a color you want to remove: ")
        ListBox1.Items.Remove(input)
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim input = InputBox("Eenter a color you want to add: ")
        ComboBox1.Items.Add(input)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim input = InputBox("Enter a color you want to remove: ")
        ComboBox1.Items.Remove(input)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ListBoxBtn.Click
        MessageBox.Show((ListBox1.Items(ListBox1.SelectedIndex)) & " : " & ListBox1.SelectedIndex())
    End Sub
End Class
