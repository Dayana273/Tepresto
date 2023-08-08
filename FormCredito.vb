Public Class FormCredito
    Private Sub PagosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PagosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PagosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CREDEFINDataSet)

    End Sub

    Private Sub FormCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CREDEFINDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.CREDEFINDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'CREDEFINDataSet.Creditos' Puede moverla o quitarla según sea necesario.
        Me.CreditosTableAdapter.Fill(Me.CREDEFINDataSet.Creditos)
        'TODO: esta línea de código carga datos en la tabla 'CREDEFINDataSet.Creditos' Puede moverla o quitarla según sea necesario.
        Me.CreditosTableAdapter.Fill(Me.CREDEFINDataSet.Creditos)
        'TODO: esta línea de código carga datos en la tabla 'CREDEFINDataSet.Pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.CREDEFINDataSet.Pagos)

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        GestionCreditos.Show()
        Me.Close()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        CalcularPrestamo.Show()
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Me.ClientesBindingSource.AddNew()
        CodigoClienteTextBox.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CREDEFINDataSet)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.CreditosTableAdapter.ConsultaCreditos(Me._CREDEFINDataSet.Creditos)
        Dim nombre As String = "%" & Nombre_s_TextBox.Text & "%"
        Dim apellido As String = "%" & Apellido_s_TextBox.Text & "%"
        Dim codigo As Integer
        Integer.TryParse(CodigoClienteTextBox.Text, codigo)
        Dim numeroIdentidad As String = Numero_IdentidaTextBox.Text
        Dim celular As String = TelefonoTextBox.Text
        Dim telefono As String = TelefonoTextBox.Text

    End Sub
End Class