Imports MySQLDriverCS

Public Class FrmVenta_Mayoreo
    Dim dr As MySQLDataReader
    Dim cosas As New Otros
    Dim fun As New Datos
    Dim folio, pres As String
    Dim exist As Integer
    Dim consulta As String
    Dim i As Integer = 0
    Dim lln As New FrmVenta_Granel

    Private Sub FrmVenta_Mayoreo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        lln.llenar_lista("select descripcion from articulos_2 where pza_caja>0 order by descripcion", lstarticulos)
        lstarticulos.ContextMenuStrip = cmscambio
    End Sub

    Private Sub TxtCodigo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigo.KeyUp
        If e.KeyData = Keys.Enter Then
            consulta = "select codigo,presentacion,existencia,precio_caja,pza_caja from articulos where codigo='" & TxtCodigo.Text & "'"
            dr = fun.leer_datos(consulta)
            While dr.Read
                If IsDBNull(dr(3)) = True Then
                    cosas.aviso("no tiene precio por caja")
                    Exit While
                Else
                    If dr(4).ToString <> "0" Then
                        folio = dr(0).ToString
                        pres = dr(1).ToString
                        exist = dr(2)
                        Txtdescripcion.Text = dr(1).ToString
                        txtExist_cajas.Text = CDec(dr(2) \ dr(4))
                        TxtPrecio_caja.Text = dr(3)
                        TxtPieza_caja.Text = dr(4).ToString
                    Else
                        cosas.aviso("No tiene designadas las piezas por caja")
                    End If
                End If
            End While
            TxtCodigo.Clear()
            TxtCajas.Focus()
        End If
    End Sub

    Private Sub TxtCajas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCajas.LostFocus
        If TxtCajas.Text <> "" Then
            If CDec(TxtCajas.Text) > 0 Then
                If CDec(TxtCajas.Text) <= CDec(txtExist_cajas.Text) Then
                    DgvLista_Mayoreo.Rows.Add(folio, TxtCajas.Text, "Cajas " & pres, txtExist_cajas.Text, TxtPrecio_caja.Text, (CDec(TxtCajas.Text * TxtPrecio_caja.Text)), TxtPieza_caja.Text)
                    cosas.limpiar(GpbInfo)
                    TxtCodigo.Clear()
                    TxtCodigo.Focus()
                Else
                    TxtCajas.Clear()
                    cosas.aviso("Revise la existencia del articulo")
                End If
            End If
        End If
    End Sub

    Private Sub btngran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If GpbLista.Visible = False Then
        '    GpbInfo.Left += GpbLista.Width + 30
        '    Me.Height += GpbLista.Height
        '    GpbLista.Height += GpbLista.Height
        '    GpbLista.Visible = True
        'Else
        '    GpbInfo.Left -= GpbLista.Width + 30
        '    GpbLista.Visible = False
        '    Me.Height -= (GpbLista.Height / 2)
        '    GpbLista.Height -= (GpbLista.Height / 2)
        'End If
    End Sub

    Private Sub btnaccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaccept.Click
        If DgvLista_Mayoreo.RowCount <> 0 Then
            For Each fila As DataGridViewRow In DgvLista_Mayoreo.Rows
                'consulta = "update articulos set existencia=(existencia-" & CDec(fila.Cells(1).Value * fila.Cells(6).Value) & ") where codigo='" & fila.Cells(0).Value & "'"
                'fun.ejecutar_consulta(consulta)
                'consulta = "update articulos_2 set existencia=(existencia-" & CDec(fila.Cells(1).Value * fila.Cells(6).Value) & ") where id_articulo=" & fila.Cells(0).Value & ""
                'fun.ejecutar_consulta(consulta)
                FrmVentas.DgvLista_venta.Rows.Add(fila.Cells(0).Value, fila.Cells(1).Value, fila.Cells(2).Value, 0, fila.Cells(4).Value, fila.Cells(5).Value)
            Next
            cosas.limpiar(GpbInfo)
            DgvLista_Mayoreo.Rows.Clear()
            FrmVentas.calc_total()
        Else
            cosas.aviso("Debe agregar articulos")
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        DgvLista_Mayoreo.Rows.Clear()
        cosas.limpiar(GpbInfo)
    End Sub

    Private Sub CambiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarToolStripMenuItem.Click
        If lstarticulos.SelectedIndex >= 0 Then
            consulta = "select id_articulo,descripcion,existencia,precio_caja,pza_caja from articulos_2 where descripcion='" & lstarticulos.SelectedItem.ToString() & "'"
            dr = fun.leer_datos(consulta)
            While dr.Read
                If IsDBNull(dr(3)) = True Then
                    cosas.aviso("Aun no se asigna precio de caja")
                    Exit While
                Else
                    If dr(4).ToString <> "0" Then
                        folio = dr(0).ToString
                        pres = dr(1).ToString
                        Txtdescripcion.Text = dr(1).ToString
                        exist = dr(2)
                        txtExist_cajas.Text = CDec(dr(2) \ dr(4))
                        TxtPrecio_caja.Text = dr(3)
                        TxtPieza_caja.Text = dr(4).ToString
                    Else
                        cosas.aviso("No tiene designadas las piezas por caja")
                    End If

                End If
            End While
            TxtCajas.Focus()
        End If
    End Sub

End Class