﻿Imports MySql.Data.MySqlClient
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
            comando.Parameters.AddWithValue("_fechaSalida", parte.FechaSalida1)
            comando.Parameters.AddWithValue("_tecnico", parte.Tecnico1)
            comando.Parameters.AddWithValue("_solucion", parte.Solucion1)
            comando.Parameters.AddWithValue("_total", parte.totalEuros1)
            comando.Parameters.AddWithValue("_material", parte.Material1)
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
                Dim parte As New ParteTrabajo(lector.GetInt32(0), lector.GetString(1), lector.GetString(2),
                                              lector.GetString(3), lector.GetString(4), lector.GetString(5),
                                             lector.GetString(6), lector.GetString(7), lector.GetString(8),
                                              lector.GetString(9), lector.GetDouble(10), lector.GetString(11))
                listaPartes.Add(parte)

            Loop
        End If
        Return listaPartes
    End Function
    Public Function mostrarParte(ByVal id As Int32) As ArrayList
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim listaPartes As New ArrayList
        Dim lector As MySqlDataReader
        Dim controlador As New ConexionBaseDeDatos
        Try
            con = controlador.conectar
            comando.Connection = con
            comando.CommandText = "mostrarParte"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", id)
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
    Public Sub actualizarParte(ByVal parte As ParteTrabajo)
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim controlador As New ConexionBaseDeDatos
        Try
            con = controlador.conectar
            comando.Connection = con
            comando.CommandText = "actualizarParte"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", parte.Id1)
            comando.Parameters.AddWithValue("_cliente", parte.Cliente1)
            comando.Parameters.AddWithValue("_telefono", parte.Telefono1)
            comando.Parameters.AddWithValue("_problema", parte.Problema1)
            comando.Parameters.AddWithValue("_producto", parte.Producto1)
            comando.Parameters.AddWithValue("_numSerie", parte.NumeroSerie1)
            con.Open()
            comando.ExecuteNonQuery()
            controlador.desconectar(con)
            mensaje = "Parte actualizado"
            frmAdvertencia.Show()
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Sub actualizarYCerrarParte(ByVal parte As ParteTrabajo)
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim controlador As New ConexionBaseDeDatos
        Try
            con = controlador.conectar
            comando.Connection = con
            comando.CommandText = "actualizarYCerrarParte"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", parte.Id1)
            comando.Parameters.AddWithValue("_fechaEntrada", parte.FechaEntrada1)
            comando.Parameters.AddWithValue("_fechaSalida", parte.FechaSalida1)
            comando.Parameters.AddWithValue("_tecnico", parte.Tecnico1)
            comando.Parameters.AddWithValue("_cliente", parte.Cliente1)
            comando.Parameters.AddWithValue("_telefono", parte.Telefono1)
            comando.Parameters.AddWithValue("_problema", parte.Problema1)
            comando.Parameters.AddWithValue("_solucion", parte.Solucion1)
            comando.Parameters.AddWithValue("_producto", parte.Producto1)
            comando.Parameters.AddWithValue("_numSerie", parte.NumeroSerie1)
            comando.Parameters.AddWithValue("_totalEuros", parte.totalEuros1)
            comando.Parameters.AddWithValue("_material", parte.Material1)
            con.Open()
            comando.ExecuteNonQuery()
            controlador.desconectar(con)
            mensaje = "Parte cerrado y actualizado"
            frmAdvertencia.Show()
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
End Class
