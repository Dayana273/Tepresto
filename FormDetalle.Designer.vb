<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetalle
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
        Dim Label3 As System.Windows.Forms.Label
        Dim FormaPagoLabel1 As System.Windows.Forms.Label
        Dim DescripcionLabel1 As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim ValorCuotaLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim CodigoCreditoLabel As System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.FormaPagoComboBox = New System.Windows.Forms.ComboBox()
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.ValorCuotaTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CodigoCreditoTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableAdapterManager1 = New Tepresto.CREDEFINDataSetTableAdapters.TableAdapterManager()
        Me.PagosTableAdapter1 = New Tepresto.CREDEFINDataSetTableAdapters.PagosTableAdapter()
        Me.ClientesTableAdapter1 = New Tepresto.CREDEFINDataSetTableAdapters.ClientesTableAdapter()
        Me.CreditosTableAdapter1 = New Tepresto.CREDEFINDataSetTableAdapters.CreditosTableAdapter()
        Me.CredefinDataSet1 = New Tepresto.CREDEFINDataSet()
        Label3 = New System.Windows.Forms.Label()
        FormaPagoLabel1 = New System.Windows.Forms.Label()
        DescripcionLabel1 = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        ValorCuotaLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CodigoCreditoLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CredefinDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(117, 407)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(151, 16)
        Label3.TabIndex = 38
        Label3.Text = "Cuotas en este Pago"
        '
        'FormaPagoLabel1
        '
        FormaPagoLabel1.AutoSize = True
        FormaPagoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormaPagoLabel1.Location = New System.Drawing.Point(2, 501)
        FormaPagoLabel1.Name = "FormaPagoLabel1"
        FormaPagoLabel1.Size = New System.Drawing.Size(96, 16)
        FormaPagoLabel1.TabIndex = 35
        FormaPagoLabel1.Text = "Forma Pago:"
        '
        'DescripcionLabel1
        '
        DescripcionLabel1.AutoSize = True
        DescripcionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel1.Location = New System.Drawing.Point(12, 351)
        DescripcionLabel1.Name = "DescripcionLabel1"
        DescripcionLabel1.Size = New System.Drawing.Size(94, 16)
        DescripcionLabel1.TabIndex = 34
        DescripcionLabel1.Text = "Descripcion:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CantidadLabel.Location = New System.Drawing.Point(25, 309)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(73, 16)
        CantidadLabel.TabIndex = 32
        CantidadLabel.Text = "Cantidad:"
        '
        'ValorCuotaLabel
        '
        ValorCuotaLabel.AutoSize = True
        ValorCuotaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorCuotaLabel.Location = New System.Drawing.Point(12, 271)
        ValorCuotaLabel.Name = "ValorCuotaLabel"
        ValorCuotaLabel.Size = New System.Drawing.Size(92, 16)
        ValorCuotaLabel.TabIndex = 30
        ValorCuotaLabel.Text = "Valor Cuota:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(115, 181)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(137, 16)
        Label2.TabIndex = 28
        Label2.Text = "Numero de Recibo"
        '
        'CodigoCreditoLabel
        '
        CodigoCreditoLabel.AutoSize = True
        CodigoCreditoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoCreditoLabel.Location = New System.Drawing.Point(260, 181)
        CodigoCreditoLabel.Name = "CodigoCreditoLabel"
        CodigoCreditoLabel.Size = New System.Drawing.Size(115, 16)
        CodigoCreditoLabel.TabIndex = 26
        CodigoCreditoLabel.Text = "Codigo Credito:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RosyBrown
        Me.Button2.Location = New System.Drawing.Point(134, 573)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 66)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnRegresar.Location = New System.Drawing.Point(289, 573)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(134, 66)
        Me.BtnRegresar.TabIndex = 40
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(274, 404)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(84, 22)
        Me.TextBox2.TabIndex = 39
        '
        'FormaPagoComboBox
        '
        Me.FormaPagoComboBox.FormattingEnabled = True
        Me.FormaPagoComboBox.Items.AddRange(New Object() {"Efectivo", "Deposito a Cuenta", "Transferencia", "Giro Nacional", "Giro Internacional"})
        Me.FormaPagoComboBox.Location = New System.Drawing.Point(118, 493)
        Me.FormaPagoComboBox.Name = "FormaPagoComboBox"
        Me.FormaPagoComboBox.Size = New System.Drawing.Size(285, 24)
        Me.FormaPagoComboBox.TabIndex = 37
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Items.AddRange(New Object() {"Cuota Normal", "Pago de Interes", "Abono a Cuota", "Ajuste a Capital", "Abono a Capital", "Cancelacion"})
        Me.DescripcionComboBox.Location = New System.Drawing.Point(118, 348)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(277, 24)
        Me.DescripcionComboBox.TabIndex = 36
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.Location = New System.Drawing.Point(118, 306)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(277, 22)
        Me.CantidadTextBox.TabIndex = 33
        '
        'ValorCuotaTextBox
        '
        Me.ValorCuotaTextBox.Location = New System.Drawing.Point(118, 265)
        Me.ValorCuotaTextBox.Name = "ValorCuotaTextBox"
        Me.ValorCuotaTextBox.Size = New System.Drawing.Size(277, 22)
        Me.ValorCuotaTextBox.TabIndex = 31
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(118, 213)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(118, 22)
        Me.TextBox1.TabIndex = 29
        '
        'CodigoCreditoTextBox
        '
        Me.CodigoCreditoTextBox.Location = New System.Drawing.Point(263, 213)
        Me.CodigoCreditoTextBox.Name = "CodigoCreditoTextBox"
        Me.CodigoCreditoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CodigoCreditoTextBox.TabIndex = 27
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(178, 98)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(245, 22)
        Me.DateTimePicker1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 31)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "RECIBO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tepresto.My.Resources.Resources.pagos
        Me.PictureBox1.Location = New System.Drawing.Point(28, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ClientesTableAdapter = Me.ClientesTableAdapter1
        Me.TableAdapterManager1.CreditosTableAdapter = Me.CreditosTableAdapter1
        Me.TableAdapterManager1.PagosTableAdapter = Me.PagosTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Tepresto.CREDEFINDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PagosTableAdapter1
        '
        Me.PagosTableAdapter1.ClearBeforeFill = True
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'CreditosTableAdapter1
        '
        Me.CreditosTableAdapter1.ClearBeforeFill = True
        '
        'CredefinDataSet1
        '
        Me.CredefinDataSet1.DataSetName = "CREDEFINDataSet"
        Me.CredefinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 716)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(FormaPagoLabel1)
        Me.Controls.Add(Me.FormaPagoComboBox)
        Me.Controls.Add(DescripcionLabel1)
        Me.Controls.Add(Me.DescripcionComboBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(ValorCuotaLabel)
        Me.Controls.Add(Me.ValorCuotaTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(CodigoCreditoLabel)
        Me.Controls.Add(Me.CodigoCreditoTextBox)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDetalle"
        Me.Text = "FormDetalle"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CredefinDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents FormaPagoComboBox As ComboBox
    Friend WithEvents DescripcionComboBox As ComboBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents ValorCuotaTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CodigoCreditoTextBox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TableAdapterManager1 As Tepresto.CREDEFINDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesTableAdapter1 As Tepresto.CREDEFINDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents CreditosTableAdapter1 As Tepresto.CREDEFINDataSetTableAdapters.CreditosTableAdapter
    Friend WithEvents PagosTableAdapter1 As Tepresto.CREDEFINDataSetTableAdapters.PagosTableAdapter
    Friend WithEvents CredefinDataSet1 As Tepresto.CREDEFINDataSet
End Class
