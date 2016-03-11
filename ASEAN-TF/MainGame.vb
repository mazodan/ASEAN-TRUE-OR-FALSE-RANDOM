Imports WMPLib

Public Class MainGame
    Dim CloseState As Boolean = True    'THIS IS SWITCHED IF THE USER FINISHED THE QUIZ
    'TO PREVENT GOING BACK TO THE MAIN MENU
    Dim MGF As New MainGameFunctions    'Declare new instance of the object
    Dim Q As New Questions
    Dim rInteger As Integer             'The random number to be Used
    Dim QuestionIndex As Integer = 0    'the current Question
    Dim Ans As String
    Dim life As String = "###"


    Private Sub MainGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MGF.initializeTheVariables()    'Initializes the pertinent values
        MGF.setTheTimeAndScore(txtTimeLeft, txtScore)
        MGF.MakeAllValuesInArrayHundred()   'to make all arrays values as 100 to reset
        'after a new game is initiated
        SelectRandomNumber()            'Selects the random number to be used
        Q.LoadQuestions()               'Loads all questions to the Jagged Array
        MGF.SetTheQuestionAndAnswer(rInteger, txtQuestion, Q.QA)
        'Sets the question using the Random integer
        MGF.playTheQuestionSound()
        'PLAYS THE BACKGROUND SOUND
        Qtimer.Start()


    End Sub

    Private Sub MainGame_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CloseState = True Then
            txtQuestion.Visible = False
            Qtimer.Enabled = False
            If MessageBox.Show("Are you sure you want to Quit this quiz", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                MainMenu.Show()
                AnswerArrays.Clear()    'clears the array to recycle for next game
                MGF.StopBackgroundSound()
            Else
                e.Cancel = True
                txtQuestion.Visible = True
                Qtimer.Enabled = True
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
            rInteger = MGF.rNumber(0, 31)
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

    Private Sub Qtimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtimer.Tick
        If oras = 0 Or oras < 0 Then    'Automatic Pass if timer reached zero
            nxtQuestion()
        Else
            txtTimeLeft.Text = oras
            oras -= 0.01
            pbarTime.Value = oras
        End If
    End Sub


    Private Sub btnTrue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrue.Click
        Ans = "True"
        checkAnswer()
    End Sub

    Private Sub btnFalse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFalse.Click
        Ans = "False"
        checkAnswer()
    End Sub

    Sub checkAnswer()
        Dim ResourceFilePath As String
        If Ans = QuizAnswer Then
            ResourceFilePath = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\resources\")
            wmp.URL = ResourceFilePath & "\tama.wav"
            wmp.Ctlcontrols.play()
            score += 1
            txtScore.Text = score
            nxtQuestion()
        Else
            ResourceFilePath = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\resources\")
            wmp.URL = ResourceFilePath & "\mali.wav"
            wmp.Ctlcontrols.play()
            lives -= 1
            lblLife.Text = lives.ToString
            nxtQuestion()

        End If
    End Sub

    Sub nxtQuestion()
        winCondition()
        oras = 10.0
        QuestionIndex += 1
        SelectRandomNumber()            'Selects the random number to be used
        MGF.SetTheQuestionAndAnswer(rInteger, txtQuestion, Q.QA)
        lblQuestionNumber.Text = QuestionIndex + 1
    End Sub


    Private Sub btnPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPass.Click
        If pass > 0 Then
            pass -= 1
            lblPass.Text = pass
            nxtQuestion()
        End If
        If pass = 0 Then
            btnPass.Visible = False
        End If
    End Sub

    Sub winCondition()
        If lblQuestionNumber.Text = "15" Or score = 10 Or lives = 0 Then
            If score = 10 Then      'Determines if player got score of 10
                WinCond = True
            Else
                WinCond = False
            End If
            CloseState = False
            MGF.StopBackgroundSound()
            Result.Show()
            Me.Close()
        End If
    End Sub
End Class