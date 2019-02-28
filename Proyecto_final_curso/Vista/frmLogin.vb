Public Class frmLogin


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False

    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        Dim admin As New Administracion
        Dim control As New ControladorLogin
        Dim log As New ArrayList
        admin.Usuario1 = txtUsuario.Text
        admin.Contrasena1 = txtPwd.Text

        log = control.isLogged(admin)
        If log.Item(0) <> 1 Then
            mensaje = "Error; usuario y/o contraseña incorrectos"
            frmAdvertencia.Show()
        ElseIf log.Item(1) = 4 Then
            mensaje = "Este usuario carece de privilegios para loguearse aquí."
            frmAdvertencia.Show()
        Else
            rol = log.Item(1)
            frmGestionAplicacion.Show()
            Me.Close()

        End If
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        habilitar()
        Me.Close()
    End Sub

End Class