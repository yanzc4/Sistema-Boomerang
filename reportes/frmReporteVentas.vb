Public Class frmReporteVentas
    Private Sub frmReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetBoomerang.ventas1' Puede moverla o quitarla según sea necesario.
        Me.ventas1TableAdapter.FillByDiaMesAño(Me.DataSetBoomerang.ventas1, reportdia, reportmes, reportaño)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class