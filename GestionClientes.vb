Public Class GestionClientes
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        FormCliente.Show()
        Me.Close()
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        ConsultaCliente.Show()
        Me.Close()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        CalcularPrestamo.Show()
        Me.Close()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class