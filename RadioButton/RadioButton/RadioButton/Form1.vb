Public Class Form1
    Private Sub ConfirmBtn_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        If SizeS.Checked Then
            SizeLabel.Text = "S"
        ElseIf SizeM.Checked Then
            SizeLabel.Text = "M"
        ElseIf SizeL.Checked Then
            SizeLabel.Text = "L"
        End If

        If ColorPink.Checked Then
            Shrit1.BackColor = Color.Pink
            Shirt2.BackColor = Color.Pink
            SizeLabel.BackColor = Color.Pink
            SizeLabel.ForeColor = Color.Black
        ElseIf ColorBlack.Checked Then
            Shrit1.BackColor = Color.Black
            Shirt2.BackColor = Color.Black
            SizeLabel.BackColor = Color.Black
            SizeLabel.ForeColor = Color.White
        ElseIf ColorBrown.Checked Then
            Shrit1.BackColor = Color.Brown
            Shirt2.BackColor = Color.Brown
            SizeLabel.BackColor = Color.Brown
            SizeLabel.ForeColor = Color.White
        End If
    End Sub
End Class
