Module Module1

    Sub Main()
        Dim string1, nextchar, string2 As String
        Dim counter As Integer = 0
        Dim Isanagram As Boolean = True
        string1 = ""
        string2 = ""
        nextchar = ""

        Console.Write("Enter string1 ? ")
        string1 = Console.ReadLine
        string1 = LCase(string1)

        Console.Write("Enter string2 ? ")
        string2 = Console.ReadLine
        string2 = LCase(string2)

        For counter = 1 To Len(string1)
            nextchar = Mid(string1, counter, 1)
            If InStr(string2, nextchar) = 0 Then
                Isanagram = False

            End If
        Next
        If Isanagram = True Then
            Console.WriteLine("String1 and String2 are anagram!")
        Else
            Console.WriteLine("String1 and String2 are not anagram!")
        End If
        Console.ReadKey()

    End Sub

End Module
