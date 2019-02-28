Public Class frmClienteNuevo
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
        Dim vacio As Boolean
        imgAceptarGrande.Visible = True
        vacio = isEmpty(Me)
        If vacio = False Then
            Dim cliente As New Cliente
            Dim control As New ControladorCliente
            cliente.Nombre1 = txtNombre.Text
            Cliente.Nif1 = txtCif.Text
            Cliente.PersonaContacto1 = txtPersoCto.Text
            Cliente.Email1 = txtEmail.Text
            Cliente.Observaciones1 = txtObservaciones.Text
            Cliente.Domicilio1 = txtDomicilio.Text
            Cliente.Poblacion1 = txtPoblacion.Text
            Cliente.Provincia1 = txtProvincia.Text
            Cliente.Telef11 = txtTelef1.Text
            Cliente.Telef21 = txtTelef2.Text
            Cliente.Codpos1 = txtCP.Text
            control.insertar(cliente)
            vaciar(Me)
        End If
    End Sub

    Private Sub frmClienteNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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