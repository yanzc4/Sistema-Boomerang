<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVaucher
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me._vaucherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.boomerangDataSet = New Sistema_Boomerang.boomerangDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me._vaucherTableAdapter = New Sistema_Boomerang.boomerangDataSetTableAdapters._vaucherTableAdapter()
        Me.panelCabecera = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me._vaucherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boomerangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        '_vaucherBindingSource
        '
        Me._vaucherBindingSource.DataMember = "_vaucher"
        Me._vaucherBindingSource.DataSource = Me.boomerangDataSet
        '
        'boomerangDataSet
        '
        Me.boomerangDataSet.DataSetName = "boomerangDataSet"
        Me.boomerangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me._vaucherBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Boomerang.vaucher.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 51)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(333, 390)
        Me.ReportViewer1.TabIndex = 0
        '
        '_vaucherTableAdapter
        '
        Me._vaucherTableAdapter.ClearBeforeFill = True
        '
        'panelCabecera
        '
        Me.panelCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.panelCabecera.Controls.Add(Me.Label1)
        Me.panelCabecera.Controls.Add(Me.btnCerrar)
        Me.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(358, 40)
        Me.panelCabecera.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TICKET"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Sistema_Boomerang.My.Resources.Resources.cruzar
        Me.btnCerrar.Location = New System.Drawing.Point(318, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmVaucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(358, 453)
        Me.Controls.Add(Me.panelCabecera)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVaucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVaucher"
        CType(Me._vaucherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boomerangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCabecera.ResumeLayout(False)
        Me.panelCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents _vaucherBindingSource As BindingSource
    Friend WithEvents boomerangDataSet As boomerangDataSet
    Friend WithEvents _vaucherTableAdapter As boomerangDataSetTableAdapters._vaucherTableAdapter
    Friend WithEvents panelCabecera As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
End Class
