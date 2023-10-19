<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExistencias_bajas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvCn_codigos = New System.Windows.Forms.DataGridView()
        Me.cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvGranel = New System.Windows.Forms.DataGridView()
        Me.cla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.present = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvCn_codigos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvGranel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DgvCn_codigos)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(844, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Artículos con Código"
        '
        'DgvCn_codigos
        '
        Me.DgvCn_codigos.AllowUserToAddRows = False
        Me.DgvCn_codigos.AllowUserToDeleteRows = False
        Me.DgvCn_codigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCn_codigos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod, Me.desc, Me.pre, Me.exist, Me.prov})
        Me.DgvCn_codigos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCn_codigos.Location = New System.Drawing.Point(3, 21)
        Me.DgvCn_codigos.Name = "DgvCn_codigos"
        Me.DgvCn_codigos.ReadOnly = True
        Me.DgvCn_codigos.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvCn_codigos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvCn_codigos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvCn_codigos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCn_codigos.Size = New System.Drawing.Size(838, 207)
        Me.DgvCn_codigos.TabIndex = 0
        '
        'cod
        '
        Me.cod.HeaderText = "Código"
        Me.cod.Name = "cod"
        Me.cod.ReadOnly = True
        Me.cod.Width = 150
        '
        'desc
        '
        Me.desc.HeaderText = "Descripción"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        Me.desc.Width = 270
        '
        'pre
        '
        Me.pre.HeaderText = "Precio"
        Me.pre.Name = "pre"
        Me.pre.ReadOnly = True
        '
        'exist
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        Me.exist.DefaultCellStyle = DataGridViewCellStyle1
        Me.exist.HeaderText = "Existencia"
        Me.exist.Name = "exist"
        Me.exist.ReadOnly = True
        '
        'prov
        '
        Me.prov.HeaderText = "Proveedor"
        Me.prov.Name = "prov"
        Me.prov.ReadOnly = True
        Me.prov.Width = 130
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DgvGranel)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(851, 192)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Artículos a Granel"
        '
        'DgvGranel
        '
        Me.DgvGranel.AllowUserToAddRows = False
        Me.DgvGranel.AllowUserToDeleteRows = False
        Me.DgvGranel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGranel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cla, Me.descrip, Me.present, Me.precio, Me.existe, Me.provee})
        Me.DgvGranel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvGranel.Location = New System.Drawing.Point(3, 21)
        Me.DgvGranel.Name = "DgvGranel"
        Me.DgvGranel.ReadOnly = True
        Me.DgvGranel.RowHeadersVisible = False
        Me.DgvGranel.Size = New System.Drawing.Size(845, 168)
        Me.DgvGranel.TabIndex = 1
        '
        'cla
        '
        Me.cla.HeaderText = "Codigo"
        Me.cla.Name = "cla"
        Me.cla.ReadOnly = True
        Me.cla.Width = 70
        '
        'descrip
        '
        Me.descrip.HeaderText = "Descripción"
        Me.descrip.Name = "descrip"
        Me.descrip.ReadOnly = True
        Me.descrip.Width = 270
        '
        'present
        '
        Me.present.HeaderText = "Presentación"
        Me.present.Name = "present"
        Me.present.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 70
        '
        'existe
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        Me.existe.DefaultCellStyle = DataGridViewCellStyle3
        Me.existe.HeaderText = "Existencia"
        Me.existe.Name = "existe"
        Me.existe.ReadOnly = True
        Me.existe.Width = 90
        '
        'provee
        '
        Me.provee.HeaderText = "Proveedor"
        Me.provee.Name = "provee"
        Me.provee.ReadOnly = True
        Me.provee.Width = 150
        '
        'FrmExistencias_bajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 453)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmExistencias_bajas"
        Me.Text = "Artículos por Agotarse"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvCn_codigos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvGranel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvCn_codigos As System.Windows.Forms.DataGridView
    Friend WithEvents DgvGranel As System.Windows.Forms.DataGridView
    Friend WithEvents cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents present As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents provee As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
End Class
