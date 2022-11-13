<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlatos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ElContainer1 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.btnNcategoria = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnAgregar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.panelCabecera = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.ElDivider1 = New Klik.Windows.Forms.v1.EntryLib.ELDivider()
        Me.ElButton3 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton2 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton1 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.dgvPlatos = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ElContainer2 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.txtPrecio = New Sistema_Boomerang.PowerTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ElContainer7 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.txtNombre = New Sistema_Boomerang.PowerTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgPlato = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer1.SuspendLayout()
        CType(Me.btnNcategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCabecera.SuspendLayout()
        CType(Me.ElDivider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPlatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer2.SuspendLayout()
        CType(Me.ElContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPlato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElContainer1
        '
        Me.ElContainer1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ElContainer1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer1.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer1.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer1.Controls.Add(Me.PictureBox1)
        Me.ElContainer1.Controls.Add(Me.btnNcategoria)
        Me.ElContainer1.Controls.Add(Me.Label2)
        Me.ElContainer1.Controls.Add(Me.ComboBox1)
        Me.ElContainer1.Controls.Add(Me.btnEliminar)
        Me.ElContainer1.Controls.Add(Me.btnAgregar)
        Me.ElContainer1.Controls.Add(Me.imgPlato)
        Me.ElContainer1.Controls.Add(Me.panelCabecera)
        Me.ElContainer1.Controls.Add(Me.ElButton3)
        Me.ElContainer1.Controls.Add(Me.ElButton2)
        Me.ElContainer1.Controls.Add(Me.ElButton1)
        Me.ElContainer1.Controls.Add(Me.dgvPlatos)
        Me.ElContainer1.Controls.Add(Me.btnNuevo)
        Me.ElContainer1.Controls.Add(Me.txtCategoria)
        Me.ElContainer1.Controls.Add(Me.btnRegistrar)
        Me.ElContainer1.Controls.Add(Me.Label5)
        Me.ElContainer1.Controls.Add(Me.ElContainer2)
        Me.ElContainer1.Controls.Add(Me.Label3)
        Me.ElContainer1.Controls.Add(Me.Label1)
        Me.ElContainer1.Controls.Add(Me.ElContainer7)
        Me.ElContainer1.Location = New System.Drawing.Point(3, 2)
        Me.ElContainer1.Name = "ElContainer1"
        Me.ElContainer1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer1.Size = New System.Drawing.Size(875, 493)
        Me.ElContainer1.TabIndex = 1
        Me.ElContainer1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'btnNcategoria
        '
        Me.btnNcategoria.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNcategoria.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnNcategoria.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnNcategoria.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNcategoria.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnNcategoria.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnNcategoria.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNcategoria.Location = New System.Drawing.Point(520, 160)
        Me.btnNcategoria.Name = "btnNcategoria"
        Me.btnNcategoria.Size = New System.Drawing.Size(128, 27)
        Me.btnNcategoria.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNcategoria.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNcategoria.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnNcategoria.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnNcategoria.TabIndex = 128
        Me.btnNcategoria.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNcategoria.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnNcategoria.TextStyle.Text = "Crear Categoria"
        Me.btnNcategoria.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNcategoria.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(504, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Elija Categoria"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(507, 120)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox1.TabIndex = 126
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
        Me.btnEliminar.Location = New System.Drawing.Point(398, 160)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 27)
        Me.btnEliminar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnEliminar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnEliminar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnEliminar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnEliminar.TabIndex = 125
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
        Me.btnAgregar.Location = New System.Drawing.Point(398, 123)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 27)
        Me.btnAgregar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnAgregar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnAgregar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnAgregar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnAgregar.TabIndex = 124
        Me.btnAgregar.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.TextStyle.Text = "Agregar"
        Me.btnAgregar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAgregar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'panelCabecera
        '
        Me.panelCabecera.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.panelCabecera.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.panelCabecera.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.panelCabecera.Controls.Add(Me.ElDivider1)
        Me.panelCabecera.Controls.Add(Me.btnCerrar)
        Me.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCabecera.Location = New System.Drawing.Point(4, 3)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panelCabecera.Size = New System.Drawing.Size(867, 40)
        Me.panelCabecera.TabIndex = 121
        Me.panelCabecera.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'ElDivider1
        '
        Me.ElDivider1.LineColor = System.Drawing.Color.Black
        Me.ElDivider1.Location = New System.Drawing.Point(10, 9)
        Me.ElDivider1.Name = "ElDivider1"
        Me.ElDivider1.Size = New System.Drawing.Size(594, 23)
        Me.ElDivider1.TabIndex = 4
        Me.ElDivider1.TransparentStyle.BackColor = System.Drawing.Color.Black
        Me.ElDivider1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'ElButton3
        '
        Me.ElButton3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElButton3.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton3.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElButton3.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElButton3.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElButton3.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton3.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton3.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton3.Location = New System.Drawing.Point(693, 439)
        Me.ElButton3.Name = "ElButton3"
        Me.ElButton3.Size = New System.Drawing.Size(148, 34)
        Me.ElButton3.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton3.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton3.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.ElButton3.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.ElButton3.TabIndex = 120
        Me.ElButton3.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton3.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElButton3.TextStyle.Text = "Guardar"
        Me.ElButton3.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton3.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'ElButton2
        '
        Me.ElButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElButton2.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton2.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElButton2.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElButton2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElButton2.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton2.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton2.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton2.Location = New System.Drawing.Point(193, 439)
        Me.ElButton2.Name = "ElButton2"
        Me.ElButton2.Size = New System.Drawing.Size(148, 34)
        Me.ElButton2.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton2.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton2.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.ElButton2.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.ElButton2.TabIndex = 119
        Me.ElButton2.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton2.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElButton2.TextStyle.Text = "Eliminar"
        Me.ElButton2.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton2.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'ElButton1
        '
        Me.ElButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElButton1.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton1.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElButton1.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElButton1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton1.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.Location = New System.Drawing.Point(39, 439)
        Me.ElButton1.Name = "ElButton1"
        Me.ElButton1.Size = New System.Drawing.Size(148, 34)
        Me.ElButton1.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton1.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton1.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.ElButton1.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.ElButton1.TabIndex = 118
        Me.ElButton1.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton1.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElButton1.TextStyle.Text = "Editar"
        Me.ElButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'dgvPlatos
        '
        Me.dgvPlatos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvPlatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPlatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPlatos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.dgvPlatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPlatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPlatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPlatos.ColumnHeadersHeight = 30
        Me.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPlatos.EnableHeadersVisualStyles = False
        Me.dgvPlatos.GridColor = System.Drawing.Color.Yellow
        Me.dgvPlatos.Location = New System.Drawing.Point(67, 240)
        Me.dgvPlatos.Name = "dgvPlatos"
        Me.dgvPlatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPlatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPlatos.RowHeadersWidth = 51
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPlatos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPlatos.Size = New System.Drawing.Size(740, 172)
        Me.dgvPlatos.TabIndex = 117
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNuevo.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevo.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnNuevo.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnNuevo.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnNuevo.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(693, 160)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(148, 34)
        Me.btnNuevo.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevo.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevo.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnNuevo.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnNuevo.TabIndex = 116
        Me.btnNuevo.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.TextStyle.Text = "Nuevo"
        Me.btnNuevo.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevo.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'txtCategoria
        '
        Me.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCategoria.Location = New System.Drawing.Point(657, 68)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(122, 20)
        Me.txtCategoria.TabIndex = 115
        Me.txtCategoria.Visible = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRegistrar.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnRegistrar.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnRegistrar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRegistrar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnRegistrar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnRegistrar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegistrar.Location = New System.Drawing.Point(693, 120)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(148, 34)
        Me.btnRegistrar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnRegistrar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnRegistrar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnRegistrar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnRegistrar.TabIndex = 112
        Me.btnRegistrar.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.TextStyle.Text = "Registrar"
        Me.btnRegistrar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegistrar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(34, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Precio"
        '
        'ElContainer2
        '
        Me.ElContainer2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer2.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer2.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer2.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer2.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer2.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer2.Controls.Add(Me.txtPrecio)
        Me.ElContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer2.Location = New System.Drawing.Point(37, 176)
        Me.ElContainer2.Name = "ElContainer2"
        Me.ElContainer2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer2.Size = New System.Drawing.Size(184, 34)
        Me.ElContainer2.TabIndex = 108
        Me.ElContainer2.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.Black
        Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtPrecio.ForeColor = System.Drawing.Color.White
        Me.txtPrecio.Location = New System.Drawing.Point(8, 7)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(169, 20)
        Me.txtPrecio.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(296, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 25)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Registrar Nuevo Plato" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ElContainer7
        '
        Me.ElContainer7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer7.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer7.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer7.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer7.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer7.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer7.Controls.Add(Me.txtNombre)
        Me.ElContainer7.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer7.Location = New System.Drawing.Point(37, 116)
        Me.ElContainer7.Name = "ElContainer7"
        Me.ElContainer7.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer7.Size = New System.Drawing.Size(241, 34)
        Me.ElContainer7.TabIndex = 100
        Me.ElContainer7.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.Black
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(8, 7)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(226, 20)
        Me.txtNombre.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_Boomerang.My.Resources.Resources.renew
        Me.PictureBox1.Location = New System.Drawing.Point(638, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 130
        Me.PictureBox1.TabStop = False
        '
        'imgPlato
        '
        Me.imgPlato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgPlato.Location = New System.Drawing.Point(293, 116)
        Me.imgPlato.Name = "imgPlato"
        Me.imgPlato.Size = New System.Drawing.Size(80, 80)
        Me.imgPlato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPlato.TabIndex = 123
        Me.imgPlato.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Sistema_Boomerang.My.Resources.Resources.close_cross
        Me.btnCerrar.Location = New System.Drawing.Point(822, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmPlatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(881, 496)
        Me.Controls.Add(Me.ElContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPlatos"
        Me.Text = "frmPlatos"
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer1.ResumeLayout(False)
        Me.ElContainer1.PerformLayout()
        CType(Me.btnNcategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCabecera.ResumeLayout(False)
        CType(Me.ElDivider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPlatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer2.ResumeLayout(False)
        Me.ElContainer2.PerformLayout()
        CType(Me.ElContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer7.ResumeLayout(False)
        Me.ElContainer7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPlato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElContainer1 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents panelCabecera As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents ElDivider1 As Klik.Windows.Forms.v1.EntryLib.ELDivider
    Friend WithEvents btnCerrar As Button
    Friend WithEvents ElButton3 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents ElButton2 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents ElButton1 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents dgvPlatos As DataGridView
    Friend WithEvents btnNuevo As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents btnRegistrar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents Label5 As Label
    Friend WithEvents ElContainer2 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtPrecio As PowerTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ElContainer7 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtNombre As PowerTextBox
    Friend WithEvents btnEliminar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnAgregar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents imgPlato As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnNcategoria As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
