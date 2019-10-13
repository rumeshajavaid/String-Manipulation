Module Module1

    Sub Main()
        Dim string1, string2, nextcharacter, unwantedchar As String
        Dim counter As Integer = 0

        nextcharacter = ""
        string1 = ""
        string2 = ""
        unwantedchar = ""

        Console.Write("Enter string? ")
        string1 = Console.ReadLine

        Console.Write("Enter character to be removed: ")
        unwantedchar = Console.ReadLine

        For counter = 1 To Len(string1)
            nextcharacter = Mid(string1, counter, 1)
            If nextcharacter <> unwantedchar Then
                string2 = string2 + nextcharacter

            End If
        Next
        Console.WriteLine("the final string is: " & string2)
        Console.ReadKey()


    End Sub

End Module
