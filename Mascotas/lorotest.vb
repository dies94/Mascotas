Imports Entidades

Module lorotest

    Sub Main()

        Dim guarda As String
        Dim lorito As New Loro(Nothing, "01/01/2000", "jose")


        Console.WriteLine("Edad: " & lorito.Edad)

        Console.WriteLine("nombre: " & lorito.ToString())

        lorito.escuchar("papita ")
        lorito.escuchar("pa el loro")
        lorito.escuchar("juan ")

        guarda = lorito.hablar()
        Console.WriteLine(guarda)
        guarda = guarda & " " & lorito.hablar()
        Console.WriteLine(guarda)
        guarda = guarda & " " & lorito.hablar()
        Console.WriteLine(guarda)

        Console.ReadKey()
    End Sub

End Module
