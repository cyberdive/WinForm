Public Class Form1
    Dim vitesse As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(vitesse)
        If ProgressBar1.Value = 100 Then
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub BtnActionGo_Click(sender As Object, e As EventArgs) Handles BtnActionGo.Click
        vitesse = 1
        If BtnActionGo.Text = "Stop" Then
            BtnActionGo.Text = "Go"
            Timer1.Enabled = False

        Else
            BtnActionGo.Text = "Stop"
            Timer1.Enabled = True
        End If


    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        vitesse = TrackBar1.Value
    End Sub
End Class
