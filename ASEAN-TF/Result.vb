Public Class Result

    Private Sub Result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If WinCond = True Then
            My.Computer.Audio.Play(My.Resources.Winner, AudioPlayMode.Background)
            lblRes.Text = "Congratulations, You have won the Quiz"
            txtScore.Text = score
        Else
            My.Computer.Audio.Play(My.Resources.Lose, AudioPlayMode.Background)
            lblRes.Text = "Sorry, You have lost the Quiz"
            txtScore.Text = score
        End If
    End Sub
End Class