Public Class Administracion
    Private id As Integer
    Private usuario As String
    Private contrasena As String
    'constructor por defecto
    Public Sub New()

    End Sub
    'constructor ampliado
    Public Sub New(id As Integer, usuario As String, contrasena As String)
        Me.id = id
        Me.usuario = usuario
        Me.contrasena = contrasena
    End Sub
    'constructor ampliado
    Public Sub New(usuario As String, contrasena As String)
        Me.usuario = usuario
        Me.contrasena = contrasena
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
End Class
