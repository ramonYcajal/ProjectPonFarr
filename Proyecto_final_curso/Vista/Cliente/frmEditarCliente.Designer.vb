﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarCliente))
        Me.imgAceptarGrande = New System.Windows.Forms.PictureBox()
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
        Me.imgAceptarPequena = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imgClienteNombre = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgTelefono1 = New System.Windows.Forms.PictureBox()
        Me.imgClientePersCto = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.imgClienteDomicilio = New System.Windows.Forms.PictureBox()
        Me.imgClientePoblacion = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.txtTlf = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.imgTelefClienteGrande = New System.Windows.Forms.PictureBox()
        Me.ImgAgregarTelefonoGrande = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.lblDRPId = New System.Windows.Forms.Label()
        Me.imgDRPBorrar = New System.Windows.Forms.PictureBox()
        Me.imgDRPAceptar = New System.Windows.Forms.PictureBox()
        Me.txtDRPTelef = New System.Windows.Forms.TextBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.txtDRPNom = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TelefonoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClienteNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTelefono1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClientePersCto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClienteDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClientePoblacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTelefClienteGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgAgregarTelefonoGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.imgDRPBorrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDRPAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TelefonoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgAceptarGrande
        '
        Me.imgAceptarGrande.Image = CType(resources.GetObject("imgAceptarGrande.Image"), System.Drawing.Image)
        Me.imgAceptarGrande.Location = New System.Drawing.Point(830, 720)
        Me.imgAceptarGrande.Name = "imgAceptarGrande"
        Me.imgAceptarGrande.Size = New System.Drawing.Size(71, 89)
        Me.imgAceptarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarGrande.TabIndex = 87
        Me.imgAceptarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgAceptarGrande, "Actualizar cliente")
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(68, 73)
        Me.txtNombre.MaxLength = 49
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(375, 29)
        Me.txtNombre.TabIndex = 65
        '
        'txtCif
        '
        Me.txtCif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCif.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCif.Location = New System.Drawing.Point(93, 146)
        Me.txtCif.MaxLength = 10
        Me.txtCif.Name = "txtCif"
        Me.txtCif.Size = New System.Drawing.Size(201, 29)
        Me.txtCif.TabIndex = 66
        '
        'txtPersoCto
        '
        Me.txtPersoCto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPersoCto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersoCto.Location = New System.Drawing.Point(29, 441)
        Me.txtPersoCto.MaxLength = 50
        Me.txtPersoCto.Name = "txtPersoCto"
        Me.txtPersoCto.Size = New System.Drawing.Size(322, 29)
        Me.txtPersoCto.TabIndex = 77
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(93, 202)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 29)
        Me.txtEmail.TabIndex = 67
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(37, 611)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(558, 198)
        Me.txtObservaciones.TabIndex = 78
        '
        'txtDomicilio
        '
        Me.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(529, 146)
        Me.txtDomicilio.MaxLength = 150
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(460, 29)
        Me.txtDomicilio.TabIndex = 70
        '
        'txtPoblacion
        '
        Me.txtPoblacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPoblacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoblacion.Location = New System.Drawing.Point(527, 202)
        Me.txtPoblacion.MaxLength = 50
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(460, 29)
        Me.txtPoblacion.TabIndex = 71
        '
        'txtProvincia
        '
        Me.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.Location = New System.Drawing.Point(93, 262)
        Me.txtProvincia.MaxLength = 15
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(254, 29)
        Me.txtProvincia.TabIndex = 73
        '
        'txtCP
        '
        Me.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(529, 262)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(122, 29)
        Me.txtCP.TabIndex = 74
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(923, 729)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 63
        Me.imgSalirGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgSalirGrande, "Cerrar")
        '
        'imgSalirPequena
        '
        Me.imgSalirPequena.Image = CType(resources.GetObject("imgSalirPequena.Image"), System.Drawing.Image)
        Me.imgSalirPequena.Location = New System.Drawing.Point(934, 739)
        Me.imgSalirPequena.Name = "imgSalirPequena"
        Me.imgSalirPequena.Size = New System.Drawing.Size(60, 60)
        Me.imgSalirPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirPequena.TabIndex = 64
        Me.imgSalirPequena.TabStop = False
        '
        'imgAceptarPequena
        '
        Me.imgAceptarPequena.Image = CType(resources.GetObject("imgAceptarPequena.Image"), System.Drawing.Image)
        Me.imgAceptarPequena.Location = New System.Drawing.Point(840, 729)
        Me.imgAceptarPequena.Name = "imgAceptarPequena"
        Me.imgAceptarPequena.Size = New System.Drawing.Size(52, 70)
        Me.imgAceptarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarPequena.TabIndex = 88
        Me.imgAceptarPequena.TabStop = False
        '
        'imgClienteNombre
        '
        Me.imgClienteNombre.Image = CType(resources.GetObject("imgClienteNombre.Image"), System.Drawing.Image)
        Me.imgClienteNombre.Location = New System.Drawing.Point(12, 52)
        Me.imgClienteNombre.Name = "imgClienteNombre"
        Me.imgClienteNombre.Size = New System.Drawing.Size(50, 50)
        Me.imgClienteNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClienteNombre.TabIndex = 90
        Me.imgClienteNombre.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgClienteNombre, "Nombre")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 125)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 91
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "N.I.F. / C.I.F.")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 181)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "e-mail")
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
        'imgClientePersCto
        '
        Me.imgClientePersCto.Image = CType(resources.GetObject("imgClientePersCto.Image"), System.Drawing.Image)
        Me.imgClientePersCto.Location = New System.Drawing.Point(32, 385)
        Me.imgClientePersCto.Name = "imgClientePersCto"
        Me.imgClientePersCto.Size = New System.Drawing.Size(100, 50)
        Me.imgClientePersCto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClientePersCto.TabIndex = 95
        Me.imgClientePersCto.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgClientePersCto, "Persona de contacto")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(37, 567)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 96
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Observaciones")
        '
        'imgClienteDomicilio
        '
        Me.imgClienteDomicilio.Image = CType(resources.GetObject("imgClienteDomicilio.Image"), System.Drawing.Image)
        Me.imgClienteDomicilio.Location = New System.Drawing.Point(473, 125)
        Me.imgClienteDomicilio.Name = "imgClienteDomicilio"
        Me.imgClienteDomicilio.Size = New System.Drawing.Size(50, 50)
        Me.imgClienteDomicilio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClienteDomicilio.TabIndex = 97
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
        Me.imgClientePoblacion.TabIndex = 98
        Me.imgClientePoblacion.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgClientePoblacion, "Población")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(37, 241)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 99
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Provincia")
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(473, 241)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 100
        Me.PictureBox6.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox6, "Código postal")
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(22, 68)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 5
        Me.PictureBox7.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox7, "Nombre")
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(267, 68)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 102
        Me.PictureBox8.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox8, "Teléfono")
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
        'imgTelefClienteGrande
        '
        Me.imgTelefClienteGrande.Image = CType(resources.GetObject("imgTelefClienteGrande.Image"), System.Drawing.Image)
        Me.imgTelefClienteGrande.Location = New System.Drawing.Point(973, 367)
        Me.imgTelefClienteGrande.Name = "imgTelefClienteGrande"
        Me.imgTelefClienteGrande.Size = New System.Drawing.Size(33, 33)
        Me.imgTelefClienteGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTelefClienteGrande.TabIndex = 105
        Me.imgTelefClienteGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgTelefClienteGrande, "Agregar")
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
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(515, 70)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(29, 29)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 108
        Me.PictureBox12.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox12, "Aceptar")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 24)
        Me.MenuStrip1.TabIndex = 89
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblDRPId)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgDRPBorrar)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgDRPAceptar)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.txtDRPTelef)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox9)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.txtDRPNom)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox3)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox10)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox11)
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
        'txtDRPTelef
        '
        Me.txtDRPTelef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDRPTelef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonoBindingSource, "Telefono1", True))
        Me.txtDRPTelef.Location = New System.Drawing.Point(250, 15)
        Me.txtDRPTelef.Name = "txtDRPTelef"
        Me.txtDRPTelef.Size = New System.Drawing.Size(163, 20)
        Me.txtDRPTelef.TabIndex = 110
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
        'txtDRPNom
        '
        Me.txtDRPNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDRPNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TelefonoBindingSource, "Nombre1", True))
        Me.txtDRPNom.Location = New System.Drawing.Point(41, 15)
        Me.txtDRPNom.Name = "txtDRPNom"
        Me.txtDRPNom.Size = New System.Drawing.Size(165, 20)
        Me.txtDRPNom.TabIndex = 108
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 107
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Nombre")
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(330, 51)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 113
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(364, 51)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(48, 23)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 114
        Me.PictureBox11.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ImgAgregarTelefonoGrande)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.txtTlf)
        Me.Panel1.Controls.Add(Me.txtNom)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.DataRepeater1)
        Me.Panel1.Controls.Add(Me.imgTelefono1)
        Me.Panel1.Controls.Add(Me.PictureBox12)
        Me.Panel1.Location = New System.Drawing.Point(460, 299)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 250)
        Me.Panel1.TabIndex = 108
        '
        'TelefonoBindingSource
        '
        Me.TelefonoBindingSource.DataSource = GetType(Proyecto_final_curso.Telefono)
        '
        'frmEditarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1022, 821)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.imgTelefClienteGrande)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.imgClientePoblacion)
        Me.Controls.Add(Me.imgClienteDomicilio)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.imgClientePersCto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
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
        Me.Controls.Add(Me.imgAceptarGrande)
        Me.Controls.Add(Me.imgAceptarPequena)
        Me.Controls.Add(Me.imgSalirGrande)
        Me.Controls.Add(Me.imgSalirPequena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEditarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditarCliente"
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClienteNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTelefono1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClientePersCto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClienteDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClientePoblacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTelefClienteGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgAgregarTelefonoGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.imgDRPBorrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDRPAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TelefonoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgAceptarGrande As PictureBox
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
    Friend WithEvents imgAceptarPequena As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents imgClienteNombre As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents imgTelefono1 As PictureBox
    Friend WithEvents imgClientePersCto As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents imgClienteDomicilio As PictureBox
    Friend WithEvents imgClientePoblacion As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents TelefonoBindingSource As BindingSource
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents imgTelefClienteGrande As PictureBox
    Friend WithEvents txtDRPNom As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtDRPTelef As TextBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents imgDRPBorrar As PictureBox
    Friend WithEvents imgDRPAceptar As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents ImgAgregarTelefonoGrande As PictureBox
    Friend WithEvents lblDRPId As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox12 As PictureBox
End Class
