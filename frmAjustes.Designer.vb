<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjustes
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
        Me.btnNuevoEmp = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnSalir = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevoCate = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer1.SuspendLayout()
        CType(Me.btnNuevoEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevoCate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ElContainer1.Controls.Add(Me.btnNuevoCate)
        Me.ElContainer1.Controls.Add(Me.btnNuevoEmp)
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
        'btnNuevoEmp
        '
        Me.btnNuevoEmp.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevoEmp.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnNuevoEmp.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.btnNuevoEmp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevoEmp.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnNuevoEmp.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnNuevoEmp.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevoEmp.Location = New System.Drawing.Point(53, 92)
        Me.btnNuevoEmp.Name = "btnNuevoEmp"
        Me.btnNuevoEmp.Size = New System.Drawing.Size(150, 39)
        Me.btnNuevoEmp.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevoEmp.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevoEmp.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnNuevoEmp.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnNuevoEmp.TabIndex = 47
        Me.btnNuevoEmp.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoEmp.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnNuevoEmp.TextStyle.Text = "Nuevo Empleado"
        Me.btnNuevoEmp.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevoEmp.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
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
        Me.Label1.Location = New System.Drawing.Point(387, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ajustes Del Sistema"
        '
        'btnNuevoCate
        '
        Me.btnNuevoCate.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevoCate.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnNuevoCate.BorderStyle.SolidColor = System.Drawing.Color.Black
        Me.btnNuevoCate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevoCate.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnNuevoCate.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnNuevoCate.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevoCate.Location = New System.Drawing.Point(228, 92)
        Me.btnNuevoCate.Name = "btnNuevoCate"
        Me.btnNuevoCate.Size = New System.Drawing.Size(150, 39)
        Me.btnNuevoCate.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevoCate.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnNuevoCate.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Black
        Me.btnNuevoCate.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black
        Me.btnNuevoCate.TabIndex = 48
        Me.btnNuevoCate.TextStyle.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCate.TextStyle.ForeColor = System.Drawing.Color.White
        Me.btnNuevoCate.TextStyle.Text = "Nueva Categoria"
        Me.btnNuevoCate.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevoCate.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom
        '
        'frmAjustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 670)
        Me.Controls.Add(Me.ElContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAjustes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAjustes"
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer1.ResumeLayout(False)
        Me.ElContainer1.PerformLayout()
        CType(Me.btnNuevoEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevoCate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElContainer1 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents btnSalir As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNuevoEmp As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnNuevoCate As Klik.Windows.Forms.v1.EntryLib.ELButton
End Class
