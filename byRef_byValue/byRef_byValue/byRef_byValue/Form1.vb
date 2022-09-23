Public Class Form1

    Private Function SqrootRef(ByRef x As Single) As Double
        x ^= 0.5
        SqrootRef = x
    End Function

    Private Function SqrootVal(ByVal x As Single) As Double
        x ^= 0.5
        SqrootVal = x
    End Function

    Private Sub ShowBtn_Click(sender As Object, e As EventArgs) Handles ShowBtn.Click
        Dim r As Single = 9
        Dim v As Single = 9

        ValueLbl.Text = "by Ref " & vbNewLine & "r (before): " & r & vbNewLine & "sqroot: " & SqrootRef(r) & vbNewLine & "r (after): " & r & vbNewLine & vbNewLine & "by Val " & vbNewLine & "v (before): " & v & vbNewLine & "sqroot: " & SqrootVal(v) & vbNewLine & "v (after): " & v
    End Sub
End Class
