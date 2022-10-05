<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVenta
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
        Me.ElContainer1 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.btnSalir = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer1.SuspendLayout()
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
        Me.ElContainer1.Controls.Add(Me.btnSalir)
        Me.ElContainer1.Controls.Add(Me.Label1)
        Me.ElContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer1.Location = New System.Drawing.Point(12, 12)
        Me.ElContainer1.Name = "ElContainer1"
        Me.ElContainer1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer1.Size = New System.Drawing.Size(980, 646)
        Me.ElContainer1.TabIndex = 0
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
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(415, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VENTAS"
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 670)
        Me.Controls.Add(Me.ElContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVenta"
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer1.ResumeLayout(False)
        Me.ElContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElContainer1 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents btnSalir As Label
    Friend WithEvents Label1 As Label
End Class
