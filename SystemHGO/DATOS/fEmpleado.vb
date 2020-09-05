Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class fEmpleado
    Inherits Conexion
    Dim Cmd As New SqlCommand

    Public Function Mostrar() As DataTable
        Try
            Conectar()
            Cmd = New SqlCommand("Mostrar_Empleado")
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

    Public Function Insertar_Empleado(ByVal dts As CEmpleado) As Boolean
        Try
            Conectar()
            Cmd = New SqlCommand("Insertar_Empleado")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = conexion

            Cmd.Parameters.AddWithValue("@NoEmpleado", dts._noEmpleado)
            Cmd.Parameters.AddWithValue("@Nombre", dts._Nombre)
            Cmd.Parameters.AddWithValue("@ApellidoP", dts._ApellidoP)
            Cmd.Parameters.AddWithValue("@ApellidoM", dts._ApellidoM)
            Cmd.Parameters.AddWithValue("@CURP", dts._CURP)
            Cmd.Parameters.AddWithValue("@RFC", dts._RFC)
            Cmd.Parameters.AddWithValue("@Direccion", dts._Direccion)
            Cmd.Parameters.AddWithValue("@Colonia", dts._Colonia)
            Cmd.Parameters.AddWithValue("@Ciudad", dts._Ciudad)
            Cmd.Parameters.AddWithValue("@Estado", dts._Estado)
            Cmd.Parameters.AddWithValue("@CP", dts._CP)
            Cmd.Parameters.AddWithValue("@Telefono", dts._Telefono)
            Cmd.Parameters.AddWithValue("@Mail", dts._Mail)
            Cmd.Parameters.AddWithValue("@idPuesto", dts._idPuesto)

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

    Public Function Modificar_Empleado(ByVal dts As CEmpleado) As Boolean
        Try
            Conectar()
            Cmd = New SqlCommand("Modificar_Empleado")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = conexion

            Cmd.Parameters.AddWithValue("@ID_Empleado", dts._idEmpleado)
            Cmd.Parameters.AddWithValue("@NoEmpleado", dts._noEmpleado)
            Cmd.Parameters.AddWithValue("@Nombre", dts._Nombre)
            Cmd.Parameters.AddWithValue("@ApellidoP", dts._ApellidoP)
            Cmd.Parameters.AddWithValue("@ApellidoM", dts._ApellidoM)
            Cmd.Parameters.AddWithValue("@CURP", dts._CURP)
            Cmd.Parameters.AddWithValue("@RFC", dts._RFC)
            Cmd.Parameters.AddWithValue("@Direccion", dts._Direccion)
            Cmd.Parameters.AddWithValue("@Colonia", dts._Colonia)
            Cmd.Parameters.AddWithValue("@Ciudad", dts._Ciudad)
            Cmd.Parameters.AddWithValue("@Estado", dts._Estado)
            Cmd.Parameters.AddWithValue("@CP", dts._CP)
            Cmd.Parameters.AddWithValue("@Telefono", dts._Telefono)
            Cmd.Parameters.AddWithValue("@Mail", dts._Mail)
            Cmd.Parameters.AddWithValue("@idPuesto", dts._idPuesto)

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

    Public Function Eliminar_Empleado(ByVal dts As CEmpleado) As Boolean
        Try
            Conectar()
            Cmd = New SqlCommand("Eliminar_Empleado")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = conexion

            Cmd.Parameters.Add("@ID_Empleado", SqlDbType.Int).Value = dts._idEmpleado
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
