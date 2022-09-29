Imports System.Runtime.InteropServices
Public Class Form1

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnMaxiMini.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaxiMini_Click(sender As Object, e As EventArgs) Handles btnMaxiMini.Click
        btnMaxiMini.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub panelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles panelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If panelMenu.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width - 20
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If panelMenu.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width + 20
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If panelMenu.Width = 220 Then
            tmOcultarMenu.Enabled = True
            lblMenu.Visible = False
            pbLogo.Visible = False

        ElseIf panelMenu.Width = 60 Then
            tmMostrarMenu.Enabled = True
            lblMenu.Visible = True
            pbLogo.Visible = True

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class
