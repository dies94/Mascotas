Public Class Loro
    'atributos
    Private _memoria As Queue(Of String)
    Private _edad As Short
    Private _fechaNacimiento As Date
    Private _nombre As String

    'constructor

    Public Sub New(memoria As Queue(Of String), fechanacimiento As Date, nombre As String)
        Me._memoria = New Queue(Of String)
        Me.FechaNacimiento = fechanacimiento
        Me.Nombre = nombre
    End Sub

    'propiedades

    Public ReadOnly Property Edad As Short
        Get
            Return _edad
        End Get
    End Property


    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
            CalculaEdad(value)
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Function CalculaEdad(fechanacimiento As Date) As UShort

        Return Me.Edad = DateDiff(DateInterval.Year, fechanacimiento, Date.Today)

    End Function


    Public Sub escuchar(frase As String)
        _memoria.Enqueue(frase)
    End Sub

    Public Function hablar() As String

        Return _memoria.Dequeue

    End Function

End Class
