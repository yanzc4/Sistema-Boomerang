Imports System.Data.SqlClient
Imports System.IO
Public Class frmPlatos
    Dim cn As New SqlConnection(My.Settings.boomerang)
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
        MsgBox("Plato Agregad")
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
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            cn.Open()
            cargarcombo()
            agregarplato()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Not IsDBNull(cn) Then cn.Close()
        End Try
        listarplatos()
    End Sub

    Private Sub btnNcategoria_Click(sender As Object, e As EventArgs) Handles btnNcategoria.Click
        frmCategoria.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cargarcombo()
    End Sub
End Class