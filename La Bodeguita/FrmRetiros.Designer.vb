<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRetiros
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtVentas = New System.Windows.Forms.TextBox()
        Me.txtDsiponible = New System.Windows.Forms.TextBox()
        Me.txtRetirado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRetiro = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtretiro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblcaja = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtVentas)
        Me.GroupBox3.Controls.Add(Me.txtDsiponible)
        Me.GroupBox3.Controls.Add(Me.txtRetirado)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtnota)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.BtnRetiro)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtretiro)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(18, 45)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(521, 380)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'txtVentas
        '
        Me.txtVentas.Enabled = False
        Me.txtVentas.Location = New System.Drawing.Point(196, 45)
        Me.txtVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtVentas.Name = "txtVentas"
        Me.txtVentas.Size = New System.Drawing.Size(303, 29)
        Me.txtVentas.TabIndex = 0
        Me.txtVentas.Tag = "decimales"
        Me.txtVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDsiponible
        '
        Me.txtDsiponible.Enabled = False
        Me.txtDsiponible.Location = New System.Drawing.Point(196, 155)
        Me.txtDsiponible.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDsiponible.Name = "txtDsiponible"
        Me.txtDsiponible.Size = New System.Drawing.Size(303, 29)
        Me.txtDsiponible.TabIndex = 2
        Me.txtDsiponible.Tag = "decimales"
        Me.txtDsiponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetirado
        '
        Me.txtRetirado.Enabled = False
        Me.txtRetirado.Location = New System.Drawing.Point(196, 98)
        Me.txtRetirado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRetirado.Name = "txtRetirado"
        Me.txtRetirado.Size = New System.Drawing.Size(303, 29)
        Me.txtRetirado.TabIndex = 1
        Me.txtRetirado.Tag = "decimales"
        Me.txtRetirado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Disponible a retirar :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Total Retirado :"
        '
        'txtnota
        '
        Me.txtnota.Location = New System.Drawing.Point(196, 261)
        Me.txtnota.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Size = New System.Drawing.Size(303, 29)
        Me.txtnota.TabIndex = 4
        Me.txtnota.Tag = "cadena"
        Me.txtnota.Text = "RETIRO DE EFECTIVO"
        Me.txtnota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 265)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Descripción :"
        '
        'BtnRetiro
        '
        Me.BtnRetiro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRetiro.Location = New System.Drawing.Point(324, 329)
        Me.BtnRetiro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRetiro.Name = "BtnRetiro"
        Me.BtnRetiro.Size = New System.Drawing.Size(112, 35)
        Me.BtnRetiro.TabIndex = 5
        Me.BtnRetiro.Text = "Aceptar"
        Me.BtnRetiro.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 48)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Venta al dia :"
        '
        'txtretiro
        '
        Me.txtretiro.Location = New System.Drawing.Point(196, 209)
        Me.txtretiro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtretiro.Name = "txtretiro"
        Me.txtretiro.Size = New System.Drawing.Size(303, 29)
        Me.txtretiro.TabIndex = 3
        Me.txtretiro.Tag = "decimales"
        Me.txtretiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 213)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cantidad a Retirar:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(306, 14)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 23)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Esta es la Caja No. :"
        '
        'lblcaja
        '
        Me.lblcaja.AutoSize = True
        Me.lblcaja.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaja.Location = New System.Drawing.Point(514, 14)
        Me.lblcaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcaja.Name = "lblcaja"
        Me.lblcaja.Size = New System.Drawing.Size(19, 23)
        Me.lblcaja.TabIndex = 22
        Me.lblcaja.Text = "0"
        '
        'FrmRetiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 445)
        Me.Controls.Add(Me.lblcaja)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmRetiros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiro de Efectivo"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnRetiro As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtretiro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnota As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDsiponible As System.Windows.Forms.TextBox
    Friend WithEvents txtRetirado As System.Windows.Forms.TextBox
    Friend WithEvents txtVentas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblcaja As System.Windows.Forms.Label
End Class
