<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCliente
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
        Dim Apellido_s_Label As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim Nombre_s_Label As System.Windows.Forms.Label
        Dim CodigoClienteLabel As System.Windows.Forms.Label
        Dim Numero_IdentidaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaCliente))
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Numero_IdentidaTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_s_TextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_s_TextBox = New System.Windows.Forms.TextBox()
        Me.CodigoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.LblConsultarCliente = New System.Windows.Forms.Label()
        Me.CREDEFINDataSet = New Tepresto.CREDEFINDataSet()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosTableAdapter = New Tepresto.CREDEFINDataSetTableAdapters.PagosTableAdapter()
        Me.TableAdapterManager = New Tepresto.CREDEFINDataSetTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter = New Tepresto.CREDEFINDataSetTableAdapters.ClientesTableAdapter()
        Me.CreditosTableAdapter = New Tepresto.CREDEFINDataSetTableAdapters.CreditosTableAdapter()
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
        Me.CreditosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Apellido_s_Label = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Nombre_s_Label = New System.Windows.Forms.Label()
        CodigoClienteLabel = New System.Windows.Forms.Label()
        Numero_IdentidaLabel = New System.Windows.Forms.Label()
        CType(Me.CREDEFINDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PagosBindingNavigator.SuspendLayout()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Apellido_s_Label
        '
        Apellido_s_Label.AutoSize = True
        Apellido_s_Label.Location = New System.Drawing.Point(438, 140)
        Apellido_s_Label.Name = "Apellido_s_Label"
        Apellido_s_Label.Size = New System.Drawing.Size(75, 16)
        Apellido_s_Label.TabIndex = 26
        Apellido_s_Label.Text = "Apellido(s):"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(449, 105)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(64, 16)
        TelefonoLabel.TabIndex = 24
        TelefonoLabel.Text = "Telefono:"
        '
        'Nombre_s_Label
        '
        Nombre_s_Label.AutoSize = True
        Nombre_s_Label.Location = New System.Drawing.Point(213, 130)
        Nombre_s_Label.Name = "Nombre_s_Label"
        Nombre_s_Label.Size = New System.Drawing.Size(74, 16)
        Nombre_s_Label.TabIndex = 22
        Nombre_s_Label.Text = "Nombre(s):"
        '
        'CodigoClienteLabel
        '
        CodigoClienteLabel.AutoSize = True
        CodigoClienteLabel.Location = New System.Drawing.Point(189, 102)
        CodigoClienteLabel.Name = "CodigoClienteLabel"
        CodigoClienteLabel.Size = New System.Drawing.Size(98, 16)
        CodigoClienteLabel.TabIndex = 20
        CodigoClienteLabel.Text = "Codigo Cliente:"
        '
        'Numero_IdentidaLabel
        '
        Numero_IdentidaLabel.AutoSize = True
        Numero_IdentidaLabel.Location = New System.Drawing.Point(642, 143)
        Numero_IdentidaLabel.Name = "Numero_IdentidaLabel"
        Numero_IdentidaLabel.Size = New System.Drawing.Size(109, 16)
        Numero_IdentidaLabel.TabIndex = 34
        Numero_IdentidaLabel.Text = "Numero Identida:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBuscar.Location = New System.Drawing.Point(819, 30)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(134, 47)
        Me.BtnBuscar.TabIndex = 32
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Black
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnRegresar.Location = New System.Drawing.Point(959, 30)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(137, 47)
        Me.BtnRegresar.TabIndex = 30
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Numero_IdentidaTextBox
        '
        Me.Numero_IdentidaTextBox.Location = New System.Drawing.Point(757, 140)
        Me.Numero_IdentidaTextBox.Name = "Numero_IdentidaTextBox"
        Me.Numero_IdentidaTextBox.Size = New System.Drawing.Size(136, 22)
        Me.Numero_IdentidaTextBox.TabIndex = 28
        '
        'Apellido_s_TextBox
        '
        Me.Apellido_s_TextBox.Location = New System.Drawing.Point(519, 137)
        Me.Apellido_s_TextBox.Name = "Apellido_s_TextBox"
        Me.Apellido_s_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Apellido_s_TextBox.TabIndex = 27
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(519, 106)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TelefonoTextBox.TabIndex = 25
        '
        'Nombre_s_TextBox
        '
        Me.Nombre_s_TextBox.Location = New System.Drawing.Point(293, 127)
        Me.Nombre_s_TextBox.Name = "Nombre_s_TextBox"
        Me.Nombre_s_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Nombre_s_TextBox.TabIndex = 23
        '
        'CodigoClienteTextBox
        '
        Me.CodigoClienteTextBox.Location = New System.Drawing.Point(293, 99)
        Me.CodigoClienteTextBox.Name = "CodigoClienteTextBox"
        Me.CodigoClienteTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CodigoClienteTextBox.TabIndex = 21
        '
        'LblConsultarCliente
        '
        Me.LblConsultarCliente.AutoSize = True
        Me.LblConsultarCliente.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultarCliente.Location = New System.Drawing.Point(300, 43)
        Me.LblConsultarCliente.Name = "LblConsultarCliente"
        Me.LblConsultarCliente.Size = New System.Drawing.Size(319, 34)
        Me.LblConsultarCliente.TabIndex = 19
        Me.LblConsultarCliente.Text = "Consultar Cliente"
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
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.CreditosTableAdapter = Me.CreditosTableAdapter
        Me.TableAdapterManager.PagosTableAdapter = Me.PagosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Tepresto.CREDEFINDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'CreditosTableAdapter
        '
        Me.CreditosTableAdapter.ClearBeforeFill = True
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
        Me.PagosBindingNavigator.Size = New System.Drawing.Size(1144, 31)
        Me.PagosBindingNavigator.TabIndex = 33
        Me.PagosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
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
        Me.PagosDataGridView.Location = New System.Drawing.Point(69, 530)
        Me.PagosDataGridView.Name = "PagosDataGridView"
        Me.PagosDataGridView.RowHeadersWidth = 51
        Me.PagosDataGridView.RowTemplate.Height = 24
        Me.PagosDataGridView.Size = New System.Drawing.Size(853, 132)
        Me.PagosDataGridView.TabIndex = 33
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
        'CreditosBindingSource
        '
        Me.CreditosBindingSource.DataMember = "Creditos"
        Me.CreditosBindingSource.DataSource = Me.CREDEFINDataSet
        '
        'CreditosDataGridView
        '
        Me.CreditosDataGridView.AutoGenerateColumns = False
        Me.CreditosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CreditosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn25})
        Me.CreditosDataGridView.DataSource = Me.CreditosBindingSource
        Me.CreditosDataGridView.Location = New System.Drawing.Point(69, 374)
        Me.CreditosDataGridView.Name = "CreditosDataGridView"
        Me.CreditosDataGridView.RowHeadersWidth = 51
        Me.CreditosDataGridView.RowTemplate.Height = 24
        Me.CreditosDataGridView.Size = New System.Drawing.Size(928, 134)
        Me.CreditosDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CodigoCredito"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CodigoCredito"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CodigoCliente"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CodigoCliente"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Monto"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Plazo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Plazo"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Interes"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Interes"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FomaPago"
        Me.DataGridViewTextBoxColumn14.HeaderText = "FomaPago"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CantidaddeCuotas"
        Me.DataGridViewTextBoxColumn15.HeaderText = "CantidaddeCuotas"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ValorCuota"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ValorCuota"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "InteresCorrespondiente"
        Me.DataGridViewTextBoxColumn17.HeaderText = "InteresCorrespondiente"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CuotasPagadas"
        Me.DataGridViewTextBoxColumn18.HeaderText = "CuotasPagadas"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CuotasPendientes"
        Me.DataGridViewTextBoxColumn19.HeaderText = "CuotasPendientes"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 125
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "SaldoAlVencimiento"
        Me.DataGridViewTextBoxColumn20.HeaderText = "SaldoAlVencimiento"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 125
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "CapitalPendiente"
        Me.DataGridViewTextBoxColumn21.HeaderText = "CapitalPendiente"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 125
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "FechaApertura"
        Me.DataGridViewTextBoxColumn22.HeaderText = "FechaApertura"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 125
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "DiasPago"
        Me.DataGridViewTextBoxColumn23.HeaderText = "DiasPago"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 125
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "ProximoPago"
        Me.DataGridViewTextBoxColumn24.HeaderText = "ProximoPago"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 125
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "CreditoActivo"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "CreditoActivo"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Observacion"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Observacion"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 125
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.CREDEFINDataSet
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewImageColumn1, Me.DataGridViewCheckBoxColumn2})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(69, 189)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.RowHeadersWidth = 51
        Me.ClientesDataGridView.RowTemplate.Height = 24
        Me.ClientesDataGridView.Size = New System.Drawing.Size(928, 164)
        Me.ClientesDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "CodigoCliente"
        Me.DataGridViewTextBoxColumn26.HeaderText = "CodigoCliente"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 125
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Nombre(s)"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Nombre(s)"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 125
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Apellido(s)"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Apellido(s)"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 125
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Tipo_Identidad"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Tipo_Identidad"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 125
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Numero_Identida"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Numero_Identida"
        Me.DataGridViewTextBoxColumn30.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 125
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Nacionalidad"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Nacionalidad"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 125
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Sexo"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Sexo"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 125
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "FechaNacimiento"
        Me.DataGridViewTextBoxColumn33.HeaderText = "FechaNacimiento"
        Me.DataGridViewTextBoxColumn33.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 125
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "ProfecionOcupacion"
        Me.DataGridViewTextBoxColumn34.HeaderText = "ProfecionOcupacion"
        Me.DataGridViewTextBoxColumn34.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 125
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "EstadoCivil"
        Me.DataGridViewTextBoxColumn35.HeaderText = "EstadoCivil"
        Me.DataGridViewTextBoxColumn35.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 125
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "NombreConyugue"
        Me.DataGridViewTextBoxColumn36.HeaderText = "NombreConyugue"
        Me.DataGridViewTextBoxColumn36.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 125
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "ProfecionOcupacionConyugue"
        Me.DataGridViewTextBoxColumn37.HeaderText = "ProfecionOcupacionConyugue"
        Me.DataGridViewTextBoxColumn37.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 125
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "TelefonoConyugue"
        Me.DataGridViewTextBoxColumn38.HeaderText = "TelefonoConyugue"
        Me.DataGridViewTextBoxColumn38.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Width = 125
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "DireccionDomicilio"
        Me.DataGridViewTextBoxColumn39.HeaderText = "DireccionDomicilio"
        Me.DataGridViewTextBoxColumn39.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Width = 125
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "DireccionNegocio"
        Me.DataGridViewTextBoxColumn40.HeaderText = "DireccionNegocio"
        Me.DataGridViewTextBoxColumn40.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.Width = 125
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn41.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Width = 125
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Celular"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Celular"
        Me.DataGridViewTextBoxColumn42.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 125
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Fotofrafia"
        Me.DataGridViewImageColumn1.HeaderText = "Fotofrafia"
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 125
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 125
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.Tepresto.My.Resources.Resources.ClienteConsultar
        Me.PictureBox1.Location = New System.Drawing.Point(26, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'ConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1144, 674)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Numero_IdentidaLabel)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.CreditosDataGridView)
        Me.Controls.Add(Me.PagosDataGridView)
        Me.Controls.Add(Me.PagosBindingNavigator)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Numero_IdentidaTextBox)
        Me.Controls.Add(Apellido_s_Label)
        Me.Controls.Add(Me.Apellido_s_TextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Nombre_s_Label)
        Me.Controls.Add(Me.Nombre_s_TextBox)
        Me.Controls.Add(CodigoClienteLabel)
        Me.Controls.Add(Me.CodigoClienteTextBox)
        Me.Controls.Add(Me.LblConsultarCliente)
        Me.Name = "ConsultaCliente"
        Me.Text = "ConsultaCliente"
        CType(Me.CREDEFINDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PagosBindingNavigator.ResumeLayout(False)
        Me.PagosBindingNavigator.PerformLayout()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents Numero_IdentidaTextBox As TextBox
    Friend WithEvents Apellido_s_TextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents Nombre_s_TextBox As TextBox
    Friend WithEvents CodigoClienteTextBox As TextBox
    Friend WithEvents LblConsultarCliente As Label
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
    Friend WithEvents CreditosTableAdapter As CREDEFINDataSetTableAdapters.CreditosTableAdapter
    Friend WithEvents CreditosBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As CREDEFINDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents CreditosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
