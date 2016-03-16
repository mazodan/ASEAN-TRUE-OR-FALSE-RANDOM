Public Class Result
    Dim closeState As Boolean = True
    Private Sub Result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If WinCond = True Then
            My.Computer.Audio.Play(My.Resources.Winner, AudioPlayMode.Background)   'checks the win condition if won or lost
            lblRes.Text = "Congratulations, You have won the Quiz"                  'sets the message
            txtScore.Text = score                                                   'places the score in textbox
        Else
            My.Computer.Audio.Play(My.Resources.Lose, AudioPlayMode.Background)     'plays either win or lose music
            lblRes.Text = "Sorry, You have lost the Quiz"
            txtScore.Text = score
        End If
    End Sub

    Private Sub Result_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If closeState = True Then       'if form is closed, exit the whole app
            Application.Exit()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()          'otherwise, app will close if exit button is pressed
    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click
        MainMenu.Show()         'shows main menu
        closeState = False      'closestate to false
        Me.Close()              'close this form
    End Sub

    Private Sub btnAgain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgain.Click
        MainGame.Show()
        closeState = False
        Me.Close()
    End Sub
End Class