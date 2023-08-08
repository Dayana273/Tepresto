Public Class FormDetalle

    Private Sub FormDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_CREDEFIN_1_DataSet.Creditos' Puede moverla o quitarla según sea necesario.
        Me.CreditosTableAdapter1.Fill(Me.CredefinDataSet1.Creditos)
        'TODO: esta línea de código carga datos en la tabla '_CREDEFIN_1_DataSet.Pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter1.Fill(Me._CredefinDataSet1.Pagos)

    End Sub


    Private Sub PagosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PagosBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.CredefinDataSet1)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        FormPagos.Show()
        Me.Close()
    End Sub
End Class