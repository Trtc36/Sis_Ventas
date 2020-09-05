'Librerias utilizadas para manejar los datos con Sql
Imports System.Data
Imports System.Data.SqlClient


Public Class Conexion
    'Establece la conexion con la base de datos, (buscar cadena en Proyecto>Propiedades de MENU>Configuración)
    Public conexion As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=Sis_Ventas_HGO;Integrated Security=True")

    'Variables para la consulta
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter 'Ejecucion del comando
    Public comando As SqlCommand 'Comando en si
    Public respuesta As SqlDataReader 'Lectura del comando
    Public dt As DataTable

    Public Function Conectar()
        Try
            conexion = New SqlConnection("Data Source=localhost;Initial Catalog=Sis_Ventas_HGO;Integrated Security=True") 'Conexion con el nombre de la cadena de conexion
            conexion.Open()
            MessageBox.Show("Conectado")
            Return True

        Catch ex As Exception
            MsgBox("Error de conexión")
            Return False
        End Try
    End Function
    Public Function Desconectar()
        Try
            If (conexion.State = ConnectionState.Open) Then
                conexion.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Sub Consulta(ByRef sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Function Insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub llenarDVG(ByVal sql As String, ByVal dvg As DataGridView)
        Try
            da = New SqlDataAdapter(sql, conexion)
            dt = New DataTable
            da.Fill(dt)
            dvg.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el DataGridView debido a " + ex.ToString)
        End Try
    End Sub

End Class
