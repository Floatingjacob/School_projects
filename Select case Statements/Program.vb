Imports System
Imports System.Linq.Expressions

Module Program
    Dim Day = Date.Today.DayOfWeek
    Dim Sunday = Date.Now.DayOfWeek.Sunday
    Dim Monday = Date.Now.DayOfWeek.Monday
    Dim Tuesday = Date.Now.DayOfWeek.Tuesday
    Dim Wednsday = Date.Now.DayOfWeek.Wednesday
    Dim Thursday = Date.Now.DayOfWeek.Thursday
    Dim Friday = Date.Now.DayOfWeek.Friday
    Dim Saturday = Date.Now.DayOfWeek.Saturday
    Sub Main(args As String())

        Select Case Day
            Case Sunday
                Console.WriteLine("Today is Sunday")
                Console.WriteLine("Dont be late for church")
            Case Monday
                Console.WriteLine("Today is Monday")
                Console.WriteLine("Garfield sure is not having a good day today")
            Case Tuesday
                Console.WriteLine("Today is Tuesday.")
                Console.WriteLine("Go to The Link")
            Case Wednsday
                Console.WriteLine("Today is Wednsday.")
                Console.WriteLine("Nothing interesting today")
            Case Thursday
                Console.WriteLine("Today is Thursday")
                Console.WriteLine("Nothing interesting today")

            Case Friday
                Console.WriteLine("Today is Friday")
                Console.WriteLine("Today this project is due")
            Case Saturday
                Console.WriteLine("Today is Saturday")
                Console.WriteLine("You probably have late work")
        End Select
        Console.WriteLine("Press any key to exit...")
        While Console.ReadKey.Equals(0)
            Console.Write(".")
        End While
        Console.ReadKey()
    End Sub
End Module
