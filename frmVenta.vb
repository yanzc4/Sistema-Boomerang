Imports System.Data.SqlClient
Public Class frmVenta
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Public idPlato As String
    Public precio As String
    Public descPlato As String
    Private Sub Poblar()
        da = New SqlDataAdapter("select p.id COD, p.f_plato IMAGEN, p.nombre MENU, p.precio PRECIO from platos p where p.nombre like'%" & txtBuscar.Text & "%'", conexion.conexion)
        ds = New DataSet
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Poblar()
    End Sub

    Private Sub dgvProductos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellEnter
        idPlato = dgvProductos.Item(0, e.RowIndex).Value
        precio = dgvProductos.Item(3, e.RowIndex).Value
        descPlato = dgvProductos.Item(2, e.RowIndex).Value
    End Sub

    Private Sub ElButton1_Click(sender As Object, e As EventArgs) Handles ElButton1.Click
        TextBox1.Text = idPlato.ToString
        TextBox2.Text = precio.ToString
        TextBox3.Text = descPlato.ToString
    End Sub
End Class