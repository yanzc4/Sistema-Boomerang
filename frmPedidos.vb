Imports System.Data.SqlClient
Public Class frmPedidos
    Dim cn As New SqlConnection(My.Settings.boomerang)

    Sub nuevaVenta()
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "_crearventas"
        cmd.Parameters.Add("@ecod", SqlDbType.Char).Value = lblCod_user.Text.Trim
        cmd.Parameters.Add("@vfecha", SqlDbType.Date).Value = lblFecha.Text.Trim
        cmd.Parameters.Add("@vcliente", SqlDbType.VarChar).Value = txtCliente.Text.Trim
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        MsgBox("Venta Agregada")
    End Sub
    Sub listarVentas()
        cn.Open()
        Dim da As New SqlDataAdapter("execute _listarventas '" & idEmpleado & "'", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Ventas")
        dgvVentas.DataSource = ds.Tables("Ventas")
        cn.Close()
    End Sub
    Private Sub frmPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fecha1()
        lblCod_user.Text = idEmpleado.ToString
        lblFecha.Text = fechaServidor.ToString
        listarVentas()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        fecha1()
        lblCod_user.Text = idEmpleado.ToString
        lblFecha.Text = fechaServidor.ToString
        txtCliente.Clear()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            cn.Open()
            nuevaVenta()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Not IsDBNull(cn) Then cn.Close()
        End Try
        listarVentas()
    End Sub

    Private Sub dgvVentas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellEnter
        TextBox1.Text = dgvVentas.Item(0, e.RowIndex).Value
    End Sub

    Private Sub ElButton1_Click(sender As Object, e As EventArgs) Handles ElButton1.Click
        idVenta = TextBox1.Text
    End Sub
End Class