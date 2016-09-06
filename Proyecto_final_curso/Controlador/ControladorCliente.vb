Imports MySql.Data.MySqlClient
Public Class ControladorCliente
    Public Sub New()

    End Sub
    Public Sub insertar(ByVal clie As Cliente)

        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "insertarCliente"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_nombre", clie.Nombre1)
            comando.Parameters.AddWithValue("_nif", clie.Nif1)
            comando.Parameters.AddWithValue("_personaContacto", clie.PersonaContacto1)
            comando.Parameters.AddWithValue("_email", clie.Email1)
            comando.Parameters.AddWithValue("_observaciones", clie.Observaciones1)
            comando.Parameters.AddWithValue("_domicilio", clie.Domicilio1)
            comando.Parameters.AddWithValue("_poblacion", clie.Poblacion1)
            comando.Parameters.AddWithValue("_provincia", clie.Provincia1)
            comando.Parameters.AddWithValue("_codpos", clie.Codpos1)
            con.Open()
            comando.ExecuteNonQuery()
            mensaje = "Cliente  agregado"
            frmAdvertencia.Show()
            conexion.desconectar(con)
            'una de las variables de tipo cliente es un arraylist que almacena teléfonos
            'lo que hago es ver si tiene algún dato ingresado, si es así entonces llama
            'a controlaldorTeléfono para insertar los datos que tenga, pasándole el objeto
            'de tipo cliente y el nombre de la tabla de destino para guardar los objetos
            If clie.ArrayTelefonos1.Count <> 0 Then
                Dim controlador As New ControladorTelefono
                controlador.insertarArrayTelefonos(clie, "cliente")
            End If
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    'Funcion que me muestra todos los clientes de la base de datos y me los guarda en un
    'arraylist
    Public Function mostrarClientes() As ArrayList
        'me creo un arraylist para ir almacenando los datos de la consulta
        'al arraylist no hace falta decirle de qué tipo es, simplemente dim ___ as new Arraylist
        Dim arrayClientes As New ArrayList
        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim lector As MySqlDataReader
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarClientes"
            comando.CommandType = CommandType.StoredProcedure
            con.Open()
            lector = comando.ExecuteReader()
            arrayClientes = cargarArrayClientes(lector)
            conexion.desconectar(con)

        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()

        End Try
        'devuelvo el arraylist con todos los clientes encontrados de la base de datos
        Return arrayClientes
    End Function
    'esta función es privada porque sólo la necesita usar esta clase de forma interna
    'no hace falta tenerla de forma pública para acceder desde fuera.
    'recibe una varieble lector que es de tipo mysqldatareader, la gestiona leyendo
    'los datos que hay dentro de la variable , los va almacenando en un arraylist 
    'y devuelve el arraylist
    Private Function cargarArrayClientes(ByVal lector As MySqlDataReader) As ArrayList
        Dim arrayClientes As New ArrayList
        Dim controlador As New ControladorTelefono
        Dim listaTelefonos As New ArrayList
        If lector.HasRows Then
            Do While lector.Read
                ' por cada vuelta, me creo un objeto de tipo cliente y le añado sus valores
                'finalmente almaceno ese nuevo objeto cliente en el arraylist
                Dim clie As New Cliente()
                clie.Id1 = lector.GetInt32(0)
                clie.Nombre1 = lector.GetString(1)
                clie.Nif1 = lector.GetString(2)
                clie.PersonaContacto1 = lector.GetString(3)
                clie.Email1 = lector.GetString(4)
                clie.Observaciones1 = lector.GetString(5)
                clie.Domicilio1 = lector.GetString(6)
                clie.Poblacion1 = lector.GetString(7)
                clie.Provincia1 = lector.GetString(8)
                listaTelefonos = controlador.mostrarArrayTelefonos(clie.Id1, "cliente")
                clie.ArrayTelefonos1 = listaTelefonos
                clie.Codpos1 = lector.GetString(9)
                arrayClientes.Add(clie)

            Loop
        End If
        Return arrayClientes
    End Function
    ' función que filtra todos los clientes atendiendo a un nombre en concreto o que tenga unos caracteres
    ' específicos
    Public Function filtrarCliente(ByVal nombre As String) As ArrayList
        Dim arrayClientes As New ArrayList
        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim lector As MySqlDataReader
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "filtrarClientes"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_filtro", nombre)
            con.Open()
            lector = comando.ExecuteReader()
            arrayClientes = cargarArrayClientes(lector)
            conexion.desconectar(con)

        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        'devuelvo el arraylist con todos los clientes encontrados de la base de datos
        Return arrayClientes
    End Function
    ' función que me buscar un cliente en concreto y me lo muestra
    'me lo guarda en un arraylist, no hace falta pero así ahorro código para mostrarlo
    'usando la función cargarArrayClientes
    Public Function mostrarCliente(ByVal id As Int32) As ArrayList
        Dim arrayClientes As New ArrayList
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Dim lector As MySqlDataReader
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarCliente"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", id)
            con.Open()
            lector = comando.ExecuteReader
            arrayClientes = cargarArrayClientes(lector)
            conexion.desconectar(con)

        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return arrayClientes
    End Function
    'función que actualiza un cliente determinado alguno de sus valores
    Public Sub actualizar(ByVal clie As Cliente)
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "ActualizarCliente"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", clie.Id1)
            comando.Parameters.AddWithValue("_nombre", clie.Nombre1)
            comando.Parameters.AddWithValue("_nif", clie.Nif1)
            comando.Parameters.AddWithValue("_personaContacto", clie.PersonaContacto1)
            comando.Parameters.AddWithValue("_email", clie.Email1)
            comando.Parameters.AddWithValue("_observaciones", clie.Observaciones1)
            comando.Parameters.AddWithValue("_domicilio", clie.Domicilio1)
            comando.Parameters.AddWithValue("_poblacion", clie.Poblacion1)
            comando.Parameters.AddWithValue("_provincia", clie.Provincia1)
            comando.Parameters.AddWithValue("_codpos", clie.Codpos1)
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
