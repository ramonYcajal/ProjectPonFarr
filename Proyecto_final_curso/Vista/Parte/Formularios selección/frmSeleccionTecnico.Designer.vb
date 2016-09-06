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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox2)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.PictureBox3)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(388, 100)
        Me.DataRepeater1.Location = New System.Drawing.Point(13, 100)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(396, 198)
        Me.DataRepeater1.TabIndex = 2
        Me.DataRepeater1.Text = "DataRepeater1"
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
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(316, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 69
        Me.PictureBox2.TabStop = False
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
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(362, 318)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(43, 43)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 71
        Me.imgSalirGrande.TabStop = False
        '
        'imgSalirPequena
        '
        Me.imgSalirPequena.Image = CType(resources.GetObject("imgSalirPequena.Image"), System.Drawing.Image)
        Me.imgSalirPequena.Location = New System.Drawing.Point(363, 319)
        Me.imgSalirPequena.Name = "imgSalirPequena"
        Me.imgSalirPequena.Size = New System.Drawing.Size(41, 41)
        Me.imgSalirPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirPequena.TabIndex = 72
        Me.imgSalirPequena.TabStop = False
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataSource = GetType(Proyecto_final_curso.Usuario)
        '
        'frmSeleccionTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(421, 371)
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
End Class
