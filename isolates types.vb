Module Module1

    Sub Main()
        Dim string1, nextchar, Alphabet, Number, Specialchar As String
        Dim Counter As Integer = 0


        string1 = ""
        Nextchar = ""
        Alphabet = ""
        Number = ""
        Specialchar = ""

        Console.Write(" Enter string = ")
        string1 = Console.ReadLine

        For Counter = 1 To Len(string1)
            nextchar = LCase(Mid(string1, Counter, 1))

            If nextchar >= "a" And nextchar <= "z" Then
                Alphabet = Alphabet & nextchar
            Else

                If nextchar >= "0" And nextchar <= "9" Then
                    Number = Number & nextchar
                Else
                    Specialchar = Specialchar & nextchar

                End If


            End If

        Next


        Console.WriteLine("The alphabets in the string are = " & Alphabet)
        Console.WriteLine("The numbers are = " & Number)
        Console.WriteLine("The special characters are = " & Specialchar)
        Console.ReadKey()


    End Sub

End Module
