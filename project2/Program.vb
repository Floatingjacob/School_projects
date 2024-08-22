Imports System
Imports System.IO
Imports System.Text
Imports System.Numerics

Module Program

    Sub Main(args As String())
        Dim key As ConsoleKeyInfo

        Do
            Console.WriteLine("Press 1 for addition")
            Console.WriteLine("Press 2 for subtraction")
            Console.WriteLine("Press 3 for division")
            Console.WriteLine("Press 4 for multiplication")
            Console.WriteLine("Press Q to quit")
            key = Console.ReadKey(True)

            If key.KeyChar = "1"c Then
                Console.Write("Type your first number: ")
                Dim one As Decimal = Console.ReadLine()
                Console.Write("Type your second number: ")
                Dim two As Decimal = Console.ReadLine()
                Console.WriteLine("Result: " & (one + two))
            ElseIf key.KeyChar = "2"c Then
                Console.Write("Type your first number: ")
                Dim one As Decimal = Console.ReadLine()
                Console.Write("Type your second number: ")
                Dim two As Decimal = Console.ReadLine()
                Console.WriteLine("Result: " & (one - two))
            ElseIf key.KeyChar = "3"c Then
                Console.Write("Type your first number: ")
                Dim one As Decimal = Console.ReadLine()
                Console.Write("Type your second number: ")
                Dim two As Decimal = Console.ReadLine()
                Console.WriteLine("Result: " & (one / two))
            ElseIf key.KeyChar = "4"c Then
                Console.Write("Type your first number: ")
                Dim one As Decimal = Console.ReadLine()
                Console.Write("Type your second number: ")
                Dim two As Decimal = Console.ReadLine()
                Console.WriteLine("Result: " & (one * two))
            ElseIf key.KeyChar = "Q"c Or key.KeyChar = "q"c Then
                Exit Do
            End If

            Console.WriteLine("Press any key to continue...")
            Console.ReadKey(True)
            Console.Clear()
        Loop While True

        Console.WriteLine("Exiting...")
    End Sub
End Module
