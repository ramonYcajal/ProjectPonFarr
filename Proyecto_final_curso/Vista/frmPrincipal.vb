Imports MySql.Data.MySqlClient
Imports System.Threading


Public Class frmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' esto arranca el servidor de xampp'
        'appwinstyle.hide, lo que hace es ocultar la ventana de msdos para que el usuario no la vea
        'Shell("c:\xampp\mysql_start.bat", AppWinStyle.Hide)
        'comprobar()

    End Sub
    'Private Sub comprobar()

    '    'se va a modificar todo, en vez de comprobar un archivo, comprobará si existe la base de datos
    '    ' si no existe, la creará con todos sus procedimientos almacenados y demás mierdas
    '    Dim conn As New MySqlConnection
    '    conn.ConnectionString = "server=localhost;;uid=root;pwd="
    '    Dim cmd As MySqlCommand = New MySqlCommand("SELECT IF(EXISTS (SELECT SCHEMA_NAME " &
    '    "FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'gestion'), 'Y','N')", conn)
    '    conn.Open()
    '    Dim exists As String = cmd.ExecuteScalar().ToString()
    '    conn.Close()

    '    If exists.Equals("N") Then
    '        Me.WindowState = FormWindowState.Minimized
    '        frmBarraDeProgreso.Show()
    '        'Dim hilo As Thread
    '        'hilo = New Thread(AddressOf tarea)
    '        'hilo.IsBackground = True
    '        'hilo.Start()
    '    End If
    'End Sub
    'Private Sub tarea()
    '    Dim conductor As BaseDeDatos
    '    conductor = New BaseDeDatos

    '    mensaje = "Es la primera vez que me ejecutas, necesito un tiempo para crear todo el sistema, gracias"
    '    mensaje = "voy a crear la base de datos..."
    '    conductor.CrearBaseDeDatos()
    '    mensaje = "base de datos creada, creando árbol de tablas y procedimientos..."
    '    conductor.crearTablas()
    '    conductor.crearStoredProcedures()
    '    mensaje = "Ya puedes comenzar a utilizar PON FARR"

    'End Sub

    Private Sub imgTecnicoGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgTecnicoGrande.MouseDown
        imgTecnicoGrande.Visible = False

    End Sub
    Private Sub imgTecnicoGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgTecnicoGrande.MouseUp
        imgTecnicoGrande.Visible = True
        frmPartes.Show()
    End Sub

    Private Sub imgdineroGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgdineroGrande.MouseDown
        imgdineroGrande.Visible = False
    End Sub
    Private Sub imgdineroGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgdineroGrande.MouseUp
        imgdineroGrande.Visible = True
        frmClientes.Show()
    End Sub

    Private Sub imgEngranajeGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgEngranajeGrande.MouseDown
        imgEngranajeGrande.Visible = False
    End Sub
    Private Sub imgEngranajeGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgEngranajeGrande.MouseUp
        imgEngranajeGrande.Visible = True
        deshabilitar()
        frmLogin.Show()
    End Sub

    Private Sub imgCuadernoGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgCuadernoGrande.MouseDown
        imgCuadernoGrande.Visible = False
    End Sub
    Private Sub imgCuadernoGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgCuadernoGrande.MouseUp
        imgCuadernoGrande.Visible = True
        frmCuaderno.Show()
    End Sub

    Private Sub imgProveedorGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgProveedorGrande.MouseDown
        imgProveedorGrande.Visible = False
    End Sub
    Private Sub imgProveedorGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgProveedorGrande.MouseUp
        imgProveedorGrande.Visible = True
        frmProveedores.Show()
    End Sub

    Private Sub imgLanGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgLanGrande.MouseDown
        imgLanGrande.Visible = False
    End Sub
    Private Sub imgLanGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgLanGrande.MouseUp
        imgLanGrande.Visible = True
        frmRedes.Show()
    End Sub

    Private Sub imgBuzonGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgBuzonGrande.MouseDown
        imgBuzonGrande.Visible = False
    End Sub
    Private Sub imgBuzonGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgBuzonGrande.MouseUp
        imgBuzonGrande.Visible = True
        frmCorreos.Show()
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        frmSalir.Show()
    End Sub

    Private Sub imgDespliegaAbajo_Click(sender As Object, e As EventArgs) Handles imgDespliegaAbajo.Click
        TimerBajar.Start()
    End Sub

    Private Sub imgFlechaArriba_Click(sender As Object, e As EventArgs) Handles imgFlechaArriba.Click
        timerSubir.Start()
    End Sub

    Private Sub TimerBajar_Tick(sender As Object, e As EventArgs) Handles TimerBajar.Tick
        Dim i As Integer
        For i = -640 To 0 Step 1
            panelMenu.Top = i
            If i = 0 Then
                imgFlechaArriba.Visible = True
                TimerBajar.Stop()
            End If
        Next
    End Sub

    Private Sub timerSubir_Tick(sender As Object, e As EventArgs) Handles timerSubir.Tick
        Dim i As Integer
        For i = 0 To -640 Step -1
            panelMenu.Top = i
            If i = -640 Then
                imgFlechaArriba.Visible = False
                timerSubir.Stop()
            End If
        Next
    End Sub

    Private Sub imgInfoGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgInfoGrande.MouseDown
        imgInfoGrande.Visible = False

    End Sub
    Private Sub imgInfoGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgInfoGrande.MouseUp
        imgInfoGrande.Visible = True
        frmAcercaDe.Show()

    End Sub

End Class


