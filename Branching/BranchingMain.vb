Module BranchingMain

    Sub Main()

        Console.WriteLine("Input a number from 1 to 4: ")
        Dim specialNumber As Integer = Console.ReadLine()

        ' If Else example
        If specialNumber = 1 Then
            Console.WriteLine("Number is 1")
        ElseIf specialNumber = 2 Then
            Console.WriteLine("Number is 2")
        ElseIf specialNumber = 3 Then
            Console.WriteLine("Number is 3")
        ElseIf specialNumber = 4 Then
            Console.WriteLine("Number is 4")
        Else
            Console.WriteLine("Number is wrong")
        End If

        ' Select example
        Select Case specialNumber
            Case 1
                Console.WriteLine("Number is 1")
            Case 2
                Console.WriteLine("Number is 2")
            Case Else
                Console.WriteLine("Number is wrong")
        End Select



    End Sub
End Module
