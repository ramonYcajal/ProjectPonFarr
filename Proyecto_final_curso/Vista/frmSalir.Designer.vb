<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalir))
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.lblPonFarr = New System.Windows.Forms.Label()
        Me.imgAceptarGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.imgAceptarPequena = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.Color.Tan
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Enabled = False
        Me.txtMensaje.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(19, 28)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(308, 71)
        Me.txtMensaje.TabIndex = 0
        '
        'lblPonFarr
        '
        Me.lblPonFarr.AutoSize = True
        Me.lblPonFarr.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPonFarr.ForeColor = System.Drawing.Color.Black
        Me.lblPonFarr.Location = New System.Drawing.Point(301, 0)
        Me.lblPonFarr.Name = "lblPonFarr"
        Me.lblPonFarr.Size = New System.Drawing.Size(89, 25)
        Me.lblPonFarr.TabIndex = 66
        Me.lblPonFarr.Text = "Pon Farr"
        '
        'imgAceptarGrande
        '
        Me.imgAceptarGrande.Image = CType(resources.GetObject("imgAceptarGrande.Image"), System.Drawing.Image)
        Me.imgAceptarGrande.Location = New System.Drawing.Point(306, 192)
        Me.imgAceptarGrande.Name = "imgAceptarGrande"
        Me.imgAceptarGrande.Size = New System.Drawing.Size(35, 44)
        Me.imgAceptarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarGrande.TabIndex = 69
        Me.imgAceptarGrande.TabStop = False
        Me.imgAceptarGrande.Tag = ""
        Me.ToolTip1.SetToolTip(Me.imgAceptarGrande, "Aceptar/Salir")
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(350, 196)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(40, 40)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 67
        Me.imgSalirGrande.TabStop = False
        Me.imgSalirGrande.Tag = ""
        Me.ToolTip1.SetToolTip(Me.imgSalirGrande, "Cancelar")
        '
        'imgSalirPequena
        '
        Me.imgSalirPequena.Image = CType(resources.GetObject("imgSalirPequena.Image"), System.Drawing.Image)
        Me.imgSalirPequena.Location = New System.Drawing.Point(352, 198)
        Me.imgSalirPequena.Name = "imgSalirPequena"
        Me.imgSalirPequena.Size = New System.Drawing.Size(36, 36)
        Me.imgSalirPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirPequena.TabIndex = 68
        Me.imgSalirPequena.TabStop = False
        '
        'imgAceptarPequena
        '
        Me.imgAceptarPequena.Image = CType(resources.GetObject("imgAceptarPequena.Image"), System.Drawing.Image)
        Me.imgAceptarPequena.Location = New System.Drawing.Point(310, 196)
        Me.imgAceptarPequena.Name = "imgAceptarPequena"
        Me.imgAceptarPequena.Size = New System.Drawing.Size(27, 36)
        Me.imgAceptarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarPequena.TabIndex = 70
        Me.imgAceptarPequena.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtMensaje)
        Me.Panel1.Controls.Add(Me.lblPonFarr)
        Me.Panel1.Controls.Add(Me.imgAceptarGrande)
        Me.Panel1.Controls.Add(Me.imgAceptarPequena)
        Me.Panel1.Controls.Add(Me.imgSalirGrande)
        Me.Panel1.Controls.Add(Me.imgSalirPequena)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 241)
        Me.Panel1.TabIndex = 71
        '
        'frmSalir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(419, 262)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSalir"
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents lblPonFarr As Label
    Friend WithEvents imgAceptarGrande As PictureBox
    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
    Friend WithEvents imgAceptarPequena As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolTip1 As ToolTip
End Class
