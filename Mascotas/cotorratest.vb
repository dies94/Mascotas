Imports Entidades

Module cotorratest

    Sub main()
        Dim cotorrita As New Cotorra


        cotorrita.Escucharcotorra("river", 1)
        Console.WriteLine(cotorrita.hablar)
        cotorrita.Escucharcotorra("boca", 0)
        cotorrita.Escucharcotorra("EL mas grande", 1)
        Console.WriteLine(cotorrita.hablar)
        cotorrita.Escucharcotorra("nada", 0)
        Console.ReadKey()
    End Sub


End Module
