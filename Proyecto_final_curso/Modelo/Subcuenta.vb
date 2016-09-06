Public Class Subcuenta
    Private id As Integer
    Private idcorreo As String
    Private direccion As String
    Private usuario As String
    Private contrasena As String
    Private ubicacion As String
    Public Sub New()

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

    Public Property Idcorreo1 As String
        Get
            Return idcorreo
        End Get
        Set(value As String)
            idcorreo = value
        End Set
    End Property

    Public Property Direccion1 As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property Usuario1 As String
        Get
            Return usuario
        End Get
        Set(value As String)
            usuario = value
        End Set
    End Property

    Public Property Contrasena1 As String
        Get
            Return contrasena
        End Get
        Set(value As String)
            contrasena = value
        End Set
    End Property

    Public Property Ubicacion1 As String
        Get
            Return ubicacion
        End Get
        Set(value As String)
            ubicacion = value
        End Set
    End Property
End Class
