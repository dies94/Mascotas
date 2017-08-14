Public Class Cotorra
    Inherits Loro

    Public Sub New()
        MyBase.New(Nothing, "01/01/2000", "jose")
    End Sub

    Public ReadOnly Property Edadhumana
        Get
            Return Edad * 2
        End Get

    End Property

    Public Sub Escucharcotorra(frase As String, valor As Byte)
        If valor = 1 Then
            MyBase.escuchar(frase)
        End If
    End Sub


End Class

