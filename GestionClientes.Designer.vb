<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionClientes
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
        Me.LabGestionCliente = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnInactivos = New System.Windows.Forms.Button()
        Me.BtnActivos = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabGestionCliente
        '
        Me.LabGestionCliente.AutoSize = True
        Me.LabGestionCliente.Font = New System.Drawing.Font("Algerian", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabGestionCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabGestionCliente.Location = New System.Drawing.Point(304, 22)
        Me.LabGestionCliente.Name = "LabGestionCliente"
        Me.LabGestionCliente.Size = New System.Drawing.Size(255, 31)
        Me.LabGestionCliente.TabIndex = 0
        Me.LabGestionCliente.Text = "Gestion Clientes"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.Tepresto.My.Resources.Resources.ClienteConsultar
        Me.BtnNuevo.Location = New System.Drawing.Point(41, 122)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(243, 196)
        Me.BtnNuevo.TabIndex = 1
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnInactivos
        '
        Me.BtnInactivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInactivos.Image = Global.Tepresto.My.Resources.Resources.Inactivos__3_
        Me.BtnInactivos.Location = New System.Drawing.Point(361, 416)
        Me.BtnInactivos.Name = "BtnInactivos"
        Me.BtnInactivos.Size = New System.Drawing.Size(257, 200)
        Me.BtnInactivos.TabIndex = 2
        Me.BtnInactivos.Text = "Inactivos"
        Me.BtnInactivos.UseVisualStyleBackColor = True
        '
        'BtnActivos
        '
        Me.BtnActivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActivos.Image = Global.Tepresto.My.Resources.Resources.Activos
        Me.BtnActivos.Location = New System.Drawing.Point(41, 416)
        Me.BtnActivos.Name = "BtnActivos"
        Me.BtnActivos.Size = New System.Drawing.Size(243, 200)
        Me.BtnActivos.TabIndex = 3
        Me.BtnActivos.Text = "Activos"
        Me.BtnActivos.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Image = Global.Tepresto.My.Resources.Resources.Consultar
        Me.BtnConsultar.Location = New System.Drawing.Point(677, 129)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(233, 189)
        Me.BtnConsultar.TabIndex = 4
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Image = Global.Tepresto.My.Resources.Resources.Regresar
        Me.BtnRegresar.Location = New System.Drawing.Point(677, 416)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(212, 200)
        Me.BtnRegresar.TabIndex = 5
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Image = Global.Tepresto.My.Resources.Resources.Calculadora
        Me.BtnCalcular.Location = New System.Drawing.Point(351, 125)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(243, 196)
        Me.BtnCalcular.TabIndex = 6
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(12, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(932, 578)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'GestionClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(975, 686)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnActivos)
        Me.Controls.Add(Me.BtnInactivos)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.LabGestionCliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "GestionClientes"
        Me.Text = "GestionClientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabGestionCliente As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnInactivos As Button
    Friend WithEvents BtnActivos As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
