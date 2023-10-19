Imports MySQLDriverCS
Imports System.Data

Public Class FrmAltas_Articulos
    Dim cosas As New Otros
    Dim fun As New Datos
    Dim dr1 As MySQLDataReader
    Dim consulta As String
    Dim clave_prov As Integer
    Public pre(0), pro(0) As String    

    Private Sub FrmAltas_Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load      
        proveedores(CmbProveedores)
        CmbProveedor_granel.DataSource = CmbProveedores.Items        
        Label14.Visible = False
        cosas.valida(Me.TpCodigos)
        cosas.valida(Me.TpGranel)
    End Sub

    Private Sub CmbProveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProveedores.SelectedIndexChanged
        obtiene_clave_prov(CmbProveedores)
    End Sub

    Private Sub CmbProveedor_granel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProveedor_granel.SelectedIndexChanged
        obtiene_clave_prov(CmbProveedor_granel)
    End Sub

    Private Sub obtiene_clave_prov(ByVal combo As ComboBox)
        clave_prov = 0
        consulta = "select id_proveedor from proveedores where nombre='" & combo.Text & "'"

        Dim dt As DataTable = fun.r_datos(consulta)
        If (dt.Rows.Count > 0) Then
            For Each tr In dt.Rows
                clave_prov = tr(0).ToString()
            Next
        End If
    End Sub

    Public Function proveedores(ByVal combo As ComboBox)
        Dim dt As DataTable = fun.r_datos("select nombre from proveedores order by nombre")
        Dim t As Integer = 0
        If (dt.Rows.Count > 0) Then
            ReDim Preserve pro(dt.Rows.Count)
            Dim tr As DataRow
            For Each tr In dt.Rows
                combo.Items.Add(tr(0).ToString())                
            Next
        End If
        Return Nothing
    End Function

    Private Sub alta_articulos()
        If cosas.revisa_todo1(Me.TpCodigos) Then
            If CInt(TxtExistencia1.Text) > 0 Then
                If fun.revisar_datos(TxtCodigo.Text, TxtPresentacion1.Text, 0, 1, "select *from articulos") = False Then
                    consulta = "insert into articulos(codigo,presentacion,precio,precio_caja,pza_caja,existencia,id_proveedor) values('" & TxtCodigo.Text & "','" & TxtPresentacion1.Text & "'," & CDec(TxtPrecio1.Text) & "," & CDec(txtPrecio_caja.Text) & "," & CDec(TxtPza_caja.Text) & "," & TxtExistencia1.Text & "," & clave_prov & ")"
                    fun.ejecutar_consulta(consulta)
                    cosas.limpiar(Me.TpCodigos)
                    txtPrecio_caja.Text = "0.00"
                    TxtPza_caja.Text = "0"
                    TxtCodigo.Focus()
                Else
                    cosas.limpiar(Me.TpCodigos)
                    cosas.aviso("El articulo ya existe")
                End If
            Else
                cosas.aviso("No puede registrar productos con existencia igual a cero")
                TxtExistencia1.Clear()
            End If
        End If
    End Sub

    Private Sub TxtCodigo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigo.KeyUp
        If e.KeyData = Keys.Enter Then
            If TxtCodigo.Text <> "" Then
                TxtPresentacion1.Focus()
            Else
                TxtCodigo.Focus()
            End If

        End If
    End Sub

    Private Sub btnguarda2_double_click(ByVal sender As Object, ByVal e As EventArgs)
        alta_articulos2()
    End Sub

    Private Sub TpCodigos_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TpCodigos.Leave
        cosas.limpiar(Me.TpCodigos)
        txtPrecio_caja.Text = "0.00"
        TxtPza_caja.Text = "0"
    End Sub

    Private Sub TpGranel_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TpGranel.Leave
        cosas.limpiar(Me.TpGranel)
        TxtPrecio_caja2.Text = "0.00"
        TxtPza_caja2.Text = "0"
    End Sub


    Private Sub alta_articulos2()
        If cosas.revisa_todo1(Me.TpGranel) Then
            If CDec(TxtExistencia2.Text) > 0 Then
                If fun.revisar_datos(TxtDescripcion.Text, clave_prov, 1, 5, "select *from articulos_2") = False Then
                    consulta = "insert into articulos_2(descripcion,presentacion,precio,precio_caja,pza_caja,existencia,id_proveedor) values('" & TxtDescripcion.Text & "','" & CmbPres.Text & "'," & CDec(TxtPrecio_granel.Text) & "," & CDec(TxtPrecio_caja2.Text) & "," & CDec(TxtPza_caja2.Text) & "," & CDec(TxtExistencia2.Text) & "," & clave_prov & ")"
                    fun.ejecutar_consulta(consulta)
                    cosas.limpiar(Me.TpGranel)
                    TxtPrecio_caja2.Text = "0.00"
                    TxtPza_caja2.Text = "0"
                    TxtDescripcion.Focus()
                Else
                    cosas.aviso("El articulo ya existe")
                    cosas.limpiar(Me.TpGranel)
                End If
            Else
                cosas.aviso("No puede registrar articulos con existencia igual a cero")
                TxtExistencia2.Clear()
            End If
        End If
    End Sub

    Private Sub txtPrecio_caja_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecio_caja.LostFocus
        If txtPrecio_caja.Text = "" Then
            txtPrecio_caja.Text = "0.00"
        End If
    End Sub

    Private Sub txtPrecio_caja2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPrecio_caja2.LostFocus
        If TxtPrecio_caja2.Text = "" Then
            TxtPrecio_caja2.Text = "0.00"
        End If
    End Sub

    Private Sub txtPza_caja_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPza_caja.LostFocus
        If TxtPza_caja.Text = "" Then
            TxtPza_caja.Text = "0"
        End If
    End Sub

    Private Sub txtPza_caja2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPza_caja2.LostFocus
        If TxtPza_caja2.Text = "" Then
            TxtPza_caja2.Text = "0"
        End If
    End Sub

    Private Sub BtnAceptar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar1.Click
        alta_articulos()
    End Sub

    Private Sub BtnCancelar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar1.Click
        If MessageBox.Show("Desea cancelar la operación?..", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
            cosas.limpiar(Me.TpCodigos)
        End If
    End Sub

    Private Sub BtnAceptar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar2.Click
        alta_articulos2()
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub BtnCancelar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar2.Click
        If MessageBox.Show("Desea cancelar la operación?...", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
            cosas.limpiar(Me.TpGranel)
        End If
    End Sub
End Class
