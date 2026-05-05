Module ForExamples
    Sub Iteration()
        For i As Integer = 0 To 100
            Console.WriteLine($"i = {i}")
        Next
    End Sub

    Sub Iteration_Step()
        For i As Integer = 0 To 100 Step 2
            Console.WriteLine($"i = {i}")
        Next
    End Sub

    Sub Iteration_Step_Negative()
        For i As Integer = 100 To 0 Step -1
            Console.WriteLine($"i = {i}")
        Next
    End Sub

    Sub Iteration_Step_Double()
        For i As Integer = 0 To 100 Step 0.25
            Console.WriteLine($"i = {i}")
        Next
    End Sub

    Sub ExitContinue()
        Console.WriteLine("Press arrow up or down to increase or decrease number")
        Dim j As Integer = 0
        For i As Integer = 0 To Integer.MaxValue
            Dim userKey = Console.ReadKey()
            Dim keyPressed = userKey.Key.ToString()

            Select Case keyPressed
                Case "UpArrow"
                    j += 1
                Case "DownArrow"
                    j -= 1
                Case "Escape"
                    Exit For
                Case "Spacebar"
                    Continue For
                Case Else
                    Console.WriteLine("Wrong key, buddy")
            End Select

            Console.WriteLine($"j = {j}")
        Next
    End Sub
End Module
