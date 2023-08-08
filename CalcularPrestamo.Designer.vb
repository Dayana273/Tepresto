<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcularPrestamo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Monto_CantidadLabel As System.Windows.Forms.Label
        Dim PlazoLabel As System.Windows.Forms.Label
        Dim Tasa_de_InteresLabel As System.Windows.Forms.Label
        Dim Forma_de_PagoLabel As System.Windows.Forms.Label
        Dim Numero_de_cuotasLabel As System.Windows.Forms.Label
        Dim Valor_de_la_cuotaLabel As System.Windows.Forms.Label
        Dim Interes_por_cuotaLabel As System.Windows.Forms.Label
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.TxtPlazo = New System.Windows.Forms.ComboBox()
        Me.BtnListo = New System.Windows.Forms.Button()
        Me.BtnCalcu = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.TxtTasaInteres = New System.Windows.Forms.TextBox()
        Me.TxtNumeroCuotas = New System.Windows.Forms.TextBox()
        Me.LblValorCuota = New System.Windows.Forms.TextBox()
        Me.LblInteresPorCuota = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Monto_CantidadLabel = New System.Windows.Forms.Label()
        PlazoLabel = New System.Windows.Forms.Label()
        Tasa_de_InteresLabel = New System.Windows.Forms.Label()
        Forma_de_PagoLabel = New System.Windows.Forms.Label()
        Numero_de_cuotasLabel = New System.Windows.Forms.Label()
        Valor_de_la_cuotaLabel = New System.Windows.Forms.Label()
        Interes_por_cuotaLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Monto_CantidadLabel
        '
        Monto_CantidadLabel.AutoSize = True
        Monto_CantidadLabel.Location = New System.Drawing.Point(120, 189)
        Monto_CantidadLabel.Name = "Monto_CantidadLabel"
        Monto_CantidadLabel.Size = New System.Drawing.Size(105, 16)
        Monto_CantidadLabel.TabIndex = 44
        Monto_CantidadLabel.Text = "Monto/Cantidad:"
        '
        'PlazoLabel
        '
        PlazoLabel.AutoSize = True
        PlazoLabel.Location = New System.Drawing.Point(120, 217)
        PlazoLabel.Name = "PlazoLabel"
        PlazoLabel.Size = New System.Drawing.Size(44, 16)
        PlazoLabel.TabIndex = 46
        PlazoLabel.Text = "Plazo:"
        '
        'Tasa_de_InteresLabel
        '
        Tasa_de_InteresLabel.AutoSize = True
        Tasa_de_InteresLabel.Location = New System.Drawing.Point(120, 245)
        Tasa_de_InteresLabel.Name = "Tasa_de_InteresLabel"
        Tasa_de_InteresLabel.Size = New System.Drawing.Size(104, 16)
        Tasa_de_InteresLabel.TabIndex = 47
        Tasa_de_InteresLabel.Text = "Tasa de Interes:"
        '
        'Forma_de_PagoLabel
        '
        Forma_de_PagoLabel.AutoSize = True
        Forma_de_PagoLabel.Location = New System.Drawing.Point(120, 273)
        Forma_de_PagoLabel.Name = "Forma_de_PagoLabel"
        Forma_de_PagoLabel.Size = New System.Drawing.Size(104, 16)
        Forma_de_PagoLabel.TabIndex = 49
        Forma_de_PagoLabel.Text = "Forma de Pago:"
        '
        'Numero_de_cuotasLabel
        '
        Numero_de_cuotasLabel.AutoSize = True
        Numero_de_cuotasLabel.Location = New System.Drawing.Point(120, 301)
        Numero_de_cuotasLabel.Name = "Numero_de_cuotasLabel"
        Numero_de_cuotasLabel.Size = New System.Drawing.Size(120, 16)
        Numero_de_cuotasLabel.TabIndex = 50
        Numero_de_cuotasLabel.Text = "Numero de cuotas:"
        '
        'Valor_de_la_cuotaLabel
        '
        Valor_de_la_cuotaLabel.AutoSize = True
        Valor_de_la_cuotaLabel.Location = New System.Drawing.Point(120, 329)
        Valor_de_la_cuotaLabel.Name = "Valor_de_la_cuotaLabel"
        Valor_de_la_cuotaLabel.Size = New System.Drawing.Size(121, 16)
        Valor_de_la_cuotaLabel.TabIndex = 52
        Valor_de_la_cuotaLabel.Text = "Valor de la cuota L."
        '
        'Interes_por_cuotaLabel
        '
        Interes_por_cuotaLabel.AutoSize = True
        Interes_por_cuotaLabel.Location = New System.Drawing.Point(120, 357)
        Interes_por_cuotaLabel.Name = "Interes_por_cuotaLabel"
        Interes_por_cuotaLabel.Size = New System.Drawing.Size(119, 16)
        Interes_por_cuotaLabel.TabIndex = 54
        Interes_por_cuotaLabel.Text = "Interes por cuota L."
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Font = New System.Drawing.Font("Algerian", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3.Location = New System.Drawing.Point(142, 55)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(267, 25)
        Me.Lbl3.TabIndex = 63
        Me.Lbl3.Text = "Calcular Prestamo"
        '
        'TxtPlazo
        '
        Me.TxtPlazo.FormattingEnabled = True
        Me.TxtPlazo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.TxtPlazo.Location = New System.Drawing.Point(246, 214)
        Me.TxtPlazo.Name = "TxtPlazo"
        Me.TxtPlazo.Size = New System.Drawing.Size(138, 24)
        Me.TxtPlazo.TabIndex = 62
        '
        'BtnListo
        '
        Me.BtnListo.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnListo.Location = New System.Drawing.Point(156, 431)
        Me.BtnListo.Name = "BtnListo"
        Me.BtnListo.Size = New System.Drawing.Size(112, 59)
        Me.BtnListo.TabIndex = 61
        Me.BtnListo.Text = "Guardar"
        Me.BtnListo.UseVisualStyleBackColor = False
        '
        'BtnCalcu
        '
        Me.BtnCalcu.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnCalcu.Location = New System.Drawing.Point(32, 431)
        Me.BtnCalcu.Name = "BtnCalcu"
        Me.BtnCalcu.Size = New System.Drawing.Size(102, 59)
        Me.BtnCalcu.TabIndex = 60
        Me.BtnCalcu.Text = "Calcular"
        Me.BtnCalcu.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnEliminar.Location = New System.Drawing.Point(289, 431)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(120, 59)
        Me.BtnEliminar.TabIndex = 59
        Me.BtnEliminar.Text = "Regresar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(390, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 16)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "%"
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.Items.AddRange(New Object() {"Semanal", "Quincenal", "Mensual"})
        Me.CmbFormaPago.Location = New System.Drawing.Point(246, 273)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(138, 24)
        Me.CmbFormaPago.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(390, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Meses"
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(246, 186)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(138, 22)
        Me.TxtMonto.TabIndex = 45
        '
        'TxtTasaInteres
        '
        Me.TxtTasaInteres.Location = New System.Drawing.Point(246, 242)
        Me.TxtTasaInteres.Name = "TxtTasaInteres"
        Me.TxtTasaInteres.Size = New System.Drawing.Size(138, 22)
        Me.TxtTasaInteres.TabIndex = 48
        '
        'TxtNumeroCuotas
        '
        Me.TxtNumeroCuotas.Location = New System.Drawing.Point(246, 303)
        Me.TxtNumeroCuotas.Name = "TxtNumeroCuotas"
        Me.TxtNumeroCuotas.Size = New System.Drawing.Size(138, 22)
        Me.TxtNumeroCuotas.TabIndex = 51
        '
        'LblValorCuota
        '
        Me.LblValorCuota.Location = New System.Drawing.Point(246, 326)
        Me.LblValorCuota.Name = "LblValorCuota"
        Me.LblValorCuota.Size = New System.Drawing.Size(138, 22)
        Me.LblValorCuota.TabIndex = 53
        '
        'LblInteresPorCuota
        '
        Me.LblInteresPorCuota.Location = New System.Drawing.Point(246, 354)
        Me.LblInteresPorCuota.Name = "LblInteresPorCuota"
        Me.LblInteresPorCuota.Size = New System.Drawing.Size(138, 22)
        Me.LblInteresPorCuota.TabIndex = 55
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.Tepresto.My.Resources.Resources.Calculadora
        Me.PictureBox1.Location = New System.Drawing.Point(12, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'CalcularPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 517)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.TxtPlazo)
        Me.Controls.Add(Me.BtnListo)
        Me.Controls.Add(Me.BtnCalcu)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbFormaPago)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Monto_CantidadLabel)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(PlazoLabel)
        Me.Controls.Add(Tasa_de_InteresLabel)
        Me.Controls.Add(Me.TxtTasaInteres)
        Me.Controls.Add(Forma_de_PagoLabel)
        Me.Controls.Add(Numero_de_cuotasLabel)
        Me.Controls.Add(Me.TxtNumeroCuotas)
        Me.Controls.Add(Valor_de_la_cuotaLabel)
        Me.Controls.Add(Me.LblValorCuota)
        Me.Controls.Add(Interes_por_cuotaLabel)
        Me.Controls.Add(Me.LblInteresPorCuota)
        Me.Name = "CalcularPrestamo"
        Me.Text = "CalcularPrestamo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl3 As Label
    Friend WithEvents TxtPlazo As ComboBox
    Friend WithEvents BtnListo As Button
    Friend WithEvents BtnCalcu As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbFormaPago As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents TxtTasaInteres As TextBox
    Friend WithEvents TxtNumeroCuotas As TextBox
    Friend WithEvents LblValorCuota As TextBox
    Friend WithEvents LblInteresPorCuota As TextBox
End Class
