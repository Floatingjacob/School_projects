Imports System.Net.Http
Imports System.Text.Json.Nodes

Module Program

    Sub Main(args As String())
        Run().Wait()
    End Sub

    Public Async Function Run() As Task
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Lookup Bedrock XUID and convert to Java UUID-style format.")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("Type the Minecraft Bedrock username here: ")
        Dim username = Console.ReadLine()
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("[DEBUG] ")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Fetching user info...
")

        Dim xuidDecimal As String = Await GetXUID("https://mcprofile.io/api/v1/bedrock/gamertag/" & username)

        If String.IsNullOrEmpty(xuidDecimal) Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write("ERROR! ")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("Failed to retrieve XUID.")
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Press any key to exit...")
            Console.ReadKey()
            Return
        End If
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("[DEBUG] ")
        Console.WriteLine("XUID in decimal is: " & xuidDecimal)
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("[DEBUG] ")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Converting to hex...
")

        Dim xuidHex As String = Convert.ToUInt64(xuidDecimal).ToString("X").PadLeft(16, "0"c)
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("[DEBUG] ")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("XUID in HEX: " & xuidHex)

        If xuidHex.Length = 16 Then
            Dim formatted = "00000000-0000-0000-" & Left(xuidHex, 4) & "-" & Right(xuidHex, 12)
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Success!")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("The Java-formatted XUID is: ")
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine(formatted & "
")

            Console.ForegroundColor = ConsoleColor.White
            Console.Write("The geyser command to add this user to your minecraft server is: ")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("/fwhitelist add " & formatted)
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write("[ERROR] ")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("XUID in incorrect HEX length.")
        End If
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Function

    Public Async Function GetXUID(url As String) As Task(Of String)
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            Select Case response.IsSuccessStatusCode
                Case True
                Case False
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write("[ERROR] ")
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.WriteLine("Username not found.")
                    Console.WriteLine("Press any key to exit...")
                    Console.ReadKey()
                    End
            End Select
            Dim jsonString As String = Await response.Content.ReadAsStringAsync()
            Dim xuid As String = JsonObject.Parse(jsonString)?("xuid")?.ToString()
            Return xuid
        End Using
    End Function

End Module
