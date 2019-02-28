Public Class frmProveedorNuevo
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
            provee.Telef11 = txtTelef1.Text
            provee.Telef21 = txtTelef2.Text
            provee.Codpos1 = txtCP.Text
            control.insertar(provee)
        End If
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = False
        Me.Close()
    End Sub

    Private Sub frmProveedorNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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