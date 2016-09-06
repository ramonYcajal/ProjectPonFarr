Imports MySql.Data.MySqlClient
Public Class ControladorCuaderno
    Public Sub New()

    End Sub
    ' función para insertar una nueva incidencia en el cuaderno
    Public Sub insertar(ByVal cuaderno As Cuaderno)
        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "insertarCuaderno"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_fecha", cuaderno.Fecha1)
            comando.Parameters.AddWithValue("_datos", cuaderno.Datos1)
            comando.Parameters.AddWithValue("_persona", cuaderno.Persona1)
            comando.Parameters.AddWithValue("_resuelto", cuaderno.Resuelto1)
            comando.Parameters.AddWithValue("_cliente", cuaderno.Cliente1)
            con.Open()
            comando.ExecuteNonQuery()
            mensaje = "Incidencia agregada"
            frmAdvertencia.Show()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    ' función para actualizar una incidencia en concreto.
    Public Sub actualizarCuaderno(ByVal cuaderno As Cuaderno)
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "actualizarCuaderno"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", cuaderno.Id1)
            comando.Parameters.AddWithValue("_fecha", cuaderno.Fecha1)
            comando.Parameters.AddWithValue("_datos", cuaderno.Datos1)
            comando.Parameters.AddWithValue("_persona", cuaderno.Persona1)
            comando.Parameters.AddWithValue("_resuelto", cuaderno.Resuelto1)
            comando.Parameters.AddWithValue("_cliente", cuaderno.Cliente1)
            con.Open()
            comando.ExecuteNonQuery()
            mensaje = "Incidencia actualizada"
            frmAdvertencia.Show()
            conexion.desconectar(con)
        Catch ex As Exception

        End Try
    End Sub
    Public Function mostrarCuaderno() As ArrayList
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Dim listaCuaderno As New ArrayList
        Dim lector As MySqlDataReader
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarCuaderno"
            comando.CommandType = CommandType.StoredProcedure
            con.Open()
            lector = comando.ExecuteReader
            listaCuaderno = cargarArray(lector)
            conexion.desconectar(con)

        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaCuaderno
    End Function
    ' esta función es privada porque sólo la necesita usar esta clase de forma interna
    'no hace falta tenerla de forma pública para acceder desde fuera.
    Private Function cargarArray(ByVal lector As MySqlDataReader) As ArrayList
        Dim listaCuaderno As New ArrayList
        If lector.HasRows Then
            Do While lector.Read
                Dim cuaderno As New Cuaderno
                cuaderno.Id1 = lector.GetInt32(0)
                cuaderno.Fecha1 = lector.GetString(1)
                cuaderno.Datos1 = lector.GetString(2)
                cuaderno.Persona1 = lector.GetString(3)
                cuaderno.Resuelto1 = lector.GetString(4)
                cuaderno.Cliente1 = lector.GetString(5)
                listaCuaderno.Add(cuaderno)
            Loop
        End If
        Return listaCuaderno
    End Function
    Public Function mostrarIncidencia(ByVal idCuaderno As Int32) As ArrayList
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Dim listaCuaderno As New ArrayList
        Dim lector As MySqlDataReader
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarIncidenciaCuaderno"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", idCuaderno)
            con.Open()
            lector = comando.ExecuteReader
            listaCuaderno = cargarArray(lector)
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaCuaderno
    End Function
    Public Function mostrarUsuariosCuaderno() As ArrayList
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Dim lector As MySqlDataReader

        Dim listaUsuarios As New ArrayList
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarUsuariosCuaderno"
            comando.CommandType = CommandType.StoredProcedure
            con.Open()
            lector = comando.ExecuteReader
            listaUsuarios = cargarArrayUsuarios(lector)
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaUsuarios
    End Function
    Private Function cargarArrayUsuarios(ByVal lector As MySqlDataReader) As ArrayList
        Dim listaUsuarios As New ArrayList
        If lector.HasRows Then
            Do While lector.Read
                listaUsuarios.Add(lector.GetString(0))
            Loop
        End If
        Return listaUsuarios
    End Function
    ' función para filtrar el cuaderno por unos datos dados
    Public Function filtrar(ByVal persona As String, ByVal resuelto As String, ByVal cliente As String) As ArrayList
        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim lector As MySqlDataReader
        Dim listaCuaderno As New ArrayList
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "filtrarCuaderno"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_cliente", cliente)
            comando.Parameters.AddWithValue("_persona", persona)
            comando.Parameters.AddWithValue("_resuelto", resuelto)
            con.Open()
            lector = comando.ExecuteReader
            listaCuaderno = cargarArray(lector)
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaCuaderno
    End Function
End Class
