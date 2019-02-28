Imports MySql.Data.MySqlClient
Public Class ControladorPuesto
    Private listaPuestos As ArrayList
    Private Sub insertarId(listaPuestos As ArrayList)
        Dim idRed As Int32
        idRed = mostrarUltimoId()
        For Each puesto As Puesto In listaPuestos
            puesto.Idred1 = idRed

        Next
    End Sub
    Public Sub insertar(listaPuestos As ArrayList)
        insertarId(listaPuestos)
        For Each puesto As Puesto In listaPuestos
            Dim conexion As New ConexionBaseDeDatos
            Dim con As New MySqlConnection
            Dim comando As New MySqlCommand
            Try
                con = conexion.conectar
                comando.Connection = con
                comando.CommandText = "insertarPuesto"
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("_idRed", puesto.Idred1)
                comando.Parameters.AddWithValue("_localizacion", puesto.Localizacion1)
                comando.Parameters.AddWithValue("_nombrePC", puesto.NombrePc1)
                comando.Parameters.AddWithValue("_usuario", puesto.Usuario1)
                comando.Parameters.AddWithValue("_ip", puesto.Ip1)
                comando.Parameters.AddWithValue("_SistOperativo", puesto.SistemaOperativo1)
                comando.Parameters.AddWithValue("_contrasena", puesto.Contrasena1)
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
            comando.Parameters.AddWithValue("_nombreTabla", "red")
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
    Public Function mostrarPuestos(ByVal id As Int32) As ArrayList
        Dim conexion As New ConexionBaseDeDatos
        Dim listaPuestos As New ArrayList
        Dim lector As MySqlDataReader
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarPuestos"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", id)
            con.Open()
            lector = comando.ExecuteReader
            listaPuestos = cargarArrayPuestos(lector)
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaPuestos
    End Function
    Private Function cargarArrayPuestos(ByVal lector As MySqlDataReader) As ArrayList
        Dim listaPuestos As New ArrayList
        If lector.HasRows Then
            Do While lector.Read
                Dim puesto As New Puesto
                puesto.Id1 = lector.GetInt32(0)
                puesto.Idred1 = lector.GetInt32(1)
                puesto.Localizacion1 = lector.GetString(2)
                puesto.NombrePc1 = lector.GetString(3)
                puesto.Usuario1 = lector.GetString(4)
                puesto.Ip1 = lector.GetString(5)
                puesto.SistemaOperativo1 = lector.GetString(6)
                puesto.Contrasena1 = lector.GetString(7)
                listaPuestos.Add(puesto)
            Loop
        End If
        Return listaPuestos
    End Function
    Public Sub insertarPuesto(ByVal puesto As Puesto)
        Dim controlador As New ControladorPuesto
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim con As New MySqlConnection
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "insertarPuesto"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_idRed", puesto.Idred1)
            comando.Parameters.AddWithValue("_localizacion", puesto.Localizacion1)
            comando.Parameters.AddWithValue("_nombrePC", puesto.NombrePc1)
            comando.Parameters.AddWithValue("_usuario", puesto.Usuario1)
            comando.Parameters.AddWithValue("_ip", puesto.Ip1)
            comando.Parameters.AddWithValue("_SistOperativo", puesto.SistemaOperativo1)
            comando.Parameters.AddWithValue("_contrasena", puesto.Contrasena1)
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Sub actualizarPuesto(ByVal puesto As Puesto)
        Dim controlador As New ControladorPuesto
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim con As New MySqlConnection
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "actualizarPuesto"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", puesto.Id1)
            comando.Parameters.AddWithValue("_idRed", puesto.Idred1)
            comando.Parameters.AddWithValue("_localizacion", puesto.Localizacion1)
            comando.Parameters.AddWithValue("_nombrePc", puesto.NombrePc1)
            comando.Parameters.AddWithValue("_usuario", puesto.Usuario1)
            comando.Parameters.AddWithValue("_ip", puesto.Ip1)
            comando.Parameters.AddWithValue("_sistOperativo", puesto.SistemaOperativo1)
            comando.Parameters.AddWithValue("_contrasena", puesto.Contrasena1)
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Sub eliminarPuesto(ByVal id As Int32)
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Dim controlador As New ControladorPuesto
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "eliminarPuesto"
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
