Imports System.Data.SqlClient
Public Class frmPedidos
    Dim cn As New SqlConnection(My.Settings.boomerang)
    Dim codventaedit, empleadocod, editarfechaventa, nombreclienteedit As String
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
    Private Sub editarVenta()
        Dim act As New SqlCommand
        act.CommandType = CommandType.StoredProcedure
        act.CommandText = "_modificarventa"
        act.Parameters.Add("@vcod", SqlDbType.Int).Value = lblCodigo.Text.Trim
        act.Parameters.Add("@ecod", SqlDbType.Char).Value = lblCod_user.Text.Trim
        act.Parameters.Add("@vfecha", SqlDbType.Date).Value = lblFecha.Text.Trim
        act.Parameters.Add("@vcliente", SqlDbType.VarChar).Value = txtCliente.Text.Trim
        act.Connection = cn
        act.ExecuteNonQuery()
        MsgBox("venta Modificada")
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
        btnGuardar.Visible = False
        btnRegistrar.Visible = True
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            cn.Open()
            editarVenta()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Not IsDBNull(cn) Then cn.Close()
        End Try
        listarVentas()
        btnRegistrar.Visible = True
        btnGuardar.Visible = False
        fecha1()
        lblCod_user.Text = idEmpleado.ToString
        lblFecha.Text = fechaServidor.ToString
        txtCliente.Clear()
    End Sub

    Private Sub dgvVentas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellEnter

        Try
            TextBox1.Text = dgvVentas.Item(0, e.RowIndex).Value
            codventaedit = dgvVentas.Item(0, e.RowIndex).Value
            empleadocod = dgvVentas.Item(1, e.RowIndex).Value
            editarfechaventa = dgvVentas.Item(2, e.RowIndex).Value
            nombreclienteedit = dgvVentas.Item(3, e.RowIndex).Value
        Catch ex As Exception
            MsgBox("Error Campo Vacio --> Selecciona otro campo")
        End Try
    End Sub

    Private Sub ElButton1_Click(sender As Object, e As EventArgs) Handles ElButton1.Click
        idVenta = TextBox1.Text
    End Sub

    Private Sub ElButton2_Click(sender As Object, e As EventArgs) Handles ElButton2.Click
        lblCod_user.Text = empleadocod.ToString
        lblFecha.Text = editarfechaventa.ToString
        txtCliente.Text = nombreclienteedit.ToString
        lblCodigo.Text = codventaedit.ToString
        btnGuardar.Visible = True
        btnRegistrar.Visible = False
    End Sub
End Class