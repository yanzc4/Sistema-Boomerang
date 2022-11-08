<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPedidos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ElContainer1 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ElContainer3 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.btnBuscar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElContainer7 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.txtBuscar = New Sistema_Boomerang.PowerTextBox()
        Me.ElButton1 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ElContainer2 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.btnNuevo = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnRegistrar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ElContainer6 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.txtCliente = New Sistema_Boomerang.PowerTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ElContainer5 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ElContainer4 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.lblCod_user = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer1.SuspendLayout()
        CType(Me.ElContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer3.SuspendLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer7.SuspendLayout()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer2.SuspendLayout()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer6.SuspendLayout()
        CType(Me.ElContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer5.SuspendLayout()
        CType(Me.ElContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ElContainer1
        '
        Me.ElContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElContainer1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer1.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer1.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer1.Controls.Add(Me.TextBox1)
        Me.ElContainer1.Controls.Add(Me.ElContainer3)
        Me.ElContainer1.Controls.Add(Me.ElContainer2)
        Me.ElContainer1.Controls.Add(Me.btnSalir)
        Me.ElContainer1.Controls.Add(Me.Label1)
        Me.ElContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer1.Location = New System.Drawing.Point(12, 12)
        Me.ElContainer1.Name = "ElContainer1"
        Me.ElContainer1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer1.Size = New System.Drawing.Size(980, 646)
        Me.ElContainer1.TabIndex = 1
        Me.ElContainer1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(396, 533)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 127
        '
        'ElContainer3
        '
        Me.ElContainer3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer3.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ElContainer3.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ElContainer3.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer3.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer3.BorderStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ElContainer3.BorderStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ElContainer3.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer3.Controls.Add(Me.btnBuscar)
        Me.ElContainer3.Controls.Add(Me.ElContainer7)
        Me.ElContainer3.Controls.Add(Me.ElButton1)
        Me.ElContainer3.Controls.Add(Me.dgvVentas)
        Me.ElContainer3.Controls.Add(Me.Label2)
        Me.ElContainer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer3.Location = New System.Drawing.Point(17, 66)
        Me.ElContainer3.Name = "ElContainer3"
        Me.ElContainer3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer3.Size = New System.Drawing.Size(548, 379)
        Me.ElContainer3.TabIndex = 125
        Me.ElContainer3.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBuscar.BackgroundImageStyle.FilterColor = System.Drawing.Color.Black
        Me.btnBuscar.BackgroundImageStyle.Image = Global.Sistema_Boomerang.My.Resources.Resources.buscar1
        Me.btnBuscar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBuscar.BackgroundImageStyle.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnBuscar.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnBuscar.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnBuscar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBuscar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnBuscar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBuscar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBuscar.Location = New System.Drawing.Point(300, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(43, 34)
        Me.btnBuscar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnBuscar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnBuscar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnBuscar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnBuscar.TabIndex = 130
        Me.btnBuscar.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBuscar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'ElContainer7
        '
        Me.ElContainer7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer7.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer7.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer7.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer7.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer7.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer7.Controls.Add(Me.txtBuscar)
        Me.ElContainer7.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer7.Location = New System.Drawing.Point(20, 12)
        Me.ElContainer7.Name = "ElContainer7"
        Me.ElContainer7.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer7.Size = New System.Drawing.Size(274, 34)
        Me.ElContainer7.TabIndex = 129
        Me.ElContainer7.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.Black
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(8, 7)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(259, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'ElButton1
        '
        Me.ElButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElButton1.BackgroundImageStyle.FilterColor = System.Drawing.Color.Black
        Me.ElButton1.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.BackgroundImageStyle.ImageSize = New System.Drawing.Size(24, 24)
        Me.ElButton1.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton1.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElButton1.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElButton1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton1.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.Location = New System.Drawing.Point(462, 112)
        Me.ElButton1.Name = "ElButton1"
        Me.ElButton1.Size = New System.Drawing.Size(43, 34)
        Me.ElButton1.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton1.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton1.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.ElButton1.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.ElButton1.TabIndex = 128
        Me.ElButton1.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton1.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.ElButton1.TextStyle.Text = "ver"
        Me.ElButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'dgvVentas
        '
        Me.dgvVentas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVentas.ColumnHeadersHeight = 30
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVentas.EnableHeadersVisualStyles = False
        Me.dgvVentas.GridColor = System.Drawing.Color.Yellow
        Me.dgvVentas.Location = New System.Drawing.Point(20, 112)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.RowHeadersWidth = 51
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvVentas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(436, 248)
        Me.dgvVentas.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 23)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "LIsta de ventas:"
        '
        'ElContainer2
        '
        Me.ElContainer2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer2.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ElContainer2.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ElContainer2.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer2.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer2.BorderStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ElContainer2.BorderStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ElContainer2.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer2.Controls.Add(Me.btnNuevo)
        Me.ElContainer2.Controls.Add(Me.btnRegistrar)
        Me.ElContainer2.Controls.Add(Me.Label6)
        Me.ElContainer2.Controls.Add(Me.ElContainer6)
        Me.ElContainer2.Controls.Add(Me.Label5)
        Me.ElContainer2.Controls.Add(Me.ElContainer5)
        Me.ElContainer2.Controls.Add(Me.Label4)
        Me.ElContainer2.Controls.Add(Me.ElContainer4)
        Me.ElContainer2.Controls.Add(Me.Label3)
        Me.ElContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer2.Location = New System.Drawing.Point(653, 66)
        Me.ElContainer2.Name = "ElContainer2"
        Me.ElContainer2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer2.Size = New System.Drawing.Size(311, 326)
        Me.ElContainer2.TabIndex = 123
        Me.ElContainer2.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
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
        Me.btnNuevo.Location = New System.Drawing.Point(158, 267)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(123, 34)
        Me.btnNuevo.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevo.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevo.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnNuevo.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnNuevo.TabIndex = 137
        Me.btnNuevo.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.TextStyle.Text = "Nuevo"
        Me.btnNuevo.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevo.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
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
        Me.btnRegistrar.Location = New System.Drawing.Point(31, 267)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(123, 34)
        Me.btnRegistrar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnRegistrar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnRegistrar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnRegistrar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnRegistrar.TabIndex = 136
        Me.btnRegistrar.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.TextStyle.Text = "Registrar"
        Me.btnRegistrar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegistrar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(28, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 15)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Nombre del Cliente"
        '
        'ElContainer6
        '
        Me.ElContainer6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer6.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer6.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer6.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer6.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer6.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer6.Controls.Add(Me.txtCliente)
        Me.ElContainer6.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer6.Location = New System.Drawing.Point(31, 211)
        Me.ElContainer6.Name = "ElContainer6"
        Me.ElContainer6.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer6.Size = New System.Drawing.Size(250, 34)
        Me.ElContainer6.TabIndex = 134
        Me.ElContainer6.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.Black
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtCliente.ForeColor = System.Drawing.Color.White
        Me.txtCliente.Location = New System.Drawing.Point(8, 7)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(235, 20)
        Me.txtCliente.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Fecha"
        '
        'ElContainer5
        '
        Me.ElContainer5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer5.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer5.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer5.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer5.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer5.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer5.Controls.Add(Me.lblFecha)
        Me.ElContainer5.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer5.Location = New System.Drawing.Point(31, 149)
        Me.ElContainer5.Name = "ElContainer5"
        Me.ElContainer5.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer5.Size = New System.Drawing.Size(103, 34)
        Me.ElContainer5.TabIndex = 132
        Me.ElContainer5.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(6, 6)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(89, 23)
        Me.lblFecha.TabIndex = 125
        Me.lblFecha.Text = "2022-11-08"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(28, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 15)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Codigo Empleado"
        '
        'ElContainer4
        '
        Me.ElContainer4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer4.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer4.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer4.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer4.BackgroundStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer4.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer4.Controls.Add(Me.lblCod_user)
        Me.ElContainer4.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer4.Location = New System.Drawing.Point(31, 86)
        Me.ElContainer4.Name = "ElContainer4"
        Me.ElContainer4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer4.Size = New System.Drawing.Size(69, 34)
        Me.ElContainer4.TabIndex = 130
        Me.ElContainer4.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'lblCod_user
        '
        Me.lblCod_user.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod_user.ForeColor = System.Drawing.Color.White
        Me.lblCod_user.Location = New System.Drawing.Point(9, 6)
        Me.lblCod_user.Name = "lblCod_user"
        Me.lblCod_user.Size = New System.Drawing.Size(51, 23)
        Me.lblCod_user.TabIndex = 125
        Me.lblCod_user.Text = "U009"
        Me.lblCod_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(109, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 23)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Nueva Venta"
        '
        'btnSalir
        '
        Me.btnSalir.AutoSize = True
        Me.btnSalir.BackColor = System.Drawing.Color.Tomato
        Me.btnSalir.Font = New System.Drawing.Font("Inter Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(16, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(31, 29)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "X"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(387, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Registro de ventas"
        '
        'frmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 670)
        Me.Controls.Add(Me.ElContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPedidos"
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer1.ResumeLayout(False)
        Me.ElContainer1.PerformLayout()
        CType(Me.ElContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer3.ResumeLayout(False)
        Me.ElContainer3.PerformLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer7.ResumeLayout(False)
        Me.ElContainer7.PerformLayout()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer2.ResumeLayout(False)
        Me.ElContainer2.PerformLayout()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer6.ResumeLayout(False)
        Me.ElContainer6.PerformLayout()
        CType(Me.ElContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer5.ResumeLayout(False)
        CType(Me.ElContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElContainer1 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ElContainer3 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents ElContainer2 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents btnSalir As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents ElContainer7 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtBuscar As PowerTextBox
    Friend WithEvents ElButton1 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents ElContainer4 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents lblCod_user As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ElContainer5 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ElContainer6 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents txtCliente As PowerTextBox
    Friend WithEvents btnNuevo As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnRegistrar As Klik.Windows.Forms.v1.EntryLib.ELButton
End Class
