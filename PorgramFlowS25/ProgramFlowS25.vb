Option Explicit On
Option Strict On
Option Compare Text


Module ProgramFlowS25

    Sub Main()

        'Do 'starts first number at 0. adds 1 to itself and writes to console what its value is
        '    Console.WriteLine("In the first loop. Loop While firstNumber <= 3")
        '    firstNumber += 1
        '    Console.WriteLine($"FirstNumber is {firstNumber}")
        'Loop While firstNumber <= 3 'loops this process until first number is greater than or equal to 3

        'Console.WriteLine()

        'Do
        '    Console.WriteLine("In the second loop. Loop While firstNumber <= 3") 'same as first loop
        '    firstNumber += 1
        '    Console.WriteLine($"FirstNumber is {firstNumber}")
        'Loop While firstNumber <= 3 'first number is now 5, second loop stops here

        'Console.WriteLine()

        'Do Until firstNumber >= 3 'evaluation at the beginning of loop, first number is now >3, so loop never runs
        '    Console.WriteLine("In the third loop. Loop While firstNumber >= 3")
        '    firstNumber += 1
        '    Console.WriteLine($"FirstNumber is {firstNumber}")
        'Loop

        'Do While firstNumber >= 3
        '    Console.WriteLine("In the fourth loop. Loop While firstNumber >= 3") 'loops while first number is greater than or equal to 3
        '    firstNumber -= 1 'subtracts 1 each loop
        '    Console.WriteLine($"FirstNumber is {firstNumber}") 'displays new first number
        'Loop

        'Console.WriteLine()

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim getOutOfHere As Boolean = False
        Dim userInput As String


        Do
            'first loop
            Console.WriteLine("Enter a whole number")
            Console.WriteLine("Enter Q to quit")
            userInput = Console.ReadLine()
            Console.WriteLine($"You entered {userInput}")
            Try
                firstNumber = CInt(userInput)
                getOutOfHere = True

            Catch ex As Exception
                If userInput <> "Q" Then
                    Console.WriteLine("No no no," & $" {userInput} is not a whole number")
                Else
                    getOutOfHere = True
                End If
            End Try
        Loop Until getOutOfHere = True

        'second loop
        getOutOfHere = False 'reset flag
        Do While userInput <> "Q" And getOutOfHere = False

            Console.WriteLine("Enter another whole number")
            Console.WriteLine("Enter Q to quit")
            userInput = Console.ReadLine()
            Console.WriteLine($"You entered {userInput}")
            Try
                secondNumber = CInt(userInput)
                getOutOfHere = True

            Catch ex As Exception
                If userInput <> "Q" Then
                    Console.WriteLine("No no no," & $" {userInput} is not a whole number")
                Else
                    getOutOfHere = True
                End If
            End Try
        Loop





    End Sub

End Module
