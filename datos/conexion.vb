Imports System.Data.Sql
Imports System.Data.SqlClient
Module conexion
    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public nombreEmpleado As String = ""
    Public idEmpleado As String = ""
    Public fechaServidor As String = ""
    Public idVenta As String = ""
    Public dscDetalle As String = ""
    Public totalDetalle As String = "---"
    Public fechaTotalDetalle As String = ""
    Public cvhoy As Integer
    Public cvayer As Integer
    Public reportdia As String = ""
    Public reportmes As String = ""
    Public reportaño As String = ""

    Sub abrir()
        Try
            conexion = New SqlConnection(My.Settings.boomerang)
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error " + ex.ToString)
        End Try
    End Sub
    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select * from usuarios where users='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
                nombreEmpleado = respuesta.Item("nombre")
                idEmpleado = respuesta.Item("cod_user")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function contrasena(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("select passwords from usuarios where users='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("passwords")
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function consultarTipoUsuario(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("select nivel from usuarios where users='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("nivel")
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Public Sub fecha1()
        Try
            enunciado = New SqlCommand("select convert(date,getdate()) fecha", conexion)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                fechaServidor = respuesta.Item("fecha")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub mostrarTotal(ByVal codDetalleVenta As String)
        Try
            enunciado = New SqlCommand("execute _totalventa " & codDetalleVenta & "", conexion)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                dscDetalle = respuesta.Item("dsc")
                totalDetalle = respuesta.Item("total")
                fechaTotalDetalle = respuesta.Item("fecha")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox("Error...Selecciona primero la venta")
        End Try
    End Sub
    Public Sub graficoVenta()
        Try
            enunciado = New SqlCommand("execute _graficoventas1 '" & idEmpleado & "'", conexion)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                cvhoy = respuesta.Item("hoy")
                cvayer = respuesta.Item("ayer")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox("Error al cargar Grafico")
        End Try
    End Sub

End Module
