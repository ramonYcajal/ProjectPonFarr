Public Class frmEditarProveedor
    Dim controlador As New ControladorProveedor
    Private Sub frmEditarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaProveedores As New ArrayList
        listaProveedores = controlador.mostrarProveedor(proveedorId)
        cargarProveedor(listaProveedores)
    End Sub
    Private Sub cargarProveedor(ByVal listaProveedor As ArrayList)
        For Each proveedor As Proveedor In listaProveedor
            proveedorId = proveedor.Id1
            txtNombre.Text = proveedor.Nombre1
            txtCif.Text = proveedor.Nif1
            txtPersoCto.Text = proveedor.PersonaContacto1
            txtEmail.Text = proveedor.Email1
            txtObservaciones.Text = proveedor.Observaciones1
            txtDomicilio.Text = proveedor.Domicilio1
            txtPoblacion.Text = proveedor.Poblacion1
            txtProvincia.Text = proveedor.Provincia1
            txtTelef1.Text = proveedor.Telef11
            txtTelef2.Text = proveedor.Telef21
            txtCP.Text = proveedor.Codpos1
        Next

    End Sub
    Private Sub actualizarProveedor()
        Dim proveedorAux As New Proveedor
        proveedorAux.Id1 = proveedorId
        proveedorAux.Nombre1 = txtNombre.Text
        proveedorAux.Nif1 = txtCif.Text
        proveedorAux.PersonaContacto1 = txtPersoCto.Text
        proveedorAux.Email1 = txtEmail.Text
        proveedorAux.Observaciones1 = txtObservaciones.Text
        proveedorAux.Domicilio1 = txtDomicilio.Text
        proveedorAux.Poblacion1 = txtPoblacion.Text
        proveedorAux.Provincia1 = txtProvincia.Text
        proveedorAux.Telef11 = txtTelef1.Text
        proveedorAux.Telef21 = txtTelef2.Text
        proveedorAux.Codpos1 = txtCP.Text
        controlador.actualizar(proveedorAux)
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
        actualizarProveedor()
    End Sub
End Class