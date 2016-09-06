<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblPersonaContacto = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.imgModificarGrande = New System.Windows.Forms.PictureBox()
        Me.imgModificarPequena = New System.Windows.Forms.PictureBox()
        Me.imgAgregarGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.imgAgregarPequena = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imgFiltrarGrande = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.imgFiltrarPequena = New System.Windows.Forms.PictureBox()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgModificarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgModificarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAgregarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAgregarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiltrarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataRepeater1
        '
        Me.DataRepeater1.AllowUserToAddItems = False
        Me.DataRepeater1.AllowUserToDeleteItems = False
        Me.DataRepeater1.BackColor = System.Drawing.Color.Tan
        Me.DataRepeater1.DataSource = Me.ClienteBindingSource
        Me.DataRepeater1.ItemHeaderVisible = False
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblEmail)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblId)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblTelefono)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblPersonaContacto)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.lblNombre)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgModificarGrande)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgModificarPequena)
        Me.DataRepeater1.ItemTemplate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(986, 139)
        Me.DataRepeater1.Location = New System.Drawing.Point(16, 196)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(994, 521)
        Me.DataRepeater1.TabIndex = 34
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataSource = GetType(Proyecto_final_curso.Cliente)
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Email1", True))
        Me.lblEmail.Location = New System.Drawing.Point(679, 10)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(67, 25)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Label2"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Id1", True))
        Me.lblId.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(34, 66)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(40, 13)
        Me.lblId.TabIndex = 8
        Me.lblId.Text = "Label1"
        Me.lblId.Visible = False
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Telef11", True))
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(510, 10)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(67, 25)
        Me.lblTelefono.TabIndex = 7
        Me.lblTelefono.Text = "Label3"
        '
        'lblPersonaContacto
        '
        Me.lblPersonaContacto.AutoSize = True
        Me.lblPersonaContacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "PersonaContacto1", True))
        Me.lblPersonaContacto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonaContacto.Location = New System.Drawing.Point(242, 10)
        Me.lblPersonaContacto.Name = "lblPersonaContacto"
        Me.lblPersonaContacto.Size = New System.Drawing.Size(67, 25)
        Me.lblPersonaContacto.TabIndex = 6
        Me.lblPersonaContacto.Text = "Label2"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nombre1", True))
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Maroon
        Me.lblNombre.Location = New System.Drawing.Point(7, 10)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(67, 25)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Label1"
        '
        'imgModificarGrande
        '
        Me.imgModificarGrande.Image = CType(resources.GetObject("imgModificarGrande.Image"), System.Drawing.Image)
        Me.imgModificarGrande.Location = New System.Drawing.Point(864, 45)
        Me.imgModificarGrande.Name = "imgModificarGrande"
        Me.imgModificarGrande.Size = New System.Drawing.Size(85, 86)
        Me.imgModificarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgModificarGrande.TabIndex = 10
        Me.imgModificarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgModificarGrande, "Detalles/Modificar")
        '
        'imgModificarPequena
        '
        Me.imgModificarPequena.Image = CType(resources.GetObject("imgModificarPequena.Image"), System.Drawing.Image)
        Me.imgModificarPequena.Location = New System.Drawing.Point(875, 53)
        Me.imgModificarPequena.Name = "imgModificarPequena"
        Me.imgModificarPequena.Size = New System.Drawing.Size(66, 70)
        Me.imgModificarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgModificarPequena.TabIndex = 11
        Me.imgModificarPequena.TabStop = False
        '
        'imgAgregarGrande
        '
        Me.imgAgregarGrande.Image = CType(resources.GetObject("imgAgregarGrande.Image"), System.Drawing.Image)
        Me.imgAgregarGrande.Location = New System.Drawing.Point(824, 729)
        Me.imgAgregarGrande.Name = "imgAgregarGrande"
        Me.imgAgregarGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgAgregarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAgregarGrande.TabIndex = 40
        Me.imgAgregarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgAgregarGrande, "Nuevo cliente")
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(923, 729)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 38
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
        Me.imgSalirPequena.TabIndex = 39
        Me.imgSalirPequena.TabStop = False
        '
        'imgAgregarPequena
        '
        Me.imgAgregarPequena.Image = CType(resources.GetObject("imgAgregarPequena.Image"), System.Drawing.Image)
        Me.imgAgregarPequena.Location = New System.Drawing.Point(834, 739)
        Me.imgAgregarPequena.Name = "imgAgregarPequena"
        Me.imgAgregarPequena.Size = New System.Drawing.Size(60, 60)
        Me.imgAgregarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAgregarPequena.TabIndex = 41
        Me.imgAgregarPequena.TabStop = False
        '
        'imgFiltrarGrande
        '
        Me.imgFiltrarGrande.Image = CType(resources.GetObject("imgFiltrarGrande.Image"), System.Drawing.Image)
        Me.imgFiltrarGrande.Location = New System.Drawing.Point(946, 33)
        Me.imgFiltrarGrande.Name = "imgFiltrarGrande"
        Me.imgFiltrarGrande.Size = New System.Drawing.Size(70, 70)
        Me.imgFiltrarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFiltrarGrande.TabIndex = 46
        Me.imgFiltrarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgFiltrarGrande, "Filtrar")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(237, 127)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(106, 63)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 73
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Persona de contacto")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(506, 123)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(78, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Teléfono")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Cliente")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(690, 123)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(78, 71)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 76
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Correo electrónico")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(607, 52)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(37, 33)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 77
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Filtrar por nombre")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 24)
        Me.MenuStrip1.TabIndex = 42
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'txtFiltro
        '
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(650, 52)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(290, 33)
        Me.txtFiltro.TabIndex = 44
        '
        'imgFiltrarPequena
        '
        Me.imgFiltrarPequena.Image = CType(resources.GetObject("imgFiltrarPequena.Image"), System.Drawing.Image)
        Me.imgFiltrarPequena.Location = New System.Drawing.Point(952, 38)
        Me.imgFiltrarPequena.Name = "imgFiltrarPequena"
        Me.imgFiltrarPequena.Size = New System.Drawing.Size(59, 59)
        Me.imgFiltrarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFiltrarPequena.TabIndex = 47
        Me.imgFiltrarPequena.TabStop = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1022, 821)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.DataRepeater1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.imgFiltrarGrande)
        Me.Controls.Add(Me.imgFiltrarPequena)
        Me.Controls.Add(Me.imgAgregarGrande)
        Me.Controls.Add(Me.imgAgregarPequena)
        Me.Controls.Add(Me.imgSalirGrande)
        Me.Controls.Add(Me.imgSalirPequena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClientes"
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgModificarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgModificarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAgregarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAgregarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFiltrarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents imgAgregarGrande As PictureBox
    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
    Friend WithEvents imgAgregarPequena As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblPersonaContacto As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents imgFiltrarGrande As PictureBox
    Friend WithEvents imgFiltrarPequena As PictureBox
    Friend WithEvents imgModificarGrande As PictureBox
    Friend WithEvents imgModificarPequena As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
