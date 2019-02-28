Imports Microsoft.Reporting.WinForms
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
            parte.Cliente1 = txtCliente.Text
            parte.Telefono1 = txtTelefono.Text
            parte.Problema1 = txtProblema.Text
            parte.Solucion1 = txtSolucion.Text
            parte.Producto1 = txtProducto.Text
            parte.NumeroSerie1 = txtNserie.Text
            parte.totalEuros1 = lblPrecioTotal.Text
            parte.Solucion1 = txtSolucion.Text
            parte.Tecnico1 = txtTecnico.Text
            parte.Material1 = txtMaterial.Text
            controlador.insertar(parte)
            parteImprimeTodo.Show()
            ' vacío el formulario para dejarlo listo para un nuevo parte de trabajo
            vaciar(Me)

        End If
    End Sub

    Private Sub frmParteNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fecha As DateTime
        fecha = Now()
        lblFechaEntrada.Text = Format(fecha.ToString(" dd-MMMM-yyyy, HH:mm:ss"))

    End Sub

    Private Sub imgMasGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgMasGrande.MouseDown
        imgMasGrande.Visible = False
    End Sub
    Private Sub imgMasGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgMasGrande.MouseUp
        imgMasGrande.Visible = True
        frmSeleccionMaterial.Show()
    End Sub

    Private Sub imgMenosGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgMenosGrande.MouseDown
        imgMenosGrande.Visible = False
    End Sub
    Private Sub imgMenosGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgMenosGrande.MouseUp
        imgMenosGrande.Visible = True
        txtMaterial.Clear()
    End Sub

    Private Sub imgImprimirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgImprimirGrande.MouseDown
        imgImprimirGrande.Visible = False
    End Sub
    Private Sub imgImprimirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgImprimirGrande.MouseUp
        imgImprimirGrande.Visible = True
        parteImprimeTodo.Show()
    End Sub

    Private Sub imgMaterial_Click(sender As Object, e As EventArgs) Handles imgMaterial.Click
        frmSeleccionMaterial.Show()
    End Sub

    Private Sub imgAgregarTecnico_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAgregarTecnico.MouseDown
        imgAgregarTecnico.Visible = False

    End Sub
    Private Sub imgAgregarTecnico_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAgregarTecnico.MouseUp
        imgAgregarTecnico.Visible = True
        frmSeleccionTecnico.Show()
    End Sub

    Private Sub frmParteNuevo_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtTecnico.Text = listaTecnicos
        txtMaterial.Text = listaMaterial
        lblPrecioTotal.Text = totalPrecioMaterial
    End Sub

    Private Sub imgQuitarTecnico_MouseDown(sender As Object, e As MouseEventArgs) Handles imgQuitarTecnico.MouseDown
        imgQuitarTecnico.Visible = False
    End Sub
    Private Sub imgQuitarTecnico_MouseUp(sender As Object, e As MouseEventArgs) Handles imgQuitarTecnico.MouseUp
        imgQuitarTecnico.Visible = True
        txtTecnico.Clear()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        frmSalir.Show()
    End Sub

    Private Sub GestionarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarAplicaciónToolStripMenuItem.Click
        deshabilitar()
        frmLogin.Show()
    End Sub

    Private Sub CuadernoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadernoToolStripMenuItem.Click
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

    Private Sub PartesDeTabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadernoToolStripMenuItem.Click
        Me.Close()
        frmPartes.Show()
    End Sub
End Class