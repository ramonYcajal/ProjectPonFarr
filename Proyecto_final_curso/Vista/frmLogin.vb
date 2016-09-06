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
        Dim log As Integer
        admin.Usuario1 = txtUsuario.Text
        admin.Contrasena1 = txtPwd.Text
        log = control.isLogged(admin)
        If log <> 1 Then
            mensaje = "Error; usuario y/o contraseña incorrectos"
            frmAdvertencia.Show()
        Else
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class