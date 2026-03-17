Module WhileExamples
    Sub Iteration()
        Dim i As Integer = 0

        While i < 100
            Console.WriteLine($"i = {i}")
            i += 1
        End While
    End Sub

    Sub InputValidation_Wrong()
        Dim userInput1 As Integer
        Dim userInput2 As Integer

        Console.WriteLine("Input first number: ")
        If Not Integer.TryParse(Console.ReadLine(), userInput1) Then
            Console.WriteLine("Wrong input!")
        End If

        Console.WriteLine("Input second number: ")
        userInput2 = Console.ReadLine

        Console.WriteLine($"Sum = {userInput1 + userInput2}")
    End Sub

    Sub InputValidation_Right()
        Dim userInput1 As Integer
        Dim userInput2 As Integer

        Dim isUserInput1Correct = False
        While Not isUserInput1Correct
            Console.WriteLine("Input first number: ")
            isUserInput1Correct = Integer.TryParse(Console.ReadLine(), userInput1)

            If Not isUserInput1Correct Then
                Console.WriteLine("Only numbers allowed, input again")
            End If
        End While

        Dim isUserInput2Correct = False
        While Not isUserInput2Correct
            Console.WriteLine("Input second number: ")
            isUserInput2Correct = Integer.TryParse(Console.ReadLine(), userInput2)

            If Not isUserInput2Correct Then
                Console.WriteLine("Only numbers allowed, input again")
            End If
        End While

        Console.WriteLine($"Sum = {userInput1 + userInput2}")
    End Sub

    Sub ExitContinue()
        Dim i As Integer

        Console.WriteLine("Press arrow up or down to increase or decrease number")

        While True
            Dim userKey = Console.ReadKey()
            Dim keyPressed = userKey.Key.ToString()

            Select Case keyPressed
                Case "UpArrow"
                    i += 1
                Case "DownArrow"
                    i -= 1
                Case "Escape"
                    Exit While
                Case "Spacebar"
                    Continue While
                Case Else
                    Console.WriteLine("Wrong key, buddy")
            End Select

            Console.WriteLine($"i = {i}")
        End While
    End Sub

    Sub ContinueAbuse()
        Dim x As Integer = 0
        While x < 100
            If x < 100 Then
                Console.WriteLine($"x < 100, x = {x}")
            End If
            If x >= 99 Then
                Console.WriteLine($"x >= 100, x = {x}")
                Continue While
            End If
            x += 1
        End While
    End Sub
End Module