Imports System.Data.SqlClient
Public Class frmVenta
    Dim cn As New SqlConnection(My.Settings.boomerang)
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Public idPlato As String = ""
    Public precio As String = ""
    Public descPlato As String = "0.00"
    Private Sub Poblar()
        da = New SqlDataAdapter("select p.id COD, p.f_plato IMAGEN, p.nombre MENU, p.precio PRECIO from platos p where p.nombre like'%" & txtBuscar.Text & "%'", cn)
        ds = New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            dgvProductos.DataSource = ds.Tables(0)
        Else
            dgvProductos.DataSource = Nothing
        End If
    End Sub
    Private Sub nuevoDetalle()
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "_creardetalleventa"
        cmd.Parameters.Add("@vcod", SqlDbType.Int).Value = lblvId.Text.Trim
        cmd.Parameters.Add("@pcod", SqlDbType.Int).Value = lblPlatoid.Text.Trim
        cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = txtCantidad.Text.Trim
        cmd.Parameters.Add("@pprecio", SqlDbType.Decimal).Value = lblPrecio.Text.Trim
        cmd.Parameters.Add("@descuento", SqlDbType.Decimal).Value = txtDescuento.Text.Trim
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        MsgBox("Plato Agregado")
    End Sub
    Sub listarDetalle()
        cn.Open()
        Dim da As New SqlDataAdapter("execute _listardetalleventa '" & idVenta & "'", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Ventas")
        dgvDetalle.DataSource = ds.Tables("Ventas")
        cn.Close()
    End Sub
    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Poblar()
        listarDetalle()
        lblID_venta.Text = idVenta.ToString
        mostrarTotal(idVenta)
        lbldsc.Text = dscDetalle.ToString
        lblTotal.Text = totalDetalle.ToString
        lblFecha.Text = fechaTotalDetalle.ToString
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Poblar()
    End Sub

    Private Sub dgvProductos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellEnter
        Try
            idPlato = dgvProductos.Item(0, e.RowIndex).Value
            precio = dgvProductos.Item(3, e.RowIndex).Value
        Catch ex As Exception
            MsgBox("Error Campo Vacio --> Selecciona otro campo")
        End Try
    End Sub

    Private Sub ElButton1_Click(sender As Object, e As EventArgs) Handles ElButton1.Click
        lblPlatoid.Text = idPlato.ToString
        lblPrecio.Text = precio.ToString
        txtDescuento.Text = descPlato.ToString
        txtCantidad.Text = "1"
        Dim idve As String
        idve = lblID_venta.Text
        lblvId.Text = idve
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            cn.Open()
            nuevoDetalle()
        Catch ex As Exception
            MsgBox("Selecciona primero la venta")
        Finally
            If Not IsDBNull(cn) Then cn.Close()
        End Try
        mostrarTotal(idVenta)
        lbldsc.Text = dscDetalle.ToString
        lblTotal.Text = totalDetalle.ToString
        lblFecha.Text = fechaTotalDetalle.ToString
        listarDetalle()
    End Sub
End Class