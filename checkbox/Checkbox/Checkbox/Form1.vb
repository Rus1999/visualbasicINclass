Public Class Form1
    Dim sum As Integer = 0
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        If LaserJetX.Checked = True Then
            sum += 100
        End If
        If BigNotebook.Checked = True Then
            sum += 500
        End If
        If SmartDesktop.Checked = True Then
            sum += 200
        End If
        If HDDigicam.Checked = True Then
            sum += 80
        End If
        If HiTechMP4.Checked = True Then
            sum += 300
        End If
        If ADSLModem.Checked = True Then
            sum += 150
        End If

        Result.Text = Format(sum, "Currency")
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        LaserJetX.Checked = False
        BigNotebook.Checked = False
        SmartDesktop.Checked = False
        HDDigicam.Checked = False
        HiTechMP4.Checked = False
        ADSLModem.Checked = False
        Result.Text = ""
        sum = 0
    End Sub
End Class
