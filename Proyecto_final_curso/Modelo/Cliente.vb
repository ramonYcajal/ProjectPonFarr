Public Class Cliente
    Private id As Integer
    Private nombre As String
    Private nif As String
    Private personaContacto As String
    Private email As String
    Private observaciones As String
    Private domicilio As String
    Private poblacion As String
    Private provincia As String
    Private arrayTelefonos As New ArrayList
    Private codpos As String

    'constructor por defecto
    Public Sub New()

    End Sub
    'constructor ampliado
    Public Sub New(id As Integer, nombre As String, nif As String, personaContacto As String, email As String, observaciones As String, domicilio As String, poblacion As String, provincia As String, codpos As String, arrayTelefonos As ArrayList)
        Me.id = id
        Me.nombre = nombre
        Me.nif = nif
        Me.personaContacto = personaContacto
        Me.email = email
        Me.observaciones = observaciones
        Me.domicilio = domicilio
        Me.poblacion = poblacion
        Me.provincia = provincia
        Me.codpos = codpos
        Me.arrayTelefonos = arrayTelefonos
    End Sub
    'constructor ampliado
    Public Sub New(nombre As String, nif As String, personaContacto As String, email As String, observaciones As String, domicilio As String, poblacion As String, provincia As String, codpos As String, arrayTelefonos As ArrayList)

        Me.nombre = nombre
        Me.nif = nif
        Me.personaContacto = personaContacto
        Me.email = email
        Me.observaciones = observaciones
        Me.domicilio = domicilio
        Me.poblacion = poblacion
        Me.provincia = provincia
        Me.codpos = codpos
        Me.arrayTelefonos = arrayTelefonos
    End Sub
    ' getters y setters
    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Nif1 As String
        Get
            Return nif
        End Get
        Set(value As String)
            nif = value
        End Set
    End Property

    Public Property PersonaContacto1 As String
        Get
            Return personaContacto
        End Get
        Set(value As String)
            personaContacto = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
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

    Public Property Domicilio1 As String
        Get
            Return domicilio
        End Get
        Set(value As String)
            domicilio = value
        End Set
    End Property

    Public Property Poblacion1 As String
        Get
            Return poblacion
        End Get
        Set(value As String)
            poblacion = value
        End Set
    End Property

    Public Property Provincia1 As String
        Get
            Return provincia
        End Get
        Set(value As String)
            provincia = value
        End Set
    End Property


    Public Property Codpos1 As String
        Get
            Return codpos
        End Get
        Set(value As String)
            codpos = value
        End Set
    End Property

    Public Property ArrayTelefonos1 As ArrayList
        Get
            Return arrayTelefonos
        End Get
        Set(value As ArrayList)
            arrayTelefonos = value
        End Set
    End Property
End Class
