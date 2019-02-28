Public Class frmRedNueva
    Dim listaPuestos As New ArrayList
    Dim listaVacia As New ArrayList
    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False

    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Close()

    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        Dim controlador As New ControladorRed
        Dim red As New Red
        red.Cliente1 = txtCliente.Text
        red.NombreServidor1 = txtServidorNom.Text
        red.ServidorIp1 = txtServidorIP.Text
        red.Grupo1 = txtGrupoTrabajo.Text
        red.Router1 = txtRouterIP.Text
        red.Dns11 = txtDNS1.Text
        red.Dns21 = txtDNS2.Text
        red.UsuarioRouter1 = txtRouterUser.Text
        red.ContrasenaRouter1 = txtRouterPWD.Text
        red.Mascara1 = txtServidorMask.Text
        red.ArrayPuestos1 = listaPuestos
        controlador.insertar(red)
        Dim formulario As New Form
        formulario = Me
        For Each control As Control In formulario.Controls
            If (TypeOf (control) Is Panel) Then
                vaciar(control)
            End If
        Next
    End Sub

    Private Sub imgAgregarPuesto_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAgregarPuesto.MouseDown
        imgAgregarPuesto.Visible = False
    End Sub
    Private Sub imgAgregarPuesto_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAgregarPuesto.MouseUp
        imgAgregarPuesto.Visible = True
        DataRepeater1.DataSource = listaVacia
        Dim puesto As New Puesto
        puesto.Localizacion1 = txtLocalizacionPC.Text
        puesto.NombrePc1 = txtNombrePC.Text
        puesto.Usuario1 = txtPCUsuario.Text
        puesto.Ip1 = txtPCIP.Text
        puesto.SistemaOperativo1 = txtSistemaOpe.Text
        puesto.Contrasena1 = txtContrasena.Text
        listaPuestos.Add(puesto)
        DataRepeater1.DataSource = listaPuestos
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        frmSalir.Show()
    End Sub

    Private Sub GestionarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarAplicaciónToolStripMenuItem.Click
        deshabilitar()
        frmLogin.Show()
    End Sub

    Private Sub CuadernoDeBitácoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadernoDeBitácoraToolStripMenuItem.Click
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