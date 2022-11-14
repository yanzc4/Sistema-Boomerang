
Public Class frmPrincipal

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
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmCarga.Close()
        frmLogin.Close()
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnMaxiMini.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMaxiMini_Click(sender As Object, e As EventArgs) Handles btnMaxiMini.Click
        btnMaxiMini.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEmpleado.Text = nombreEmpleado.ToString
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormEnPanel(New frmPedidos)
        pVentas.Visible = True
        pReporte.Visible = False
        pAjustes.Visible = False
        pDashboard.Visible = False
        pPedidos.Visible = False
    End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        AbrirFormEnPanel(New frmVenta)
        pPedidos.Visible = True
        pVentas.Visible = False
        pReporte.Visible = False
        pAjustes.Visible = False
        pDashboard.Visible = False
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        AbrirFormEnPanel(New frmDashboard)
        pDashboard.Visible = True
        pPedidos.Visible = False
        pVentas.Visible = False
        pReporte.Visible = False
        pAjustes.Visible = False
    End Sub

    Private Sub btnAjustes_Click(sender As Object, e As EventArgs) Handles btnAjustes.Click
        AbrirFormEnPanel(New frmAjustes)
        pAjustes.Visible = True
        pDashboard.Visible = False
        pPedidos.Visible = False
        pVentas.Visible = False
        pReporte.Visible = False
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        AbrirFormEnPanel(New frmInventario)
        pReporte.Visible = True
        pAjustes.Visible = False
        pDashboard.Visible = False
        pPedidos.Visible = False
        pVentas.Visible = False
    End Sub
End Class