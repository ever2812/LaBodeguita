<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCat_Articulo
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCat_Articulo))
        Me.DgvLista_Articulos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txtbuscar1 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnAct1 = New System.Windows.Forms.Button()
        Me.TxtPza_caja1 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtPrecio_caja1 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtExistencia1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDescripcion1 = New System.Windows.Forms.TextBox()
        Me.CmbProv = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprecio1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tpnormales = New System.Windows.Forms.TabPage()
        Me.Tpgranel = New System.Windows.Forms.TabPage()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.TxtBuscar2 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar2 = New System.Windows.Forms.Button()
        Me.BtnAct2 = New System.Windows.Forms.Button()
        Me.TxtPza_caja2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtPrecio_caja2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtExistencia2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDescripcion2 = New System.Windows.Forms.TextBox()
        Me.CmbProvee = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprecio2 = New System.Windows.Forms.TextBox()
        Me.CmbPresent = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DgvList_Articulos2 = New System.Windows.Forms.DataGridView()
        Me.cmscambio = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CambiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmscambio1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DgvLista_Articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Tpnormales.SuspendLayout()
        Me.Tpgranel.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DgvList_Articulos2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmscambio.SuspendLayout()
        Me.cmscambio1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvLista_Articulos
        '
        Me.DgvLista_Articulos.AllowUserToAddRows = False
        Me.DgvLista_Articulos.AllowUserToDeleteRows = False
        Me.DgvLista_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLista_Articulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvLista_Articulos.Location = New System.Drawing.Point(4, 25)
        Me.DgvLista_Articulos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DgvLista_Articulos.Name = "DgvLista_Articulos"
        Me.DgvLista_Articulos.ReadOnly = True
        Me.DgvLista_Articulos.RowHeadersVisible = False
        Me.DgvLista_Articulos.RowHeadersWidth = 51
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvLista_Articulos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvLista_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvLista_Articulos.Size = New System.Drawing.Size(1144, 249)
        Me.DgvLista_Articulos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DgvLista_Articulos)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 39)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1152, 277)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1054, 48)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 26)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "&Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Txtbuscar1
        '
        Me.Txtbuscar1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbuscar1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Txtbuscar1.Location = New System.Drawing.Point(5, 6)
        Me.Txtbuscar1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txtbuscar1.Name = "Txtbuscar1"
        Me.Txtbuscar1.Size = New System.Drawing.Size(405, 27)
        Me.Txtbuscar1.TabIndex = 0
        Me.Txtbuscar1.Text = "Código el Artículo"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(445, 7)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(153, 23)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ver Lista Completa"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BtnAct1)
        Me.GroupBox2.Controls.Add(Me.TxtPza_caja1)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.txtPrecio_caja1)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.TxtExistencia1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtDescripcion1)
        Me.GroupBox2.Controls.Add(Me.CmbProv)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtprecio1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 333)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(1158, 115)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descripción del Articulo"
        '
        'BtnAct1
        '
        Me.BtnAct1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAct1.Location = New System.Drawing.Point(1054, 16)
        Me.BtnAct1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAct1.Name = "BtnAct1"
        Me.BtnAct1.Size = New System.Drawing.Size(94, 26)
        Me.BtnAct1.TabIndex = 1
        Me.BtnAct1.Text = "&Actualizar"
        Me.BtnAct1.UseVisualStyleBackColor = True
        '
        'TxtPza_caja1
        '
        Me.TxtPza_caja1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPza_caja1.Location = New System.Drawing.Point(890, 51)
        Me.TxtPza_caja1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtPza_caja1.Name = "TxtPza_caja1"
        Me.TxtPza_caja1.Size = New System.Drawing.Size(139, 27)
        Me.TxtPza_caja1.TabIndex = 28
        Me.TxtPza_caja1.Tag = "enteros"
        Me.TxtPza_caja1.Text = "0"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(784, 52)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(103, 23)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "Pzas. x Caja:"
        '
        'txtPrecio_caja1
        '
        Me.txtPrecio_caja1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_caja1.Location = New System.Drawing.Point(609, 51)
        Me.txtPrecio_caja1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPrecio_caja1.Name = "txtPrecio_caja1"
        Me.txtPrecio_caja1.Size = New System.Drawing.Size(133, 27)
        Me.txtPrecio_caja1.TabIndex = 27
        Me.txtPrecio_caja1.Tag = "decimales"
        Me.txtPrecio_caja1.Text = "0.00"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(441, 52)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(170, 23)
        Me.Label28.TabIndex = 29
        Me.Label28.Text = "Precio/Caja/Paquete:"
        '
        'TxtExistencia1
        '
        Me.TxtExistencia1.BackColor = System.Drawing.Color.White
        Me.TxtExistencia1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExistencia1.Location = New System.Drawing.Point(890, 21)
        Me.TxtExistencia1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtExistencia1.Name = "TxtExistencia1"
        Me.TxtExistencia1.Size = New System.Drawing.Size(139, 27)
        Me.TxtExistencia1.TabIndex = 12
        Me.TxtExistencia1.Tag = "enteros"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(799, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 23)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Existencia:"
        '
        'TxtDescripcion1
        '
        Me.TxtDescripcion1.BackColor = System.Drawing.Color.White
        Me.TxtDescripcion1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion1.Location = New System.Drawing.Point(114, 21)
        Me.TxtDescripcion1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtDescripcion1.Name = "TxtDescripcion1"
        Me.TxtDescripcion1.Size = New System.Drawing.Size(289, 27)
        Me.TxtDescripcion1.TabIndex = 10
        Me.TxtDescripcion1.Tag = "cadena"
        '
        'CmbProv
        '
        Me.CmbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbProv.FormattingEnabled = True
        Me.CmbProv.Location = New System.Drawing.Point(114, 51)
        Me.CmbProv.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbProv.Name = "CmbProv"
        Me.CmbProv.Size = New System.Drawing.Size(289, 28)
        Me.CmbProv.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Proveedor:"
        '
        'txtprecio1
        '
        Me.txtprecio1.BackColor = System.Drawing.Color.White
        Me.txtprecio1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio1.Location = New System.Drawing.Point(609, 22)
        Me.txtprecio1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtprecio1.Name = "txtprecio1"
        Me.txtprecio1.Size = New System.Drawing.Size(133, 27)
        Me.txtprecio1.TabIndex = 4
        Me.txtprecio1.Tag = "decimales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(481, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio Unitario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripción:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tpnormales)
        Me.TabControl1.Controls.Add(Me.Tpgranel)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1192, 549)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 3
        '
        'Tpnormales
        '
        Me.Tpnormales.BackColor = System.Drawing.SystemColors.Control
        Me.Tpnormales.Controls.Add(Me.Txtbuscar1)
        Me.Tpnormales.Controls.Add(Me.LinkLabel1)
        Me.Tpnormales.Controls.Add(Me.GroupBox1)
        Me.Tpnormales.Controls.Add(Me.GroupBox2)
        Me.Tpnormales.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tpnormales.Location = New System.Drawing.Point(4, 30)
        Me.Tpnormales.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Tpnormales.Name = "Tpnormales"
        Me.Tpnormales.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Tpnormales.Size = New System.Drawing.Size(1184, 515)
        Me.Tpnormales.TabIndex = 0
        Me.Tpnormales.Text = "Codigo"
        '
        'Tpgranel
        '
        Me.Tpgranel.BackColor = System.Drawing.SystemColors.Control
        Me.Tpgranel.Controls.Add(Me.LinkLabel2)
        Me.Tpgranel.Controls.Add(Me.TxtBuscar2)
        Me.Tpgranel.Controls.Add(Me.GroupBox6)
        Me.Tpgranel.Controls.Add(Me.GroupBox4)
        Me.Tpgranel.Location = New System.Drawing.Point(4, 30)
        Me.Tpgranel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Tpgranel.Name = "Tpgranel"
        Me.Tpgranel.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Tpgranel.Size = New System.Drawing.Size(1184, 515)
        Me.Tpgranel.TabIndex = 1
        Me.Tpgranel.Text = "A Granel"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.Location = New System.Drawing.Point(445, 7)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(153, 23)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Ver Lista Completa"
        '
        'TxtBuscar2
        '
        Me.TxtBuscar2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtBuscar2.Location = New System.Drawing.Point(5, 6)
        Me.TxtBuscar2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtBuscar2.Name = "TxtBuscar2"
        Me.TxtBuscar2.Size = New System.Drawing.Size(405, 27)
        Me.TxtBuscar2.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.BtnCancelar2)
        Me.GroupBox6.Controls.Add(Me.BtnAct2)
        Me.GroupBox6.Controls.Add(Me.TxtPza_caja2)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.TxtPrecio_caja2)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.TxtExistencia2)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.TxtDescripcion2)
        Me.GroupBox6.Controls.Add(Me.CmbProvee)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.txtprecio2)
        Me.GroupBox6.Controls.Add(Me.CmbPresent)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(10, 357)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox6.Size = New System.Drawing.Size(1419, 148)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Descripción del Articulo"
        '
        'BtnCancelar2
        '
        Me.BtnCancelar2.Location = New System.Drawing.Point(1054, 48)
        Me.BtnCancelar2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCancelar2.Name = "BtnCancelar2"
        Me.BtnCancelar2.Size = New System.Drawing.Size(94, 26)
        Me.BtnCancelar2.TabIndex = 41
        Me.BtnCancelar2.Text = "&Cancelar"
        Me.BtnCancelar2.UseVisualStyleBackColor = True
        '
        'BtnAct2
        '
        Me.BtnAct2.Location = New System.Drawing.Point(1054, 16)
        Me.BtnAct2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAct2.Name = "BtnAct2"
        Me.BtnAct2.Size = New System.Drawing.Size(94, 26)
        Me.BtnAct2.TabIndex = 1
        Me.BtnAct2.Text = "&Actualizar"
        Me.BtnAct2.UseVisualStyleBackColor = True
        '
        'TxtPza_caja2
        '
        Me.TxtPza_caja2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPza_caja2.Location = New System.Drawing.Point(932, 21)
        Me.TxtPza_caja2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtPza_caja2.Name = "TxtPza_caja2"
        Me.TxtPza_caja2.Size = New System.Drawing.Size(95, 27)
        Me.TxtPza_caja2.TabIndex = 32
        Me.TxtPza_caja2.Tag = "enteros"
        Me.TxtPza_caja2.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(826, 22)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 23)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Pzas. x Caja:"
        '
        'TxtPrecio_caja2
        '
        Me.TxtPrecio_caja2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio_caja2.Location = New System.Drawing.Point(531, 51)
        Me.TxtPrecio_caja2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtPrecio_caja2.Name = "TxtPrecio_caja2"
        Me.TxtPrecio_caja2.Size = New System.Drawing.Size(95, 27)
        Me.TxtPrecio_caja2.TabIndex = 31
        Me.TxtPrecio_caja2.Tag = "decimales"
        Me.TxtPrecio_caja2.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(362, 52)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(170, 23)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Precio/Caja/Paquete:"
        '
        'TxtExistencia2
        '
        Me.TxtExistencia2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExistencia2.Location = New System.Drawing.Point(706, 21)
        Me.TxtExistencia2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtExistencia2.Name = "TxtExistencia2"
        Me.TxtExistencia2.Size = New System.Drawing.Size(95, 27)
        Me.TxtExistencia2.TabIndex = 13
        Me.TxtExistencia2.Tag = "enteros"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(615, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Existencia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 52)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Presentación:"
        '
        'TxtDescripcion2
        '
        Me.TxtDescripcion2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion2.Location = New System.Drawing.Point(114, 21)
        Me.TxtDescripcion2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtDescripcion2.Name = "TxtDescripcion2"
        Me.TxtDescripcion2.Size = New System.Drawing.Size(218, 27)
        Me.TxtDescripcion2.TabIndex = 10
        Me.TxtDescripcion2.Tag = "cadena"
        '
        'CmbProvee
        '
        Me.CmbProvee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProvee.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbProvee.FormattingEnabled = True
        Me.CmbProvee.Location = New System.Drawing.Point(810, 51)
        Me.CmbProvee.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbProvee.Name = "CmbProvee"
        Me.CmbProvee.Size = New System.Drawing.Size(218, 28)
        Me.CmbProvee.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(712, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Proveedor:"
        '
        'txtprecio2
        '
        Me.txtprecio2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio2.Location = New System.Drawing.Point(491, 21)
        Me.txtprecio2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtprecio2.Name = "txtprecio2"
        Me.txtprecio2.Size = New System.Drawing.Size(95, 27)
        Me.txtprecio2.TabIndex = 4
        Me.txtprecio2.Tag = "decimales"
        '
        'CmbPresent
        '
        Me.CmbPresent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPresent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPresent.FormattingEnabled = True
        Me.CmbPresent.Items.AddRange(New Object() {"Kg.", "Pza."})
        Me.CmbPresent.Location = New System.Drawing.Point(114, 51)
        Me.CmbPresent.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbPresent.Name = "CmbPresent"
        Me.CmbPresent.Size = New System.Drawing.Size(218, 28)
        Me.CmbPresent.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(362, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Precio Unitario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Descripción:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.DgvList_Articulos2)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(4, 21)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(1162, 318)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'DgvList_Articulos2
        '
        Me.DgvList_Articulos2.AllowUserToAddRows = False
        Me.DgvList_Articulos2.AllowUserToDeleteRows = False
        Me.DgvList_Articulos2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvList_Articulos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvList_Articulos2.Location = New System.Drawing.Point(4, 22)
        Me.DgvList_Articulos2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DgvList_Articulos2.Name = "DgvList_Articulos2"
        Me.DgvList_Articulos2.ReadOnly = True
        Me.DgvList_Articulos2.RowHeadersVisible = False
        Me.DgvList_Articulos2.RowHeadersWidth = 51
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvList_Articulos2.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvList_Articulos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvList_Articulos2.Size = New System.Drawing.Size(1154, 293)
        Me.DgvList_Articulos2.TabIndex = 0
        '
        'cmscambio
        '
        Me.cmscambio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmscambio.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmscambio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.cmscambio.Name = "cmscambio"
        Me.cmscambio.Size = New System.Drawing.Size(139, 56)
        '
        'CambiarToolStripMenuItem
        '
        Me.CambiarToolStripMenuItem.Image = CType(resources.GetObject("CambiarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CambiarToolStripMenuItem.Name = "CambiarToolStripMenuItem"
        Me.CambiarToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.CambiarToolStripMenuItem.Text = "Cambiar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'cmscambio1
        '
        Me.cmscambio1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmscambio1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmscambio1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.cmscambio1.Name = "cmscambio"
        Me.cmscambio1.Size = New System.Drawing.Size(139, 56)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(138, 26)
        Me.ToolStripMenuItem1.Text = "Cambiar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(138, 26)
        Me.ToolStripMenuItem2.Text = "Eliminar"
        '
        'FrmCat_Articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 549)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCat_Articulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de artículos"
        CType(Me.DgvLista_Articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Tpnormales.ResumeLayout(False)
        Me.Tpnormales.PerformLayout()
        Me.Tpgranel.ResumeLayout(False)
        Me.Tpgranel.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DgvList_Articulos2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmscambio.ResumeLayout(False)
        Me.cmscambio1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvLista_Articulos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtbuscar1 As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbProv As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tpnormales As System.Windows.Forms.TabPage
    Friend WithEvents Tpgranel As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBuscar2 As System.Windows.Forms.TextBox
    Friend WithEvents DgvList_Articulos2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbProvee As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtprecio2 As System.Windows.Forms.TextBox
    Friend WithEvents CmbPresent As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtExistencia2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtExistencia1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtPza_caja1 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio_caja1 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TxtPza_caja2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio_caja2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents cmscambio As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CambiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmscambio1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnAct1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnAct2 As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar2 As System.Windows.Forms.Button
End Class
