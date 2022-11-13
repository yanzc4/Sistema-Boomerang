Public Class frmInventario

    Public dia As String = ""
    Public mes As String = ""
    Public año As String = ""
    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        dia = txtDia.Text
        mes = txtMes.Text
        año = txtAño.Text
        frmReporteVentas.Show()
    End Sub
End Class