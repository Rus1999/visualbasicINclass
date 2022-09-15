Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sum, n As Integer
        ListBox1.Items.Add("n" & vbTab & "Sum")
        ListBox1.Items.Add("-----------------")
        While n < 100
            n += 1
            sum += n
            ListBox1.Items.Add(n & vbTab & sum)
        End While
    End Sub
End Class