Imports MySql.Data.MySqlClient
Public Class ControladorMaterial
    Public Sub New()

    End Sub
    Public Sub insertar(ByVal material As Material)
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim control As New ConexionBaseDeDatos

        Try
            con = control.conectar
            comando.Connection = con
            comando.CommandText = "insertarMaterial"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_material", material.Material1)
            comando.Parameters.AddWithValue("_precio", material.Precio1)
            comando.Parameters.AddWithValue("_pvp", material.pvp1)
            con.Open()
            comando.ExecuteNonQuery()
            mensaje = "Material agregado"
            frmAdvertencia.Show()
            control.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try

    End Sub
    Public Function mostrarMaterial() As ArrayList
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim control As New ConexionBaseDeDatos
        Dim lector As MySqlDataReader
        Dim listaMaterial As New ArrayList
        Try
            con = control.conectar
            comando.Connection = con
            comando.CommandText = "mostrarMaterial"
            comando.CommandType = CommandType.StoredProcedure
            con.Open()
            lector = comando.ExecuteReader
            listaMaterial = cargarArray(lector)
            control.desconectar(con)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaMaterial

    End Function
    Private Function cargarArray(ByVal lector As MySqlDataReader) As ArrayList
        Dim listaMaterial As New ArrayList
        If lector.HasRows Then
            Do While lector.Read
                Dim material As New Material
                material.Id1 = lector.GetInt32(0)
                Material.Material1 = lector.GetString(1)
                Material.Precio1 = lector.GetDouble(2)
                Material.pvp1 = lector.GetDouble(3)
                listaMaterial.Add(Material)
            Loop
        End If
        Return listaMaterial
    End Function
    Public Function filtrarMaterial(ByVal material As String) As ArrayList
        Dim controlador As New ConexionBaseDeDatos
        Dim lector As MySqlDataReader
        Dim conexion As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim listaMaterial As New ArrayList
        Try
            conexion = controlador.conectar
            comando.Connection = conexion
            comando.CommandText = "filtrarMaterial"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_material", material)
            conexion.Open()
            lector = comando.ExecuteReader
            listaMaterial = cargarArray(lector)
            controlador.desconectar(conexion)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
        Return listaMaterial
    End Function
    Public Sub actualizarMaterial(ByVal material As Material)
        Dim controlador As New ConexionBaseDeDatos
        Dim conexion As New MySqlConnection
        Dim comando As New MySqlCommand
        Try
            conexion = controlador.conectar
            comando.Connection = conexion
            comando.CommandText = "actualizarMaterial"
            comando.Parameters.AddWithValue("_id", material.Id1)
            comando.Parameters.AddWithValue("_material", material.Material1)
            comando.Parameters.AddWithValue("_precio", material.Precio1)
            comando.Parameters.AddWithValue("_pvp", material.pvp1)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()
            comando.ExecuteNonQuery()
            mensaje = "Registro actualizado"
            frmAdvertencia.Show()
            controlador.desconectar(conexion)
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
    Public Sub eliminarMaterial(ByVal id As Integer)
        Dim controlador As New ConexionBaseDeDatos
        Dim conexion As New MySqlConnection
        Dim comando As New MySqlCommand
        Try
            conexion = controlador.conectar
            comando.Connection = conexion
            comando.CommandText = "eliminarMaterial"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("_id", id)
            conexion.Open()
            comando.ExecuteNonQuery()
            controlador.desconectar(conexion)
            mensaje = "Material eliminado"
            frmAdvertencia.Show()
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Sub
End Class
