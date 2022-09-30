<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCarga
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.carga = New CircularProgressBar.CircularProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelCabecera.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelCabecera
        '
        Me.panelCabecera.BackColor = System.Drawing.Color.Black
        Me.panelCabecera.Controls.Add(Me.Label1)
        Me.panelCabecera.Controls.Add(Me.btnMinimizar)
        Me.panelCabecera.Controls.Add(Me.btnCerrar)
        Me.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(864, 40)
        Me.panelCabecera.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SISTEMA DE RESTAURANTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(52, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sistema Creado para el"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(52, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Restaurante Bommerang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(52, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Venta de Platos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(52, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "A la Carta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(52, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Ven y Disfruta-Boomerang"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Red
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Inter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(56, 220)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(216, 31)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "Ingresar"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'carga
        '
        Me.carga.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.carga.AnimationSpeed = 500
        Me.carga.BackColor = System.Drawing.Color.Transparent
        Me.carga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carga.ForeColor = System.Drawing.Color.White
        Me.carga.InnerColor = System.Drawing.Color.Transparent
        Me.carga.InnerMargin = 2
        Me.carga.InnerWidth = -1
        Me.carga.Location = New System.Drawing.Point(57, 288)
        Me.carga.MarqueeAnimationSpeed = 2000
        Me.carga.Name = "carga"
        Me.carga.OuterColor = System.Drawing.Color.Black
        Me.carga.OuterMargin = -25
        Me.carga.OuterWidth = 26
        Me.carga.ProgressColor = System.Drawing.Color.Red
        Me.carga.ProgressWidth = 8
        Me.carga.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carga.Size = New System.Drawing.Size(110, 110)
        Me.carga.StartAngle = 270
        Me.carga.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.carga.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.carga.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.carga.SubscriptText = ""
        Me.carga.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.carga.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.carga.SuperscriptText = ""
        Me.carga.TabIndex = 11
        Me.carga.TextMargin = New System.Windows.Forms.Padding(8)
        Me.carga.Value = 68
        '
        'Timer1
        '
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(66, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cargando..."
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar1.AnimationSpeed = 500
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgressBar1.InnerColor = System.Drawing.Color.Black
        Me.CircularProgressBar1.InnerMargin = 2
        Me.CircularProgressBar1.InnerWidth = -1
        Me.CircularProgressBar1.Location = New System.Drawing.Point(762, 379)
        Me.CircularProgressBar1.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.OuterColor = System.Drawing.Color.Black
        Me.CircularProgressBar1.OuterMargin = -25
        Me.CircularProgressBar1.OuterWidth = 26
        Me.CircularProgressBar1.ProgressColor = System.Drawing.Color.Red
        Me.CircularProgressBar1.ProgressWidth = 5
        Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBar1.Size = New System.Drawing.Size(90, 90)
        Me.CircularProgressBar1.StartAngle = 270
        Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar1.SubscriptText = ".23"
        Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar1.SuperscriptText = "°C"
        Me.CircularProgressBar1.TabIndex = 14
        Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar1.Value = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(682, 407)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "User"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Inter Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(656, 426)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 19)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Iniciar Sesion"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Sistema_Boomerang.My.Resources.Resources.perfil2
        Me.PictureBox2.Location = New System.Drawing.Point(782, 401)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_Boomerang.My.Resources.Resources.setupw
        Me.PictureBox1.Location = New System.Drawing.Point(329, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 427)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Sistema_Boomerang.My.Resources.Resources.triangulo
        Me.btnMinimizar.Location = New System.Drawing.Point(780, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Sistema_Boomerang.My.Resources.Resources.cruzar
        Me.btnCerrar.Location = New System.Drawing.Point(824, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(864, 501)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.CircularProgressBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.carga)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCarga"
        Me.panelCabecera.ResumeLayout(False)
        Me.panelCabecera.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelCabecera As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents carga As CircularProgressBar.CircularProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
