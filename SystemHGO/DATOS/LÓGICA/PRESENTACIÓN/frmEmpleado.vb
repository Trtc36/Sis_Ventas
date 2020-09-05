Public Class frmEmpleado

    Private dt As New DataTable


    Private Sub Mostrar()
        Try
            Dim funcion As New fEmpleado
            dt = funcion.Mostrar
            dvgEmpleado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dvgEmpleado.DataSource = dt
                txtDato.Enabled = True
                dvgEmpleado.ColumnHeadersVisible = True
                llbInexistente.Visible = False
            Else
                dvgEmpleado.DataSource = Nothing
                txtDato.Enabled = False
                dvgEmpleado.ColumnHeadersVisible = False
                llbInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnModificar.Enabled = False
        btnSalir.Enabled = True
        btnEliminar.Enabled = False
        btnBuscar.Enabled = True

        Buscar()
    End Sub

    Private Sub Buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cmbCampo.Text & " like '" & txtDato.Text & "%'"
            If dv.Count <> 0 Then
                llbInexistente.Visible = False
                dvgEmpleado.DataSource = dv
                Ocultar_Columnas()
            Else
                llbInexistente.Visible = True
                dvgEmpleado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ocultar_Columnas()
        dvgEmpleado.Columns(1).Visible = False
        dvgEmpleado.Columns(5).Visible = False
        dvgEmpleado.Columns(8).Visible = False
        dvgEmpleado.Columns(9).Visible = False
        dvgEmpleado.Columns(10).Visible = False
        dvgEmpleado.Columns(11).Visible = False
        dvgEmpleado.Columns(12).Visible = False
        dvgEmpleado.Columns(13).Visible = False
        dvgEmpleado.Columns(14).Visible = False
        dvgEmpleado.Columns(15).Visible = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Mostrar()
    End Sub



    Private Sub txtNombreEmpleado_Validating(sender As Object, e As EventArgs) Handles txtNombreEmpleado.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erpErrorIcono.SetError(sender, "")
        Else
            Me.erpErrorIcono.SetError(sender, "Ingresa el nombre del empleado, Dato obligatorio")
        End If
    End Sub

    Private Sub txtApellidoP_Validating(sender As Object, e As EventArgs) Handles txtApellidoP.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erpErrorIcono.SetError(sender, "")
        Else
            Me.erpErrorIcono.SetError(sender, "Ingresa el apellido paterno del empleado, Dato obligatorio")
        End If
    End Sub

    Private Sub txtApellidoM_Validating(sender As Object, e As EventArgs) Handles txtApellidoM.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erpErrorIcono.SetError(sender, "")
        Else
            Me.erpErrorIcono.SetError(sender, "Ingresa el apellido materno del empleado, Dato obligatorio")
        End If
    End Sub

    Private Sub txtRFC_Validating(sender As Object, e As EventArgs) Handles txtRFC.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erpErrorIcono.SetError(sender, "")
        Else
            Me.erpErrorIcono.SetError(sender, "Ingresa el RFC del empleado, Dato obligatorio")
        End If
    End Sub

    Private Sub txtCURP_Validating(sender As Object, e As EventArgs) Handles txtCURP.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erpErrorIcono.SetError(sender, "")
        Else
            Me.erpErrorIcono.SetError(sender, "Ingresa el CURP del empleado, Dato obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As EventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erpErrorIcono.SetError(sender, "")
        Else
            Me.erpErrorIcono.SetError(sender, "Ingresa la direccion(Calle y número) del empleado, Dato obligatorio")
        End If
    End Sub

    Private Sub txtCP_LostFocus(sender As Object, e As EventArgs) Handles txtCP.LostFocus
        Codigo()
    End Sub

    Private Sub txtCP_Validating(sender As Object, e As EventArgs) Handles txtCP.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erpErrorIcono.SetError(sender, "")
        Else
            Me.erpErrorIcono.SetError(sender, "Ingresa el código postal del empleado, Dato obligatorio")
        End If
    End Sub

    Private Sub cmbColonia_Validating(sender As Object, e As EventArgs) Handles cmbColonia.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.erpErrorIcono.SetError(sender, "")
        Else
            Me.erpErrorIcono.SetError(sender, "Ingresa la colonia del empleado, Dato obligatorio")
        End If
    End Sub

    Private Sub txtCiudad_Validating(sender As Object, e As EventArgs) Handles txtCiudad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erpErrorIcono.SetError(sender, "")
        Else
            Me.erpErrorIcono.SetError(sender, "Ingresa la ciudad del empleado, Dato obligatorio")
        End If
    End Sub

    Private Sub txtEstado_Validating(sender As Object, e As EventArgs) Handles txtEstado.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erpErrorIcono.SetError(sender, "")
        Else
            Me.erpErrorIcono.SetError(sender, "Ingresa el estado del empleado, Dato obligatorio")
        End If
    End Sub
    Private Sub cmbPuesto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.erpErrorIcono.SetError(sender, "")
        Else
            Me.erpErrorIcono.SetError(sender, "Ingresa el puesto del empleado, Dato obligatorio")
        End If
    End Sub
    Public Sub Limpiar()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        txtIDEmpleado.Text = ""
        txtNombreEmpleado.Text = ""
        txtApellidoP.Text = ""
        txtApellidoM.Text = ""
        txtCURP.Text = ""
        txtRFC.Text = ""
        cmbPuesto.Text = ""
        txtDireccion.Text = ""
        txtCP.Text = ""
        cmbColonia.Text = ""
        txtCiudad.Text = ""
        txtEstado.Text = ""
        txtTelefono.Text = ""
        txtMail.Text = ""
    End Sub




    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
        Activar()
        btnNuevo.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombreEmpleado.Text <> "" And txtApellidoP.Text <> "" And txtApellidoM.Text <> "" And txtRFC.Text <> "" And txtCURP.Text <> "" And txtDireccion.Text <> "" And cmbColonia.Text <> "" And txtEstado.Text <> "" And txtCiudad.Text <> "" And cmbPuesto.Text <> "" And txtCP.Text <> "" Then
            Try
                Dim dts As New CEmpleado
                Dim func As New fEmpleado

                dts._noEmpleado = txtIDEmpleado.Text
                dts._Nombre = txtNombreEmpleado.Text
                dts._ApellidoP = txtApellidoP.Text
                dts._ApellidoM = txtApellidoM.Text
                dts._CURP = txtCURP.Text
                dts._RFC = txtRFC.Text
                dts._Direccion = txtDireccion.Text
                dts._CP = txtCP.Text
                dts._Colonia = cmbColonia.Text
                dts._Ciudad = txtCiudad.Text
                dts._Estado = txtEstado.Text
                dts._idPuesto = cmbPuesto.Text
                dts._Telefono = txtTelefono.Text
                dts._Mail = txtMail.Text

                If func.Insertar_Empleado(dts) Then
                    MessageBox.Show("Empleado registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Mostrar()
                    Limpiar()
                Else
                    MessageBox.Show("Empleado no registrado, intente de nuevo", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Mostrar()
                    Limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan datos por ingresar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dvgEmpleado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgEmpleado.CellClick
        txtConsecutivo.Text = dvgEmpleado.SelectedCells.Item(1).Value
        txtIDEmpleado.Text = dvgEmpleado.SelectedCells.Item(2).Value
        txtNombreEmpleado.Text = dvgEmpleado.SelectedCells.Item(3).Value
        txtApellidoP.Text = dvgEmpleado.SelectedCells.Item(4).Value
        txtApellidoM.Text = dvgEmpleado.SelectedCells.Item(5).Value
        txtCURP.Text = dvgEmpleado.SelectedCells.Item(6).Value
        txtRFC.Text = dvgEmpleado.SelectedCells.Item(7).Value
        txtDireccion.Text = dvgEmpleado.SelectedCells.Item(8).Value
        cmbColonia.Text = dvgEmpleado.SelectedCells.Item(9).Value
        txtCiudad.Text = dvgEmpleado.SelectedCells.Item(10).Value
        txtEstado.Text = dvgEmpleado.SelectedCells.Item(11).Value
        txtCP.Text = dvgEmpleado.SelectedCells.Item(12).Value
        txtTelefono.Text = dvgEmpleado.SelectedCells.Item(13).Value
        txtMail.Text = dvgEmpleado.SelectedCells.Item(14).Value
        cmbPuesto.Text = dvgEmpleado.SelectedCells.Item(15).Value
        Activar()
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        btnEliminar.Enabled = True
    End Sub



    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea modificar el registro", "Modificando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtConsecutivo.Text <> 0 And txtNombreEmpleado.Text <> "" And txtApellidoP.Text <> "" And txtApellidoM.Text <> "" And txtRFC.Text <> "" And txtCURP.Text <> "" And txtDireccion.Text <> "" And cmbColonia.Text <> "" And txtEstado.Text <> "" And txtCiudad.Text <> "" And cmbPuesto.Text <> "" And txtCP.Text <> "" Then
                Try
                    Dim dts As New CEmpleado
                    Dim func As New fEmpleado

                    dts._idEmpleado = txtConsecutivo.Text
                    dts._noEmpleado = txtIDEmpleado.Text
                    dts._Nombre = txtNombreEmpleado.Text
                    dts._ApellidoP = txtApellidoP.Text
                    dts._ApellidoM = txtApellidoM.Text
                    dts._CURP = txtCURP.Text
                    dts._RFC = txtRFC.Text
                    dts._Direccion = txtDireccion.Text
                    dts._CP = txtCP.Text
                    dts._Colonia = cmbColonia.Text
                    dts._Ciudad = txtCiudad.Text
                    dts._Estado = txtEstado.Text
                    dts._idPuesto = cmbPuesto.Text
                    dts._Telefono = txtTelefono.Text
                    dts._Mail = txtMail.Text

                    If func.Modificar_Empleado(dts) Then
                        MessageBox.Show("Empleado modificado correctamente", "Modificando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Mostrar()
                        Limpiar()
                    Else
                        MessageBox.Show("Empleado no modificado, intente de nuevo", "Modificando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Mostrar()
                        Limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Faltan datos por ingresar", "Modificando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub


    Private Sub chbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chbEliminar.CheckedChanged
        If chbEliminar.CheckState = CheckState.Checked Then
            dvgEmpleado.Columns.Item("Eliminar").Visible = True
        Else
            dvgEmpleado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub dvgEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgEmpleado.CellContentClick
        If e.ColumnIndex = Me.dvgEmpleado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dvgEmpleado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar la información seleccionada", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dvgEmpleado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ID_Empleado").Value)
                        Dim vdb As New CEmpleado
                        Dim func As New fEmpleado
                        vdb._idEmpleado = onekey

                        If func.Eliminar_Empleado(vdb) Then
                        Else
                            MessageBox.Show("Empleado no eliminado", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call Mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registro", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Mostrar()
        End If
        Limpiar()
    End Sub

    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Desactivar()
    End Sub

    Public Sub Desactivar()
        txtConsecutivo.Enabled = False
        txtIDEmpleado.Enabled = False
        txtNombreEmpleado.Enabled = False
        txtApellidoP.Enabled = False
        txtApellidoM.Enabled = False
        txtCURP.Enabled = False
        txtRFC.Enabled = False
        txtDireccion.Enabled = False
        cmbColonia.Enabled = False
        txtCiudad.Enabled = False
        txtEstado.Enabled = False
        txtCP.Enabled = False
        txtTelefono.Enabled = False
        txtMail.Enabled = False
        cmbPuesto.Enabled = False
    End Sub

    Public Sub Activar()
        txtIDEmpleado.Enabled = True
        txtNombreEmpleado.Enabled = True
        txtApellidoP.Enabled = True
        txtApellidoM.Enabled = True
        txtCURP.Enabled = True
        txtRFC.Enabled = True
        txtDireccion.Enabled = True
        cmbColonia.Enabled = True
        txtCiudad.Enabled = True
        txtEstado.Enabled = True
        txtCP.Enabled = True
        txtTelefono.Enabled = True
        txtMail.Enabled = True
        cmbPuesto.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Mostrar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Public Sub Codigo()
        If txtCP.Text = "36903" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("EL BELTRÁN")
            cmbColonia.Items.Add("LOS CONEJITOS")
            cmbColonia.Items.Add("EL TOLENTO")
            cmbColonia.Items.Add("ARROYO HONDO")
            cmbColonia.Items.Add("LÁZARO CÁRDENAS")
            cmbColonia.Items.Add("EL SABINO")
            cmbColonia.Items.Add("SAN MIGUEL II")
            cmbColonia.Items.Add("SAN MIGUEL")
            cmbColonia.Items.Add("CORRAL DE PIEDRA")
            cmbColonia.Items.Add("SAN JOSÉ")
            cmbColonia.Items.Add("LA SOLEDAD")

        ElseIf txtCP.Text = "36904" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("LA MAGUEYERA")
            cmbColonia.Items.Add("PALO BLANCO")
            cmbColonia.Items.Add("LOS FRESNOS I")
            cmbColonia.Items.Add("LOS FRESNOS II")
            cmbColonia.Items.Add("EL HUARAPO")
            cmbColonia.Items.Add("FERMÍN")
            cmbColonia.Items.Add("LAS AMÉRICAS")
            cmbColonia.Items.Add("NUEVA ESPERANZA")
            cmbColonia.Items.Add("SIGLO XXI")

        ElseIf txtCP.Text = "36905" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("LINDAVISTA")
            cmbColonia.Items.Add("LA LOMA")
            cmbColonia.Items.Add("MIGUEL HIDALGO")

        ElseIf txtCP.Text = "36906" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("LOS SABINOS")
            cmbColonia.Items.Add("BELLAVISTA")
            cmbColonia.Items.Add("IVEG")
            cmbColonia.Items.Add("MAGISTERIAL")
            cmbColonia.Items.Add("LOMAS DE SAN FERNANDO")
            cmbColonia.Items.Add("BALCONES DE SAN ANDRÉS")
            cmbColonia.Items.Add("DEL SOL")
            cmbColonia.Items.Add("EL NACIMIENTO")
            cmbColonia.Items.Add("JOAQUÍN PARDAVÉ")
            cmbColonia.Items.Add("NICOLAS BRAVO")

        ElseIf txtCP.Text = "36907" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("ANTONIO GÓMEZ RODRÍGUEZ")
            cmbColonia.Items.Add("SAN ANTONIO")
            cmbColonia.Items.Add("JUÁREZ")
            cmbColonia.Items.Add("CRUZ VERDE")
            cmbColonia.Items.Add("LOS PRESIDENTES")
            cmbColonia.Items.Add("LA RINCONADA")
            cmbColonia.Items.Add("LA MEDIA ANEGA")
            cmbColonia.Items.Add("LOMA BONITA")
            cmbColonia.Items.Add("VILLAS CASA BLANCA")

        ElseIf txtCP.Text = "36910" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("SANTA ANA PACUECO")

        ElseIf txtCP.Text = "33913" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("EL LIMÓN")
            cmbColonia.Items.Add("SAN FELIPE (EL CHILARILLO)")
            cmbColonia.Items.Add("GUAYABO DE RUIZ")
            cmbColonia.Items.Add("NUEVO SANTA ELENA DE ACEVES (EL CAPRICHO)")
            cmbColonia.Items.Add("FICHA DE LÓPEZ")
            cmbColonia.Items.Add("EL ÁDOLO")
            cmbColonia.Items.Add("EL CICUITAL")
            cmbColonia.Items.Add("EL CUBILETE (PINO SOLO)")
            cmbColonia.Items.Add("EL PANTANO")
            cmbColonia.Items.Add("EL PARIÁN")
            cmbColonia.Items.Add("FICHAS DE LEÓN")
            cmbColonia.Items.Add("LOS CAPULINES DE AGUIRRE")
            cmbColonia.Items.Add("PINO SOLO")
            cmbColonia.Items.Add("RINCÓN DE PITAHAYOS")

        ElseIf txtCP.Text = "36914" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("EJIDO JOYA DE MULAS")
            cmbColonia.Items.Add("SAN ANTONIO DE ACEVES")
            cmbColonia.Items.Add("SAUZ DE MÉNDEZ")
            cmbColonia.Items.Add("LOMITA DE ACEVES (SANTA ELENA DE ACEVES)")
            cmbColonia.Items.Add("CASAS BLANCAS")
            cmbColonia.Items.Add("DON JOSÉ ALATORRE")
            cmbColonia.Items.Add("EL HUIZACHE")
            cmbColonia.Items.Add("EL NACIMIENTO")
            cmbColonia.Items.Add("LA GLORIA")
            cmbColonia.Items.Add("LA VIGUERÍA")
            cmbColonia.Items.Add("LOMA DE ACEVES UNO")
            cmbColonia.Items.Add("PUERTO DE CHILARILLO")
            cmbColonia.Items.Add("SAN ISIDRO DE AYALA (LA VERIJA)")

        ElseIf txtCP.Text = "36915" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("LA JAMACUA DE CORTÉS")
            cmbColonia.Items.Add("LOS AMOLES DE CORTÉS")
            cmbColonia.Items.Add("LA MINA")
            cmbColonia.Items.Add("LA SARDINA")
            cmbColonia.Items.Add("PRESA DE JOYA DE MULAS")
            cmbColonia.Items.Add("SAUZ DE MÉNDEZ")

        ElseIf txtCP.Text = "36916" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("GUAYABO DE PEDROZA")
            cmbColonia.Items.Add("ESTACIÓN LA PIEDAD")
            cmbColonia.Items.Add("LA ERMITA")
            cmbColonia.Items.Add("GUAYABO DE PEDROZA")
            cmbColonia.Items.Add("LA SARNA")
            cmbColonia.Items.Add("EMILIANO ZAPATA (LA RASCA)")
            cmbColonia.Items.Add("LA CALERITA")
            cmbColonia.Items.Add("LÁZARO CÁRDENAS")
            cmbColonia.Items.Add("EL VIVERO")
            cmbColonia.Items.Add("GUAMÚCHIL")
            cmbColonia.Items.Add("PESCADORES")
            cmbColonia.Items.Add("RANCHO LAS PEÑAS")

        ElseIf txtCP.Text = "36917" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("QUESERA DE CORTÉS")
            cmbColonia.Items.Add("SANTA LUCÍA")
            cmbColonia.Items.Add("LIEBRES DE SUÁREZ")
            cmbColonia.Items.Add("LA MULA DE AGUILAR")
            cmbColonia.Items.Add("TARENGO DE PARRAS")
            cmbColonia.Items.Add("CAPILLA DE MORALES")
            cmbColonia.Items.Add("LA CHARQUILLA")
            cmbColonia.Items.Add("CANOAS")
            cmbColonia.Items.Add("EL AVISPERO")
            cmbColonia.Items.Add("EL CARRIZAL")
            cmbColonia.Items.Add("EL CEBADERO")
            cmbColonia.Items.Add("EL PIRUL")
            cmbColonia.Items.Add("EL TOPETE")
            cmbColonia.Items.Add("LA ROSA MORADA")
            cmbColonia.Items.Add("SAN FRANCICO DE RIZO")
            cmbColonia.Items.Add("TROJES DE ROMERO")

        ElseIf txtCP.Text = "36920" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("CERRO ALTO")
            cmbColonia.Items.Add("ESTANCIA DE LA PAZ")
            cmbColonia.Items.Add("EL PANDITO")
            cmbColonia.Items.Add("LA BARRANCA DE CHILAR")
            cmbColonia.Items.Add("EL NACIMIENTO")
            cmbColonia.Items.Add("CERRO BLANCO DE CAMARILLO")
            cmbColonia.Items.Add("EJIDO CARRETAS (EL INFIERNILLO)")
            cmbColonia.Items.Add("EL CAPULÍN DE LA CRUZ")
            cmbColonia.Items.Add("EL CHILAR GRANDE")
            cmbColonia.Items.Add("EL CRUCILLAL")
            cmbColonia.Items.Add("EL GIRO")
            cmbColonia.Items.Add("EL ROSARIO")
            cmbColonia.Items.Add("HUERTA GRANDE (SAUZ DE MÉNDEZ)")
            cmbColonia.Items.Add("JOYA DE LOBOS")
            cmbColonia.Items.Add("LA CALLE DE MARTÍNEZ")
            cmbColonia.Items.Add("LA GARITA")
            cmbColonia.Items.Add("LA GLORIA")
            cmbColonia.Items.Add("LA GRULLA")
            cmbColonia.Items.Add("LA JÍCAMA")
            cmbColonia.Items.Add("LOS CHILARES")
            cmbColonia.Items.Add("MESA DE MARAVILLAS")
            cmbColonia.Items.Add("PRESA DE COLORADO")
            cmbColonia.Items.Add("PRESITAS DE REGIL")
            cmbColonia.Items.Add("PROVIDENCIA")
            cmbColonia.Items.Add("RANCHO NUEVO DE GUTIÉRREZ")

        ElseIf txtCP.Text = "36923" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("LAS PRADERAS")
            cmbColonia.Items.Add("LA SOLEDAD DE MORALES")
            cmbColonia.Items.Add("MAGALLANES")
            cmbColonia.Items.Add("ZAPOTE DE CESTAU")
            cmbColonia.Items.Add("TEPUZA DE ORTIZ")
            cmbColonia.Items.Add("TEPUZA DE VILLALOBOS")
            cmbColonia.Items.Add("EL CERESO")
            cmbColonia.Items.Add("ALFERES DE JIMÉNEZ")
            cmbColonia.Items.Add("CORRAL DE RAMAS")
            cmbColonia.Items.Add("EL ÁLAMO (EL ÁLAMO DEL CACHIRPE)")
            cmbColonia.Items.Add("EL CUARENTA DE SOLEDAD DE MORALES")
            cmbColonia.Items.Add("EL FRESNO DE LA PEÑA")
            cmbColonia.Items.Add("EL GALLITO")
            cmbColonia.Items.Add("EL GONZALO DE PAÚL")
            cmbColonia.Items.Add("EL GUAJE")
            cmbColonia.Items.Add("EL GUAYABO")
            cmbColonia.Items.Add("EL NACIMIENTO DE ORTIZ")
            cmbColonia.Items.Add("EL ROSARIO (EL RANCHITO)")
            cmbColonia.Items.Add("FRACCIÓN DE NACIMIENTO")
            cmbColonia.Items.Add("FRESNO DOS")
            cmbColonia.Items.Add("GRANJA HILARIÓN ESPINOZA")
            cmbColonia.Items.Add("GRANJITA SAN JORGE (ESTACIÓN CORRALEJO)")
            cmbColonia.Items.Add("LAS PALMAS (LAS PALMAS DEL CACHIRPE)")
            cmbColonia.Items.Add("LOS ALFERES DE CERVANTES")
            cmbColonia.Items.Add("SAN ÁNGEL")

        ElseIf txtCP.Text = "36924" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("LA GRANJENA")
            cmbColonia.Items.Add("LABOR DE REYES")
            cmbColonia.Items.Add("SAN GABRIEL")
            cmbColonia.Items.Add("SAN IGNACIO")
            cmbColonia.Items.Add("CONCEPCIÓN DE RUIZ")
            cmbColonia.Items.Add("MONTE BELLO (EL TECOLOTE)")
            cmbColonia.Items.Add("SAN LUIS EL ALTO")
            cmbColonia.Items.Add("EL ROMERAL")
            cmbColonia.Items.Add("LABOR DE ARMENTA")
            cmbColonia.Items.Add("PURÍSIMA DE RAMÍREZ (LOS ORIONES)")
            cmbColonia.Items.Add("SAN JOSÉ DE LOS SABINOS")
            cmbColonia.Items.Add("LA HILACHA (EL REFUGIO DE HERRERA)")
            cmbColonia.Items.Add("SAN PEDRITO")
            cmbColonia.Items.Add("EL DERRAMADERO (LA CUCUNA)")
            cmbColonia.Items.Add("CONSA DE JUAN DE ÁLVAREZ")
            cmbColonia.Items.Add("EL CACHIRPE DOS")
            cmbColonia.Items.Add("GODOY")
            cmbColonia.Items.Add("LA CUMBRE")
            cmbColonia.Items.Add("LA CUMBRE DOS (JOSÉ REYES)")
            cmbColonia.Items.Add("LA LOMA")
            cmbColonia.Items.Add("LA PRIVIDENCIA DE CORTEZ")
            cmbColonia.Items.Add("LABOR DE ARIAS")
            cmbColonia.Items.Add("LABOR DE LÓPEZ")
            cmbColonia.Items.Add("MONTE REDONDO DOS (LOS ESQUIVEL)")
            cmbColonia.Items.Add("MONTE REDONDO UNO (LOS CORTÉS)")
            cmbColonia.Items.Add("SAN MIGUEL DE VILLASEÑOR")
            cmbColonia.Items.Add("sANTA MÓNICA")

        ElseIf txtCP.Text = "36925" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("EL CALABOZO (LA JOYA)")
            cmbColonia.Items.Add("PLAN DEL FRESNO (EL PAJARITO)")
            cmbColonia.Items.Add("EL TIGRE")
            cmbColonia.Items.Add("EL VOLANTÍN")
            cmbColonia.Items.Add("EL GALLO")
            cmbColonia.Items.Add("TIERRAS NEGRAS")
            cmbColonia.Items.Add("GUANGÜTIRO")
            cmbColonia.Items.Add("CERRO BLANCO")
            cmbColonia.Items.Add("CERRO PRIETO (LAS LETRAS)")
            cmbColonia.Items.Add("COPORITOS")
            cmbColonia.Items.Add("EL AGUACATE")
            cmbColonia.Items.Add("EL CUERVO")
            cmbColonia.Items.Add("LA ACEITUNA")
            cmbColonia.Items.Add("LA CAJA DE LA GOLONDRINA")
            cmbColonia.Items.Add("LA LAGARTIJA")
            cmbColonia.Items.Add("LA TEPUZA")
            cmbColonia.Items.Add("LAGUNITA DE CERRO BLANCO")
            cmbColonia.Items.Add("LAS MANGAS (ROSA DE NEGRETE)")
            cmbColonia.Items.Add("LLANOS DEL MUERTO")
            cmbColonia.Items.Add("POTRERILLOS DEL CERRO")

        ElseIf txtCP.Text = "36926" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("EL NARANJITO")
            cmbColonia.Items.Add("LAS TABLAS DE CORRALEJO")
            cmbColonia.Items.Add("CAÑADA DE CORRALEJO")
            cmbColonia.Items.Add("PRESA DEL AGUACATE")
            cmbColonia.Items.Add("MANGAS DE CORRALEJO")
            cmbColonia.Items.Add("LAS CARRETAS")
            cmbColonia.Items.Add("EL NOPAL")
            cmbColonia.Items.Add("ATARJEA")
            cmbColonia.Items.Add("CARRIZO DEL CERRO")
            cmbColonia.Items.Add("CERRO COLORADO")
            cmbColonia.Items.Add("CERRO PRIETO")
            cmbColonia.Items.Add("EL AGUACATE")
            cmbColonia.Items.Add("EL VENADO")
            cmbColonia.Items.Add("EL ZARCO")
            cmbColonia.Items.Add("LA CINTA")
            cmbColonia.Items.Add("LA CUMBRE")
            cmbColonia.Items.Add("LA GARITA")
            cmbColonia.Items.Add("LA LAGUNITA")
            cmbColonia.Items.Add("LA MANGA")
            cmbColonia.Items.Add("LA SERENA")
            cmbColonia.Items.Add("LAS BIZNAGAS")
            cmbColonia.Items.Add("LAS MINAS")
            cmbColonia.Items.Add("LAS MINAS DOS")
            cmbColonia.Items.Add("LAS PAREDES")
            cmbColonia.Items.Add("LOS ALCALANES")
            cmbColonia.Items.Add("MESA DE LA TIENDA")
            cmbColonia.Items.Add("MONTE REDONDO")
            cmbColonia.Items.Add("PRESITAS DE GÓMEZ")
            cmbColonia.Items.Add("SANTA TERESA DE AGUIRRE")

        ElseIf txtCP.Text = "36927" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("ESTACIÓN CORRALEJO")
            cmbColonia.Items.Add("CORRALEJO DE HIDALGO")
            cmbColonia.Items.Add("AGUA TIBIA DE AYALA")
            cmbColonia.Items.Add("EL RODEO DE AYALA (LA ORDEÑA)")
            cmbColonia.Items.Add("CARRIZO DE LEDEZMA")
            cmbColonia.Items.Add("EL COPAL")
            cmbColonia.Items.Add("ÁNGELES DE VILLASEÑOR")
            cmbColonia.Items.Add("BUENAVISTA DE CERVANTES")
            cmbColonia.Items.Add("DIQUE ALTO DE CORRALEJO")
            cmbColonia.Items.Add("EL JAGÜEY (MANANTIALES)")
            cmbColonia.Items.Add("EL LAUREL")
            cmbColonia.Items.Add("EL MANZANO")
            cmbColonia.Items.Add("EL PORVENIR DE AYALA")
            cmbColonia.Items.Add("EL TARENGO")
            cmbColonia.Items.Add("LA ESTANZUELA")
            cmbColonia.Items.Add("LAS POMAS")
            cmbColonia.Items.Add("LOS ELIZARRARAZ (LOS ÁNGELES DE VILLASEÑOR)")
            cmbColonia.Items.Add("PANZA COLA")
            cmbColonia.Items.Add("RANCHO EL CHAYOTE")
            cmbColonia.Items.Add("SAN AGUSTÍN EL ALTO")

        ElseIf txtCP.Text = "36930" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("LAGUNA LARGA DE CORTÉS")
            cmbColonia.Items.Add("COL INDECO")

        ElseIf txtCP.Text = "36933" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("LA MADEJA")
            cmbColonia.Items.Add("LOS OCOTES")
            cmbColonia.Items.Add("LA ESTRELLA")
            cmbColonia.Items.Add("EL CAPADERO")
            cmbColonia.Items.Add("EL MONTE")
            cmbColonia.Items.Add("LA CINTA")
            cmbColonia.Items.Add("LA ESTACA")
            cmbColonia.Items.Add("LAS CUEVAS")
            cmbColonia.Items.Add("LAS UVAS")

        ElseIf txtCP.Text = "36934" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("SAN RAFAEL DE LA MARAÑA")
            cmbColonia.Items.Add("SAN JOSÉ DE LAS MORAS")
            cmbColonia.Items.Add("ARATZIPU")
            cmbColonia.Items.Add("EL SALITRILLO")
            cmbColonia.Items.Add("MITAD DE NORIA")
            cmbColonia.Items.Add("EL CARRICILLO")
            cmbColonia.Items.Add("CIENEGUITA DE MORALES")
            cmbColonia.Items.Add("EL SOLOVINO")
            cmbColonia.Items.Add("LA ESMERALDA")

        ElseIf txtCP.Text = "36935" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("LAS ÁNIMAS")
            cmbColonia.Items.Add("PALO ALTO DE ARRIBA")
            cmbColonia.Items.Add("CHURIPITZEO")
            cmbColonia.Items.Add("PLAZUELAS")
            cmbColonia.Items.Add("EL COBRE")
            cmbColonia.Items.Add("EL GUAYABO DE CAMARENA")
            cmbColonia.Items.Add("LAS TINAJAS")
            cmbColonia.Items.Add("BUENOS AIRES")
            cmbColonia.Items.Add("EL CHUPADERO")
            cmbColonia.Items.Add("EL REFUGIO DE RIVAS")
            cmbColonia.Items.Add("EL SAUZ DE PASTORES")
            cmbColonia.Items.Add("EL XOCONOXTLE")
            cmbColonia.Items.Add("GUADALUPE DE GÓMEZ (LA CALAVERA)")
            cmbColonia.Items.Add("LA CAPILLA")
            cmbColonia.Items.Add("LA CARBONERA")
            cmbColonia.Items.Add("LA ESCONDIDA DE MORALES")
            cmbColonia.Items.Add("LA GOLONDRINA")
            cmbColonia.Items.Add("LA YESCA")
            cmbColonia.Items.Add("LAGUNILLA DE PÉREZ")
            cmbColonia.Items.Add("LAS PLAZUELAS (SAN JUAN EL ALTO)")
            cmbColonia.Items.Add("LOS ÁLAMOS")
            cmbColonia.Items.Add("PALO BLANCO DE ÁVILA")
            cmbColonia.Items.Add("SAN ANDRÉS")

        ElseIf txtCP.Text = "36936" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("PEQUEÑA PROPIEDAD DEL CORRAL DE LA PARTIDA")
            cmbColonia.Items.Add("COLORADO DE SAAVEDRA")
            cmbColonia.Items.Add("CORRAL DE PARTIDA")
            cmbColonia.Items.Add("EL MOGOTE DE REYES")
            cmbColonia.Items.Add("LA LUCITA DE LEDEZMA")
            cmbColonia.Items.Add("LA REMOLACHA")
            cmbColonia.Items.Add("LAS TINAJITAS")
            cmbColonia.Items.Add("LIEBRES DE ROSALES")
            cmbColonia.Items.Add("LOMA LINDA DE ALVAREZ")
            cmbColonia.Items.Add("PLAYA AZUL")
            cmbColonia.Items.Add("SAN MIGUEL DE BUENAVISTA (RANCHO DE PEÑA)")
            cmbColonia.Items.Add("SANTA TERESA DE MORALES TRES")
            cmbColonia.Items.Add("SAUZ DE MOLINA")
            cmbColonia.Items.Add("SAUZ DE VILLASEÑOR")
            cmbColonia.Items.Add("VARAL DE MORALES")

        ElseIf txtCP.Text = "36937" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("EL PEDREGAL DE ABAJO")
            cmbColonia.Items.Add("EL PEDREGAL DE ARRIBA")
            cmbColonia.Items.Add("EL TLACUACHE")
            cmbColonia.Items.Add("ZAPOTE DE BARAJAS")
            cmbColonia.Items.Add("SAN ANTONIO DE AGUIRRE (SAN VICENTE)")
            cmbColonia.Items.Add("SAN RAFAEL DE VILLASEÑOR")
            cmbColonia.Items.Add("EL POCHOTE")
            cmbColonia.Items.Add("VIBORILLAS DE SUÁREZ")
            cmbColonia.Items.Add("EL CAPRICHO DE REYES")
            cmbColonia.Items.Add("EL HUIZACHE")
            cmbColonia.Items.Add("PUERTA DE GÓMEZ CHICA")

        ElseIf txtCP.Text = "36938" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("ESTACIÓN PÉNJAMO")
            cmbColonia.Items.Add("SAN CARLOS")

        ElseIf txtCP.Text = "36940" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("BUENAVISTA DE CORTÉS")
            cmbColonia.Items.Add("LA CAL GRANDE")
            cmbColonia.Items.Add("SAN MIGUEL DE CAMARENA")
            cmbColonia.Items.Add("MORELOS")
            cmbColonia.Items.Add("CHURINCILLO")
            cmbColonia.Items.Add("VILLAFUERTE")
            cmbColonia.Items.Add("EL TALÓN")
            cmbColonia.Items.Add("LA ESPERANZA")
            cmbColonia.Items.Add("LA ESTACA")
            cmbColonia.Items.Add("LA VILLA DE GUADALUPE")
            cmbColonia.Items.Add("LAS JARAS")
            cmbColonia.Items.Add("SAN JOSÉ CHINCUAL")

        ElseIf txtCP.Text = "36943" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("LAGUNILLAS")
            cmbColonia.Items.Add("MEZQUITE DE LUNA")
            cmbColonia.Items.Add("CORRAL DE SANTIAGO")
            cmbColonia.Items.Add("ARECHITA")
            cmbColonia.Items.Add("EL RECREO")
            cmbColonia.Items.Add("LA ESTANCIA DEL REFUGIO")
            cmbColonia.Items.Add("PERALTA DE JIMÉNEZ")
            cmbColonia.Items.Add("SAN JOSÉ DE LA CAL GRANDE (EL CUILE)")

        ElseIf txtCP.Text = "36944" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("CRUCES DE ROJAS")
            cmbColonia.Items.Add("HORNITOS (HORNOS)")
            cmbColonia.Items.Add("LA LOBERA")
            cmbColonia.Items.Add("MARAVILLAS DE MORALES")
            cmbColonia.Items.Add("EL CUERVO")
            cmbColonia.Items.Add("LA SOLEDAD")
            cmbColonia.Items.Add("EL TIGRE")

        ElseIf txtCP.Text = "36945" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("CORRALES DE RÁBAGO")
            cmbColonia.Items.Add("HACIENDA DEL CARMEN")
            cmbColonia.Items.Add("SAN ISIDRO DEL CARMEN")
            cmbColonia.Items.Add("CERRITOS BLANCOS")
            cmbColonia.Items.Add("EL AVISPERO")
            cmbColonia.Items.Add("EL CARACOL")
            cmbColonia.Items.Add("VEREDAS")
            cmbColonia.Items.Add("EL CERRO")
            cmbColonia.Items.Add("HUANDARILLO")
            cmbColonia.Items.Add("ABRAHAM MARTÍNEZ (COLONIA LAS FLORES)")
            cmbColonia.Items.Add("SAN RAFAEL DE LA ANGOSTURA")
            cmbColonia.Items.Add("CASAS CHICAS")
            cmbColonia.Items.Add("DEL CERRO")
            cmbColonia.Items.Add("EL TARENGO")
            cmbColonia.Items.Add("LA HUERTA DE HUANDARILLO")
            cmbColonia.Items.Add("LA PUERTA DEL RINCÓN")
            cmbColonia.Items.Add("LA SOLEDAD")
            cmbColonia.Items.Add("SAN ANTONIO CASA CHICA")

        ElseIf txtCP.Text = "36946" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("CHARCOS DE PAÚL")
            cmbColonia.Items.Add("CUEVAS DE MORALES")
            cmbColonia.Items.Add("LA PAZ")
            cmbColonia.Items.Add("EL INFIERNILLO")
            cmbColonia.Items.Add("SAN MARCOS")
            cmbColonia.Items.Add("CASTILLO DE VILLASEÑOR")
            cmbColonia.Items.Add("LA ROSA (DE CRUCES DE MORALES)")
            cmbColonia.Items.Add("SAN IGNACIO DE ÁLVAREZ")
            cmbColonia.Items.Add("INDEPENDENCIA")
            cmbColonia.Items.Add("CRUCES DE MORALES")
            cmbColonia.Items.Add("LOMITA DE NAVARRO")
            cmbColonia.Items.Add("OJO DE AGUA DEL MORO")
            cmbColonia.Items.Add("SANTA TERESA DE MORALES")
            cmbColonia.Items.Add("TACUBA")
            cmbColonia.Items.Add("TEPAMAL DE PIMENTEL")

        ElseIf txtCP.Text = "36947" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("PALO VERDE")
            cmbColonia.Items.Add("COLORADO DE HERRERA")
            cmbColonia.Items.Add("PALO ALTO DE ABAJO")
            cmbColonia.Items.Add("PROVIDENCIA DE NEGRETE")
            cmbColonia.Items.Add("SAN BERNARDO")
            cmbColonia.Items.Add("TACUBAYA")
            cmbColonia.Items.Add("TEPETATE DE NEGRETE")
            cmbColonia.Items.Add("TROJES DE PAÚL")
            cmbColonia.Items.Add("LA GAVILANA")
            cmbColonia.Items.Add("SAN JUANITO DE ECHEVERRÍA")
            cmbColonia.Items.Add("SAN FERNANDO DE PAÚL (EL PIOJO)")
            cmbColonia.Items.Add("SAN JOSÉ DE MORALES")
            cmbColonia.Items.Add("PRESIDIO DE MORALES")
            cmbColonia.Items.Add("MIRAVALLE")
            cmbColonia.Items.Add("EL COPAL")
            cmbColonia.Items.Add("EL PINO DE RAMÍREZ")
            cmbColonia.Items.Add("ESTACIÓN TACUBAYA")
            cmbColonia.Items.Add("LA CUMBRE")
            cmbColonia.Items.Add("LA LOMA")
            cmbColonia.Items.Add("LAS UVAS")
            cmbColonia.Items.Add("PORTALES DE HERRERA")
            cmbColonia.Items.Add("SANTA TERESA DE MORALES DOS")
            cmbColonia.Items.Add("TEPETATE DE ORIGEL (EL TOPE)")

        ElseIf txtCP.Text = "36948" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("GUAYABO DE ORIGEL")
            cmbColonia.Items.Add("SAN JOSÉ DE MARAVILLAS")
            cmbColonia.Items.Add("LA CALLE")
            cmbColonia.Items.Add("ZAMBRANO")
            cmbColonia.Items.Add("POTRELILLOS DEL RÍO")
            cmbColonia.Items.Add("ARAMÚTARO DE LUQUE")
            cmbColonia.Items.Add("PURÍSIMA DE ALTAMIRA")
            cmbColonia.Items.Add("SAN VICENTE DEL MÁRMOL")
            cmbColonia.Items.Add("OJO DE AGUA CALIENTE")
            cmbColonia.Items.Add("RANCHO NUEVO DE POTREROS")
            cmbColonia.Items.Add("TRINIDAD DE LOS ÁNGELES (LA JABONERA)")
            cmbColonia.Items.Add("CAPILLA DE MÁRQUEZ")
            cmbColonia.Items.Add("CRUCITAS DE GUTIÉRREZ")
            cmbColonia.Items.Add("EL CHIFLIDO")
            cmbColonia.Items.Add("EL MÁRMOL")
            cmbColonia.Items.Add("LA ATARJEA")
            cmbColonia.Items.Add("ORDEÑA DE BARAJAS")
            cmbColonia.Items.Add("MORO DE BARAJAS (LA PEÑITA)")
            cmbColonia.Items.Add("NORIA DE BARAJAS")
            cmbColonia.Items.Add("POTREROS")
            cmbColonia.Items.Add("PUESTA DE AGUA CALIENTE")
            cmbColonia.Items.Add("RANCHO NUEVO DE BARAJAS ( EL MAGUEY)")
            cmbColonia.Items.Add("RANCHO SECO DE BARAJAS")
            cmbColonia.Items.Add("SAN ISIDRO DE CRUCITAS")
            cmbColonia.Items.Add("EL COMALILLO")
            cmbColonia.Items.Add("BARAJAS VIEJO")
            cmbColonia.Items.Add("EL TEPAMAL")
            cmbColonia.Items.Add("VISTA HERMOSA DE LA TRINIDAD (VILLASEÑOR)")
            cmbColonia.Items.Add("EJIDO BENITO JUÁREZ (LA MULA)")
            cmbColonia.Items.Add("LEYVA DE BARAJAS")
            cmbColonia.Items.Add("BRILLANTE DE MIRAMAR")
            cmbColonia.Items.Add("COBERTIZO DE BARAJAS")
            cmbColonia.Items.Add("EL JARALILLO")
            cmbColonia.Items.Add("EL MAGUEY DE BARAJAS")
            cmbColonia.Items.Add("EL MONTE")
            cmbColonia.Items.Add("EL NOPAL (EL NOPAL DE ARROYO)")
            cmbColonia.Items.Add("EL NOPAL DOS")
            cmbColonia.Items.Add("LA TROJA (EL CHIFLIDO)")
            cmbColonia.Items.Add("SAN JOSÉ DE MARAVILLAS (EL RANCHITO)")

        ElseIf txtCP.Text = "36900" Then
            txtCiudad.Text = "PÉNJAMO"
            txtEstado.Text = "GTO"
            cmbColonia.Items.Add("PÉNJAMO CENTRO")
        End If
    End Sub

    
End Class