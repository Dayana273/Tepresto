<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagos
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
        Dim CelularLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim Nombre_s_Label As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim ProximoPagoLabel As System.Windows.Forms.Label
        Dim SaldoAlVencimientoLabel As System.Windows.Forms.Label
        Dim CuotasPendientesLabel As System.Windows.Forms.Label
        Dim CuotasPagadasLabel As System.Windows.Forms.Label
        Dim DiasPagoLabel As System.Windows.Forms.Label
        Dim FomaPagoLabel As System.Windows.Forms.Label
        Dim InteresLabbel1 As System.Windows.Forms.Label
        Dim InteresLabel As System.Windows.Forms.Label
        Dim FechaAperturaLabel As System.Windows.Forms.Label
        Dim ValorCuotaLabel As System.Windows.Forms.Label
        Dim PlazoLabel As System.Windows.Forms.Label
        Dim CantidaddeCuotasLabel As System.Windows.Forms.Label
        Dim MontoLabel As System.Windows.Forms.Label
        Dim CodigoClienteLabel As System.Windows.Forms.Label
        Dim CodigoCreditoLabel As System.Windows.Forms.Label
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.BtnVerRecibo = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_s_TextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.ProximoPagoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SaldoAlVencimientoTextBox = New System.Windows.Forms.TextBox()
        Me.CuotasPendientesTextBox = New System.Windows.Forms.TextBox()
        Me.CuotasPagadasTextBox = New System.Windows.Forms.TextBox()
        Me.DiasPagoTextBox = New System.Windows.Forms.TextBox()
        Me.FomaPagoComboBox = New System.Windows.Forms.ComboBox()
        Me.InteresTextBox1 = New System.Windows.Forms.TextBox()
        Me.InteresTextBox = New System.Windows.Forms.TextBox()
        Me.FechaAperturaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ValorCuotaTextBox = New System.Windows.Forms.TextBox()
        Me.PlazoComboBox = New System.Windows.Forms.ComboBox()
        Me.CantidaddeCuotasTextBox = New System.Windows.Forms.TextBox()
        Me.MontoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoCreditoTextBox = New System.Windows.Forms.TextBox()
        Me.LblPagos = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Nombre_s_Label = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        ProximoPagoLabel = New System.Windows.Forms.Label()
        SaldoAlVencimientoLabel = New System.Windows.Forms.Label()
        CuotasPendientesLabel = New System.Windows.Forms.Label()
        CuotasPagadasLabel = New System.Windows.Forms.Label()
        DiasPagoLabel = New System.Windows.Forms.Label()
        FomaPagoLabel = New System.Windows.Forms.Label()
        InteresLabbel1 = New System.Windows.Forms.Label()
        InteresLabel = New System.Windows.Forms.Label()
        FechaAperturaLabel = New System.Windows.Forms.Label()
        ValorCuotaLabel = New System.Windows.Forms.Label()
        PlazoLabel = New System.Windows.Forms.Label()
        CantidaddeCuotasLabel = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        CodigoClienteLabel = New System.Windows.Forms.Label()
        CodigoCreditoLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(593, 202)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(52, 16)
        CelularLabel.TabIndex = 90
        CelularLabel.Text = "Celular:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(407, 199)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(64, 16)
        TelefonoLabel.TabIndex = 88
        TelefonoLabel.Text = "Telefono:"
        '
        'Nombre_s_Label
        '
        Nombre_s_Label.AutoSize = True
        Nombre_s_Label.Location = New System.Drawing.Point(57, 199)
        Nombre_s_Label.Name = "Nombre_s_Label"
        Nombre_s_Label.Size = New System.Drawing.Size(74, 16)
        Nombre_s_Label.TabIndex = 86
        Nombre_s_Label.Text = "Nombre(s):"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(467, 509)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(87, 16)
        ObservacionLabel.TabIndex = 84
        ObservacionLabel.Text = "Observacion:"
        '
        'ProximoPagoLabel
        '
        ProximoPagoLabel.AutoSize = True
        ProximoPagoLabel.Location = New System.Drawing.Point(467, 445)
        ProximoPagoLabel.Name = "ProximoPagoLabel"
        ProximoPagoLabel.Size = New System.Drawing.Size(95, 16)
        ProximoPagoLabel.TabIndex = 82
        ProximoPagoLabel.Text = "Proximo Pago:"
        '
        'SaldoAlVencimientoLabel
        '
        SaldoAlVencimientoLabel.AutoSize = True
        SaldoAlVencimientoLabel.Location = New System.Drawing.Point(36, 493)
        SaldoAlVencimientoLabel.Name = "SaldoAlVencimientoLabel"
        SaldoAlVencimientoLabel.Size = New System.Drawing.Size(138, 16)
        SaldoAlVencimientoLabel.TabIndex = 80
        SaldoAlVencimientoLabel.Text = "Saldo Al Vencimiento:"
        '
        'CuotasPendientesLabel
        '
        CuotasPendientesLabel.AutoSize = True
        CuotasPendientesLabel.Location = New System.Drawing.Point(37, 463)
        CuotasPendientesLabel.Name = "CuotasPendientesLabel"
        CuotasPendientesLabel.Size = New System.Drawing.Size(123, 16)
        CuotasPendientesLabel.TabIndex = 78
        CuotasPendientesLabel.Text = "Cuotas Pendientes:"
        '
        'CuotasPagadasLabel
        '
        CuotasPagadasLabel.AutoSize = True
        CuotasPagadasLabel.Location = New System.Drawing.Point(37, 439)
        CuotasPagadasLabel.Name = "CuotasPagadasLabel"
        CuotasPagadasLabel.Size = New System.Drawing.Size(111, 16)
        CuotasPagadasLabel.TabIndex = 76
        CuotasPagadasLabel.Text = "Cuotas Pagadas:"
        '
        'DiasPagoLabel
        '
        DiasPagoLabel.AutoSize = True
        DiasPagoLabel.Location = New System.Drawing.Point(671, 360)
        DiasPagoLabel.Name = "DiasPagoLabel"
        DiasPagoLabel.Size = New System.Drawing.Size(74, 16)
        DiasPagoLabel.TabIndex = 74
        DiasPagoLabel.Text = "Dias Pago:"
        '
        'FomaPagoLabel
        '
        FomaPagoLabel.AutoSize = True
        FomaPagoLabel.Location = New System.Drawing.Point(664, 316)
        FomaPagoLabel.Name = "FomaPagoLabel"
        FomaPagoLabel.Size = New System.Drawing.Size(81, 16)
        FomaPagoLabel.TabIndex = 72
        FomaPagoLabel.Text = "Foma Pago:"
        '
        'InteresLabbel1
        '
        InteresLabbel1.AutoSize = True
        InteresLabbel1.Location = New System.Drawing.Point(433, 357)
        InteresLabbel1.Name = "InteresLabbel1"
        InteresLabbel1.Size = New System.Drawing.Size(94, 16)
        InteresLabbel1.TabIndex = 70
        InteresLabbel1.Text = "Interes x Cuota"
        '
        'InteresLabel
        '
        InteresLabel.AutoSize = True
        InteresLabel.Location = New System.Drawing.Point(467, 313)
        InteresLabel.Name = "InteresLabel"
        InteresLabel.Size = New System.Drawing.Size(50, 16)
        InteresLabel.TabIndex = 68
        InteresLabel.Text = "Interes:"
        '
        'FechaAperturaLabel
        '
        FechaAperturaLabel.AutoSize = True
        FechaAperturaLabel.Location = New System.Drawing.Point(484, 162)
        FechaAperturaLabel.Name = "FechaAperturaLabel"
        FechaAperturaLabel.Size = New System.Drawing.Size(102, 16)
        FechaAperturaLabel.TabIndex = 66
        FechaAperturaLabel.Text = "Fecha Apertura:"
        '
        'ValorCuotaLabel
        '
        ValorCuotaLabel.AutoSize = True
        ValorCuotaLabel.Location = New System.Drawing.Point(221, 354)
        ValorCuotaLabel.Name = "ValorCuotaLabel"
        ValorCuotaLabel.Size = New System.Drawing.Size(80, 16)
        ValorCuotaLabel.TabIndex = 64
        ValorCuotaLabel.Text = "Valor Cuota:"
        '
        'PlazoLabel
        '
        PlazoLabel.AutoSize = True
        PlazoLabel.Location = New System.Drawing.Point(236, 305)
        PlazoLabel.Name = "PlazoLabel"
        PlazoLabel.Size = New System.Drawing.Size(44, 16)
        PlazoLabel.TabIndex = 62
        PlazoLabel.Text = "Plazo:"
        '
        'CantidaddeCuotasLabel
        '
        CantidaddeCuotasLabel.AutoSize = True
        CantidaddeCuotasLabel.Location = New System.Drawing.Point(33, 348)
        CantidaddeCuotasLabel.Name = "CantidaddeCuotasLabel"
        CantidaddeCuotasLabel.Size = New System.Drawing.Size(59, 16)
        CantidaddeCuotasLabel.TabIndex = 60
        CantidaddeCuotasLabel.Text = "# Cuotas"
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Location = New System.Drawing.Point(33, 305)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(47, 16)
        MontoLabel.TabIndex = 58
        MontoLabel.Text = "Monto:"
        '
        'CodigoClienteLabel
        '
        CodigoClienteLabel.AutoSize = True
        CodigoClienteLabel.Location = New System.Drawing.Point(264, 164)
        CodigoClienteLabel.Name = "CodigoClienteLabel"
        CodigoClienteLabel.Size = New System.Drawing.Size(98, 16)
        CodigoClienteLabel.TabIndex = 56
        CodigoClienteLabel.Text = "Codigo Cliente:"
        '
        'CodigoCreditoLabel
        '
        CodigoCreditoLabel.AutoSize = True
        CodigoCreditoLabel.Location = New System.Drawing.Point(47, 165)
        CodigoCreditoLabel.Name = "CodigoCreditoLabel"
        CodigoCreditoLabel.Size = New System.Drawing.Size(100, 16)
        CodigoCreditoLabel.TabIndex = 54
        CodigoCreditoLabel.Text = "Codigo Credito:"
        '
        'BtnAtras
        '
        Me.BtnAtras.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtras.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAtras.Location = New System.Drawing.Point(520, 581)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(147, 124)
        Me.BtnAtras.TabIndex = 93
        Me.BtnAtras.Text = "<-Regresar"
        Me.BtnAtras.UseVisualStyleBackColor = False
        '
        'BtnVerRecibo
        '
        Me.BtnVerRecibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVerRecibo.Image = Global.Tepresto.My.Resources.Resources.pagos
        Me.BtnVerRecibo.Location = New System.Drawing.Point(346, 581)
        Me.BtnVerRecibo.Name = "BtnVerRecibo"
        Me.BtnVerRecibo.Size = New System.Drawing.Size(125, 124)
        Me.BtnVerRecibo.TabIndex = 99
        Me.BtnVerRecibo.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(259, 196)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 22)
        Me.TextBox1.TabIndex = 92
        '
        'CelularTextBox
        '
        Me.CelularTextBox.Location = New System.Drawing.Point(651, 199)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CelularTextBox.TabIndex = 91
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(477, 196)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TelefonoTextBox.TabIndex = 89
        '
        'Nombre_s_TextBox
        '
        Me.Nombre_s_TextBox.Location = New System.Drawing.Point(153, 196)
        Me.Nombre_s_TextBox.Name = "Nombre_s_TextBox"
        Me.Nombre_s_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Nombre_s_TextBox.TabIndex = 87
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.Location = New System.Drawing.Point(572, 503)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(383, 22)
        Me.ObservacionTextBox.TabIndex = 85
        '
        'ProximoPagoDateTimePicker
        '
        Me.ProximoPagoDateTimePicker.Location = New System.Drawing.Point(583, 439)
        Me.ProximoPagoDateTimePicker.Name = "ProximoPagoDateTimePicker"
        Me.ProximoPagoDateTimePicker.Size = New System.Drawing.Size(251, 22)
        Me.ProximoPagoDateTimePicker.TabIndex = 83
        '
        'SaldoAlVencimientoTextBox
        '
        Me.SaldoAlVencimientoTextBox.Location = New System.Drawing.Point(180, 487)
        Me.SaldoAlVencimientoTextBox.Name = "SaldoAlVencimientoTextBox"
        Me.SaldoAlVencimientoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SaldoAlVencimientoTextBox.TabIndex = 81
        '
        'CuotasPendientesTextBox
        '
        Me.CuotasPendientesTextBox.Location = New System.Drawing.Point(180, 460)
        Me.CuotasPendientesTextBox.Name = "CuotasPendientesTextBox"
        Me.CuotasPendientesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CuotasPendientesTextBox.TabIndex = 79
        '
        'CuotasPagadasTextBox
        '
        Me.CuotasPagadasTextBox.Location = New System.Drawing.Point(180, 436)
        Me.CuotasPagadasTextBox.Name = "CuotasPagadasTextBox"
        Me.CuotasPagadasTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CuotasPagadasTextBox.TabIndex = 77
        '
        'DiasPagoTextBox
        '
        Me.DiasPagoTextBox.Location = New System.Drawing.Point(751, 357)
        Me.DiasPagoTextBox.Name = "DiasPagoTextBox"
        Me.DiasPagoTextBox.Size = New System.Drawing.Size(124, 22)
        Me.DiasPagoTextBox.TabIndex = 75
        '
        'FomaPagoComboBox
        '
        Me.FomaPagoComboBox.FormattingEnabled = True
        Me.FomaPagoComboBox.Location = New System.Drawing.Point(754, 313)
        Me.FomaPagoComboBox.Name = "FomaPagoComboBox"
        Me.FomaPagoComboBox.Size = New System.Drawing.Size(121, 24)
        Me.FomaPagoComboBox.TabIndex = 73
        '
        'InteresTextBox1
        '
        Me.InteresTextBox1.Location = New System.Drawing.Point(545, 351)
        Me.InteresTextBox1.Name = "InteresTextBox1"
        Me.InteresTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.InteresTextBox1.TabIndex = 71
        '
        'InteresTextBox
        '
        Me.InteresTextBox.Location = New System.Drawing.Point(545, 302)
        Me.InteresTextBox.Name = "InteresTextBox"
        Me.InteresTextBox.Size = New System.Drawing.Size(100, 22)
        Me.InteresTextBox.TabIndex = 69
        '
        'FechaAperturaDateTimePicker
        '
        Me.FechaAperturaDateTimePicker.Location = New System.Drawing.Point(592, 158)
        Me.FechaAperturaDateTimePicker.Name = "FechaAperturaDateTimePicker"
        Me.FechaAperturaDateTimePicker.Size = New System.Drawing.Size(268, 22)
        Me.FechaAperturaDateTimePicker.TabIndex = 67
        '
        'ValorCuotaTextBox
        '
        Me.ValorCuotaTextBox.Location = New System.Drawing.Point(307, 348)
        Me.ValorCuotaTextBox.Name = "ValorCuotaTextBox"
        Me.ValorCuotaTextBox.Size = New System.Drawing.Size(111, 22)
        Me.ValorCuotaTextBox.TabIndex = 65
        '
        'PlazoComboBox
        '
        Me.PlazoComboBox.FormattingEnabled = True
        Me.PlazoComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.PlazoComboBox.Location = New System.Drawing.Point(297, 300)
        Me.PlazoComboBox.Name = "PlazoComboBox"
        Me.PlazoComboBox.Size = New System.Drawing.Size(121, 24)
        Me.PlazoComboBox.TabIndex = 63
        '
        'CantidaddeCuotasTextBox
        '
        Me.CantidaddeCuotasTextBox.Location = New System.Drawing.Point(109, 348)
        Me.CantidaddeCuotasTextBox.Name = "CantidaddeCuotasTextBox"
        Me.CantidaddeCuotasTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CantidaddeCuotasTextBox.TabIndex = 61
        '
        'MontoTextBox
        '
        Me.MontoTextBox.Location = New System.Drawing.Point(109, 302)
        Me.MontoTextBox.Name = "MontoTextBox"
        Me.MontoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MontoTextBox.TabIndex = 59
        '
        'CodigoClienteTextBox
        '
        Me.CodigoClienteTextBox.Location = New System.Drawing.Point(378, 161)
        Me.CodigoClienteTextBox.Name = "CodigoClienteTextBox"
        Me.CodigoClienteTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CodigoClienteTextBox.TabIndex = 57
        '
        'CodigoCreditoTextBox
        '
        Me.CodigoCreditoTextBox.Location = New System.Drawing.Point(153, 162)
        Me.CodigoCreditoTextBox.Name = "CodigoCreditoTextBox"
        Me.CodigoCreditoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CodigoCreditoTextBox.TabIndex = 55
        '
        'LblPagos
        '
        Me.LblPagos.AutoSize = True
        Me.LblPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPagos.Location = New System.Drawing.Point(224, -39)
        Me.LblPagos.Name = "LblPagos"
        Me.LblPagos.Size = New System.Drawing.Size(199, 29)
        Me.LblPagos.TabIndex = 53
        Me.LblPagos.Text = "Pago de Cuotas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tepresto.My.Resources.Resources.Pagos2
        Me.PictureBox1.Location = New System.Drawing.Point(26, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(30, 140)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(938, 122)
        Me.PictureBox2.TabIndex = 95
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(30, 288)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(938, 121)
        Me.PictureBox3.TabIndex = 96
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(30, 415)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(252, 162)
        Me.PictureBox4.TabIndex = 97
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.IndianRed
        Me.PictureBox5.Location = New System.Drawing.Point(361, 406)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(607, 153)
        Me.PictureBox5.TabIndex = 98
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(430, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 31)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Pago de Cuotas"
        '
        'FormPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 707)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnVerRecibo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Nombre_s_Label)
        Me.Controls.Add(Me.Nombre_s_TextBox)
        Me.Controls.Add(ObservacionLabel)
        Me.Controls.Add(Me.ObservacionTextBox)
        Me.Controls.Add(ProximoPagoLabel)
        Me.Controls.Add(Me.ProximoPagoDateTimePicker)
        Me.Controls.Add(SaldoAlVencimientoLabel)
        Me.Controls.Add(Me.SaldoAlVencimientoTextBox)
        Me.Controls.Add(CuotasPendientesLabel)
        Me.Controls.Add(Me.CuotasPendientesTextBox)
        Me.Controls.Add(CuotasPagadasLabel)
        Me.Controls.Add(Me.CuotasPagadasTextBox)
        Me.Controls.Add(DiasPagoLabel)
        Me.Controls.Add(Me.DiasPagoTextBox)
        Me.Controls.Add(FomaPagoLabel)
        Me.Controls.Add(Me.FomaPagoComboBox)
        Me.Controls.Add(InteresLabbel1)
        Me.Controls.Add(Me.InteresTextBox1)
        Me.Controls.Add(InteresLabel)
        Me.Controls.Add(Me.InteresTextBox)
        Me.Controls.Add(FechaAperturaLabel)
        Me.Controls.Add(Me.FechaAperturaDateTimePicker)
        Me.Controls.Add(ValorCuotaLabel)
        Me.Controls.Add(Me.ValorCuotaTextBox)
        Me.Controls.Add(PlazoLabel)
        Me.Controls.Add(Me.PlazoComboBox)
        Me.Controls.Add(CantidaddeCuotasLabel)
        Me.Controls.Add(Me.CantidaddeCuotasTextBox)
        Me.Controls.Add(MontoLabel)
        Me.Controls.Add(Me.MontoTextBox)
        Me.Controls.Add(CodigoClienteLabel)
        Me.Controls.Add(Me.CodigoClienteTextBox)
        Me.Controls.Add(CodigoCreditoLabel)
        Me.Controls.Add(Me.CodigoCreditoTextBox)
        Me.Controls.Add(Me.LblPagos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Name = "FormPagos"
        Me.Text = "FormPagos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAtras As Button
    Friend WithEvents BtnVerRecibo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CelularTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents Nombre_s_TextBox As TextBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents ProximoPagoDateTimePicker As DateTimePicker
    Friend WithEvents SaldoAlVencimientoTextBox As TextBox
    Friend WithEvents CuotasPendientesTextBox As TextBox
    Friend WithEvents CuotasPagadasTextBox As TextBox
    Friend WithEvents DiasPagoTextBox As TextBox
    Friend WithEvents FomaPagoComboBox As ComboBox
    Friend WithEvents InteresTextBox1 As TextBox
    Friend WithEvents InteresTextBox As TextBox
    Friend WithEvents FechaAperturaDateTimePicker As DateTimePicker
    Friend WithEvents ValorCuotaTextBox As TextBox
    Friend WithEvents PlazoComboBox As ComboBox
    Friend WithEvents CantidaddeCuotasTextBox As TextBox
    Friend WithEvents MontoTextBox As TextBox
    Friend WithEvents CodigoClienteTextBox As TextBox
    Friend WithEvents CodigoCreditoTextBox As TextBox
    Friend WithEvents LblPagos As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
End Class
