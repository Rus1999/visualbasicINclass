Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CalBtn.Click
        BMILbl.Text = BMI(Val(WeightTxtBox.Text), Val(HeightTxtBox.Text))
    End Sub

    Private Function BMI(weight As Single, height As Single) As Double
        BMI = weight / (height ^ 2)
    End Function
End Class
