Public Class frmProveedores
    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False

    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Me.Close()

    End Sub

    Private Sub imgAgregarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAgregarGrande.MouseDown
        imgAgregarGrande.Visible = False
    End Sub
    Private Sub imgAgregarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAgregarGrande.MouseUp
        imgAgregarGrande.Visible = True
        frmProveedorNuevo.Show()
        ' Me.Close()

    End Sub

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarProveedores()
        ocultar(Me)
    End Sub

    Private Sub imgModificarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgModificarGrande.MouseDown
        dataRepeaterProveedores.CurrentItem.Controls("imgModificarGrande").Visible = False
    End Sub
    Private Sub imgModificarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgModificarGrande.MouseUp
        dataRepeaterProveedores.CurrentItem.Controls("imgModificarGrande").Visible = True
        proveedorId = dataRepeaterProveedores.CurrentItem.Controls("lblId").Text
        frmEditarProveedor.Show()
        ' Me.Close()
    End Sub

    Private Sub imgFiltrarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgFiltrarGrande.MouseDown
        imgFiltrarGrande.Visible = False
    End Sub
    Private Sub imgFiltrarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgFiltrarGrande.MouseUp
        Dim filtro As String
        Dim controlador As New ControladorProveedor
        Dim listaProveedores As New ArrayList
        filtro = "%" + txtFiltro.Text + "%"
        imgFiltrarGrande.Visible = True
        listaProveedores = controlador.filtrarProveedor(filtro)
        dataRepeaterProveedores.DataSource = listaProveedores

    End Sub
    Private Sub cargarProveedores()
        Dim controlador As New ControladorProveedor
        Dim listaProveedores As New ArrayList
        controlador.mostrarProveedores()
        listaProveedores = controlador.mostrarProveedores
        dataRepeaterProveedores.DataSource = listaProveedores
    End Sub

    Private Sub frmProveedores_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cargarProveedores()
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