Public Class frmLogIn
    Public contador As Integer = 0
    Dim permiso As Boolean

    Dim conexion As Conexion = New Conexion()
    Dim fu As New fLogIn
    Dim eu As New CLogIn


    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        contador = contador + 1
        Try
            If (txtPassword.Text <> "") And (txtUsuario.Text <> "") Then
                Dim dt As New DataTable

                eu._usuario = txtUsuario.Text
                eu._password = txtPassword.Text
                dt = fu.validar_LogIn(eu)

                If dt.Rows.Count() > 0 Then
                    tmrEntrar.Start()

                    Dim Rol As String
                    Dim TipoNivel As String

                    Rol = dt.Rows(0)("Rol")
                    TipoNivel = dt.Rows(0)("TipoPermiso")
                    If (Rol = "ADMON") And (TipoNivel = "TOTAL") Then
                        permiso = True
                    ElseIf (Rol = "OPERATIVO") And (TipoNivel = "VENTAS") Then
                        permiso = False
                    End If
                Else
                    MsgBox("Estimado usuario te quedan " & (3 - contador) & " intentos")
                    If (contador >= 3) Then
                        Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class