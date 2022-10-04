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
        Me.ElContainer1 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.btnSalir = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ElContainer4 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.ElContainer3 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.ElContainer2 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ElContainer4)
        Me.Panel1.Controls.Add(Me.ElContainer3)
        Me.Panel1.Controls.Add(Me.ElContainer2)
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
        'ElContainer4
        '
        Me.ElContainer4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ElContainer4.BackgroundStyle.GradientEndColor = System.Drawing.Color.LawnGreen
        Me.ElContainer4.BackgroundStyle.GradientStartColor = System.Drawing.Color.Green
        Me.ElContainer4.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer4.Location = New System.Drawing.Point(734, 20)
        Me.ElContainer4.Name = "ElContainer4"
        Me.ElContainer4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer4.Size = New System.Drawing.Size(177, 64)
        Me.ElContainer4.TabIndex = 15
        Me.ElContainer4.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'ElContainer3
        '
        Me.ElContainer3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ElContainer3.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ElContainer3.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ElContainer3.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer3.Location = New System.Drawing.Point(521, 20)
        Me.ElContainer3.Name = "ElContainer3"
        Me.ElContainer3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer3.Size = New System.Drawing.Size(177, 64)
        Me.ElContainer3.TabIndex = 14
        Me.ElContainer3.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'ElContainer2
        '
        Me.ElContainer2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ElContainer2.BackgroundStyle.GradientEndColor = System.Drawing.Color.LightSalmon
        Me.ElContainer2.BackgroundStyle.GradientStartColor = System.Drawing.Color.OrangeRed
        Me.ElContainer2.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.ElContainer2.Controls.Add(Me.PictureBox2)
        Me.ElContainer2.Controls.Add(Me.Label3)
        Me.ElContainer2.Controls.Add(Me.Label4)
        Me.ElContainer2.Controls.Add(Me.Label2)
        Me.ElContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer2.Location = New System.Drawing.Point(308, 20)
        Me.ElContainer2.Name = "ElContainer2"
        Me.ElContainer2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer2.Size = New System.Drawing.Size(177, 64)
        Me.ElContainer2.TabIndex = 13
        Me.ElContainer2.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistema_Boomerang.My.Resources.Resources.grafico_de_barras
        Me.PictureBox2.Location = New System.Drawing.Point(11, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(69, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "1700.00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(35, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "S./"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(69, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ventas"
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
        CType(Me.ElContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer2.ResumeLayout(False)
        Me.ElContainer2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElContainer1 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents btnSalir As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ElContainer4 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents ElContainer3 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents ElContainer2 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
