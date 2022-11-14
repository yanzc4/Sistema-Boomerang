Imports System.Data.SqlClient
Imports System.IO
Public Class frmPlatos
    Dim cn As New SqlConnection(My.Settings.boomerang)
    Dim imagenp As Image
    Dim idplato1 As String
    Dim nombreplato1 As String
    Dim precioplato2 As String
    Sub listarplatos()
        cn.Open()
        Dim da As New SqlDataAdapter("execute _listarplatos", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Categoria")
        dgvPlatos.DataSource = ds.Tables("Categoria")
        cn.Close()
    End Sub
    Sub cargarcombo()
        Dim tabla As New DataTable
        Dim sql As String = "select id_categoria, nombre from categoria_p"
        Dim adp As New SqlDataAdapter(sql, cn)
        adp.Fill(tabla)
        ComboBox1.DataSource = tabla
        ComboBox1.DisplayMember = "nombre"
        ComboBox1.ValueMember = "id_categoria"
    End Sub
    Sub agregarplato()
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "_agregarplato"
        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim

        'para guardar imagenes
        Dim ms As New MemoryStream
        Me.imgPlato.Image.Save(ms, Me.imgPlato.Image.RawFormat)
        cmd.Parameters.Add("@f_plato", SqlDbType.Image).Value = ms.GetBuffer

        cmd.Parameters.Add("@id_cate", SqlDbType.Int).Value = txtCategoria.Text.Trim
        cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = txtPrecio.Text.Trim
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        MsgBox("Plato Agregado")
    End Sub
    Private Sub modificarPlato()
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "_modificarplato"
        cmd.Parameters.Add("@pcod", SqlDbType.Int).Value = lblIdPlato.Text.Trim
        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim

        'para guardar imagenes
        Dim mss As New MemoryStream
        Me.imgPlato.Image.Save(mss, Me.imgPlato.Image.RawFormat)
        cmd.Parameters.Add("@f_plato", SqlDbType.Image).Value = mss.GetBuffer

        cmd.Parameters.Add("@id_cate", SqlDbType.Int).Value = txtCategoria.Text.Trim
        cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = txtPrecio.Text.Trim
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        MsgBox("Plato Modificado")
    End Sub
    Private Sub eliminarPlato()
        Dim eli As New SqlCommand
        eli.CommandType = CommandType.StoredProcedure
        eli.CommandText = "_eliminarplato"
        eli.Parameters.Add("@pcod", SqlDbType.Int).Value = TextBox1.Text.Trim
        eli.Connection = cn
        eli.ExecuteNonQuery()
        MsgBox("Plato Borrado")
    End Sub
    Private Sub frmPlatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarplatos()
        cargarcombo()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        OpenFileDialog1.Filter = "Formato JPG|*.jpg|Formato PNG|*.png|Formato bitmaps|*.bmp"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.imgPlato.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        imgPlato.Image = Nothing
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.ValueMember.ToString <> "" Then
            Dim sql As String = "select * from categoria_p where id_categoria=" + ComboBox1.SelectedValue.ToString + ""
            Dim adapter As New SqlDataAdapter(sql, cn)
            Dim dt As New DataTable
            adapter.Fill(dt)
            For Each row As DataRow In dt.Rows
                txtCategoria.Text = row("id_categoria").ToString
            Next
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCategoria.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
        imgPlato.Image = Nothing
        lblIdPlato.Text = ""
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            cn.Open()
            agregarplato()
        Catch ex As Exception
            MsgBox("Seleccione una categoria")
        Finally
            If Not IsDBNull(cn) Then cn.Close()
        End Try
        listarplatos()
        cargarcombo()
    End Sub

    Private Sub btnNcategoria_Click(sender As Object, e As EventArgs) Handles btnNcategoria.Click
        frmCategoria.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cargarcombo()
    End Sub

    Private Sub ElButton1_Click(sender As Object, e As EventArgs) Handles ElButton1.Click
        lblIdPlato.Text = idplato1.ToString
        imgPlato.Image = imagenp
        txtNombre.Text = nombreplato1.ToString
        txtPrecio.Text = precioplato2.ToString
        MsgBox("No olvides seleccionar la categoria")
    End Sub

    Private Sub dgvPlatos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlatos.CellEnter
        Try
            TextBox1.Text = dgvPlatos.Item(0, e.RowIndex).Value
            imagenp = dgvPlatos.Item(1, e.RowIndex).FormattedValue
            idplato1 = dgvPlatos.Item(0, e.RowIndex).Value
            nombreplato1 = dgvPlatos.Item(2, e.RowIndex).Value
            precioplato2 = dgvPlatos.Item(4, e.RowIndex).Value
        Catch ex As Exception
            MsgBox("Campo Vacio")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            cn.Open()
            modificarPlato()
        Catch ex As Exception
            MsgBox("Selecciona categoria")
        Finally
            If Not IsDBNull(cn) Then cn.Close()
        End Try
        listarplatos()
        cargarcombo()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If MsgBox("¿Quieres Eliminar?", vbYesNo, "Información") = vbYes Then
            Try
                cn.Open()
                eliminarPlato()
            Catch ex As Exception
                MsgBox("Error: el plato esta registrado en ventas")
            Finally
                If Not IsDBNull(cn) Then cn.Close()
            End Try
            listarplatos()
        Else
            MsgBox("Gracias")
        End If
    End Sub
End Class