<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.panelCabecera = New System.Windows.Forms.Panel()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnMaxiMini = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelCabecera.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelCabecera
        '
        Me.panelCabecera.BackColor = System.Drawing.Color.Tomato
        Me.panelCabecera.Controls.Add(Me.Label1)
        Me.panelCabecera.Controls.Add(Me.btnMaxiMini)
        Me.panelCabecera.Controls.Add(Me.btnMinimizar)
        Me.panelCabecera.Controls.Add(Me.btnMaximizar)
        Me.panelCabecera.Controls.Add(Me.btnCerrar)
        Me.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(1084, 40)
        Me.panelCabecera.TabIndex = 0
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.Black
        Me.panelMenu.Controls.Add(Me.Button1)
        Me.panelMenu.Controls.Add(Me.btnDashboard)
        Me.panelMenu.Controls.Add(Me.btnInventario)
        Me.panelMenu.Controls.Add(Me.btnPedidos)
        Me.panelMenu.Controls.Add(Me.lblNombre)
        Me.panelMenu.Controls.Add(Me.Label2)
        Me.panelMenu.Controls.Add(Me.btnVenta)
        Me.panelMenu.Controls.Add(Me.pbLogo)
        Me.panelMenu.Controls.Add(Me.lblMenu)
        Me.panelMenu.Controls.Add(Me.btnMenu)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 40)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(220, 501)
        Me.panelMenu.TabIndex = 1
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(220, 40)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(864, 501)
        Me.panelContenedor.TabIndex = 2
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMenu.Font = New System.Drawing.Font("Inter Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.Tomato
        Me.lblMenu.Location = New System.Drawing.Point(12, 11)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(98, 35)
        Me.lblMenu.TabIndex = 1
        Me.lblMenu.Text = "Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(76, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Usuario:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(80, 172)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(51, 16)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Admin"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Inter Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SISTEMA DE RESTAURANTE"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Inter Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Sistema_Boomerang.My.Resources.Resources.configuraciones
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(218, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "    Ajustes"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Black
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Inter Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = Global.Sistema_Boomerang.My.Resources.Resources.speedometer
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(1, 375)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(218, 37)
        Me.btnDashboard.TabIndex = 9
        Me.btnDashboard.Text = "    Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnInventario
        '
        Me.btnInventario.BackColor = System.Drawing.Color.Black
        Me.btnInventario.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnInventario.FlatAppearance.BorderSize = 0
        Me.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventario.Font = New System.Drawing.Font("Inter Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.ForeColor = System.Drawing.Color.White
        Me.btnInventario.Image = Global.Sistema_Boomerang.My.Resources.Resources.caja
        Me.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventario.Location = New System.Drawing.Point(1, 317)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnInventario.Size = New System.Drawing.Size(218, 37)
        Me.btnInventario.TabIndex = 8
        Me.btnInventario.Text = "    Inventario"
        Me.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventario.UseVisualStyleBackColor = False
        '
        'btnPedidos
        '
        Me.btnPedidos.BackColor = System.Drawing.Color.Black
        Me.btnPedidos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPedidos.FlatAppearance.BorderSize = 0
        Me.btnPedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.btnPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedidos.Font = New System.Drawing.Font("Inter Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedidos.ForeColor = System.Drawing.Color.White
        Me.btnPedidos.Image = Global.Sistema_Boomerang.My.Resources.Resources.motorbike
        Me.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPedidos.Location = New System.Drawing.Point(1, 259)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnPedidos.Size = New System.Drawing.Size(218, 37)
        Me.btnPedidos.TabIndex = 7
        Me.btnPedidos.Text = "    Pedidos"
        Me.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPedidos.UseVisualStyleBackColor = False
        '
        'btnVenta
        '
        Me.btnVenta.BackColor = System.Drawing.Color.Black
        Me.btnVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVenta.FlatAppearance.BorderSize = 0
        Me.btnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.btnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.Font = New System.Drawing.Font("Inter Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.ForeColor = System.Drawing.Color.White
        Me.btnVenta.Image = Global.Sistema_Boomerang.My.Resources.Resources.papas_fritas
        Me.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVenta.Location = New System.Drawing.Point(2, 203)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnVenta.Size = New System.Drawing.Size(218, 37)
        Me.btnVenta.TabIndex = 3
        Me.btnVenta.Text = "    Venta"
        Me.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVenta.UseVisualStyleBackColor = False
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.Sistema_Boomerang.My.Resources.Resources.Logo_empresa_removebg_preview
        Me.pbLogo.Location = New System.Drawing.Point(10, 51)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(198, 101)
        Me.pbLogo.TabIndex = 2
        Me.pbLogo.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Image = Global.Sistema_Boomerang.My.Resources.Resources.lista
        Me.btnMenu.Location = New System.Drawing.Point(173, 10)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(40, 40)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnMaxiMini
        '
        Me.btnMaxiMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaxiMini.FlatAppearance.BorderSize = 0
        Me.btnMaxiMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMaxiMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMaxiMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaxiMini.Image = Global.Sistema_Boomerang.My.Resources.Resources.lavado_en_seco
        Me.btnMaxiMini.Location = New System.Drawing.Point(998, 0)
        Me.btnMaxiMini.Name = "btnMaxiMini"
        Me.btnMaxiMini.Size = New System.Drawing.Size(40, 40)
        Me.btnMaxiMini.TabIndex = 3
        Me.btnMaxiMini.UseVisualStyleBackColor = True
        Me.btnMaxiMini.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Sistema_Boomerang.My.Resources.Resources.triangulo
        Me.btnMinimizar.Location = New System.Drawing.Point(952, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.Sistema_Boomerang.My.Resources.Resources.lavado_en_seco
        Me.btnMaximizar.Location = New System.Drawing.Point(998, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Sistema_Boomerang.My.Resources.Resources.cerrar_verde
        Me.btnCerrar.Location = New System.Drawing.Point(1044, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 541)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelCabecera.ResumeLayout(False)
        Me.panelCabecera.PerformLayout()
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelCabecera As Panel
    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaxiMini As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents btnVenta As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnPedidos As Button
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents Label1 As Label
End Class
