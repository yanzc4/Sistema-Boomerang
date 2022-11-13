Imports System.IO
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class frmCategoria

    Dim cn As New SqlConnection(My.Settings.boomerang)
    Dim nombrecate1 As String = ""
    Dim idCategoria1 As String = ""

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

    Private Sub crearcategoria()
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "_agregarcategoria"
        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        MsgBox("Categoria Agregada")
    End Sub
    Private Sub listarcategoria()
        cn.Open()
        Dim da As New SqlDataAdapter("execute _listarcategoria", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Categoria")
        dgvCategoria.DataSource = ds.Tables("Categoria")
        cn.Close()
    End Sub
    Private Sub modificarcategoria()
        Dim modi As New SqlCommand
        modi.CommandType = CommandType.StoredProcedure
        modi.CommandText = "_modificarcategoria"
        modi.Parameters.Add("@ccod", SqlDbType.Int).Value = lblIdCategoriar.Text.Trim
        modi.Parameters.Add("@cnombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim
        modi.Connection = cn
        modi.ExecuteNonQuery()
        MsgBox("Categoria Agregada")
    End Sub
    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarcategoria()
        'para redondear
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 20, 20))
    End Sub

    Private Sub panelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles panelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Clear()
    End Sub


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            cn.Open()
            crearcategoria()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Not IsDBNull(cn) Then cn.Close()
        End Try
        listarcategoria()
    End Sub

    Private Sub dgvCategoria_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategoria.CellEnter
        Try
            idCategoria1 = dgvCategoria.Item(0, e.RowIndex).Value
            nombrecate1 = dgvCategoria.Item(1, e.RowIndex).Value
        Catch ex As Exception
            MsgBox("Campo Vacio")
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        lblIdCategoriar.Text = idCategoria1.ToString
        txtNombre.Text = nombrecate1.ToString
        btnRegistrar.Visible = False
        btnAceptar.Visible = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            cn.Open()
            modificarcategoria()
        Catch ex As Exception
            MsgBox("Error..Intente denuevo")
        Finally
            If Not IsDBNull(cn) Then cn.Close()
        End Try
        btnAceptar.Visible = False
        btnRegistrar.Visible = True
        listarcategoria()
        txtNombre.Clear()
        lblIdCategoriar.Text = ""
    End Sub
End Class