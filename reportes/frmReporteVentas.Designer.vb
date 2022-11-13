<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteVentas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ventas1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetBoomerang = New Sistema_Boomerang.DataSetBoomerang()
        Me.ventas1TableAdapter = New Sistema_Boomerang.DataSetBoomerangTableAdapters.ventas1TableAdapter()
        CType(Me.ventas1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetBoomerang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ventas1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Boomerang.ReporteVentas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'ventas1BindingSource
        '
        Me.ventas1BindingSource.DataMember = "ventas1"
        Me.ventas1BindingSource.DataSource = Me.DataSetBoomerang
        '
        'DataSetBoomerang
        '
        Me.DataSetBoomerang.DataSetName = "DataSetBoomerang"
        Me.DataSetBoomerang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ventas1TableAdapter
        '
        Me.ventas1TableAdapter.ClearBeforeFill = True
        '
        'frmReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteVentas"
        Me.Text = "frmReporteVentas"
        CType(Me.ventas1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetBoomerang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ventas1BindingSource As BindingSource
    Friend WithEvents DataSetBoomerang As DataSetBoomerang
    Friend WithEvents ventas1TableAdapter As DataSetBoomerangTableAdapters.ventas1TableAdapter
End Class
