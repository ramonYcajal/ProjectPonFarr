Imports MySql.Data.MySqlClient
Public Class ControladorLogin
    'constructor por defecto
    Public Sub New()

    End Sub
    Public Function isLogged(ByVal admin As Administracion) As ArrayList
        Dim conexion As New ConexionBaseDeDatos
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "login"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_nombre", admin.Usuario1)
            comando.Parameters.AddWithValue("_contrasena", admin.Contrasena1)
            comando.Parameters.AddWithValue("@_resultado", MySqlDbType.Int16)
            comando.Parameters.AddWithValue("@_id", MySqlDbType.Int16)
            comando.Parameters("@_resultado").Direction = ParameterDirection.Output
            comando.Parameters("@_id").Direction = ParameterDirection.Output
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Dim array As New ArrayList
        array.Add(comando.Parameters("@_resultado").Value)
        array.Add(comando.Parameters("@_id").Value)
        Return array
    End Function
    Public Function cambioContrasena(ByVal contrasenaVieja As String, contrasenaNueva As String)
        Dim conexion As New ConexionBaseDeDatos
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim resultado As Int32
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "cambiarContraseña"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_nombre", "admin")
            comando.Parameters.AddWithValue("_contrasenaVieja", contrasenaVieja)
            comando.Parameters.AddWithValue("_contrasenaNueva", contrasenaNueva)
            comando.Parameters.AddWithValue("@_resultado", MySqlDbType.Int16)
            comando.Parameters("@_resultado").Direction = ParameterDirection.Output
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        resultado = comando.Parameters("@_resultado").Value
        Return resultado
    End Function
End Class
