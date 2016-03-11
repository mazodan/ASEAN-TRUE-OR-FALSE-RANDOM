Public Class MainGame
    Dim CloseState As Boolean = True    'THIS IS SWITCHED IF THE USER FINISHED THE QUIZ
    'TO PREVENT GOING BACK TO THE MAIN MENU
    Dim MGF As New MainGameFunctions    'Declare new instance of the object
    Dim Q As New Questions
    Dim rInteger As Integer             'The random number to be Used
    Dim QuestionIndex As Integer = 0

    Private Sub MainGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MGF.initializeTheVariables()    'Initializes the pertinent values
        MGF.setTheTimeAndScore(txtTimeLeft, txtScore)
        MGF.MakeAllValuesInArrayHundred()   'to make all arrays values as 100 to reset
        'after a new game is initiated
        SelectRandomNumber()            'Selects the random number to be used
        Q.LoadQuestions()               'Loads all questions to the Jagged Array
        MGF.SetTheQuestionAndAnswer(rInteger, txtQuestion, Q.QA)
        MGF.playTheQuestionSound()



    End Sub

    Private Sub MainGame_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CloseState = True Then
            txtQuestion.Visible = False
            If MessageBox.Show("Are you sure you want to Quit this quiz", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                MainMenu.Show()
                AnswerArrays.Clear()    'clears the array to recycle for next game
                MGF.StopBackgroundSound()
            Else
                e.Cancel = True
                txtQuestion.Visible = True
            End If
        End If
    End Sub

    'Temporary stub
    Private Sub stBtnR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stBtnR.Click
        


        MessageBox.Show(MGF.rNumber(0, 21))
    End Sub

    Sub SelectRandomNumber()
        Dim QuestionAlreadyUsed = True
        'Sample condition, Will always return true
        While QuestionAlreadyUsed = True
            'Uses while statement to repeat if Question is already asked
            'array will reset in a new game;
            rInteger = MGF.rNumber(0, 21)
            'gets random number
            If AnswerArrays.Contains(rInteger.ToString) = True Then
                QuestionAlreadyUsed = True
                'if number is in the array, question is already answered
                'then the condition will loop and will get another random number
            Else
                'if random number is not in string
                'puts that random number in an array
                AnswerArrays(QuestionIndex) = rInteger.ToString()
                Exit While
                'Exits While statement without messing with the condition
            End If
        End While
    End Sub
End Class