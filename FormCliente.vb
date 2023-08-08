Public Class FormCliente












    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

    End Sub

    Private Sub Btnfot_Click(sender As Object, e As EventArgs) Handles Btnfot.Click
        Try
            OpenFileDialog1.Title = "Abrir Imagen"
            OpenFileDialog1.FileName = "jpg"
            OpenFileDialog1.Filter = "All Files |*.*"
            OpenFileDialog1.ShowDialog()

            FotografiaPictureBox.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
            MsgBox("Archivo no valido")
        End Try

    End Sub



    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        GestionClientes.Show()
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        CodigoClienteTextBox.Focus()
    End Sub

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class