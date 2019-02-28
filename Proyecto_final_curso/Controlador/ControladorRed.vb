Imports MySql.Data.MySqlClient
Public Class ControladorRed
    'controlador por defecto
    Public Sub New()

    End Sub
    Public Sub insertar(ByVal red As Red)
        'recibe el objeto de tipo red
        'inserta los campos correspondientes en la base de datos pasados por parámetros
        'a la stored procedure
        'comprueba el arraylist de puestos a ver si tiene objetos dentro
        'si los tiene, entonces pide la última id de la tabla de red 
        'y en el objeto de tipo puesto ,se va llenando todos los puestos correspondientes con
        ' la última id insertarda, se pasa el objeto ya rellenado y se inserta en la tabla de puestos
        Dim conexion As New ConexionBaseDeDatos
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "insertarRed"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_cliente", red.Cliente1)
            comando.Parameters.AddWithValue("_servidorNom", red.NombreServidor1)
            comando.Parameters.AddWithValue("_servidorIP", red.ServidorIp1)
            comando.Parameters.AddWithValue("_grupo", red.Grupo1)
            comando.Parameters.AddWithValue("_router", red.Router1)
            comando.Parameters.AddWithValue("_dns1", red.Dns11)
            comando.Parameters.AddWithValue("_dns2", red.Dns21)
            comando.Parameters.AddWithValue("_mascara", red.Mascara1)
            comando.Parameters.AddWithValue("_usuarioRouter", red.UsuarioRouter1)
            comando.Parameters.AddWithValue("_contrasenaRouter", red.ContrasenaRouter1)
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
            If (red.ArrayPuestos1.Count <> 0) Then
                ' entonces crea un objeto de tipo controladorPuesto y le pasa el arraylist de los puestos
                ' y el controlador de puesto ya se encargar de agregar los puestos correspondientes
                Dim controlador As New ControladorPuesto
                controlador.insertar(red.ArrayPuestos1)
            End If
            mensaje = "Nuevo registro agregado"
            frmAdvertencia.Show()
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Function mostrarRedes() As ArrayList
        Dim conexion As New ConexionBaseDeDatos
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim listaRedes As New ArrayList
        Dim lector As MySqlDataReader
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarRedes"
            comando.CommandType = CommandType.StoredProcedure
            con.Open()
            lector = comando.ExecuteReader
            listaRedes = cargarArray(lector)
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaRedes
    End Function
    Public Function mostrarRed(ByVal id As Int32) As ArrayList
        Dim conexion As New ConexionBaseDeDatos
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim lector As MySqlDataReader
        Dim listaRed As New ArrayList
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarRed"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", id)
            con.Open()
            lector = comando.ExecuteReader
            listaRed = cargarArray(lector)
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaRed
    End Function
    Private Function cargarArray(ByVal lector As MySqlDataReader) As ArrayList
        Dim listaRedes As New ArrayList
        If lector.HasRows Then
            Do While lector.Read
                Dim red As New Red
                Dim controladorPuesto As New ControladorPuesto
                red.Id1 = lector.GetInt32(0)
                red.Cliente1 = lector.GetString(1)
                red.NombreServidor1 = lector.GetString(2)
                red.ServidorIp1 = lector.GetString(3)
                red.Grupo1 = lector.GetString(4)
                red.Router1 = lector.GetString(5)
                red.Dns11 = lector.GetString(6)
                red.Dns21 = lector.GetString(7)
                red.Mascara1 = lector.GetString(8)
                red.UsuarioRouter1 = lector.GetString(9)
                red.ArrayPuestos1 = controladorPuesto.mostrarPuestos(red.Id1)
                red.ContrasenaRouter1 = lector.GetString(10)
                listaRedes.Add(red)
            Loop
        End If
        Return listaRedes
    End Function
    Public Sub actualizarRed(ByVal red As Red)
        Dim conexion As New ConexionBaseDeDatos
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "actualizarRed"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", red.Id1)
            comando.Parameters.AddWithValue("_cliente", red.Cliente1)
            comando.Parameters.AddWithValue("_servidorNombre", red.NombreServidor1)
            comando.Parameters.AddWithValue("_servidorIP", red.ServidorIp1)
            comando.Parameters.AddWithValue("_grupo", red.Grupo1)
            comando.Parameters.AddWithValue("_router", red.Router1)
            comando.Parameters.AddWithValue("_dns1", red.Dns11)
            comando.Parameters.AddWithValue("_dns2", red.Dns21)
            comando.Parameters.AddWithValue("_mascara", red.Mascara1)
            comando.Parameters.AddWithValue("_usuarioRouter", red.UsuarioRouter1)
            comando.Parameters.AddWithValue("_contrasenaRouter", red.ContrasenaRouter1)
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
    Public Function filtrarRed(ByVal nombre As String) As ArrayList
        Dim arrayRed As New ArrayList
        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim lector As MySqlDataReader
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "filtrarRed"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_nombreCliente", nombre)
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
