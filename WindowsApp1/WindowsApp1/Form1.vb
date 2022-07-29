Public Class MyForm
    Private Sub MyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Punyarit Klaphachon"
        Me.BackColor = Color.Beige
        Me.MaximizeBox = False
        Me.MinimizeBox = True

        'Specifying the form size to 400pixel x 400pixel
        Me.Size = New Size(400, 400)
        'To set the form opacity at 85%
        Me.Opacity = 0.85
        'To position the form at the center of the screen
        Me.CenterToParent()
    End Sub
End Class
