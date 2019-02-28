Public Class frmGestionAplicacion


    Private Sub frmGestionAplicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If rol = 3 Then
            TabPage2.Parent = Nothing
        Else
            TabPage2.Parent = TabControl1
        End If
        cargarUsuarios()
        cargarMaterial()
        ' me pone los texbox del material a cero
        inicializarTexbox()

    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        TabPage3.Controls("imgAceptarGrande").Visible = False

    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        Dim nombre As String
        Dim vacio As Boolean
        vacio = isEmpty(TabPage3)
        TabPage3.Controls("imgAceptarGrande").Visible = True
        nombre = txtUsuarioNuevo.Text
        If vacio = False Then
            Dim usuario As New Usuario
            Dim control As New ControladorUsuario
            Dim listaUsuarios As New ArrayList
            usuario.Nombre1 = nombre
            control.insertar(usuario)
            cargarUsuarios()
        End If

    End Sub

    Private Sub imgBorrarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgBorrarGrande.MouseDown
        DataRepeater1.CurrentItem.Controls("imgBorrarGrande").Visible = False
    End Sub
    Private Sub imgBorrarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgBorrarGrande.MouseUp
        Dim usuario As New Usuario
        Dim control As New ControladorUsuario
        DataRepeater1.CurrentItem.Controls("imgBorrarGrande").Visible = True
        usuario.Id1 = DataRepeater1.CurrentItem.Controls("lblId").Text
        control.borrarUsuario(usuario.Id1)
        cargarUsuarios()
    End Sub

    Private Sub imgUsuarioAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgUsuarioAceptarGrande.MouseDown
        DataRepeater1.CurrentItem.Controls("imgUsuarioAceptarGrande").Visible = False
    End Sub
    Private Sub imgUsuarioAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgUsuarioAceptarGrande.MouseUp

        Dim nombreNuevo As String
        DataRepeater1.CurrentItem.Controls("imgUsuarioAceptarGrande").Visible = True
        nombreNuevo = DataRepeater1.CurrentItem.Controls("txtNombreNuevo").Text
        If nombreNuevo = "" Then
            mensaje = "no me puedes dejar en blanco"
            frmAdvertencia.Show()
        Else
            Dim control As New ControladorUsuario
            Dim usuario As New Usuario
            usuario.Id1 = DataRepeater1.CurrentItem.Controls("lblId").Text
            usuario.Nombre1 = DataRepeater1.CurrentItem.Controls("lblNombre").Text
            control.actualizarUsuario(usuario, nombreNuevo)
            cargarUsuarios()
        End If


    End Sub
    Private Sub cargarUsuarios()
        Dim usuario As New Usuario
        Dim control As New ControladorUsuario
        Dim listaUsuarios As New ArrayList
        listaUsuarios = control.mostrarUsuarios
        DataRepeater1.DataSource = listaUsuarios
    End Sub
    Private Sub cargarMaterial()
        Dim material As New Material
        Dim control As New ControladorMaterial
        Dim listaMaterial As New ArrayList
        listaMaterial = control.mostrarMaterial
        DataRepeater2.DataSource = listaMaterial
    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Me.Close()
        habilitar()
    End Sub

    Private Sub imgTB1AceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgTB1AceptarGrande.MouseDown
        TabPage1.Controls("imgTB1AceptarGrande").Visible = False
    End Sub
    Private Sub imgTB1AceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgTB1AceptarGrande.MouseUp
        Dim vacio As Boolean
        Dim euros As String
        TabPage1.Controls("imgTB1AceptarGrande").Visible = True
        vacio = isEmpty(TabPage1)
        If vacio = False Then
            Dim material As New Material
            Dim controlador As New ControladorMaterial
            Dim listaMaterial As New ArrayList
            material.Material1 = TabPage1.Controls("txtNombreMaterial").Text
            material.Precio1 = TabPage1.Controls("txtPrecioDistribuidor").Text
            euros = TabPage1.Controls("lblIva").Text
            ' le quito el euro para que queden sólo los números
            euros.Replace(" €", "")
            'le quito los espacios por si quedara alguno al hacer el replace
            euros = Trim(euros)
            material.pvp1 = euros
            controlador.insertar(material)
            vaciar(TabPage1)
            lblIva.Text = 0
            listaMaterial = controlador.mostrarMaterial
            DataRepeater2.DataSource = listaMaterial
        End If
    End Sub

    Private Sub inicializarTexbox()
        TabPage1.Controls("txtPrecioDistribuidor").Text = 0
        TabPage1.Controls("txtPrecioBeneficio").Text = 0
    End Sub

    Private Sub txtPrecioBeneficio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioBeneficio.TextChanged
        Dim result As Double
        result = 0
        Try
            result = Convert.ToDouble(txtPrecioDistribuidor.Text) + Convert.ToDouble(txtPrecioBeneficio.Text)
            result = result + (result * 0.21)
            lblIva.Text = Convert.ToString(result) + " €"
        Catch
        End Try
    End Sub

    Private Sub txtDRPrecioBeneficios_TextChanged(sender As Object, e As EventArgs) Handles txtDRPrecioBeneficios.TextChanged
        Dim result As Double
        result = 0
        Try
            result = Convert.ToDouble(DataRepeater2.CurrentItem.Controls("txtDRPrecioDist").Text) + Convert.ToDouble(DataRepeater2.CurrentItem.Controls("txtDRPrecioBeneficios").Text)
            result = result + (result * 0.21)
            DataRepeater2.CurrentItem.Controls("lblDRPvp").Text = Convert.ToString(result)
        Catch
        End Try
    End Sub

    Private Sub imgDRPAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgDRPAceptarGrande.MouseDown
        DataRepeater2.CurrentItem.Controls("imgDRPAceptarGrande").Visible = False
    End Sub
    Private Sub imgDRPAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgDRPAceptarGrande.MouseUp
        DataRepeater2.CurrentItem.Controls("imgDRPAceptarGrande").Visible = True
        Dim material As New Material
        Dim controlador As New ControladorMaterial
        material.Id1 = DataRepeater2.CurrentItem.Controls("lblDRPId").Text
        material.Material1 = DataRepeater2.CurrentItem.Controls("txtDRPMaterial").Text
        material.Precio1 = DataRepeater2.CurrentItem.Controls("txtDRPrecioDist").Text
        material.pvp1 = DataRepeater2.CurrentItem.Controls("lblDRPvp").Text
        controlador.actualizarMaterial(material)
    End Sub

    Private Sub imgDRPBorrarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgDRPBorrarGrande.MouseDown
        DataRepeater2.CurrentItem.Controls("imgDRPBorrarGrande").Visible = False
    End Sub
    Private Sub imgDRPBorrarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgDRPBorrarGrande.MouseUp
        DataRepeater2.CurrentItem.Controls("imgDRPBorrarGrande").Visible = True
        Dim controlador As New ControladorMaterial
        Dim listaMaterial As New ArrayList
        Dim id As Int32
        id = DataRepeater2.CurrentItem.Controls("lblDRPId").Text
        controlador.eliminarMaterial(id)
        listaMaterial = controlador.mostrarMaterial
        DataRepeater2.DataSource = listaMaterial
    End Sub

    Private Sub imgFiltrarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgFiltrarGrande.MouseDown
        imgFiltrarGrande.Visible = False
    End Sub
    Private Sub imgFiltrarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgFiltrarGrande.MouseUp
        imgFiltrarGrande.Visible = True
        Dim controlador As New ControladorMaterial
        Dim listaMaterial As New ArrayList
        Dim filtro As String
        filtro = "%" + txtFiltrar.Text + "%"
        listaMaterial = controlador.filtrarMaterial(filtro)
        DataRepeater2.DataSource = listaMaterial
    End Sub

    Private Sub aceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles aceptarGrande.MouseDown
        aceptarGrande.Visible = False
    End Sub
    Private Sub aceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles aceptarGrande.MouseUp
        aceptarGrande.Visible = True
        Dim controlador As New ControladorLogin
        Dim resultado As Int32
        resultado = controlador.cambioContrasena(txtContrasenaVieja.Text, txtContrasenaNueva.Text)
        If resultado = 1 Then
            mensaje = "Cambio contraseña correcto"
            frmAdvertencia.Show()
        Else
            mensaje = "Contraseña incorrecta"
            frmAdvertencia.Show()
        End If

    End Sub
End Class