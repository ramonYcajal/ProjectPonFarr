Public Class frmEditarCliente
    Dim controlador As New ControladorCliente
    Private Sub frmEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim listaClientes As New ArrayList
        listaClientes = controlador.mostrarCliente(clienteId)
        cargarCliente(listaClientes)
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
            txtTelef1.Text = cliente.Telef11
            txtTelef2.Text = cliente.Telef21
        Next

    End Sub
    Private Sub actualizarCliente()
        Dim clienteUpdate As New Cliente
        'cargo el contenido de los textbox en un objeto de tipo cliente
        clienteUpdate.Id1 = clienteId
        clienteUpdate.Nif1 = txtCif.Text
        clienteUpdate.Nombre1 = txtNombre.Text
        clienteUpdate.Observaciones1 = txtObservaciones.Text
        clienteUpdate.PersonaContacto1 = txtPersoCto.Text
        clienteUpdate.Poblacion1 = txtPoblacion.Text
        clienteUpdate.Provincia1 = txtProvincia.Text
        clienteUpdate.Telef11 = txtTelef1.Text
        clienteUpdate.Telef21 = txtTelef2.Text
        clienteUpdate.Codpos1 = txtCP.Text
        clienteUpdate.Domicilio1 = txtDomicilio.Text
        clienteUpdate.Email1 = txtEmail.Text
        'lanzo el objeto de tipo cliente al método actualizar de la clase controladorCliente
        controlador.actualizar(clienteUpdate)
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
End Class