<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteNuevo
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim NifLabel As System.Windows.Forms.Label
        Dim PersctoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim DomicilioLabel As System.Windows.Forms.Label
        Dim PoblacionLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim Telef1Label As System.Windows.Forms.Label
        Dim Telef2Label As System.Windows.Forms.Label
        Dim CodposLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteNuevo))
        Me.imgSalirGrande = New System.Windows.Forms.PictureBox()
        Me.imgSalirPequena = New System.Windows.Forms.PictureBox()
        Me.CodigoLabel1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCif = New System.Windows.Forms.TextBox()
        Me.txtPersoCto = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtTelef1 = New System.Windows.Forms.TextBox()
        Me.txtTelef2 = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.imgAceptarGrande = New System.Windows.Forms.PictureBox()
        Me.imgAceptarPequena = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        NombreLabel = New System.Windows.Forms.Label()
        NifLabel = New System.Windows.Forms.Label()
        PersctoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        DomicilioLabel = New System.Windows.Forms.Label()
        PoblacionLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        Telef1Label = New System.Windows.Forms.Label()
        Telef2Label = New System.Windows.Forms.Label()
        CodposLabel = New System.Windows.Forms.Label()
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(25, 102)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(93, 24)
        NombreLabel.TabIndex = 55
        NombreLabel.Text = "NOMBRE"
        '
        'NifLabel
        '
        NifLabel.AutoSize = True
        NifLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NifLabel.Location = New System.Drawing.Point(25, 187)
        NifLabel.Name = "NifLabel"
        NifLabel.Size = New System.Drawing.Size(74, 24)
        NifLabel.TabIndex = 42
        NifLabel.Text = "NIF/CIF"
        '
        'PersctoLabel
        '
        PersctoLabel.AutoSize = True
        PersctoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PersctoLabel.Location = New System.Drawing.Point(25, 414)
        PersctoLabel.Name = "PersctoLabel"
        PersctoLabel.Size = New System.Drawing.Size(245, 24)
        PersctoLabel.TabIndex = 45
        PersctoLabel.Text = "PERSONA DE CONTACTO"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(28, 238)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(72, 24)
        EmailLabel.TabIndex = 50
        EmailLabel.Text = "E-MAIL"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObservacionesLabel.Location = New System.Drawing.Point(28, 530)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(172, 24)
        ObservacionesLabel.TabIndex = 53
        ObservacionesLabel.Text = "OBSERVACIONES"
        '
        'DomicilioLabel
        '
        DomicilioLabel.AutoSize = True
        DomicilioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DomicilioLabel.Location = New System.Drawing.Point(414, 184)
        DomicilioLabel.Name = "DomicilioLabel"
        DomicilioLabel.Size = New System.Drawing.Size(104, 24)
        DomicilioLabel.TabIndex = 54
        DomicilioLabel.Text = "DOMICILIO"
        '
        'PoblacionLabel
        '
        PoblacionLabel.AutoSize = True
        PoblacionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PoblacionLabel.Location = New System.Drawing.Point(407, 235)
        PoblacionLabel.Name = "PoblacionLabel"
        PoblacionLabel.Size = New System.Drawing.Size(118, 24)
        PoblacionLabel.TabIndex = 56
        PoblacionLabel.Text = "POBLACION"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProvinciaLabel.Location = New System.Drawing.Point(407, 279)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(111, 24)
        ProvinciaLabel.TabIndex = 57
        ProvinciaLabel.Text = "PROVINCIA"
        '
        'Telef1Label
        '
        Telef1Label.AutoSize = True
        Telef1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telef1Label.Location = New System.Drawing.Point(28, 283)
        Telef1Label.Name = "Telef1Label"
        Telef1Label.Size = New System.Drawing.Size(95, 24)
        Telef1Label.TabIndex = 58
        Telef1Label.Text = "TELEF.01"
        '
        'Telef2Label
        '
        Telef2Label.AutoSize = True
        Telef2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telef2Label.Location = New System.Drawing.Point(25, 335)
        Telef2Label.Name = "Telef2Label"
        Telef2Label.Size = New System.Drawing.Size(95, 24)
        Telef2Label.TabIndex = 59
        Telef2Label.Text = "TELEF.02"
        '
        'CodposLabel
        '
        CodposLabel.AutoSize = True
        CodposLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodposLabel.Location = New System.Drawing.Point(826, 279)
        CodposLabel.Name = "CodposLabel"
        CodposLabel.Size = New System.Drawing.Size(35, 24)
        CodposLabel.TabIndex = 60
        CodposLabel.Text = "CP"
        '
        'imgSalirGrande
        '
        Me.imgSalirGrande.Image = CType(resources.GetObject("imgSalirGrande.Image"), System.Drawing.Image)
        Me.imgSalirGrande.Location = New System.Drawing.Point(923, 729)
        Me.imgSalirGrande.Name = "imgSalirGrande"
        Me.imgSalirGrande.Size = New System.Drawing.Size(80, 80)
        Me.imgSalirGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSalirGrande.TabIndex = 36
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
        Me.imgSalirPequena.TabIndex = 37
        Me.imgSalirPequena.TabStop = False
        '
        'CodigoLabel1
        '
        Me.CodigoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoLabel1.Location = New System.Drawing.Point(113, 53)
        Me.CodigoLabel1.Name = "CodigoLabel1"
        Me.CodigoLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CodigoLabel1.TabIndex = 49
        Me.CodigoLabel1.Text = "Label1"
        Me.CodigoLabel1.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(150, 99)
        Me.txtNombre.MaxLength = 49
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(375, 29)
        Me.txtNombre.TabIndex = 38
        '
        'txtCif
        '
        Me.txtCif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCif.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCif.Location = New System.Drawing.Point(150, 184)
        Me.txtCif.MaxLength = 10
        Me.txtCif.Name = "txtCif"
        Me.txtCif.Size = New System.Drawing.Size(201, 29)
        Me.txtCif.TabIndex = 39
        '
        'txtPersoCto
        '
        Me.txtPersoCto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPersoCto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersoCto.Location = New System.Drawing.Point(29, 441)
        Me.txtPersoCto.MaxLength = 50
        Me.txtPersoCto.Name = "txtPersoCto"
        Me.txtPersoCto.Size = New System.Drawing.Size(322, 29)
        Me.txtPersoCto.TabIndex = 51
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(150, 235)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 29)
        Me.txtEmail.TabIndex = 40
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(32, 569)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(558, 198)
        Me.txtObservaciones.TabIndex = 52
        '
        'txtDomicilio
        '
        Me.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(529, 181)
        Me.txtDomicilio.MaxLength = 150
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(460, 29)
        Me.txtDomicilio.TabIndex = 43
        '
        'txtPoblacion
        '
        Me.txtPoblacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPoblacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoblacion.Location = New System.Drawing.Point(529, 232)
        Me.txtPoblacion.MaxLength = 50
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(460, 29)
        Me.txtPoblacion.TabIndex = 44
        '
        'txtProvincia
        '
        Me.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.Location = New System.Drawing.Point(529, 276)
        Me.txtProvincia.MaxLength = 15
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(254, 29)
        Me.txtProvincia.TabIndex = 46
        '
        'txtTelef1
        '
        Me.txtTelef1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelef1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelef1.Location = New System.Drawing.Point(150, 279)
        Me.txtTelef1.MaxLength = 12
        Me.txtTelef1.Name = "txtTelef1"
        Me.txtTelef1.Size = New System.Drawing.Size(201, 29)
        Me.txtTelef1.TabIndex = 41
        '
        'txtTelef2
        '
        Me.txtTelef2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelef2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelef2.Location = New System.Drawing.Point(150, 332)
        Me.txtTelef2.MaxLength = 12
        Me.txtTelef2.Name = "txtTelef2"
        Me.txtTelef2.Size = New System.Drawing.Size(201, 29)
        Me.txtTelef2.TabIndex = 48
        '
        'txtCP
        '
        Me.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(867, 276)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(122, 29)
        Me.txtCP.TabIndex = 47
        '
        'imgAceptarGrande
        '
        Me.imgAceptarGrande.Image = CType(resources.GetObject("imgAceptarGrande.Image"), System.Drawing.Image)
        Me.imgAceptarGrande.Location = New System.Drawing.Point(830, 720)
        Me.imgAceptarGrande.Name = "imgAceptarGrande"
        Me.imgAceptarGrande.Size = New System.Drawing.Size(71, 89)
        Me.imgAceptarGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarGrande.TabIndex = 61
        Me.imgAceptarGrande.TabStop = False
        Me.ToolTip1.SetToolTip(Me.imgAceptarGrande, "Guardar")
        '
        'imgAceptarPequena
        '
        Me.imgAceptarPequena.Image = CType(resources.GetObject("imgAceptarPequena.Image"), System.Drawing.Image)
        Me.imgAceptarPequena.Location = New System.Drawing.Point(840, 729)
        Me.imgAceptarPequena.Name = "imgAceptarPequena"
        Me.imgAceptarPequena.Size = New System.Drawing.Size(52, 70)
        Me.imgAceptarPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAceptarPequena.TabIndex = 62
        Me.imgAceptarPequena.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 24)
        Me.MenuStrip1.TabIndex = 63
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'frmClienteNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1022, 821)
        Me.Controls.Add(Me.imgAceptarGrande)
        Me.Controls.Add(Me.CodigoLabel1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(NifLabel)
        Me.Controls.Add(Me.txtCif)
        Me.Controls.Add(PersctoLabel)
        Me.Controls.Add(Me.txtPersoCto)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(DomicilioLabel)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(PoblacionLabel)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Telef1Label)
        Me.Controls.Add(Me.txtTelef1)
        Me.Controls.Add(Telef2Label)
        Me.Controls.Add(Me.txtTelef2)
        Me.Controls.Add(CodposLabel)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.imgAceptarPequena)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.imgSalirGrande)
        Me.Controls.Add(Me.imgSalirPequena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmClienteNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmParteNuevo"
        CType(Me.imgSalirGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalirPequena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarGrande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAceptarPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgSalirGrande As PictureBox
    Friend WithEvents imgSalirPequena As PictureBox
    Friend WithEvents CodigoLabel1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCif As TextBox
    Friend WithEvents txtPersoCto As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtPoblacion As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtTelef1 As TextBox
    Friend WithEvents txtTelef2 As TextBox
    Friend WithEvents txtCP As TextBox
    Friend WithEvents imgAceptarGrande As PictureBox
    Friend WithEvents imgAceptarPequena As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
