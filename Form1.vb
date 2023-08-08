Public Class Form1
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        GestionClientes.Show()
        Me.Close()
    End Sub

    Private Sub BtnCreditos_Click(sender As Object, e As EventArgs) Handles BtnCreditos.Click
        GestionCreditos.Show()
        Me.Close()

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        CalcularPrestamo.Show()
        Me.Close()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnPagos_Click(sender As Object, e As EventArgs) Handles BtnPagos.Click
        FormPagos.Show()
        Me.Close()
    End Sub
End Class
