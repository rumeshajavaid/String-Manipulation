Module Module1

    Sub Main()
        Dim string1, midword, word As String
        Dim Sp, Sp2 As Integer

        string1 = ""
        midword = ""
        word = ""
        Sp = 0
        Sp2 = 0

        Console.Write("Enter string of 3 words: ")
        string1 = Console.ReadLine

        Sp = InStr(string1, " ")
        word = Mid(string1, Sp + 1, Len(string1))

        Sp2 = InStr(word, " ")
        midword = Mid(word, 1, Sp2 - 1)

        Console.WriteLine("Mid word is " & midword)
        Console.ReadKey()

    End Sub

End Module
