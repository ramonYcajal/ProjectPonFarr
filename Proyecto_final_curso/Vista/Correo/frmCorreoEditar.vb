Public Class frmCorreoEditar
    Private Sub frmCorreoEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub
    Private Sub imgDRPAceptar_MouseDown(sender As Object, e As MouseEventArgs) Handles imgDRPAceptar.MouseDown
        DataRepeater1.CurrentItem.Controls(imgDRPAceptar.Name).Visible = False
    End Sub
    Private Sub imgDRPAceptar_MouseUp(sender As Object, e As MouseEventArgs) Handles imgDRPAceptar.MouseUp
        DataRepeater1.CurrentItem.Controls(imgDRPAceptar.Name).Visible = True
        Dim subcuenta As New Subcuenta
        Dim controlador As New ControladorSubcuenta
        subcuenta.Id1 = DataRepeater1.CurrentItem.Controls(lblDRPlIdSubcuenta.Name).Text
        subcuenta.Direccion1 = DataRepeater1.CurrentItem.Controls(txtDRPDireccionCorreo.Name).Text
        subcuenta.Usuario1 = DataRepeater1.CurrentItem.Controls(txtDRPUsuario.Name).Text
        subcuenta.Ubicacion1 = DataRepeater1.CurrentItem.Controls(txtDRPUbicacion.Name).Text
        subcuenta.Contrasena1 = DataRepeater1.CurrentItem.Controls(txtDRPContrasena.Name).Text
        controlador.actualizarSubcuenta(subcuenta)
        cargarDatos()
    End Sub

    Private Sub imgDRPBorrar_MouseDown(sender As Object, e As MouseEventArgs) Handles imgDRPBorrar.MouseDown
        DataRepeater1.CurrentItem.Controls(imgDRPBorrar.Name).Visible = False
    End Sub
    Private Sub imgDRPBorrar_MouseUp(sender As Object, e As MouseEventArgs) Handles imgDRPBorrar.MouseUp
        DataRepeater1.CurrentItem.Controls(imgDRPBorrar.Name).Visible = True
        Dim id As Int32
        Dim controlador As New ControladorSubcuenta
        DataRepeater1.CurrentItem.Controls(imgDRPBorrar.Name).Visible = True
        id = DataRepeater1.CurrentItem.Controls(lblDRPlIdSubcuenta.Name).Text
        controlador.eliminarSubcuenta(id)
        cargarDatos()
    End Sub

    Private Sub imgImprimirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgImprimirGrande.MouseDown
        imgImprimirGrande.Visible = False
    End Sub
    Private Sub imgImprimirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgImprimirGrande.MouseUp
        imgImprimirGrande.Visible = True
        informeCorreo.Show()
    End Sub

    Private Sub cargarDatos()
        Dim controlador As New ControladorCorreo
        Dim listaCorreos As New ArrayList
        listaCorreos = controlador.mostrarCorreo(correoId)
        For Each correo As Correo In listaCorreos
            txtProveedor.Text = correo.Proveedor1
            txtCliente.Text = correo.Nombre1
            txtDireccionCorreo.Text = correo.DireccionCorreo1

            txtNombreCuenta.Text = correo.NombreCUentaConexions1
            txtContrasena.Text = correo.Contrasena1
            txtCorreoSaliente.Text = correo.ServidorCorreoSaliente1
            txtCorreoEntrante.Text = correo.ServidorCorreoEntrante1
            txtObservaciones.Text = correo.Observaciones1
            txtSubdominio.Text = correo.Subdominio1
            txtUsuarioGestion.Text = correo.UsuarioGestion1
            txtContrasenaGestion.Text = correo.ContrasenaGestion1
            txtWebGestion.Text = correo.WebGestion1
            DataRepeater1.DataSource = correo.Subcuentas1
            'la variable listaSubcuentas está declarada en el módulo de variables y métodos
            'Y la uso para mandarsela al reporte de red para que imprima todos
            'las cuentas de un correo con dominio de una empresa concreta
            listaSubcuentas = correo.Subcuentas1
        Next
    End Sub

    Private Sub imgAgregarSubcuenta_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAgregarSubcuenta.MouseDown
        imgAgregarSubcuenta.Visible = False
    End Sub
    Private Sub imgAgregarSubcuenta_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAgregarSubcuenta.MouseUp
        imgAgregarSubcuenta.Visible = True
        Dim subcuenta As New Subcuenta
        Dim controlador As New ControladorSubcuenta
        subcuenta.Idcorreo1 = correoId
        subcuenta.Ubicacion1 = txtLocalizacionPC.Text
        subcuenta.Usuario1 = txtUsuario.Text
        subcuenta.Contrasena1 = txtContrasenaSubcuenta.Text
        subcuenta.Direccion1 = txtCorreoSubcuenta.Text
        controlador.insertarSubcuenta(subcuenta)
        cargarDatos()
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

    Private Sub CorreoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorreosToolStripMenuItem.Click
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

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
    End Sub
End Class