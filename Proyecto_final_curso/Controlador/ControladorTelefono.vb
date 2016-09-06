Imports MySql.Data.MySqlClient
Public Class ControladorTelefono
    ' esta clase es la que va a controlar la inserción muestra y modificación de las dos tablas
    'de teléfonos de la base de datos, una para los clientes y otra para los proveedores.

    Public Sub insertarArrayTelefonos(ByVal objeto As Object, tabla As String)
        'insertar array de teléfonos para un nuevo cliente en el caso de que tenga muchos
        ' la función recibe como parámetros un arraylist de tipo teléfono
        'como el cliente que se añade sería el último en la base de datos, lo que se hace es 
        'una consulta para que devuelva la última id, da igual cliente o proveedor
        'y esa id sería la clave foránea de la tabla detalle que hay que manterner para que la  
        'estructura entronque con el modelo relacional

        Dim idRetorno As Int32
        Dim listaTelefonos As New ArrayList
        Dim nomb As String
        Dim telef As String
        Try
            Select Case tabla
                Case "cliente"
                    'se conecta a la tabla cliente y obtiene la última id usa la funcion
                    'guardo el arraylist de la variable de tipo cliente en un arraylist local
                    idRetorno = mostrarUltimoId(objeto, "cliente")
                    listaTelefonos = objeto.ArrayTelefonos1
                    ' recorro el arraylist local en  busca de todos los objetos de tipo telefono
                    'para irlos guardando en su tabla correspondiente
                    ' la idRetorno es la id del último cliente nuevo que he agregado
                    ' la parte para guardar está en otra función que se llama guardarArrayTelefonos
                    ' porque las dos tablasd de telefonos se repiten los campos
                    ' así que el código es igual. lo único que hay que hacer es tomar
                    ' lo que se guarde en los objetos de tipo teléfono y pasaralo a variables
                    ' luego le lanzas las variables a la funcion de guardar y listo

                    ' el case de proveedor es igual

                    For Each telefono As Telefono In listaTelefonos
                        nomb = telefono.Nombre1
                        telef = telefono.Telefono1
                        guardarArrayTelefonos(idRetorno, nomb, telef, tabla)
                    Next

                Case "proveedor"

                    idRetorno = mostrarUltimoId(objeto, "proveedor")
                    listaTelefonos = objeto.ArrayTelefonos1

                    For Each telefono As Telefono In listaTelefonos
                        nomb = telefono.Nombre1
                        telef = telefono.Telefono1
                        guardarArrayTelefonos(idRetorno, nomb, telef, tabla)

                    Next

            End Select
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    ' esta función devuelve el id del último dato que se haya insertado dentro de una determinada tabla
    ' la tabla puede ser la de clientes y proveedores
    'esta función es llamada desde otra función que se llama insertarArrayTelefonos
    Private Function mostrarUltimoId(ByVal objeto As Object, ByVal tabla As String) As Int32
        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim idRetorno As Int32
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarUltimoId"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_nombreTabla", tabla)
            comando.Parameters.AddWithValue("@_id", MySqlDbType.Int16)
            comando.Parameters("@_id").Direction = ParameterDirection.Output
            con.Open()
            comando.ExecuteNonQuery()
            idRetorno = comando.Parameters("@_id").Value
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return idRetorno
    End Function

    Private Sub guardarArrayTelefonos(ByVal idRetorno As Int32, ByVal nombre As String,
                                      ByVal telefono As String, ByVal tabla As String)
        Dim conexion As New ConexionBaseDeDatos
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Try

            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "insertarTelefonos"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_idRetorno", idRetorno)
            comando.Parameters.AddWithValue("_nombre", nombre)
            comando.Parameters.AddWithValue("_telefono", telefono)
            comando.Parameters.AddWithValue("_nombreTabla", tabla)
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Function mostrarArrayTelefonos(ByVal id As Int32, ByVal tabla As String) As ArrayList

        Dim listaTelefonos As New ArrayList
        Try
            'hago la conexión y pido los teéfonos de un determinado id que me da de la tabla en cuestion
            ' luego como las tablas de telefonos clientes y telefonos proveedores son iguales
            ' la carga del array es igual, así que le paso a una función el lector en cuestion
            'resultante de una consulta, y me carga el arraylist, así no repito código
            Select Case tabla
                Case "cliente"
                    'La función obtenerLectorYlistaTelefonos lo que hace es  conectarse a la base de
                    'datos y obtener el resultado de una consulta en una variable de tipo msqldatareader
                    'esa variable no la devuelve, LoaderOptimization que hace es llamar a una tercera
                    'función que se llama cargar arrayteléfonos y el resultado de esta tercera función
                    'se guarda en un arraylist que se llama listaTelefonos que es lo que devuelve la 
                    'función obtenerLectorYListaTelefonos

                    listaTelefonos = obtenerLectorYListaTelefonos(id, tabla)
                Case "proveedor"


                    listaTelefonos = obtenerLectorYListaTelefonos(id, tabla)
            End Select
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaTelefonos
    End Function
    'función que obtiene el lector procedente de una de las dos tablas de teléfonos
    'pasadas por parámetros desde la función de arriba
    Private Function obtenerLectorYListaTelefonos(ByVal id As Int32, ByVal tabla As String) As ArrayList
        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Dim lector As MySqlDataReader
        Dim listaTelefonos As New ArrayList
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "mostrarTelefonos"
            comando.Parameters.AddWithValue("_id", id)
            comando.Parameters.AddWithValue("_nombreTabla", tabla)
            comando.CommandType = CommandType.StoredProcedure
            con.Open()
            lector = comando.ExecuteReader
            listaTelefonos = cargarArrayTelefonos(lector)
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try

        Return listaTelefonos
    End Function
    ' esta función es privada porque sólo hace falta que accedan a ella los métodos de la clase
    ' lo que hace es recibir un lector de la consulta mostrar arrayteléfonos y carga el contenido
    ' las tablas de teléfonos tanto para clientes como para proveedores son iguales, así que este código
    ' es válido para ambas.
    Private Function cargarArrayTelefonos(ByVal lector As MySqlDataReader) As ArrayList
        Dim listaTelefonos As New ArrayList
        If lector.HasRows Then
            Do While lector.Read
                Dim telefono As New Telefono
                telefono.Id1 = lector.GetInt32(0)
                telefono.Nombre1 = lector.GetString(2)
                telefono.Telefono1 = lector.GetString(3)
                listaTelefonos.Add(telefono)
            Loop
        End If
        Return listaTelefonos
    End Function

    ' función que recibe un id un nombre de tabla, llama al procedimiento almacenado en cuestión
    ' y borra la fila que sea, en el procedimiento es donde se escoge si es de cliente o de proveedor
    ' con un select case.
    Public Sub eliminarTelefono(ByVal id As Int32, ByVal tabla As String)
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "eliminarTelefonos"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", id)
            comando.Parameters.AddWithValue("_nombreTabla", tabla)
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
            mensaje = "Teléfono eliminado"
            frmAdvertencia.Show()
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Sub actualizarTelefono(ByVal id As Int32, ByVal nombre As String, ByVal telefono As String,
                                  ByVal tabla As String)
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "actualizarTelefono"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", id)
            comando.Parameters.AddWithValue("_nombre", nombre)
            comando.Parameters.AddWithValue("_telefono", telefono)
            comando.Parameters.AddWithValue("_nombreTabla", tabla)
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
            mensaje = "Teléfono actualizado"
            frmAdvertencia.Show()
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    ' función que recibe un teléfono y lo inserta en la tabla correspondiente porque viene de la parte
    ' de actualizar cliente o actualizar proveedor y esta parte prefiero que agregue el teléfono
    ' directamente a la base de datos y luego desde editar cliente que vuelva a cargar el array
    ' la id es la id que hace de clave foránea en cualquiera de las dos tablas de teléfonos.
    Public Sub insertarTelefono(ByVal id As Int32, ByVal telefono As Telefono, ByVal tabla As String)
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim conexion As New ConexionBaseDeDatos
        Try
            con = conexion.conectar
            comando.Connection = con
            comando.CommandText = "insertarTelefono"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", id)
            comando.Parameters.AddWithValue("_nombre", telefono.Nombre1)
            comando.Parameters.AddWithValue("_telefono", telefono.Telefono1)
            comando.Parameters.AddWithValue("_nombreTabla", tabla)
            con.Open()
            comando.ExecuteNonQuery()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()

        End Try
    End Sub
End Class
