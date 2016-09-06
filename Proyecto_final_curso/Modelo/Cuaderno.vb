Public Class Cuaderno
    Private id As Integer
    Private fecha As String
    Private datos As String
    Private persona As String
    Private resuelto As String
    Private cliente As String

    'constructor por defecto
    Public Sub New()

    End Sub
    'constructor ampliado
    Public Sub New(id As Integer, fecha As String, datos As String, persona As String, resuelto As String, cliente As String)
        Me.Id1 = id
        Me.Fecha1 = fecha
        Me.Datos1 = datos
        Me.Persona1 = persona
        Me.Resuelto1 = resuelto
        Me.Cliente1 = cliente
    End Sub
    'constructor ampliado
    Public Sub New(fecha As String, datos As String, persona As String, resuelto As String, cliente As String)

        Me.Fecha1 = fecha
        Me.Datos1 = datos
        Me.Persona1 = persona
        Me.Resuelto1 = resuelto
        Me.Cliente1 = cliente
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

    Public Property Fecha1 As String
        Get
            Return fecha
        End Get
        Set(value As String)
            fecha = value
        End Set
    End Property

    Public Property Datos1 As String
        Get
            Return datos
        End Get
        Set(value As String)
            datos = value
        End Set
    End Property

    Public Property Persona1 As String
        Get
            Return persona
        End Get
        Set(value As String)
            persona = value
        End Set
    End Property

    Public Property Resuelto1 As String
        Get
            Return resuelto
        End Get
        Set(value As String)
            resuelto = value
        End Set
    End Property

    Public Property Cliente1 As String
        Get
            Return cliente
        End Get
        Set(value As String)
            cliente = value
        End Set
    End Property
End Class
