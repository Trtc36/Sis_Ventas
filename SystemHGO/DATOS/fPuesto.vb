Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class fPuesto
    Inherits Conexion
    Dim Cmd As New SqlCommand

    Public Function Mostrar() As DataTable
        Try
            Conectar()
            Cmd = New SqlCommand("Mostrar_Puesto")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = conexion

            If Cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(Cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Insertar_Puesto(ByVal dts As construc_Puesto) As Boolean
        Try
            Conectar()
            Cmd = New SqlCommand("Insertar_Puesto")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = conexion

            Cmd.Parameters.AddWithValue("@NoPuesto", dts._NoPuesto)
            Cmd.Parameters.AddWithValue("@Nombre", dts._Nombre)
            Cmd.Parameters.AddWithValue("@Descripcion", dts._Descripcion)
            

            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Modificar_Puesto(ByVal dts As construc_Puesto) As Boolean
        Try
            Conectar()
            Cmd = New SqlCommand("Modificar_Puesto")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = conexion

            Cmd.Parameters.AddWithValue("@ID_Puesto", dts._idPuesto)
            Cmd.Parameters.AddWithValue("@NoEmpleado", dts._NoPuesto)
            Cmd.Parameters.AddWithValue("@Nombre", dts._Nombre)
            Cmd.Parameters.AddWithValue("@ApellidoP", dts._Descripcion)


            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Eliminar_Puesto(ByVal dts As construc_Puesto) As Boolean
        Try
            Conectar()
            Cmd = New SqlCommand("Eliminar_Puesto")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = conexion

            Cmd.Parameters.Add("@ID_Puesto", SqlDbType.Int).Value = dts._idPuesto
            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
End Class
