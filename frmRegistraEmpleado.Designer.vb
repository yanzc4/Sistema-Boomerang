<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistraEmpleado
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
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ElContainer1 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.ElButton3 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton2 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton1 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.dgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ElContainer6 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.txtPassN = New Sistema_Boomerang.PowerTextBox()
        Me.btnRegistrar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ElContainer3 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.txtUsuarioN = New Sistema_Boomerang.PowerTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ElContainer2 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.txtCelular = New Sistema_Boomerang.PowerTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ElContainer4 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.txtApellidos = New Sistema_Boomerang.PowerTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtEmpleado = New System.Windows.Forms.RadioButton()
        Me.rdbAdministrador = New System.Windows.Forms.RadioButton()
        Me.ElContainer5 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.txtCodN = New Sistema_Boomerang.PowerTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ElContainer7 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.txtNombre = New Sistema_Boomerang.PowerTextBox()
        Me.panelCabecera = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.ElDivider1 = New Klik.Windows.Forms.v1.EntryLib.ELDivider()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer1.SuspendLayout()
        CType(Me.ElButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer6.SuspendLayout()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer3.SuspendLayout()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer2.SuspendLayout()
        CType(Me.ElContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ElContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer5.SuspendLayout()
        CType(Me.ElContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer7.SuspendLayout()
        CType(Me.panelCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCabecera.SuspendLayout()
        CType(Me.ElDivider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElContainer1
        '
        Me.ElContainer1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ElContainer1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer1.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer1.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer1.Controls.Add(Me.panelCabecera)
        Me.ElContainer1.Controls.Add(Me.ElButton3)
        Me.ElContainer1.Controls.Add(Me.ElButton2)
        Me.ElContainer1.Controls.Add(Me.ElButton1)
        Me.ElContainer1.Controls.Add(Me.dgvEmpleado)
        Me.ElContainer1.Controls.Add(Me.btnNuevo)
        Me.ElContainer1.Controls.Add(Me.txtNivel)
        Me.ElContainer1.Controls.Add(Me.Label7)
        Me.ElContainer1.Controls.Add(Me.ElContainer6)
        Me.ElContainer1.Controls.Add(Me.btnRegistrar)
        Me.ElContainer1.Controls.Add(Me.Label6)
        Me.ElContainer1.Controls.Add(Me.ElContainer3)
        Me.ElContainer1.Controls.Add(Me.Label5)
        Me.ElContainer1.Controls.Add(Me.ElContainer2)
        Me.ElContainer1.Controls.Add(Me.Label4)
        Me.ElContainer1.Controls.Add(Me.ElContainer4)
        Me.ElContainer1.Controls.Add(Me.Label3)
        Me.ElContainer1.Controls.Add(Me.Label2)
        Me.ElContainer1.Controls.Add(Me.GroupBox1)
        Me.ElContainer1.Controls.Add(Me.ElContainer5)
        Me.ElContainer1.Controls.Add(Me.Label1)
        Me.ElContainer1.Controls.Add(Me.ElContainer7)
        Me.ElContainer1.Location = New System.Drawing.Point(3, 2)
        Me.ElContainer1.Name = "ElContainer1"
        Me.ElContainer1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer1.Size = New System.Drawing.Size(875, 493)
        Me.ElContainer1.TabIndex = 0
        Me.ElContainer1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
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
        Me.ElButton3.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ElButton2.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ElButton1.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton1.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElButton1.TextStyle.Text = "Editar"
        Me.ElButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'dgvEmpleado
        '
        Me.dgvEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.dgvEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvEmpleado.ColumnHeadersHeight = 30
        Me.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEmpleado.EnableHeadersVisualStyles = False
        Me.dgvEmpleado.GridColor = System.Drawing.Color.Yellow
        Me.dgvEmpleado.Location = New System.Drawing.Point(39, 250)
        Me.dgvEmpleado.Name = "dgvEmpleado"
        Me.dgvEmpleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleado.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvEmpleado.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.dgvEmpleado.Size = New System.Drawing.Size(802, 172)
        Me.dgvEmpleado.TabIndex = 117
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
        Me.btnNuevo.Location = New System.Drawing.Point(693, 201)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(148, 34)
        Me.btnNuevo.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevo.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevo.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnNuevo.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnNuevo.TabIndex = 116
        Me.btnNuevo.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.TextStyle.Text = "Nuevo"
        Me.btnNuevo.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevo.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'txtNivel
        '
        Me.txtNivel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNivel.Location = New System.Drawing.Point(657, 71)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(122, 20)
        Me.txtNivel.TabIndex = 115
        Me.txtNivel.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(292, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 14)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Contraseña"
        '
        'ElContainer6
        '
        Me.ElContainer6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer6.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer6.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer6.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer6.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer6.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer6.Controls.Add(Me.txtPassN)
        Me.ElContainer6.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer6.Location = New System.Drawing.Point(295, 180)
        Me.ElContainer6.Name = "ElContainer6"
        Me.ElContainer6.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer6.Size = New System.Drawing.Size(241, 34)
        Me.ElContainer6.TabIndex = 113
        Me.ElContainer6.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'txtPassN
        '
        Me.txtPassN.BackColor = System.Drawing.Color.Black
        Me.txtPassN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtPassN.ForeColor = System.Drawing.Color.White
        Me.txtPassN.Location = New System.Drawing.Point(8, 7)
        Me.txtPassN.Name = "txtPassN"
        Me.txtPassN.Size = New System.Drawing.Size(226, 20)
        Me.txtPassN.TabIndex = 1
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
        Me.btnRegistrar.Location = New System.Drawing.Point(693, 161)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(148, 34)
        Me.btnRegistrar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnRegistrar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnRegistrar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnRegistrar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnRegistrar.TabIndex = 112
        Me.btnRegistrar.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.TextStyle.Text = "Registrar"
        Me.btnRegistrar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegistrar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(36, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 14)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Usuario"
        '
        'ElContainer3
        '
        Me.ElContainer3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer3.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer3.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer3.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer3.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer3.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer3.Controls.Add(Me.txtUsuarioN)
        Me.ElContainer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer3.Location = New System.Drawing.Point(39, 180)
        Me.ElContainer3.Name = "ElContainer3"
        Me.ElContainer3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer3.Size = New System.Drawing.Size(241, 34)
        Me.ElContainer3.TabIndex = 110
        Me.ElContainer3.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'txtUsuarioN
        '
        Me.txtUsuarioN.BackColor = System.Drawing.Color.Black
        Me.txtUsuarioN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuarioN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtUsuarioN.ForeColor = System.Drawing.Color.White
        Me.txtUsuarioN.Location = New System.Drawing.Point(8, 7)
        Me.txtUsuarioN.Name = "txtUsuarioN"
        Me.txtUsuarioN.Size = New System.Drawing.Size(226, 20)
        Me.txtUsuarioN.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(654, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 14)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Celular"
        '
        'ElContainer2
        '
        Me.ElContainer2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer2.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer2.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer2.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer2.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer2.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer2.Controls.Add(Me.txtCelular)
        Me.ElContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer2.Location = New System.Drawing.Point(657, 113)
        Me.ElContainer2.Name = "ElContainer2"
        Me.ElContainer2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer2.Size = New System.Drawing.Size(184, 34)
        Me.ElContainer2.TabIndex = 108
        Me.ElContainer2.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'txtCelular
        '
        Me.txtCelular.BackColor = System.Drawing.Color.Black
        Me.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtCelular.ForeColor = System.Drawing.Color.White
        Me.txtCelular.Location = New System.Drawing.Point(8, 7)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(169, 20)
        Me.txtCelular.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(400, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 14)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Apellidos"
        '
        'ElContainer4
        '
        Me.ElContainer4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer4.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer4.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer4.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer4.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer4.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer4.Controls.Add(Me.txtApellidos)
        Me.ElContainer4.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer4.Location = New System.Drawing.Point(403, 114)
        Me.ElContainer4.Name = "ElContainer4"
        Me.ElContainer4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer4.Size = New System.Drawing.Size(241, 34)
        Me.ElContainer4.TabIndex = 106
        Me.ElContainer4.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.Black
        Me.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtApellidos.ForeColor = System.Drawing.Color.White
        Me.txtApellidos.Location = New System.Drawing.Point(8, 7)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(226, 20)
        Me.txtApellidos.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(144, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 14)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Codigo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.rbtEmpleado)
        Me.GroupBox1.Controls.Add(Me.rdbAdministrador)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(558, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 64)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rol"
        '
        'rbtEmpleado
        '
        Me.rbtEmpleado.AutoSize = True
        Me.rbtEmpleado.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtEmpleado.Location = New System.Drawing.Point(7, 40)
        Me.rbtEmpleado.Name = "rbtEmpleado"
        Me.rbtEmpleado.Size = New System.Drawing.Size(79, 18)
        Me.rbtEmpleado.TabIndex = 1
        Me.rbtEmpleado.TabStop = True
        Me.rbtEmpleado.Text = "Empleado"
        Me.rbtEmpleado.UseVisualStyleBackColor = True
        '
        'rdbAdministrador
        '
        Me.rdbAdministrador.AutoSize = True
        Me.rdbAdministrador.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAdministrador.Location = New System.Drawing.Point(7, 16)
        Me.rdbAdministrador.Name = "rdbAdministrador"
        Me.rdbAdministrador.Size = New System.Drawing.Size(102, 18)
        Me.rdbAdministrador.TabIndex = 0
        Me.rdbAdministrador.TabStop = True
        Me.rdbAdministrador.Text = "Administrador"
        Me.rdbAdministrador.UseVisualStyleBackColor = True
        '
        'ElContainer5
        '
        Me.ElContainer5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer5.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer5.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer5.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer5.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer5.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer5.Controls.Add(Me.txtCodN)
        Me.ElContainer5.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer5.Location = New System.Drawing.Point(39, 115)
        Me.ElContainer5.Name = "ElContainer5"
        Me.ElContainer5.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer5.Size = New System.Drawing.Size(94, 34)
        Me.ElContainer5.TabIndex = 102
        Me.ElContainer5.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'txtCodN
        '
        Me.txtCodN.BackColor = System.Drawing.Color.Black
        Me.txtCodN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtCodN.ForeColor = System.Drawing.Color.White
        Me.txtCodN.Location = New System.Drawing.Point(8, 7)
        Me.txtCodN.Name = "txtCodN"
        Me.txtCodN.Size = New System.Drawing.Size(79, 20)
        Me.txtCodN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Inter", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(296, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 25)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Registrar Nuevo Empleado"
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
        Me.ElContainer7.Location = New System.Drawing.Point(147, 115)
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
        'frmRegistraEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(881, 496)
        Me.Controls.Add(Me.ElContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistraEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistraEmpleado"
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer1.ResumeLayout(False)
        Me.ElContainer1.PerformLayout()
        CType(Me.ElButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer6.ResumeLayout(False)
        Me.ElContainer6.PerformLayout()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer3.ResumeLayout(False)
        Me.ElContainer3.PerformLayout()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer2.ResumeLayout(False)
        Me.ElContainer2.PerformLayout()
        CType(Me.ElContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer4.ResumeLayout(False)
        Me.ElContainer4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ElContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer5.ResumeLayout(False)
        Me.ElContainer5.PerformLayout()
        CType(Me.ElContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer7.ResumeLayout(False)
        Me.ElContainer7.PerformLayout()
        CType(Me.panelCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCabecera.ResumeLayout(False)
        CType(Me.ElDivider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElContainer1 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents ElButton3 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents ElButton2 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents ElButton1 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents dgvEmpleado As DataGridView
    Friend WithEvents btnNuevo As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtNivel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ElContainer6 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtPassN As PowerTextBox
    Friend WithEvents btnRegistrar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents Label6 As Label
    Friend WithEvents ElContainer3 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtUsuarioN As PowerTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ElContainer2 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtCelular As PowerTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ElContainer4 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtApellidos As PowerTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtEmpleado As RadioButton
    Friend WithEvents rdbAdministrador As RadioButton
    Friend WithEvents ElContainer5 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtCodN As PowerTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ElContainer7 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtNombre As PowerTextBox
    Friend WithEvents panelCabecera As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents ElDivider1 As Klik.Windows.Forms.v1.EntryLib.ELDivider
    Friend WithEvents btnCerrar As Button
End Class
