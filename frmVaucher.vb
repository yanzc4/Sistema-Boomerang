Imports Sistema_Boomerang.boomerangDataSet
Imports System.Runtime.InteropServices
Public Class frmVaucher
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub frmVaucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me._vaucherTableAdapter.Fill(Me.boomerangDataSet._vaucher, idVenta)
        Catch ex As Exception
            MsgBox("seleccione usuario")
        End Try

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub panelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles panelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class