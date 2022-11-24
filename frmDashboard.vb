Imports System.Data.SqlClient

Public Class frmDashboard
    Dim cn As New SqlConnection(My.Settings.boomerang)
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BoomerangDataSet3._ventasempleado' Puede moverla o quitarla según sea necesario.
        Me._ventasempleadoTableAdapter.Fill(Me.BoomerangDataSet3._ventasempleado)
        'TODO: esta línea de código carga datos en la tabla 'BoomerangDataSet2._topcategorias' Puede moverla o quitarla según sea necesario.
        Me._topcategoriasTableAdapter.Fill(Me.BoomerangDataSet2._topcategorias)
        'TODO: esta línea de código carga datos en la tabla 'BoomerangDataSet1._topbebidas' Puede moverla o quitarla según sea necesario.
        Me._topbebidasTableAdapter.Fill(Me.BoomerangDataSet1._topbebidas)
        'TODO: esta línea de código carga datos en la tabla 'BoomerangDataSet._ventasmes' Puede moverla o quitarla según sea necesario.
        Me._ventasmesTableAdapter.Fill(Me.BoomerangDataSet._ventasmes)
        datosVentasG()
        lblTotalVentas.Text = totalgeneral.ToString
        lblCantidadVentas.Text = cantventg.ToString
        lblDescuento.Text = totaldecg.ToString


    End Sub
End Class