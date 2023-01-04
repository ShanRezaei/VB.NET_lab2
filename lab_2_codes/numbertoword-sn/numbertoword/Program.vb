Imports System
Imports System.IO
Imports System.Security.Cryptography

Module Program

    Sub main()
        Dim mynumber_1 As Integer
        Dim mynumber, digits As String
        Dim numbertoword As String
        Dim Words As String
        'Dim Digits As String
        Dim TM As String



        Console.WriteLine("enter a number")
        mynumber_1 = Console.ReadLine()

        mynumber = (Str(mynumber_1))



        ' If MyNumber between 1 To 99 Only.
        TM = Right(mynumber, 2)


        If mynumber_1 >= 0 And mynumber_1 < 10 Then
            Select Case mynumber_1

                Case 0
                    Console.WriteLine("the converted number is:  zero")
                    Console.ReadKey()

                Case 1

                    Console.WriteLine("the converted number is:  One")
                    Console.ReadKey()
                Case 2
                    Console.WriteLine("the converted number is: two ")
                    Console.ReadKey()
                Case 3
                    Console.WriteLine("the converted number is:  three")
                    Console.ReadKey()
                Case 4
                    Console.WriteLine("the converted number is:  four")
                    Console.ReadKey()
                Case 5
                    Console.WriteLine("the converted number is:  five")
                    Console.ReadKey()
                Case 6
                    Console.WriteLine("the converted number is: six")
                    Console.ReadKey()
                Case 7
                    Console.WriteLine("the converted number is: seven")
                    Console.ReadKey()
                Case 8
                    Console.WriteLine("the converted number is:  eight")
                    Console.ReadKey()
                Case 9
                    Console.WriteLine("the converted number is: nine")
                    Console.ReadKey()
                Case Else
                    Console.WriteLine("")
                    Console.ReadKey()
            End Select






        ElseIf (mynumber_1 >= 10 And mynumber_1 <= 20) Then

            Select Case mynumber_1
                Case 10
                    Console.WriteLine("the converted number is: ten")
                    Console.ReadKey()
                Case 11
                    Console.WriteLine("the converted number is: eleven")
                    Console.ReadKey()
                Case 12
                    Console.WriteLine("the converted number is: twleve")
                    Console.ReadKey()
                Case 13
                    Console.WriteLine("the converted number is: thirteen")
                    Console.ReadKey()
                Case 14
                    Console.WriteLine("the converted number is:fourteen")
                    Console.ReadKey()
                Case 15
                    Console.WriteLine("the converted number is: fifteen")
                    Console.ReadKey()
                Case 16
                    Console.WriteLine("the converted number is: sixteen")
                    Console.ReadKey()
                Case 17
                    Console.WriteLine("the converted number is: seventeen")
                    Console.ReadKey()
                Case 18
                    Console.WriteLine("the converted number is: eighteen")
                    Console.ReadKey()
                Case 19
                    Console.WriteLine("the converted number is: nineteen")
                    Console.ReadKey()
                Case 20
                    Console.WriteLine("the converted number is: twenty")
                    Console.ReadKey()

                Case Else
                    Console.WriteLine("")
                    Console.ReadKey()
            End Select


        ElseIf (mynumber_1 >= 20 And mynumber_1 < 100) Then

            Words = ConvertTens(TM)
            numbertoword = Words & digits
            Console.WriteLine(numbertoword)
            Console.ReadKey()


        ElseIf mynumber_1 = 100 Then
            Console.WriteLine("the converted number is: one hundred")
            Console.ReadKey()
        Else



        End If



    End Sub




    ' Conversion for tens
    '*****************************************

    Private Function ConvertTens(ByVal MyTens)
        Dim Result As String

        ' .. otherwise it's between 20 and 99.
        Select Case Val(Left(MyTens, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select

            ' Convert ones place digit.
            Result = Result & ConvertDigit(Right(MyTens, 1))


        ConvertTens = Result
    End Function

    Private Function ConvertDigit(ByVal MyDigit)
        Select Case Val(MyDigit)
            Case 1 : ConvertDigit = "One"
            Case 2 : ConvertDigit = "Two"
            Case 3 : ConvertDigit = "Three"
            Case 4 : ConvertDigit = "Four"
            Case 5 : ConvertDigit = "Five"
            Case 6 : ConvertDigit = "Six"
            Case 7 : ConvertDigit = "Seven"
            Case 8 : ConvertDigit = "Eight"
            Case 9 : ConvertDigit = "Nine"
            Case Else : ConvertDigit = ""
        End Select
    End Function



End Module
