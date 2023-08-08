Public Class CalcularPrestamo
    Private Sub BtnCalcu_Click(sender As Object, e As EventArgs) Handles BtnCalcu.Click
        Dim monto As Double = CDbl(TxtMonto.Text)
        Dim plazoEnMeses As Integer = CInt(TxtPlazo.Text)
        Dim tasaInteres As Double = CDbl(TxtTasaInteres.Text) / 100
        Dim formaPago As String = CmbFormaPago.SelectedItem.ToString()
        Dim numeroCuotas As Integer = CInt(TxtNumeroCuotas.Text)

        ' Calcular el valor de la cuota y el interés por cuota
        Dim interesPorCuota As Double = (monto * plazoEnMeses * tasaInteres) / numeroCuotas
        Dim valorCuota As Double = (monto * plazoEnMeses * tasaInteres + monto) / numeroCuotas

        ' Mostrar los resultados en las etiquetas correspondientes
        LblValorCuota.Text = valorCuota.ToString("")
        LblInteresPorCuota.Text = interesPorCuota.ToString("")
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        FormCredito.Show()
        Me.Close()
    End Sub

    Private Sub BtnListo_Click(sender As Object, e As EventArgs) Handles BtnListo.Click

    End Sub
End Class