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
    Private material As String
    Private totalEuros As Double
    'constructor por defecto
    Public Sub New()

    End Sub
    'constructor ampliado
    Public Sub New(id As Integer, fechaEntrada As String, fechaSalida As String, tecnico As String, cliente As String, telefono As String, problema As String, solucion As String, producto As String, numeroSerie As String, totalEuros As Double, material As String)
        Me.Id2 = id
        Me.FechaEntrada2 = fechaEntrada
        Me.FechaSalida2 = fechaSalida
        Me.Tecnico2 = tecnico
        Me.Cliente2 = cliente
        Me.Telefono2 = telefono
        Me.Problema2 = problema
        Me.Solucion2 = solucion
        Me.Producto2 = producto
        Me.NumeroSerie2 = numeroSerie
        Me.TotalEuros2 = totalEuros
        Me.Material1 = material
    End Sub
    'constructor ampliado
    Public Sub New(fechaEntrada As String, fechaSalida As String, tecnico As String, cliente As String, telefono As String, problema As String, solucion As String, producto As String, numeroSerie As String)

        Me.FechaEntrada2 = fechaEntrada
        Me.FechaSalida2 = fechaSalida
        Me.Tecnico2 = tecnico
        Me.Cliente2 = cliente
        Me.Telefono2 = telefono
        Me.Problema2 = problema
        Me.Solucion2 = solucion
        Me.Producto2 = producto
        Me.NumeroSerie2 = numeroSerie
    End Sub
    'constructor ampliado
    Public Sub New(ByVal id As Int32, fechaEntrada As String, cliente As String, telefono As String, problema As String, producto As String, numeroSerie As String)
        Me.Id2 = id
        Me.FechaEntrada2 = fechaEntrada
        Me.Cliente2 = cliente
        Me.Telefono2 = telefono
        Me.Problema2 = problema
        Me.Producto2 = producto
        Me.NumeroSerie2 = numeroSerie
    End Sub
    Public Sub New(ByVal id As Int32)
        Me.Id2 = id
    End Sub
    'getters y setters
    Public Property Id1 As Integer
        Get
            Return Id2
        End Get
        Set(value As Integer)
            Id2 = value
        End Set
    End Property

    Public Property FechaEntrada1 As String
        Get
            Return FechaEntrada2
        End Get
        Set(value As String)
            FechaEntrada2 = value
        End Set
    End Property

    Public Property FechaSalida1 As String
        Get
            Return FechaSalida2
        End Get
        Set(value As String)
            FechaSalida2 = value
        End Set
    End Property

    Public Property Tecnico1 As String
        Get
            Return Tecnico2
        End Get
        Set(value As String)
            Tecnico2 = value
        End Set
    End Property

    Public Property Cliente1 As String
        Get
            Return Cliente2
        End Get
        Set(value As String)
            Cliente2 = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return Telefono2
        End Get
        Set(value As String)
            Telefono2 = value
        End Set
    End Property

    Public Property Problema1 As String
        Get
            Return Problema2
        End Get
        Set(value As String)
            Problema2 = value
        End Set
    End Property

    Public Property Solucion1 As String
        Get
            Return Solucion2
        End Get
        Set(value As String)
            Solucion2 = value
        End Set
    End Property

    Public Property Producto1 As String
        Get
            Return Producto2
        End Get
        Set(value As String)
            Producto2 = value
        End Set
    End Property

    Public Property NumeroSerie1 As String
        Get
            Return NumeroSerie2
        End Get
        Set(value As String)
            NumeroSerie2 = value
        End Set
    End Property
    Public Property totalEuros1 As Double
        Get
            Return TotalEuros2
        End Get
        Set(value As Double)
            TotalEuros2 = value
        End Set
    End Property

    Public Property Id2 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property FechaEntrada2 As String
        Get
            Return fechaEntrada
        End Get
        Set(value As String)
            fechaEntrada = value
        End Set
    End Property

    Public Property FechaSalida2 As String
        Get
            Return fechaSalida
        End Get
        Set(value As String)
            fechaSalida = value
        End Set
    End Property

    Public Property Tecnico2 As String
        Get
            Return tecnico
        End Get
        Set(value As String)
            tecnico = value
        End Set
    End Property

    Public Property Cliente2 As String
        Get
            Return cliente
        End Get
        Set(value As String)
            cliente = value
        End Set
    End Property

    Public Property Telefono2 As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property Problema2 As String
        Get
            Return problema
        End Get
        Set(value As String)
            problema = value
        End Set
    End Property

    Public Property Solucion2 As String
        Get
            Return solucion
        End Get
        Set(value As String)
            solucion = value
        End Set
    End Property

    Public Property Producto2 As String
        Get
            Return producto
        End Get
        Set(value As String)
            producto = value
        End Set
    End Property

    Public Property NumeroSerie2 As String
        Get
            Return NumeroSerie
        End Get
        Set(value As String)
            NumeroSerie = value
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

    Public Property TotalEuros2 As Double
        Get
            Return totalEuros
        End Get
        Set(value As Double)
            totalEuros = value
        End Set
    End Property
End Class
