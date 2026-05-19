Module SingleDimArrayExamples
    Sub DeclarationAndUsage()
        'Declaration
        Dim numbers(4) As Integer

        'Initialization case#1
        numbers = New Integer() {1, 2, 3, 4}

        'Initialization case#2
        numbers = {1, 2, 3, 4}

        'Initialization case#3 & Indexes
        numbers(0) = 1
        numbers(1) = 2
        numbers(2) = 3
        numbers(3) = 4
        'Usage case#1
        Console.WriteLine(numbers)

        'Usage case#2
        Console.WriteLine(numbers(0))

    End Sub

    Sub Printing()

    End Sub

    Sub FindMaxValue()

    End Sub

    Sub FindMinValue()

    End Sub

    Sub SumOfElements()

    End Sub

    Sub CountElementsByValue()

    End Sub

    Sub FindElementsBetweenValues()

    End Sub

    Sub PrintUniqueElements()

    End Sub

    Sub MakeCopy()

    End Sub

    Sub SeparateOddAndEven()

    End Sub

    Sub MergeTwoArrays()

    End Sub

    Sub SortElementsAscending()

    End Sub

    Sub SortElementsDescending()

    End Sub
End Module

