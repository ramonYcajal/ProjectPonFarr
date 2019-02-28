Imports MySql.Data.MySqlClient
Public Class ControladorCorreo
    Public Sub New()

    End Sub
    Public Sub insertarCorreo(ByVal correo As Correo)
        Dim conexion As New ConexionBaseDeDatos
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "insertarCorreo"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_proveedor", correo.Proveedor1)
            comando.Parameters.AddWithValue("_idusuario", correo.Idusuario1)
            comando.Parameters.AddWithValue("_nombre", correo.Nombre1)
            comando.Parameters.AddWithValue("_direccionCorreo", correo.DireccionCorreo1)
            comando.Parameters.AddWithValue("_usuarioConexion", correo.UsuarioConexion1)
            comando.Parameters.AddWithValue("_nombreCuentaConexion", correo.NombreCUentaConexions1)
            comando.Parameters.AddWithValue("_servidorCorreoEntrante", correo.ServidorCorreoEntrante1)
            comando.Parameters.AddWithValue("_contrasena", correo.Contrasena1)
            comando.Parameters.AddWithValue("_servidorCorreoSaliente", correo.ServidorCorreoSaliente1)
            comando.Parameters.AddWithValue("_observaciones", correo.Observaciones1)
            comando.Parameters.AddWithValue("_subdominio", correo.Subdominio1)
            comando.Parameters.AddWithValue("_usuarioGestion", correo.UsuarioGestion1)
            comando.Parameters.AddWithValue("_contrasenaGestion", correo.ContrasenaGestion1)
            comando.Parameters.AddWithValue("_webGestion", correo.WebGestion1)
            con.Open()
            comando.ExecuteNonQuery()
            If (correo.Subcuentas1.Count <> 0) Then
                ' entonces crea un objeto de tipo controladorPuesto y le pasa el arraylist de los puestos
                ' y el controlador de puesto ya se encargar de agregar los puestos correspondientes
                Dim controlador As New ControladorSubcuenta
                controlador.insertar(correo.Subcuentas1)
            End If
            mensaje = "Registro agregado"
            frmAdvertencia.Show()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    '/////////////////////////////////////////////////////////////////////////

    Public Function mostrarCorreos() As ArrayList
        Dim conexion As New ConexionBaseDeDatos
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim listaCorreos As New ArrayList
        Dim lector As MySqlDataReader
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarCorreos"
            comando.CommandType = CommandType.StoredProcedure
            con.Open()
            lector = comando.ExecuteReader
            listaCorreos = cargarArray(lector)
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaCorreos
    End Function
    Public Function mostrarCorreo(ByVal id As Int32) As ArrayList
        Dim conexion As New ConexionBaseDeDatos
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim lector As MySqlDataReader
        Dim listaCorreo As New ArrayList
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarCorreo"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", id)
            con.Open()
            lector = comando.ExecuteReader
            listaCorreo = cargarArray(lector)
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaCorreo
    End Function
    Private Function cargarArray(ByVal lector As MySqlDataReader) As ArrayList
        Dim listaRedes As New ArrayList
        If lector.HasRows Then
            Do While lector.Read
                Dim correo As New Correo
                Dim controladorSubcuenta As New ControladorSubcuenta
                correo.Id1 = lector.GetInt32(0)
                correo.Proveedor1 = lector.GetString(1)
                correo.Idusuario1 = lector.GetString(2)
                correo.Nombre1 = lector.GetString(3)
                correo.DireccionCorreo1 = lector.GetString(4)
                correo.UsuarioConexion1 = lector.GetString(5)
                correo.NombreCUentaConexions1 = lector.GetString(6)
                correo.Contrasena1 = lector.GetString(7)
                correo.ServidorCorreoEntrante1 = lector.GetString(8)
                correo.ServidorCorreoSaliente1 = lector.GetString(9)
                correo.Observaciones1 = lector.GetString(10)
                correo.Subdominio1 = lector.GetString(11)
                correo.UsuarioGestion1 = lector.GetString(12)
                correo.ContrasenaGestion1 = lector.GetString(13)
                correo.WebGestion1 = lector.GetString(14)
                correo.Subcuentas1 = controladorSubcuenta.mostrarSubcuentas(correo.Id1)
                listaRedes.Add(correo)
            Loop
        End If
        Return listaRedes
    End Function
    Public Sub actualizarCorreo(ByVal correo As Correo)
        Dim conexion As New ConexionBaseDeDatos
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "actualizarCorreo"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_proveedor", correo.Proveedor1)
            comando.Parameters.AddWithValue("_idusuario", correo.Idusuario1)
            comando.Parameters.AddWithValue("_nombre", correo.Nombre1)
            comando.Parameters.AddWithValue("_direccionCorreo", correo.DireccionCorreo1)
            comando.Parameters.AddWithValue("_usuarioConexion", correo.UsuarioConexion1)
            comando.Parameters.AddWithValue("_nombreCuentaConexion", correo.NombreCUentaConexions1)
            comando.Parameters.AddWithValue("_servidorCorreoEntrante", correo.ServidorCorreoEntrante1)
            comando.Parameters.AddWithValue("_contrasena", correo.Contrasena1)
            comando.Parameters.AddWithValue("_servidorCorreoSaliente", correo.ServidorCorreoSaliente1)
            comando.Parameters.AddWithValue("_observaciones", correo.Observaciones1)
            comando.Parameters.AddWithValue("_subdominio", correo.Subdominio1)
            comando.Parameters.AddWithValue("_usuarioGestion", correo.UsuarioGestion1)
            comando.Parameters.AddWithValue("_contrasenaGestion", correo.ContrasenaGestion1)
            comando.Parameters.AddWithValue("_webGestion", correo.WebGestion1)
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
            mensaje = " registro actualizado"
            frmAdvertencia.Show()
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Function filtrarCorreo(ByVal nombre As String) As ArrayList
        Dim arrayRed As New ArrayList
        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim lector As MySqlDataReader
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "filtrarCorreo"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_Cliente", nombre)
            con.Open()
            lector = comando.ExecuteReader()
            arrayRed = cargarArray(lector)
            conexion.desconectar(con)

        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        'devuelvo el arraylist con todos los clientes encontrados de la base de datos
        Return arrayRed
    End Function
End Class
