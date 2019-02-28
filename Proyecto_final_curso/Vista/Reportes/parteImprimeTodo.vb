Imports Microsoft.Reporting.WinForms
Public Class parteImprimeTodo
    Private Sub parteImprimeTodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' puuuuffff por fín este es el código que muetra los contenidos de los texbox y labels
        ' en el reporte. explico cómo hacerlo 
        'primero desde el report.rdlc tienes que ir al menú ver y seleccionar report data
        ' cuando te salgan los origenes de datos pinchas con el derecho en la carpeta
        'de parámetros y creas uno nuevo, poniendo un nombre.
        'marcas las dos primeras casillas de permitir valores null y valores en blanco
        ' aceptas y ya está. pones un textbox en el informe y arrastras dentro de él el parametro
        'creado desde la carpeta de parámetros

        ' luego te vas al formulario que contiene el reportviewer y pones el siguiente código
        ' importas arriba del todo esto: imports microsoft.reporting.winforms
        'creas una variable de tipo reportparameter
        ' le pasas en el constructor entre comillas el nombre del parámetro que has creado
        'la ruta del componente de texto que quieras mostrar (me.formulario.textbox.text)
        ' pones una coma y añades true para decir que sí lo muestre
        ' ahora seteas el parámetro pasandole al reportviewer un new reportparameter(){r(0)})
        'me.reportviewer1.localReport.setParameters(new reportParameter(){r(0)})
        'actualizas el reportviewer
        'me.reportviewer1.refreshreport()

        Dim fechaEntrada As ReportParameter
        Dim cliente As ReportParameter
        Dim producto As ReportParameter
        Dim numSerie As ReportParameter
        Dim problema As ReportParameter

        fechaEntrada = New ReportParameter("fechaEntrada", frmParteNuevo.lblFechaEntrada.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {fechaEntrada})

        cliente = New ReportParameter("cliente", frmParteNuevo.txtCliente.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cliente})

        producto = New ReportParameter("producto", frmParteNuevo.txtProducto.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {producto})

        numSerie = New ReportParameter("numSerie", frmParteNuevo.txtNserie.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {numSerie})

        problema = New ReportParameter("problema", frmParteNuevo.txtProblema.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {problema})

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class