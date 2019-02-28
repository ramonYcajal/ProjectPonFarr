<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClienteNuevo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteNuevo))
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCif = New System.Windows.Forms.TextBox()
        Me.txtPersoCto = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.imgAceptarGrande = New System.Windows.Forms.PictureBox()
        Me.imgAceptarPequena = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArcivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuadernoDeBitácoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorreosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartesDeTabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imgClienteNombre = New System.Windows.Forms.PictureBox()
        Me.imgClienteDomicilio = New System.Windows.Forms.PictureBox()
        Me.imgClientePoblacion = New System.Windows.Forms.PictureBox()
        Me.imgClienteProvincia = New System.Windows.Forms.PictureBox()
        Me.imgClientePersCto = New System.Windows.Forms.PictureBox()
        Me.imgTelefono1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.imgclienteCP = New System.Windows.Forms.PictureBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtTlf = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.imgTelefClienteGrande = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.TelefonoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.imgClienteNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClienteDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClientePoblacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClienteProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClientePersCto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTelefono1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgclienteCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTelefClienteGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.TelefonoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(923, 729)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 36
        Me.imgSalirGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgSalirGrande, "Cerrar")
        '
        'imgSalirPequena
        '
        Me.imgSalirPequena.Image = CType(resources.GetObject("imgSalirPequena.Image"), System.Drawing.Image)
        Me.imgSalirPequena.Location = New System.Drawing.Point(933, 739)
        Me.imgSalirPequena.Name = "imgSalirPequena"
        Me.imgSalirPequena.Size = New System.Drawing.Size(60, 60)
        Me.imgSalirPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirPequena.TabIndex = 37
        Me.imgSalirPequena.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(68, 69)
        Me.txtNombre.MaxLength = 49
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(375, 33)
        Me.txtNombre.TabIndex = 38
        '
        'txtCif
        '
        Me.txtCif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCif.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCif.Location = New System.Drawing.Point(93, 142)
        Me.txtCif.MaxLength = 10
        Me.txtCif.Name = "txtCif"
        Me.txtCif.Size = New System.Drawing.Size(201, 33)
        Me.txtCif.TabIndex = 39
        '
        'txtPersoCto
        '
        Me.txtPersoCto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPersoCto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersoCto.Location = New System.Drawing.Point(29, 437)
        Me.txtPersoCto.MaxLength = 50
        Me.txtPersoCto.Name = "txtPersoCto"
        Me.txtPersoCto.Size = New System.Drawing.Size(322, 33)
        Me.txtPersoCto.TabIndex = 51
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(93, 198)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 33)
        Me.txtEmail.TabIndex = 40
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(37, 607)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(558, 198)
        Me.txtObservaciones.TabIndex = 52
        '
        'txtDomicilio
        '
        Me.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomicilio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(529, 142)
        Me.txtDomicilio.MaxLength = 150
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(460, 33)
        Me.txtDomicilio.TabIndex = 43
        '
        'txtPoblacion
        '
        Me.txtPoblacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPoblacion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoblacion.Location = New System.Drawing.Point(527, 198)
        Me.txtPoblacion.MaxLength = 50
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(460, 33)
        Me.txtPoblacion.TabIndex = 44
        '
        'txtProvincia
        '
        Me.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvincia.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.Location = New System.Drawing.Point(93, 258)
        Me.txtProvincia.MaxLength = 15
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(254, 33)
        Me.txtProvincia.TabIndex = 46
        '
        'txtCP
        '
        Me.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCP.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(529, 258)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(122, 33)
        Me.txtCP.TabIndex = 47
        '
        'imgAceptarGrande
        '
        Me.imgAceptarGrande.Image = CType(resources.GetObject("imgAceptarGrande.Image"), System.Drawing.Image)
        Me.imgAceptarGrande.Location = New System.Drawing.Point(830, 720)
        Me.imgAceptarGrande.Name = "imgAceptarGrande"
        Me.imgAceptarGrande.Size = New System.Drawing.Size(71, 89)
        Me.imgAceptarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarGrande.TabIndex = 61
        Me.imgAceptarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgAceptarGrande, "Guardar")
        '
        'imgAceptarPequena
        '
        Me.imgAceptarPequena.Image = CType(resources.GetObject("imgAceptarPequena.Image"), System.Drawing.Image)
        Me.imgAceptarPequena.Location = New System.Drawing.Point(840, 729)
        Me.imgAceptarPequena.Name = "imgAceptarPequena"
        Me.imgAceptarPequena.Size = New System.Drawing.Size(52, 70)
        Me.imgAceptarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarPequena.TabIndex = 62
        Me.imgAceptarPequena.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArcivoToolStripMenuItem, Me.IrAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 33)
        Me.MenuStrip1.TabIndex = 63
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArcivoToolStripMenuItem
        '
        Me.ArcivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.GestionarAplicaciónToolStripMenuItem})
        Me.ArcivoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ArcivoToolStripMenuItem.Name = "ArcivoToolStripMenuItem"
        Me.ArcivoToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
        Me.ArcivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(258, 30)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GestionarAplicaciónToolStripMenuItem
        '
        Me.GestionarAplicaciónToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.GestionarAplicaciónToolStripMenuItem.Image = CType(resources.GetObject("GestionarAplicaciónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestionarAplicaciónToolStripMenuItem.Name = "GestionarAplicaciónToolStripMenuItem"
        Me.GestionarAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(258, 30)
        Me.GestionarAplicaciónToolStripMenuItem.Text = "Gestionar Aplicación"
        '
        'IrAToolStripMenuItem
        '
        Me.IrAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.CuadernoDeBitácoraToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.CorreosToolStripMenuItem, Me.RedToolStripMenuItem, Me.PartesDeTabajoToolStripMenuItem})
        Me.IrAToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.IrAToolStripMenuItem.Name = "IrAToolStripMenuItem"
        Me.IrAToolStripMenuItem.Size = New System.Drawing.Size(51, 29)
        Me.IrAToolStripMenuItem.Text = "Ir a"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CuadernoDeBitácoraToolStripMenuItem
        '
        Me.CuadernoDeBitácoraToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.CuadernoDeBitácoraToolStripMenuItem.Image = CType(resources.GetObject("CuadernoDeBitácoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CuadernoDeBitácoraToolStripMenuItem.Name = "CuadernoDeBitácoraToolStripMenuItem"
        Me.CuadernoDeBitácoraToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
        Me.CuadernoDeBitácoraToolStripMenuItem.Text = "Cuaderno de bitácora"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.ProveedoresToolStripMenuItem.Image = CType(resources.GetObject("ProveedoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'CorreosToolStripMenuItem
        '
        Me.CorreosToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.CorreosToolStripMenuItem.Image = CType(resources.GetObject("CorreosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CorreosToolStripMenuItem.Name = "CorreosToolStripMenuItem"
        Me.CorreosToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
        Me.CorreosToolStripMenuItem.Text = "Correos"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.RedToolStripMenuItem.Image = CType(resources.GetObject("RedToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'PartesDeTabajoToolStripMenuItem
        '
        Me.PartesDeTabajoToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.PartesDeTabajoToolStripMenuItem.Image = CType(resources.GetObject("PartesDeTabajoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PartesDeTabajoToolStripMenuItem.Name = "PartesDeTabajoToolStripMenuItem"
        Me.PartesDeTabajoToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
        Me.PartesDeTabajoToolStripMenuItem.Text = "Partes de tabajo"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'imgClienteNombre
        '
        Me.imgClienteNombre.Image = CType(resources.GetObject("imgClienteNombre.Image"), System.Drawing.Image)
        Me.imgClienteNombre.Location = New System.Drawing.Point(12, 52)
        Me.imgClienteNombre.Name = "imgClienteNombre"
        Me.imgClienteNombre.Size = New System.Drawing.Size(50, 50)
        Me.imgClienteNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClienteNombre.TabIndex = 64
        Me.imgClienteNombre.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgClienteNombre, "Nombre")
        '
        'imgClienteDomicilio
        '
        Me.imgClienteDomicilio.Image = CType(resources.GetObject("imgClienteDomicilio.Image"), System.Drawing.Image)
        Me.imgClienteDomicilio.Location = New System.Drawing.Point(473, 125)
        Me.imgClienteDomicilio.Name = "imgClienteDomicilio"
        Me.imgClienteDomicilio.Size = New System.Drawing.Size(50, 50)
        Me.imgClienteDomicilio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClienteDomicilio.TabIndex = 65
        Me.imgClienteDomicilio.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgClienteDomicilio, "Domicilio")
        '
        'imgClientePoblacion
        '
        Me.imgClientePoblacion.Image = CType(resources.GetObject("imgClientePoblacion.Image"), System.Drawing.Image)
        Me.imgClientePoblacion.Location = New System.Drawing.Point(473, 181)
        Me.imgClientePoblacion.Name = "imgClientePoblacion"
        Me.imgClientePoblacion.Size = New System.Drawing.Size(50, 50)
        Me.imgClientePoblacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClientePoblacion.TabIndex = 66
        Me.imgClientePoblacion.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgClientePoblacion, "Población")
        '
        'imgClienteProvincia
        '
        Me.imgClienteProvincia.Image = CType(resources.GetObject("imgClienteProvincia.Image"), System.Drawing.Image)
        Me.imgClienteProvincia.Location = New System.Drawing.Point(37, 241)
        Me.imgClienteProvincia.Name = "imgClienteProvincia"
        Me.imgClienteProvincia.Size = New System.Drawing.Size(50, 50)
        Me.imgClienteProvincia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClienteProvincia.TabIndex = 67
        Me.imgClienteProvincia.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgClienteProvincia, "Provincia")
        '
        'imgClientePersCto
        '
        Me.imgClientePersCto.Image = CType(resources.GetObject("imgClientePersCto.Image"), System.Drawing.Image)
        Me.imgClientePersCto.Location = New System.Drawing.Point(32, 385)
        Me.imgClientePersCto.Name = "imgClientePersCto"
        Me.imgClientePersCto.Size = New System.Drawing.Size(100, 50)
        Me.imgClientePersCto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClientePersCto.TabIndex = 68
        Me.imgClientePersCto.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgClientePersCto, "Persona de contacto")
        '
        'imgTelefono1
        '
        Me.imgTelefono1.Image = CType(resources.GetObject("imgTelefono1.Image"), System.Drawing.Image)
        Me.imgTelefono1.Location = New System.Drawing.Point(471, 311)
        Me.imgTelefono1.Name = "imgTelefono1"
        Me.imgTelefono1.Size = New System.Drawing.Size(50, 50)
        Me.imgTelefono1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTelefono1.TabIndex = 69
        Me.imgTelefono1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgTelefono1, "Teléfonos")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 181)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "e-mail")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 125)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "N.I.F. / C.I.F.")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(37, 567)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 38)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 73
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Observaciones")
        '
        'imgclienteCP
        '
        Me.imgclienteCP.Image = CType(resources.GetObject("imgclienteCP.Image"), System.Drawing.Image)
        Me.imgclienteCP.Location = New System.Drawing.Point(473, 241)
        Me.imgclienteCP.Name = "imgclienteCP"
        Me.imgclienteCP.Size = New System.Drawing.Size(50, 50)
        Me.imgclienteCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgclienteCP.TabIndex = 75
        Me.imgclienteCP.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgclienteCP, "Código postal")
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(516, 367)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(205, 33)
        Me.txtNom.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.txtNom, "Nombre")
        '
        'txtTlf
        '
        Me.txtTlf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTlf.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTlf.Location = New System.Drawing.Point(761, 367)
        Me.txtTlf.Name = "txtTlf"
        Me.txtTlf.Size = New System.Drawing.Size(206, 33)
        Me.txtTlf.TabIndex = 77
        Me.ToolTip1.SetToolTip(Me.txtTlf, "Teléfono")
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(482, 367)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 4
        Me.PictureBox7.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox7, "Nombre")
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(727, 367)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 4
        Me.PictureBox8.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox8, "Teléfono")
        '
        'imgTelefClienteGrande
        '
        Me.imgTelefClienteGrande.Image = CType(resources.GetObject("imgTelefClienteGrande.Image"), System.Drawing.Image)
        Me.imgTelefClienteGrande.Location = New System.Drawing.Point(973, 367)
        Me.imgTelefClienteGrande.Name = "imgTelefClienteGrande"
        Me.imgTelefClienteGrande.Size = New System.Drawing.Size(37, 33)
        Me.imgTelefClienteGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTelefClienteGrande.TabIndex = 80
        Me.imgTelefClienteGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgTelefClienteGrande, "Agregar")
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(974, 368)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(35, 31)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 81
        Me.PictureBox9.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox9, "Aceptar")
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(227, 1)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 3
        Me.PictureBox6.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox6, "Teléfono")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Nombre")
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(476, 367)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(0, 0)
        Me.PictureBox4.TabIndex = 74
        Me.PictureBox4.TabStop = False
        '
        'DataRepeater1
        '
        Me.DataRepeater1.AllowUserToAddItems = False
        Me.DataRepeater1.AllowUserToDeleteItems = False
        Me.DataRepeater1.DataSource = Me.TelefonoBindingSource
        Me.DataRepeater1.ItemHeaderVisible = False
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox6)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox5)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblTelefono)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblNombre)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(443, 50)
        Me.DataRepeater1.Location = New System.Drawing.Point(516, 408)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(451, 116)
        Me.DataRepeater1.TabIndex = 78
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'TelefonoBindingSource
        '
        Me.TelefonoBindingSource.DataSource = GetType(Proyecto_final_curso.Telefono)
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonoBindingSource, "Telefono1", True))
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(265, 18)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(40, 13)
        Me.lblTelefono.TabIndex = 1
        Me.lblTelefono.Text = "Label1"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonoBindingSource, "Nombre1", True))
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(41, 18)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(40, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Label1"
        '
        'frmClienteNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1022, 821)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.DataRepeater1)
        Me.Controls.Add(Me.txtTlf)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.imgclienteCP)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.imgTelefono1)
        Me.Controls.Add(Me.imgClientePersCto)
        Me.Controls.Add(Me.imgClienteProvincia)
        Me.Controls.Add(Me.imgClientePoblacion)
        Me.Controls.Add(Me.imgClienteDomicilio)
        Me.Controls.Add(Me.imgClienteNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCif)
        Me.Controls.Add(Me.txtPersoCto)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.imgSalirGrande)
        Me.Controls.Add(Me.imgSalirPequena)
        Me.Controls.Add(Me.imgTelefClienteGrande)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.imgAceptarGrande)
        Me.Controls.Add(Me.imgAceptarPequena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmClienteNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmParteNuevo"
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.imgClienteNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClienteDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClientePoblacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClienteProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClientePersCto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTelefono1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgclienteCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTelefClienteGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.TelefonoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCif As TextBox
    Friend WithEvents txtPersoCto As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtPoblacion As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtCP As TextBox
    Friend WithEvents imgAceptarGrande As PictureBox
    Friend WithEvents imgAceptarPequena As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents imgClienteNombre As PictureBox
    Friend WithEvents imgClienteDomicilio As PictureBox
    Friend WithEvents imgClientePoblacion As PictureBox
    Friend WithEvents imgClienteProvincia As PictureBox
    Friend WithEvents imgClientePersCto As PictureBox
    Friend WithEvents imgTelefono1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents imgclienteCP As PictureBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents TelefonoBindingSource As BindingSource
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents imgTelefClienteGrande As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents ArcivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IrAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuadernoDeBitácoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorreosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartesDeTabajoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
End Class
