Public Class stopwatch
    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        Timer1.Enabled = True
    End Sub

    Private Sub StopBtn_Click(sender As Object, e As EventArgs) Handles StopBtn.Click
        Timer1.Enabled = False
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        TimerLbl.Text = 0
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerLbl.Text = Val(TimerLbl.Text) + 1
    End Sub
End Class
