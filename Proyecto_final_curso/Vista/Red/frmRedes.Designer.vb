<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRedes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRedes))
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.RedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblIpServidor = New System.Windows.Forms.Label()
        Me.lblNombreServidor = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.imgModificarGrande = New System.Windows.Forms.PictureBox()
        Me.imgModificarPequena = New System.Windows.Forms.PictureBox()
        Me.imgAgregarGrande = New System.Windows.Forms.PictureBox()
        Me.imgAgregarPequena = New System.Windows.Forms.PictureBox()
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.imgFiltrarGrande = New System.Windows.Forms.PictureBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.imgFiltrarPequena = New System.Windows.Forms.PictureBox()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuadernoDeBitácoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartesDeTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.RedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgModificarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgModificarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAgregarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAgregarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiltrarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataRepeater1
        '
        Me.DataRepeater1.AllowUserToAddItems = False
        Me.DataRepeater1.AllowUserToDeleteItems = False
        Me.DataRepeater1.BackColor = System.Drawing.Color.Tan
        Me.DataRepeater1.DataSource = Me.RedBindingSource
        Me.DataRepeater1.ItemHeaderVisible = False
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblGrupo)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblIpServidor)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblNombreServidor)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblId)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblCliente)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgModificarGrande)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgModificarPequena)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(986, 139)
        Me.DataRepeater1.Location = New System.Drawing.Point(16, 196)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(994, 521)
        Me.DataRepeater1.TabIndex = 0
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'RedBindingSource
        '
        Me.RedBindingSource.DataSource = GetType(Proyecto_final_curso.Red)
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RedBindingSource, "Grupo1", True))
        Me.lblGrupo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.Location = New System.Drawing.Point(683, 10)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(67, 25)
        Me.lblGrupo.TabIndex = 4
        Me.lblGrupo.Text = "Label5"
        '
        'lblIpServidor
        '
        Me.lblIpServidor.AutoSize = True
        Me.lblIpServidor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RedBindingSource, "ServidorIp1", True))
        Me.lblIpServidor.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIpServidor.Location = New System.Drawing.Point(484, 10)
        Me.lblIpServidor.Name = "lblIpServidor"
        Me.lblIpServidor.Size = New System.Drawing.Size(67, 25)
        Me.lblIpServidor.TabIndex = 3
        Me.lblIpServidor.Text = "Label4"
        '
        'lblNombreServidor
        '
        Me.lblNombreServidor.AutoSize = True
        Me.lblNombreServidor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RedBindingSource, "NombreServidor1", True))
        Me.lblNombreServidor.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreServidor.Location = New System.Drawing.Point(259, 10)
        Me.lblNombreServidor.Name = "lblNombreServidor"
        Me.lblNombreServidor.Size = New System.Drawing.Size(67, 25)
        Me.lblNombreServidor.TabIndex = 2
        Me.lblNombreServidor.Text = "Label3"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RedBindingSource, "Id1", True))
        Me.lblId.Location = New System.Drawing.Point(1, 110)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(39, 13)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "Label2"
        Me.lblId.Visible = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RedBindingSource, "Cliente1", True))
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Maroon
        Me.lblCliente.Location = New System.Drawing.Point(7, 10)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(67, 25)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Label1"
        '
        'imgModificarGrande
        '
        Me.imgModificarGrande.Image = CType(resources.GetObject("imgModificarGrande.Image"), System.Drawing.Image)
        Me.imgModificarGrande.Location = New System.Drawing.Point(864, 45)
        Me.imgModificarGrande.Name = "imgModificarGrande"
        Me.imgModificarGrande.Size = New System.Drawing.Size(85, 86)
        Me.imgModificarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgModificarGrande.TabIndex = 12
        Me.imgModificarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgModificarGrande, "Modificar")
        '
        'imgModificarPequena
        '
        Me.imgModificarPequena.Image = CType(resources.GetObject("imgModificarPequena.Image"), System.Drawing.Image)
        Me.imgModificarPequena.Location = New System.Drawing.Point(875, 53)
        Me.imgModificarPequena.Name = "imgModificarPequena"
        Me.imgModificarPequena.Size = New System.Drawing.Size(66, 70)
        Me.imgModificarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgModificarPequena.TabIndex = 13
        Me.imgModificarPequena.TabStop = False
        '
        'imgAgregarGrande
        '
        Me.imgAgregarGrande.Image = CType(resources.GetObject("imgAgregarGrande.Image"), System.Drawing.Image)
        Me.imgAgregarGrande.Location = New System.Drawing.Point(824, 729)
        Me.imgAgregarGrande.Name = "imgAgregarGrande"
        Me.imgAgregarGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgAgregarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAgregarGrande.TabIndex = 44
        Me.imgAgregarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgAgregarGrande, "Nuevo")
        '
        'imgAgregarPequena
        '
        Me.imgAgregarPequena.Image = CType(resources.GetObject("imgAgregarPequena.Image"), System.Drawing.Image)
        Me.imgAgregarPequena.Location = New System.Drawing.Point(834, 739)
        Me.imgAgregarPequena.Name = "imgAgregarPequena"
        Me.imgAgregarPequena.Size = New System.Drawing.Size(60, 60)
        Me.imgAgregarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAgregarPequena.TabIndex = 45
        Me.imgAgregarPequena.TabStop = False
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(923, 729)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 42
        Me.imgSalirGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgSalirGrande, "Salir")
        '
        'imgSalirPequena
        '
        Me.imgSalirPequena.Image = CType(resources.GetObject("imgSalirPequena.Image"), System.Drawing.Image)
        Me.imgSalirPequena.Location = New System.Drawing.Point(933, 739)
        Me.imgSalirPequena.Name = "imgSalirPequena"
        Me.imgSalirPequena.Size = New System.Drawing.Size(60, 60)
        Me.imgSalirPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirPequena.TabIndex = 43
        Me.imgSalirPequena.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.IrAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 33)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Cliente")
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(270, 124)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(78, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Nombre del servidor")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(495, 124)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(78, 70)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 49
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "IP del servidor")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(694, 124)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(78, 70)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 50
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Grupo de trabajo")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(607, 52)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(37, 33)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 81
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Filtrar por nombre")
        '
        'imgFiltrarGrande
        '
        Me.imgFiltrarGrande.Image = CType(resources.GetObject("imgFiltrarGrande.Image"), System.Drawing.Image)
        Me.imgFiltrarGrande.Location = New System.Drawing.Point(946, 33)
        Me.imgFiltrarGrande.Name = "imgFiltrarGrande"
        Me.imgFiltrarGrande.Size = New System.Drawing.Size(70, 70)
        Me.imgFiltrarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFiltrarGrande.TabIndex = 79
        Me.imgFiltrarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgFiltrarGrande, "Filtrar")
        '
        'txtFiltro
        '
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(650, 52)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(290, 33)
        Me.txtFiltro.TabIndex = 78
        '
        'imgFiltrarPequena
        '
        Me.imgFiltrarPequena.Image = CType(resources.GetObject("imgFiltrarPequena.Image"), System.Drawing.Image)
        Me.imgFiltrarPequena.Location = New System.Drawing.Point(952, 39)
        Me.imgFiltrarPequena.Name = "imgFiltrarPequena"
        Me.imgFiltrarPequena.Size = New System.Drawing.Size(59, 59)
        Me.imgFiltrarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFiltrarPequena.TabIndex = 80
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
        Me.IrAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.CorreoToolStripMenuItem, Me.CuadernoDeBitácoraToolStripMenuItem, Me.PartesDeTrabajoToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
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
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.ProveedoresToolStripMenuItem.Image = CType(resources.GetObject("ProveedoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.Tan
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
        'frmRedes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1022, 821)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.imgAgregarGrande)
        Me.Controls.Add(Me.imgAgregarPequena)
        Me.Controls.Add(Me.DataRepeater1)
        Me.Controls.Add(Me.imgSalirGrande)
        Me.Controls.Add(Me.imgSalirPequena)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.imgFiltrarGrande)
        Me.Controls.Add(Me.imgFiltrarPequena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRedes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRedes"
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.RedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgModificarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgModificarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAgregarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAgregarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RedBindingSource As BindingSource
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblGrupo As Label
    Friend WithEvents lblIpServidor As Label
    Friend WithEvents lblNombreServidor As Label
    Friend WithEvents lblId As Label
    Friend WithEvents imgModificarGrande As PictureBox
    Friend WithEvents imgModificarPequena As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents imgFiltrarGrande As PictureBox
    Friend WithEvents imgFiltrarPequena As PictureBox
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IrAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorreoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuadernoDeBitácoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartesDeTrabajoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
End Class
