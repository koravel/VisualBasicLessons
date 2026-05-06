Module DoExamples
    'Eternal loop, same as While True but simplier
    Sub Iteration_DoLoop()
        Dim i As Integer = 0

        Do
            Console.WriteLine($"i = {i}")
            i += 1
        Loop
    End Sub

    Sub Iteration_DoUntil()
        Dim i As Integer = 0

        Do
            Console.WriteLine($"i = {i}")
            i += 1
        Loop Until i = 100
    End Sub

    Sub Iteration_DoWhile()
        Dim i As Integer = 0
        Do
            Console.WriteLine($"i = {i}")
            i += 1
        Loop While i < 100
    End Sub

    Sub Iteration_DoWhile_Variations()
        Dim i As Integer = 100

        Console.WriteLine($"Pre-condition:")
        Do While i < 100
            Console.WriteLine($"i = {i}")
            i += 1
        Loop

        i = 999

        Console.WriteLine($"Post-condition:")
        Do
            Console.WriteLine($"i = {i}")
            i += 1
        Loop While i < 100
    End Sub

    Sub ExitContinue()
        Console.WriteLine("Press arrow up or down to increase or decrease number")
        Dim j As Integer = 0
        Do
            Dim userKey = Console.ReadKey()
            Dim keyPressed = userKey.Key.ToString()

            Select Case keyPressed
                Case "UpArrow"
                    j += 1
                Case "DownArrow"
                    j -= 1
                Case "Escape"
                    Exit Do
                Case "Spacebar"
                    Continue Do
                Case Else
                    Console.WriteLine("Wrong key, buddy")
            End Select

            Console.WriteLine($"j = {j}")
        Loop
    End Sub

End Module
