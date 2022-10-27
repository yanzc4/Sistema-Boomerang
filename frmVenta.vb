Imports System.Data.SqlClient
Public Class frmVenta
    Private Sub Poblar()
        Dim da As New SqlDataAdapter("select p.id CODIGO, p.f_plato IMAGEN, p.nombre MENU, c.nombre CATEGORIA, p.precio PRECIO from platos p join categoria_p c on p.id_categoria=c.id_categoria where p.nombre like'%" & txtBuscar.Text & "%'", conexion.conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            dgvProductos.DataSource = ds.Tables(0)
        Else
            dgvProductos.DataSource = Nothing
        End If
    End Sub
    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Poblar()
    End Sub
End Class