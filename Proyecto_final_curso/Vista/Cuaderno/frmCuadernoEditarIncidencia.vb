﻿Public Class frmCuadernoEditarIncidencia
    Private Sub frmCuadernoEditarIncidencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaCuaderno As ArrayList
        Dim controlador As New ControladorCuaderno
        listaCuaderno = controlador.mostrarIncidencia(cuadernoId)
        cargarCombos()
        cargarIncidencia(listaCuaderno)

    End Sub
    Private Sub cargarIncidencia(ByVal listaCuaderno As ArrayList)
        For Each cuaderno As Cuaderno In listaCuaderno
            cuadernoId = cuaderno.Id1
            lblFecha.Text = cuaderno.Fecha1
            txtCliente.Text = cuaderno.Cliente1
            cmbPersona.Text = cuaderno.Persona1
            cmbResuelto.Text = cuaderno.Resuelto1
            txtDatos.Text = cuaderno.Datos1
        Next
    End Sub
    Private Sub cargarCombos()
        Dim controlador As New ControladorUsuario
        Dim controlIncidencia As New ControladorIncidencia
        Dim listaIncidencias As New ArrayList
        Dim listaUsuarios As New ArrayList
        listaIncidencias = controlIncidencia.mostrarIncidencias()
        listaUsuarios = controlador.mostrarUsuarios()
        For Each usuario As Usuario In listaUsuarios
            cmbPersona.Items.Add(usuario.Nombre1)
        Next
        For Each incidencia As Incidencia In listaIncidencias
            cmbResuelto.Items.Add(incidencia.EstadoIncidencia1)
        Next

    End Sub

    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_Mouseup(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Me.Close()
        ' frmCuaderno.Show()
    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        Dim vacio As Boolean
        vacio = isEmpty(Me)
        If vacio = False Then
            Dim cuaderno As New Cuaderno
            Dim controlador As New ControladorCuaderno
            cuaderno.Id1 = cuadernoId
            cuaderno.Fecha1 = lblFecha.Text
            cuaderno.Cliente1 = txtCliente.Text
            cuaderno.Persona1 = cmbPersona.SelectedItem.ToString
            cuaderno.Resuelto1 = cmbResuelto.SelectedItem.ToString
            cuaderno.Datos1 = txtDatos.Text
            controlador.actualizarCuaderno(cuaderno)
        End If

    End Sub
End Class