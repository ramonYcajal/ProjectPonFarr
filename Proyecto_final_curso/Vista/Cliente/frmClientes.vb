Public Class frmClientes
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
        frmClienteNuevo.Show()
        ' Me.Close()

    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListaClientes()

    End Sub

    Private Sub imgFiltrarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgFiltrarGrande.MouseDown
        imgFiltrarGrande.Visible = False
    End Sub
    Private Sub imgFiltrarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgFiltrarGrande.MouseUp
        Dim filtro As String
        Dim listaClientes As New ArrayList
        Dim clie As New ControladorCliente
        imgFiltrarGrande.Visible = True
        filtro = "%" + txtFiltro.Text + "%"
        listaClientes = clie.filtrarCliente(filtro)
        DataRepeater1.DataSource = listaClientes
    End Sub

    Private Sub imgModificarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgModificarGrande.MouseDown
        DataRepeater1.CurrentItem.Controls("imgModificarGrande").Visible = False
    End Sub
    Private Sub imgModificarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgModificarGrande.MouseUp
        DataRepeater1.CurrentItem.Controls("imgModificarGrande").Visible = True
        ' esta id se la paso al formulario de frmActualizarCliente y ese formulario
        'crea el constructor, llama a la función de mostrar un cliente que devuelve
        'un constructor y cuando se modifique, le pasa el objeto cliente a la función
        'actualizarcliente
        clienteId = DataRepeater1.CurrentItem.Controls("lblId").Text
        frmEditarCliente.Show()
        'Me.Close()
    End Sub
    Private Sub cargarListaClientes()
        Dim clie As New ControladorCliente
        Dim listaClientes As New ArrayList
        listaClientes = clie.mostrarClientes
        DataRepeater1.DataSource = listaClientes
    End Sub

    Private Sub frmClientes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cargarListaClientes()
    End Sub
End Class