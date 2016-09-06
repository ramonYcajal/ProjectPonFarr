Imports MySql.Data.MySqlClient
Public Class ControladorLogin
    'constructor por defecto
    Public Sub New()

    End Sub
    Public Function isLogged(ByVal admin As Administracion) As Integer
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
            comando.Parameters("@_resultado").Direction = ParameterDirection.Output
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return comando.Parameters("@_resultado").Value
    End Function
End Class
