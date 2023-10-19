<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmagotados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvArticulos = New System.Windows.Forms.DataGridView()
        Me.descrip1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exist1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvArticulos
        '
        Me.DgvArticulos.AllowUserToAddRows = False
        Me.DgvArticulos.AllowUserToDeleteRows = False
        Me.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.descrip1, Me.precio1, Me.exist1})
        Me.DgvArticulos.Location = New System.Drawing.Point(12, 12)
        Me.DgvArticulos.Name = "DgvArticulos"
        Me.DgvArticulos.ReadOnly = True
        Me.DgvArticulos.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvArticulos.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvArticulos.Size = New System.Drawing.Size(654, 378)
        Me.DgvArticulos.TabIndex = 0
        '
        'descrip1
        '
        Me.descrip1.HeaderText = "Descripción"
        Me.descrip1.Name = "descrip1"
        Me.descrip1.ReadOnly = True
        Me.descrip1.Width = 400
        '
        'precio1
        '
        Me.precio1.HeaderText = "Precio"
        Me.precio1.Name = "precio1"
        Me.precio1.ReadOnly = True
        Me.precio1.Width = 120
        '
        'exist1
        '
        Me.exist1.HeaderText = "Existencia"
        Me.exist1.Name = "exist1"
        Me.exist1.ReadOnly = True
        Me.exist1.Width = 114
        '
        'frmagotados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 402)
        Me.Controls.Add(Me.DgvArticulos)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmagotados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Artículos agotados..."
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents descrip1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exist1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
