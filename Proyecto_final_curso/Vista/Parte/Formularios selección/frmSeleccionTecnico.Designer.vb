<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionTecnico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionTecnico))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.imgAceptarGrande = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imgBorrarGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.txtTecnicos = New System.Windows.Forms.TextBox()
        Me.imgBorrarPequena = New System.Windows.Forms.PictureBox()
        Me.imgFiltrarGrande = New System.Windows.Forms.PictureBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBorrarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBorrarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "¿Tecnico reparador?")
        '
        'DataRepeater1
        '
        Me.DataRepeater1.AllowUserToAddItems = False
        Me.DataRepeater1.AllowUserToDeleteItems = False
        Me.DataRepeater1.DataSource = Me.UsuarioBindingSource
        Me.DataRepeater1.ItemHeaderVisible = False
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.txtNombre)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgAceptarGrande)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox3)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(388, 100)
        Me.DataRepeater1.Location = New System.Drawing.Point(13, 100)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(396, 198)
        Me.DataRepeater1.TabIndex = 2
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataSource = GetType(Proyecto_final_curso.Usuario)
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.Tan
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Nombre1", True))
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(22, 28)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(258, 28)
        Me.txtNombre.TabIndex = 0
        '
        'imgAceptarGrande
        '
        Me.imgAceptarGrande.Image = CType(resources.GetObject("imgAceptarGrande.Image"), System.Drawing.Image)
        Me.imgAceptarGrande.Location = New System.Drawing.Point(316, 28)
        Me.imgAceptarGrande.Name = "imgAceptarGrande"
        Me.imgAceptarGrande.Size = New System.Drawing.Size(40, 42)
        Me.imgAceptarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarGrande.TabIndex = 69
        Me.imgAceptarGrande.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(317, 29)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(38, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 70
        Me.PictureBox3.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'imgBorrarGrande
        '
        Me.imgBorrarGrande.Image = CType(resources.GetObject("imgBorrarGrande.Image"), System.Drawing.Image)
        Me.imgBorrarGrande.Location = New System.Drawing.Point(41, 476)
        Me.imgBorrarGrande.Name = "imgBorrarGrande"
        Me.imgBorrarGrande.Size = New System.Drawing.Size(84, 35)
        Me.imgBorrarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBorrarGrande.TabIndex = 78
        Me.imgBorrarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgBorrarGrande, "Borrar técnico(s)")
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(362, 476)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(43, 43)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 71
        Me.imgSalirGrande.TabStop = False
        '
        'imgSalirPequena
        '
        Me.imgSalirPequena.Image = CType(resources.GetObject("imgSalirPequena.Image"), System.Drawing.Image)
        Me.imgSalirPequena.Location = New System.Drawing.Point(363, 477)
        Me.imgSalirPequena.Name = "imgSalirPequena"
        Me.imgSalirPequena.Size = New System.Drawing.Size(41, 41)
        Me.imgSalirPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirPequena.TabIndex = 72
        Me.imgSalirPequena.TabStop = False
        '
        'txtTecnicos
        '
        Me.txtTecnicos.BackColor = System.Drawing.Color.Tan
        Me.txtTecnicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTecnicos.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTecnicos.Location = New System.Drawing.Point(18, 314)
        Me.txtTecnicos.Multiline = True
        Me.txtTecnicos.Name = "txtTecnicos"
        Me.txtTecnicos.ReadOnly = True
        Me.txtTecnicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTecnicos.Size = New System.Drawing.Size(385, 124)
        Me.txtTecnicos.TabIndex = 73
        '
        'imgBorrarPequena
        '
        Me.imgBorrarPequena.Image = CType(resources.GetObject("imgBorrarPequena.Image"), System.Drawing.Image)
        Me.imgBorrarPequena.Location = New System.Drawing.Point(43, 478)
        Me.imgBorrarPequena.Name = "imgBorrarPequena"
        Me.imgBorrarPequena.Size = New System.Drawing.Size(80, 31)
        Me.imgBorrarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBorrarPequena.TabIndex = 79
        Me.imgBorrarPequena.TabStop = False
        '
        'imgFiltrarGrande
        '
        Me.imgFiltrarGrande.Image = CType(resources.GetObject("imgFiltrarGrande.Image"), System.Drawing.Image)
        Me.imgFiltrarGrande.Location = New System.Drawing.Point(381, 35)
        Me.imgFiltrarGrande.Name = "imgFiltrarGrande"
        Me.imgFiltrarGrande.Size = New System.Drawing.Size(28, 33)
        Me.imgFiltrarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFiltrarGrande.TabIndex = 85
        Me.imgFiltrarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgFiltrarGrande, "Filtrar")
        '
        'txtFiltro
        '
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(94, 35)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(281, 33)
        Me.txtFiltro.TabIndex = 84
        '
        'frmSeleccionTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(421, 531)
        Me.Controls.Add(Me.imgFiltrarGrande)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.imgBorrarGrande)
        Me.Controls.Add(Me.imgBorrarPequena)
        Me.Controls.Add(Me.txtTecnicos)
        Me.Controls.Add(Me.DataRepeater1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.imgSalirGrande)
        Me.Controls.Add(Me.imgSalirPequena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSeleccionTecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSeleccionTecnico"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBorrarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBorrarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents imgAceptarGrande As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
    Friend WithEvents txtTecnicos As TextBox
    Friend WithEvents imgBorrarGrande As PictureBox
    Friend WithEvents imgBorrarPequena As PictureBox
    Friend WithEvents imgFiltrarGrande As PictureBox
    Friend WithEvents txtFiltro As TextBox
End Class
