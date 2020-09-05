Public Class frmMENU


    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        frmEmpleado.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmUsuario.Show()
    End Sub

    Private Sub ArtículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtículosToolStripMenuItem.Click
        frmArticulos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmCliente.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frmProveedor.Show()
    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click
        frmEmpresa.Show()
    End Sub

    Private Sub CategoríasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoríasToolStripMenuItem.Click
        frmCategoria.Show()
    End Sub

    Private Sub CréditoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréditoToolStripMenuItem.Click
        frmCredito.Show()
    End Sub

    Private Sub ContadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContadoToolStripMenuItem.Click
        frmContado.Show()
    End Sub

    Private Sub AbonoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbonoToolStripMenuItem.Click
        frmAbono.Show()
    End Sub

    Private Sub EstadoDeCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeCuentaToolStripMenuItem.Click
        frmEstadoCta.Show()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click
        frmReporteVentas.Show()
    End Sub

    Private Sub AbonosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbonosToolStripMenuItem.Click
        frmReporteAbonos.Show()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        frmReporteInventario.Show()
    End Sub

    Private Sub PuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestosToolStripMenuItem.Click
        frmPuesto.Show()
    End Sub
End Class