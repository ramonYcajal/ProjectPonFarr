Imports MySql.Data.MySqlClient
Public Class ControladorSubcuenta
    Private listaSubcuentas As ArrayList
    Private Sub insertarId(listaSubcuentas As ArrayList)
        Dim idCorreo As Int32
        idCorreo = mostrarUltimoId()
        For Each subcuenta As Subcuenta In listaSubcuentas
            subcuenta.Idcorreo1 = idCorreo

        Next
    End Sub
    Public Sub insertar(listaSubcuentas As ArrayList)
        insertarId(listaSubcuentas)
        For Each subcuenta As Subcuenta In listaSubcuentas
            Dim conexion As New ConexionBaseDeDatos
            Dim con As New MySqlConnection
            Dim comando As New MySqlCommand
            Try
                con = conexion.conectar
                comando.Connection = con
                comando.CommandText = "insertarSubcuenta"
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("_idCorreo", subcuenta.Idcorreo1)
                comando.Parameters.AddWithValue("_direccion", subcuenta.Direccion1)
                comando.Parameters.AddWithValue("_usuario", subcuenta.Usuario1)
                comando.Parameters.AddWithValue("_contrasena", subcuenta.Contrasena1)
                comando.Parameters.AddWithValue("_ubicacion", subcuenta.Ubicacion1)
                con.Open()
                comando.ExecuteNonQuery()
                conexion.desconectar(con)
            Catch ex As Exception
                mensaje = ex.Message
                frmAdvertencia.Show()
            End Try
        Next
    End Sub
    Private Function mostrarUltimoId() As Int32
        Dim id As Int32
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarUltimoId"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_nombreTabla", "correos")
            comando.Parameters.AddWithValue("@_id", MySqlDbType.Int16)
            comando.Parameters("@_id").Direction = ParameterDirection.Output
            con.Open()
            comando.ExecuteNonQuery()
            id = comando.Parameters("@_id").Value
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return id
    End Function
    Public Function mostrarSubcuentas(ByVal id As Int32) As ArrayList
        Dim conexion As New ConexionBaseDeDatos
        Dim listaSubcuentas As New ArrayList
        Dim lector As MySqlDataReader
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarSubcuentas"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_idCorreo", id)
            con.Open()
            lector = comando.ExecuteReader
            listaSubcuentas = cargarArraySubcuentas(lector)
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaSubcuentas
    End Function
    Private Function cargarArraySubcuentas(ByVal lector As MySqlDataReader) As ArrayList
        Dim listaSubcuentas As New ArrayList
        If lector.HasRows Then
            Do While lector.Read
                Dim subcuenta As New Subcuenta
                subcuenta.Id1 = lector.GetInt32(0)
                subcuenta.Idcorreo1 = lector.GetInt32(1)
                subcuenta.Direccion1 = lector.GetString(2)
                subcuenta.Usuario1 = lector.GetString(3)
                subcuenta.Contrasena1 = lector.GetString(4)
                subcuenta.Ubicacion1 = lector.GetString(5)
                listaSubcuentas.Add(subcuenta)
            Loop
        End If
        Return listaSubcuentas
    End Function
    Public Sub insertarSubcuenta(ByVal subcuenta As Subcuenta)
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim con As New MySqlConnection
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "insertarSubcuenta"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_idCorreo", subcuenta.Idcorreo1)
            comando.Parameters.AddWithValue("_direccion", subcuenta.Direccion1)
            comando.Parameters.AddWithValue("_usuario", subcuenta.Usuario1)
            comando.Parameters.AddWithValue("_contrasena", subcuenta.Contrasena1)
            comando.Parameters.AddWithValue("_ubicacion", subcuenta.Ubicacion1)
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Sub actualizarSubcuenta(ByVal subcuenta As Subcuenta)
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim con As New MySqlConnection
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "actualizarSubcuenta"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", subcuenta.Id1)
            'comando.Parameters.AddWithValue("_idCorreo", subcuenta.Idcorreo1)
            comando.Parameters.AddWithValue("_direccion", subcuenta.Direccion1)
            comando.Parameters.AddWithValue("_usuario", subcuenta.Usuario1)
            comando.Parameters.AddWithValue("_contrasena", subcuenta.Contrasena1)
            comando.Parameters.AddWithValue("_ubicacion", subcuenta.Ubicacion1)

            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Sub eliminarSubcuenta(ByVal id As Int32)
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Dim controlador As New ControladorPuesto
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "eliminarSubcuenta"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", id)
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
End Class
