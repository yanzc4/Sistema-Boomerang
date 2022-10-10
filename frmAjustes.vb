Public Class frmAjustes
    Private Sub btnNuevoEmp_Click(sender As Object, e As EventArgs) Handles btnNuevoEmp.Click
        frmRegistraEmpleado.ShowDialog()
    End Sub

    Private Sub btnNuevoCate_Click(sender As Object, e As EventArgs) Handles btnNuevoCate.Click
        frmCategoria.ShowDialog()
    End Sub
End Class