<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.panelCabecera = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMaxiMini = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.btnReportes = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnAjustes = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnDashboard = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnInventario = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnPedidos = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnVentas = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.panelCabecera.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAjustes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelCabecera
        '
        Me.panelCabecera.BackColor = System.Drawing.Color.Black
        Me.panelCabecera.Controls.Add(Me.Label1)
        Me.panelCabecera.Controls.Add(Me.btnMaxiMini)
        Me.panelCabecera.Controls.Add(Me.btnMinimizar)
        Me.panelCabecera.Controls.Add(Me.btnMaximizar)
        Me.panelCabecera.Controls.Add(Me.btnCerrar)
        Me.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(1250, 40)
        Me.panelCabecera.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Inter Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SISTEMA DE RESTAURANTE"
        '
        'btnMaxiMini
        '
        Me.btnMaxiMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaxiMini.FlatAppearance.BorderSize = 0
        Me.btnMaxiMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMaxiMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMaxiMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaxiMini.Image = Global.Sistema_Boomerang.My.Resources.Resources.lavado_en_seco
        Me.btnMaxiMini.Location = New System.Drawing.Point(1164, 0)
        Me.btnMaxiMini.Name = "btnMaxiMini"
        Me.btnMaxiMini.Size = New System.Drawing.Size(40, 40)
        Me.btnMaxiMini.TabIndex = 3
        Me.btnMaxiMini.UseVisualStyleBackColor = True
        Me.btnMaxiMini.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Sistema_Boomerang.My.Resources.Resources.triangulo
        Me.btnMinimizar.Location = New System.Drawing.Point(1118, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.Sistema_Boomerang.My.Resources.Resources.lavado_en_seco
        Me.btnMaximizar.Location = New System.Drawing.Point(1164, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Sistema_Boomerang.My.Resources.Resources.cruzar
        Me.btnCerrar.Location = New System.Drawing.Point(1210, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.CircularProgressBar1)
        Me.Panel1.Controls.Add(Me.btnReportes)
        Me.Panel1.Controls.Add(Me.btnAjustes)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.btnInventario)
        Me.Panel1.Controls.Add(Me.btnPedidos)
        Me.Panel1.Controls.Add(Me.btnVentas)
        Me.Panel1.Controls.Add(Me.pbLogo)
        Me.Panel1.Controls.Add(Me.lblMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 670)
        Me.Panel1.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Inter Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(70, 627)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 19)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Iniciar Sesion"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(97, 608)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 19)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "User"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Sistema_Boomerang.My.Resources.Resources.perfil2
        Me.PictureBox2.Location = New System.Drawing.Point(101, 542)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar1.AnimationSpeed = 500
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgressBar1.InnerColor = System.Drawing.Color.Black
        Me.CircularProgressBar1.InnerMargin = 2
        Me.CircularProgressBar1.InnerWidth = -1
        Me.CircularProgressBar1.Location = New System.Drawing.Point(81, 520)
        Me.CircularProgressBar1.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.OuterColor = System.Drawing.Color.Black
        Me.CircularProgressBar1.OuterMargin = -25
        Me.CircularProgressBar1.OuterWidth = 26
        Me.CircularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.CircularProgressBar1.ProgressWidth = 5
        Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBar1.Size = New System.Drawing.Size(80, 80)
        Me.CircularProgressBar1.StartAngle = 270
        Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar1.SubscriptText = ".23"
        Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar1.SuperscriptText = "°C"
        Me.CircularProgressBar1.TabIndex = 48
        Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar1.Value = 100
        '
        'btnReportes
        '
        Me.btnReportes.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnReportes.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnReportes.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnReportes.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.btnReportes.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnReportes.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnReportes.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnReportes.ForegroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.papas_fritas
        Me.btnReportes.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.ForegroundImageStyle.ImageIndent = New System.Drawing.Point(10, 0)
        Me.btnReportes.Location = New System.Drawing.Point(0, 445)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(246, 37)
        Me.btnReportes.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnReportes.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White
        Me.btnReportes.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.btnReportes.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnReportes.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnReportes.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.btnReportes.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.btnReportes.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnReportes.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.btnReportes.TabIndex = 47
        Me.btnReportes.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnReportes.TextStyle.Text = "          Reportes"
        Me.btnReportes.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'btnAjustes
        '
        Me.btnAjustes.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnAjustes.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnAjustes.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnAjustes.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.btnAjustes.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.btnAjustes.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAjustes.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnAjustes.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAjustes.ForegroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.configuraciones
        Me.btnAjustes.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjustes.ForegroundImageStyle.ImageIndent = New System.Drawing.Point(10, 0)
        Me.btnAjustes.Location = New System.Drawing.Point(0, 392)
        Me.btnAjustes.Name = "btnAjustes"
        Me.btnAjustes.Size = New System.Drawing.Size(246, 37)
        Me.btnAjustes.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnAjustes.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White
        Me.btnAjustes.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.btnAjustes.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnAjustes.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnAjustes.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.btnAjustes.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.btnAjustes.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnAjustes.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.btnAjustes.TabIndex = 46
        Me.btnAjustes.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjustes.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnAjustes.TextStyle.Text = "          Ajustes"
        Me.btnAjustes.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'btnDashboard
        '
        Me.btnDashboard.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnDashboard.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnDashboard.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnDashboard.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.btnDashboard.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDashboard.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnDashboard.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDashboard.ForegroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.speedometer
        Me.btnDashboard.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.ForegroundImageStyle.ImageIndent = New System.Drawing.Point(10, 0)
        Me.btnDashboard.Location = New System.Drawing.Point(0, 339)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(246, 37)
        Me.btnDashboard.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnDashboard.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White
        Me.btnDashboard.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.btnDashboard.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnDashboard.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnDashboard.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.btnDashboard.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.btnDashboard.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnDashboard.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.btnDashboard.TabIndex = 45
        Me.btnDashboard.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.TextStyle.Text = "          Panel De Control"
        Me.btnDashboard.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'btnInventario
        '
        Me.btnInventario.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnInventario.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnInventario.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnInventario.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.btnInventario.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.btnInventario.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnInventario.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnInventario.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnInventario.ForegroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.caja
        Me.btnInventario.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventario.ForegroundImageStyle.ImageIndent = New System.Drawing.Point(10, 0)
        Me.btnInventario.Location = New System.Drawing.Point(0, 286)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(246, 37)
        Me.btnInventario.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnInventario.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White
        Me.btnInventario.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.btnInventario.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnInventario.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnInventario.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.btnInventario.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.btnInventario.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnInventario.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.btnInventario.TabIndex = 44
        Me.btnInventario.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnInventario.TextStyle.Text = "          Inventario"
        Me.btnInventario.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'btnPedidos
        '
        Me.btnPedidos.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnPedidos.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnPedidos.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnPedidos.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.btnPedidos.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.btnPedidos.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPedidos.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnPedidos.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnPedidos.ForegroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.motorbike
        Me.btnPedidos.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPedidos.ForegroundImageStyle.ImageIndent = New System.Drawing.Point(10, 0)
        Me.btnPedidos.Location = New System.Drawing.Point(0, 233)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(246, 37)
        Me.btnPedidos.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnPedidos.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White
        Me.btnPedidos.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.btnPedidos.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnPedidos.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnPedidos.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.btnPedidos.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.btnPedidos.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnPedidos.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.btnPedidos.TabIndex = 43
        Me.btnPedidos.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedidos.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnPedidos.TextStyle.Text = "          Pedidos"
        Me.btnPedidos.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'btnVentas
        '
        Me.btnVentas.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnVentas.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnVentas.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnVentas.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.btnVentas.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnVentas.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnVentas.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnVentas.ForegroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.papas_fritas
        Me.btnVentas.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.ForegroundImageStyle.ImageIndent = New System.Drawing.Point(10, 0)
        Me.btnVentas.Location = New System.Drawing.Point(0, 180)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(246, 37)
        Me.btnVentas.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnVentas.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White
        Me.btnVentas.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.btnVentas.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnVentas.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnVentas.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.btnVentas.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.btnVentas.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnVentas.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.btnVentas.TabIndex = 42
        Me.btnVentas.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnVentas.TextStyle.Text = "          Ventas"
        Me.btnVentas.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.Sistema_Boomerang.My.Resources.Resources.Logo_empresa_removebg_preview
        Me.pbLogo.Location = New System.Drawing.Point(23, 61)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(202, 99)
        Me.pbLogo.TabIndex = 4
        Me.pbLogo.TabStop = False
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMenu.Font = New System.Drawing.Font("Inter Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblMenu.Location = New System.Drawing.Point(73, 23)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(98, 35)
        Me.lblMenu.TabIndex = 3
        Me.lblMenu.Text = "Menu"
        '
        'panelContenedor
        '
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(246, 40)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(1004, 670)
        Me.panelContenedor.TabIndex = 3
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1250, 710)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.panelCabecera.ResumeLayout(False)
        Me.panelCabecera.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAjustes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelCabecera As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMaxiMini As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents btnVentas As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents btnReportes As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnAjustes As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnDashboard As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnInventario As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnPedidos As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
