﻿Imports System.Data.Sql
Imports System.Data.SqlClient
Module conexion
    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public nombreEmpleado As String = ""
    Public idEmpleado As String = ""
    Public fechaServidor As String = ""
    Public idVenta As String = ""

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

End Module
