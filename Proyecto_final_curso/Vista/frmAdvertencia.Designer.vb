<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvertencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdvertencia))
        Me.txtAviso = New System.Windows.Forms.TextBox()
        Me.lblPonFarr = New System.Windows.Forms.Label()
        Me.imgAceptarGrande = New System.Windows.Forms.PictureBox()
        Me.imgAceptarPequena = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAviso
        '
        Me.txtAviso.BackColor = System.Drawing.Color.Tan
        Me.txtAviso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAviso.Enabled = False
        Me.txtAviso.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAviso.Location = New System.Drawing.Point(17, 37)
        Me.txtAviso.Multiline = True
        Me.txtAviso.Name = "txtAviso"
        Me.txtAviso.Size = New System.Drawing.Size(375, 148)
        Me.txtAviso.TabIndex = 0
        '
        'lblPonFarr
        '
        Me.lblPonFarr.AutoSize = True
        Me.lblPonFarr.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPonFarr.ForeColor = System.Drawing.Color.Black
        Me.lblPonFarr.Location = New System.Drawing.Point(293, 9)
        Me.lblPonFarr.Name = "lblPonFarr"
        Me.lblPonFarr.Size = New System.Drawing.Size(89, 25)
        Me.lblPonFarr.TabIndex = 65
        Me.lblPonFarr.Text = "Pon Farr"
        '
        'imgAceptarGrande
        '
        Me.imgAceptarGrande.Image = CType(resources.GetObject("imgAceptarGrande.Image"), System.Drawing.Image)
        Me.imgAceptarGrande.Location = New System.Drawing.Point(357, 191)
        Me.imgAceptarGrande.Name = "imgAceptarGrande"
        Me.imgAceptarGrande.Size = New System.Drawing.Size(35, 44)
        Me.imgAceptarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarGrande.TabIndex = 71
        Me.imgAceptarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgAceptarGrande, "Aceptar")
        '
        'imgAceptarPequena
        '
        Me.imgAceptarPequena.Image = CType(resources.GetObject("imgAceptarPequena.Image"), System.Drawing.Image)
        Me.imgAceptarPequena.Location = New System.Drawing.Point(362, 196)
        Me.imgAceptarPequena.Name = "imgAceptarPequena"
        Me.imgAceptarPequena.Size = New System.Drawing.Size(25, 34)
        Me.imgAceptarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarPequena.TabIndex = 72
        Me.imgAceptarPequena.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtAviso)
        Me.Panel1.Controls.Add(Me.lblPonFarr)
        Me.Panel1.Controls.Add(Me.imgAceptarGrande)
        Me.Panel1.Controls.Add(Me.imgAceptarPequena)
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 256)
        Me.Panel1.TabIndex = 73
        '
        'frmAdvertencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(419, 262)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Tan
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdvertencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdvertencia"
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtAviso As TextBox
    Friend WithEvents lblPonFarr As Label
    Friend WithEvents imgAceptarGrande As PictureBox
    Friend WithEvents imgAceptarPequena As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolTip1 As ToolTip
End Class
