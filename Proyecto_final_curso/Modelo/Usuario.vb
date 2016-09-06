Public Class Usuario
    Private id As Integer
    Private nombre As String
    'constructor por defecto
    Public Sub New()

    End Sub
    'constructor ampliado
    Public Sub New(id As Integer, nombre As String)
        Me.id = id
        Me.nombre = nombre
    End Sub
    'constructor ampliado
    Public Sub New(nombre As String)
        Me.nombre = nombre
    End Sub
    'getters y setters
    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
End Class
