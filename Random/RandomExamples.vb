Module RandomExamples
    Function GetRandomNumber() As Integer
        Dim randGenerator As New System.Random(DateTime.UtcNow.Millisecond)

        Dim randomNumber As Integer = randGenerator.Next(1, 100)

        Return randomNumber
    End Function


End Module