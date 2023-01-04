Imports System
Imports System.Data

Module Program
    Sub Main(args As String())
        Dim opt As Integer = 1
        Dim ex_1 As Integer
        Dim ex_2 As Integer
        Dim ex_3 As Integer
        Dim input As String
        Dim input_add As String
        Dim in_update As String
        Dim new_input As String
        Dim input_delete As Integer
        Dim input_update As Integer
        Dim menu As ArrayList = New ArrayList()
        menu.Add("0) mary lavine, 5143789843")
        menu.Add("1) sarah mrcdi, 5143786543")
        menu.Add("2) shan lavine, 5143789843")
        menu.Add("3) mehr shokri, 5143789843")


        Console.WriteLine("**************welcome to phone book********************")



        Do



            Console.WriteLine("if you want to add new contact type add")
            Console.WriteLine("if you want to delete a contact type delete")
            Console.WriteLine("if  you want to update a contact type update ")
            Console.WriteLine("if you want to display contacts type display ")
            Console.WriteLine("if you want to exit type exit")
            input = Console.ReadLine()


            Select Case input

                Case "add"


                    Do
                        Console.WriteLine("enter the first_name  last_name,phone_number")
                        input_add = Console.ReadLine()
                        menu.Add(input_add)
                        Console.WriteLine("how many contact number you have?: {0}", menu.Count)

                        For Each i As String In menu
                            Console.WriteLine("{0} ", i)
                        Next i
                        Console.WriteLine()
                        Console.ReadKey()


                        Console.WriteLine("do you want to add new contact? if yes type 1 if no type 0")
                        ex_1 = Console.ReadLine()

                    Loop While ex_1 = 1


                Case "delete"

                    Do
                        Console.WriteLine("which contact do you want to remove: type its number")
                        input_delete = Console.ReadLine()
                        Console.WriteLine(menu(input_delete))
                        menu.RemoveAt(input_delete)
                        Console.WriteLine("how many contact number you have?: {0}", menu.Count)

                        For Each i As String In menu
                            Console.WriteLine("{0} ", i)
                        Next i
                        Console.WriteLine()
                        Console.ReadKey()


                        Console.WriteLine("do you want to delete another contact? if yes type 1 if no type 0")
                        ex_2 = Console.ReadLine()

                    Loop While ex_2 = 1


                Case "update"

                    Do

                        Console.WriteLine("how many contact number you have?: {0}", menu.Count)

                        For Each i As String In menu
                            Console.WriteLine("{0} ", i)
                        Next i
                        Console.WriteLine()
                        Console.ReadKey()




                        'Dim array() As Object = menu.ToArray()


                        Console.WriteLine("which contact do you want to update: type its number")
                        input_update = Console.ReadLine()


                        Console.WriteLine("enter   the new first name and last name and number")
                        new_input = Console.ReadLine()

                        menu.Insert(input_update, new_input)
                        menu.RemoveAt(input_update + 1)



                        For Each i As String In menu
                            Console.WriteLine("{0} ", i)
                        Next i
                        Console.WriteLine()
                        Console.ReadKey()


                        Console.WriteLine("do you want to update another contact? if yes type 1 if no type 0")
                        ex_3 = Console.ReadLine()

                    Loop While ex_3 = 1





                Case "display"
                    Console.WriteLine("*********contact list********")

                    For Each i As String In menu
                        Console.WriteLine(i)
                    Next i

                    Console.ReadLine()



                Case "exit"

                    Console.WriteLine("do you want to exit? if yes type 1 if no type 0")
                    opt = Console.ReadLine()

            End Select



        Loop While opt = 1


    End Sub
End Module
