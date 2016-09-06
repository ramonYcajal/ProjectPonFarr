Public Class frmSeleccionMaterial
    Private Sub frmSeleccionMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub
    Private Sub cargarDatos()
        Dim listaMaterial As New ArrayList
        Dim controlMaterial As New ControladorMaterial
        listaMaterial = controlMaterial.mostrarMaterial
        DataRepeater1.DataSource = listaMaterial
    End Sub

End Class