Imports System.Security.Cryptography    'TO ACCESS CRYPTOGRAPHIC LIBRARY

Public Class MainGameFunctions
    'THIS CLASS IS INSTANTIATED WHEN THE QUIZ BEGINS
    'CONTAINS ALL THE FUNCTIONS FOR THE LOGIC 
    'PLEASE UNDERSTAND SOME LOGIC WHEN PRESENTING

    'NOTE, ALSO CONTAINS THE RANDOMIZING FUNCTION

    'DIFFERENCE BETWEEN FUNCTION AND SUB (SUBROUTINE)
    'FUNCTION RETURNS A VALUE, SUB DOES NOT. 

    Sub initializeTheVariables()    'TO INITIATE THE VALUES FOR THE NEW QUIZ
        score = 0
        oras = 10.0
        pass = 2
        lives = 3
    End Sub

    Sub MakeAllValuesInArrayHundred()
        'Makes all value in arrays 100 for comparison purposes
        For i As Integer = 0 To 15
            AnswerArrays.Add("100")
        Next
        'THERE, LESS WORK FOR THE PROGRAMMER

    End Sub

    Sub setTheTimeAndScore(ByVal time As TextBox, ByVal TXscore As TextBox)
        time.Text = oras            'SET THE VALUES IN THE TEXTBOX
        TXscore.Text = score
    End Sub

   
    Function rNumber(ByVal min As Integer, ByVal exMax As Integer) As Integer
        Dim rngCSP As New RNGCryptoServiceProvider      'Initializes the RNGcryptoserviceprovider as an object
        Dim buffer As Byte() = New Byte(3) {}           'new byte array
        rngCSP.GetBytes(buffer)                         'Puts some random bytes in that array
        Dim result As Integer = BitConverter.ToInt32(buffer, 0) 'converts to integer to be used as seed
        'a seed is used to compute some random formula to get the desired random number
        Return New Random(result).Next(min, exMax)      'Returns random number
        'next is used as a reference which range will the random number fall to
    End Function

    Sub SetTheQuestionAndAnswer(ByVal rNum As Integer, ByVal txtBx As TextBox, ByVal lst As Array)
        txtBx.Text = lst(rNum)(0)       'Displays the question in the Textbox
        'using the random number
        QuizAnswer = lst(rNum)(1)       'sets the answer of the Question
    End Sub

    Sub playTheQuestionSound()
        My.Computer.Audio.Play(My.Resources.QuestionSound, AudioPlayMode.BackgroundLoop) 'plays question sound
    End Sub

    Sub StopBackgroundSound()
        My.Computer.Audio.Stop()        'stops the sound
    End Sub

    Sub placeSymbolsInLabels(ByVal lbl As Label, ByVal rpt As Integer, ByVal str As String)
        'this functions either sets the heart or check symbol in the respective labels
        lbl.Text = ""               'clears the text to prevent overlaps
        For i As Integer = 1 To rpt     'loops until the value of lives or passes
            lbl.Text = lbl.Text + str   'and repeats the ❤  or ✔ depending on the lives or passes left
        Next
    End Sub

End Class
