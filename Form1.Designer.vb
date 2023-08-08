<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LblTepresto = New System.Windows.Forms.Label()
        Me.BtnPagos = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnCreditos = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTepresto
        '
        Me.LblTepresto.AutoSize = True
        Me.LblTepresto.Font = New System.Drawing.Font("Algerian", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTepresto.ForeColor = System.Drawing.Color.White
        Me.LblTepresto.Location = New System.Drawing.Point(299, 18)
        Me.LblTepresto.Name = "LblTepresto"
        Me.LblTepresto.Size = New System.Drawing.Size(291, 36)
        Me.LblTepresto.TabIndex = 0
        Me.LblTepresto.Text = "TPRESTO S DE RL"
        '
        'BtnPagos
        '
        Me.BtnPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagos.Image = Global.Tepresto.My.Resources.Resources.Pagos2
        Me.BtnPagos.Location = New System.Drawing.Point(51, 397)
        Me.BtnPagos.Name = "BtnPagos"
        Me.BtnPagos.Size = New System.Drawing.Size(252, 194)
        Me.BtnPagos.TabIndex = 5
        Me.BtnPagos.Text = "Pagos"
        Me.BtnPagos.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Image = Global.Tepresto.My.Resources.Resources.Calculadora
        Me.BtnCalcular.Location = New System.Drawing.Point(654, 101)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(205, 199)
        Me.BtnCalcular.TabIndex = 6
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.Tepresto.My.Resources.Resources.salir
        Me.BtnSalir.Location = New System.Drawing.Point(654, 398)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(223, 193)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnReportes
        '
        Me.BtnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportes.Image = Global.Tepresto.My.Resources.Resources.Reportes
        Me.BtnReportes.Location = New System.Drawing.Point(360, 387)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(245, 204)
        Me.BtnReportes.TabIndex = 3
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'BtnCreditos
        '
        Me.BtnCreditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreditos.Image = Global.Tepresto.My.Resources.Resources.CreditoNuevo
        Me.BtnCreditos.Location = New System.Drawing.Point(360, 101)
        Me.BtnCreditos.Name = "BtnCreditos"
        Me.BtnCreditos.Size = New System.Drawing.Size(245, 195)
        Me.BtnCreditos.TabIndex = 2
        Me.BtnCreditos.Text = "Creditos"
        Me.BtnCreditos.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.Color.Black
        Me.BtnClientes.Image = Global.Tepresto.My.Resources.Resources.ClienteConsultar
        Me.BtnClientes.Location = New System.Drawing.Point(51, 101)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(252, 195)
        Me.BtnClientes.TabIndex = 1
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(37, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(888, 583)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(957, 679)
        Me.Controls.Add(Me.BtnPagos)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnReportes)
        Me.Controls.Add(Me.BtnCreditos)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.LblTepresto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTepresto As Label
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnCreditos As Button
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnPagos As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents PictClientes As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
