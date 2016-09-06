Public Class frmCuadernoNuevaIncidencia
    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Me.Close()
        'frmCuaderno.Show()
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

            Try
                cuaderno.Fecha1 = lblFecha.Text
                cuaderno.Datos1 = txtDatos.Text
                cuaderno.Persona1 = cmbPersona.SelectedItem.ToString
                cuaderno.Resuelto1 = cmbResuelto.SelectedItem.ToString
                cuaderno.Cliente1 = txtCliente.Text
                control.insertar(cuaderno)
                vaciar(Me)
            Catch ex As Exception
                mensaje = "Has de rellenarlo todo"
                frmAdvertencia.Show()
            End Try

        End If

    End Sub

    Private Sub frmCuadernoNuevaIncidencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fecha As DateTime
        fecha = Now()
        lblFecha.Text = Format(fecha.ToString(" dd-MMMM-yyyy, HH:mm:ss"))
        cargarCombos()
    End Sub
    Private Sub cargarCombos()
        Dim controlador As New ControladorUsuario
        Dim controlIncidencia As New ControladorIncidencia
        Dim listaIncidencias As New ArrayList
        Dim listaUsuarios As New ArrayList
        listaIncidencias = controlIncidencia.mostrarIncidencias()
        listaUsuarios = controlador.mostrarUsuarios()
        For Each usuario As Usuario In listaUsuarios
            cmbPersona.Items.Add(usuario.Nombre1)
        Next
        For Each incidencia As Incidencia In listaIncidencias
            cmbResuelto.Items.Add(incidencia.EstadoIncidencia1)
        Next

    End Sub
End Class