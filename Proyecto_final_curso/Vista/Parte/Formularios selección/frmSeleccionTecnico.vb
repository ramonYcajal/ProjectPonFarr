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
        Me.Close()
    End Sub
End Class