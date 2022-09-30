Imports System.Data.SqlClient
Imports Sistema_Boomerang.conexionDAO
Public Class Fusuario
    Inherits conexion
    Public Function validarusuario(ByVal dts As conexionDAO) As DataTable
        conectado()
        cmd = New SqlCommand("_iniciosesion")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnn

        cmd.Parameters.AddWithValue("@users", dts._users)
        cmd.Parameters.AddWithValue("@passwords", dts._passwords)

        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Else
            Return Nothing
        End If
    End Function

End Class
