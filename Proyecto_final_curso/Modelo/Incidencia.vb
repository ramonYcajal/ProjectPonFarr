Public Class Incidencia
    Private id As Integer
    Private estadoIncidencia As String

    Public Sub New()

    End Sub

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property EstadoIncidencia1 As String
        Get
            Return estadoIncidencia
        End Get
        Set(value As String)
            estadoIncidencia = value
        End Set
    End Property

End Class
