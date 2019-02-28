Public Class frmParteModificar
    Private Sub frmParteModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarContenido()
    End Sub
    Private Sub cargarContenido()
        Dim controlador As New ControladorParte
        Dim parte As New ParteTrabajo
        Dim listaPartes As New ArrayList
        listaPartes = controlador.mostrarParte(parteId)
        For Each parte In listaPartes
            lblFechaEntrada.Text = parte.FechaEntrada1
            txtCliente.Text = parte.Cliente1
            txtTelefono.Text = parte.Telefono1
            txtProblema.Text = parte.Problema1
            txtProducto.Text = parte.Producto1
            txtNserie.Text = parte.NumeroSerie1
            lblFechaSalida.Text = parte.FechaSalida1
            txtTecnico.Text = parte.Tecnico1
            txtSolucion.Text = parte.Solucion1
            lblPrecio.Text = parte.totalEuros1
            txtMaterial.Text = parte.Material1

        Next
    End Sub
    Private Sub actualizarParte()
        Dim parte As New ParteTrabajo
        Dim controlador As New ControladorParte
        parte.Id1 = parteId
        parte.Telefono1 = txtTelefono.Text
        parte.Cliente1 = txtCliente.Text
        parte.Problema1 = txtProblema.Text
        parte.Producto1 = txtProducto.Text
        parte.NumeroSerie1 = txtNserie.Text
        ' el método actualizarPArte sólo actualiza la información de la incidencia por si se ha confundido al anotar.
        controlador.actualizarParte(parte)

    End Sub

    Private Sub imgImprimirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgImprimirGrande.MouseDown
        imgImprimirGrande.Visible = False

    End Sub
    Private Sub imgImprimirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgImprimirGrande.MouseUp
        imgImprimirGrande.Visible = True
        ' crear el método en controlador de actualizar y cerrar parte, para que lo imprima todo
        Dim fecha As DateTime
        fecha = Now()
        lblFechaSalida.Text = Format(fecha.ToString(" dd-MMMM-yyyy, HH:mm:ss"))
        Dim parte As New ParteTrabajo
        Dim controlador As New ControladorParte
        parte.Id1 = parteId
        parte.Telefono1 = txtTelefono.Text
        parte.Cliente1 = txtCliente.Text
        parte.Problema1 = txtProblema.Text
        parte.Producto1 = txtProducto.Text
        parte.NumeroSerie1 = txtNserie.Text
        parte.FechaEntrada1 = lblFechaEntrada.Text
        parte.FechaSalida1 = lblFechaSalida.Text
        parte.Solucion1 = txtSolucion.Text
        parte.Tecnico1 = txtTecnico.Text
        parte.Material1 = txtMaterial.Text
        parte.totalEuros1 = CDbl(lblPrecio.Text)
        controlador.actualizarYCerrarParte(parte)
        parteImprimeSolucion.Show()
    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        actualizarParte()
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False

    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Me.Close()

    End Sub

    Private Sub imgAgregarTecnico_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAgregarTecnico.MouseDown
        imgAgregarTecnico.Visible = False
    End Sub
    Private Sub imgAgregarTecnico_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAgregarTecnico.MouseUp
        imgAgregarTecnico.Visible = True
        flagActivated = True
        frmSeleccionTecnico.Show()
    End Sub

    Private Sub frmParteModificar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If flagActivated = True Then
            txtTecnico.Text = txtTecnico.Text & listaTecnicos
            txtMaterial.Text = txtMaterial.Text & listaMaterial
            lblPrecio.Text = totalPrecioMaterial
            flagActivated = False
        End If

    End Sub

    Private Sub imgQuitarTecnico_MouseDown(sender As Object, e As MouseEventArgs) Handles imgQuitarTecnico.MouseDown
        imgQuitarTecnico.Visible = False

    End Sub
    Private Sub imgQuitarTecnico_MouseUp(sender As Object, e As MouseEventArgs) Handles imgQuitarTecnico.MouseUp
        imgQuitarTecnico.Visible = True
        listaTecnicos = ""
        txtTecnico.Clear()

    End Sub

    Private Sub imgMasGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgMasGrande.MouseDown
        imgMasGrande.Visible = False
    End Sub
    Private Sub imgMasGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgMasGrande.MouseUp
        imgMasGrande.Visible = True
        flagActivated = True
        frmSeleccionMaterial.Show()
    End Sub

    Private Sub imgMenosGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgMenosGrande.MouseDown
        imgMenosGrande.Visible = False
    End Sub
    Private Sub imgMenosGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgMenosGrande.MouseUp
        imgMenosGrande.Visible = True
        listaMaterial = ""
        txtMaterial.Clear()
        totalPrecioMaterial = 0
        lblPrecio.Text = 0
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        frmSalir.Show()
    End Sub

    Private Sub GestionarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarAplicaciónToolStripMenuItem.Click
        deshabilitar()
        frmLogin.Show()
    End Sub

    Private Sub CuadernoDeBitácoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadernoDeBitácoraToolStripMenuItem.Click
        Me.Close()
        frmCuaderno.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Me.Close()
        frmProveedores.Show()
    End Sub

    Private Sub CorreoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorreoToolStripMenuItem.Click
        Me.Close()
        frmCorreos.Show()
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.Close()
        frmRedes.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.Close()
        frmClientes.Show()
    End Sub

    Private Sub PartesDeTabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartesDeTrabajoToolStripMenuItem.Click
        Me.Close()
        frmPartes.Show()
    End Sub
End Class