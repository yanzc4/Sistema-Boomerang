Public Class frmAjustes
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.panelContenedor1.Controls.Count > 0 Then
            Me.panelContenedor1.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.panelContenedor1.Controls.Add(fh)
        Me.panelContenedor1.Tag = fh
        fh.Show()

    End Sub
    Private Sub btnNuevoEmp_Click(sender As Object, e As EventArgs) Handles btnNuevoEmp.Click
        AbrirFormEnPanel(frmRegistraEmpleado)
        'frmRegistraEmpleado.ShowDialog()
    End Sub

    Private Sub btnNuevoCate_Click(sender As Object, e As EventArgs) Handles btnNuevoCate.Click
        AbrirFormEnPanel(frmPlatos)
    End Sub

End Class