Imports MySql.Data.MySqlClient
Public Class ControladorParte
    Public Sub New()

    End Sub
    Public Sub insertar(ByVal parte As ParteTrabajo)
        Dim con As New MySqlConnection
        Dim conexion As New ConexionBaseDeDatos
        Dim comando As New MySqlCommand
        Try
            con = conexion.conectar()
            comando.Connection = con
            comando.CommandText = "insertarParte"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_fechaEntrada", parte.FechaEntrada1)
            comando.Parameters.AddWithValue("_cliente", parte.Cliente1)
            comando.Parameters.AddWithValue("_telefono", parte.Telefono1)
            comando.Parameters.AddWithValue("_problema", parte.Problema1)
            comando.Parameters.AddWithValue("_producto", parte.Producto1)
            comando.Parameters.AddWithValue("_numSerie", parte.NumeroSerie1)
            con.Open()
            comando.ExecuteNonQuery()
            mensaje = "Parte agregado"
            frmAdvertencia.Show()
            conexion.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Function mostrarPartes() As ArrayList
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim listaPartes As New ArrayList
        Dim lector As MySqlDataReader
        Dim controlador As New ConexionBaseDeDatos
        Try
            con = controlador.conectar
            comando.Connection = con
            comando.CommandText = "mostrarPartes"
            comando.CommandType = CommandType.StoredProcedure
            con.Open()
            lector = comando.ExecuteReader
            listaPartes = cargarArrayPartes(lector)
            controlador.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaPartes
    End Function
    Private Function cargarArrayPartes(ByVal lector As MySqlDataReader) As ArrayList
        Dim listaPartes As New ArrayList
        If lector.HasRows Then
            Do While lector.Read
                'uso la sobrecarga de los constructores
                Dim parte As New ParteTrabajo(lector.GetInt32(0), lector.GetString(1), lector.GetString(4), lector.GetString(5),
                      lector.GetString(6), lector.GetString(8), lector.GetString(9))
                listaPartes.Add(parte)

            Loop
        End If
        Return listaPartes
    End Function
End Class
