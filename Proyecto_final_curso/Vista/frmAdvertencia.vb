Public Class frmAdvertencia
    Private Sub frmAdvertencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        txtAviso.Text = mensaje
    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown

        imgAceptarGrande.Visible = False
    End Sub

    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class