﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ElContainer1 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.ElContainer9 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.gfcVentas = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ElContainer8 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElContainer3 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.ElButton2 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnBuscar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElContainer7 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.txtBuscar = New Sistema_Boomerang.PowerTextBox()
        Me.ElButton1 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ElContainer2 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btnGuardar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
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
        CType(Me.ElContainer9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer9.SuspendLayout()
        CType(Me.gfcVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer8.SuspendLayout()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer3.SuspendLayout()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer7.SuspendLayout()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer2.SuspendLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ElContainer1.Controls.Add(Me.ElContainer9)
        Me.ElContainer1.Controls.Add(Me.ElContainer8)
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
        'ElContainer9
        '
        Me.ElContainer9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer9.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ElContainer9.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ElContainer9.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer9.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer9.BorderStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ElContainer9.BorderStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ElContainer9.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer9.Controls.Add(Me.gfcVentas)
        Me.ElContainer9.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer9.Location = New System.Drawing.Point(653, 411)
        Me.ElContainer9.Name = "ElContainer9"
        Me.ElContainer9.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer9.Size = New System.Drawing.Size(311, 218)
        Me.ElContainer9.TabIndex = 131
        Me.ElContainer9.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'gfcVentas
        '
        Me.gfcVentas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gfcVentas.BackColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.IsMarginVisible = False
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        ChartArea1.AxisX.LineWidth = 0
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MajorGrid.LineWidth = 0
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        ChartArea1.AxisX.MajorTickMark.Size = 3.0!
        ChartArea1.AxisX2.LineColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.LabelStyle.Format = "$(0)"
        ChartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        ChartArea1.AxisY.LineWidth = 0
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        ChartArea1.AxisY2.LineColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.gfcVentas.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Legend1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.TitleBackColor = System.Drawing.Color.Transparent
        Legend1.TitleForeColor = System.Drawing.Color.Empty
        Me.gfcVentas.Legends.Add(Legend1)
        Me.gfcVentas.Location = New System.Drawing.Point(7, 10)
        Me.gfcVentas.Name = "gfcVentas"
        Me.gfcVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.gfcVentas.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(127, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(254, Byte), Integer))}
        Series1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Series1.BorderWidth = 8
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.LabelForeColor = System.Drawing.Color.Transparent
        Series1.Legend = "Legend1"
        Series1.MarkerBorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Series1.MarkerColor = System.Drawing.Color.White
        Series1.MarkerImageTransparentColor = System.Drawing.Color.White
        Series1.MarkerSize = 6
        Series1.Name = "venta_hoy_ayer"
        Me.gfcVentas.Series.Add(Series1)
        Me.gfcVentas.Size = New System.Drawing.Size(297, 202)
        Me.gfcVentas.TabIndex = 142
        Me.gfcVentas.Text = "Chart4"
        '
        'ElContainer8
        '
        Me.ElContainer8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElContainer8.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ElContainer8.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ElContainer8.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer8.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer8.BorderStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ElContainer8.BorderStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ElContainer8.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElContainer8.Controls.Add(Me.Label7)
        Me.ElContainer8.Controls.Add(Me.TextBox1)
        Me.ElContainer8.Controls.Add(Me.btnEliminar)
        Me.ElContainer8.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer8.Location = New System.Drawing.Point(17, 411)
        Me.ElContainer8.Name = "ElContainer8"
        Me.ElContainer8.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer8.Size = New System.Drawing.Size(617, 218)
        Me.ElContainer8.TabIndex = 129
        Me.ElContainer8.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(57, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(391, 48)
        Me.Label7.TabIndex = 136
        Me.Label7.Text = "Seleccione venta a eliminar de la lista de ventas luego click en el boton elimina" &
    "r"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(52, 159)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 127
        Me.TextBox1.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEliminar.BackgroundImageStyle.FilterColor = System.Drawing.Color.Black
        Me.btnEliminar.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEliminar.BackgroundImageStyle.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnEliminar.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnEliminar.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnEliminar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEliminar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnEliminar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnEliminar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(60, 69)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(116, 34)
        Me.btnEliminar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnEliminar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnEliminar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnEliminar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnEliminar.TabIndex = 134
        Me.btnEliminar.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.TextStyle.Text = "Eliminar"
        Me.btnEliminar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEliminar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
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
        Me.ElContainer3.Controls.Add(Me.ElButton2)
        Me.ElContainer3.Controls.Add(Me.btnBuscar)
        Me.ElContainer3.Controls.Add(Me.ElContainer7)
        Me.ElContainer3.Controls.Add(Me.ElButton1)
        Me.ElContainer3.Controls.Add(Me.dgvVentas)
        Me.ElContainer3.Controls.Add(Me.Label2)
        Me.ElContainer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer3.Location = New System.Drawing.Point(17, 66)
        Me.ElContainer3.Name = "ElContainer3"
        Me.ElContainer3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer3.Size = New System.Drawing.Size(617, 326)
        Me.ElContainer3.TabIndex = 125
        Me.ElContainer3.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'ElButton2
        '
        Me.ElButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ElButton2.BackgroundImageStyle.FilterColor = System.Drawing.Color.Black
        Me.ElButton2.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton2.BackgroundImageStyle.ImageSize = New System.Drawing.Size(24, 24)
        Me.ElButton2.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton2.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElButton2.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ElButton2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElButton2.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton2.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton2.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton2.Location = New System.Drawing.Point(483, 148)
        Me.ElButton2.Name = "ElButton2"
        Me.ElButton2.Size = New System.Drawing.Size(116, 34)
        Me.ElButton2.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton2.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton2.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.ElButton2.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.ElButton2.TabIndex = 132
        Me.ElButton2.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton2.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElButton2.TextStyle.Text = "Editar"
        Me.ElButton2.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton2.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
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
        Me.btnBuscar.Location = New System.Drawing.Point(311, 12)
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
        Me.ElContainer7.Location = New System.Drawing.Point(26, 12)
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
        Me.ElButton1.Location = New System.Drawing.Point(483, 98)
        Me.ElButton1.Name = "ElButton1"
        Me.ElButton1.Size = New System.Drawing.Size(116, 34)
        Me.ElButton1.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton1.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElButton1.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.ElButton1.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.ElButton1.TabIndex = 128
        Me.ElButton1.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton1.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElButton1.TextStyle.Text = "Pedidos"
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
        Me.dgvVentas.Location = New System.Drawing.Point(26, 98)
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
        Me.dgvVentas.Size = New System.Drawing.Size(436, 215)
        Me.dgvVentas.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 62)
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
        Me.ElContainer2.Controls.Add(Me.lblCodigo)
        Me.ElContainer2.Controls.Add(Me.btnGuardar)
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
        'lblCodigo
        '
        Me.lblCodigo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(201, 166)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 23)
        Me.lblCodigo.TabIndex = 140
        Me.lblCodigo.Text = "--"
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCodigo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGuardar.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnGuardar.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnGuardar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGuardar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnGuardar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnGuardar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGuardar.Location = New System.Drawing.Point(31, 267)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(123, 34)
        Me.btnGuardar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnGuardar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnGuardar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnGuardar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnGuardar.TabIndex = 139
        Me.btnGuardar.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.TextStyle.Text = "Guardar"
        Me.btnGuardar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGuardar.Visible = False
        Me.btnGuardar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
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
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(387, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 29)
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
        CType(Me.ElContainer9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer9.ResumeLayout(False)
        CType(Me.gfcVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer8.ResumeLayout(False)
        Me.ElContainer8.PerformLayout()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer3.ResumeLayout(False)
        Me.ElContainer3.PerformLayout()
        CType(Me.ElButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer7.ResumeLayout(False)
        Me.ElContainer7.PerformLayout()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer2.ResumeLayout(False)
        Me.ElContainer2.PerformLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ElContainer8 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents ElButton2 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnGuardar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents lblCodigo As Label
    Friend WithEvents btnEliminar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents Label7 As Label
    Friend WithEvents ElContainer9 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents gfcVentas As DataVisualization.Charting.Chart
End Class
