Imports MySql.Data.MySqlClient
Public Class ControladorUsuario
    Public Sub New()

    End Sub
    Public Sub insertar(ByVal usuario As Usuario)
        Dim conexion As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim con As New ConexionBaseDeDatos
        Try
            conexion = con.conectar()
            comando.Connection = conexion
            comando.CommandText = "insertarUsuario"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_nombre", usuario.Nombre1)
            conexion.Open()
            comando.ExecuteNonQuery()
            con.desconectar(conexion)
            mensaje = "Usuario agregado"
            frmAdvertencia.Show()
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try

    End Sub

    Public Function mostrarUsuarios() As ArrayList
        Dim listaUsuarios As New ArrayList
        Dim conexion As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim con As New ConexionBaseDeDatos
        Dim lector As MySqlDataReader
        Try
            conexion = con.conectar()
            comando.Connection = conexion
            comando.CommandText = "mostrarUsuarios"
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()
            lector = comando.ExecuteReader
            listaUsuarios = cargarArrayUsuarios(lector)
            con.desconectar(conexion)

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
                Dim usuario As New Usuario
                usuario.Id1 = lector.GetInt32(0)
                usuario.Nombre1 = lector.GetString(1)
                listaUsuarios.Add(usuario)
            Loop
        End If
        Return listaUsuarios
    End Function
    Public Sub borrarUsuario(ByVal idUsuario As Int32)
        Dim conexion As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim con As New ConexionBaseDeDatos
        Try
            conexion = con.conectar
            comando.Connection = conexion
            comando.CommandText = "eliminarUsuario"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", idUsuario)
            conexion.Open()
            comando.ExecuteNonQuery()
            con.desconectar(conexion)
            mensaje = "Usuario borrado"
            frmAdvertencia.Show()
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Sub actualizarUsuario(ByVal usuario As Usuario, ByVal nombreNuevo As String)
        Dim conexion As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim con As New ConexionBaseDeDatos
        Try
            conexion = con.conectar
            comando.Connection = conexion
            comando.CommandText = "actualizarUsuario"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", usuario.Id1)
            comando.Parameters.AddWithValue("_nombre", usuario.Nombre1)
            comando.Parameters.AddWithValue("_nombreNuevo", nombreNuevo)
            conexion.Open()
            comando.ExecuteNonQuery()
            con.desconectar(conexion)
            mensaje = "Usuario actualizado"
            frmAdvertencia.Show()
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Function filtrarUsuario(ByVal usuario As String) As ArrayList
        Dim controlador As New ConexionBaseDeDatos
        Dim lector As MySqlDataReader
        Dim conexion As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim listaUsuarios As New ArrayList
        Try
            conexion = controlador.conectar
            comando.Connection = conexion
            comando.CommandText = "filtrarUsuario"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_filtro", usuario)
            conexion.Open()
            lector = comando.ExecuteReader
            listaUsuarios = cargarArray(lector)
            controlador.desconectar(conexion)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaUsuarios
    End Function
    Private Function cargarArray(ByVal lector As MySqlDataReader) As ArrayList
        Dim listaUsuarios As New ArrayList
        If lector.HasRows Then
            Do While lector.Read
                Dim usuario As New Usuario
                usuario.Nombre1 = lector.GetString(0)
                listaUsuarios.Add(usuario)
            Loop
        End If
        Return listaUsuarios
    End Function
End Class
