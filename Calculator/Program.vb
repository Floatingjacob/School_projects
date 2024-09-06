Imports System

Module Program

    Sub Main(args As String())
        Console.WriteLine("input your math")
        Console.WriteLine("the correct format is: num1 operator num2")
        Console.WriteLine("you can use up to 3 operators before needing to start a new equation")
        Console.WriteLine("you can only use whole numbers, no decimals")
        Dim input As String = Console.ReadLine()

        Dim parts As String() = input.Split(" "c)

        If parts.Length = 3 Then
            Dim num1 As Integer = Convert.ToInt32(parts(0))
            Dim operator1 As String = parts(1)
            Dim num2 As Integer = Convert.ToInt32(parts(2))

            Dim doneSomeMath As String = DoSomeMath(num1, operator1, num2)
            Console.WriteLine(doneSomeMath)
        ElseIf parts.Length = 5 Then
            Dim num1 As Integer = Convert.ToInt32(parts(0))
            Dim operator1 As String = parts(1)
            Dim num2 As Integer = Convert.ToInt32(parts(2))
            Dim operator2 As String = parts(3)
            Dim num3 As Integer = Convert.ToInt32(parts(4))
            Dim doneSomeMath As String = DoSomeMath(num1, operator1, num2, operator2, num3)
            Console.WriteLine(doneSomeMath)
        ElseIf parts.Length = 7 Then
            Dim num1 As Integer = Convert.ToInt32(parts(0))
            Dim operator1 As String = parts(1)
            Dim num2 As Integer = Convert.ToInt32(parts(2))
            Dim operator2 As String = parts(3)
            Dim num3 As Integer = Convert.ToInt32(parts(4))
            Dim operator3 As String = parts(5)
            Dim num4 As Integer = Convert.ToInt32(parts(6))
            Dim doneSomeMath As String = DoSomeMath(num1, operator1, num2, operator2, num3, operator3, num4)
            Console.WriteLine(doneSomeMath)
        End If

        dotdotdot()
    End Sub

    Function dotdotdot()
        Do Until Console.KeyAvailable
            Console.Write(".")
            Threading.Thread.Sleep(800)
        Loop
    End Function

    Private Function DoSomeMath(num1 As Integer, operator1 As String, num2 As Integer) As String
        Dim result1 As Double
        Select Case operator1
            Case "+"
                result1 = num1 + num2
            Case "-"
                result1 = num1 - num2
            Case "*"
                result1 = num1 * num2
            Case "/"
                result1 = num1 / num2
            Case Else
                Return "Invalid operator"
        End Select
        Return $"{num1} {operator1} {num2} = {result1}"
    End Function

    Private Function DoSomeMath(num1 As Integer, operator1 As String, num2 As Integer, operator2 As String, num3 As Integer) As String
        Dim result1 As Double
        Select Case operator1
            Case "+"
                result1 = num1 + num2
            Case "-"
                result1 = num1 - num2
            Case "*"
                result1 = num1 * num2
            Case "/"
                result1 = num1 / num2
            Case Else
                Return "Invalid operator"
        End Select

        Dim result2 As Double
        Select Case operator2
            Case "+"
                result2 = result1 + num3
            Case "-"
                result2 = result1 - num3
            Case "*"
                result2 = result1 * num3
            Case "/"
                result2 = result1 / num3
            Case Else
                Return "Invalid operator"
        End Select

        Return $"{num1} {operator1} {num2} {operator2} {num3} = {result2}"
    End Function

    Private Function DoSomeMath(num1 As Integer, operator1 As String, num2 As Integer, operator2 As String, num3 As Integer, operator3 As String, num4 As Integer) As String
        Dim result1 As Double
        Select Case operator1
            Case "+"
                result1 = num1 + num2
            Case "-"
                result1 = num1 - num2
            Case "*"
                result1 = num1 * num2
            Case "/"
                result1 = num1 / num2
            Case Else
                Return "Invalid operator"
        End Select

        Dim result2 As Double
        Select Case operator2
            Case "+"
                result2 = result1 + num3
            Case "-"
                result2 = result1 - num3
            Case "*"
                result2 = result1 * num3
            Case "/"
                result2 = result1 / num3
            Case Else
                Return "Invalid operator"
        End Select

        Dim result3 As Double
        Select Case operator3
            Case "+"
                result3 = result2 + num4
            Case "-"
                result3 = result2 - num4
            Case "*"
                result3 = result2 * num4
            Case "/"
                result3 = result2 / num4
            Case Else
                Return "Invalid operator"
        End Select

        Return $"{num1} {operator1} {num2} {operator2} {num3} {operator3} {num4} = {result3}"
    End Function
End Module
