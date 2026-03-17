Module BasicCalculator
    '1. Create a program that will do arithmetic operations with two numbers based on sign:
    '-Numbers must be Double and be inserted by user
    '-Sign of operation also must br inserted by user
    '-Result of operation is going to a terminal with usage of string interpolation ($"...")
    Sub Start()
        Console.WriteLine("Input first number: ")
        Dim input1 = Console.ReadLine

        Console.WriteLine("Input second number: ")
        Dim input2 = Console.ReadLine

        Dim number1 = Double.Parse(input1)
        Dim number2 = Double.Parse(input2)

        Console.WriteLine("Input sign of operation: ")
        Dim operaitionSign = Console.ReadLine

        Dim result As Double
        Select Case operaitionSign
            Case "+"
                result = number1 + number2
            Case "-"
                result = number1 - number2
            Case "*"
                result = number1 * number2
            Case "/"
                result = number1 / number2
        End Select

        Console.WriteLine($"Result = {result}")
    End Sub
End Module
