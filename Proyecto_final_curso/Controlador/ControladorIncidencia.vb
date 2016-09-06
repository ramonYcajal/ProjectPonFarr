Imports MySql.Data.MySqlClient
' este controlador lo que hace es cargar los combos del cuaderno de bitácora, mostrando los datos
Public Class ControladorIncidencia
    'constructor
    Public Sub New()

    End Sub
    Public Function mostrarIncidencias() As ArrayList
        Dim conexion As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim controlador As New ConexionBaseDeDatos
        Dim lector As MySqlDataReader
        Dim listaIncidencias As New ArrayList
        Try
            conexion = controlador.conectar
            comando.Connection = conexion
            comando.CommandText = "mostrarIncidencias"
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()
            lector = comando.ExecuteReader
            listaIncidencias = cargarArray(lector)
            controlador.desconectar(conexion)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaIncidencias
    End Function
    ' función que carga el arrayList recibiendo un data reader
    ' es privada porque sólo la clase necesita acceder a esta función.
    Private Function cargarArray(lector As MySqlDataReader) As ArrayList
        Dim listaIncidencias As New ArrayList
        Dim incidencia As Incidencia
        Do While lector.Read
            incidencia = New Incidencia
            incidencia.Id1 = lector.GetInt32(0)
            incidencia.EstadoIncidencia1 = lector.GetString(1)
            listaIncidencias.Add(incidencia)
        Loop
        Return listaIncidencias
    End Function

End Class
