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
        For Each Str As String In AnswerArrays
            Str = "100"
            'THERE, LESS WORK FOR THE PROGRAMMER
        Next
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



End Class
