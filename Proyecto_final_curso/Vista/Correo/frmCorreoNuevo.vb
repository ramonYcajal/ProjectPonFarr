Public Class frmCorreoNuevo
    Dim listaSubcuentas As New ArrayList
    Dim listaVacia As New ArrayList
    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        Dim vacio As Boolean
        vacio = isEmpty(Me)
        If (vacio = False) Then
            Dim correo As New Correo
            Dim controlador As New ControladorCorreo
            correo.Proveedor1 = txtProveedor.Text
            correo.Idusuario1 = txtNombreCuenta.Text
            correo.Nombre1 = txtCliente.Text
            correo.DireccionCorreo1 = txtDireccionCorreo.Text
            correo.UsuarioConexion1 = txtNombreCuenta.Text
            correo.NombreCUentaConexions1 = txtNombreCuenta.Text
            correo.Contrasena1 = txtContrasena.Text
            correo.ServidorCorreoEntrante1 = txtCorreoEntrante.Text
            correo.ServidorCorreoSaliente1 = txtCorreoSaliente.Text
            correo.Observaciones1 = txtObservaciones.Text
            correo.Subdominio1 = txtSubdominio.Text
            correo.UsuarioGestion1 = txtUsuarioGestion.Text
            correo.ContrasenaGestion1 = txtContrasenaGestion.Text
            correo.WebGestion1 = txtWebGestion.Text
            correo.Subcuentas1 = listaSubcuentas
            controlador.insertarCorreo(correo)
            Dim formulario As New Form
            formulario = Me
            For Each control As Control In formulario.Controls
                If (TypeOf (control) Is Panel) Then
                    vaciar(control)
                End If
            Next
        End If

    End Sub

    Private Sub imgAgregarSubcuenta_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAgregarSubcuenta.MouseDown
        imgAgregarSubcuenta.Visible = False
    End Sub
    Private Sub imgAgregarSubcuenta_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAgregarSubcuenta.MouseUp
        imgAgregarSubcuenta.Visible = True
        DataRepeater1.DataSource = listaVacia
        Dim subcuenta As New Subcuenta
        subcuenta.Direccion1 = txtCorreoSubcuenta.Text
        subcuenta.Usuario1 = txtUsuario.Text
        subcuenta.Contrasena1 = txtContrasenaSubcuenta.Text
        subcuenta.Ubicacion1 = txtLocalizacionPC.Text
        listaSubcuentas.Add(subcuenta)
        DataRepeater1.DataSource = listaSubcuentas
        vaciar(panelSubcuenta)
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        frmSalir.Show()
    End Sub

    Private Sub GestionarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarAplicaciónToolStripMenuItem.Click
        deshabilitar()
        frmLogin.Show()
    End Sub

    Private Sub CuadernoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadernoDeBitácoraToolStripMenuItem.Click
        Me.Close()
        frmCuaderno.Show()
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

    Private Sub PartesDeTabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartesDeTrabajoToolStripMenuItem.Click
        Me.Close()
        frmPartes.Show()
    End Sub
End Class