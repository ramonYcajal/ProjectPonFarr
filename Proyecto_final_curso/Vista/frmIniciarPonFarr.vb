Imports MySql.Data.MySqlClient
Public Class frmIniciarPonFarr
    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        Dim admin As New Administracion
        Dim control As New ControladorLogin
        Dim log As New ArrayList
        admin.Usuario1 = txtUsuario.Text
        admin.Contrasena1 = txtPwd.Text
        log = control.isLogged(admin)
        If log.Item(0) <> 1 Then
            mensaje = "Error; usuario y/o contraseña incorrectos"
            frmAdvertencia.Show()
        Else
            rol = log.Item(1)
            frmPrincipal.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub frmIniciarPonFarr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' esto arranca el servidor de xampp'
        'appwinstyle.hide, lo que hace es ocultar la ventana de msdos para que el usuario no la vea
        Shell("c:\xampp\mysql_start.bat", AppWinStyle.Hide)
        comprobar()
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False

    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        'al salir, detengo el servidor mysql. todo totalmente transparente al usuario
        Shell("c:\xampp\mysql_stop.bat", AppWinStyle.Hide)
        Application.Exit()
    End Sub
    Private Sub comprobar()

        'se va a modificar todo, en vez de comprobar un archivo, comprobará si existe la base de datos
        ' si no existe, la creará con todos sus procedimientos almacenados y demás mierdas
        Dim conn As New MySqlConnection
        conn.ConnectionString = "server=localhost;;uid=root;pwd="
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT IF(EXISTS (SELECT SCHEMA_NAME " &
        "FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'gestion'), 'Y','N')", conn)
        conn.Open()
        Dim exists As String = cmd.ExecuteScalar().ToString()
        conn.Close()

        If exists.Equals("N") Then
            Me.WindowState = FormWindowState.Minimized
            frmBarraDeProgreso.Show()
            'Dim hilo As Thread
            'hilo = New Thread(AddressOf tarea)
            'hilo.IsBackground = True
            'hilo.Start()
        End If
    End Sub
End Class