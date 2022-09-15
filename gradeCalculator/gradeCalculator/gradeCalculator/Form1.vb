Public Class Form1
    Private Sub OKbtn_Click(sender As Object, e As EventArgs) Handles OKbtn.Click
        Dim mark As Integer
        Dim grade As String
        mark = Val(MarkInput.Text)

        If mark >= 80 And mark <= 100 Then
            grade = "A"
        ElseIf mark >= 75 And mark < 80 Then
            grade = "B+"
        ElseIf mark >= 70 And mark < 75 Then
            grade = "B"
        ElseIf mark >= 65 And mark < 70 Then
            grade = "C+"
        ElseIf mark >= 60 And mark < 65 Then
            grade = "C"
        ElseIf mark >= 55 And mark < 60 Then
            grade = "D+"
        ElseIf mark >= 50 And mark < 55 Then
            grade = "D"
        ElseIf mark >= 0 And mark < 50 Then
            grade = "F"
        Else
            grade = "Out of Range"
        End If


        OKbtn.Text = "ko"

        MsgBox("Your Grade is " & grade)

    End Sub
End Class
