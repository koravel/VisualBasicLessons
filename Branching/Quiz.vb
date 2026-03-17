Module Quiz
    '2. Create a program-quiz:
    '-Prepare a set of questions and answers, 3 questions will be sufficient
    '-Use them in branching to create quiz-like behaviour
    '-Add mini score system: for each right ansqwer +1 point
    '-Output to terminal score of the user as well as correctness of their answers for each question
    '-Do Not forget to use string interpolation
    Sub Start()
        Dim question1 = "Question1"
        Dim question2 = "Question2"
        Dim question3 = "Question3"

        Dim answer11 = "Answer11"
        Dim answer12 = "Answer12"

        Dim answer21 = "Answer21"
        Dim answer22 = "Answer22"

        Dim answer31 = "Answer31"
        Dim answer32 = "Answer32"

        Dim correctAnswer1 = answer11
        Dim correctAnswer2 = answer22
        Dim correctAnswer3 = answer31

        Dim userScore = 0

        Dim userInput As String

        Console.WriteLine(question1)
        userInput = Console.ReadLine()

        If userInput = correctAnswer1 Then
            userScore += 1
            Console.WriteLine("Correct!")
        Else
            Console.WriteLine("Incorrect!")
        End If

        Console.WriteLine(question2)
        userInput = Console.ReadLine()

        If userInput = correctAnswer2 Then
            userScore += 1
            Console.WriteLine("Correct!")
        Else
            Console.WriteLine("Incorrect!")
        End If

        Console.WriteLine(question3)
        userInput = Console.ReadLine()

        If userInput = correctAnswer3 Then
            userScore += 1
            Console.WriteLine("Correct!")
        Else
            Console.WriteLine("Incorrect!")
        End If

        Console.WriteLine($"User score = {userScore}")

    End Sub
End Module
