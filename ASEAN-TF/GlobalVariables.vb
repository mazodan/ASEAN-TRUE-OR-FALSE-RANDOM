Public Module GlobalVariables
    Public score As Integer = 0     'SCORE OF THE PLAYER = DEFAULT IS 0
    Public oras As Double = 10.0    'SECONDS LEFT FOR THE PLAYER = DEFAULT IS 10 AND DECREMENTED
    Public pass As Integer = 2      'HOW MANY LEFT TO PASS = DEFAULT IS 2
    Public lives As Integer = 3     'LIVES LEFT FOR THE PLAYER = DEFAULT IS 3
    Public WinCond As Boolean       'DETERMINES IF USER REALLY WON OR LOST
    Public QuizAnswer As String     'THE ANSWER TO BE QUESTION
    Public AnswerArrays As New List(Of String)   'STORE THE ALREADY ANSWERED QUESTIONS FOR THIS QUIZ
End Module
