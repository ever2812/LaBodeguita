Imports System.Drawing.Printing
Imports LibPrintTicket
Imports System.Drawing
Imports System.IO


Public Class FrmConf_Impresora

    Private Sub FrmConf_Impresora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mitol As New ToolTip()
        mitol.SetToolTip(NumTam_fuente, "Tamaño de letra")
        mitol.SetToolTip(NumCaja, "Número de Caja")

        NumTam_fuente.Minimum = 6
        NumTam_fuente.Maximum = 16

        NumCaja.Minimum = 1
        NumCaja.Maximum = 5

        Dim pr As New PrintDocument

        For Each prn As String In PrinterSettings.InstalledPrinters
            CmbImpresoras.Items.Add(prn)
        Next
    End Sub

    Private Sub prueba_ticket()
        Dim ticket As New Ticket

        'establecer el tamaño de la fuente para imprimir un ticket de prueba
        ticket.FontSize = NumTam_fuente.Value

        ticket.AddHeaderLine("     Abarrotes 'La Bodeguita'")
        ticket.AddHeaderLine("       EXPEDIDO EN: Acala")
        ticket.AddHeaderLine("          Acala Chiapas")
        ticket.AddSubHeaderLine("Folio: 000000 ")

        ticket.AddSubHeaderLine("Fecha: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())


        ticket.AddItem("1", "Artículo de prueba", "0.0")

        ticket.AddTotal("SUBTOTAL", "0.0")
        ticket.AddTotal("IVA", "0")
        ticket.AddTotal("TOTAL", "0.00")
        ticket.AddTotal("-----------------", "-----------------")
        ticket.AddTotal("", "")
        ticket.AddTotal("RECIBIDO", "0.00")
        ticket.AddTotal("CAMBIO", "0.00")
        ticket.AddTotal("", "")
        ticket.AddFooterLine("Pedidos: 961 1743156")
        ticket.AddFooterLine("Gracias por su preferencia...")
        'Nombre de la impresora de tickets
        ticket.PrintTicket(CmbImpresoras.SelectedItem.ToString())
    End Sub

    Private Sub btnprueba1_Click(sender As Object, e As EventArgs) Handles btnprueba1.Click
        If CmbImpresoras.SelectedIndex >= 0 Then
            prueba_ticket()
        Else
            MessageBox.Show("Primero debe elegir la impresora...", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnguardar1_Click(sender As Object, e As EventArgs) Handles btnguardar1.Click
        If CmbImpresoras.SelectedIndex >= 0 Then
            Dim escribe As New StreamWriter(Application.StartupPath & "\conf\imp.lbd", False)
            escribe.WriteLine(CmbImpresoras.SelectedItem.ToString())
            escribe.WriteLine(NumTam_fuente.Value.ToString())
            escribe.Close()
            escribe = New StreamWriter(Application.StartupPath & "\conf\si.txt")
            escribe.WriteLine("si") : escribe.Close()
        Else
            MessageBox.Show("Debe haber elegido una impresora de la lista", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub BtnGuardaCaja_Click(sender As Object, e As EventArgs) Handles BtnGuardaCaja.Click

        If NumCaja.Value > 0 Then
            Dim escribe As New StreamWriter(Application.StartupPath & "\conf\num_caja.lbd", False)
            escribe.WriteLine(NumCaja.Value)            
            escribe.Close()
        End If
    End Sub
End Class