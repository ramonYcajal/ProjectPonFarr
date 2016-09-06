Public Class ParteTrabajo
    Private id As Integer
    Private fechaEntrada As String
    Private fechaSalida As String
    Private tecnico As String
    Private cliente As String
    Private telefono As String
    Private problema As String
    Private solucion As String
    Private producto As String
    Private NumeroSerie As String
    Private totalEuros As Double
    'constructor por defecto
    Public Sub New()

    End Sub
    'constructor ampliado
    Public Sub New(id As Integer, fechaEntrada As String, fechaSalida As String, tecnico As String, cliente As String, telefono As String, problema As String, solucion As String, producto As String, numeroSerie As String)
        Me.id = id
        Me.fechaEntrada = fechaEntrada
        Me.fechaSalida = fechaSalida
        Me.tecnico = tecnico
        Me.cliente = cliente
        Me.telefono = telefono
        Me.problema = problema
        Me.solucion = solucion
        Me.producto = producto
        Me.NumeroSerie = numeroSerie
    End Sub
    'constructor ampliado
    Public Sub New(fechaEntrada As String, fechaSalida As String, tecnico As String, cliente As String, telefono As String, problema As String, solucion As String, producto As String, numeroSerie As String)

        Me.fechaEntrada = fechaEntrada
        Me.fechaSalida = fechaSalida
        Me.tecnico = tecnico
        Me.cliente = cliente
        Me.telefono = telefono
        Me.problema = problema
        Me.solucion = solucion
        Me.producto = producto
        Me.NumeroSerie = numeroSerie
    End Sub
    'constructor ampliado
    Public Sub New(ByVal id As Int32, fechaEntrada As String, cliente As String, telefono As String, problema As String, producto As String, numeroSerie As String)
        Me.id = id
        Me.fechaEntrada = fechaEntrada
        Me.cliente = cliente
        Me.telefono = telefono
        Me.problema = problema
        Me.producto = producto
        Me.NumeroSerie = numeroSerie
    End Sub
    Public Sub New(ByVal id As Int32)
        Me.id = id
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

    Public Property FechaEntrada1 As String
        Get
            Return fechaEntrada
        End Get
        Set(value As String)
            fechaEntrada = value
        End Set
    End Property

    Public Property FechaSalida1 As String
        Get
            Return fechaSalida
        End Get
        Set(value As String)
            fechaSalida = value
        End Set
    End Property

    Public Property Tecnico1 As String
        Get
            Return tecnico
        End Get
        Set(value As String)
            tecnico = value
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

    Public Property Telefono1 As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property Problema1 As String
        Get
            Return problema
        End Get
        Set(value As String)
            problema = value
        End Set
    End Property

    Public Property Solucion1 As String
        Get
            Return solucion
        End Get
        Set(value As String)
            solucion = value
        End Set
    End Property

    Public Property Producto1 As String
        Get
            Return producto
        End Get
        Set(value As String)
            producto = value
        End Set
    End Property

    Public Property NumeroSerie1 As String
        Get
            Return NumeroSerie
        End Get
        Set(value As String)
            NumeroSerie = value
        End Set
    End Property
    Public Property totalEuros1 As Double
        Get
            Return totalEuros
        End Get
        Set(value As Double)
            totalEuros = value
        End Set
    End Property
End Class
