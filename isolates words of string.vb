Module Module1

    Sub Main()
        Dim string1, string2, nextchar As String
        Dim counter As Integer = 0

        string1 = ""
        string2 = ""
        nextchar = ""

        Console.Write("Enter string ? ")
        string1 = Console.ReadLine

        For counter = 1 To Len(string1)
            nextchar = Mid(string1, counter, 1)
            string2 = string2 + nextchar

            If nextchar = " " Then
                Console.WriteLine(string2)
                string2 = ""

            End If


        Next
        Console.WriteLine(string2)
        Console.ReadKey()
    End Sub

End Module
