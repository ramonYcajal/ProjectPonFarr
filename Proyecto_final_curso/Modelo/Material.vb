Public Class Material
    Private id As Integer
    Private material As String
    Private precio As Double
    Private pvp As Double
    'constructor por defecto
    Public Sub New()

    End Sub
    'constructor ampliado
    Public Sub New(id As Integer, material As String, precio As Double)
        Me.id = id
        Me.material = material
        Me.precio = precio
    End Sub
    'constructor ampliado
    Public Sub New(material As String, precio As Double)
        Me.material = material
        Me.precio = precio
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

    Public Property Material1 As String
        Get
            Return material
        End Get
        Set(value As String)
            material = value
        End Set
    End Property

    Public Property Precio1 As Double
        Get
            Return precio
        End Get
        Set(value As Double)
            precio = value
        End Set
    End Property
    Public Property pvp1 As Double
        Get
            Return pvp
        End Get
        Set(value As Double)
            pvp = value
        End Set
    End Property
End Class
