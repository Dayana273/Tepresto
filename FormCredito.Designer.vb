<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCredito
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
        Me.components = New System.ComponentModel.Container()
        Dim FomaPagoLabel As System.Windows.Forms.Label
        Dim PlazoLabel1 As System.Windows.Forms.Label
        Dim MontoLabel As System.Windows.Forms.Label
        Dim InteresLabel As System.Windows.Forms.Label
        Dim CantidaddeCuotasLabel As System.Windows.Forms.Label
        Dim ValorCuotaLabel As System.Windows.Forms.Label
        Dim InteresCorrespondienteLabel As System.Windows.Forms.Label
        Dim CuotasPagadasLabel As System.Windows.Forms.Label
        Dim CuotasPendientesLabel As System.Windows.Forms.Label
        Dim SaldoAlVencimientoLabel As System.Windows.Forms.Label
        Dim CapitalPendienteLabel As System.Windows.Forms.Label
        Dim FechaAperturaLabel As System.Windows.Forms.Label
        Dim DiasPagoLabel As System.Windows.Forms.Label
        Dim ProximoPagoLabel As System.Windows.Forms.Label
        Dim CreditoActivoLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCredito))
        Dim CodigoCreditoLabel As System.Windows.Forms.Label
        Dim CodigoClienteLabel As System.Windows.Forms.Label
        Dim Nombre_s_Label As System.Windows.Forms.Label
        Dim Apellido_s_Label As System.Windows.Forms.Label
        Dim Numero_IdentidaLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Me.CmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.TxtPlazo = New System.Windows.Forms.ComboBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.TxtTasaInteres = New System.Windows.Forms.TextBox()
        Me.TxtNumeroCuotas = New System.Windows.Forms.TextBox()
        Me.LblValorCuota = New System.Windows.Forms.TextBox()
        Me.LblInteresPorCuota = New System.Windows.Forms.TextBox()
        Me.CuotasPagadasTextBox = New System.Windows.Forms.TextBox()
        Me.CuotasPendientesTextBox = New System.Windows.Forms.TextBox()
        Me.SaldoAlVencimientoTextBox = New System.Windows.Forms.TextBox()
        Me.CapitalPendienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaAperturaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DiasPagoTextBox = New System.Windows.Forms.TextBox()
        Me.ProximoPagoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CreditoActivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.LbInformacionPrincipal = New System.Windows.Forms.Label()
        Me.LbNuevoCredito = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.CREDEFINDataSet = New Tepresto.CREDEFINDataSet()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosTableAdapter = New Tepresto.CREDEFINDataSetTableAdapters.PagosTableAdapter()
        Me.TableAdapterManager = New Tepresto.CREDEFINDataSetTableAdapters.TableAdapterManager()
        Me.PagosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PagosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CreditosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditosTableAdapter = New Tepresto.CREDEFINDataSetTableAdapters.CreditosTableAdapter()
        Me.CodigoCreditoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Tepresto.CREDEFINDataSetTableAdapters.ClientesTableAdapter()
        Me.Nombre_s_TextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_s_TextBox = New System.Windows.Forms.TextBox()
        Me.Numero_IdentidaTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox1 = New System.Windows.Forms.TextBox()
        FomaPagoLabel = New System.Windows.Forms.Label()
        PlazoLabel1 = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        InteresLabel = New System.Windows.Forms.Label()
        CantidaddeCuotasLabel = New System.Windows.Forms.Label()
        ValorCuotaLabel = New System.Windows.Forms.Label()
        InteresCorrespondienteLabel = New System.Windows.Forms.Label()
        CuotasPagadasLabel = New System.Windows.Forms.Label()
        CuotasPendientesLabel = New System.Windows.Forms.Label()
        SaldoAlVencimientoLabel = New System.Windows.Forms.Label()
        CapitalPendienteLabel = New System.Windows.Forms.Label()
        FechaAperturaLabel = New System.Windows.Forms.Label()
        DiasPagoLabel = New System.Windows.Forms.Label()
        ProximoPagoLabel = New System.Windows.Forms.Label()
        CreditoActivoLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        CodigoCreditoLabel = New System.Windows.Forms.Label()
        CodigoClienteLabel = New System.Windows.Forms.Label()
        Nombre_s_Label = New System.Windows.Forms.Label()
        Apellido_s_Label = New System.Windows.Forms.Label()
        Numero_IdentidaLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        CType(Me.CREDEFINDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PagosBindingNavigator.SuspendLayout()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FomaPagoLabel
        '
        FomaPagoLabel.AutoSize = True
        FomaPagoLabel.Location = New System.Drawing.Point(36, 496)
        FomaPagoLabel.Name = "FomaPagoLabel"
        FomaPagoLabel.Size = New System.Drawing.Size(81, 16)
        FomaPagoLabel.TabIndex = 102
        FomaPagoLabel.Text = "Foma Pago:"
        '
        'PlazoLabel1
        '
        PlazoLabel1.AutoSize = True
        PlazoLabel1.Location = New System.Drawing.Point(38, 382)
        PlazoLabel1.Name = "PlazoLabel1"
        PlazoLabel1.Size = New System.Drawing.Size(44, 16)
        PlazoLabel1.TabIndex = 99
        PlazoLabel1.Text = "Plazo:"
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Location = New System.Drawing.Point(38, 354)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(47, 16)
        MontoLabel.TabIndex = 61
        MontoLabel.Text = "Monto:"
        '
        'InteresLabel
        '
        InteresLabel.AutoSize = True
        InteresLabel.Location = New System.Drawing.Point(51, 468)
        InteresLabel.Name = "InteresLabel"
        InteresLabel.Size = New System.Drawing.Size(50, 16)
        InteresLabel.TabIndex = 63
        InteresLabel.Text = "Interes:"
        '
        'CantidaddeCuotasLabel
        '
        CantidaddeCuotasLabel.AutoSize = True
        CantidaddeCuotasLabel.Location = New System.Drawing.Point(27, 524)
        CantidaddeCuotasLabel.Name = "CantidaddeCuotasLabel"
        CantidaddeCuotasLabel.Size = New System.Drawing.Size(125, 16)
        CantidaddeCuotasLabel.TabIndex = 65
        CantidaddeCuotasLabel.Text = "Cantidadde Cuotas:"
        '
        'ValorCuotaLabel
        '
        ValorCuotaLabel.AutoSize = True
        ValorCuotaLabel.Location = New System.Drawing.Point(61, 546)
        ValorCuotaLabel.Name = "ValorCuotaLabel"
        ValorCuotaLabel.Size = New System.Drawing.Size(80, 16)
        ValorCuotaLabel.TabIndex = 67
        ValorCuotaLabel.Text = "Valor Cuota:"
        '
        'InteresCorrespondienteLabel
        '
        InteresCorrespondienteLabel.AutoSize = True
        InteresCorrespondienteLabel.Location = New System.Drawing.Point(27, 577)
        InteresCorrespondienteLabel.Name = "InteresCorrespondienteLabel"
        InteresCorrespondienteLabel.Size = New System.Drawing.Size(153, 16)
        InteresCorrespondienteLabel.TabIndex = 69
        InteresCorrespondienteLabel.Text = "Interes Correspondiente:"
        '
        'CuotasPagadasLabel
        '
        CuotasPagadasLabel.AutoSize = True
        CuotasPagadasLabel.Location = New System.Drawing.Point(264, 305)
        CuotasPagadasLabel.Name = "CuotasPagadasLabel"
        CuotasPagadasLabel.Size = New System.Drawing.Size(111, 16)
        CuotasPagadasLabel.TabIndex = 71
        CuotasPagadasLabel.Text = "Cuotas Pagadas:"
        '
        'CuotasPendientesLabel
        '
        CuotasPendientesLabel.AutoSize = True
        CuotasPendientesLabel.Location = New System.Drawing.Point(264, 328)
        CuotasPendientesLabel.Name = "CuotasPendientesLabel"
        CuotasPendientesLabel.Size = New System.Drawing.Size(123, 16)
        CuotasPendientesLabel.TabIndex = 73
        CuotasPendientesLabel.Text = "Cuotas Pendientes:"
        '
        'SaldoAlVencimientoLabel
        '
        SaldoAlVencimientoLabel.AutoSize = True
        SaldoAlVencimientoLabel.Location = New System.Drawing.Point(264, 351)
        SaldoAlVencimientoLabel.Name = "SaldoAlVencimientoLabel"
        SaldoAlVencimientoLabel.Size = New System.Drawing.Size(138, 16)
        SaldoAlVencimientoLabel.TabIndex = 75
        SaldoAlVencimientoLabel.Text = "Saldo Al Vencimiento:"
        '
        'CapitalPendienteLabel
        '
        CapitalPendienteLabel.AutoSize = True
        CapitalPendienteLabel.Location = New System.Drawing.Point(271, 376)
        CapitalPendienteLabel.Name = "CapitalPendienteLabel"
        CapitalPendienteLabel.Size = New System.Drawing.Size(116, 16)
        CapitalPendienteLabel.TabIndex = 77
        CapitalPendienteLabel.Text = "Capital Pendiente:"
        '
        'FechaAperturaLabel
        '
        FechaAperturaLabel.AutoSize = True
        FechaAperturaLabel.Location = New System.Drawing.Point(392, 496)
        FechaAperturaLabel.Name = "FechaAperturaLabel"
        FechaAperturaLabel.Size = New System.Drawing.Size(102, 16)
        FechaAperturaLabel.TabIndex = 79
        FechaAperturaLabel.Text = "Fecha Apertura:"
        '
        'DiasPagoLabel
        '
        DiasPagoLabel.AutoSize = True
        DiasPagoLabel.Location = New System.Drawing.Point(392, 524)
        DiasPagoLabel.Name = "DiasPagoLabel"
        DiasPagoLabel.Size = New System.Drawing.Size(74, 16)
        DiasPagoLabel.TabIndex = 81
        DiasPagoLabel.Text = "Dias Pago:"
        '
        'ProximoPagoLabel
        '
        ProximoPagoLabel.AutoSize = True
        ProximoPagoLabel.Location = New System.Drawing.Point(399, 552)
        ProximoPagoLabel.Name = "ProximoPagoLabel"
        ProximoPagoLabel.Size = New System.Drawing.Size(95, 16)
        ProximoPagoLabel.TabIndex = 83
        ProximoPagoLabel.Text = "Proximo Pago:"
        '
        'CreditoActivoLabel
        '
        CreditoActivoLabel.AutoSize = True
        CreditoActivoLabel.Location = New System.Drawing.Point(757, 501)
        CreditoActivoLabel.Name = "CreditoActivoLabel"
        CreditoActivoLabel.Size = New System.Drawing.Size(93, 16)
        CreditoActivoLabel.TabIndex = 85
        CreditoActivoLabel.Text = "Credito Activo:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(746, 558)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(87, 16)
        ObservacionLabel.TabIndex = 87
        ObservacionLabel.Text = "Observacion:"
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.Location = New System.Drawing.Point(179, 488)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(200, 24)
        Me.CmbFormaPago.TabIndex = 103
        '
        'TxtPlazo
        '
        Me.TxtPlazo.FormattingEnabled = True
        Me.TxtPlazo.Location = New System.Drawing.Point(88, 379)
        Me.TxtPlazo.Name = "TxtPlazo"
        Me.TxtPlazo.Size = New System.Drawing.Size(144, 24)
        Me.TxtPlazo.TabIndex = 101
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Gold
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnNuevo.Location = New System.Drawing.Point(665, 63)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(106, 63)
        Me.BtnNuevo.TabIndex = 100
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Gold
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBuscar.Location = New System.Drawing.Point(885, 64)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(111, 62)
        Me.BtnBuscar.TabIndex = 98
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Gold
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnRegresar.Location = New System.Drawing.Point(1002, 63)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(103, 63)
        Me.BtnRegresar.TabIndex = 97
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Gold
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGuardar.Location = New System.Drawing.Point(777, 63)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(102, 63)
        Me.BtnGuardar.TabIndex = 96
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(88, 348)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(144, 22)
        Me.TxtMonto.TabIndex = 62
        '
        'TxtTasaInteres
        '
        Me.TxtTasaInteres.Location = New System.Drawing.Point(179, 462)
        Me.TxtTasaInteres.Name = "TxtTasaInteres"
        Me.TxtTasaInteres.Size = New System.Drawing.Size(200, 22)
        Me.TxtTasaInteres.TabIndex = 64
        '
        'TxtNumeroCuotas
        '
        Me.TxtNumeroCuotas.Location = New System.Drawing.Point(179, 515)
        Me.TxtNumeroCuotas.Name = "TxtNumeroCuotas"
        Me.TxtNumeroCuotas.Size = New System.Drawing.Size(200, 22)
        Me.TxtNumeroCuotas.TabIndex = 66
        '
        'LblValorCuota
        '
        Me.LblValorCuota.Location = New System.Drawing.Point(179, 546)
        Me.LblValorCuota.Name = "LblValorCuota"
        Me.LblValorCuota.Size = New System.Drawing.Size(200, 22)
        Me.LblValorCuota.TabIndex = 68
        '
        'LblInteresPorCuota
        '
        Me.LblInteresPorCuota.Location = New System.Drawing.Point(179, 577)
        Me.LblInteresPorCuota.Name = "LblInteresPorCuota"
        Me.LblInteresPorCuota.Size = New System.Drawing.Size(200, 22)
        Me.LblInteresPorCuota.TabIndex = 70
        '
        'CuotasPagadasTextBox
        '
        Me.CuotasPagadasTextBox.Location = New System.Drawing.Point(402, 294)
        Me.CuotasPagadasTextBox.Name = "CuotasPagadasTextBox"
        Me.CuotasPagadasTextBox.Size = New System.Drawing.Size(133, 22)
        Me.CuotasPagadasTextBox.TabIndex = 72
        '
        'CuotasPendientesTextBox
        '
        Me.CuotasPendientesTextBox.Location = New System.Drawing.Point(402, 322)
        Me.CuotasPendientesTextBox.Name = "CuotasPendientesTextBox"
        Me.CuotasPendientesTextBox.Size = New System.Drawing.Size(133, 22)
        Me.CuotasPendientesTextBox.TabIndex = 74
        '
        'SaldoAlVencimientoTextBox
        '
        Me.SaldoAlVencimientoTextBox.Location = New System.Drawing.Point(402, 348)
        Me.SaldoAlVencimientoTextBox.Name = "SaldoAlVencimientoTextBox"
        Me.SaldoAlVencimientoTextBox.Size = New System.Drawing.Size(133, 22)
        Me.SaldoAlVencimientoTextBox.TabIndex = 76
        '
        'CapitalPendienteTextBox
        '
        Me.CapitalPendienteTextBox.Location = New System.Drawing.Point(402, 373)
        Me.CapitalPendienteTextBox.Name = "CapitalPendienteTextBox"
        Me.CapitalPendienteTextBox.Size = New System.Drawing.Size(133, 22)
        Me.CapitalPendienteTextBox.TabIndex = 78
        '
        'FechaAperturaDateTimePicker
        '
        Me.FechaAperturaDateTimePicker.Location = New System.Drawing.Point(500, 496)
        Me.FechaAperturaDateTimePicker.Name = "FechaAperturaDateTimePicker"
        Me.FechaAperturaDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.FechaAperturaDateTimePicker.TabIndex = 80
        '
        'DiasPagoTextBox
        '
        Me.DiasPagoTextBox.Location = New System.Drawing.Point(500, 521)
        Me.DiasPagoTextBox.Name = "DiasPagoTextBox"
        Me.DiasPagoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DiasPagoTextBox.TabIndex = 82
        '
        'ProximoPagoDateTimePicker
        '
        Me.ProximoPagoDateTimePicker.Location = New System.Drawing.Point(500, 549)
        Me.ProximoPagoDateTimePicker.Name = "ProximoPagoDateTimePicker"
        Me.ProximoPagoDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.ProximoPagoDateTimePicker.TabIndex = 84
        '
        'CreditoActivoCheckBox
        '
        Me.CreditoActivoCheckBox.Location = New System.Drawing.Point(856, 496)
        Me.CreditoActivoCheckBox.Name = "CreditoActivoCheckBox"
        Me.CreditoActivoCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.CreditoActivoCheckBox.TabIndex = 86
        Me.CreditoActivoCheckBox.UseVisualStyleBackColor = True
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.Location = New System.Drawing.Point(870, 552)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ObservacionTextBox.TabIndex = 88
        '
        'LbInformacionPrincipal
        '
        Me.LbInformacionPrincipal.AutoSize = True
        Me.LbInformacionPrincipal.Location = New System.Drawing.Point(38, 247)
        Me.LbInformacionPrincipal.Name = "LbInformacionPrincipal"
        Me.LbInformacionPrincipal.Size = New System.Drawing.Size(131, 16)
        Me.LbInformacionPrincipal.TabIndex = 59
        Me.LbInformacionPrincipal.Text = "Informacion Principal"
        '
        'LbNuevoCredito
        '
        Me.LbNuevoCredito.AutoSize = True
        Me.LbNuevoCredito.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNuevoCredito.Location = New System.Drawing.Point(364, 43)
        Me.LbNuevoCredito.Name = "LbNuevoCredito"
        Me.LbNuevoCredito.Size = New System.Drawing.Size(247, 34)
        Me.LbNuevoCredito.TabIndex = 58
        Me.LbNuevoCredito.Text = "Nuevo Credito"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(54, 283)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(99, 33)
        Me.BtnCalcular.TabIndex = 57
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'CREDEFINDataSet
        '
        Me.CREDEFINDataSet.DataSetName = "CREDEFINDataSet"
        Me.CREDEFINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "Pagos"
        Me.PagosBindingSource.DataSource = Me.CREDEFINDataSet
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CreditosTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Me.PagosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Tepresto.CREDEFINDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PagosBindingNavigator
        '
        Me.PagosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PagosBindingNavigator.BindingSource = Me.PagosBindingSource
        Me.PagosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PagosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PagosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PagosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PagosBindingNavigatorSaveItem})
        Me.PagosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PagosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PagosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PagosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PagosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PagosBindingNavigator.Name = "PagosBindingNavigator"
        Me.PagosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PagosBindingNavigator.Size = New System.Drawing.Size(1165, 27)
        Me.PagosBindingNavigator.TabIndex = 105
        Me.PagosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'PagosBindingNavigatorSaveItem
        '
        Me.PagosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PagosBindingNavigatorSaveItem.Image = CType(resources.GetObject("PagosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PagosBindingNavigatorSaveItem.Name = "PagosBindingNavigatorSaveItem"
        Me.PagosBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.PagosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PagosDataGridView
        '
        Me.PagosDataGridView.AutoGenerateColumns = False
        Me.PagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.PagosDataGridView.DataSource = Me.PagosBindingSource
        Me.PagosDataGridView.Location = New System.Drawing.Point(583, 268)
        Me.PagosDataGridView.Name = "PagosDataGridView"
        Me.PagosDataGridView.RowHeadersWidth = 51
        Me.PagosDataGridView.RowTemplate.Height = 24
        Me.PagosDataGridView.Size = New System.Drawing.Size(546, 190)
        Me.PagosDataGridView.TabIndex = 105
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoPago"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoPago"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CodigoCredito"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CodigoCredito"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaPago"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FechaPago"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ValorCuota"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ValorCuota"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cuotas"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cuotas"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FormaPago"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FormaPago"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Tepresto.My.Resources.Resources.CreditoNuevo
        Me.PictureBox3.Location = New System.Drawing.Point(24, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 96)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 107
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CreditosBindingSource, "CodigoCredito", True))
        Me.PictureBox1.Location = New System.Drawing.Point(24, 234)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1105, 453)
        Me.PictureBox1.TabIndex = 104
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ClientesBindingSource, "Nombre(s)", True))
        Me.PictureBox2.Location = New System.Drawing.Point(24, 132)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1103, 90)
        Me.PictureBox2.TabIndex = 106
        Me.PictureBox2.TabStop = False
        '
        'CreditosBindingSource
        '
        Me.CreditosBindingSource.DataMember = "Creditos"
        Me.CreditosBindingSource.DataSource = Me.CREDEFINDataSet
        '
        'CreditosTableAdapter
        '
        Me.CreditosTableAdapter.ClearBeforeFill = True
        '
        'CodigoCreditoLabel
        '
        CodigoCreditoLabel.AutoSize = True
        CodigoCreditoLabel.Location = New System.Drawing.Point(36, 148)
        CodigoCreditoLabel.Name = "CodigoCreditoLabel"
        CodigoCreditoLabel.Size = New System.Drawing.Size(100, 16)
        CodigoCreditoLabel.TabIndex = 108
        CodigoCreditoLabel.Text = "Codigo Credito:"
        '
        'CodigoCreditoTextBox
        '
        Me.CodigoCreditoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditosBindingSource, "CodigoCredito", True))
        Me.CodigoCreditoTextBox.Location = New System.Drawing.Point(132, 145)
        Me.CodigoCreditoTextBox.Name = "CodigoCreditoTextBox"
        Me.CodigoCreditoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.CodigoCreditoTextBox.TabIndex = 109
        '
        'CodigoClienteLabel
        '
        CodigoClienteLabel.AutoSize = True
        CodigoClienteLabel.Location = New System.Drawing.Point(271, 145)
        CodigoClienteLabel.Name = "CodigoClienteLabel"
        CodigoClienteLabel.Size = New System.Drawing.Size(98, 16)
        CodigoClienteLabel.TabIndex = 109
        CodigoClienteLabel.Text = "Codigo Cliente:"
        '
        'CodigoClienteTextBox
        '
        Me.CodigoClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditosBindingSource, "CodigoCliente", True))
        Me.CodigoClienteTextBox.Location = New System.Drawing.Point(375, 142)
        Me.CodigoClienteTextBox.Name = "CodigoClienteTextBox"
        Me.CodigoClienteTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CodigoClienteTextBox.TabIndex = 110
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.CREDEFINDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Nombre_s_Label
        '
        Nombre_s_Label.AutoSize = True
        Nombre_s_Label.Location = New System.Drawing.Point(36, 189)
        Nombre_s_Label.Name = "Nombre_s_Label"
        Nombre_s_Label.Size = New System.Drawing.Size(74, 16)
        Nombre_s_Label.TabIndex = 110
        Nombre_s_Label.Text = "Nombre(s):"
        '
        'Nombre_s_TextBox
        '
        Me.Nombre_s_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre(s)", True))
        Me.Nombre_s_TextBox.Location = New System.Drawing.Point(132, 186)
        Me.Nombre_s_TextBox.Name = "Nombre_s_TextBox"
        Me.Nombre_s_TextBox.Size = New System.Drawing.Size(132, 22)
        Me.Nombre_s_TextBox.TabIndex = 111
        '
        'Apellido_s_Label
        '
        Apellido_s_Label.AutoSize = True
        Apellido_s_Label.Location = New System.Drawing.Point(271, 186)
        Apellido_s_Label.Name = "Apellido_s_Label"
        Apellido_s_Label.Size = New System.Drawing.Size(75, 16)
        Apellido_s_Label.TabIndex = 111
        Apellido_s_Label.Text = "Apellido(s):"
        '
        'Apellido_s_TextBox
        '
        Me.Apellido_s_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Apellido(s)", True))
        Me.Apellido_s_TextBox.Location = New System.Drawing.Point(375, 183)
        Me.Apellido_s_TextBox.Name = "Apellido_s_TextBox"
        Me.Apellido_s_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Apellido_s_TextBox.TabIndex = 112
        '
        'Numero_IdentidaLabel
        '
        Numero_IdentidaLabel.AutoSize = True
        Numero_IdentidaLabel.Location = New System.Drawing.Point(497, 189)
        Numero_IdentidaLabel.Name = "Numero_IdentidaLabel"
        Numero_IdentidaLabel.Size = New System.Drawing.Size(109, 16)
        Numero_IdentidaLabel.TabIndex = 112
        Numero_IdentidaLabel.Text = "Numero Identida:"
        '
        'Numero_IdentidaTextBox
        '
        Me.Numero_IdentidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Numero_Identida", True))
        Me.Numero_IdentidaTextBox.Location = New System.Drawing.Point(612, 189)
        Me.Numero_IdentidaTextBox.Name = "Numero_IdentidaTextBox"
        Me.Numero_IdentidaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Numero_IdentidaTextBox.TabIndex = 113
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(200, 259)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(64, 16)
        TelefonoLabel.TabIndex = 113
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(270, 256)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TelefonoTextBox.TabIndex = 114
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(497, 148)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(52, 16)
        CelularLabel.TabIndex = 114
        CelularLabel.Text = "Celular:"
        '
        'CelularTextBox1
        '
        Me.CelularTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Celular", True))
        Me.CelularTextBox1.Location = New System.Drawing.Point(612, 142)
        Me.CelularTextBox1.Name = "CelularTextBox1"
        Me.CelularTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.CelularTextBox1.TabIndex = 115
        '
        'FormCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 699)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox1)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Numero_IdentidaLabel)
        Me.Controls.Add(Me.Numero_IdentidaTextBox)
        Me.Controls.Add(Apellido_s_Label)
        Me.Controls.Add(Me.Apellido_s_TextBox)
        Me.Controls.Add(Nombre_s_Label)
        Me.Controls.Add(Me.Nombre_s_TextBox)
        Me.Controls.Add(CodigoClienteLabel)
        Me.Controls.Add(Me.CodigoClienteTextBox)
        Me.Controls.Add(CodigoCreditoLabel)
        Me.Controls.Add(Me.CodigoCreditoTextBox)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PagosDataGridView)
        Me.Controls.Add(Me.PagosBindingNavigator)
        Me.Controls.Add(FomaPagoLabel)
        Me.Controls.Add(Me.CmbFormaPago)
        Me.Controls.Add(PlazoLabel1)
        Me.Controls.Add(Me.TxtPlazo)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(MontoLabel)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(InteresLabel)
        Me.Controls.Add(Me.TxtTasaInteres)
        Me.Controls.Add(CantidaddeCuotasLabel)
        Me.Controls.Add(Me.TxtNumeroCuotas)
        Me.Controls.Add(ValorCuotaLabel)
        Me.Controls.Add(Me.LblValorCuota)
        Me.Controls.Add(InteresCorrespondienteLabel)
        Me.Controls.Add(Me.LblInteresPorCuota)
        Me.Controls.Add(CuotasPagadasLabel)
        Me.Controls.Add(Me.CuotasPagadasTextBox)
        Me.Controls.Add(CuotasPendientesLabel)
        Me.Controls.Add(Me.CuotasPendientesTextBox)
        Me.Controls.Add(SaldoAlVencimientoLabel)
        Me.Controls.Add(Me.SaldoAlVencimientoTextBox)
        Me.Controls.Add(CapitalPendienteLabel)
        Me.Controls.Add(Me.CapitalPendienteTextBox)
        Me.Controls.Add(FechaAperturaLabel)
        Me.Controls.Add(Me.FechaAperturaDateTimePicker)
        Me.Controls.Add(DiasPagoLabel)
        Me.Controls.Add(Me.DiasPagoTextBox)
        Me.Controls.Add(ProximoPagoLabel)
        Me.Controls.Add(Me.ProximoPagoDateTimePicker)
        Me.Controls.Add(CreditoActivoLabel)
        Me.Controls.Add(Me.CreditoActivoCheckBox)
        Me.Controls.Add(ObservacionLabel)
        Me.Controls.Add(Me.ObservacionTextBox)
        Me.Controls.Add(Me.LbInformacionPrincipal)
        Me.Controls.Add(Me.LbNuevoCredito)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCredito"
        Me.Text = "FormCredito"
        CType(Me.CREDEFINDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PagosBindingNavigator.ResumeLayout(False)
        Me.PagosBindingNavigator.PerformLayout()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbFormaPago As ComboBox
    Friend WithEvents TxtPlazo As ComboBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents TxtTasaInteres As TextBox
    Friend WithEvents TxtNumeroCuotas As TextBox
    Friend WithEvents LblValorCuota As TextBox
    Friend WithEvents LblInteresPorCuota As TextBox
    Friend WithEvents CuotasPagadasTextBox As TextBox
    Friend WithEvents CuotasPendientesTextBox As TextBox
    Friend WithEvents SaldoAlVencimientoTextBox As TextBox
    Friend WithEvents CapitalPendienteTextBox As TextBox
    Friend WithEvents FechaAperturaDateTimePicker As DateTimePicker
    Friend WithEvents DiasPagoTextBox As TextBox
    Friend WithEvents ProximoPagoDateTimePicker As DateTimePicker
    Friend WithEvents CreditoActivoCheckBox As CheckBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents LbInformacionPrincipal As Label
    Friend WithEvents LbNuevoCredito As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CREDEFINDataSet As CREDEFINDataSet
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents PagosTableAdapter As CREDEFINDataSetTableAdapters.PagosTableAdapter
    Friend WithEvents TableAdapterManager As CREDEFINDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PagosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PagosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PagosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents CreditosBindingSource As BindingSource
    Friend WithEvents CreditosTableAdapter As CREDEFINDataSetTableAdapters.CreditosTableAdapter
    Friend WithEvents CodigoCreditoTextBox As TextBox
    Friend WithEvents CodigoClienteTextBox As TextBox
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As CREDEFINDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents Nombre_s_TextBox As TextBox
    Friend WithEvents Apellido_s_TextBox As TextBox
    Friend WithEvents Numero_IdentidaTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CelularTextBox1 As TextBox
End Class
