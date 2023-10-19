Imports LibPrintTicket
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO

Public Class frmpago
    Dim lee As StreamReader
    Dim funciones As New Otros

    Private Sub TxtEfectivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEfectivo.TextChanged
        Try
            If CDec(TxtEfectivo.Text) >= CDec(lbltotal.Text) Then
                Dim dj As Decimal = CDec(TxtEfectivo.Text) - CDec(lbltotal.Text)
                lblcambio.Text = Math.Round(dj, 2).ToString()
            Else
                lblcambio.Text = "0"
            End If
        Catch ex As Exception
            TxtEfectivo.Clear()
            lblcambio.Text = "0"
        End Try
    End Sub

    Private Sub frmpago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtEfectivo.Text = "0"
        Me.Icon = New Icon(Application.StartupPath.ToString() & "\img\pago2.ico")
    End Sub

    'imprimir  el ticket
    Private Sub imp_ticket()
        Dim ticket As New Ticket
        Dim impres As String = funciones.impresora()
        ticket.FontSize = Convert.ToDecimal(funciones.tam_fuente())
        ticket.AddHeaderLine("ABARROTES 'La Bodeguita'")
        ticket.AddHeaderLine("EXPEDIDO EN: Acala")
        ticket.AddHeaderLine("ACALA, CHIAPAS")
        ticket.AddSubHeaderLine("CAJA: " & funciones.no_caja())
        ticket.AddSubHeaderLine("FOLIO:" & FrmVentas.LblFolio.Text)
        ticket.AddSubHeaderLine("FECHA: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())
        For Each fila As DataGridViewRow In FrmVentas.DgvLista_venta.Rows
            ticket.AddItem(fila.Cells(1).Value, fila.Cells(2).Value, fila.Cells(5).Value)
        Next
        ticket.AddTotal("SUBTOTAL:", lbltotal.Text)
        ticket.AddTotal("     IVA:", "0")
        ticket.AddTotal("   TOTAL:", lbltotal.Text)
        ticket.AddTotal("-----------------", "-----------------")
        ticket.AddTotal("", "")
        ticket.AddTotal("RECIBIDO:", TxtEfectivo.Text)
        ticket.AddTotal("  CAMBIO:", lblcambio.Text)
        ticket.AddTotal("", "")

        ticket.AddFooterLine("PEDIDOS: 961 1743156")
        ticket.AddFooterLine("GRACIAS POR SU PREFERENCIA...")
        'Nombre de la impresora de tickets
        ticket.PrintTicket(impres)
    End Sub

    Private Sub frmpago_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp    
        If e.KeyData = Keys.Enter Then
            Try
                If (Convert.ToDecimal(TxtEfectivo.Text) - Convert.ToDecimal(lblcambio.Text)) = Convert.ToDecimal(lbltotal.Text) Then
                    FrmVentas.guarda_venta()
                    imp_ticket()
                    FrmVentas.cancel_venta()
                    Me.Close()
                End If
            Catch ex As Exception

            End Try           
        End If
    End Sub

End Class