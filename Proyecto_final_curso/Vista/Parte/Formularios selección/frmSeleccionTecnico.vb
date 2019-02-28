Public Class frmSeleccionTecnico
    Private Sub frmSeleccionTecnico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()

    End Sub
    Private Sub cargarDatos()
        Dim listaUsuarios As New ArrayList
        Dim controlUsuarios As New ControladorUsuario
        listaUsuarios = controlUsuarios.mostrarUsuarios
        DataRepeater1.DataSource = listaUsuarios
    End Sub


    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        listaTecnicos = txtTecnicos.Text
        Me.Close()
    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        DataRepeater1.CurrentItem.Controls(imgAceptarGrande.Name).Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        DataRepeater1.CurrentItem.Controls(imgAceptarGrande.Name).Visible = True
        txtTecnicos.Text = txtTecnicos.Text & vbCrLf & DataRepeater1.CurrentItem.Controls(txtNombre.Name).Text
    End Sub

    Private Sub imgBorrarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgBorrarGrande.MouseDown
        imgBorrarGrande.Visible = False
    End Sub
    Private Sub imgBorrarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgBorrarGrande.MouseUp
        imgBorrarGrande.Visible = True
        txtTecnicos.Clear()
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim filtro As String
        Dim listaUsuarios As New ArrayList
        Dim usuario As New ControladorUsuario
        imgFiltrarGrande.Visible = True
        filtro = "%" + txtFiltro.Text + "%"
        listaUsuarios = usuario.filtrarUsuario(filtro)
        DataRepeater1.DataSource = listaUsuarios
    End Sub
End Class