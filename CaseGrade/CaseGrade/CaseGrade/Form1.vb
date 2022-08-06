Public Class Form1
    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim mark As Single
        mark = Val(MarkInputBox.Text)
        Select Case mark
            Case 0 To 49.999999999999
                GradeResult.Text = "F"
            Case 50 To 54.99999999999
                GradeResult.Text = "D"
            Case 55 To 59.99999999999
                GradeResult.Text = "D+"
            Case 60 To 64.999999999999
                GradeResult.Text = "C"
            Case 65 To 69.999999999999
                GradeResult.Text = "C+"
            Case 70 To 74.999999999999
                GradeResult.Text = "B"
            Case 75 To 79.999999999999
                GradeResult.Text = "B+"
            Case 80 To 100
                GradeResult.Text = "A"
            Case Else
                GradeResult.Text = "Out of Range"
        End Select
    End Sub
End Class
