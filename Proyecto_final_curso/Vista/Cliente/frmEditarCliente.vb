Public Class frmEditarCliente
    Dim controlador As New ControladorCliente

    Private Sub frmEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarContenido()
        desactivar(Me)
        ocultar(Me)
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Me.Close()
    End Sub
    Private Sub cargarCliente(ByVal listaClientes As ArrayList)
        For Each cliente As Cliente In listaClientes
            clienteId = cliente.Id1
            txtCif.Text = cliente.Nif1
            txtCP.Text = cliente.Codpos1
            txtDomicilio.Text = cliente.Domicilio1
            txtEmail.Text = cliente.Email1
            txtNombre.Text = cliente.Nombre1
            txtObservaciones.Text = cliente.Observaciones1
            txtPersoCto.Text = cliente.PersonaContacto1
            txtPoblacion.Text = cliente.Poblacion1
            txtProvincia.Text = cliente.Provincia1
            DataRepeater1.DataSource = cliente.ArrayTelefonos1
        Next

    End Sub
    Private Sub actualizarCliente()
        Dim clienteUpdate As New Cliente
        Dim vacio As Boolean
        vacio = isEmpty(Me)
        If vacio = False Then
            'cargo el contenido de los textbox en un objeto de tipo cliente
            clienteUpdate.Id1 = clienteId
            clienteUpdate.Nif1 = txtCif.Text
            clienteUpdate.Nombre1 = txtNombre.Text
            clienteUpdate.Observaciones1 = txtObservaciones.Text
            clienteUpdate.PersonaContacto1 = txtPersoCto.Text
            clienteUpdate.Poblacion1 = txtPoblacion.Text
            clienteUpdate.Provincia1 = txtProvincia.Text
            clienteUpdate.Codpos1 = txtCP.Text
            clienteUpdate.Domicilio1 = txtDomicilio.Text
            clienteUpdate.Email1 = txtEmail.Text
            'lanzo el objeto de tipo cliente al método actualizar de la clase controladorCliente
            controlador.actualizar(clienteUpdate)
        End If

    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        actualizarCliente()

    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        ' para que solo pueda teclear numeros
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub imgDRPAceptar_MouseDown(sender As Object, e As MouseEventArgs) Handles imgDRPAceptar.MouseDown
        DataRepeater1.CurrentItem.Controls("imgDRPAceptar").Visible = False
    End Sub
    Private Sub imgDRPAceptar_MouseUp(sender As Object, e As MouseEventArgs) Handles imgDRPAceptar.MouseUp
        DataRepeater1.CurrentItem.Controls("imgDRPAceptar").Visible = True
        Dim id As Int32
        Dim nombre As String
        Dim telefono As String
        Dim controlador As New ControladorTelefono
        id = DataRepeater1.CurrentItem.Controls("lblDRPId").Text
        nombre = DataRepeater1.CurrentItem.Controls("txtDRPNom").Text
        telefono = DataRepeater1.CurrentItem.Controls("txtDRPTelef").Text
        controlador.actualizarTelefono(id, nombre, telefono, "cliente")
        cargarContenido()
    End Sub

    Private Sub imgDRPBorrar_MouseDown(sender As Object, e As MouseEventArgs) Handles imgDRPBorrar.MouseDown
        DataRepeater1.CurrentItem.Controls("imgDRPBorrar").Visible = False
    End Sub
    Private Sub imgDRPBorrar_MouseUp(sender As Object, e As MouseEventArgs) Handles imgDRPBorrar.MouseUp
        DataRepeater1.CurrentItem.Controls("imgDRPBorrar").Visible = True
        Dim id As Int32
        id = DataRepeater1.CurrentItem.Controls("lblDRPId").Text
        ' llamo a la funcion de borrar teléfono que la tengo en el controladortelefonos
        Dim controlador As New ControladorTelefono
        controlador.eliminarTelefono(id, "cliente")
        cargarContenido()

    End Sub

    Private Sub imgTelefClienteGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgTelefClienteGrande.MouseDown
        imgTelefClienteGrande.Visible = False
    End Sub
    Private Sub imgTelefClienteGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgTelefClienteGrande.MouseUp
        imgTelefClienteGrande.Visible = True
    End Sub
    'esta funcion me recarga todo el contenido del cliente ante un cambio en la zona de los teléfonos
    Private Sub cargarContenido()
        Dim listaClientes As New ArrayList
        listaClientes = controlador.mostrarCliente(clienteId)
        cargarCliente(listaClientes)
    End Sub

    Private Sub ImgAgregarTelefonoGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles ImgAgregarTelefonoGrande.MouseDown
        ImgAgregarTelefonoGrande.Visible = False

    End Sub
    Private Sub ImgAgregarTelefonoGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles ImgAgregarTelefonoGrande.MouseUp
        ' clienteId es una variable global declarada en el módulo de todas las variables
        'al venir aquí y cargar en cliente específico, toma la id del objeto cliente en el metodo cargar cliente situado más arriba
        ' y es la que usa para almacenarlo en la tabla donde la clave foránea id_cliente
        If txtNom.Text = "" Or txtTlf.Text = "" Then
            mensaje = "Has de rellenar el nombre y el teléfono. "
            frmAdvertencia.Show()
        Else
            ImgAgregarTelefonoGrande.Visible = True
            Dim telefono As New Telefono
            Dim controlador As New ControladorTelefono
            telefono.Nombre1 = txtNom.Text
            telefono.Telefono1 = txtTlf.Text
            controlador.insertarTelefono(clienteId, telefono, "cliente")
            'recargo el cliente en total
            cargarContenido()
        End If
    End Sub

    Private Sub txtCP_Enter(sender As Object, e As EventArgs) Handles txtCP.Enter
        'esta línea lo que hace es que cuando el cursor está en este texbox es decir
        'cuando el foco lo tiene el textbox, entonces lo que hace es borrar el portapapeles
        'que es donde se pone el texto a la hora de copiar y pegar de tal modo que cuando
        'vayas a hacer un control+v , el portapapeles está vacío y no pega nada.
        Clipboard.Clear()
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