Public Class frmEditarRed
    Private Sub frmEditarRed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRed()
    End Sub
    Private Sub cargarRed()
        Dim controlador As New ControladorRed
        Dim listaRed As New ArrayList
        listaRed = controlador.mostrarRed(redId)
        For Each red As Red In listaRed
            txtCliente.Text = red.Cliente1
            txtServidorNom.Text = red.NombreServidor1
            txtServidorIP.Text = red.ServidorIp1
            txtGrupoTrabajo.Text = red.Grupo1
            txtRouterIP.Text = red.Router1
            txtDNS1.Text = red.Dns11
            txtDNS2.Text = red.Dns21
            txtServidorMask.Text = red.Mascara1
            txtRouterUser.Text = red.UsuarioRouter1
            txtRouterPWD.Text = red.ContrasenaRouter1
            DataRepeater1.DataSource = red.ArrayPuestos1
            'la variable listaPuestos está declarada en el módulo de variables y métodos
            'Y la uso para mandarsela al reporte de red para que imprima todos
            'los puestos de una red concreta
            listaPuestos = red.ArrayPuestos1
        Next
    End Sub

    Private Sub imgDRPAceptar_MouseDown(sender As Object, e As MouseEventArgs) Handles imgDRPAceptar.MouseDown
        DataRepeater1.CurrentItem.Controls(imgDRPAceptar.Name).Visible = False
    End Sub
    Private Sub imgDRPAceptar_MouseUp(sender As Object, e As MouseEventArgs) Handles imgDRPAceptar.MouseUp
        DataRepeater1.CurrentItem.Controls(imgDRPAceptar.Name).Visible = True
        Dim controlador As New ControladorPuesto
        Dim puesto As New Puesto
        puesto.Id1 = DataRepeater1.CurrentItem.Controls(lblId.Name).Text
        puesto.Localizacion1 = DataRepeater1.CurrentItem.Controls(txtLocalizacion.Name).Text
        puesto.NombrePc1 = DataRepeater1.CurrentItem.Controls(txtPCNombre.Name).Text
        puesto.Usuario1 = DataRepeater1.CurrentItem.Controls(txtUsuarioPC.Name).Text
        puesto.Ip1 = DataRepeater1.CurrentItem.Controls(txtIPPC.Name).Text
        puesto.SistemaOperativo1 = DataRepeater1.CurrentItem.Controls(txtSOPC.Name).Text
        puesto.Contrasena1 = DataRepeater1.CurrentItem.Controls(txtPWDPC.Name).Text
        controlador.actualizarPuesto(puesto)
        cargarRed()
    End Sub

    Private Sub imgDRPBorrar_MouseDown(sender As Object, e As MouseEventArgs) Handles imgDRPBorrar.MouseDown
        DataRepeater1.CurrentItem.Controls(imgDRPBorrar.Name).Visible = False
    End Sub
    Private Sub imgDRPBorrar_MouseUp(sender As Object, e As MouseEventArgs) Handles imgDRPBorrar.MouseUp
        Dim id As Int32
        Dim controlador As New ControladorPuesto
        DataRepeater1.CurrentItem.Controls(imgDRPBorrar.Name).Visible = True
        id = DataRepeater1.CurrentItem.Controls(lblId.Name).Text
        controlador.eliminarPuesto(id)
        cargarRed()
    End Sub
    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False
    End Sub

    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        Dim controlador As New ControladorRed
        Dim red As New Red
        red.Id1 = redId
        red.Cliente1 = txtCliente.Text
        red.NombreServidor1 = txtServidorNom.Text
        red.ServidorIp1 = txtServidorIP.Text
        red.Grupo1 = txtGrupoTrabajo.Text
        red.Router1 = txtRouterIP.Text
        red.Dns11 = txtDNS1.Text
        red.Dns21 = txtDNS2.Text
        red.Mascara1 = txtServidorMask.Text
        red.UsuarioRouter1 = txtRouterUser.Text
        red.ContrasenaRouter1 = txtRouterPWD.Text
        controlador.actualizarRed(red)
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_Mouseup(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Me.Close()
    End Sub

    Private Sub imgAgregarPuesto_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAgregarPuesto.MouseDown
        imgAgregarPuesto.Visible = False
    End Sub
    Private Sub imgAgregarPuesto_Mouseup(sender As Object, e As MouseEventArgs) Handles imgAgregarPuesto.MouseUp
        imgAgregarPuesto.Visible = True
        Dim vacio As Boolean
        vacio = isEmpty(panelPuesto)
        If (vacio = False) Then
            Dim controlador As New ControladorPuesto
            Dim puesto As New Puesto
            puesto.Idred1 = redId
            puesto.Localizacion1 = txtLocalizacionPC.Text
            puesto.NombrePc1 = txtNombrePC.Text
            puesto.Usuario1 = txtPCUsuario.Text
            puesto.Ip1 = txtPCIP.Text
            puesto.SistemaOperativo1 = txtSistemaOpe.Text
            puesto.Contrasena1 = txtContrasena.Text
            controlador.insertarPuesto(Puesto)
            cargarRed()
            vaciar(panelPuesto)
        End If
    End Sub

    Private Sub imgImprimirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgImprimirGrande.MouseDown
        imgImprimirGrande.Visible = False
    End Sub
    Private Sub imgImprimirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgImprimirGrande.MouseUp
        imgImprimirGrande.Visible = True
        informeRed.Show()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        frmSalir.Show()
    End Sub

    Private Sub GestionarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarAplicaciónToolStripMenuItem.Click
        deshabilitar()
        frmLogin.Show()
    End Sub

    Private Sub CuadernoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadernoToolStripMenuItem.Click
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

    Private Sub PartesDeTabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParteToolStripMenuItem.Click
        Me.Close()
        frmPartes.Show()
    End Sub
End Class