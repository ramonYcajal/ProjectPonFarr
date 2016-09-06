Public Class frmEditarProveedor
    Dim controlador As New ControladorProveedor

    Private Sub frmEditarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarContenido()
    End Sub
    Private Sub cargarContenido()
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
            DataRepeater1.DataSource = proveedor.ArrayTelefonos1
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
        proveedorAux.Codpos1 = txtCP.Text
        controlador.actualizar(proveedorAux)
    End Sub
    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        ' para que sólo pueda teclear numeros
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
        'frmProveedores.Show()
    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        actualizarProveedor()
    End Sub

    Private Sub ImgAgregarTelefonoGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles ImgAgregarTelefonoGrande.MouseDown
        ImgAgregarTelefonoGrande.Visible = False

    End Sub
    Private Sub ImgAgregarTelefonoGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles ImgAgregarTelefonoGrande.MouseUp
        ImgAgregarTelefonoGrande.Visible = True
        ' proveedorId es una variable global declarada en el módulo de todas las variables
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
            controlador.insertarTelefono(proveedorId, telefono, "proveedor")
            'recargo el proveedor en total
            cargarContenido()
        End If

    End Sub

    Private Sub imgDRPAceptar_MouseDown(sender As Object, e As MouseEventArgs) Handles imgDRPAceptar.MouseDown
        DataRepeater1.CurrentItem.Controls(imgDRPAceptar.Name).Visible = False
    End Sub
    Private Sub imgDRPAceptar_MouseUp(sender As Object, e As MouseEventArgs) Handles imgDRPAceptar.MouseUp
        DataRepeater1.CurrentItem.Controls(imgDRPAceptar.Name).Visible = True
        Dim id As Int32
        Dim nombre As String
        Dim telefono As String
        Dim controlador As New ControladorTelefono
        id = DataRepeater1.CurrentItem.Controls(lblDRPId.Name).Text
        nombre = DataRepeater1.CurrentItem.Controls(txtDRPNom.Name).Text
        telefono = DataRepeater1.CurrentItem.Controls(txtDRPTelef.Name).Text
        controlador.actualizarTelefono(id, nombre, telefono, "proveedor")
        cargarContenido()
    End Sub

    Private Sub imgDRPBorrar_MouseDown(sender As Object, e As MouseEventArgs) Handles imgDRPBorrar.MouseDown
        DataRepeater1.CurrentItem.Controls(imgDRPBorrar.Name).Visible = False
    End Sub
    Private Sub imgDRPBorrar_MouseUp(sender As Object, e As MouseEventArgs) Handles imgDRPBorrar.MouseUp
        DataRepeater1.CurrentItem.Controls(imgDRPBorrar.Name).Visible = True
        Dim id As Int32
        id = DataRepeater1.CurrentItem.Controls(lblDRPId.Name).Text
        ' llamo a la funcion de borrar teléfono que la tengo en el controladortelefonos
        Dim controlador As New ControladorTelefono
        controlador.eliminarTelefono(id, "proveedor")
        cargarContenido()
    End Sub
End Class