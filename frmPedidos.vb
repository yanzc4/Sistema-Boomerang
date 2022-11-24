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
        Dim da As New SqlDataAdapter("select * from ventas where cod_user='" & idEmpleado & "' and fecha=cast(getdate()as date) and cliente like '%" & txtBuscar.Text & "%' order by fecha desc", cn)
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
    Private Sub eliminarVenta()
        Dim eli As New SqlCommand
        eli.CommandType = CommandType.StoredProcedure
        eli.CommandText = "_eliminarventa"
        eli.Parameters.Add("@vcod", SqlDbType.Int).Value = TextBox1.Text.Trim
        eli.Connection = cn
        eli.ExecuteNonQuery()
        MsgBox("Venta Borrada")
    End Sub
    Private Sub frmPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fecha1()
        lblCod_user.Text = idEmpleado.ToString
        lblFecha.Text = fechaServidor.ToString
        listarVentas()
        graficoVenta()
        Me.gfcVentas.Series("venta_hoy_ayer").Points.AddXY("Ayer: " + cvayer.ToString, cvayer)
        Me.gfcVentas.Series("venta_hoy_ayer").Points.AddXY("Hoy: " + cvhoy.ToString, cvhoy)
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
        graficoVenta()
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Quieres Eliminar?", vbYesNo, "Información") = vbYes Then
            Try
                cn.Open()
                eliminarVenta()
            Catch ex As Exception
                MsgBox("Error: la venta tiene pedidos")
            Finally
                If Not IsDBNull(cn) Then cn.Close()
            End Try
            listarVentas()
            graficoVenta()
        Else
            MsgBox("Gracias")
        End If
    End Sub

    Private Sub ElContainer1_Click(sender As Object, e As EventArgs) Handles ElContainer1.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        listarVentas()
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