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
        Me.imgAceptarGrande = New System.Windows.Forms.PictureBox()
        Me.imgAceptarPequena = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.TextBox1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgAceptarGrande)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.imgAceptarPequena)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(388, 100)
        Me.DataRepeater1.Location = New System.Drawing.Point(13, 100)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(396, 198)
        Me.DataRepeater1.TabIndex = 1
        Me.DataRepeater1.Text = "DataRepeater1"
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
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Tan
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "Material1", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(-2, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(312, 89)
        Me.TextBox1.TabIndex = 69
        '
        'MaterialBindingSource
        '
        Me.MaterialBindingSource.DataSource = GetType(Proyecto_final_curso.Material)
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(362, 318)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(43, 43)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 73
        Me.imgSalirGrande.TabStop = False
        '
        'imgSalirPequena
        '
        Me.imgSalirPequena.Image = CType(resources.GetObject("imgSalirPequena.Image"), System.Drawing.Image)
        Me.imgSalirPequena.Location = New System.Drawing.Point(363, 319)
        Me.imgSalirPequena.Name = "imgSalirPequena"
        Me.imgSalirPequena.Size = New System.Drawing.Size(41, 41)
        Me.imgSalirPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirPequena.TabIndex = 74
        Me.imgSalirPequena.TabStop = False
        '
        'frmSeleccionMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(421, 371)
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
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents imgAceptarGrande As PictureBox
    Friend WithEvents imgAceptarPequena As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialBindingSource As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
End Class
