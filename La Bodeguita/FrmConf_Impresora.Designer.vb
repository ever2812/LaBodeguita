<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConf_Impresora
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnguardar1 = New System.Windows.Forms.Button()
        Me.btnprueba1 = New System.Windows.Forms.Button()
        Me.NumTam_fuente = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbImpresoras = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnGuardaCaja = New System.Windows.Forms.Button()
        Me.NumCaja = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumTam_fuente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnguardar1)
        Me.GroupBox2.Controls.Add(Me.btnprueba1)
        Me.GroupBox2.Controls.Add(Me.NumTam_fuente)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CmbImpresoras)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 26)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(596, 245)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Impresora para Tickets"
        '
        'btnguardar1
        '
        Me.btnguardar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardar1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar1.Location = New System.Drawing.Point(403, 162)
        Me.btnguardar1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnguardar1.Name = "btnguardar1"
        Me.btnguardar1.Size = New System.Drawing.Size(140, 35)
        Me.btnguardar1.TabIndex = 28
        Me.btnguardar1.Text = "Guardar"
        Me.btnguardar1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnguardar1.UseVisualStyleBackColor = True
        '
        'btnprueba1
        '
        Me.btnprueba1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprueba1.Location = New System.Drawing.Point(214, 162)
        Me.btnprueba1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnprueba1.Name = "btnprueba1"
        Me.btnprueba1.Size = New System.Drawing.Size(140, 35)
        Me.btnprueba1.TabIndex = 27
        Me.btnprueba1.Text = "Probar"
        Me.btnprueba1.UseVisualStyleBackColor = True
        '
        'NumTam_fuente
        '
        Me.NumTam_fuente.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumTam_fuente.Location = New System.Drawing.Point(189, 94)
        Me.NumTam_fuente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumTam_fuente.Name = "NumTam_fuente"
        Me.NumTam_fuente.Size = New System.Drawing.Size(210, 28)
        Me.NumTam_fuente.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Tamaño de fuente:"
        '
        'CmbImpresoras
        '
        Me.CmbImpresoras.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbImpresoras.FormattingEnabled = True
        Me.CmbImpresoras.Location = New System.Drawing.Point(186, 49)
        Me.CmbImpresoras.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbImpresoras.Name = "CmbImpresoras"
        Me.CmbImpresoras.Size = New System.Drawing.Size(357, 29)
        Me.CmbImpresoras.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnGuardaCaja)
        Me.GroupBox1.Controls.Add(Me.NumCaja)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 282)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(596, 107)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Número de Caja"
        '
        'BtnGuardaCaja
        '
        Me.BtnGuardaCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardaCaja.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardaCaja.Location = New System.Drawing.Point(403, 35)
        Me.BtnGuardaCaja.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnGuardaCaja.Name = "BtnGuardaCaja"
        Me.BtnGuardaCaja.Size = New System.Drawing.Size(140, 35)
        Me.BtnGuardaCaja.TabIndex = 28
        Me.BtnGuardaCaja.Text = "Guardar"
        Me.BtnGuardaCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnGuardaCaja.UseVisualStyleBackColor = True
        '
        'NumCaja
        '
        Me.NumCaja.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCaja.Location = New System.Drawing.Point(151, 40)
        Me.NumCaja.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumCaja.Name = "NumCaja"
        Me.NumCaja.Size = New System.Drawing.Size(180, 28)
        Me.NumCaja.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Caja No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 21)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Impresora :"
        '
        'FrmConf_Impresora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 401)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmConf_Impresora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuraciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumTam_fuente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbImpresoras As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumTam_fuente As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnguardar1 As System.Windows.Forms.Button
    Friend WithEvents btnprueba1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGuardaCaja As System.Windows.Forms.Button
    Friend WithEvents NumCaja As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As Label
End Class
