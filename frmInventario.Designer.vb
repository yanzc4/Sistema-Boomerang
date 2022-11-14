<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventario
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
        Me.btnFiltrar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer1.SuspendLayout()
        CType(Me.btnFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ElContainer1.Controls.Add(Me.btnFiltrar)
        Me.ElContainer1.Controls.Add(Me.panelContenedor)
        Me.ElContainer1.Controls.Add(Me.Label3)
        Me.ElContainer1.Controls.Add(Me.txtAño)
        Me.ElContainer1.Controls.Add(Me.Label4)
        Me.ElContainer1.Controls.Add(Me.Label5)
        Me.ElContainer1.Controls.Add(Me.txtMes)
        Me.ElContainer1.Controls.Add(Me.txtDia)
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
        'btnFiltrar
        '
        Me.btnFiltrar.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnFiltrar.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnFiltrar.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFiltrar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnFiltrar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnFiltrar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnFiltrar.Location = New System.Drawing.Point(526, 139)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(111, 28)
        Me.btnFiltrar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnFiltrar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnFiltrar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnFiltrar.TabIndex = 56
        Me.btnFiltrar.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnFiltrar.TextStyle.Text = "Filtrar"
        Me.btnFiltrar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnFiltrar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'panelContenedor
        '
        Me.panelContenedor.Location = New System.Drawing.Point(88, 197)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(801, 391)
        Me.panelContenedor.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(85, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Dia:"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(369, 143)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(366, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Año:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(225, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Mes:"
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(228, 143)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 49
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(88, 143)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(100, 20)
        Me.txtDia.TabIndex = 47
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
        Me.Label1.Location = New System.Drawing.Point(352, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "REPORTE DE VENTAS"
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 670)
        Me.Controls.Add(Me.ElContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInventario"
        Me.Text = "frmInventario"
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer1.ResumeLayout(False)
        Me.ElContainer1.PerformLayout()
        CType(Me.btnFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElContainer1 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents btnSalir As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMes As TextBox
    Friend WithEvents txtDia As TextBox
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents btnFiltrar As Klik.Windows.Forms.v1.EntryLib.ELButton
End Class
