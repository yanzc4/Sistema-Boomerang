Imports System.Data.SqlClient
Imports Sistema_Boomerang.conexion
Imports System.Runtime.InteropServices
Public Class frmRegistraEmpleado
    Dim cn As New SqlConnection(My.Settings.boomerang)

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    'para redondear
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr
    End Function

    Function nuevousuario()
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
    End Function
    Function listarusuario()
        cn.Open()
        Dim da As New SqlDataAdapter("execute _listarusuarios", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Empleado")
        dgvEmpleado.DataSource = ds.Tables("Empleado")
        cn.Close()
    End Function

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub panelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles panelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub frmRegistraEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarusuario()
        'para redondear
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 20, 20))
    End Sub

    Private Sub ElContainer4_Click(sender As Object, e As EventArgs) Handles ElContainer4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

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