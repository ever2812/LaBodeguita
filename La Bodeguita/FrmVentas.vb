Imports MySQLDriverCS
Imports System.IO
Imports LibPrintTicket
Imports System.Drawing
Imports System.Drawing.Printing

Public Class FrmVentas
    Dim cosas As New Otros
    Dim fun As New Datos
    Dim consulta As String
    Dim caja_codigo As String = ""
    Dim dr As MySQLDataReader
    Dim fecha As String = Mid(Now(), 7, 4) & "/" & Mid(Now(), 4, 2) & "/" & Mid(Now(), 1, 2)
    Dim i As Integer = 0
    Dim lee As StreamReader

    'reconoce que teclas se presionan para responder a los eventos
    Private Sub FrmVentas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyData = Keys.F6 Then
            granel()
        ElseIf e.KeyData = Keys.F5 Then
            If LblTotal_pago.Text <> "" Then                
                frmpago.lbltotal.Text = Me.LblTotal_pago.Text
                frmpago.Show()
            Else
                cosas.aviso("Necesita realizar una venta")
            End If
        ElseIf e.KeyData = Keys.F7 Then
            FrmVenta_Mayoreo.StartPosition = FormStartPosition.CenterScreen
            FrmVenta_Mayoreo.Show()

        ElseIf e.KeyData = Keys.F9 Then
            If DgvLista_venta.RowCount > 0 Then
                cancel_venta()
            Else
                cosas.aviso("Deben haber articulos en la lista")
            End If
        ElseIf e.KeyData = Keys.F1 Then
            If DgvLista_venta.RowCount > 0 And LblTotal_pago.Text <> "0.00" Then
                abre_cajon()
                guarda_venta()
                cancel_venta() : TxtCodigo.Focus()
            Else
                cosas.aviso("Debe realizar una venta")
            End If
        End If
    End Sub

    Private Sub FrmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        Height = FrmPrincipal.Height - 80
        Width = FrmPrincipal.Width - 20
        folio()        
        cosas.asing_tooltip(TxtCodigo, "Código de barras del artículo...")
        DgvLista_venta.ContextMenuStrip = Me.ContextMenuStrip1
        StartPosition = FormStartPosition.CenterScreen
        DgvLista_venta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    'lee los codigos de barras hasta el final
    Private Sub TxtCodigo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigo.KeyUp
        If e.KeyData = Keys.Enter Then
            recupera_datos()
        End If
    End Sub

    'guardar el total de la venta y los articulos incluidos

    Public Sub guarda_venta()
        '*********** Guardar el total de la venta**********
        consulta = "insert into ventas(fecha,total,id_empleado,caja) values('" & fecha & "'," & LblTotal_pago.Text & "," & FrmPrincipal.id_usuario & "," & cosas.no_caja() & ")"
        fun.ejecutar_consulta(consulta)

        '*************************************************

        consulta = "insert into venta_articulo(folio,id_articulo,cantidad,descripcion,precio,importe) values"

        For Each fil As DataGridViewRow In DgvLista_venta.Rows


            consulta = consulta & " (" & LblFolio.Text & ",'" & fil.Cells(0).Value.ToString() & "'," & CDec(fil.Cells(1).Value.ToString()) & ",'" & fil.Cells(2).Value.ToString() & "'," & fil.Cells(4).Value.ToString() & "," & fil.Cells(5).Value.ToString() & "),"


            'Actualizar enxitencia de los articulos
            'Dim dsc As String = fil.Cells(2).Value
            ''MsgBox(Mid(dsc, 1, 5))
            'If Mid(dsc, 1, 5) <> "Cajas" Then

            '    '******actualizar la existencia d elos articulos a granel************
            '    consulta = "update articulos_2 set existencia=(existencia-" & CDec(fil.Cells(1).Value) & ") where id_articulo=" & fil.Cells(0).Value & ";"
            '    fun.ejecutar_consulta(consulta)


            '    '*****actualiza la existencia de los articulos con codigo de barras*****************
            '    consulta = "update articulos set existencia=(existencia-" & CInt(fil.Cells(1).Value) & ") where codigo='" & fil.Cells(0).Value & "'"
            '    fun.ejecutar_consulta(consulta)


            'End If
        Next

        '**********guardar los articulos vendidos***********
        Dim cons As String = consulta
        Dim ind As Integer = consulta.Length
        Dim cons2 As String = cons.Remove(ind - 1, 1)

        cons2 = cons2 & ";"
        fun.ejecutar_consulta(cons2)

    End Sub

    'cancelar todos los articulos
    Public Sub cancel_venta()
        DgvLista_venta.Rows.Clear()        
        LblTotal_pago.Text = "0.00"        
        folio()
    End Sub

    'obtener el folio de la venta
    Private Sub folio()
        Dim tabla As New DataTable()
        consulta = "select max(folio) from ventas"
        tabla = fun.r_datos(consulta)
        If tabla.Rows.Count > 0 Then
            Try
                For Each fila As DataRow In tabla.Rows
                    If Convert.ToInt32(fila(0).ToString()) > 0 Then
                        LblFolio.Text = (Convert.ToInt32(fila(0).ToString()) + 1).ToString()
                        Exit For
                    Else
                        LblFolio.Text = "1"
                    End If
                Next
            Catch ex As Exception
            End Try
        End If
    End Sub

    'calcula el total de la venta por cada nuevo articulo agregado
    Friend Sub calc_total()
        LblTotal_pago.Text = "0.00"
        For Each fila As DataGridViewRow In DgvLista_venta.Rows
            LblTotal_pago.Text += Math.Round(CDec((fila.Cells(5).Value)), 2)
        Next
    End Sub

    Private Sub DgvLista_venta_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvLista_venta.CellValueChanged
        For Each fi As DataGridViewRow In DgvLista_venta.SelectedRows
            If IsNumeric(fi.Cells(1).Value) Then
                If CDec(fi.Cells(1).Value) > CDec(fi.Cells(3).Value) Then
                    cosas.aviso("La cantidad excede la existencia, verifique")
                    fi.Cells(1).Value = 1
                Else
                    fi.Cells(5).Value = fi.Cells(1).Value * fi.Cells(4).Value
                    calc_total()
                End If
            Else
                cosas.aviso("El valor debe ser numérico")
                fi.Cells(1).Value = 0
            End If
        Next
    End Sub

    'muestra la ventana de ventas a granel
    Private Sub granel()
        FrmVenta_Granel.StartPosition = FormStartPosition.CenterScreen
        FrmVenta_Granel.Show()
    End Sub

    'recupera los datos de los articulos con codigo de barras
    Private Sub recupera_datos()
        consulta = "select codigo,presentacion,existencia,precio from articulos where codigo='" & TxtCodigo.Text & "';"
        Dim tb As New DataTable()
        tb = fun.r_datos(consulta)

        If tb.Rows.Count > 0 Then
            Try
                For Each fila As DataRow In tb.Rows
                    If Convert.ToInt32(fila(2).ToString()) > 0 Then
                        DgvLista_venta.Rows.Add(fila(0).ToString(), 1, fila(1).ToString(), fila(2).ToString(), fila(3).ToString(), (1 * (Convert.ToDecimal(fila(3).ToString()))))
                        calc_total()
                    Else
                        cosas.aviso("Este artículo esta agotado, no se puede realizar la venta")
                        Exit For
                    End If
                Next
            Catch ex As Exception

            End Try
        End If
        TxtCodigo.Clear()
    End Sub

    'abrir el cajon de dinero sin imprimir el ticket
    Public Sub abre_cajon()       
        Dim pr = New PrintDocument()
        pr.PrinterSettings.PrinterName = cosas.impresora()
        pr.PrinterSettings.PrintFileName = ".\conf\cajon.txt"
        pr.Print()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAcept.Click
        If DgvLista_venta.Rows.Count > 0 And LblTotal_pago.Text <> "0.0" Then
            frmpago.lbltotal.Text = Me.LblTotal_pago.Text
            frmpago.Show()
        Else
            cosas.aviso("Primero tiene que agregar artículos a la lista...")
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click

        If DgvLista_venta.RowCount > 0 Then
            cancel_venta()
        Else
            cosas.aviso("Deben haber articulos en la lista")
        End If
    End Sub

    Private Sub btngranel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGranel.Click
        granel()
    End Sub

    Private Sub btnmayoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMayoreo.Click
        FrmVenta_Mayoreo.Top = 130
        FrmVenta_Mayoreo.Left = 120
        FrmVenta_Mayoreo.Show()
    End Sub

    Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
        Dim it As Integer = 0
        For Each t As DataGridViewRow In DgvLista_venta.Rows
            If t.Selected = True Then
                Exit For
            End If
            it += 1
        Next
        DgvLista_venta.Rows.RemoveAt(it)
        calc_total()
    End Sub

    Private Sub CancelarTodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarTodoToolStripMenuItem.Click
        If DgvLista_venta.RowCount > 0 Then
            cancel_venta()
        Else
            cosas.aviso("Deben haber articulos en la lista")
        End If
    End Sub
End Class