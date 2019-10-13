Module Module1

    Sub Main()
        Dim string1, string2, nextchar As String
        Dim counter As Integer = 0
        Dim Ispangram As Boolean = True

        string1 = ""
        string2 = "abcdefghijklmnopqrstuvwxyz"
        nextchar = ""

        Console.Write("Enter string to be checked ? ")
        string1 = Console.ReadLine
        string1 = LCase(string1)

        For counter = 1 To Len(string2)
            nextchar = Mid(string2, counter, 1)
            If InStr(string1, nextchar) = 0 Then
                Ispangram = False
            End If



        Next
        If Ispangram = True Then
            Console.Write("It is a pangram!")
        Else


            Console.Write("It is not a pangram!")

        End If


        Console.ReadKey()
    End Sub

End Module
