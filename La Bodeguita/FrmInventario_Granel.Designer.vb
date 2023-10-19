<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventario_Granel
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
        Me.DgvArticulos2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lblinversion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblInver_total = New System.Windows.Forms.Label()
        CType(Me.DgvArticulos2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvArticulos2
        '
        Me.DgvArticulos2.AllowUserToAddRows = False
        Me.DgvArticulos2.AllowUserToDeleteRows = False
        Me.DgvArticulos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticulos2.Location = New System.Drawing.Point(12, 12)
        Me.DgvArticulos2.Name = "DgvArticulos2"
        Me.DgvArticulos2.ReadOnly = True
        Me.DgvArticulos2.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvArticulos2.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvArticulos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvArticulos2.Size = New System.Drawing.Size(910, 467)
        Me.DgvArticulos2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 486)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "$"
        '
        'Lblinversion
        '
        Me.Lblinversion.Location = New System.Drawing.Point(79, 483)
        Me.Lblinversion.Name = "Lblinversion"
        Me.Lblinversion.Size = New System.Drawing.Size(105, 16)
        Me.Lblinversion.TabIndex = 0
        Me.Lblinversion.Text = "0.00"
        Me.Lblinversion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 482)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "$"
        '
        'LblInver_total
        '
        Me.LblInver_total.Location = New System.Drawing.Point(297, 482)
        Me.LblInver_total.Name = "LblInver_total"
        Me.LblInver_total.Size = New System.Drawing.Size(95, 16)
        Me.LblInver_total.TabIndex = 1
        Me.LblInver_total.Text = "0.00"
        Me.LblInver_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmInventario_Granel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 508)
        Me.Controls.Add(Me.DgvArticulos2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblInver_total)
        Me.Controls.Add(Me.Lblinversion)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInventario_Granel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Inventario a Granel"
        CType(Me.DgvArticulos2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvArticulos2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lblinversion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblInver_total As System.Windows.Forms.Label
    'Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
End Class
