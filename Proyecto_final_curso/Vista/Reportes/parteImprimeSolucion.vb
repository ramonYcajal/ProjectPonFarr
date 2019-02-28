Imports Microsoft.Reporting.WinForms
Public Class parteImprimeSolucion
    Private Sub parteImprimeSolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim solucion As New ReportParameter
        Dim tecnico As New ReportParameter
        Dim material As New ReportParameter
        Dim pvp As New ReportParameter
        Dim fechaSalida As New ReportParameter

        material = New ReportParameter("material", frmParteModificar.txtMaterial.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {material})

        solucion = New ReportParameter("solucion", frmParteModificar.txtSolucion.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {solucion})

        tecnico = New ReportParameter("tecnico", frmParteModificar.txtTecnico.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {tecnico})

        pvp = New ReportParameter("pvp", frmParteModificar.lblPrecio.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {pvp})

        fechaSalida = New ReportParameter("fechaSalida", frmParteModificar.lblFechaSalida.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {fechaSalida})
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class