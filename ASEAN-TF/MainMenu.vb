Public Class MainMenu

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Instructions.ShowDialog()   'Shows the instruction form
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()          'Quits the app
    End Sub

    
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        MainGame.Show() 'starts the main game and hides this form
        Me.Hide()    'hides this form
    End Sub
End Class
