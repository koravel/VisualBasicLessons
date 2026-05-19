Module RandomMain
    Sub Main()
        Dim randGenerator As New System.Random()

        For i As Integer = 0 To 10
            Dim randomNumber As Integer = randGenerator.Next(1, 100)
            Console.WriteLine(randomNumber)
            i += 1
        Next
    End Sub
End Module
