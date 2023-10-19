<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.Menu_Principal = New System.Windows.Forms.MenuStrip()
        Me.menu_Inicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Altas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Bajas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Ventas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Inventarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GranelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgotadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaDiariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DineroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DineroEnCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetirarEfectivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Configura = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServidorDeInformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpresorasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Acerca_de = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Menu_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu_Principal
        '
        Me.Menu_Principal.BackColor = System.Drawing.SystemColors.Control
        Me.Menu_Principal.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Principal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Menu_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Inicio, Me.Menu_Altas, Me.Menu_Bajas, Me.Menu_Ventas, Me.Menu_Inventarios, Me.Menu_Reportes, Me.DineroToolStripMenuItem, Me.Menu_Configura, Me.Acerca_de, Me.Menu_Salir})
        Me.Menu_Principal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.Menu_Principal.Location = New System.Drawing.Point(0, 0)
        Me.Menu_Principal.Name = "Menu_Principal"
        Me.Menu_Principal.Padding = New System.Windows.Forms.Padding(6, 1, 0, 1)
        Me.Menu_Principal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Menu_Principal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Menu_Principal.Size = New System.Drawing.Size(1243, 27)
        Me.Menu_Principal.TabIndex = 5
        Me.Menu_Principal.Text = "MenuStrip"
        '
        'menu_Inicio
        '
        Me.menu_Inicio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarSesionToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.menu_Inicio.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menu_Inicio.Name = "menu_Inicio"
        Me.menu_Inicio.Size = New System.Drawing.Size(67, 25)
        Me.menu_Inicio.Text = "Inicio"
        Me.menu_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IniciarSesionToolStripMenuItem
        '
        Me.IniciarSesionToolStripMenuItem.Name = "IniciarSesionToolStripMenuItem"
        Me.IniciarSesionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.IniciarSesionToolStripMenuItem.Text = "Iniciar Sesión"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'Menu_Altas
        '
        Me.Menu_Altas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.Menu_Altas.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Altas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Altas.Name = "Menu_Altas"
        Me.Menu_Altas.Size = New System.Drawing.Size(66, 25)
        Me.Menu_Altas.Text = "Altas"
        Me.Menu_Altas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ArticulosToolStripMenuItem.Text = "Artículos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.UsuariosToolStripMenuItem.Text = "Empleados"
        '
        'Menu_Bajas
        '
        Me.Menu_Bajas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem1, Me.ProveedoresToolStripMenuItem1, Me.EmpleadosToolStripMenuItem})
        Me.Menu_Bajas.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Bajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Bajas.Name = "Menu_Bajas"
        Me.Menu_Bajas.Size = New System.Drawing.Size(112, 25)
        Me.Menu_Bajas.Text = "Catálogos"
        Me.Menu_Bajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ArticulosToolStripMenuItem1
        '
        Me.ArticulosToolStripMenuItem1.Name = "ArticulosToolStripMenuItem1"
        Me.ArticulosToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ArticulosToolStripMenuItem1.Text = "Artículos"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'Menu_Ventas
        '
        Me.Menu_Ventas.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Ventas.Name = "Menu_Ventas"
        Me.Menu_Ventas.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.Menu_Ventas.Size = New System.Drawing.Size(84, 25)
        Me.Menu_Ventas.Text = "Ventas"
        Me.Menu_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Menu_Inventarios
        '
        Me.Menu_Inventarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalesToolStripMenuItem, Me.GranelToolStripMenuItem, Me.AgotadosToolStripMenuItem})
        Me.Menu_Inventarios.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Inventarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Inventarios.Name = "Menu_Inventarios"
        Me.Menu_Inventarios.Size = New System.Drawing.Size(109, 25)
        Me.Menu_Inventarios.Text = "Inventario"
        Me.Menu_Inventarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NormalesToolStripMenuItem
        '
        Me.NormalesToolStripMenuItem.Name = "NormalesToolStripMenuItem"
        Me.NormalesToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.NormalesToolStripMenuItem.Text = "Normales"
        '
        'GranelToolStripMenuItem
        '
        Me.GranelToolStripMenuItem.Name = "GranelToolStripMenuItem"
        Me.GranelToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.GranelToolStripMenuItem.Text = "Granel"
        '
        'AgotadosToolStripMenuItem
        '
        Me.AgotadosToolStripMenuItem.Name = "AgotadosToolStripMenuItem"
        Me.AgotadosToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.AgotadosToolStripMenuItem.Text = "Agotados"
        '
        'Menu_Reportes
        '
        Me.Menu_Reportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaDiariaToolStripMenuItem})
        Me.Menu_Reportes.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Reportes.Name = "Menu_Reportes"
        Me.Menu_Reportes.Size = New System.Drawing.Size(93, 25)
        Me.Menu_Reportes.Text = "Informes"
        Me.Menu_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VentaDiariaToolStripMenuItem
        '
        Me.VentaDiariaToolStripMenuItem.Name = "VentaDiariaToolStripMenuItem"
        Me.VentaDiariaToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.VentaDiariaToolStripMenuItem.Text = "Venta Diaria"
        '
        'DineroToolStripMenuItem
        '
        Me.DineroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DineroEnCajaToolStripMenuItem, Me.RetirarEfectivoToolStripMenuItem, Me.ReporteDiarioToolStripMenuItem})
        Me.DineroToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DineroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DineroToolStripMenuItem.Name = "DineroToolStripMenuItem"
        Me.DineroToolStripMenuItem.Size = New System.Drawing.Size(65, 25)
        Me.DineroToolStripMenuItem.Text = "Caja"
        Me.DineroToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DineroEnCajaToolStripMenuItem
        '
        Me.DineroEnCajaToolStripMenuItem.Name = "DineroEnCajaToolStripMenuItem"
        Me.DineroEnCajaToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.DineroEnCajaToolStripMenuItem.Text = "Dinero en Caja"
        '
        'RetirarEfectivoToolStripMenuItem
        '
        Me.RetirarEfectivoToolStripMenuItem.Name = "RetirarEfectivoToolStripMenuItem"
        Me.RetirarEfectivoToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.RetirarEfectivoToolStripMenuItem.Text = "Retirar Efectivo"
        '
        'ReporteDiarioToolStripMenuItem
        '
        Me.ReporteDiarioToolStripMenuItem.Name = "ReporteDiarioToolStripMenuItem"
        Me.ReporteDiarioToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.ReporteDiarioToolStripMenuItem.Text = "Reporte Diario"
        '
        'Menu_Configura
        '
        Me.Menu_Configura.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServidorDeInformaciónToolStripMenuItem, Me.ImpresorasToolStripMenuItem})
        Me.Menu_Configura.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Configura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Configura.Name = "Menu_Configura"
        Me.Menu_Configura.Size = New System.Drawing.Size(110, 25)
        Me.Menu_Configura.Text = "Configurar"
        Me.Menu_Configura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ServidorDeInformaciónToolStripMenuItem
        '
        Me.ServidorDeInformaciónToolStripMenuItem.Name = "ServidorDeInformaciónToolStripMenuItem"
        Me.ServidorDeInformaciónToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.ServidorDeInformaciónToolStripMenuItem.Text = "Conexión de Datos"
        '
        'ImpresorasToolStripMenuItem
        '
        Me.ImpresorasToolStripMenuItem.Name = "ImpresorasToolStripMenuItem"
        Me.ImpresorasToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.ImpresorasToolStripMenuItem.Text = "Tickets y Cajas"
        '
        'Acerca_de
        '
        Me.Acerca_de.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.Acerca_de.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Acerca_de.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Acerca_de.Name = "Acerca_de"
        Me.Acerca_de.Size = New System.Drawing.Size(79, 25)
        Me.Acerca_de.Text = "Ayuda"
        Me.Acerca_de.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'Menu_Salir
        '
        Me.Menu_Salir.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Menu_Salir.Name = "Menu_Salir"
        Me.Menu_Salir.Size = New System.Drawing.Size(55, 25)
        Me.Menu_Salir.Text = "Salir"
        Me.Menu_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 304)
        Me.Controls.Add(Me.Menu_Principal)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Menu_Principal
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.Menu_Principal.ResumeLayout(False)
        Me.Menu_Principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Menu_Principal As System.Windows.Forms.MenuStrip
    Friend WithEvents menu_Inicio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Altas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Bajas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Ventas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Inventarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Reportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Acerca_de As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GranelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Configura As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DineroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents AgotadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServidorDeInformaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpresorasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaDiariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DineroEnCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetirarEfectivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDiarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
