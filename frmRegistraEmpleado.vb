Imports System.Data.SqlClient
Imports Sistema_Boomerang.conexion
Imports System.Runtime.InteropServices
Public Class frmRegistraEmpleado
    Dim cn As New SqlConnection(My.Settings.boomerang)
    Dim codigousuario2, nombreusuario2, apellidousuario2, celularusuario2, userusuario2, contrausuario2, nivelusuario2 As String

    'para redondear
    '<DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    'Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr
    'End Function

    Private Sub nuevousuario()
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "_agregarusuario"
        cmd.Parameters.Add("@xcod", SqlDbType.Char).Value = txtCodN.Text.Trim
        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim
        cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = txtApellidos.Text.Trim
        cmd.Parameters.Add("@celular", SqlDbType.VarChar).Value = txtCelular.Text.Trim
        cmd.Parameters.Add("@users", SqlDbType.VarChar).Value = txtUsuarioN.Text.Trim
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassN.Text.Trim
        cmd.Parameters.Add("@nivel", SqlDbType.VarChar).Value = txtNivel.Text.Trim
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        MsgBox("Usuario Agregado")
    End Sub
    Private Sub listarusuario()
        cn.Open()
        Dim da As New SqlDataAdapter("execute _listarusuarios", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Empleado")
        dgvEmpleado.DataSource = ds.Tables("Empleado")
        cn.Close()
    End Sub
    Private Sub modificarUsuario()
        Dim modi As New SqlCommand
        modi.CommandType = CommandType.StoredProcedure
        modi.CommandText = "_modificarusuario"
        modi.Parameters.Add("@xcod", SqlDbType.Char).Value = txtCodN.Text.Trim
        modi.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim
        modi.Parameters.Add("@apellido", SqlDbType.VarChar).Value = txtApellidos.Text.Trim
        modi.Parameters.Add("@celular", SqlDbType.VarChar).Value = txtCelular.Text.Trim
        modi.Parameters.Add("@users", SqlDbType.VarChar).Value = txtUsuarioN.Text.Trim
        modi.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassN.Text.Trim
        modi.Parameters.Add("@nivel", SqlDbType.VarChar).Value = txtNivel.Text.Trim
        modi.Connection = cn
        modi.ExecuteNonQuery()
        MsgBox("Usuario Modificado")
    End Sub

    'consultar para la tabla usuario ponerla en cascada
    Private Sub eliminarusuario()
        Dim eli As New SqlCommand
        eli.CommandType = CommandType.StoredProcedure
        eli.CommandText = "_eliminarusuario"
        eli.Parameters.Add("@ucod", SqlDbType.Char).Value = TextBox1.Text.Trim
        eli.Connection = cn
        eli.ExecuteNonQuery()
        MsgBox("Usuario Borrado")
    End Sub

    Private Sub dgvEmpleado_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.CellEnter
        Try
            TextBox1.Text = dgvEmpleado.Item(0, e.RowIndex).Value
            codigousuario2 = dgvEmpleado.Item(0, e.RowIndex).Value
            nombreusuario2 = dgvEmpleado.Item(1, e.RowIndex).Value
            apellidousuario2 = dgvEmpleado.Item(2, e.RowIndex).Value
            celularusuario2 = dgvEmpleado.Item(3, e.RowIndex).Value
            userusuario2 = dgvEmpleado.Item(4, e.RowIndex).Value
            contrausuario2 = dgvEmpleado.Item(5, e.RowIndex).Value
            nivelusuario2 = dgvEmpleado.Item(6, e.RowIndex).Value
        Catch ex As Exception
            MsgBox("Campo Vacio")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtCodN.Text = codigousuario2.ToString
        txtNombre.Text = nombreusuario2.ToString
        txtApellidos.Text = apellidousuario2.ToString
        txtCelular.Text = celularusuario2.ToString
        txtUsuarioN.Text = userusuario2.ToString
        txtPassN.Text = contrausuario2.ToString
        txtNivel.Text = nivelusuario2.ToString
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            cn.Open()
            modificarUsuario()
        Catch ex As Exception
            MsgBox("Error seleccione un Rol")
        Finally
            If Not IsDBNull(cn) Then cn.Close()
        End Try
        listarusuario()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Quieres Eliminar?", vbYesNo, "Información") = vbYes Then
            Try
                cn.Open()
                eliminarusuario()
            Catch ex As Exception
                'consultar para hacer el delete en cascada
                MsgBox("Error: para quitarle el acceso solo cambie la contraseña")
            Finally
                If Not IsDBNull(cn) Then cn.Close()
            End Try
            listarusuario()
        Else
            MsgBox("Gracias")
        End If
    End Sub

    Private Sub frmRegistraEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarusuario()
        'para redondear
        'Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 20, 20))
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        rdbAdministrador.Checked = False
        rbtEmpleado.Checked = False
        txtNivel.Clear()
        txtCodN.Clear()
        txtNombre.Clear()
        txtApellidos.Clear()
        txtCelular.Clear()
        txtUsuarioN.Clear()
        txtPassN.Clear()
    End Sub

    Private Sub rdbAdministrador_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAdministrador.CheckedChanged
        txtNivel.Text = "Administrador"
    End Sub

    Private Sub rbtEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEmpleado.CheckedChanged
        txtNivel.Text = "Empleado"
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            cn.Open()
            nuevousuario()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Not IsDBNull(cn) Then cn.Close()
        End Try
        listarusuario()
    End Sub
End Class