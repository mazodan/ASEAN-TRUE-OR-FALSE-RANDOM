Imports WMPLib          'accesses the windows media player component of windows

Public Class MainGame
    Dim CloseState As Boolean = True    'THIS IS SWITCHED IF THE USER FINISHED THE QUIZ
    'TO PREVENT GOING BACK TO THE MAIN MENU
    Dim MGF As New MainGameFunctions    'Declare new instance of the object, contains game functions
    Dim Q As New Questions              'Object contains the question array/database
    Dim rInteger As Integer             'The random number to be Used
    Dim QuestionIndex As Integer = 0    'the current Question
    Dim Ans As String                   'when the user chooses his choice to compare to the answer


    Private Sub MainGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MGF.initializeTheVariables()    'Initializes the pertinent values
        MGF.setTheTimeAndScore(txtTimeLeft, txtScore)   'Sets the default time and score when the game starts
        MGF.placeSymbolsInLabels(lblLife, lives, "❤")   'the two codes will place the symbols depending on the lives or pass values
        MGF.placeSymbolsInLabels(lblPass, pass, "✔")
        MGF.MakeAllValuesInArrayHundred()   'to make all arrays values as 100 to reset
        'after a new game is initiated
        SelectRandomNumber()            'Selects the random number to be used
        Q.LoadQuestions()               'Loads all questions to the Jagged Array
        MGF.SetTheQuestionAndAnswer(rInteger, txtQuestion, Q.QA)    'Selects a random question
        'Sets the question using the Random integer
        MGF.playTheQuestionSound()
        'PLAYS THE BACKGROUND SOUND
        Qtimer.Start()              'starts the countdown


    End Sub

    Private Sub MainGame_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CloseState = True Then           'will only launch if the user has not yet finished the quiz
            txtQuestion.Visible = False     'makes the question disappear to prevent cheating
            Qtimer.Enabled = False          'pauses the timer
            If MessageBox.Show("Are you sure you want to Quit this quiz", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                MainMenu.Show()         'Shows the hidden main menu
                AnswerArrays.Clear()    'clears the array to recycle for next game
                MGF.StopBackgroundSound()   'stops any playing sound
            Else
                e.Cancel = True             'cancels the form closing, e is event arguments
                txtQuestion.Visible = True  'makes the question visible again
                Qtimer.Enabled = True       'resumes the timer
            End If
        End If
    End Sub


    Sub SelectRandomNumber()
        Dim QuestionAlreadyUsed = True
        'Sample condition, Will always return true
        While QuestionAlreadyUsed = True
            'Uses while statement to repeat if Question is already asked
            'array will reset in a new game;
            rInteger = MGF.rNumber(0, 49)
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
        'Note, this timer is set to 10 miliseconds
        If oras = 0 Or oras < 0 Then    'Automatic Pass if timer reached zero
            nxtQuestion()               'next question is launched
        Else
            txtTimeLeft.Text = oras     'if timer has not reached zero
            oras -= 0.01                'the timer will decrement by 1 hundreths of a second
            pbarTime.Value = oras       'timer is set to the progress bar
        End If
    End Sub


    Private Sub btnTrue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrue.Click
        Ans = "True"            'sets answer to true and checks the answer, same with the bottom code
        checkAnswer()
    End Sub

    Private Sub btnFalse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFalse.Click
        Ans = "False"
        checkAnswer()
    End Sub

    Sub checkAnswer()
        Dim ResourceFilePath As String          'this will set the resource file path of the program
        If Ans = QuizAnswer Then                'if user is correct
            ResourceFilePath = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\resources\")
            'System.IO.Path.GetFullPath - gets the precise location of the path
            'Application.startupPath - gets the path of the exe file
            '\..\..\ - goes up 2 times in the folder and goes to the resources folder where the sound is
            wmp.URL = ResourceFilePath & "\tama.wav"
            'uses the Windows media player component to play the sound, sets the url to the sound indicating the user is correct
            wmp.Ctlcontrols.play()          'plays the correct sound
            score += 1                      'increments the score
            txtScore.Text = score           'places it in the textbox
            nxtQuestion()                   'the next question is retrived randomly
        Else
            ResourceFilePath = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\resources\")
            wmp.URL = ResourceFilePath & "\mali.wav"        'sound played when the user is wrong
            wmp.Ctlcontrols.play()                          'Wrong sound
            lives -= 1                                      'decrements life
            MGF.placeSymbolsInLabels(lblLife, lives, "❤")   'updates the symbols
            nxtQuestion()                                   'the next question is retrived randomly

        End If
    End Sub

    Sub nxtQuestion()                   'When the next question is requested
        winCondition()                  'checks the win condition
        oras = 10.0                     'time is reset to 10 seconds
        QuestionIndex += 1              'question number is incremented
        SelectRandomNumber()            'Selects the random number to be used
        MGF.SetTheQuestionAndAnswer(rInteger, txtQuestion, Q.QA)    'gets the random question and places it into the question textbox
        lblQuestionNumber.Text = QuestionIndex + 1                  'question index gets updated in the form
    End Sub


    Private Sub btnPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPass.Click
        If pass > 0 Then            'if the player still has pass
            pass -= 1               'pass is reduced
            MGF.placeSymbolsInLabels(lblPass, pass, "✔")    'updates the symbols
            nxtQuestion()           'gets next question
        End If
        If pass = 0 Then
            btnPass.Visible = False 'if player does not have passes left, pass button disappears
        End If
    End Sub

    Sub winCondition()
        If lblQuestionNumber.Text = "15" Or score = 10 Or lives = 0 Then
            If score = 10 Then      'Determines if player got score of 10
                WinCond = True      'sets the boolean win condition whether player has won
            Else
                WinCond = False
            End If
            CloseState = False      'prevents closing the whole app if user finishes or loses the quiz
            MGF.StopBackgroundSound() 'stops the background sound
            Result.Show()           'shows the result
            Me.Close()              'exits this main game form
        End If
    End Sub
End Class