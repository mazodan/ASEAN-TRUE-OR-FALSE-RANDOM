Public Class MainMenu

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Instructions.ShowDialog()   'Shows the instruction form
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()          'Quits the app
    End Sub

    
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        'THIS IS A STUB
        'Dim xforce As New Questions
        'xforce.LoadQuestions()
        'MessageBox.Show(xforce.QA(5)(0))

        MainGame.Show()
        Me.Hide()
    End Sub
End Class
