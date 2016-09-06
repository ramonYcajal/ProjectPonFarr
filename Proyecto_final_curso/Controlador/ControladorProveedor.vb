Imports MySql.Data.MySqlClient
Public Class ControladorProveedor
    Public Sub New()

    End Sub
    ' insertar un proveedor nuevo en la base de datos
    Public Sub insertar(ByVal prov As Proveedor)
        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand

        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "insertarProveedor"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_nombre", prov.Nombre1)
            comando.Parameters.AddWithValue("_nif", prov.Nif1)
            comando.Parameters.AddWithValue("_personaContacto", prov.PersonaContacto1)
            comando.Parameters.AddWithValue("_email", prov.Email1)
            comando.Parameters.AddWithValue("_observaciones", prov.Observaciones1)
            comando.Parameters.AddWithValue("_domicilio", prov.Domicilio1)
            comando.Parameters.AddWithValue("_poblacion", prov.Poblacion1)
            comando.Parameters.AddWithValue("_provincia", prov.Provincia1)
            comando.Parameters.AddWithValue("_codpos", prov.Codpos1)
            con.Open()
            comando.ExecuteNonQuery()
            mensaje = "Proveedor agregado"
            frmAdvertencia.Show()
            conexion.desconectar(con)
            If prov.ArrayTelefonos1.Count <> 0 Then
                Dim controlador As New ControladorTelefono
                controlador.insertarArrayTelefonos(prov, "proveedor")
            End If
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    'función que devuelve un arraylist de todos los proveedores
    Public Function mostrarProveedores() As ArrayList
        Dim listaProveedores As New ArrayList
        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim lector As MySqlDataReader
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarProveedores"
            comando.CommandType = CommandType.StoredProcedure
            con.Open()
            lector = comando.ExecuteReader
            listaProveedores = cargarArrayProveedores(lector)
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaProveedores
    End Function
    'función que carga en un arraylist toda la lista de proveedores
    'es privada porque sólo esta clase necesita acceder a esta función
    Private Function cargarArrayProveedores(ByVal lector As MySqlDataReader) As ArrayList
        Dim listaProveedores As New ArrayList
        Dim listatelefonos As New ArrayList
        Dim controlador As New ControladorTelefono
        If lector.HasRows Then
            Do While lector.Read
                Dim proveedor As New Proveedor
                proveedor.Id1 = lector.GetInt32(0)
                proveedor.Nombre1 = lector.GetString(1)
                proveedor.Nif1 = lector.GetString(2)
                proveedor.PersonaContacto1 = lector.GetString(3)
                proveedor.Email1 = lector.GetString(4)
                proveedor.Observaciones1 = lector.GetString(5)
                proveedor.Domicilio1 = lector.GetString(6)
                proveedor.Poblacion1 = lector.GetString(7)
                proveedor.Provincia1 = lector.GetString(8)
                listatelefonos = controlador.mostrarArrayTelefonos(proveedor.Id1, "proveedor")
                proveedor.ArrayTelefonos1 = listatelefonos
                proveedor.Codpos1 = lector.GetString(9)
                listaProveedores.Add(proveedor)
            Loop
        End If
        Return listaProveedores
    End Function
    ' función que filtra todos los proveedores atendiendo a un nombre en concreto o que tenga unos caracteres
    ' específicos
    Public Function filtrarProveedor(ByVal nombre As String) As ArrayList
        Dim arrayProveedores As New ArrayList
        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim lector As MySqlDataReader
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "filtrarProveedores"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_filtro", nombre)
            con.Open()
            lector = comando.ExecuteReader()
            arrayProveedores = cargarArrayProveedores(lector)
            conexion.desconectar(con)

        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        'devuelvo el arraylist con todos los proveedores encontrados de la base de datos
        Return arrayProveedores
    End Function
    ' función que me buscar un proveedor en concreto y me lo muestra
    'me lo guarda en un arraylist, no hace falta pero así ahorro código para mostrarlo
    'usando la función cargarArrayClientes
    Public Function mostrarProveedor(ByVal id As Int32) As ArrayList
        Dim arrayProveedores As New ArrayList
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Dim lector As MySqlDataReader
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarProveedor"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", id)
            con.Open()
            lector = comando.ExecuteReader
            arrayProveedores = cargarArrayProveedores(lector)
            conexion.desconectar(con)

        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return arrayProveedores
    End Function
    'función que actualiza un proveedor determinado alguno de sus valores
    Public Sub actualizar(ByVal prov As Proveedor)
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "ActualizarProveedor"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", prov.Id1)
            comando.Parameters.AddWithValue("_nombre", prov.Nombre1)
            comando.Parameters.AddWithValue("_nif", prov.Nif1)
            comando.Parameters.AddWithValue("_personaContacto", prov.PersonaContacto1)
            comando.Parameters.AddWithValue("_email", prov.Email1)
            comando.Parameters.AddWithValue("_observaciones", prov.Observaciones1)
            comando.Parameters.AddWithValue("_domicilio", prov.Domicilio1)
            comando.Parameters.AddWithValue("_poblacion", prov.Poblacion1)
            comando.Parameters.AddWithValue("_provincia", prov.Provincia1)
            comando.Parameters.AddWithValue("_codpos", prov.Codpos1)
            con.Open()
            comando.ExecuteNonQuery()
            mensaje = "Registro actualizado"
            frmAdvertencia.Show()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
End Class
