Public Class Red
    Private id As Integer
    Private cliente As String
    Private nombreServidor As String
    Private servidorIp As String
    Private grupo As String
    Private router As String
    Private dns1 As String
    Private dns2 As String
    Private mascara As String
    Private usuarioRouter As String
    Private contrasenaRouter As String
    Private arrayPuestos As New ArrayList
    'constructor por defecto
    Public Sub New()

    End Sub

    'constructor ampliado
    Public Sub New(id As Integer, cliente As String, nombreServidor As String, servidorIp As String, grupo As String, router As String, dns1 As String, dns2 As String, mascara As String,
                   usuarioRouter As String, contrasenaRouter As String, arrayPuestos As ArrayList)
        Me.id = id
        Me.cliente = cliente
        Me.nombreServidor = nombreServidor
        Me.servidorIp = servidorIp
        Me.grupo = grupo
        Me.router = router
        Me.dns1 = dns1
        Me.dns2 = dns2
        Me.mascara = mascara
        Me.UsuarioRouter1 = usuarioRouter
        Me.ContrasenaRouter1 = contrasenaRouter
        Me.ArrayPuestos1 = arrayPuestos
    End Sub

    'constructor ampliado

    Public Sub New(cliente As String, nombreServidor As String, servidorIp As String, grupo As String, router As String, dns1 As String, dns2 As String, mascara As String,
                   usuarioRouter As String, contrasenaRouter As String, arrayPuestos As ArrayList)
        Me.cliente = cliente
        Me.nombreServidor = nombreServidor
        Me.servidorIp = servidorIp
        Me.grupo = grupo
        Me.router = router
        Me.dns1 = dns1
        Me.dns2 = dns2
        Me.mascara = mascara
        Me.UsuarioRouter1 = usuarioRouter
        Me.ContrasenaRouter1 = contrasenaRouter
        Me.ArrayPuestos1 = arrayPuestos
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

    Public Property Cliente1 As String
        Get
            Return cliente
        End Get
        Set(value As String)
            cliente = value
        End Set
    End Property

    Public Property NombreServidor1 As String
        Get
            Return nombreServidor
        End Get
        Set(value As String)
            nombreServidor = value
        End Set
    End Property

    Public Property ServidorIp1 As String
        Get
            Return servidorIp
        End Get
        Set(value As String)
            servidorIp = value
        End Set
    End Property

    Public Property Grupo1 As String
        Get
            Return grupo
        End Get
        Set(value As String)
            grupo = value
        End Set
    End Property

    Public Property Router1 As String
        Get
            Return router
        End Get
        Set(value As String)
            router = value
        End Set
    End Property

    Public Property Dns11 As String
        Get
            Return dns1
        End Get
        Set(value As String)
            dns1 = value
        End Set
    End Property

    Public Property Dns21 As String
        Get
            Return dns2
        End Get
        Set(value As String)
            dns2 = value
        End Set
    End Property

    Public Property Mascara1 As String
        Get
            Return mascara
        End Get
        Set(value As String)
            mascara = value
        End Set
    End Property

    Public Property ArrayPuestos1 As ArrayList
        Get
            Return arrayPuestos
        End Get
        Set(value As ArrayList)
            arrayPuestos = value
        End Set
    End Property

    Public Property UsuarioRouter1 As String
        Get
            Return usuarioRouter
        End Get
        Set(value As String)
            usuarioRouter = value
        End Set
    End Property

    Public Property ContrasenaRouter1 As String
        Get
            Return contrasenaRouter
        End Get
        Set(value As String)
            contrasenaRouter = value
        End Set
    End Property
End Class
