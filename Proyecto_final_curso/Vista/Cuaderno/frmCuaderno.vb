Public Class frmCuaderno
    Private Sub imgAgregarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAgregarGrande.MouseDown
        imgAgregarGrande.Visible = False
    End Sub
    Private Sub imgAgregarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAgregarGrande.MouseUp
        imgAgregarGrande.Visible = True
        frmCuadernoNuevaIncidencia.Show()
        'Me.Close()
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Me.Close()
    End Sub

    Private Sub frmCuaderno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListaCuaderno()
        cargarUsuarios()
        cargarIncidencias()

    End Sub

    Private Sub imgModificarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgModificarGrande.MouseDown
        DataRepeater1.CurrentItem.Controls("imgModificarGrande").Visible = False
    End Sub
    Private Sub imgModificarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgModificarGrande.MouseUp
        DataRepeater1.CurrentItem.Controls("imgModificarGrande").Visible = True
        cuadernoId = DataRepeater1.CurrentItem.Controls("lblId").Text
        frmCuadernoEditarIncidencia.Show()
        'Me.Close()
    End Sub

    Private Sub imgFiltrarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgFiltrarGrande.MouseDown
        imgFiltrarGrande.Visible = False
    End Sub
    Private Sub imgFiltrarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgFiltrarGrande.MouseUp
        imgFiltrarGrande.Visible = True
        Dim cliente As String = txtCliente.Text
        Dim persona As String = cmbUsuario.SelectedItem
        Dim resuelto As String = cmbEstadoIncidencia.SelectedItem
        Dim listaCuaderno As New ArrayList
        Dim controlador As New ControladorCuaderno
        If cliente = "" And persona = "" And resuelto = "" Then
            cargarListaCuaderno()

        Else
            cliente = "%" + txtCliente.Text + "%"
            persona = cmbUsuario.SelectedItem
            resuelto = cmbEstadoIncidencia.SelectedItem
            listaCuaderno = controlador.filtrar(persona, resuelto, cliente)
            DataRepeater1.DataSource = listaCuaderno
            vaciar(Me)
        End If
    End Sub
    Private Sub cargarListaCuaderno()
        Dim listaCuaderno As New ArrayList
        Dim controlador As New ControladorCuaderno
        listaCuaderno = controlador.mostrarCuaderno()
        DataRepeater1.DataSource = listaCuaderno
    End Sub
    Private Sub cargarUsuarios()
        Dim listaUsuario As New ArrayList
        Dim controlador As New ControladorCuaderno
        listaUsuario = controlador.mostrarUsuariosCuaderno()
        For Each usuario In listaUsuario
            cmbUsuario.Items.Add(usuario.ToString)
        Next
    End Sub
    Private Sub cargarIncidencias()
        Dim listaIncidencias As New ArrayList
        Dim controlador As New ControladorIncidencia
        listaIncidencias = controlador.mostrarIncidencias()
        For Each incidencia As Incidencia In listaIncidencias
            cmbEstadoIncidencia.Items.Add(incidencia.EstadoIncidencia1)
        Next
    End Sub
    ' esto sirve para cambiar los colores de los controles o lo que quiersa hacer
    ' yo lo uso para poner distintos colores a los estados de las incidencias
    'resuelta en azul
    'no resuelta en rojo
    'en trámite en blanco
    'es uno de los eventos que están disponibles para el control dataRepeater
    Private Sub DataRepeater1_DrawItem(sender As Object, e As PowerPacks.DataRepeaterItemEventArgs) Handles DataRepeater1.DrawItem
        If e.DataRepeaterItem.Controls(lblEstado.Name).Text = "Resuelta" Then
            e.DataRepeaterItem.Controls(lblEstado.Name).ForeColor = Color.DarkBlue
        End If
        If e.DataRepeaterItem.Controls(lblEstado.Name).Text = "No resuelta" Then
            e.DataRepeaterItem.Controls(lblEstado.Name).ForeColor = Color.DarkRed
        End If
        If e.DataRepeaterItem.Controls(lblEstado.Name).Text = "En trámite" Then
            e.DataRepeaterItem.Controls(lblEstado.Name).ForeColor = Color.Cornsilk
        End If
    End Sub

    Private Sub frmCuaderno_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cargarListaCuaderno()
        'cargarUsuarios()
        'cargarIncidencias()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        frmSalir.Show()
    End Sub

    Private Sub GestionarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarAplicaciónToolStripMenuItem.Click
        deshabilitar()
        frmLogin.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Me.Close()
        frmProveedores.Show()
    End Sub

    Private Sub CorreoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorreoToolStripMenuItem.Click
        Me.Close()
        frmCorreos.Show()
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.Close()
        frmRedes.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.Close()
        frmClientes.Show()
    End Sub

    Private Sub ParteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParteToolStripMenuItem.Click
        Me.Close()
        frmPartes.Show()
    End Sub
End Class