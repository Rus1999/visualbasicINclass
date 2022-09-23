Public Class Form1
    Private Sub BoldChk_CheckedChanged(sender As Object, e As EventArgs) Handles BoldChk.CheckedChanged
        If BoldChk.Checked Then
            ResultText.Font = New Font(ResultText.Font, ResultText.Font.Style Or FontStyle.Bold)
        Else
            ResultText.Font = New Font(ResultText.Font, ResultText.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub ItalicChk_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicChk.CheckedChanged
        If ItalicChk.Checked Then
            ResultText.Font = New Font(ResultText.Font, ResultText.Font.Style Or FontStyle.Italic)
        Else
            ResultText.Font = New Font(ResultText.Font, ResultText.Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub UnderlinedChk_CheckedChanged(sender As Object, e As EventArgs) Handles UnderlinedChk.CheckedChanged
        If UnderlinedChk.Checked Then
            ResultText.Font = New Font(ResultText.Font, ResultText.Font.Style Or FontStyle.Underline)
        Else
            ResultText.Font = New Font(ResultText.Font, ResultText.Font.Style And Not FontStyle.Underline)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResultText.Text = ResultText.Font.Style

    End Sub
End Class
