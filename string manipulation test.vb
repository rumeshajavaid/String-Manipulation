Module Module1

    Sub Main()
        Dim validBinaryString As Boolean
        Dim string1, string2 As String
        Dim counter, nextchar, digit, sum, value As Integer

        string1 = ""
        string2 = ""
        counter = 0
        nextchar = 0
        validBinaryString = True
        sum = 0
        digit = 0
        value = 0

        Console.Write("Enter Binary number:")
        string1 = Console.ReadLine
        If Len(string1) > 0 And Len(string1) <= 8 Then
            validBinaryString = True
        Else
            validBinaryString = False
        End If

        For counter = 1 To Len(string1)
            nextchar = Mid(string1, counter, 1)
            If nextchar = "0" Or nextchar = "1" Then
                validBinaryString = True
            Else
                validBinaryString = False

            End If

        Next
        If validBinaryString = False Then
            Console.WriteLine("not a valid binary number")
        Else
            Console.WriteLine("It is a valid binary number")
            Console.ReadKey()

        End If

        If validBinaryString = True Then
            For counter = Len(string1) To 1 Step -1
                value = Mid(string1, counter, 1)


                If value = "1" Then
                    If counter = 8 Then
                        digit = value * 1
                        sum = sum + digit
                    Else
                        If counter = 7 Then
                            digit = value * 2
                            sum = sum + digit
                        Else
                            If counter = 6 Then
                                digit = value * 4
                                sum = sum + digit
                            Else
                                If counter = 5 Then
                                    digit = value * 8
                                    sum = sum + digit
                                Else
                                    If counter = 4 Then
                                        digit = value * 16
                                        sum = sum + digit
                                    Else
                                        If counter = 3 Then
                                            digit = value * 32
                                            sum = sum + digit
                                        Else
                                            If counter = 2 Then
                                                digit = value * 64
                                                sum = sum + digit
                                            Else
                                                If counter = 1 Then
                                                    digit = value * 128
                                                    sum = sum + digit
                                                End If
                                            End If

                                        End If
                                    End If

                                End If





                            End If



                        End If

                    End If

                End If









            Next
        End If
        Console.WriteLine(string1 & "=" & sum)
        Console.ReadKey()
    End Sub

End Module
