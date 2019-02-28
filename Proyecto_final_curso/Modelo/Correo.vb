Public Class Correo
    Private id As Integer
    Private proveedor As String
    Private idusuario As String
    Private nombre As String
    Private direccionCorreo As String
    Private usuarioConexion As String
    Private nombreCUentaConexions As String
    Private contrasena As String
    Private servidorCorreoEntrante As String
    Private servidorCorreoSaliente As String
    Private observaciones As String
    Private subdominio As String
    Private usuarioGestion As String
    Private contrasenaGestion As String
    Private webGestion As String
    Private subcuentas As New ArrayList
    'constructor por defecto
    Public Sub New()

    End Sub
    'constructor ampliado
    Public Sub New(id As Integer, proveedor As String, nombre As String, direccionCorreo As String, usuarioConexion As String, nombreCUentaConexions As String, contrasena As String, servidorCorreoEntrante As String, servidorCorreoSaliente As String, observaciones As String, subdominio As String, usuarioGestion As String, contrasenaGestion As String, webGestion As String)
        Me.id = id
        Me.proveedor = proveedor
        ' Me.idusuario = idusuario
        Me.nombre = nombre
        Me.direccionCorreo = direccionCorreo
        Me.usuarioConexion = usuarioConexion
        Me.nombreCUentaConexions = nombreCUentaConexions
        Me.contrasena = contrasena
        Me.servidorCorreoEntrante = servidorCorreoEntrante
        Me.servidorCorreoSaliente = servidorCorreoSaliente
        Me.observaciones = observaciones
        Me.subdominio = subdominio
        Me.usuarioGestion = usuarioGestion
        Me.contrasenaGestion = contrasenaGestion
        Me.webGestion = webGestion
    End Sub
    'constructor ampliado
    Public Sub New(proveedor As String, nombre As String, direccionCorreo As String, usuarioConexion As String, nombreCUentaConexions As String, contrasena As String, servidorCorreoEntrante As String, servidorCorreoSaliente As String, observaciones As String, subdominio As String, usuarioGestion As String, contrasenaGestion As String, webGestion As String)
        Me.proveedor = proveedor
        ' Me.idusuario = idusuario
        Me.nombre = nombre
        Me.direccionCorreo = direccionCorreo
        Me.usuarioConexion = usuarioConexion
        Me.nombreCUentaConexions = nombreCUentaConexions
        Me.contrasena = contrasena
        Me.servidorCorreoEntrante = servidorCorreoEntrante
        Me.servidorCorreoSaliente = servidorCorreoSaliente
        Me.observaciones = observaciones
        Me.subdominio = subdominio
        Me.usuarioGestion = usuarioGestion
        Me.contrasenaGestion = contrasenaGestion
        Me.webGestion = webGestion
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

    Public Property Proveedor1 As String
        Get
            Return proveedor
        End Get
        Set(value As String)
            proveedor = value
        End Set
    End Property

    'Public Property Idusuario1 As String
    '    Get
    '        Return idusuario
    '    End Get
    '    Set(value As String)
    '        idusuario = value
    '    End Set
    'End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property DireccionCorreo1 As String
        Get
            Return direccionCorreo
        End Get
        Set(value As String)
            direccionCorreo = value
        End Set
    End Property

    Public Property UsuarioConexion1 As String
        Get
            Return usuarioConexion
        End Get
        Set(value As String)
            usuarioConexion = value
        End Set
    End Property

    Public Property NombreCUentaConexions1 As String
        Get
            Return nombreCUentaConexions
        End Get
        Set(value As String)
            nombreCUentaConexions = value
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

    Public Property ServidorCorreoEntrante1 As String
        Get
            Return servidorCorreoEntrante
        End Get
        Set(value As String)
            servidorCorreoEntrante = value
        End Set
    End Property

    Public Property ServidorCorreoSaliente1 As String
        Get
            Return servidorCorreoSaliente
        End Get
        Set(value As String)
            servidorCorreoSaliente = value
        End Set
    End Property

    Public Property Observaciones1 As String
        Get
            Return observaciones
        End Get
        Set(value As String)
            observaciones = value
        End Set
    End Property

    Public Property Subdominio1 As String
        Get
            Return subdominio
        End Get
        Set(value As String)
            subdominio = value
        End Set
    End Property

    Public Property UsuarioGestion1 As String
        Get
            Return usuarioGestion
        End Get
        Set(value As String)
            usuarioGestion = value
        End Set
    End Property

    Public Property ContrasenaGestion1 As String
        Get
            Return contrasenaGestion
        End Get
        Set(value As String)
            contrasenaGestion = value
        End Set
    End Property

    Public Property WebGestion1 As String
        Get
            Return webGestion
        End Get
        Set(value As String)
            webGestion = value
        End Set
    End Property

    Public Property Idusuario1 As String
        Get
            Return idusuario
        End Get
        Set(value As String)
            idusuario = value
        End Set
    End Property

    Public Property Subcuentas1 As ArrayList
        Get
            Return subcuentas
        End Get
        Set(value As ArrayList)
            subcuentas = value
        End Set
    End Property
End Class
