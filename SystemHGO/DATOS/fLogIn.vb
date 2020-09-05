Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class fLogIn
    Inherits Conexion

    Public Function validar_LogIn(ByVal dts As CLogIn) As DataTable
        Conectar()

        comando = New SqlCommand("Valida_LogIn") 'Nombre del procedimiento de sql server
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = conexion
        comando.Parameters.AddWithValue("@UserName", dts._usuario)
        comando.Parameters.AddWithValue("@Password", dts._password)

        If comando.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(comando)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Else
            Return Nothing
        End If
    End Function

End Class
