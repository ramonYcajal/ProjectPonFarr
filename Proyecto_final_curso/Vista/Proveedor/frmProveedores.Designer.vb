<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.dataRepeaterProveedores = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblPersonaContacto = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.imgModificarGrande = New System.Windows.Forms.PictureBox()
        Me.imgModificarPequena = New System.Windows.Forms.PictureBox()
        Me.imgAgregarGrande = New System.Windows.Forms.PictureBox()
        Me.imgAgregarPequena = New System.Windows.Forms.PictureBox()
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.imgFiltrarGrande = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.imgFiltrarPequena = New System.Windows.Forms.PictureBox()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuadernoDeBitácoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartesDeTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataRepeaterProveedores.ItemTemplate.SuspendLayout()
        Me.dataRepeaterProveedores.SuspendLayout()
        CType(Me.imgModificarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgModificarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAgregarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAgregarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiltrarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataRepeaterProveedores
        '
        Me.dataRepeaterProveedores.AllowUserToAddItems = False
        Me.dataRepeaterProveedores.AllowUserToDeleteItems = False
        Me.dataRepeaterProveedores.BackColor = System.Drawing.Color.Tan
        Me.dataRepeaterProveedores.DataSource = Me.ProveedorBindingSource
        Me.dataRepeaterProveedores.ItemHeaderVisible = False
        '
        'dataRepeaterProveedores.ItemTemplate
        '
        Me.dataRepeaterProveedores.ItemTemplate.Controls.Add(Me.lblEmail)
        Me.dataRepeaterProveedores.ItemTemplate.Controls.Add(Me.lblId)
        Me.dataRepeaterProveedores.ItemTemplate.Controls.Add(Me.lblPersonaContacto)
        Me.dataRepeaterProveedores.ItemTemplate.Controls.Add(Me.lblNombre)
        Me.dataRepeaterProveedores.ItemTemplate.Controls.Add(Me.imgModificarGrande)
        Me.dataRepeaterProveedores.ItemTemplate.Controls.Add(Me.imgModificarPequena)
        Me.dataRepeaterProveedores.ItemTemplate.Size = New System.Drawing.Size(986, 139)
        Me.dataRepeaterProveedores.Location = New System.Drawing.Point(16, 196)
        Me.dataRepeaterProveedores.Name = "dataRepeaterProveedores"
        Me.dataRepeaterProveedores.Size = New System.Drawing.Size(994, 521)
        Me.dataRepeaterProveedores.TabIndex = 58
        Me.dataRepeaterProveedores.Text = "DataRepeater1"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Email1", True))
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(679, 10)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(67, 25)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Label2"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Id1", True))
        Me.lblId.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(38, 56)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(40, 13)
        Me.lblId.TabIndex = 15
        Me.lblId.Text = "Label1"
        Me.lblId.Visible = False
        '
        'lblPersonaContacto
        '
        Me.lblPersonaContacto.AutoSize = True
        Me.lblPersonaContacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "PersonaContacto1", True))
        Me.lblPersonaContacto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonaContacto.Location = New System.Drawing.Point(327, 10)
        Me.lblPersonaContacto.Name = "lblPersonaContacto"
        Me.lblPersonaContacto.Size = New System.Drawing.Size(67, 25)
        Me.lblPersonaContacto.TabIndex = 13
        Me.lblPersonaContacto.Text = "Label2"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Nombre1", True))
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Maroon
        Me.lblNombre.Location = New System.Drawing.Point(7, 10)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(67, 25)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Label1"
        '
        'imgModificarGrande
        '
        Me.imgModificarGrande.Image = CType(resources.GetObject("imgModificarGrande.Image"), System.Drawing.Image)
        Me.imgModificarGrande.Location = New System.Drawing.Point(864, 45)
        Me.imgModificarGrande.Name = "imgModificarGrande"
        Me.imgModificarGrande.Size = New System.Drawing.Size(85, 86)
        Me.imgModificarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgModificarGrande.TabIndex = 17
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
        Me.imgModificarPequena.TabIndex = 18
        Me.imgModificarPequena.TabStop = False
        '
        'imgAgregarGrande
        '
        Me.imgAgregarGrande.Image = CType(resources.GetObject("imgAgregarGrande.Image"), System.Drawing.Image)
        Me.imgAgregarGrande.Location = New System.Drawing.Point(825, 729)
        Me.imgAgregarGrande.Name = "imgAgregarGrande"
        Me.imgAgregarGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgAgregarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAgregarGrande.TabIndex = 61
        Me.imgAgregarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgAgregarGrande, "Nuevo proveedor")
        '
        'imgAgregarPequena
        '
        Me.imgAgregarPequena.Image = CType(resources.GetObject("imgAgregarPequena.Image"), System.Drawing.Image)
        Me.imgAgregarPequena.Location = New System.Drawing.Point(835, 739)
        Me.imgAgregarPequena.Name = "imgAgregarPequena"
        Me.imgAgregarPequena.Size = New System.Drawing.Size(60, 60)
        Me.imgAgregarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAgregarPequena.TabIndex = 62
        Me.imgAgregarPequena.TabStop = False
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(922, 729)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 59
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
        Me.imgSalirPequena.TabIndex = 60
        Me.imgSalirPequena.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.IrAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 33)
        Me.MenuStrip1.TabIndex = 63
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Proveedor")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(331, 127)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(106, 63)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 70
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Persona de contacto")
        '
        'imgFiltrarGrande
        '
        Me.imgFiltrarGrande.Image = CType(resources.GetObject("imgFiltrarGrande.Image"), System.Drawing.Image)
        Me.imgFiltrarGrande.Location = New System.Drawing.Point(946, 33)
        Me.imgFiltrarGrande.Name = "imgFiltrarGrande"
        Me.imgFiltrarGrande.Size = New System.Drawing.Size(70, 70)
        Me.imgFiltrarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFiltrarGrande.TabIndex = 73
        Me.imgFiltrarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgFiltrarGrande, "Filtrar")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(690, 123)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(78, 71)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 75
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Correo electrónico")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(611, 52)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 76
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Filtrar por nombre")
        '
        'txtFiltro
        '
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(650, 52)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(290, 33)
        Me.txtFiltro.TabIndex = 71
        '
        'imgFiltrarPequena
        '
        Me.imgFiltrarPequena.Image = CType(resources.GetObject("imgFiltrarPequena.Image"), System.Drawing.Image)
        Me.imgFiltrarPequena.Location = New System.Drawing.Point(952, 38)
        Me.imgFiltrarPequena.Name = "imgFiltrarPequena"
        Me.imgFiltrarPequena.Size = New System.Drawing.Size(59, 59)
        Me.imgFiltrarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFiltrarPequena.TabIndex = 74
        Me.imgFiltrarPequena.TabStop = False
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.GestionarAplicaciónToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'IrAToolStripMenuItem
        '
        Me.IrAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.CorreoToolStripMenuItem, Me.CuadernoDeBitácoraToolStripMenuItem, Me.PartesDeTrabajoToolStripMenuItem, Me.RedToolStripMenuItem})
        Me.IrAToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.IrAToolStripMenuItem.Name = "IrAToolStripMenuItem"
        Me.IrAToolStripMenuItem.Size = New System.Drawing.Size(51, 29)
        Me.IrAToolStripMenuItem.Text = "Ir a"
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
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CorreoToolStripMenuItem
        '
        Me.CorreoToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.CorreoToolStripMenuItem.Image = CType(resources.GetObject("CorreoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CorreoToolStripMenuItem.Name = "CorreoToolStripMenuItem"
        Me.CorreoToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
        Me.CorreoToolStripMenuItem.Text = "Correo"
        '
        'CuadernoDeBitácoraToolStripMenuItem
        '
        Me.CuadernoDeBitácoraToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.CuadernoDeBitácoraToolStripMenuItem.Image = CType(resources.GetObject("CuadernoDeBitácoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CuadernoDeBitácoraToolStripMenuItem.Name = "CuadernoDeBitácoraToolStripMenuItem"
        Me.CuadernoDeBitácoraToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
        Me.CuadernoDeBitácoraToolStripMenuItem.Text = "Cuaderno de bitácora"
        '
        'PartesDeTrabajoToolStripMenuItem
        '
        Me.PartesDeTrabajoToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.PartesDeTrabajoToolStripMenuItem.Image = CType(resources.GetObject("PartesDeTrabajoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PartesDeTrabajoToolStripMenuItem.Name = "PartesDeTrabajoToolStripMenuItem"
        Me.PartesDeTrabajoToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
        Me.PartesDeTrabajoToolStripMenuItem.Text = "Partes de trabajo"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.RedToolStripMenuItem.Image = CType(resources.GetObject("RedToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataSource = GetType(Proyecto_final_curso.Proveedor)
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1022, 821)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dataRepeaterProveedores)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.imgFiltrarGrande)
        Me.Controls.Add(Me.imgFiltrarPequena)
        Me.Controls.Add(Me.imgAgregarGrande)
        Me.Controls.Add(Me.imgAgregarPequena)
        Me.Controls.Add(Me.imgSalirGrande)
        Me.Controls.Add(Me.imgSalirPequena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(16, 196)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProveedores"
        Me.dataRepeaterProveedores.ItemTemplate.ResumeLayout(False)
        Me.dataRepeaterProveedores.ItemTemplate.PerformLayout()
        Me.dataRepeaterProveedores.ResumeLayout(False)
        CType(Me.imgModificarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgModificarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAgregarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAgregarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFiltrarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataRepeaterProveedores As PowerPacks.DataRepeater
    Friend WithEvents imgAgregarGrande As PictureBox
    Friend WithEvents imgAgregarPequena As PictureBox
    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblPersonaContacto As Label
    Friend WithEvents imgModificarGrande As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents imgModificarPequena As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents imgFiltrarGrande As PictureBox
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents imgFiltrarPequena As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IrAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorreoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuadernoDeBitácoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartesDeTrabajoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
End Class
