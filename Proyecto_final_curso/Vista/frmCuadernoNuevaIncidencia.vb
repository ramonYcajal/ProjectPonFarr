Public Class frmCuadernoNuevaIncidencia
    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Me.Close()
    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        Dim vacio As Boolean
        imgAceptarGrande.Visible = True
        vacio = isEmpty(Me)
        If (vacio = False) Then
            Dim cuaderno As New Cuaderno
            Dim control As New ControladorCuaderno
            cuaderno.Fecha1 = lblFecha.Text
            cuaderno.Datos1 = txtDatos.Text
            cuaderno.Persona1 = cmbPersona.SelectedItem
            cuaderno.Resuelto1 = cmbResuelto.SelectedItem
            cuaderno.Cliente1 = txtCliente.Text
            control.insertar(cuaderno)
            vaciar(Me)
        End If

    End Sub

    Private Sub frmCuadernoNuevaIncidencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fecha As DateTime
        fecha = Now()
        lblFecha.Text = Format(fecha.ToString(" dd-MMMM-yyyy, HH:mm:ss"))

    End Sub
End Class