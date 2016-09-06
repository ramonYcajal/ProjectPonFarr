﻿Public Class frmClienteNuevo
    Private listaTelefonos As New ArrayList
    Private lista As New ArrayList

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False

    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        ' frmClientes.Show()
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
            cliente.Nif1 = txtCif.Text
            cliente.PersonaContacto1 = txtPersoCto.Text
            cliente.Email1 = txtEmail.Text
            cliente.Observaciones1 = txtObservaciones.Text
            cliente.Domicilio1 = txtDomicilio.Text
            cliente.Poblacion1 = txtPoblacion.Text
            cliente.Provincia1 = txtProvincia.Text
            cliente.Codpos1 = txtCP.Text
            cliente.ArrayTelefonos1 = listaTelefonos
            control.insertar(cliente)
            vaciar(Me)
            listaTelefonos.Clear()
            DataRepeater1.DataSource = lista
        End If
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
        ' la ñapa de crear un arraylist de nombre lista es porque una vez que toma el datasource
        ' aunque se actualice el array con nuevos datos, no lo carga
        ' así que me invento un arraylist vacío para que lo cargue y luego cargue la listaTelefonos
        'con los nuevos datos. es una ñapa de mierda, pero no sé de momento cómo hacerlo de otro modo
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

End Class