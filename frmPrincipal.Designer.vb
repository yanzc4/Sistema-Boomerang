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
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnSalir = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.ElButton1 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton2 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton3 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton4 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton5 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.panelCabecera.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton5, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.ElButton5)
        Me.Panel1.Controls.Add(Me.ElButton4)
        Me.Panel1.Controls.Add(Me.ElButton3)
        Me.Panel1.Controls.Add(Me.ElButton2)
        Me.Panel1.Controls.Add(Me.ElButton1)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.pbLogo)
        Me.Panel1.Controls.Add(Me.lblMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 670)
        Me.Panel1.TabIndex = 2
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
        Me.lblMenu.ForeColor = System.Drawing.Color.Red
        Me.lblMenu.Location = New System.Drawing.Point(73, 23)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(98, 35)
        Me.lblMenu.TabIndex = 3
        Me.lblMenu.Text = "Menu"
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnSalir.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnSalir.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnSalir.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.btnSalir.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSalir.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnSalir.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSalir.ForegroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.papas_fritas
        Me.btnSalir.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.ForegroundImageStyle.ImageIndent = New System.Drawing.Point(10, 0)
        Me.btnSalir.Location = New System.Drawing.Point(0, 180)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(246, 37)
        Me.btnSalir.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnSalir.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White
        Me.btnSalir.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.btnSalir.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnSalir.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnSalir.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.btnSalir.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.btnSalir.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.btnSalir.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.btnSalir.TabIndex = 42
        Me.btnSalir.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnSalir.TextStyle.Text = "Salir"
        Me.btnSalir.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSalir.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'panelContenedor
        '
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(246, 40)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(1004, 670)
        Me.panelContenedor.TabIndex = 3
        '
        'ElButton1
        '
        Me.ElButton1.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton1.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElButton1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton1.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElButton1.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElButton1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton1.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton1.ForegroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.papas_fritas
        Me.ElButton1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElButton1.ForegroundImageStyle.ImageIndent = New System.Drawing.Point(10, 0)
        Me.ElButton1.Location = New System.Drawing.Point(0, 223)
        Me.ElButton1.Name = "ElButton1"
        Me.ElButton1.Size = New System.Drawing.Size(246, 37)
        Me.ElButton1.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton1.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton1.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.ElButton1.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton1.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.ElButton1.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.ElButton1.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton1.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton1.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton1.TabIndex = 43
        Me.ElButton1.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton1.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElButton1.TextStyle.Text = "Salir"
        Me.ElButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'ElButton2
        '
        Me.ElButton2.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton2.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElButton2.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton2.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElButton2.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElButton2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElButton2.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton2.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton2.ForegroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.papas_fritas
        Me.ElButton2.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElButton2.ForegroundImageStyle.ImageIndent = New System.Drawing.Point(10, 0)
        Me.ElButton2.Location = New System.Drawing.Point(0, 266)
        Me.ElButton2.Name = "ElButton2"
        Me.ElButton2.Size = New System.Drawing.Size(246, 37)
        Me.ElButton2.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton2.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton2.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.ElButton2.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton2.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.ElButton2.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.ElButton2.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton2.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton2.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton2.TabIndex = 44
        Me.ElButton2.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton2.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElButton2.TextStyle.Text = "Salir"
        Me.ElButton2.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton2.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'ElButton3
        '
        Me.ElButton3.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton3.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElButton3.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton3.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElButton3.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElButton3.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElButton3.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton3.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton3.ForegroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.papas_fritas
        Me.ElButton3.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElButton3.ForegroundImageStyle.ImageIndent = New System.Drawing.Point(10, 0)
        Me.ElButton3.Location = New System.Drawing.Point(0, 309)
        Me.ElButton3.Name = "ElButton3"
        Me.ElButton3.Size = New System.Drawing.Size(246, 37)
        Me.ElButton3.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton3.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton3.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.ElButton3.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton3.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.ElButton3.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.ElButton3.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton3.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton3.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton3.TabIndex = 45
        Me.ElButton3.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton3.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElButton3.TextStyle.Text = "Salir"
        Me.ElButton3.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton3.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'ElButton4
        '
        Me.ElButton4.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton4.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElButton4.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton4.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElButton4.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElButton4.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElButton4.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton4.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton4.ForegroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.papas_fritas
        Me.ElButton4.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElButton4.ForegroundImageStyle.ImageIndent = New System.Drawing.Point(10, 0)
        Me.ElButton4.Location = New System.Drawing.Point(0, 352)
        Me.ElButton4.Name = "ElButton4"
        Me.ElButton4.Size = New System.Drawing.Size(246, 37)
        Me.ElButton4.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton4.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton4.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.ElButton4.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton4.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.ElButton4.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.ElButton4.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton4.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton4.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton4.TabIndex = 46
        Me.ElButton4.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton4.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElButton4.TextStyle.Text = "Salir"
        Me.ElButton4.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton4.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'ElButton5
        '
        Me.ElButton5.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton5.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElButton5.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton5.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElButton5.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElButton5.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElButton5.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton5.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton5.ForegroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.papas_fritas
        Me.ElButton5.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElButton5.ForegroundImageStyle.ImageIndent = New System.Drawing.Point(10, 0)
        Me.ElButton5.Location = New System.Drawing.Point(0, 395)
        Me.ElButton5.Name = "ElButton5"
        Me.ElButton5.Size = New System.Drawing.Size(246, 37)
        Me.ElButton5.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton5.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton5.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Red
        Me.ElButton5.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton5.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.ElButton5.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Black
        Me.ElButton5.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton5.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.Red
        Me.ElButton5.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White
        Me.ElButton5.TabIndex = 47
        Me.ElButton5.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton5.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElButton5.TextStyle.Text = "Salir"
        Me.ElButton5.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton5.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
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
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton5, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSalir As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents ElButton5 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents ElButton4 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents ElButton3 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents ElButton2 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents ElButton1 As Klik.Windows.Forms.v1.EntryLib.ELButton
End Class
