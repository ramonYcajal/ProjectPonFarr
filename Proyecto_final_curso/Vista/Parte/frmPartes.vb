﻿Public Class frmPartes
    Private Sub frmPartes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPartes()
    End Sub
    Private Sub imgSalirGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseDown
        imgSalirGrande.Visible = False
    End Sub
    Private Sub imgSalirGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgSalirGrande.MouseUp
        imgSalirGrande.Visible = True
        Close()
    End Sub

    Private Sub imgAgregarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAgregarGrande.MouseDown
        imgAgregarGrande.Visible = False
    End Sub
    Private Sub imgAgregarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAgregarGrande.MouseUp
        imgAgregarGrande.Visible = True
        listaTecnicos = ""
        listaMaterial = ""
        frmParteNuevo.Show()
    End Sub

    Private Sub imgFiltrarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgFiltrarGrande.MouseDown
        imgFiltrarGrande.Visible = False
    End Sub
    Private Sub imgFiltrarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgFiltrarGrande.MouseUp
        imgFiltrarGrande.Visible = True
    End Sub

    Private Sub imgModificarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgModificarGrande.MouseDown
        DataRepeater1.CurrentItem.Controls("imgModificarGrande").Visible = False
    End Sub
    Private Sub imgModificarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgModificarGrande.MouseUp
        DataRepeater1.CurrentItem.Controls("imgModificarGrande").Visible = True
        parteId = DataRepeater1.CurrentItem.Controls(lblId.Name).Text
        frmParteModificar.Show()
    End Sub

    Private Sub GestionarAplicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarAplicacionToolStripMenuItem.Click
        deshabilitar()
        frmLogin.Show()
    End Sub
    Private Sub cargarPartes()
        Dim controlador As New ControladorParte
        Dim listaPartes As New ArrayList
        listaPartes = controlador.mostrarPartes
        DataRepeater1.DataSource = listaPartes
    End Sub

    Private Sub frmPartes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cargarPartes()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        frmSalir.Show()
    End Sub

    Private Sub GestionarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarAplicacionToolStripMenuItem.Click
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
End Class