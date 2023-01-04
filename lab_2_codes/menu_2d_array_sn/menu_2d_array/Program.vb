Imports System
Imports System.ComponentModel.Design
Imports System.Threading

Module Program
    Sub Main(args As String())
        Dim ex As Integer
        Dim option_1 As Integer

        Dim input As String
        Dim menu_1 As String(,)
        ReDim Preserve menu_1(10, 0)

        menu_1(0, 0) = " kebab    9.99  5"
        menu_1(1, 0) = " beef    6.99   7"
        menu_1(2, 0) = " chiken   4.00   9"
        menu_1(3, 0) = " beer    0.99   10"





        Console.WriteLine("do you want to enter the new item?: if yes type 1 if not type 0")
        option_1 = Console.ReadLine()
        If option_1 = 1 Then


            For index As Integer = 4 To menu_1.Length
                Console.WriteLine("enter the new item:")
                input = Console.ReadLine()
                menu_1(index, 0) = input



                Console.WriteLine("do you want to enter the new item?: if yes type 1 if not type 0")
                ex = Console.ReadLine()

                If ex = 0 Then
                    Exit For ' terminate the For loop   
                End If

            Next
            For i As Integer = 0 To menu_1.Length - 1

                Console.WriteLine("item{0} = {1}", i, menu_1(i, 0))

            Next

        Else


            For i As Integer = 0 To menu_1.Length - 1

                Console.WriteLine("item{0} = {1}", i, menu_1(i, 0))

            Next


        End If


    End Sub
End Module
