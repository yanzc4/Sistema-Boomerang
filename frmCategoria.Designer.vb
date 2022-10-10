<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
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
        Me.ElDivider1 = New Klik.Windows.Forms.v1.EntryLib.ELDivider()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ElContainer1 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ElContainer5 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.imgCategoria = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ElContainer4 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnEliminar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnAgregar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnNuevo = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.txtDescripcion = New Sistema_Boomerang.PowerTextBox()
        Me.txtNombre = New Sistema_Boomerang.PowerTextBox()
        Me.txtId = New Sistema_Boomerang.PowerTextBox()
        Me.panelCabecera.SuspendLayout()
        CType(Me.ElDivider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer1.SuspendLayout()
        CType(Me.ElContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer5.SuspendLayout()
        CType(Me.imgCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer4.SuspendLayout()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelCabecera
        '
        Me.panelCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.panelCabecera.Controls.Add(Me.ElDivider1)
        Me.panelCabecera.Controls.Add(Me.btnCerrar)
        Me.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(369, 40)
        Me.panelCabecera.TabIndex = 20
        '
        'ElDivider1
        '
        Me.ElDivider1.LineColor = System.Drawing.Color.Black
        Me.ElDivider1.Location = New System.Drawing.Point(12, 9)
        Me.ElDivider1.Name = "ElDivider1"
        Me.ElDivider1.Size = New System.Drawing.Size(232, 23)
        Me.ElDivider1.TabIndex = 3
        Me.ElDivider1.TransparentStyle.BackColor = System.Drawing.Color.Black
        Me.ElDivider1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Sistema_Boomerang.My.Resources.Resources.close_cross
        Me.btnCerrar.Location = New System.Drawing.Point(329, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Descripcion"
        '
        'ElContainer1
        '
        Me.ElContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer1.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer1.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer1.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer1.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer1.Controls.Add(Me.txtDescripcion)
        Me.ElContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer1.Location = New System.Drawing.Point(47, 237)
        Me.ElContainer1.Name = "ElContainer1"
        Me.ElContainer1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer1.Size = New System.Drawing.Size(277, 34)
        Me.ElContainer1.TabIndex = 74
        Me.ElContainer1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(44, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 14)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Nombre"
        '
        'ElContainer5
        '
        Me.ElContainer5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer5.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer5.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer5.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer5.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer5.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer5.Controls.Add(Me.txtNombre)
        Me.ElContainer5.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer5.Location = New System.Drawing.Point(47, 178)
        Me.ElContainer5.Name = "ElContainer5"
        Me.ElContainer5.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer5.Size = New System.Drawing.Size(197, 34)
        Me.ElContainer5.TabIndex = 72
        Me.ElContainer5.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'imgCategoria
        '
        Me.imgCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgCategoria.Location = New System.Drawing.Point(156, 102)
        Me.imgCategoria.Name = "imgCategoria"
        Me.imgCategoria.Size = New System.Drawing.Size(64, 64)
        Me.imgCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCategoria.TabIndex = 71
        Me.imgCategoria.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(44, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 14)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Codigo"
        '
        'ElContainer4
        '
        Me.ElContainer4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer4.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer4.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer4.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer4.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer4.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer4.Controls.Add(Me.txtId)
        Me.ElContainer4.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer4.Location = New System.Drawing.Point(47, 119)
        Me.ElContainer4.Name = "ElContainer4"
        Me.ElContainer4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer4.Size = New System.Drawing.Size(94, 34)
        Me.ElContainer4.TabIndex = 68
        Me.ElContainer4.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Inter", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(78, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 25)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Registrar Categoria"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnRegistrar.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnRegistrar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRegistrar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnRegistrar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnRegistrar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegistrar.Location = New System.Drawing.Point(47, 293)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(131, 34)
        Me.btnRegistrar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnRegistrar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnRegistrar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnRegistrar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnRegistrar.TabIndex = 77
        Me.btnRegistrar.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.TextStyle.Text = "Registrar"
        Me.btnRegistrar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegistrar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnEliminar.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnEliminar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEliminar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnEliminar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnEliminar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(230, 139)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 27)
        Me.btnEliminar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnEliminar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnEliminar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnEliminar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnEliminar.TabIndex = 80
        Me.btnEliminar.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.TextStyle.Text = "Eliminar"
        Me.btnEliminar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEliminar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnAgregar.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnAgregar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAgregar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnAgregar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAgregar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAgregar.Location = New System.Drawing.Point(230, 102)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 27)
        Me.btnAgregar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnAgregar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnAgregar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnAgregar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnAgregar.TabIndex = 79
        Me.btnAgregar.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.TextStyle.Text = "Agregar"
        Me.btnAgregar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAgregar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevo.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnNuevo.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnNuevo.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnNuevo.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(193, 293)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(131, 34)
        Me.btnNuevo.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevo.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevo.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnNuevo.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnNuevo.TabIndex = 81
        Me.btnNuevo.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.TextStyle.Text = "Nuevo"
        Me.btnNuevo.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevo.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.Black
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtDescripcion.ForeColor = System.Drawing.Color.White
        Me.txtDescripcion.Location = New System.Drawing.Point(8, 7)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(262, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.Black
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(8, 7)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.Black
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtId.ForeColor = System.Drawing.Color.White
        Me.txtId.Location = New System.Drawing.Point(8, 7)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(79, 20)
        Me.txtId.TabIndex = 1
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(369, 349)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ElContainer1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ElContainer5)
        Me.Controls.Add(Me.imgCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ElContainer4)
        Me.Controls.Add(Me.panelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCategoria"
        Me.panelCabecera.ResumeLayout(False)
        CType(Me.ElDivider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer1.ResumeLayout(False)
        Me.ElContainer1.PerformLayout()
        CType(Me.ElContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer5.ResumeLayout(False)
        Me.ElContainer5.PerformLayout()
        CType(Me.imgCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer4.ResumeLayout(False)
        Me.ElContainer4.PerformLayout()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelCabecera As Panel
    Friend WithEvents ElDivider1 As Klik.Windows.Forms.v1.EntryLib.ELDivider
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ElContainer1 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtDescripcion As PowerTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ElContainer5 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtNombre As PowerTextBox
    Friend WithEvents imgCategoria As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ElContainer4 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtId As PowerTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegistrar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnEliminar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnAgregar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnNuevo As Klik.Windows.Forms.v1.EntryLib.ELButton
End Class
