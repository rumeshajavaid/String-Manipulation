Module Module1

    Sub Main()
        Dim string1, string2, firstword, secondword As String
        Dim SP As Integer

        string1 = ""
        string2 = ""
        firstword = ""
        secondword = ""
        SP = 0

        Console.Write("Enter first string ?")
        string1 = Console.ReadLine

        Console.Write("Enter second string?")
        string2 = Console.ReadLine

        SP = InStr(string1, " ")
        firstword = Left(string1, SP - 1)

        SP = InStr(string2, " ")
        secondword = Right(string2, Len(string2) - SP)
        Console.WriteLine("finale string =" &
                          firstword & " " & secondword)
        Console.ReadKey()


    End Sub

End Module
