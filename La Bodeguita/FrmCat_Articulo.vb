Imports MySQLDriverCS
Imports System.Data


Public Class FrmCat_Articulo
    Dim cosas As New Otros
    Dim fun As New Datos    
    Dim consulta, id_art As String
    Dim clav_press, clav_prov, id_art2 As Integer
    Dim art As New FrmAltas_Articulos
    Dim presentaciones(200) As String
    Dim estado As String

    Private Sub FrmBaja_Articulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        Me.Top = 20
        Me.Height = (FrmPrincipal.Height - 120)
        ''cargar articulos con codigo de barras
        consulta = "select a.codigo as Codigo,a.presentacion as Nombre,a.precio as Precio,a.existencia as Existencia,a.precio_caja,a.pza_caja,b.nombre as Proveedor,a.id_proveedor from articulos a, proveedores b where a.id_proveedor=b.id_proveedor order by a.presentacion;"
        carga_articulos(consulta)
        ''cargar articulos sin codigo de barras
        consulta = "select a.id_articulo,a.id_proveedor,a.descripcion,a.presentacion,a.precio,a.existencia,a.precio_caja,a.pza_caja,b.nombre from articulos_2 a, proveedores b where a.id_proveedor=b.Id_proveedor order by a.descripcion;"
        carga_articulos2(consulta)

        art.proveedores(CmbProvee)
        CmbProv.DataSource = CmbProvee.Items

        DgvLista_Articulos.ContextMenuStrip = Me.cmscambio
        DgvList_Articulos2.ContextMenuStrip = Me.cmscambio1

        cosas.valida(GroupBox2)
        cosas.valida(GroupBox6)
        cosas.asing_tooltip(TxtBuscar2, "Escriba el nombre del artículo a buscar...")
    End Sub

    'busca la informacion del articulo y muestra en el datagrid
    Private Sub Txtbuscar1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtbuscar1.KeyUp
        If e.KeyData = Keys.Enter Then
            consulta = "select a.codigo,a.presentacion,a.precio,a.existencia,a.precio_caja,a.pza_caja,b.nombre,a.id_proveedor from articulos a, proveedores b where a.codigo='" & Txtbuscar1.Text & "' and a.id_proveedor=b.id_proveedor order by a.presentacion;"
            carga_articulos(consulta)
            DgvLista_Articulos.Focus()
        End If
    End Sub

    Private Sub TxtBuscar2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar2.TextChanged
        If TxtBuscar2.Text <> "Descripción del artículo..." Then

            consulta = "select a.id_articulo,a.id_proveedor,a.descripcion,a.presentacion,a.precio,a.existencia,a.precio_caja,a.pza_caja,b.nombre from articulos_2 a, proveedores b where a.descripcion like '%" & TxtBuscar2.Text & "%' and  a.id_proveedor=b.Id_proveedor order by a.descripcion;"

            carga_articulos2(consulta)

        End If
    End Sub
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtbuscar1.GotFocus
        Txtbuscar1.Clear()
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtbuscar1.LostFocus
        Txtbuscar1.Text = "Código del Artículo..."
    End Sub

    'recupera la clave del proveedor en caso de cambiarla
    Private Sub CmbProv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProv.SelectedIndexChanged
        obtiene_clave_prov(CmbProv)
    End Sub

    'carga la lista de articulos con codigo
    Private Sub carga_articulos(ByVal consulta As String)
        Dim dt As DataTable = fun.r_datos(consulta)
        If (dt.Rows.Count > 0) Then
            DgvLista_Articulos.DataSource = dt
        End If
        DgvLista_Articulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvLista_Articulos.Columns(7).Visible = False
    End Sub

    'carga la lista de articulos a granel 
    Private Sub carga_articulos2(ByVal consulta As String)
        Dim dt As DataTable = fun.r_datos(consulta)
        If (dt.Rows.Count > 0) Then
            DgvList_Articulos2.DataSource = dt
        End If
        DgvList_Articulos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvList_Articulos2.Columns(0).Visible = False
        DgvList_Articulos2.Columns(1).Visible = False
    End Sub

    Private Sub obtiene_clave_prov(ByVal combo As ComboBox)
        clav_prov = 0
        consulta = "select id_proveedor from proveedores where nombre='" & combo.Text & "';"
        Dim dt As DataTable = fun.r_datos(consulta)
        If (dt.Rows.Count > 0) Then
            For Each mi In dt.Rows
                clav_prov = Convert.ToInt32(mi(0).ToString())
            Next
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        consulta = "select a.codigo as Codigo,a.presentacion as Nombre,a.precio as Precio,a.existencia as Existencia,a.precio_caja,a.pza_caja,b.nombre as Proveedor,a.id_proveedor from articulos a, proveedores b where a.id_proveedor=b.id_proveedor order by a.presentacion;"
        carga_articulos(consulta)
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        consulta = "select a.id_articulo,a.id_proveedor,a.descripcion,a.presentacion,a.precio,a.existencia,a.precio_caja,a.pza_caja,b.nombre from articulos_2 a, proveedores b where a.id_proveedor=b.Id_proveedor order by a.descripcion;"
        carga_articulos2(consulta)
    End Sub  

    Private Sub CambiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarToolStripMenuItem.Click
        For Each fila As DataGridViewRow In DgvLista_Articulos.SelectedRows
            id_art = fila.Cells(0).Value
            TxtDescripcion1.Text = fila.Cells(1).Value
            txtprecio1.Text = fila.Cells(2).Value
            TxtExistencia1.Text = fila.Cells(3).Value

            If IsDBNull(fila.Cells(4).Value) Then
                txtPrecio_caja1.Text = "0.00"
            Else
                txtPrecio_caja1.Text = fila.Cells(4).Value
            End If

            If IsDBNull(fila.Cells(5).Value) Then
                TxtPza_caja1.Text = "0"
            Else
                TxtPza_caja1.Text = fila.Cells(5).Value
            End If            
            clav_prov = fila.Cells(7).Value
        Next
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        For Each fila As DataGridViewRow In DgvLista_Articulos.SelectedRows
            id_art = fila.Cells(0).Value
        Next
        If FrmPrincipal.usuario <> "" And FrmPrincipal.tipo_u = "Administrador" Then
            If id_art <> "" Then
                If MessageBox.Show("Desea eliminar este registro?...", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.Yes Then
                    consulta = "delete from articulos where codigo='" & id_art & "'"
                    fun.ejecutar_consulta(consulta)
                    consulta = "select a.codigo as Codigo,a.presentacion as Nombre,a.precio as Precio,a.existencia as Existencia,a.precio_caja,a.pza_caja,b.nombre as Proveedor,a.id_proveedor from articulos a, proveedores b where a.id_proveedor=b.id_proveedor order by a.presentacion;"
                    carga_articulos(consulta)
                Else
                    TxtDescripcion1.Focus()
                End If

            Else
                cosas.aviso("Primero debe elegir el articulo a eliminar")
            End If
        Else
            cosas.aviso("Necesita privilegios de administrador del sistema")
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If FrmPrincipal.usuario <> "" And FrmPrincipal.tipo_u = "Administrador" Then
            If id_art2 > 0 Then
                If MessageBox.Show("Desea eliminar este registro?...", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.Yes Then
                    consulta = "delete from articulos_2 where id_articulo=" & id_art2 & ""
                    fun.ejecutar_consulta(consulta)
                    consulta = "select a.id_articulo,a.descripcion,a.presentacion,a.precio,a.existencia,a.id_proveedor,b.nombre from articulos_2 a, proveedores b where a.id_proveedor=b.Id_proveedor;"
                    carga_articulos2(consulta)
                Else
                    TxtDescripcion2.Focus()
                End If
            Else
                cosas.aviso("Primero debe elegir un articulo")
            End If
        Else
            cosas.aviso("Necesita privilegios de administrador del sistema")
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        For Each fila As DataGridViewRow In DgvList_Articulos2.SelectedRows
            id_art2 = fila.Cells(0).Value
            clav_prov = fila.Cells(1).Value
            TxtDescripcion2.Text = fila.Cells(2).Value
            CmbPresent.Text = fila.Cells(3).Value
            txtprecio2.Text = fila.Cells(4).Value
            TxtExistencia2.Text = fila.Cells(5).Value

            If IsDBNull(fila.Cells(6).Value) Then
                TxtPrecio_caja2.Text = "0.00"
            Else
                TxtPrecio_caja2.Text = fila.Cells(6).Value
            End If
            If IsDBNull(fila.Cells(7).Value) Then
                TxtPza_caja2.Text = "0"
            Else
                TxtPza_caja2.Text = fila.Cells(7).Value
            End If

        Next
    End Sub

  

    Private Sub BtnAct1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAct1.Click
        If cosas.revisa_todo1(Me.GroupBox2) And clav_prov > 0 And id_art <> "" Then
            consulta = "update articulos set presentacion='" & TxtDescripcion1.Text & "', precio=" & txtprecio1.Text & ", existencia=" & TxtExistencia1.Text & ", precio_caja=" & CDec(txtPrecio_caja1.Text) & ", pza_caja=" & TxtPza_caja1.Text & ", id_proveedor=" & clav_prov & " where codigo='" & id_art & "'"
            fun.ejecutar_consulta(consulta)
            cosas.limpiar(GroupBox2)
            consulta = "select a.codigo as Codigo,a.presentacion as Nombre,a.precio as Precio,a.existencia as Existencia,a.precio_caja,a.pza_caja,b.nombre as Proveedor,a.id_proveedor from articulos a, proveedores b where a.id_proveedor=b.id_proveedor order by a.presentacion;"
            carga_articulos(consulta)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cosas.limpiar(GroupBox2)
    End Sub

    Private Sub BtnAct2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAct2.Click
        If cosas.revisa_todo1(Me.GroupBox6) Then
            consulta = "update articulos_2 set descripcion='" & TxtDescripcion2.Text & "', precio=" & txtprecio2.Text & ", existencia=" & TxtExistencia2.Text & ", precio_caja=" & TxtPrecio_caja2.Text & ", pza_caja=" & TxtPza_caja2.Text & ", presentacion='" & CmbPresent.Text & "', id_proveedor=" & clav_prov & " where id_articulo=" & id_art2 & ""
            fun.ejecutar_consulta(consulta)
            cosas.limpiar(GroupBox6) : TxtDescripcion2.Focus()
            consulta = "select a.id_articulo,a.descripcion,a.presentacion,a.precio,a.existencia,a.id_proveedor,a.precio_caja,a.pza_caja,b.nombre from articulos_2 a, proveedores b where a.id_proveedor=b.Id_proveedor order by a.descripcion;"
            carga_articulos2(consulta)
        End If
    End Sub

    Private Sub BtnCancelar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar2.Click
        cosas.limpiar(GroupBox6)
    End Sub
End Class