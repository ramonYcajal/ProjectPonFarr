<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuaderno
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuaderno))
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.CuadernoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDeQuien = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblAQuien = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.imgModificarGrande = New System.Windows.Forms.PictureBox()
        Me.imgModificarPequena = New System.Windows.Forms.PictureBox()
        Me.imgAgregarGrande = New System.Windows.Forms.PictureBox()
        Me.imgAgregarPequena = New System.Windows.Forms.PictureBox()
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imgFiltrarGrande = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.imgFiltrarPequena = New System.Windows.Forms.PictureBox()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.cmbEstadoIncidencia = New System.Windows.Forms.ComboBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.CuadernoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgModificarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgModificarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAgregarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAgregarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiltrarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataRepeater1
        '
        Me.DataRepeater1.AllowUserToAddItems = False
        Me.DataRepeater1.AllowUserToDeleteItems = False
        Me.DataRepeater1.BackColor = System.Drawing.Color.Tan
        Me.DataRepeater1.DataSource = Me.CuadernoBindingSource
        Me.DataRepeater1.ItemHeaderVisible = False
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.txtDeQuien)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblEstado)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblAQuien)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblId)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblFecha)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgModificarGrande)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgModificarPequena)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(986, 139)
        Me.DataRepeater1.Location = New System.Drawing.Point(16, 196)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(994, 521)
        Me.DataRepeater1.TabIndex = 34
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'CuadernoBindingSource
        '
        Me.CuadernoBindingSource.DataSource = GetType(Proyecto_final_curso.Cuaderno)
        '
        'txtDeQuien
        '
        Me.txtDeQuien.BackColor = System.Drawing.Color.Tan
        Me.txtDeQuien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDeQuien.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuadernoBindingSource, "Cliente1", True))
        Me.txtDeQuien.Enabled = False
        Me.txtDeQuien.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeQuien.ForeColor = System.Drawing.Color.Black
        Me.txtDeQuien.Location = New System.Drawing.Point(510, 10)
        Me.txtDeQuien.Multiline = True
        Me.txtDeQuien.Name = "txtDeQuien"
        Me.txtDeQuien.Size = New System.Drawing.Size(153, 103)
        Me.txtDeQuien.TabIndex = 21
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuadernoBindingSource, "Resuelto1", True))
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(679, 10)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(70, 25)
        Me.lblEstado.TabIndex = 4
        Me.lblEstado.Text = "Label1"
        '
        'lblAQuien
        '
        Me.lblAQuien.AutoSize = True
        Me.lblAQuien.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuadernoBindingSource, "Persona1", True))
        Me.lblAQuien.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAQuien.Location = New System.Drawing.Point(281, 10)
        Me.lblAQuien.Name = "lblAQuien"
        Me.lblAQuien.Size = New System.Drawing.Size(67, 25)
        Me.lblAQuien.TabIndex = 2
        Me.lblAQuien.Text = "Label1"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuadernoBindingSource, "Id1", True))
        Me.lblId.Location = New System.Drawing.Point(28, 100)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(39, 13)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "Label2"
        Me.lblId.Visible = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuadernoBindingSource, "Fecha1", True))
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Maroon
        Me.lblFecha.Location = New System.Drawing.Point(7, 10)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(67, 25)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Label1"
        '
        'imgModificarGrande
        '
        Me.imgModificarGrande.Image = CType(resources.GetObject("imgModificarGrande.Image"), System.Drawing.Image)
        Me.imgModificarGrande.Location = New System.Drawing.Point(864, 45)
        Me.imgModificarGrande.Name = "imgModificarGrande"
        Me.imgModificarGrande.Size = New System.Drawing.Size(85, 86)
        Me.imgModificarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgModificarGrande.TabIndex = 19
        Me.imgModificarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgModificarGrande, "Detalles/Modificar")
        '
        'imgModificarPequena
        '
        Me.imgModificarPequena.Image = CType(resources.GetObject("imgModificarPequena.Image"), System.Drawing.Image)
        Me.imgModificarPequena.Location = New System.Drawing.Point(874, 53)
        Me.imgModificarPequena.Name = "imgModificarPequena"
        Me.imgModificarPequena.Size = New System.Drawing.Size(66, 70)
        Me.imgModificarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgModificarPequena.TabIndex = 20
        Me.imgModificarPequena.TabStop = False
        '
        'imgAgregarGrande
        '
        Me.imgAgregarGrande.Image = CType(resources.GetObject("imgAgregarGrande.Image"), System.Drawing.Image)
        Me.imgAgregarGrande.Location = New System.Drawing.Point(825, 729)
        Me.imgAgregarGrande.Name = "imgAgregarGrande"
        Me.imgAgregarGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgAgregarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAgregarGrande.TabIndex = 44
        Me.imgAgregarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgAgregarGrande, "Nueva incidencia")
        '
        'imgAgregarPequena
        '
        Me.imgAgregarPequena.Image = CType(resources.GetObject("imgAgregarPequena.Image"), System.Drawing.Image)
        Me.imgAgregarPequena.Location = New System.Drawing.Point(835, 739)
        Me.imgAgregarPequena.Name = "imgAgregarPequena"
        Me.imgAgregarPequena.Size = New System.Drawing.Size(60, 60)
        Me.imgAgregarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAgregarPequena.TabIndex = 45
        Me.imgAgregarPequena.TabStop = False
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(922, 729)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 42
        Me.imgSalirGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgSalirGrande, "Cerrar")
        '
        'imgSalirPequena
        '
        Me.imgSalirPequena.Image = CType(resources.GetObject("imgSalirPequena.Image"), System.Drawing.Image)
        Me.imgSalirPequena.Location = New System.Drawing.Point(932, 739)
        Me.imgSalirPequena.Name = "imgSalirPequena"
        Me.imgSalirPequena.Size = New System.Drawing.Size(60, 60)
        Me.imgSalirPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirPequena.TabIndex = 43
        Me.imgSalirPequena.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'imgFiltrarGrande
        '
        Me.imgFiltrarGrande.Image = CType(resources.GetObject("imgFiltrarGrande.Image"), System.Drawing.Image)
        Me.imgFiltrarGrande.Location = New System.Drawing.Point(937, 48)
        Me.imgFiltrarGrande.Name = "imgFiltrarGrande"
        Me.imgFiltrarGrande.Size = New System.Drawing.Size(70, 70)
        Me.imgFiltrarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFiltrarGrande.TabIndex = 49
        Me.imgFiltrarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgFiltrarGrande, "Filtrar")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(619, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "¿Usuario?")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(619, 107)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "¿Cliente?")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(608, 68)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 56
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "¿Estado de la incidencia?")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(30, 140)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(59, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 57
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Fecha de entrada")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(308, 140)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 58
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Técnio")
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(521, 140)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 59
        Me.PictureBox6.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox6, "Cliente")
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(692, 142)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 60
        Me.PictureBox7.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox7, "Estado de la incidencia")
        '
        'imgFiltrarPequena
        '
        Me.imgFiltrarPequena.Image = CType(resources.GetObject("imgFiltrarPequena.Image"), System.Drawing.Image)
        Me.imgFiltrarPequena.Location = New System.Drawing.Point(943, 53)
        Me.imgFiltrarPequena.Name = "imgFiltrarPequena"
        Me.imgFiltrarPequena.Size = New System.Drawing.Size(59, 59)
        Me.imgFiltrarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFiltrarPequena.TabIndex = 50
        Me.imgFiltrarPequena.TabStop = False
        '
        'cmbUsuario
        '
        Me.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsuario.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(661, 29)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(270, 33)
        Me.cmbUsuario.TabIndex = 52
        '
        'cmbEstadoIncidencia
        '
        Me.cmbEstadoIncidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoIncidencia.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstadoIncidencia.FormattingEnabled = True
        Me.cmbEstadoIncidencia.Location = New System.Drawing.Point(661, 68)
        Me.cmbEstadoIncidencia.Name = "cmbEstadoIncidencia"
        Me.cmbEstadoIncidencia.Size = New System.Drawing.Size(270, 33)
        Me.cmbEstadoIncidencia.TabIndex = 53
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(661, 107)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(270, 29)
        Me.txtCliente.TabIndex = 54
        '
        'frmCuaderno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1022, 821)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.cmbEstadoIncidencia)
        Me.Controls.Add(Me.cmbUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.imgFiltrarGrande)
        Me.Controls.Add(Me.imgFiltrarPequena)
        Me.Controls.Add(Me.DataRepeater1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.imgAgregarGrande)
        Me.Controls.Add(Me.imgAgregarPequena)
        Me.Controls.Add(Me.imgSalirGrande)
        Me.Controls.Add(Me.imgSalirPequena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCuaderno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCuaderno"
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.CuadernoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgModificarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgModificarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAgregarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAgregarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFiltrarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents imgAgregarGrande As PictureBox
    Friend WithEvents imgAgregarPequena As PictureBox
    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CuadernoBindingSource As BindingSource
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblAQuien As Label
    Friend WithEvents imgModificarGrande As PictureBox
    Friend WithEvents imgModificarPequena As PictureBox
    Friend WithEvents imgFiltrarGrande As PictureBox
    Friend WithEvents imgFiltrarPequena As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbUsuario As ComboBox
    Friend WithEvents cmbEstadoIncidencia As ComboBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtDeQuien As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
