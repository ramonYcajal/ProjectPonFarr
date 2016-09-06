Imports MySql.Data.MySqlClient
Public Class BaseDeDatos
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Public Sub New()

    End Sub
    Sub CrearBaseDeDatos()
        Try
            Dim cadena As String
            Dim sentencia As String
            sentencia = "create database gestion"
            cadena = "server=localhost;;uid=root;pwd="
            conexion = New MySqlConnection(cadena)
            conexion.Open()
            comando = New MySqlCommand(sentencia, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Dispose()
        End Try
    End Sub
    Sub crearTablas()
        'guardar todo el rollo en el strig funciona, pero lo suyo es que esto se guarde en un
        'fichero , que el fichero luego se lea y se vaya añadiendo todo en el string
        ' y luego pasar el string por la conexión a que cree las tablas.

        Dim fichero As IO.StreamReader
        fichero = IO.File.OpenText("gestion.sql")
        Dim str As String
        str = ""
        Do Until fichero.Peek = -1
            str = str + fichero.ReadLine
        Loop
        fichero.Close()
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Dispose()
        End Try
    End Sub
End Class
