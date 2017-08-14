Imports Entidades

Module testjaula

    Sub main()
        Dim lajaula As New Jaula
        Dim lorito As New Loro(Nothing, "", "")
        Dim cotorrita1 As New Cotorra
        Dim cotorrita2 As New Cotorra
        Dim cotorrita3 As New Cotorra
        Dim cotorrita4 As New Cotorra

        lajaula.Nombre = "pricion"

        lorito.FechaNacimiento = #01/01/2000#
        lorito.Nombre = "juan"
        lorito.escuchar("papita ")
        lorito.escuchar("pal loro ")
        lorito.escuchar("juan")

        cotorrita1.FechaNacimiento = #01/01/2000#
        cotorrita1.Nombre = "pepo"
        cotorrita1.escuchar("papita ")
        cotorrita1.escuchar("pal cotorra ")
        cotorrita1.escuchar("pepo")

        cotorrita2.FechaNacimiento = #01/01/2000#
        cotorrita2.Nombre = "pato"
        cotorrita2.escuchar("papita ")
        cotorrita3.escuchar("pal cotorra ")
        cotorrita4.escuchar("pato")

        cotorrita3.FechaNacimiento = #01/01/2000#
        cotorrita3.Nombre = "pepito"
        cotorrita3.escuchar("papita ")
        cotorrita3.escuchar("pal cotorra ")
        cotorrita3.escuchar("pepito")

        cotorrita4.FechaNacimiento = #01/01/2000#
        cotorrita4.Nombre = "maria"
        cotorrita4.escuchar("papita ")
        cotorrita4.escuchar("pal cotorra ")
        cotorrita4.escuchar("maria")


        Console.ReadKey()
    End Sub

End Module
