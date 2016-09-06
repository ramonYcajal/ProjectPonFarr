<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarProveedor))
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCif = New System.Windows.Forms.TextBox()
        Me.txtPersoCto = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.imgAceptarGrande = New System.Windows.Forms.PictureBox()
        Me.imgAceptarPequena = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.imgClientePoblacion = New System.Windows.Forms.PictureBox()
        Me.imgClienteProvincia = New System.Windows.Forms.PictureBox()
        Me.imgclienteCP = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.ImgAgregarTelefonoGrande = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtTlf = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.imgDRPBorrar = New System.Windows.Forms.PictureBox()
        Me.imgDRPAceptar = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.imgTelefono1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.imgTelefClienteGrande = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.lblDRPId = New System.Windows.Forms.Label()
        Me.txtDRPTelef = New System.Windows.Forms.TextBox()
        Me.txtDRPNom = New System.Windows.Forms.TextBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.imgDRPActualizar = New System.Windows.Forms.PictureBox()
        Me.TelefonoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClientePoblacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClienteProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgclienteCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgAgregarTelefonoGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDRPBorrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDRPAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTelefono1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTelefClienteGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDRPActualizar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtNombre.TabIndex = 87
        '
        'txtCif
        '
        Me.txtCif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCif.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCif.Location = New System.Drawing.Point(93, 146)
        Me.txtCif.MaxLength = 10
        Me.txtCif.Name = "txtCif"
        Me.txtCif.Size = New System.Drawing.Size(201, 29)
        Me.txtCif.TabIndex = 88
        '
        'txtPersoCto
        '
        Me.txtPersoCto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPersoCto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersoCto.Location = New System.Drawing.Point(29, 441)
        Me.txtPersoCto.MaxLength = 50
        Me.txtPersoCto.Name = "txtPersoCto"
        Me.txtPersoCto.Size = New System.Drawing.Size(322, 29)
        Me.txtPersoCto.TabIndex = 99
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(93, 202)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 29)
        Me.txtEmail.TabIndex = 89
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(37, 611)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(558, 198)
        Me.txtObservaciones.TabIndex = 100
        '
        'txtDomicilio
        '
        Me.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(529, 146)
        Me.txtDomicilio.MaxLength = 150
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(460, 29)
        Me.txtDomicilio.TabIndex = 92
        '
        'txtPoblacion
        '
        Me.txtPoblacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPoblacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoblacion.Location = New System.Drawing.Point(529, 202)
        Me.txtPoblacion.MaxLength = 50
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(460, 29)
        Me.txtPoblacion.TabIndex = 93
        '
        'txtProvincia
        '
        Me.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.Location = New System.Drawing.Point(93, 262)
        Me.txtProvincia.MaxLength = 15
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(254, 29)
        Me.txtProvincia.TabIndex = 95
        '
        'txtCP
        '
        Me.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(529, 262)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(122, 29)
        Me.txtCP.TabIndex = 96
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
        'imgAceptarGrande
        '
        Me.imgAceptarGrande.Image = CType(resources.GetObject("imgAceptarGrande.Image"), System.Drawing.Image)
        Me.imgAceptarGrande.Location = New System.Drawing.Point(830, 720)
        Me.imgAceptarGrande.Name = "imgAceptarGrande"
        Me.imgAceptarGrande.Size = New System.Drawing.Size(71, 89)
        Me.imgAceptarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarGrande.TabIndex = 111
        Me.imgAceptarGrande.TabStop = False
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 24)
        Me.MenuStrip1.TabIndex = 113
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 114
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
        Me.PictureBox2.TabIndex = 115
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "D.N.I. / C.I.F.")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(37, 181)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 116
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "e-mail")
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(32, 385)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 119
        Me.PictureBox6.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox6, "Persona de contacto")
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(473, 125)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 121
        Me.PictureBox8.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox8, "Domicilio")
        '
        'imgClientePoblacion
        '
        Me.imgClientePoblacion.Image = CType(resources.GetObject("imgClientePoblacion.Image"), System.Drawing.Image)
        Me.imgClientePoblacion.Location = New System.Drawing.Point(473, 181)
        Me.imgClientePoblacion.Name = "imgClientePoblacion"
        Me.imgClientePoblacion.Size = New System.Drawing.Size(50, 50)
        Me.imgClientePoblacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClientePoblacion.TabIndex = 122
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
        Me.imgClienteProvincia.TabIndex = 123
        Me.imgClienteProvincia.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgClienteProvincia, "Provincia")
        '
        'imgclienteCP
        '
        Me.imgclienteCP.Image = CType(resources.GetObject("imgclienteCP.Image"), System.Drawing.Image)
        Me.imgclienteCP.Location = New System.Drawing.Point(473, 241)
        Me.imgclienteCP.Name = "imgclienteCP"
        Me.imgclienteCP.Size = New System.Drawing.Size(50, 50)
        Me.imgclienteCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgclienteCP.TabIndex = 125
        Me.imgclienteCP.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgclienteCP, "Código postal")
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(37, 567)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(100, 38)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 126
        Me.PictureBox7.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox7, "observaciones")
        '
        'ImgAgregarTelefonoGrande
        '
        Me.ImgAgregarTelefonoGrande.Image = CType(resources.GetObject("ImgAgregarTelefonoGrande.Image"), System.Drawing.Image)
        Me.ImgAgregarTelefonoGrande.Location = New System.Drawing.Point(514, 69)
        Me.ImgAgregarTelefonoGrande.Name = "ImgAgregarTelefonoGrande"
        Me.ImgAgregarTelefonoGrande.Size = New System.Drawing.Size(31, 31)
        Me.ImgAgregarTelefonoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgAgregarTelefonoGrande.TabIndex = 107
        Me.ImgAgregarTelefonoGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgAgregarTelefonoGrande, "Aceptar")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(267, 68)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 102
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Teléfono")
        '
        'txtTlf
        '
        Me.txtTlf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTlf.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTlf.Location = New System.Drawing.Point(301, 68)
        Me.txtTlf.Name = "txtTlf"
        Me.txtTlf.Size = New System.Drawing.Size(206, 33)
        Me.txtTlf.TabIndex = 104
        Me.ToolTip1.SetToolTip(Me.txtTlf, "Teléfono")
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(56, 68)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(205, 33)
        Me.txtNom.TabIndex = 103
        Me.ToolTip1.SetToolTip(Me.txtNom, "Nombre")
        '
        'imgDRPBorrar
        '
        Me.imgDRPBorrar.Image = CType(resources.GetObject("imgDRPBorrar.Image"), System.Drawing.Image)
        Me.imgDRPBorrar.Location = New System.Drawing.Point(363, 50)
        Me.imgDRPBorrar.Name = "imgDRPBorrar"
        Me.imgDRPBorrar.Size = New System.Drawing.Size(50, 25)
        Me.imgDRPBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgDRPBorrar.TabIndex = 112
        Me.imgDRPBorrar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgDRPBorrar, "Eliminar")
        '
        'imgDRPAceptar
        '
        Me.imgDRPAceptar.Image = CType(resources.GetObject("imgDRPAceptar.Image"), System.Drawing.Image)
        Me.imgDRPAceptar.Location = New System.Drawing.Point(329, 50)
        Me.imgDRPAceptar.Name = "imgDRPAceptar"
        Me.imgDRPAceptar.Size = New System.Drawing.Size(25, 25)
        Me.imgDRPAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgDRPAceptar.TabIndex = 111
        Me.imgDRPAceptar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgDRPAceptar, "Actualizar")
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(212, 3)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 109
        Me.PictureBox9.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox9, "Teléfono")
        '
        'imgTelefono1
        '
        Me.imgTelefono1.Image = CType(resources.GetObject("imgTelefono1.Image"), System.Drawing.Image)
        Me.imgTelefono1.Location = New System.Drawing.Point(11, 12)
        Me.imgTelefono1.Name = "imgTelefono1"
        Me.imgTelefono1.Size = New System.Drawing.Size(50, 50)
        Me.imgTelefono1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTelefono1.TabIndex = 93
        Me.imgTelefono1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgTelefono1, "Teléfonos")
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(515, 70)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(29, 29)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 108
        Me.PictureBox13.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox13, "Aceptar")
        '
        'imgTelefClienteGrande
        '
        Me.imgTelefClienteGrande.Image = CType(resources.GetObject("imgTelefClienteGrande.Image"), System.Drawing.Image)
        Me.imgTelefClienteGrande.Location = New System.Drawing.Point(973, 365)
        Me.imgTelefClienteGrande.Name = "imgTelefClienteGrande"
        Me.imgTelefClienteGrande.Size = New System.Drawing.Size(33, 33)
        Me.imgTelefClienteGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTelefClienteGrande.TabIndex = 127
        Me.imgTelefClienteGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgTelefClienteGrande, "Agregar")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(18, 70)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 129
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Nombre")
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 130
        Me.PictureBox10.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox10, "Nombre")
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.txtTlf)
        Me.Panel1.Controls.Add(Me.txtNom)
        Me.Panel1.Controls.Add(Me.DataRepeater1)
        Me.Panel1.Controls.Add(Me.imgTelefono1)
        Me.Panel1.Controls.Add(Me.ImgAgregarTelefonoGrande)
        Me.Panel1.Controls.Add(Me.PictureBox13)
        Me.Panel1.Location = New System.Drawing.Point(460, 299)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 250)
        Me.Panel1.TabIndex = 128
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
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox10)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblDRPId)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgDRPBorrar)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.txtDRPTelef)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox9)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.txtDRPNom)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox12)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgDRPAceptar)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgDRPActualizar)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(443, 105)
        Me.DataRepeater1.Location = New System.Drawing.Point(56, 109)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(451, 116)
        Me.DataRepeater1.TabIndex = 101
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'lblDRPId
        '
        Me.lblDRPId.AutoSize = True
        Me.lblDRPId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonoBindingSource, "Id1", True))
        Me.lblDRPId.Location = New System.Drawing.Point(70, 63)
        Me.lblDRPId.Name = "lblDRPId"
        Me.lblDRPId.Size = New System.Drawing.Size(39, 13)
        Me.lblDRPId.TabIndex = 115
        Me.lblDRPId.Text = "Label1"
        Me.lblDRPId.Visible = False
        '
        'txtDRPTelef
        '
        Me.txtDRPTelef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDRPTelef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonoBindingSource, "Telefono1", True))
        Me.txtDRPTelef.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDRPTelef.Location = New System.Drawing.Point(250, 15)
        Me.txtDRPTelef.Name = "txtDRPTelef"
        Me.txtDRPTelef.Size = New System.Drawing.Size(163, 22)
        Me.txtDRPTelef.TabIndex = 110
        '
        'txtDRPNom
        '
        Me.txtDRPNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDRPNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonoBindingSource, "Nombre1", True))
        Me.txtDRPNom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDRPNom.Location = New System.Drawing.Point(41, 15)
        Me.txtDRPNom.Name = "txtDRPNom"
        Me.txtDRPNom.Size = New System.Drawing.Size(165, 22)
        Me.txtDRPNom.TabIndex = 108
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(364, 51)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(48, 23)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 114
        Me.PictureBox12.TabStop = False
        '
        'imgDRPActualizar
        '
        Me.imgDRPActualizar.Image = CType(resources.GetObject("imgDRPActualizar.Image"), System.Drawing.Image)
        Me.imgDRPActualizar.Location = New System.Drawing.Point(330, 51)
        Me.imgDRPActualizar.Name = "imgDRPActualizar"
        Me.imgDRPActualizar.Size = New System.Drawing.Size(23, 23)
        Me.imgDRPActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgDRPActualizar.TabIndex = 113
        Me.imgDRPActualizar.TabStop = False
        '
        'TelefonoBindingSource
        '
        Me.TelefonoBindingSource.DataSource = GetType(Proyecto_final_curso.Telefono)
        '
        'frmEditarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1022, 821)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.imgTelefClienteGrande)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.imgclienteCP)
        Me.Controls.Add(Me.imgClienteProvincia)
        Me.Controls.Add(Me.imgClientePoblacion)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
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
        Me.Name = "frmEditarProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditarProveedor"
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClientePoblacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClienteProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgclienteCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgAgregarTelefonoGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDRPBorrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDRPAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTelefono1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTelefClienteGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDRPActualizar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
    Friend WithEvents imgAceptarGrande As PictureBox
    Friend WithEvents imgAceptarPequena As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents imgClientePoblacion As PictureBox
    Friend WithEvents imgClienteProvincia As PictureBox
    Friend WithEvents imgclienteCP As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImgAgregarTelefonoGrande As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents lblDRPId As Label
    Friend WithEvents imgDRPBorrar As PictureBox
    Friend WithEvents imgDRPAceptar As PictureBox
    Friend WithEvents txtDRPTelef As TextBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents txtDRPNom As TextBox
    Friend WithEvents imgDRPActualizar As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents imgTelefono1 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents imgTelefClienteGrande As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents TelefonoBindingSource As BindingSource
End Class
