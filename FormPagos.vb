Public Class FormPagos
    Private Sub BtnVerRecibo_Click(sender As Object, e As EventArgs) Handles BtnVerRecibo.Click
        FormDetalle.Show()
        Me.Close()

    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class