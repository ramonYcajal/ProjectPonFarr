<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionMaterial))
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPvp = New System.Windows.Forms.TextBox()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.imgAceptarGrande = New System.Windows.Forms.PictureBox()
        Me.imgAceptarPequena = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgBorrarGrande = New System.Windows.Forms.PictureBox()
        Me.imgFiltrarGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.txtMateriales = New System.Windows.Forms.TextBox()
        Me.imgBorrarPequena = New System.Windows.Forms.PictureBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBorrarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBorrarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataRepeater1
        '
        Me.DataRepeater1.AllowUserToAddItems = False
        Me.DataRepeater1.AllowUserToDeleteItems = False
        Me.DataRepeater1.DataSource = Me.MaterialBindingSource
        Me.DataRepeater1.ItemHeaderVisible = False
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.txtPvp)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.txtMaterial)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgAceptarGrande)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgAceptarPequena)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(388, 160)
        Me.DataRepeater1.Location = New System.Drawing.Point(13, 100)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(396, 198)
        Me.DataRepeater1.TabIndex = 1
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'MaterialBindingSource
        '
        Me.MaterialBindingSource.DataSource = GetType(Proyecto_final_curso.Material)
        '
        'txtPvp
        '
        Me.txtPvp.BackColor = System.Drawing.Color.Tan
        Me.txtPvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPvp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "pvp1", True))
        Me.txtPvp.Enabled = False
        Me.txtPvp.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPvp.Location = New System.Drawing.Point(242, 122)
        Me.txtPvp.Multiline = True
        Me.txtPvp.Name = "txtPvp"
        Me.txtPvp.Size = New System.Drawing.Size(113, 30)
        Me.txtPvp.TabIndex = 70
        '
        'txtMaterial
        '
        Me.txtMaterial.BackColor = System.Drawing.Color.Tan
        Me.txtMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaterial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "Material1", True))
        Me.txtMaterial.Enabled = False
        Me.txtMaterial.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterial.Location = New System.Drawing.Point(-2, 3)
        Me.txtMaterial.Multiline = True
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(312, 89)
        Me.txtMaterial.TabIndex = 69
        '
        'imgAceptarGrande
        '
        Me.imgAceptarGrande.Image = CType(resources.GetObject("imgAceptarGrande.Image"), System.Drawing.Image)
        Me.imgAceptarGrande.Location = New System.Drawing.Point(316, 28)
        Me.imgAceptarGrande.Name = "imgAceptarGrande"
        Me.imgAceptarGrande.Size = New System.Drawing.Size(40, 42)
        Me.imgAceptarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarGrande.TabIndex = 67
        Me.imgAceptarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgAceptarGrande, "Seleccionar")
        '
        'imgAceptarPequena
        '
        Me.imgAceptarPequena.Image = CType(resources.GetObject("imgAceptarPequena.Image"), System.Drawing.Image)
        Me.imgAceptarPequena.Location = New System.Drawing.Point(317, 29)
        Me.imgAceptarPequena.Name = "imgAceptarPequena"
        Me.imgAceptarPequena.Size = New System.Drawing.Size(38, 40)
        Me.imgAceptarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarPequena.TabIndex = 68
        Me.imgAceptarPequena.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "¿Material?")
        '
        'imgBorrarGrande
        '
        Me.imgBorrarGrande.Image = CType(resources.GetObject("imgBorrarGrande.Image"), System.Drawing.Image)
        Me.imgBorrarGrande.Location = New System.Drawing.Point(40, 476)
        Me.imgBorrarGrande.Name = "imgBorrarGrande"
        Me.imgBorrarGrande.Size = New System.Drawing.Size(84, 35)
        Me.imgBorrarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBorrarGrande.TabIndex = 80
        Me.imgBorrarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgBorrarGrande, "Borrar técnico(s)")
        '
        'imgFiltrarGrande
        '
        Me.imgFiltrarGrande.Image = CType(resources.GetObject("imgFiltrarGrande.Image"), System.Drawing.Image)
        Me.imgFiltrarGrande.Location = New System.Drawing.Point(380, 33)
        Me.imgFiltrarGrande.Name = "imgFiltrarGrande"
        Me.imgFiltrarGrande.Size = New System.Drawing.Size(28, 33)
        Me.imgFiltrarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFiltrarGrande.TabIndex = 83
        Me.imgFiltrarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgFiltrarGrande, "Filtrar")
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(362, 476)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(43, 43)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 73
        Me.imgSalirGrande.TabStop = False
        '
        'imgSalirPequena
        '
        Me.imgSalirPequena.Image = CType(resources.GetObject("imgSalirPequena.Image"), System.Drawing.Image)
        Me.imgSalirPequena.Location = New System.Drawing.Point(363, 477)
        Me.imgSalirPequena.Name = "imgSalirPequena"
        Me.imgSalirPequena.Size = New System.Drawing.Size(41, 41)
        Me.imgSalirPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirPequena.TabIndex = 74
        Me.imgSalirPequena.TabStop = False
        '
        'txtMateriales
        '
        Me.txtMateriales.BackColor = System.Drawing.Color.Tan
        Me.txtMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMateriales.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMateriales.Location = New System.Drawing.Point(18, 314)
        Me.txtMateriales.Multiline = True
        Me.txtMateriales.Name = "txtMateriales"
        Me.txtMateriales.ReadOnly = True
        Me.txtMateriales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMateriales.Size = New System.Drawing.Size(385, 124)
        Me.txtMateriales.TabIndex = 75
        '
        'imgBorrarPequena
        '
        Me.imgBorrarPequena.Image = CType(resources.GetObject("imgBorrarPequena.Image"), System.Drawing.Image)
        Me.imgBorrarPequena.Location = New System.Drawing.Point(42, 478)
        Me.imgBorrarPequena.Name = "imgBorrarPequena"
        Me.imgBorrarPequena.Size = New System.Drawing.Size(80, 31)
        Me.imgBorrarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBorrarPequena.TabIndex = 81
        Me.imgBorrarPequena.TabStop = False
        '
        'txtFiltro
        '
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(93, 33)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(281, 33)
        Me.txtFiltro.TabIndex = 82
        '
        'frmSeleccionMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(421, 531)
        Me.Controls.Add(Me.imgFiltrarGrande)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.imgBorrarGrande)
        Me.Controls.Add(Me.imgBorrarPequena)
        Me.Controls.Add(Me.txtMateriales)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataRepeater1)
        Me.Controls.Add(Me.imgSalirGrande)
        Me.Controls.Add(Me.imgSalirPequena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSeleccionMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSeleccionMaterial"
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBorrarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBorrarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents imgAceptarGrande As PictureBox
    Friend WithEvents imgAceptarPequena As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialBindingSource As BindingSource
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
    Friend WithEvents txtMateriales As TextBox
    Friend WithEvents imgBorrarGrande As PictureBox
    Friend WithEvents imgBorrarPequena As PictureBox
    Friend WithEvents txtPvp As TextBox
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents imgFiltrarGrande As PictureBox
End Class
