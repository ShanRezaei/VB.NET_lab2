Imports System

Module Program
    Sub Main(args As String())

        Dim ex As Integer 
        Dim menu As New ArrayList 
        
        menu.add("item0: kebab    9.99  5")
        menu.add("item1: beef    6.99   7")
        menu.add("item2: chiken    4.65  9")
        menu.add("item3: beer    0.99   10")
 
         Example(menu)



 Do 
        Dim answer As string
        console.writeline("do you want to add new item: if yes type yes and if no type no")
        answer=console.readline()




        If answer = "yes" Then 
             Dim input As String 
             console.writeline("enter the new item:")
             input=console.readline()
             menu.add(input)
             Example(menu)

        ElseIf answer="no"

        Console.WriteLine("thank you")
         console.readkey()

        End If 



        Console.WriteLine("IF YOU SELECT 0 YOU CAN EXIT BUT IF 1 you can ADD to the menu" )
        EX = Console.ReadLine()

 Loop While EX =1


        Dim menu_array() As Object = menu.ToArray()

        For i As Integer = 0 To 4

            Console.WriteLine("item{0} = {1}", i, menu_array(i))
            
        Next
        
    End Sub

    Private Sub Example(ByVal menu As ArrayList)
        For Each num As string In menu
            Console.WriteLine(num)
            console.readline()
        Next

    End Sub

    





End Module
