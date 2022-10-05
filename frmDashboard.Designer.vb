<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ElContainer1 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ElContainer3 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.btnSalir = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ElContainer5 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ElContainer2 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ElContainer1.Controls.Add(Me.Chart2)
        Me.ElContainer1.Controls.Add(Me.Chart1)
        Me.ElContainer1.Controls.Add(Me.Panel1)
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
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.ElContainer2)
        Me.Panel1.Controls.Add(Me.ElContainer5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ElContainer3)
        Me.Panel1.Location = New System.Drawing.Point(0, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 100)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Sistema_Boomerang.My.Resources.Resources.Logo_empresa_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(61, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'ElContainer3
        '
        Me.ElContainer3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ElContainer3.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer3.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer3.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer3.Controls.Add(Me.PictureBox2)
        Me.ElContainer3.Controls.Add(Me.Label3)
        Me.ElContainer3.Controls.Add(Me.Label4)
        Me.ElContainer3.Controls.Add(Me.Label2)
        Me.ElContainer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer3.Location = New System.Drawing.Point(521, 20)
        Me.ElContainer3.Name = "ElContainer3"
        Me.ElContainer3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer3.Size = New System.Drawing.Size(177, 64)
        Me.ElContainer3.TabIndex = 14
        Me.ElContainer3.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
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
        Me.Label1.Location = New System.Drawing.Point(396, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Panel de Control"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistema_Boomerang.My.Resources.Resources.grafico_de_barras
        Me.PictureBox2.Location = New System.Drawing.Point(14, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(72, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "1700.00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(38, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "S./"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(72, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ventas"
        '
        'ElContainer5
        '
        Me.ElContainer5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ElContainer5.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer5.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer5.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer5.Controls.Add(Me.PictureBox3)
        Me.ElContainer5.Controls.Add(Me.Label5)
        Me.ElContainer5.Controls.Add(Me.Label6)
        Me.ElContainer5.Controls.Add(Me.Label7)
        Me.ElContainer5.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer5.Location = New System.Drawing.Point(308, 20)
        Me.ElContainer5.Name = "ElContainer5"
        Me.ElContainer5.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer5.Size = New System.Drawing.Size(177, 64)
        Me.ElContainer5.TabIndex = 17
        Me.ElContainer5.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Sistema_Boomerang.My.Resources.Resources.grafico_de_barras
        Me.PictureBox3.Location = New System.Drawing.Point(14, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(72, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "1700.00"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(38, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "S./"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(72, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Ventas"
        '
        'ElContainer2
        '
        Me.ElContainer2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ElContainer2.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer2.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer2.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer2.Controls.Add(Me.PictureBox4)
        Me.ElContainer2.Controls.Add(Me.Label8)
        Me.ElContainer2.Controls.Add(Me.Label9)
        Me.ElContainer2.Controls.Add(Me.Label10)
        Me.ElContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer2.Location = New System.Drawing.Point(734, 20)
        Me.ElContainer2.Name = "ElContainer2"
        Me.ElContainer2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer2.Size = New System.Drawing.Size(177, 64)
        Me.ElContainer2.TabIndex = 18
        Me.ElContainer2.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Sistema_Boomerang.My.Resources.Resources.grafico_de_barras
        Me.PictureBox4.Location = New System.Drawing.Point(14, 15)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(72, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "1700.00"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(38, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "S./"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(72, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Ventas"
        '
        'Chart1
        '
        Me.Chart1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea2.AxisX.IsMarginVisible = False
        ChartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisX.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.LineWidth = 0
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.MajorGrid.LineWidth = 0
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        ChartArea2.AxisX.MajorTickMark.Size = 3.0!
        ChartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisY.LabelStyle.Format = "$(0)"
        ChartArea2.AxisY.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.LineWidth = 0
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.Transparent
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Legend2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(21, 197)
        Me.Chart1.Name = "Chart1"
        Series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Series2.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
        Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Series2.BorderWidth = 3
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
        Series2.Color = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(127, Byte), Integer))
        Series2.Legend = "Legend1"
        Series2.MarkerBorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Series2.MarkerColor = System.Drawing.Color.White
        Series2.MarkerImageTransparentColor = System.Drawing.Color.White
        Series2.MarkerSize = 6
        Series2.Name = "Ventas"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(576, 217)
        Me.Chart1.TabIndex = 16
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        Me.Chart2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Chart2.BackColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.IsMarginVisible = False
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.LineWidth = 0
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MajorGrid.LineWidth = 0
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        ChartArea1.AxisX.MajorTickMark.Size = 3.0!
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.LabelStyle.Format = "$(0)"
        ChartArea1.AxisY.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.LineWidth = 0
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Legend1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.TitleBackColor = System.Drawing.Color.Transparent
        Legend1.TitleForeColor = System.Drawing.Color.Empty
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(584, 219)
        Me.Chart2.Name = "Chart2"
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Series1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(127, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.MarkerBorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Series1.MarkerColor = System.Drawing.Color.White
        Series1.MarkerImageTransparentColor = System.Drawing.Color.White
        Series1.MarkerSize = 6
        Series1.Name = "Ventas"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(357, 217)
        Me.Chart2.TabIndex = 17
        Me.Chart2.Text = "Chart2"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 670)
        Me.Controls.Add(Me.ElContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer1.ResumeLayout(False)
        Me.ElContainer1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer3.ResumeLayout(False)
        Me.ElContainer3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer5.ResumeLayout(False)
        Me.ElContainer5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer2.ResumeLayout(False)
        Me.ElContainer2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElContainer1 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents btnSalir As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ElContainer3 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents ElContainer2 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ElContainer5 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
