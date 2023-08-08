<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionCreditos
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
        Me.LabGestionCredito = New System.Windows.Forms.Label()
        Me.BtnInactivos = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnActivos = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabGestionCredito
        '
        Me.LabGestionCredito.AutoSize = True
        Me.LabGestionCredito.Font = New System.Drawing.Font("Algerian", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabGestionCredito.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabGestionCredito.Location = New System.Drawing.Point(355, 9)
        Me.LabGestionCredito.Name = "LabGestionCredito"
        Me.LabGestionCredito.Size = New System.Drawing.Size(257, 31)
        Me.LabGestionCredito.TabIndex = 0
        Me.LabGestionCredito.Text = "Gestion Credito"
        '
        'BtnInactivos
        '
        Me.BtnInactivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInactivos.Image = Global.Tepresto.My.Resources.Resources.Inactivos__3_
        Me.BtnInactivos.Location = New System.Drawing.Point(361, 377)
        Me.BtnInactivos.Name = "BtnInactivos"
        Me.BtnInactivos.Size = New System.Drawing.Size(261, 208)
        Me.BtnInactivos.TabIndex = 7
        Me.BtnInactivos.Text = "Inactivos"
        Me.BtnInactivos.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Image = Global.Tepresto.My.Resources.Resources.Regresar
        Me.BtnRegresar.Location = New System.Drawing.Point(698, 377)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(238, 208)
        Me.BtnRegresar.TabIndex = 6
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnActivos
        '
        Me.BtnActivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActivos.Image = Global.Tepresto.My.Resources.Resources.Activos
        Me.BtnActivos.Location = New System.Drawing.Point(30, 377)
        Me.BtnActivos.Name = "BtnActivos"
        Me.BtnActivos.Size = New System.Drawing.Size(273, 208)
        Me.BtnActivos.TabIndex = 5
        Me.BtnActivos.Text = "Activos"
        Me.BtnActivos.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Image = Global.Tepresto.My.Resources.Resources.Calcular
        Me.BtnCalcular.Location = New System.Drawing.Point(703, 100)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(233, 212)
        Me.BtnCalcular.TabIndex = 4
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Image = Global.Tepresto.My.Resources.Resources.Consultar
        Me.BtnConsultar.Location = New System.Drawing.Point(361, 103)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(261, 207)
        Me.BtnConsultar.TabIndex = 3
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.Black
        Me.BtnNuevo.Image = Global.Tepresto.My.Resources.Resources.CreditoNuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(30, 103)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(279, 205)
        Me.BtnNuevo.TabIndex = 2
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(24, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(945, 610)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'GestionCreditos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(996, 705)
        Me.Controls.Add(Me.BtnInactivos)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnActivos)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.LabGestionCredito)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "GestionCreditos"
        Me.Text = "GestionCreditos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabGestionCredito As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnActivos As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnInactivos As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
