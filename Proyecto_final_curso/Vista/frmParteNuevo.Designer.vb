<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParteNuevo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim FechasalidaLabel As System.Windows.Forms.Label
        Dim FechaentradaLabel As System.Windows.Forms.Label
        Dim TecnicoLabel As System.Windows.Forms.Label
        Dim ProblemaLabel As System.Windows.Forms.Label
        Dim SolucionLabel As System.Windows.Forms.Label
        Dim ProductoLabel As System.Windows.Forms.Label
        Dim NserieLabel As System.Windows.Forms.Label
        Me.lblFechaSalida = New System.Windows.Forms.Label()
        Me.lblFechaEntrada = New System.Windows.Forms.Label()
        Me.panelMaterial = New System.Windows.Forms.Panel()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.cmbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.cmbTecnico = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProblema = New System.Windows.Forms.TextBox()
        Me.txtSolucion = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtNserie = New System.Windows.Forms.TextBox()
        FechasalidaLabel = New System.Windows.Forms.Label()
        FechaentradaLabel = New System.Windows.Forms.Label()
        TecnicoLabel = New System.Windows.Forms.Label()
        ProblemaLabel = New System.Windows.Forms.Label()
        SolucionLabel = New System.Windows.Forms.Label()
        ProductoLabel = New System.Windows.Forms.Label()
        NserieLabel = New System.Windows.Forms.Label()
        Me.panelMaterial.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.AutoSize = True
        Me.lblFechaSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSalida.ForeColor = System.Drawing.Color.Maroon
        Me.lblFechaSalida.Location = New System.Drawing.Point(274, 81)
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Size = New System.Drawing.Size(66, 24)
        Me.lblFechaSalida.TabIndex = 56
        Me.lblFechaSalida.Text = "Label2"
        '
        'lblFechaEntrada
        '
        Me.lblFechaEntrada.AutoSize = True
        Me.lblFechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEntrada.ForeColor = System.Drawing.Color.Maroon
        Me.lblFechaEntrada.Location = New System.Drawing.Point(29, 82)
        Me.lblFechaEntrada.Name = "lblFechaEntrada"
        Me.lblFechaEntrada.Size = New System.Drawing.Size(66, 24)
        Me.lblFechaEntrada.TabIndex = 55
        Me.lblFechaEntrada.Text = "Label1"
        '
        'panelMaterial
        '
        Me.panelMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMaterial.Controls.Add(Me.btnBorrar)
        Me.panelMaterial.Controls.Add(Me.btnCalcular)
        Me.panelMaterial.Controls.Add(Me.cmbMaterial)
        Me.panelMaterial.Controls.Add(Me.Label4)
        Me.panelMaterial.Controls.Add(Me.lblPrecio)
        Me.panelMaterial.Location = New System.Drawing.Point(713, 566)
        Me.panelMaterial.Name = "panelMaterial"
        Me.panelMaterial.Size = New System.Drawing.Size(288, 150)
        Me.panelMaterial.TabIndex = 52
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(46, 120)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 26
        Me.btnBorrar.Text = "CANCELAR"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(46, 97)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 25
        Me.btnCalcular.Text = "AÑADIR "
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'cmbMaterial
        '
        Me.cmbMaterial.DisplayMember = "material"
        Me.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMaterial.FormattingEnabled = True
        Me.cmbMaterial.Location = New System.Drawing.Point(3, 40)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(278, 32)
        Me.cmbMaterial.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "MATERIAL"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.Maroon
        Me.lblPrecio.Location = New System.Drawing.Point(218, 112)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(0, 24)
        Me.lblPrecio.TabIndex = 24
        '
        'FechasalidaLabel
        '
        FechasalidaLabel.AutoSize = True
        FechasalidaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechasalidaLabel.Location = New System.Drawing.Point(270, 54)
        FechasalidaLabel.Name = "FechasalidaLabel"
        FechasalidaLabel.Size = New System.Drawing.Size(176, 24)
        FechasalidaLabel.TabIndex = 40
        FechasalidaLabel.Text = "FECHA DE SALIDA"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.Window
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(25, 151)
        Me.txtCliente.MaxLength = 50
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(422, 29)
        Me.txtCliente.TabIndex = 42
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(453, 151)
        Me.txtTelefono.MaxLength = 12
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(283, 29)
        Me.txtTelefono.TabIndex = 43
        '
        'cmbTecnico
        '
        Me.cmbTecnico.DisplayMember = "nombre"
        Me.cmbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTecnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTecnico.FormattingEnabled = True
        Me.cmbTecnico.Location = New System.Drawing.Point(713, 511)
        Me.cmbTecnico.Name = "cmbTecnico"
        Me.cmbTecnico.Size = New System.Drawing.Size(283, 32)
        Me.cmbTecnico.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(146, 743)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 24)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "EUROS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 719)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 24)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "TOTAL:"
        '
        'FechaentradaLabel
        '
        FechaentradaLabel.AutoSize = True
        FechaentradaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaentradaLabel.Location = New System.Drawing.Point(21, 54)
        FechaentradaLabel.Name = "FechaentradaLabel"
        FechaentradaLabel.Size = New System.Drawing.Size(202, 24)
        FechaentradaLabel.TabIndex = 39
        FechaentradaLabel.Text = "FECHA DE ENTRADA"
        '
        'TecnicoLabel
        '
        TecnicoLabel.AutoSize = True
        TecnicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TecnicoLabel.Location = New System.Drawing.Point(714, 460)
        TecnicoLabel.Name = "TecnicoLabel"
        TecnicoLabel.Size = New System.Drawing.Size(94, 24)
        TecnicoLabel.TabIndex = 41
        TecnicoLabel.Text = "TÉCNICO"
        '
        'ProblemaLabel
        '
        ProblemaLabel.AutoSize = True
        ProblemaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProblemaLabel.Location = New System.Drawing.Point(21, 280)
        ProblemaLabel.Name = "ProblemaLabel"
        ProblemaLabel.Size = New System.Drawing.Size(114, 24)
        ProblemaLabel.TabIndex = 44
        ProblemaLabel.Text = "PROBLEMA"
        '
        'txtProblema
        '
        Me.txtProblema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProblema.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProblema.Location = New System.Drawing.Point(25, 307)
        Me.txtProblema.Multiline = True
        Me.txtProblema.Name = "txtProblema"
        Me.txtProblema.Size = New System.Drawing.Size(711, 123)
        Me.txtProblema.TabIndex = 45
        '
        'SolucionLabel
        '
        SolucionLabel.AutoSize = True
        SolucionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SolucionLabel.Location = New System.Drawing.Point(25, 433)
        SolucionLabel.Name = "SolucionLabel"
        SolucionLabel.Size = New System.Drawing.Size(106, 24)
        SolucionLabel.TabIndex = 46
        SolucionLabel.Text = "SOLUCIÓN"
        '
        'txtSolucion
        '
        Me.txtSolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolucion.Location = New System.Drawing.Point(29, 460)
        Me.txtSolucion.Multiline = True
        Me.txtSolucion.Name = "txtSolucion"
        Me.txtSolucion.Size = New System.Drawing.Size(661, 256)
        Me.txtSolucion.TabIndex = 47
        '
        'ProductoLabel
        '
        ProductoLabel.AutoSize = True
        ProductoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductoLabel.Location = New System.Drawing.Point(25, 209)
        ProductoLabel.Name = "ProductoLabel"
        ProductoLabel.Size = New System.Drawing.Size(116, 24)
        ProductoLabel.TabIndex = 48
        ProductoLabel.Text = "PRODUCTO"
        '
        'txtProducto
        '
        Me.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(25, 236)
        Me.txtProducto.MaxLength = 50
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(422, 29)
        Me.txtProducto.TabIndex = 49
        '
        'NserieLabel
        '
        NserieLabel.AutoSize = True
        NserieLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NserieLabel.Location = New System.Drawing.Point(449, 209)
        NserieLabel.Name = "NserieLabel"
        NserieLabel.Size = New System.Drawing.Size(185, 24)
        NserieLabel.TabIndex = 50
        NserieLabel.Text = "NÚMERO DE SERIE"
        '
        'txtNserie
        '
        Me.txtNserie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNserie.Location = New System.Drawing.Point(453, 236)
        Me.txtNserie.MaxLength = 50
        Me.txtNserie.Name = "txtNserie"
        Me.txtNserie.Size = New System.Drawing.Size(285, 29)
        Me.txtNserie.TabIndex = 51
        '
        'frmParteNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1022, 821)
        Me.Controls.Add(Me.lblFechaSalida)
        Me.Controls.Add(Me.lblFechaEntrada)
        Me.Controls.Add(Me.panelMaterial)
        Me.Controls.Add(FechasalidaLabel)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.cmbTecnico)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(FechaentradaLabel)
        Me.Controls.Add(TecnicoLabel)
        Me.Controls.Add(ProblemaLabel)
        Me.Controls.Add(Me.txtProblema)
        Me.Controls.Add(SolucionLabel)
        Me.Controls.Add(Me.txtSolucion)
        Me.Controls.Add(ProductoLabel)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(NserieLabel)
        Me.Controls.Add(Me.txtNserie)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmParteNuevo"
        Me.Text = "frmParteNuevo"
        Me.panelMaterial.ResumeLayout(False)
        Me.panelMaterial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFechaSalida As Label
    Friend WithEvents lblFechaEntrada As Label
    Friend WithEvents panelMaterial As Panel
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents cmbMaterial As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents cmbTecnico As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProblema As TextBox
    Friend WithEvents txtSolucion As TextBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtNserie As TextBox
End Class
