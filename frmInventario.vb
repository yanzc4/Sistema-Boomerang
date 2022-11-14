Public Class frmInventario
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.panelContenedor.Controls.Count > 0 Then
            Me.panelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.panelContenedor.Controls.Add(fh)
        Me.panelContenedor.Tag = fh
        fh.Show()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        reportdia = txtDia.Text
        reportmes = txtMes.Text
        reportaño = txtAño.Text
        AbrirFormEnPanel(New frmReporteVentas)
    End Sub

    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFormEnPanel(New frmReporteVentas)
    End Sub
End Class