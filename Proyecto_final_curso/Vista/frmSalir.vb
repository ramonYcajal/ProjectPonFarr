Public Class frmSalir
    Private Sub frmSalir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        txtMensaje.Text = "¿Seguro que deseas salir?"
    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False

    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        ' eto para el servidor mysql de xampp
        Shell("c:\xampp\mysql_stop.bat")
        Application.Exit()
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False

    End Sub
    Private Sub imgSalirGrande_MouseDup(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Me.Close()
    End Sub
End Class