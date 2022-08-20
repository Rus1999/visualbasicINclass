Public Class Form1
    Private Sub CheckDataBtn_Click(sender As Object, e As EventArgs) Handles CheckDataBtn.Click
        Dim result As String, result2, phone As String
        result = Trim(NameTextBox.Text)
        result2 = Trim(NameTextBox.Text)
        result = result.Remove(1)
        result = result.ToUpper() + result2.Remove(0, 1)
        phone = Trim(PhoneTextBox.Text)
        MsgBox(result + " " + Trim(UniversityTextBox.Text.ToUpper()) + " " + phone.Insert(2, "-").Insert(7, "-"))
    End Sub
End Class
