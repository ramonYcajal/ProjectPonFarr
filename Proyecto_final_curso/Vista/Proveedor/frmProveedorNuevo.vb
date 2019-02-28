Public Class frmProveedorNuevo
    Private listaTelefonos As New ArrayList
    Private lista As New ArrayList
    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False

    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        Dim vacio As Boolean
        imgAceptarGrande.Visible = True
        vacio = isEmpty(Me)
        If vacio = False Then
            Dim provee As New Proveedor
            Dim control As New ControladorProveedor
            provee.Nombre1 = txtNombre.Text
            provee.Nif1 = txtCif.Text
            provee.PersonaContacto1 = txtPersoCto.Text
            provee.Email1 = txtEmail.Text
            provee.Observaciones1 = txtObservaciones.Text
            provee.Domicilio1 = txtDomicilio.Text
            provee.Poblacion1 = txtPoblacion.Text
            provee.Provincia1 = txtProvincia.Text
            provee.ArrayTelefonos1 = listaTelefonos
            provee.Codpos1 = txtCP.Text
            control.insertar(provee)
            vaciar(Me)
            listaTelefonos.Clear()
            DataRepeater1.DataSource = lista
        End If
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = False
        Me.Close()
        ' frmProveedores.Show()
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

    Private Sub imgTelefClienteGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgTelefClienteGrande.MouseDown
        imgTelefClienteGrande.Visible = False
    End Sub
    Private Sub imgTelefClienteGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgTelefClienteGrande.MouseUp
        imgTelefClienteGrande.Visible = True
        If txtNom.Text = "" Or txtTlf.Text = "" Then
            mensaje = "Has de rellenar el nombre y el teléfono. "
            frmAdvertencia.Show()
        Else
            Dim telefono As New Telefono
            DataRepeater1.DataSource = lista
            telefono.Nombre1 = txtNom.Text
            telefono.Telefono1 = txtTlf.Text
            listaTelefonos.Add(telefono)
            DataRepeater1.DataSource = listaTelefonos
        End If

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