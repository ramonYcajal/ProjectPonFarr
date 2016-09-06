<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedorNuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedorNuevo))
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCif = New System.Windows.Forms.TextBox()
        Me.txtPersoCto = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.imgAceptarGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.imgAceptarPequena = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.imgclienteCP = New System.Windows.Forms.PictureBox()
        Me.imgClienteProvincia = New System.Windows.Forms.PictureBox()
        Me.imgClientePoblacion = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.txtTlf = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.imgTelefClienteGrande = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.imgTelefClientePequena = New System.Windows.Forms.PictureBox()
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TelefonoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgclienteCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClienteProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClientePoblacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTelefClienteGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTelefClientePequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(68, 73)
        Me.txtNombre.MaxLength = 49
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(375, 29)
        Me.txtNombre.TabIndex = 85
        '
        'txtCif
        '
        Me.txtCif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCif.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCif.Location = New System.Drawing.Point(93, 146)
        Me.txtCif.MaxLength = 12
        Me.txtCif.Name = "txtCif"
        Me.txtCif.Size = New System.Drawing.Size(201, 29)
        Me.txtCif.TabIndex = 86
        '
        'txtPersoCto
        '
        Me.txtPersoCto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPersoCto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersoCto.Location = New System.Drawing.Point(29, 441)
        Me.txtPersoCto.MaxLength = 50
        Me.txtPersoCto.Name = "txtPersoCto"
        Me.txtPersoCto.Size = New System.Drawing.Size(322, 29)
        Me.txtPersoCto.TabIndex = 97
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(93, 202)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 29)
        Me.txtEmail.TabIndex = 87
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(37, 611)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(558, 198)
        Me.txtObservaciones.TabIndex = 98
        '
        'txtDomicilio
        '
        Me.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(529, 146)
        Me.txtDomicilio.MaxLength = 150
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(460, 29)
        Me.txtDomicilio.TabIndex = 89
        '
        'txtPoblacion
        '
        Me.txtPoblacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPoblacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoblacion.Location = New System.Drawing.Point(529, 202)
        Me.txtPoblacion.MaxLength = 50
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(460, 29)
        Me.txtPoblacion.TabIndex = 91
        '
        'txtProvincia
        '
        Me.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.Location = New System.Drawing.Point(93, 262)
        Me.txtProvincia.MaxLength = 15
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(254, 29)
        Me.txtProvincia.TabIndex = 92
        '
        'txtCP
        '
        Me.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(529, 262)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(122, 29)
        Me.txtCP.TabIndex = 94
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 24)
        Me.MenuStrip1.TabIndex = 108
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'imgAceptarGrande
        '
        Me.imgAceptarGrande.Image = CType(resources.GetObject("imgAceptarGrande.Image"), System.Drawing.Image)
        Me.imgAceptarGrande.Location = New System.Drawing.Point(830, 720)
        Me.imgAceptarGrande.Name = "imgAceptarGrande"
        Me.imgAceptarGrande.Size = New System.Drawing.Size(71, 89)
        Me.imgAceptarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarGrande.TabIndex = 111
        Me.imgAceptarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgAceptarGrande, "Guardar")
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(923, 729)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 109
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
        Me.imgSalirPequena.TabIndex = 110
        Me.imgSalirPequena.TabStop = False
        '
        'imgAceptarPequena
        '
        Me.imgAceptarPequena.Image = CType(resources.GetObject("imgAceptarPequena.Image"), System.Drawing.Image)
        Me.imgAceptarPequena.Location = New System.Drawing.Point(840, 729)
        Me.imgAceptarPequena.Name = "imgAceptarPequena"
        Me.imgAceptarPequena.Size = New System.Drawing.Size(52, 70)
        Me.imgAceptarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarPequena.TabIndex = 112
        Me.imgAceptarPequena.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 113
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Nombre")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 125)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 114
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "N.I.F. / C.I.F.")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(471, 311)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 116
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Teléfono 1")
        '
        'imgclienteCP
        '
        Me.imgclienteCP.Image = CType(resources.GetObject("imgclienteCP.Image"), System.Drawing.Image)
        Me.imgclienteCP.Location = New System.Drawing.Point(473, 241)
        Me.imgclienteCP.Name = "imgclienteCP"
        Me.imgclienteCP.Size = New System.Drawing.Size(50, 50)
        Me.imgclienteCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgclienteCP.TabIndex = 124
        Me.imgclienteCP.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgclienteCP, "Código postal")
        '
        'imgClienteProvincia
        '
        Me.imgClienteProvincia.Image = CType(resources.GetObject("imgClienteProvincia.Image"), System.Drawing.Image)
        Me.imgClienteProvincia.Location = New System.Drawing.Point(37, 241)
        Me.imgClienteProvincia.Name = "imgClienteProvincia"
        Me.imgClienteProvincia.Size = New System.Drawing.Size(50, 50)
        Me.imgClienteProvincia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClienteProvincia.TabIndex = 122
        Me.imgClienteProvincia.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgClienteProvincia, "Provincia")
        '
        'imgClientePoblacion
        '
        Me.imgClientePoblacion.Image = CType(resources.GetObject("imgClientePoblacion.Image"), System.Drawing.Image)
        Me.imgClientePoblacion.Location = New System.Drawing.Point(473, 181)
        Me.imgClientePoblacion.Name = "imgClientePoblacion"
        Me.imgClientePoblacion.Size = New System.Drawing.Size(50, 50)
        Me.imgClientePoblacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClientePoblacion.TabIndex = 121
        Me.imgClientePoblacion.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgClientePoblacion, "Población")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(37, 181)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 115
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "e-mail")
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(37, 567)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(100, 38)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 119
        Me.PictureBox7.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox7, "observaciones")
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(473, 125)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 120
        Me.PictureBox8.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox8, "Domicilio")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(727, 367)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 125
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Teléfono")
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(482, 367)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 126
        Me.PictureBox10.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox10, "Nombre")
        '
        'txtTlf
        '
        Me.txtTlf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTlf.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTlf.Location = New System.Drawing.Point(761, 367)
        Me.txtTlf.Name = "txtTlf"
        Me.txtTlf.Size = New System.Drawing.Size(206, 33)
        Me.txtTlf.TabIndex = 128
        Me.ToolTip1.SetToolTip(Me.txtTlf, "Teléfono")
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(516, 367)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(205, 33)
        Me.txtNom.TabIndex = 127
        Me.ToolTip1.SetToolTip(Me.txtNom, "Nombre")
        '
        'imgTelefClienteGrande
        '
        Me.imgTelefClienteGrande.Image = CType(resources.GetObject("imgTelefClienteGrande.Image"), System.Drawing.Image)
        Me.imgTelefClienteGrande.Location = New System.Drawing.Point(973, 367)
        Me.imgTelefClienteGrande.Name = "imgTelefClienteGrande"
        Me.imgTelefClienteGrande.Size = New System.Drawing.Size(37, 33)
        Me.imgTelefClienteGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTelefClienteGrande.TabIndex = 129
        Me.imgTelefClienteGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgTelefClienteGrande, "Aceptar")
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(32, 385)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 118
        Me.PictureBox6.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(476, 374)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(0, 0)
        Me.PictureBox9.TabIndex = 123
        Me.PictureBox9.TabStop = False
        '
        'imgTelefClientePequena
        '
        Me.imgTelefClientePequena.Image = CType(resources.GetObject("imgTelefClientePequena.Image"), System.Drawing.Image)
        Me.imgTelefClientePequena.Location = New System.Drawing.Point(978, 372)
        Me.imgTelefClientePequena.Name = "imgTelefClientePequena"
        Me.imgTelefClientePequena.Size = New System.Drawing.Size(27, 23)
        Me.imgTelefClientePequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTelefClientePequena.TabIndex = 130
        Me.imgTelefClientePequena.TabStop = False
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
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox11)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox12)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblTelefono)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblNombre)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(443, 50)
        Me.DataRepeater1.Location = New System.Drawing.Point(516, 408)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(451, 116)
        Me.DataRepeater1.TabIndex = 131
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(227, 1)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 3
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 2
        Me.PictureBox12.TabStop = False
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
        'TelefonoBindingSource
        '
        Me.TelefonoBindingSource.DataSource = GetType(Proyecto_final_curso.Telefono)
        '
        'frmProveedorNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1022, 821)
        Me.Controls.Add(Me.DataRepeater1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.txtTlf)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.imgTelefClienteGrande)
        Me.Controls.Add(Me.imgTelefClientePequena)
        Me.Controls.Add(Me.imgclienteCP)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.imgClienteProvincia)
        Me.Controls.Add(Me.imgClientePoblacion)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
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
        Me.Controls.Add(Me.imgAceptarGrande)
        Me.Controls.Add(Me.imgAceptarPequena)
        Me.Controls.Add(Me.imgSalirGrande)
        Me.Controls.Add(Me.imgSalirPequena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmProveedorNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProveedorNuevo"
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgclienteCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClienteProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClientePoblacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTelefClienteGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTelefClientePequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCif As TextBox
    Friend WithEvents txtPersoCto As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtPoblacion As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtCP As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents imgAceptarGrande As PictureBox
    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
    Friend WithEvents imgAceptarPequena As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents imgclienteCP As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents imgClienteProvincia As PictureBox
    Friend WithEvents imgClientePoblacion As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents imgTelefClienteGrande As PictureBox
    Friend WithEvents imgTelefClientePequena As PictureBox
    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents TelefonoBindingSource As BindingSource
End Class
