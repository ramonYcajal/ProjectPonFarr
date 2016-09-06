Public Class frmParteNuevo
    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False

    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Close()
    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        Dim vacio As Boolean
        vacio = isEmpty(Me)
        If vacio = False Then
            ' y aquí se me graba el nuevo parte.
            Dim controlador As New ControladorParte
            Dim parte As New ParteTrabajo
            parte.FechaEntrada1 = lblFechaEntrada.Text
            parte.FechaSalida1 = lblFechaSalida.Text
            parte.Tecnico1 = cmbTecnico.Text
            parte.Cliente1 = txtCliente.Text
            parte.Telefono1 = txtTelefono.Text
            parte.Problema1 = txtProblema.Text
            parte.Solucion1 = txtSolucion.Text
            parte.Producto1 = txtProducto.Text
            parte.NumeroSerie1 = txtNserie.Text
            controlador.insertar(parte)
            ' vacío el formulario para dejarlo listo para un nuevo parte de trabajo
            vaciar(Me)
        End If
    End Sub

    Private Sub frmParteNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fecha As DateTime
        fecha = Now()
        lblFechaEntrada.Text = Format(fecha.ToString(" dd-MMMM-yyyy, HH:mm:ss"))
        cargarCombos()
    End Sub

    Private Sub imgMasGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgMasGrande.MouseDown
        imgMasGrande.Visible = False
    End Sub
    Private Sub imgMasGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgMasGrande.MouseUp
        imgMasGrande.Visible = True
    End Sub

    Private Sub imgMenosGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgMenosGrande.MouseDown
        imgMenosGrande.Visible = False
    End Sub
    Private Sub imgMenosGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgMenosGrande.MouseUp
        imgMenosGrande.Visible = True
    End Sub

    Private Sub imgImprimirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgImprimirGrande.MouseDown
        imgImprimirGrande.Visible = False
    End Sub
    Private Sub imgImprimirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgImprimirGrande.MouseUp
        imgImprimirGrande.Visible = True
    End Sub
    Private Sub cargarCombos()
        Dim listaUsuarios As New ArrayList
        Dim listaMaterial As New ArrayList
        Dim controlMaterial As New ControladorMaterial
        Dim control As New ControladorUsuario
        listaUsuarios = control.mostrarUsuarios()
        For Each usuario As Usuario In listaUsuarios
            cmbTecnico.Items.Add(usuario.Nombre1)
        Next

        listaMaterial = controlMaterial.mostrarMaterial
        For Each material As Material In listaMaterial
            cmbMaterial.Items.Add(material.Material1)
        Next
    End Sub

    Private Sub imgTecnico_Click(sender As Object, e As EventArgs) Handles imgTecnico.Click
        frmSeleccionTecnico.Show()
    End Sub

    Private Sub imgMaterial_Click(sender As Object, e As EventArgs) Handles imgMaterial.Click
        frmSeleccionMaterial.Show()
    End Sub

End Class