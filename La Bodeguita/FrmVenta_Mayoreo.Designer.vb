<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVenta_Mayoreo
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVenta_Mayoreo))
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecio_caja = New System.Windows.Forms.TextBox()
        Me.TxtPieza_caja = New System.Windows.Forms.TextBox()
        Me.TxtCajas = New System.Windows.Forms.TextBox()
        Me.DgvLista_Mayoreo = New System.Windows.Forms.DataGridView()
        Me.GpbInfo = New System.Windows.Forms.GroupBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtExist_cajas = New System.Windows.Forms.TextBox()
        Me.GpbLista = New System.Windows.Forms.GroupBox()
        Me.lstarticulos = New System.Windows.Forms.ListBox()
        Me.cmscambio = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CambiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnaccept = New System.Windows.Forms.Button()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pzas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvLista_Mayoreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpbInfo.SuspendLayout()
        Me.GpbLista.SuspendLayout()
        Me.cmscambio.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(74, 6)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(198, 23)
        Me.TxtCodigo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio Caja/Paquete:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Piezas x caja:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No. de Cajas:"
        '
        'TxtPrecio_caja
        '
        Me.TxtPrecio_caja.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio_caja.Location = New System.Drawing.Point(177, 88)
        Me.TxtPrecio_caja.Name = "TxtPrecio_caja"
        Me.TxtPrecio_caja.ReadOnly = True
        Me.TxtPrecio_caja.ShortcutsEnabled = False
        Me.TxtPrecio_caja.Size = New System.Drawing.Size(147, 23)
        Me.TxtPrecio_caja.TabIndex = 7
        '
        'TxtPieza_caja
        '
        Me.TxtPieza_caja.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPieza_caja.Location = New System.Drawing.Point(178, 127)
        Me.TxtPieza_caja.Name = "TxtPieza_caja"
        Me.TxtPieza_caja.ReadOnly = True
        Me.TxtPieza_caja.Size = New System.Drawing.Size(147, 23)
        Me.TxtPieza_caja.TabIndex = 8
        '
        'TxtCajas
        '
        Me.TxtCajas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCajas.Location = New System.Drawing.Point(178, 168)
        Me.TxtCajas.Name = "TxtCajas"
        Me.TxtCajas.Size = New System.Drawing.Size(147, 23)
        Me.TxtCajas.TabIndex = 0
        '
        'DgvLista_Mayoreo
        '
        Me.DgvLista_Mayoreo.AllowUserToAddRows = False
        Me.DgvLista_Mayoreo.AllowUserToDeleteRows = False
        Me.DgvLista_Mayoreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DgvLista_Mayoreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLista_Mayoreo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.cantidad, Me.descrip, Me.existencia, Me.precio, Me.importe, Me.pzas})
        Me.DgvLista_Mayoreo.Location = New System.Drawing.Point(14, 356)
        Me.DgvLista_Mayoreo.Name = "DgvLista_Mayoreo"
        Me.DgvLista_Mayoreo.ReadOnly = True
        Me.DgvLista_Mayoreo.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvLista_Mayoreo.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvLista_Mayoreo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvLista_Mayoreo.Size = New System.Drawing.Size(598, 96)
        Me.DgvLista_Mayoreo.TabIndex = 10
        '
        'GpbInfo
        '
        Me.GpbInfo.BackColor = System.Drawing.Color.Transparent
        Me.GpbInfo.Controls.Add(Me.Txtdescripcion)
        Me.GpbInfo.Controls.Add(Me.Label7)
        Me.GpbInfo.Controls.Add(Me.Label6)
        Me.GpbInfo.Controls.Add(Me.Label5)
        Me.GpbInfo.Controls.Add(Me.txtExist_cajas)
        Me.GpbInfo.Controls.Add(Me.Label2)
        Me.GpbInfo.Controls.Add(Me.Label3)
        Me.GpbInfo.Controls.Add(Me.Label4)
        Me.GpbInfo.Controls.Add(Me.TxtCajas)
        Me.GpbInfo.Controls.Add(Me.TxtPrecio_caja)
        Me.GpbInfo.Controls.Add(Me.TxtPieza_caja)
        Me.GpbInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpbInfo.Location = New System.Drawing.Point(278, 35)
        Me.GpbInfo.Name = "GpbInfo"
        Me.GpbInfo.Size = New System.Drawing.Size(334, 274)
        Me.GpbInfo.TabIndex = 1
        Me.GpbInfo.TabStop = False
        Me.GpbInfo.Text = "Información"
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdescripcion.Location = New System.Drawing.Point(177, 14)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.ReadOnly = True
        Me.Txtdescripcion.ShortcutsEnabled = False
        Me.Txtdescripcion.Size = New System.Drawing.Size(148, 23)
        Me.Txtdescripcion.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(78, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Descripción:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(235, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cajas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(87, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Existencia:"
        '
        'txtExist_cajas
        '
        Me.txtExist_cajas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExist_cajas.Location = New System.Drawing.Point(177, 49)
        Me.txtExist_cajas.Name = "txtExist_cajas"
        Me.txtExist_cajas.ReadOnly = True
        Me.txtExist_cajas.ShortcutsEnabled = False
        Me.txtExist_cajas.Size = New System.Drawing.Size(52, 23)
        Me.txtExist_cajas.TabIndex = 10
        '
        'GpbLista
        '
        Me.GpbLista.BackColor = System.Drawing.Color.Transparent
        Me.GpbLista.Controls.Add(Me.lstarticulos)
        Me.GpbLista.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpbLista.Location = New System.Drawing.Point(11, 35)
        Me.GpbLista.Name = "GpbLista"
        Me.GpbLista.Size = New System.Drawing.Size(261, 277)
        Me.GpbLista.TabIndex = 13
        Me.GpbLista.TabStop = False
        Me.GpbLista.Text = "Lista de Artículos"
        '
        'lstarticulos
        '
        Me.lstarticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstarticulos.FormattingEnabled = True
        Me.lstarticulos.ItemHeight = 17
        Me.lstarticulos.Location = New System.Drawing.Point(3, 21)
        Me.lstarticulos.Name = "lstarticulos"
        Me.lstarticulos.Size = New System.Drawing.Size(255, 253)
        Me.lstarticulos.TabIndex = 0
        '
        'cmscambio
        '
        Me.cmscambio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmscambio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarToolStripMenuItem})
        Me.cmscambio.Name = "cmscambio"
        Me.cmscambio.Size = New System.Drawing.Size(91, 26)
        '
        'CambiarToolStripMenuItem
        '
        Me.CambiarToolStripMenuItem.Image = CType(resources.GetObject("CambiarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CambiarToolStripMenuItem.Name = "CambiarToolStripMenuItem"
        Me.CambiarToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.CambiarToolStripMenuItem.Text = "Ver"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(119, 327)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 14
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnaccept
        '
        Me.btnaccept.Location = New System.Drawing.Point(14, 327)
        Me.btnaccept.Name = "btnaccept"
        Me.btnaccept.Size = New System.Drawing.Size(75, 23)
        Me.btnaccept.TabIndex = 15
        Me.btnaccept.Text = "Aceptar"
        Me.btnaccept.UseVisualStyleBackColor = True
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 80
        '
        'descrip
        '
        Me.descrip.HeaderText = "Descripción"
        Me.descrip.Name = "descrip"
        Me.descrip.ReadOnly = True
        Me.descrip.Width = 150
        '
        'existencia
        '
        Me.existencia.HeaderText = "Existencia"
        Me.existencia.Name = "existencia"
        Me.existencia.ReadOnly = True
        Me.existencia.Width = 80
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 80
        '
        'importe
        '
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Width = 80
        '
        'pzas
        '
        Me.pzas.HeaderText = "pzas_caja"
        Me.pzas.Name = "pzas"
        Me.pzas.ReadOnly = True
        Me.pzas.Visible = False
        '
        'FrmVenta_Mayoreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 483)
        Me.Controls.Add(Me.DgvLista_Mayoreo)
        Me.Controls.Add(Me.btnaccept)
        Me.Controls.Add(Me.GpbLista)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.GpbInfo)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVenta_Mayoreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ventas Mayoreo"
        CType(Me.DgvLista_Mayoreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpbInfo.ResumeLayout(False)
        Me.GpbInfo.PerformLayout()
        Me.GpbLista.ResumeLayout(False)
        Me.cmscambio.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio_caja As System.Windows.Forms.TextBox
    Friend WithEvents TxtPieza_caja As System.Windows.Forms.TextBox
    Friend WithEvents TxtCajas As System.Windows.Forms.TextBox
    Friend WithEvents DgvLista_Mayoreo As System.Windows.Forms.DataGridView
    Friend WithEvents GpbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents GpbLista As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtExist_cajas As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    'Friend WithEvents lstarticulos As ComponentFactory.Krypton.Toolkit.KryptonListBox
    'Friend WithEvents btngran As ComponentFactory.Krypton.Toolkit.KryptonButton
    'Friend WithEvents btnaccept As ComponentFactory.Krypton.Toolkit.KryptonButton
    'Friend WithEvents btncancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    'Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents cmscambio As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CambiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstarticulos As System.Windows.Forms.ListBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnaccept As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pzas As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
