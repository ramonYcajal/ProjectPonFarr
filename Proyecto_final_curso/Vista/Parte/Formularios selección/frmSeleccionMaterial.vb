Public Class frmSeleccionMaterial

    Private Sub frmSeleccionMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        totalPrecioMaterial = 0
    End Sub
    Private Sub cargarDatos()
        Dim listaMaterial As New ArrayList
        Dim controlMaterial As New ControladorMaterial
        listaMaterial = controlMaterial.mostrarMaterial
        DataRepeater1.DataSource = listaMaterial
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        listaMaterial = txtMateriales.Text
        Close()
    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        DataRepeater1.CurrentItem.Controls(imgAceptarGrande.Name).Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        DataRepeater1.CurrentItem.Controls(imgAceptarGrande.Name).Visible = True
        txtMateriales.Text = txtMateriales.Text & vbCrLf & DataRepeater1.CurrentItem.Controls(txtMaterial.Name).Text & " " & DataRepeater1.CurrentItem.Controls(txtPvp.Name).Text
        totalPrecioMaterial = totalPrecioMaterial + CDbl(DataRepeater1.CurrentItem.Controls(txtPvp.Name).Text)

    End Sub

    Private Sub imgBorrarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgBorrarGrande.MouseDown
        imgBorrarGrande.Visible = False
    End Sub
    Private Sub imgBorrarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgBorrarGrande.MouseUp
        imgBorrarGrande.Visible = True
        txtMateriales.Clear()
        totalPrecioMaterial = 0
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim filtro As String
        Dim listaMaterial As New ArrayList
        Dim material As New ControladorMaterial
        imgFiltrarGrande.Visible = True
        filtro = "%" + txtFiltro.Text + "%"
        listaMaterial = material.filtrarMaterial(filtro)
        DataRepeater1.DataSource = listaMaterial
    End Sub
End Class