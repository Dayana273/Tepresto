<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
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
        Dim NacionalidadLabel As System.Windows.Forms.Label
        Dim Tipo_IdentidadLabel As System.Windows.Forms.Label
        Dim EstadoCivilLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim CodigoClienteLabel As System.Windows.Forms.Label
        Dim Nombre_s_Label As System.Windows.Forms.Label
        Dim Apellido_s_Label As System.Windows.Forms.Label
        Dim Numero_IdentidaLabel As System.Windows.Forms.Label
        Dim FechaNacimientoLabel As System.Windows.Forms.Label
        Dim ProfecionOcupacionLabel As System.Windows.Forms.Label
        Dim NombreConyugueLabel As System.Windows.Forms.Label
        Dim ProfecionOcupacionConyugueLabel As System.Windows.Forms.Label
        Dim TelefonoConyugueLabel As System.Windows.Forms.Label
        Dim DireccionDomicilioLabel As System.Windows.Forms.Label
        Dim DireccionNegocioLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim ActivoLabel As System.Windows.Forms.Label
        Me.NacionalidadComboBox = New System.Windows.Forms.ComboBox()
        Me.Tipo_IdentidadComboBox = New System.Windows.Forms.ComboBox()
        Me.EstadoCivilComboBox = New System.Windows.Forms.ComboBox()
        Me.SexoComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Btnfot = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CodigoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_s_TextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_s_TextBox = New System.Windows.Forms.TextBox()
        Me.Numero_IdentidaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EstadoCivilTextBox = New System.Windows.Forms.TextBox()
        Me.NombreConyugueTextBox = New System.Windows.Forms.TextBox()
        Me.ProfecionOcupacionConyugueTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoConyugueTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionDomicilioTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionNegocioTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ActivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.FotografiaPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ClientesTableAdapter1 = New Tepresto.CREDEFINDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager1 = New Tepresto.CREDEFINDataSetTableAdapters.TableAdapterManager()
        Me.CredefinDataSet1 = New Tepresto.CREDEFINDataSet()
        Me.PagosTableAdapter1 = New Tepresto.CREDEFINDataSetTableAdapters.PagosTableAdapter()
        Me.CreditosTableAdapter1 = New Tepresto.CREDEFINDataSetTableAdapters.CreditosTableAdapter()
        NacionalidadLabel = New System.Windows.Forms.Label()
        Tipo_IdentidadLabel = New System.Windows.Forms.Label()
        EstadoCivilLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        CodigoClienteLabel = New System.Windows.Forms.Label()
        Nombre_s_Label = New System.Windows.Forms.Label()
        Apellido_s_Label = New System.Windows.Forms.Label()
        Numero_IdentidaLabel = New System.Windows.Forms.Label()
        FechaNacimientoLabel = New System.Windows.Forms.Label()
        ProfecionOcupacionLabel = New System.Windows.Forms.Label()
        NombreConyugueLabel = New System.Windows.Forms.Label()
        ProfecionOcupacionConyugueLabel = New System.Windows.Forms.Label()
        TelefonoConyugueLabel = New System.Windows.Forms.Label()
        DireccionDomicilioLabel = New System.Windows.Forms.Label()
        DireccionNegocioLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        ActivoLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotografiaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CredefinDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.Location = New System.Drawing.Point(61, 331)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(91, 16)
        NacionalidadLabel.TabIndex = 92
        NacionalidadLabel.Text = "Nacionalidad:"
        '
        'Tipo_IdentidadLabel
        '
        Tipo_IdentidadLabel.AutoSize = True
        Tipo_IdentidadLabel.Location = New System.Drawing.Point(56, 293)
        Tipo_IdentidadLabel.Name = "Tipo_IdentidadLabel"
        Tipo_IdentidadLabel.Size = New System.Drawing.Size(97, 16)
        Tipo_IdentidadLabel.TabIndex = 89
        Tipo_IdentidadLabel.Text = "Tipo Identidad:"
        '
        'EstadoCivilLabel
        '
        EstadoCivilLabel.AutoSize = True
        EstadoCivilLabel.Location = New System.Drawing.Point(632, 491)
        EstadoCivilLabel.Name = "EstadoCivilLabel"
        EstadoCivilLabel.Size = New System.Drawing.Size(81, 16)
        EstadoCivilLabel.TabIndex = 87
        EstadoCivilLabel.Text = "Estado Civil:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(66, 366)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(41, 16)
        SexoLabel.TabIndex = 86
        SexoLabel.Text = "Sexo:"
        '
        'CodigoClienteLabel
        '
        CodigoClienteLabel.AutoSize = True
        CodigoClienteLabel.Location = New System.Drawing.Point(42, 196)
        CodigoClienteLabel.Name = "CodigoClienteLabel"
        CodigoClienteLabel.Size = New System.Drawing.Size(98, 16)
        CodigoClienteLabel.TabIndex = 51
        CodigoClienteLabel.Text = "Codigo Cliente:"
        '
        'Nombre_s_Label
        '
        Nombre_s_Label.AutoSize = True
        Nombre_s_Label.Location = New System.Drawing.Point(55, 259)
        Nombre_s_Label.Name = "Nombre_s_Label"
        Nombre_s_Label.Size = New System.Drawing.Size(74, 16)
        Nombre_s_Label.TabIndex = 53
        Nombre_s_Label.Text = "Nombre(s):"
        '
        'Apellido_s_Label
        '
        Apellido_s_Label.AutoSize = True
        Apellido_s_Label.Location = New System.Drawing.Point(290, 259)
        Apellido_s_Label.Name = "Apellido_s_Label"
        Apellido_s_Label.Size = New System.Drawing.Size(75, 16)
        Apellido_s_Label.TabIndex = 55
        Apellido_s_Label.Text = "Apellido(s):"
        '
        'Numero_IdentidaLabel
        '
        Numero_IdentidaLabel.AutoSize = True
        Numero_IdentidaLabel.Location = New System.Drawing.Point(290, 297)
        Numero_IdentidaLabel.Name = "Numero_IdentidaLabel"
        Numero_IdentidaLabel.Size = New System.Drawing.Size(109, 16)
        Numero_IdentidaLabel.TabIndex = 57
        Numero_IdentidaLabel.Text = "Numero Identida:"
        '
        'FechaNacimientoLabel
        '
        FechaNacimientoLabel.AutoSize = True
        FechaNacimientoLabel.Location = New System.Drawing.Point(55, 408)
        FechaNacimientoLabel.Name = "FechaNacimientoLabel"
        FechaNacimientoLabel.Size = New System.Drawing.Size(119, 16)
        FechaNacimientoLabel.TabIndex = 59
        FechaNacimientoLabel.Text = "Fecha Nacimiento:"
        '
        'ProfecionOcupacionLabel
        '
        ProfecionOcupacionLabel.AutoSize = True
        ProfecionOcupacionLabel.Location = New System.Drawing.Point(55, 468)
        ProfecionOcupacionLabel.Name = "ProfecionOcupacionLabel"
        ProfecionOcupacionLabel.Size = New System.Drawing.Size(135, 16)
        ProfecionOcupacionLabel.TabIndex = 61
        ProfecionOcupacionLabel.Text = "Profecion Ocupacion:"
        '
        'NombreConyugueLabel
        '
        NombreConyugueLabel.AutoSize = True
        NombreConyugueLabel.Location = New System.Drawing.Point(632, 519)
        NombreConyugueLabel.Name = "NombreConyugueLabel"
        NombreConyugueLabel.Size = New System.Drawing.Size(123, 16)
        NombreConyugueLabel.TabIndex = 63
        NombreConyugueLabel.Text = "Nombre Conyugue:"
        '
        'ProfecionOcupacionConyugueLabel
        '
        ProfecionOcupacionConyugueLabel.AutoSize = True
        ProfecionOcupacionConyugueLabel.Location = New System.Drawing.Point(632, 544)
        ProfecionOcupacionConyugueLabel.Name = "ProfecionOcupacionConyugueLabel"
        ProfecionOcupacionConyugueLabel.Size = New System.Drawing.Size(199, 16)
        ProfecionOcupacionConyugueLabel.TabIndex = 65
        ProfecionOcupacionConyugueLabel.Text = "Profecion Ocupacion Conyugue:"
        '
        'TelefonoConyugueLabel
        '
        TelefonoConyugueLabel.AutoSize = True
        TelefonoConyugueLabel.Location = New System.Drawing.Point(632, 572)
        TelefonoConyugueLabel.Name = "TelefonoConyugueLabel"
        TelefonoConyugueLabel.Size = New System.Drawing.Size(128, 16)
        TelefonoConyugueLabel.TabIndex = 67
        TelefonoConyugueLabel.Text = "Telefono Conyugue:"
        '
        'DireccionDomicilioLabel
        '
        DireccionDomicilioLabel.AutoSize = True
        DireccionDomicilioLabel.Location = New System.Drawing.Point(55, 503)
        DireccionDomicilioLabel.Name = "DireccionDomicilioLabel"
        DireccionDomicilioLabel.Size = New System.Drawing.Size(126, 16)
        DireccionDomicilioLabel.TabIndex = 69
        DireccionDomicilioLabel.Text = "Direccion Domicilio:"
        '
        'DireccionNegocioLabel
        '
        DireccionNegocioLabel.AutoSize = True
        DireccionNegocioLabel.Location = New System.Drawing.Point(55, 531)
        DireccionNegocioLabel.Name = "DireccionNegocioLabel"
        DireccionNegocioLabel.Size = New System.Drawing.Size(122, 16)
        DireccionNegocioLabel.TabIndex = 71
        DireccionNegocioLabel.Text = "Direccion Negocio:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(55, 559)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(64, 16)
        TelefonoLabel.TabIndex = 73
        TelefonoLabel.Text = "Telefono:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(61, 590)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(52, 16)
        CelularLabel.TabIndex = 75
        CelularLabel.Text = "Celular:"
        '
        'ActivoLabel
        '
        ActivoLabel.AutoSize = True
        ActivoLabel.Location = New System.Drawing.Point(177, 651)
        ActivoLabel.Name = "ActivoLabel"
        ActivoLabel.Size = New System.Drawing.Size(47, 16)
        ActivoLabel.TabIndex = 98
        ActivoLabel.Text = "Activo:"
        '
        'NacionalidadComboBox
        '
        Me.NacionalidadComboBox.FormattingEnabled = True
        Me.NacionalidadComboBox.Items.AddRange(New Object() {"Hondureña", "Mexicana", "Española", "Salvadoreña", "Guatemanteca"})
        Me.NacionalidadComboBox.Location = New System.Drawing.Point(158, 328)
        Me.NacionalidadComboBox.Name = "NacionalidadComboBox"
        Me.NacionalidadComboBox.Size = New System.Drawing.Size(126, 24)
        Me.NacionalidadComboBox.TabIndex = 93
        '
        'Tipo_IdentidadComboBox
        '
        Me.Tipo_IdentidadComboBox.FormattingEnabled = True
        Me.Tipo_IdentidadComboBox.Items.AddRange(New Object() {"DNI", "Licencia", "Pasaporte", "otras"})
        Me.Tipo_IdentidadComboBox.Location = New System.Drawing.Point(158, 293)
        Me.Tipo_IdentidadComboBox.Name = "Tipo_IdentidadComboBox"
        Me.Tipo_IdentidadComboBox.Size = New System.Drawing.Size(126, 24)
        Me.Tipo_IdentidadComboBox.TabIndex = 91
        '
        'EstadoCivilComboBox
        '
        Me.EstadoCivilComboBox.FormattingEnabled = True
        Me.EstadoCivilComboBox.Items.AddRange(New Object() {"Soltero", "Viudo", "Casado", "Union Libre"})
        Me.EstadoCivilComboBox.Location = New System.Drawing.Point(837, 483)
        Me.EstadoCivilComboBox.Name = "EstadoCivilComboBox"
        Me.EstadoCivilComboBox.Size = New System.Drawing.Size(200, 24)
        Me.EstadoCivilComboBox.TabIndex = 90
        '
        'SexoComboBox
        '
        Me.SexoComboBox.FormattingEnabled = True
        Me.SexoComboBox.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.SexoComboBox.Location = New System.Drawing.Point(158, 358)
        Me.SexoComboBox.Name = "SexoComboBox"
        Me.SexoComboBox.Size = New System.Drawing.Size(126, 24)
        Me.SexoComboBox.TabIndex = 88
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNuevo.Location = New System.Drawing.Point(665, 42)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(95, 51)
        Me.BtnNuevo.TabIndex = 85
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRegresar.Location = New System.Drawing.Point(978, 42)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(88, 51)
        Me.BtnRegresar.TabIndex = 84
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnBuscar.Location = New System.Drawing.Point(886, 42)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(86, 51)
        Me.BtnBuscar.TabIndex = 83
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnGuardar.Location = New System.Drawing.Point(778, 42)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(86, 51)
        Me.BtnGuardar.TabIndex = 82
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Btnfot
        '
        Me.Btnfot.Location = New System.Drawing.Point(837, 404)
        Me.Btnfot.Name = "Btnfot"
        Me.Btnfot.Size = New System.Drawing.Size(161, 23)
        Me.Btnfot.TabIndex = 81
        Me.Btnfot.Text = "Subir foto"
        Me.Btnfot.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(683, 431)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Informacion Secundaria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(36, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 18)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Informacion Principal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 36)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "NUEVO REGISTRO"
        '
        'CodigoClienteTextBox
        '
        Me.CodigoClienteTextBox.Location = New System.Drawing.Point(165, 190)
        Me.CodigoClienteTextBox.Name = "CodigoClienteTextBox"
        Me.CodigoClienteTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CodigoClienteTextBox.TabIndex = 52
        '
        'Nombre_s_TextBox
        '
        Me.Nombre_s_TextBox.Location = New System.Drawing.Point(158, 259)
        Me.Nombre_s_TextBox.Name = "Nombre_s_TextBox"
        Me.Nombre_s_TextBox.Size = New System.Drawing.Size(126, 22)
        Me.Nombre_s_TextBox.TabIndex = 54
        '
        'Apellido_s_TextBox
        '
        Me.Apellido_s_TextBox.Location = New System.Drawing.Point(405, 259)
        Me.Apellido_s_TextBox.Name = "Apellido_s_TextBox"
        Me.Apellido_s_TextBox.Size = New System.Drawing.Size(123, 22)
        Me.Apellido_s_TextBox.TabIndex = 56
        '
        'Numero_IdentidaTextBox
        '
        Me.Numero_IdentidaTextBox.Location = New System.Drawing.Point(405, 297)
        Me.Numero_IdentidaTextBox.Name = "Numero_IdentidaTextBox"
        Me.Numero_IdentidaTextBox.Size = New System.Drawing.Size(123, 22)
        Me.Numero_IdentidaTextBox.TabIndex = 58
        '
        'FechaNacimientoDateTimePicker
        '
        Me.FechaNacimientoDateTimePicker.Location = New System.Drawing.Point(180, 404)
        Me.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker"
        Me.FechaNacimientoDateTimePicker.Size = New System.Drawing.Size(280, 22)
        Me.FechaNacimientoDateTimePicker.TabIndex = 60
        '
        'EstadoCivilTextBox
        '
        Me.EstadoCivilTextBox.Location = New System.Drawing.Point(260, 468)
        Me.EstadoCivilTextBox.Name = "EstadoCivilTextBox"
        Me.EstadoCivilTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EstadoCivilTextBox.TabIndex = 62
        '
        'NombreConyugueTextBox
        '
        Me.NombreConyugueTextBox.Location = New System.Drawing.Point(837, 513)
        Me.NombreConyugueTextBox.Name = "NombreConyugueTextBox"
        Me.NombreConyugueTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NombreConyugueTextBox.TabIndex = 64
        '
        'ProfecionOcupacionConyugueTextBox
        '
        Me.ProfecionOcupacionConyugueTextBox.Location = New System.Drawing.Point(837, 541)
        Me.ProfecionOcupacionConyugueTextBox.Name = "ProfecionOcupacionConyugueTextBox"
        Me.ProfecionOcupacionConyugueTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ProfecionOcupacionConyugueTextBox.TabIndex = 66
        '
        'TelefonoConyugueTextBox
        '
        Me.TelefonoConyugueTextBox.Location = New System.Drawing.Point(837, 569)
        Me.TelefonoConyugueTextBox.Name = "TelefonoConyugueTextBox"
        Me.TelefonoConyugueTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TelefonoConyugueTextBox.TabIndex = 68
        '
        'DireccionDomicilioTextBox
        '
        Me.DireccionDomicilioTextBox.Location = New System.Drawing.Point(260, 500)
        Me.DireccionDomicilioTextBox.Name = "DireccionDomicilioTextBox"
        Me.DireccionDomicilioTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DireccionDomicilioTextBox.TabIndex = 70
        '
        'DireccionNegocioTextBox
        '
        Me.DireccionNegocioTextBox.Location = New System.Drawing.Point(260, 528)
        Me.DireccionNegocioTextBox.Name = "DireccionNegocioTextBox"
        Me.DireccionNegocioTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DireccionNegocioTextBox.TabIndex = 72
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(260, 556)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TelefonoTextBox.TabIndex = 74
        '
        'CelularTextBox
        '
        Me.CelularTextBox.Location = New System.Drawing.Point(260, 584)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CelularTextBox.TabIndex = 76
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ActivoCheckBox
        '
        Me.ActivoCheckBox.Location = New System.Drawing.Point(139, 648)
        Me.ActivoCheckBox.Name = "ActivoCheckBox"
        Me.ActivoCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.ActivoCheckBox.TabIndex = 99
        Me.ActivoCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Gold
        Me.PictureBox4.Image = Global.Tepresto.My.Resources.Resources.Nuevoregistro_3_
        Me.PictureBox4.Location = New System.Drawing.Point(23, 25)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(154, 120)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 97
        Me.PictureBox4.TabStop = False
        '
        'FotografiaPictureBox
        '
        Me.FotografiaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FotografiaPictureBox.Location = New System.Drawing.Point(816, 196)
        Me.FotografiaPictureBox.Name = "FotografiaPictureBox"
        Me.FotografiaPictureBox.Size = New System.Drawing.Size(207, 202)
        Me.FotografiaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotografiaPictureBox.TabIndex = 77
        Me.FotografiaPictureBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 181)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(584, 511)
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(602, 181)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(473, 511)
        Me.PictureBox2.TabIndex = 95
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(12, 25)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1063, 120)
        Me.PictureBox3.TabIndex = 96
        Me.PictureBox3.TabStop = False
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ClientesTableAdapter = Me.ClientesTableAdapter1
        Me.TableAdapterManager1.CreditosTableAdapter = Nothing
        Me.TableAdapterManager1.PagosTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Tepresto.CREDEFINDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CredefinDataSet1
        '
        Me.CredefinDataSet1.DataSetName = "CREDEFINDataSet"
        Me.CredefinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosTableAdapter1
        '
        Me.PagosTableAdapter1.ClearBeforeFill = True
        '
        'CreditosTableAdapter1
        '
        Me.CreditosTableAdapter1.ClearBeforeFill = True
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 836)
        Me.Controls.Add(ActivoLabel)
        Me.Controls.Add(Me.ActivoCheckBox)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(NacionalidadLabel)
        Me.Controls.Add(Me.NacionalidadComboBox)
        Me.Controls.Add(Tipo_IdentidadLabel)
        Me.Controls.Add(Me.Tipo_IdentidadComboBox)
        Me.Controls.Add(EstadoCivilLabel)
        Me.Controls.Add(Me.EstadoCivilComboBox)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(Me.SexoComboBox)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Btnfot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FotografiaPictureBox)
        Me.Controls.Add(CodigoClienteLabel)
        Me.Controls.Add(Me.CodigoClienteTextBox)
        Me.Controls.Add(Nombre_s_Label)
        Me.Controls.Add(Me.Nombre_s_TextBox)
        Me.Controls.Add(Apellido_s_Label)
        Me.Controls.Add(Me.Apellido_s_TextBox)
        Me.Controls.Add(Numero_IdentidaLabel)
        Me.Controls.Add(Me.Numero_IdentidaTextBox)
        Me.Controls.Add(FechaNacimientoLabel)
        Me.Controls.Add(Me.FechaNacimientoDateTimePicker)
        Me.Controls.Add(ProfecionOcupacionLabel)
        Me.Controls.Add(Me.EstadoCivilTextBox)
        Me.Controls.Add(NombreConyugueLabel)
        Me.Controls.Add(Me.NombreConyugueTextBox)
        Me.Controls.Add(ProfecionOcupacionConyugueLabel)
        Me.Controls.Add(Me.ProfecionOcupacionConyugueTextBox)
        Me.Controls.Add(TelefonoConyugueLabel)
        Me.Controls.Add(Me.TelefonoConyugueTextBox)
        Me.Controls.Add(DireccionDomicilioLabel)
        Me.Controls.Add(Me.DireccionDomicilioTextBox)
        Me.Controls.Add(DireccionNegocioLabel)
        Me.Controls.Add(Me.DireccionNegocioTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "FormCliente"
        Me.Text = "FormCliente"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotografiaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CredefinDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NacionalidadComboBox As ComboBox
    Friend WithEvents Tipo_IdentidadComboBox As ComboBox
    Friend WithEvents EstadoCivilComboBox As ComboBox
    Friend WithEvents SexoComboBox As ComboBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Btnfot As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FotografiaPictureBox As PictureBox
    Friend WithEvents CodigoClienteTextBox As TextBox
    Friend WithEvents Nombre_s_TextBox As TextBox
    Friend WithEvents Apellido_s_TextBox As TextBox
    Friend WithEvents Numero_IdentidaTextBox As TextBox
    Friend WithEvents FechaNacimientoDateTimePicker As DateTimePicker
    Friend WithEvents EstadoCivilTextBox As TextBox
    Friend WithEvents NombreConyugueTextBox As TextBox
    Friend WithEvents ProfecionOcupacionConyugueTextBox As TextBox
    Friend WithEvents TelefonoConyugueTextBox As TextBox
    Friend WithEvents DireccionDomicilioTextBox As TextBox
    Friend WithEvents DireccionNegocioTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CelularTextBox As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ActivoCheckBox As CheckBox
    Friend WithEvents ClientesTableAdapter1 As CREDEFINDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager1 As CREDEFINDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CredefinDataSet1 As Tepresto.CREDEFINDataSet
    Friend WithEvents PagosTableAdapter1 As Tepresto.CREDEFINDataSetTableAdapters.PagosTableAdapter
    Friend WithEvents CreditosTableAdapter1 As Tepresto.CREDEFINDataSetTableAdapters.CreditosTableAdapter
End Class
