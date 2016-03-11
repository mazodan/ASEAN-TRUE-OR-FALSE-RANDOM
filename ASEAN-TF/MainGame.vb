Public Class MainGame
    Dim CloseState As Boolean = True    'THIS IS SWITCHED IF THE USER FINISHED THE QUIZ
    'TO PREVENT GOING BACK TO THE MAIN MENU
    Dim MGF As New MainGameFunctions    'Declare new instance of the object
    Dim rInteger As Integer             'The random number to be Used

    Private Sub MainGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MGF.initializeTheVariables()    'Initializes the pertinent values
        MGF.setTheTimeAndScore(txtTimeLeft, txtScore)



    End Sub

    Private Sub MainGame_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CloseState = True Then
            txtQuestion.Visible = False
            If MessageBox.Show("Are you sure you want to Quit this quiz", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                MainMenu.Show()

            Else
                e.Cancel = True
                txtQuestion.Visible = True
            End If
        End If
    End Sub

    'Temporary stub
    Private Sub stBtnR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stBtnR.Click
        Dim QuestionAlreadyUsed = True
        While QuestionAlreadyUsed = True
            rInteger = MGF.rNumber(0, 21)
            If AnswerArrays.Contains(rInteger.ToString) = True Then
                QuestionAlreadyUsed = True
            Else
                AnswerArrays(Val(lblQuestionNumber) - 1) = rInteger.ToString
                Exit While
                'Exits While statement without messing with the condition
            End If

        End While


        MessageBox.Show(MGF.rNumber(0, 21))
    End Sub
End Class