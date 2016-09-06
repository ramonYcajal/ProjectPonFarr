Public Class Red
    Private id As Integer
    Private cliente As String
    Private nombreServidor As String
    Private servidorIp As String
    Private grupo As String
    Private router As String
    Private dns1 As String
    Private dns2 As String
    Private dns3 As String
    Private mascara As String
    'constructor por defecto
    Public Sub New()

    End Sub

    'constructor ampliado
    Public Sub New(id As Integer, cliente As String, nombreServidor As String, servidorIp As String, grupo As String, router As String, dns1 As String, dns2 As String, dns3 As String, mascara As String)
        Me.id = id
        Me.cliente = cliente
        Me.nombreServidor = nombreServidor
        Me.servidorIp = servidorIp
        Me.grupo = grupo
        Me.router = router
        Me.dns1 = dns1
        Me.dns2 = dns2
        Me.dns3 = dns3
        Me.mascara = mascara
    End Sub

    'constructor ampliado

    Public Sub New(cliente As String, nombreServidor As String, servidorIp As String, grupo As String, router As String, dns1 As String, dns2 As String, dns3 As String, mascara As String)
        Me.cliente = cliente
        Me.nombreServidor = nombreServidor
        Me.servidorIp = servidorIp
        Me.grupo = grupo
        Me.router = router
        Me.dns1 = dns1
        Me.dns2 = dns2
        Me.dns3 = dns3
        Me.mascara = mascara
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

    Public Property Dns31 As String
        Get
            Return dns3
        End Get
        Set(value As String)
            dns3 = value
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
End Class
