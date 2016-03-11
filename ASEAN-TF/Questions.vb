Public Class Questions
    Public QA()() As String = New String(49)() {}  'DECLARATION OF JAGGED ARRAY (ARRAY CONTAINING ARRAYS
    'MORE FASTER THEN 2D ARRAYS
    Sub LoadQuestions()     'LOADS THE QUESTION AND ANSWER INTO AN ARRAY
        'THERE IS AN ARRAY IN AN ARRAY
        QA(0) = New String() {"The establishment date of ASEAN is 1967", "True"}
        QA(1) = New String() {"The Philippines has the Highest Birthrate in ASEAN", "False"}
        QA(2) = New String() {"The ASEAN Economic Community is established in 2015", "True"}
        QA(3) = New String() {"ASEAN has 6 Founding members", "False"}
        QA(4) = New String() {"The ASEAN Secretariat is located in Jakarta", "True"}
        QA(5) = New String() {"Timor-Leste is a member of ASEAN", "False"}
        QA(6) = New String() {"Accountants in the Philippines who are ASEAN certified can work in any ASEAN member states", "True"}
        QA(7) = New String() {"ASEAN Academy of Engineering and Technology (AAET) was established in Malaysia", "False"}
        QA(8) = New String() {"An integrated ASEAN market will create 14 million extra jobs in the region by 2025", "True"}
        QA(9) = New String() {"Laos was spared in the Vietnam War", "False"}
        QA(10) = New String() {"Is Jakarta the capital of Thailand?", "False"}
        QA(11) = New String() {"National Flower of Laos is Dok champa?", "True"}
        QA(12) = New String() {"Current President of the Republic of the Union of Myanmar is Thein sein", "True"}
        QA(13) = New String() {"Currency of Brunei is Baht", "False"}
        QA(14) = New String() {"One vision,one identity,one community is the motto of ASEAN", "True"}
        QA(15) = New String() {"The largest producer of rubber in Southeast Asia is Philippines", "False"}
        QA(16) = New String() {"Indonesian archipelago comprises of around 14,000 islands", "False"}
        QA(17) = New String() {"ZOPFAN is the acronym for  Zone of Peace", "False"}
        QA(18) = New String() {"Philippine hosted 2013 Asean Games", "False"}
        QA(19) = New String() {"The Philippines comprises of 10,000 islands.", "False"}
        QA(20) = New String() {"THIS IS A STUB QUESTION = TRUE", "True"}
    End Sub

End Class
