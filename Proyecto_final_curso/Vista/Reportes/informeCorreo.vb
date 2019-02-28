Imports Microsoft.Reporting.WinForms
Public Class informeCorreo
    Private Sub informeCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'antes de estas líneas, hay que hacer un binding de datos en el reporte
        'y su nombre es datasetPuestos, y se le pasa la lista de puestos 
        'pero antes hay que borrar por si hay otros datasources
        ' listapuestos es una variable global que es un arraylist de todos los puestos
        'la tabla se encarga sola de gestionarlo
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("datasetSubcuentas", listaSubcuentas))

        Dim proveedor As New ReportParameter
        Dim nombre As New ReportParameter
        Dim direccionCorreo As New ReportParameter
        ' Dim usuarioConexion As New ReportParameter
        Dim nombreCuentaConexion As New ReportParameter
        Dim contrasena As New ReportParameter
        Dim sCorreoEntrante As New ReportParameter
        Dim sCorreoSaliente As New ReportParameter
        Dim observaciones As New ReportParameter
        Dim subdominio As New ReportParameter
        Dim usuarioGestion As New ReportParameter
        Dim contrasenaGestion As New ReportParameter
        Dim webGestion As New ReportParameter

        proveedor = New ReportParameter("proveedor", frmCorreoEditar.txtProveedor.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {proveedor})

        nombre = New ReportParameter("cliente", frmCorreoEditar.txtCliente.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {nombre})

        direccionCorreo = New ReportParameter("direccion", frmCorreoEditar.txtDireccionCorreo.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {direccionCorreo})

        'usuarioConexion = New ReportParameter("usuarioConexion", frmCorreoEditar.txtNombreCuenta.Text, True)
        'Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {usuarioConexion})

        nombreCuentaConexion = New ReportParameter("nombreCuenta", frmCorreoEditar.txtNombreCuenta.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {nombreCuentaConexion})

        contrasena = New ReportParameter("contrasena", frmCorreoEditar.txtContrasena.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {contrasena})

        sCorreoEntrante = New ReportParameter("servidorCorreoEntrante", frmCorreoEditar.txtCorreoEntrante.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {sCorreoEntrante})

        sCorreoSaliente = New ReportParameter("servidorCorreoSaliente", frmCorreoEditar.txtCorreoSaliente.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {sCorreoSaliente})

        observaciones = New ReportParameter("observaciones", frmCorreoEditar.txtObservaciones.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {observaciones})

        subdominio = New ReportParameter("subdominio", frmCorreoEditar.txtSubdominio.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {subdominio})

        usuarioGestion = New ReportParameter("usuarioGestion", frmCorreoEditar.txtUsuarioGestion.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {usuarioGestion})

        contrasenaGestion = New ReportParameter("contrasenaGestion", frmCorreoEditar.txtContrasenaGestion.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {contrasenaGestion})

        webGestion = New ReportParameter("webGestion", frmCorreoEditar.txtWebGestion.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {webGestion})


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class