<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.panelCabecera = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnLogin = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.carga = New CircularProgressBar.CircularProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ElContainer1 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ElContainer2 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnIniciar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.panelCabecera.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer2.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnIniciar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Inter Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(656, 434)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 19)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Iniciar Sesion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(682, 415)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 19)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "User"
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar1.AnimationSpeed = 500
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgressBar1.InnerColor = System.Drawing.Color.Black
        Me.CircularProgressBar1.InnerMargin = 2
        Me.CircularProgressBar1.InnerWidth = -1
        Me.CircularProgressBar1.Location = New System.Drawing.Point(762, 387)
        Me.CircularProgressBar1.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.OuterColor = System.Drawing.Color.Black
        Me.CircularProgressBar1.OuterMargin = -25
        Me.CircularProgressBar1.OuterWidth = 26
        Me.CircularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.CircularProgressBar1.ProgressWidth = 5
        Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBar1.Size = New System.Drawing.Size(90, 90)
        Me.CircularProgressBar1.StartAngle = 270
        Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar1.SubscriptText = ".23"
        Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar1.SuperscriptText = "°C"
        Me.CircularProgressBar1.TabIndex = 28
        Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar1.Value = 100
        '
        'panelCabecera
        '
        Me.panelCabecera.BackColor = System.Drawing.Color.Black
        Me.panelCabecera.Controls.Add(Me.Label1)
        Me.panelCabecera.Controls.Add(Me.btnMinimizar)
        Me.panelCabecera.Controls.Add(Me.btnCerrar)
        Me.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(864, 40)
        Me.panelCabecera.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SISTEMA DE RESTAURANTE"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Sistema_Boomerang.My.Resources.Resources.triangulo
        Me.btnMinimizar.Location = New System.Drawing.Point(780, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Sistema_Boomerang.My.Resources.Resources.cruzar
        Me.btnCerrar.Location = New System.Drawing.Point(824, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Sistema_Boomerang.My.Resources.Resources.perfil2
        Me.PictureBox2.Location = New System.Drawing.Point(782, 409)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_Boomerang.My.Resources.Resources.setupw
        Me.PictureBox1.Location = New System.Drawing.Point(329, 365)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 127)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(53, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Distribuida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(53, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 15)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Unidad Didactica de Programación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(53, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 15)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Sistema de Restaurante Creado para la"
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnSalir.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnSalir.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnSalir.BackgroundStyle.SolidColor = System.Drawing.Color.White
        Me.btnSalir.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSalir.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnSalir.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSalir.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSalir.Location = New System.Drawing.Point(173, 205)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(111, 24)
        Me.btnSalir.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.btnSalir.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnSalir.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnSalir.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.btnSalir.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.btnSalir.TabIndex = 41
        Me.btnSalir.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.TextStyle.Text = "Salir"
        Me.btnSalir.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSalir.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnLogin.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLogin.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnLogin.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnLogin.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogin.Location = New System.Drawing.Point(56, 205)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(111, 24)
        Me.btnLogin.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnLogin.TabIndex = 40
        Me.btnLogin.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.TextStyle.Text = "Ingresar"
        Me.btnLogin.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogin.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(66, 440)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 19)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Cargando..."
        '
        'carga
        '
        Me.carga.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.carga.AnimationSpeed = 500
        Me.carga.BackColor = System.Drawing.Color.Transparent
        Me.carga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carga.ForeColor = System.Drawing.Color.White
        Me.carga.InnerColor = System.Drawing.Color.Transparent
        Me.carga.InnerMargin = 2
        Me.carga.InnerWidth = -1
        Me.carga.Location = New System.Drawing.Point(57, 327)
        Me.carga.MarqueeAnimationSpeed = 2000
        Me.carga.Name = "carga"
        Me.carga.OuterColor = System.Drawing.Color.Black
        Me.carga.OuterMargin = -25
        Me.carga.OuterWidth = 26
        Me.carga.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.carga.ProgressWidth = 8
        Me.carga.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carga.Size = New System.Drawing.Size(110, 110)
        Me.carga.StartAngle = 270
        Me.carga.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.carga.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.carga.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.carga.SubscriptText = ""
        Me.carga.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.carga.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.carga.SuperscriptText = ""
        Me.carga.TabIndex = 38
        Me.carga.TextMargin = New System.Windows.Forms.Padding(8)
        Me.carga.Value = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(52, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Ven y Disfruta-Boomerang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(52, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "A la Carta"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(52, 139)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(131, 19)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Venta de Platos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(52, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(207, 19)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Restaurante Bommerang"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(52, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(191, 19)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Sistema Creado para el"
        '
        'ElContainer1
        '
        Me.ElContainer1.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ElContainer1.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ElContainer1.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer1.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer1.Controls.Add(Me.PictureBox7)
        Me.ElContainer1.Controls.Add(Me.PictureBox8)
        Me.ElContainer1.Controls.Add(Me.PictureBox9)
        Me.ElContainer1.Controls.Add(Me.Label21)
        Me.ElContainer1.Controls.Add(Me.Label20)
        Me.ElContainer1.Controls.Add(Me.Label19)
        Me.ElContainer1.Controls.Add(Me.ElContainer2)
        Me.ElContainer1.Location = New System.Drawing.Point(329, 85)
        Me.ElContainer1.Name = "ElContainer1"
        Me.ElContainer1.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue
        Me.ElContainer1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer1.Size = New System.Drawing.Size(459, 274)
        Me.ElContainer1.TabIndex = 45
        Me.ElContainer1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Sistema_Boomerang.My.Resources.Resources.logotipo_de_gmail
        Me.PictureBox7.Location = New System.Drawing.Point(97, 235)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 42
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Sistema_Boomerang.My.Resources.Resources.instagram
        Me.PictureBox8.Location = New System.Drawing.Point(58, 235)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 41
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.Sistema_Boomerang.My.Resources.Resources.facebook
        Me.PictureBox9.Location = New System.Drawing.Point(19, 235)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox9.TabIndex = 40
        Me.PictureBox9.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Inter Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(14, 211)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(157, 23)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Hola Trabajador!"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(13, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 29)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "De Nuevo"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Inter Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(12, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(189, 35)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Bienvenido!"
        '
        'ElContainer2
        '
        Me.ElContainer2.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer2.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer2.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer2.Controls.Add(Me.btnClose)
        Me.ElContainer2.Controls.Add(Me.btnIniciar)
        Me.ElContainer2.Controls.Add(Me.Label23)
        Me.ElContainer2.Controls.Add(Me.Label24)
        Me.ElContainer2.Controls.Add(Me.txtPass)
        Me.ElContainer2.Controls.Add(Me.txtUsuario)
        Me.ElContainer2.Controls.Add(Me.PictureBox10)
        Me.ElContainer2.Controls.Add(Me.Label22)
        Me.ElContainer2.Location = New System.Drawing.Point(228, 0)
        Me.ElContainer2.Name = "ElContainer2"
        Me.ElContainer2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer2.Size = New System.Drawing.Size(231, 274)
        Me.ElContainer2.TabIndex = 1
        Me.ElContainer2.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Sistema_Boomerang.My.Resources.Resources.eliminar_simbolo
        Me.btnClose.Location = New System.Drawing.Point(200, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 24)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClose.TabIndex = 47
        Me.btnClose.TabStop = False
        '
        'btnIniciar
        '
        Me.btnIniciar.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIniciar.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnIniciar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnIniciar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnIniciar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnIniciar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnIniciar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnIniciar.Location = New System.Drawing.Point(60, 225)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(111, 24)
        Me.btnIniciar.StateStyles.FocusStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIniciar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIniciar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnIniciar.TabIndex = 46
        Me.btnIniciar.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.btnIniciar.TextStyle.Text = "Ingresar"
        Me.btnIniciar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnIniciar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Inter Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(27, 159)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 16)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Contraseña"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Inter Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(27, 103)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 16)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "Usuario"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.Black
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.Location = New System.Drawing.Point(30, 178)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(173, 29)
        Me.txtPass.TabIndex = 43
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.Black
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(30, 122)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(173, 29)
        Me.txtUsuario.TabIndex = 42
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.Sistema_Boomerang.My.Resources.Resources.Logo_empresa_removebg_preview
        Me.PictureBox10.Location = New System.Drawing.Point(28, 35)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(173, 70)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 24
        Me.PictureBox10.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(14, 10)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 19)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Login"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(864, 501)
        Me.Controls.Add(Me.ElContainer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.carga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.CircularProgressBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.panelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.panelCabecera.ResumeLayout(False)
        Me.panelCabecera.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer1.ResumeLayout(False)
        Me.ElContainer1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer2.ResumeLayout(False)
        Me.ElContainer2.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnIniciar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelCabecera As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSalir As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnLogin As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents Label7 As Label
    Friend WithEvents carga As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ElContainer1 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents ElContainer2 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnIniciar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label22 As Label
End Class
