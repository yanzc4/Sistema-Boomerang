Public Class frmInventario
    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        reportdia = txtDia.Text
        reportmes = txtMes.Text
        reportaño = txtAño.Text
        frmReporteVentas.Show()
    End Sub
End Class