Imports MySql.Data.MySqlClient
Public Class ConexionBaseDeDatos
    Private conexion As String
    Private conn As MySqlConnection
    'constructor por defecto
    Public Sub New()

    End Sub

    ' función que conecta con la base de datos y devuelve una variable de tipo mysqlconnection
    Public Function conectar() As MySqlConnection
        Try
            conexion = "Server=localhost;database=gestion;Uid=root;Pwd="
            conn = New MySqlConnection(conexion)
            Return conn
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        End Try
    End Function
    'función que recibe una variable de tipo mysqlconnection y se desconecta de la base de datos
    'después de desconectar, el método dispose libera los posibles residuos que queden
    Public Sub desconectar(ByVal conexion As MySqlConnection)
        Try
            conexion.Close()
        Catch ex As Exception
            mensaje = ex.Message
            frmAdvertencia.Show()
        Finally
            conexion.Dispose()
        End Try
    End Sub
End Class
