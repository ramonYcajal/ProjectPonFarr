<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartes))
        Me.menuPartes = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarAplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtBuscaSN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscaCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imgAgregarGrande = New System.Windows.Forms.PictureBox()
        Me.imgAgregarPequena = New System.Windows.Forms.PictureBox()
        Me.imgFiltrarGrande = New System.Windows.Forms.PictureBox()
        Me.imgFiltrarPequena = New System.Windows.Forms.PictureBox()
        Me.menuPartes.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAgregarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAgregarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiltrarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuPartes
        '
        Me.menuPartes.BackColor = System.Drawing.Color.Tan
        Me.menuPartes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.IrAToolStripMenuItem})
        Me.menuPartes.Location = New System.Drawing.Point(0, 0)
        Me.menuPartes.Name = "menuPartes"
        Me.menuPartes.Size = New System.Drawing.Size(1022, 33)
        Me.menuPartes.TabIndex = 0
        Me.menuPartes.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.GestionarAplicacionToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(258, 30)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GestionarAplicacionToolStripMenuItem
        '
        Me.GestionarAplicacionToolStripMenuItem.BackColor = System.Drawing.Color.Tan
        Me.GestionarAplicacionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestionarAplicacionToolStripMenuItem.Name = "GestionarAplicacionToolStripMenuItem"
        Me.GestionarAplicacionToolStripMenuItem.Size = New System.Drawing.Size(258, 30)
        Me.GestionarAplicacionToolStripMenuItem.Text = "Gestionar Aplicacion"
        '
        'IrAToolStripMenuItem
        '
        Me.IrAToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IrAToolStripMenuItem.Name = "IrAToolStripMenuItem"
        Me.IrAToolStripMenuItem.Size = New System.Drawing.Size(63, 29)
        Me.IrAToolStripMenuItem.Text = "Ir a..."
        '
        'txtBuscaSN
        '
        Me.txtBuscaSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscaSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaSN.Location = New System.Drawing.Point(678, 76)
        Me.txtBuscaSN.Name = "txtBuscaSN"
        Me.txtBuscaSN.Size = New System.Drawing.Size(262, 29)
        Me.txtBuscaSN.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(485, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = " NÚMERO DE SERIE"
        '
        'txtBuscaCliente
        '
        Me.txtBuscaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaCliente.Location = New System.Drawing.Point(678, 35)
        Me.txtBuscaCliente.Name = "txtBuscaCliente"
        Me.txtBuscaCliente.Size = New System.Drawing.Size(262, 29)
        Me.txtBuscaCliente.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(578, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 24)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = " CLIENTE"
        '
        'DataRepeater1
        '
        Me.DataRepeater1.AllowUserToAddItems = False
        Me.DataRepeater1.AllowUserToDeleteItems = False
        Me.DataRepeater1.BackColor = System.Drawing.Color.Tan
        Me.DataRepeater1.ItemHeaderVisible = False
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(979, 100)
        Me.DataRepeater1.Location = New System.Drawing.Point(16, 196)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(987, 521)
        Me.DataRepeater1.TabIndex = 33
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(923, 729)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 34
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
        Me.imgSalirPequena.TabIndex = 35
        Me.imgSalirPequena.TabStop = False
        '
        'imgAgregarGrande
        '
        Me.imgAgregarGrande.Image = CType(resources.GetObject("imgAgregarGrande.Image"), System.Drawing.Image)
        Me.imgAgregarGrande.Location = New System.Drawing.Point(824, 729)
        Me.imgAgregarGrande.Name = "imgAgregarGrande"
        Me.imgAgregarGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgAgregarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAgregarGrande.TabIndex = 36
        Me.imgAgregarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgAgregarGrande, "Nuevo parte")
        '
        'imgAgregarPequena
        '
        Me.imgAgregarPequena.Image = CType(resources.GetObject("imgAgregarPequena.Image"), System.Drawing.Image)
        Me.imgAgregarPequena.Location = New System.Drawing.Point(834, 739)
        Me.imgAgregarPequena.Name = "imgAgregarPequena"
        Me.imgAgregarPequena.Size = New System.Drawing.Size(60, 60)
        Me.imgAgregarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAgregarPequena.TabIndex = 37
        Me.imgAgregarPequena.TabStop = False
        '
        'imgFiltrarGrande
        '
        Me.imgFiltrarGrande.Image = CType(resources.GetObject("imgFiltrarGrande.Image"), System.Drawing.Image)
        Me.imgFiltrarGrande.Location = New System.Drawing.Point(946, 33)
        Me.imgFiltrarGrande.Name = "imgFiltrarGrande"
        Me.imgFiltrarGrande.Size = New System.Drawing.Size(70, 70)
        Me.imgFiltrarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFiltrarGrande.TabIndex = 48
        Me.imgFiltrarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgFiltrarGrande, "Filtrar")
        '
        'imgFiltrarPequena
        '
        Me.imgFiltrarPequena.Image = CType(resources.GetObject("imgFiltrarPequena.Image"), System.Drawing.Image)
        Me.imgFiltrarPequena.Location = New System.Drawing.Point(951, 38)
        Me.imgFiltrarPequena.Name = "imgFiltrarPequena"
        Me.imgFiltrarPequena.Size = New System.Drawing.Size(59, 59)
        Me.imgFiltrarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFiltrarPequena.TabIndex = 49
        Me.imgFiltrarPequena.TabStop = False
        '
        'frmPartes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1022, 821)
        Me.Controls.Add(Me.imgAgregarGrande)
        Me.Controls.Add(Me.imgSalirGrande)
        Me.Controls.Add(Me.imgSalirPequena)
        Me.Controls.Add(Me.DataRepeater1)
        Me.Controls.Add(Me.txtBuscaSN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscaCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menuPartes)
        Me.Controls.Add(Me.imgAgregarPequena)
        Me.Controls.Add(Me.imgFiltrarGrande)
        Me.Controls.Add(Me.imgFiltrarPequena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.menuPartes
        Me.Name = "frmPartes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClientes"
        Me.menuPartes.ResumeLayout(False)
        Me.menuPartes.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAgregarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAgregarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFiltrarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFiltrarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuPartes As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarAplicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IrAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtBuscaSN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscaCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents imgAgregarGrande As PictureBox
    Friend WithEvents imgAgregarPequena As PictureBox
    Friend WithEvents imgFiltrarGrande As PictureBox
    Friend WithEvents imgFiltrarPequena As PictureBox
End Class
