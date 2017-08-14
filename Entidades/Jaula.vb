Public Class Jaula

    Private _nombre As String
    Private _loro As Loro
    Private _cotorra As List(Of Cotorra)

    Public Sub New()
        _nombre = ""
        _loro = New Loro(Nothing, "", "")
        _cotorra = New List(Of Cotorra)
    End Sub


    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "esta es la jaula: " & Me.Nombre
    End Function

    Public Sub AddAllCotorra(agrega)

        If _cotorra.Count <= 3 Then

            _cotorra.Add(agrega)

        End If

    End Sub

    Public Function getAllcotorras() As List(Of Cotorra)
        Return _cotorra
    End Function

End Class
