Imports Microsoft.Reporting.WinForms
Public Class informeRed
    Private Sub informeRed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'antes de estas líneas, hay que hacer un binding de datos en el reporte
        'y su nombre es datasetPuestos, y se le pasa la lista de puestos 
        'pero antes hay que borrar por si hay otros datasources
        ' listapuestos es una variable global que es un arraylist de todos los puestos
        'la tabla se encarga sola de gestionarlo
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("datasetPuestos", listaPuestos))

        Dim cliente As New ReportParameter
        Dim nombreServidor As New ReportParameter
        Dim mascaraServidor As New ReportParameter
        Dim ipServidor As New ReportParameter
        Dim grupoTrabajo As New ReportParameter
        Dim ipRouter As New ReportParameter
        Dim usuarioRouter As New ReportParameter
        Dim contrasenaRouter As New ReportParameter
        Dim dns1 As New ReportParameter
        Dim dns2 As New ReportParameter

        cliente = New ReportParameter("cliente", frmEditarRed.txtCliente.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cliente})


        nombreServidor = New ReportParameter("nombreServidor", frmEditarRed.txtServidorNom.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {nombreServidor})

        mascaraServidor = New ReportParameter("mascaraServidor", frmEditarRed.txtServidorMask.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {mascaraServidor})

        ipServidor = New ReportParameter("ipServidor", frmEditarRed.txtServidorIP.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ipServidor})


        grupoTrabajo = New ReportParameter("grupoTrabajo", frmEditarRed.txtGrupoTrabajo.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {grupoTrabajo})

        ipRouter = New ReportParameter("ipRouter", frmEditarRed.txtRouterIP.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ipRouter})

        usuarioRouter = New ReportParameter("usuarioRouter", frmEditarRed.txtRouterUser.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {usuarioRouter})

        contrasenaRouter = New ReportParameter("contrasenaRouter", frmEditarRed.txtRouterPWD.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {contrasenaRouter})

        dns1 = New ReportParameter("dns1", frmEditarRed.txtDNS1.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {dns1})

        dns2 = New ReportParameter("dns2", frmEditarRed.txtDNS2.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {dns2})



        Me.ReportViewer1.RefreshReport()



    End Sub
End Class