Public Class Puesto
    Private id As Integer
    Private idred As Integer
    Private localizacion As String
    Private nombrePc As String
    Private usuario As String
    Private ip As String
    Private sistemaOperativo As String
    Private contrasena As String
    'constructor por defecto
    Public Sub New()

    End Sub
    'constructor ampliado

    Public Sub New(id As Integer, idred As Integer, localizacion As String, nombrePc As String, usuario As String, ip As String, sistemaOperativo As String, contrasena As String)
        Me.id = id
        Me.idred = idred
        Me.localizacion = localizacion
        Me.nombrePc = nombrePc
        Me.usuario = usuario
        Me.ip = ip
        Me.sistemaOperativo = sistemaOperativo
        Me.contrasena = contrasena
    End Sub
    'constructor ampliado

    Public Sub New(idred As Integer, localizacion As String, nombrePc As String, usuario As String, ip As String, sistemaOperativo As String, contrasena As String)
        Me.idred = idred
        Me.localizacion = localizacion
        Me.nombrePc = nombrePc
        Me.usuario = usuario
        Me.ip = ip
        Me.sistemaOperativo = sistemaOperativo
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

    Public Property Idred1 As Integer
        Get
            Return idred
        End Get
        Set(value As Integer)
            idred = value
        End Set
    End Property

    Public Property Localizacion1 As String
        Get
            Return localizacion
        End Get
        Set(value As String)
            localizacion = value
        End Set
    End Property

    Public Property NombrePc1 As String
        Get
            Return nombrePc
        End Get
        Set(value As String)
            nombrePc = value
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

    Public Property Ip1 As String
        Get
            Return ip
        End Get
        Set(value As String)
            ip = value
        End Set
    End Property

    Public Property SistemaOperativo1 As String
        Get
            Return sistemaOperativo
        End Get
        Set(value As String)
            sistemaOperativo = value
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
