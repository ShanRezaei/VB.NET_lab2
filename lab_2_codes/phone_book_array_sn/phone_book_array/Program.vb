Imports System

Module Program
    Sub Main(args As String())




        Dim opt As Integer = 1
        Dim ex_1 As Integer
        Dim ex_4 As Integer
        Dim ex As Integer
        Dim ex_2 As Integer
        Dim ex_3 As Integer
        Dim input As String
        Dim input_add As String
        Dim new_input As String
        Dim input_delete As Integer
        Dim input_update As Integer
        Dim phone_book As String()
        ReDim Preserve phone_book(20)

        phone_book(0) = "mary lavine, 5143789843"
        phone_book(1) = " sarah mrcdi, 5143786543"
        phone_book(2) = " shan lavine, 5143789843"
        phone_book(3) = " mehr shokri, 5143789843"




        Console.WriteLine("**************welcome to phone book********************")



        Do



            Console.WriteLine("if you want to add new contact type add")
            Console.WriteLine("if you want to delete a contact type delete")
            Console.WriteLine("if  you want to update a contact type update ")
            Console.WriteLine("if you want to display contacts type display ")
            Console.WriteLine("if you want to exit type exit")
            Input = Console.ReadLine()


            Select Case input

                Case "add"


                    Do

                        Dim index_1 As Integer
                        Dim opt_1 As Boolean
                        For j As Integer = 0 To phone_book.Length - 1

                            opt_1 = String.IsNullOrEmpty(phone_book(j))

                            If opt_1 = True Then
                                index_1 = j
                                Exit For
                            End If
                        Next




                        For index As Integer = index_1 To phone_book.Length - 1
                            Console.WriteLine("enter the new contact information:")
                            input_add = Console.ReadLine()
                            phone_book(index) = input_add



                            Console.WriteLine("do you want to enter the new contact?: if yes type 1 if not type 0")
                            ex = Console.ReadLine()

                            If ex = 0 Then
                                Exit For ' terminate the For loop   
                            End If

                        Next

                        For i As Integer = 0 To phone_book.Length - 1

                            Console.WriteLine("item{0} = {1}", i, phone_book(i))

                        Next



                        Console.WriteLine("do you want to add new contact? if yes type 1 if no type 0")
                        ex_1 = Console.ReadLine()

                    Loop While ex_1 = 1





                Case "display"
                    Console.WriteLine("*********contact list********")
                    For i As Integer = 0 To phone_book.Length - 1

                        Console.WriteLine("item{0} = {1}", i, phone_book(i))

                    Next
                    Console.WriteLine()
                    Console.ReadLine()





                Case "delete"


                    Do
                        Dim aList As ArrayList = New ArrayList(phone_book)


                        Dim num_delete As Integer
                        For i As Integer = 0 To phone_book.Length - 1

                            Console.WriteLine("item{0} = {1}", i, phone_book(i))

                        Next
                        Console.WriteLine("which contact you want to remove? choose the number")
                        num_delete = Console.ReadLine()
                        aList.RemoveAt(num_delete)



                        Dim obj_array() As Object
                        obj_array = aList.ToArray()

                        ' Array of strings.
                        Dim string_array() As String
                        phone_book = DirectCast(aList.ToArray(GetType(String)), String())


                        Console.WriteLine("do you want to delete a contact? if yes type 1 if no type 0")
                        ex_4 = Console.ReadLine()



                    Loop While ex_4 = 1





































                Case "exit"

                    Console.WriteLine("do you want to exit? if yes type 1 if no type 0")
                    opt = Console.ReadLine()

            End Select



        Loop While opt = 1




    End Sub
End Module
