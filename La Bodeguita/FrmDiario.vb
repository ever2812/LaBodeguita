Imports System.Drawing.Printing
Imports LibPrintTicket

Public Class FrmDiario

    Dim funciones As New Datos
    Dim funciones2 As New Otros
    Dim consulta As String
    Dim fecha As String = Date.Now.Year.ToString() & "-" & Date.Now.Month.ToString() & "-" & Date.Now.Day.ToString()
    Dim caja As String

    Private Sub FrmDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.caja = funciones2.no_caja()
        Me.Text = "Esta es la Caja Número [ " & caja & " ]"
        Me.TxtEnCaja.Text = caja_inicial().ToString()
        Me.TxtVentas.Text = ventas_dia().ToString()
        retiros_dia()
        Me.txtRetirado.Text = total_retiros().ToString()
        calcular_total()
    End Sub

    Public Function caja_inicial() As Decimal
        Dim tbla As New DataTable()
        Dim total As Decimal = 0
        consulta = "select monto from inicia where caja=" & caja & " and fecha='" & fecha & "'"
        tbla = funciones.r_datos(consulta)
        If tbla.Rows.Count > 0 Then
            Try
                For Each fila As DataRow In tbla.Rows
                    total = fila("monto")
                Next
                If total > 0 Then
                    Return total
                Else
                    Return 0
                End If
            Catch ex As Exception
                Return 0
            End Try
        End If
    End Function


    Public Function ventas_dia() As Decimal
        Dim tbla As New DataTable()
        Dim total As Decimal = 0
        consulta = "select sum(total) as monto from ventas where caja=" & caja & " and fecha='" & fecha & "'"
        tbla = funciones.r_datos(consulta)
        If tbla.Rows.Count > 0 Then
            Try
                For Each fila As DataRow In tbla.Rows
                    total = fila("monto")
                Next
                If total > 0 Then
                    Return total
                Else
                    Return 0
                End If
            Catch ex As Exception
                Return 0
            End Try
        End If
    End Function

    Private Sub retiros_dia()
        consulta = "select fecha as FECHA, motivo as Motivo, monto as Cantidad from retiros where caja=" & caja & " and fecha='" & fecha & "'"
        DataGridView1.DataSource = funciones.r_datos(consulta)
    End Sub

    Public Function total_retiros() As Decimal
        Dim tbla As New DataTable()
        Dim total As Decimal = 0
        consulta = "select sum(monto) as monto from retiros where caja=" & caja & " and fecha='" & fecha & "'"
        tbla = funciones.r_datos(consulta)
        If tbla.Rows.Count > 0 Then
            Try
                For Each fila As DataRow In tbla.Rows
                    total = fila("monto")
                Next
                If total > 0 Then
                    Return total
                Else
                    Return 0
                End If
            Catch ex As Exception
                Return 0
            End Try
        End If
    End Function

    Private Sub calcular_total()
        Dim subtotal As Decimal
        Dim total As Decimal

        Try
            subtotal = Convert.ToDecimal(TxtEnCaja.Text) + Convert.ToDecimal(TxtVentas.Text)
            If subtotal > 0 Then
                total = subtotal - Convert.ToDecimal(txtRetirado.Text)
                TxtTotalFinal.Text = total.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        imp()
    End Sub

    Private Sub imp()
        Dim ticket As New Ticket
        Dim impres As String = funciones2.impresora()
        ticket.FontSize = Convert.ToDecimal(funciones2.tam_fuente())
        ticket.AddHeaderLine("REPORTE GENERAL DEL DIA")
        ticket.AddHeaderLine("ABARROTES LA BODEGUITA")
        ticket.AddHeaderLine("VILLA DE ACALA")
        ticket.AddSubHeaderLine("CAJA NUMERO :" & caja)
        ticket.AddSubHeaderLine("FECHA: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())

        ticket.AddTotal("CAJA INICIAL :", TxtEnCaja.Text)
        ticket.AddTotal(" VENTA TOTAL :", TxtVentas.Text)
        ticket.AddTotal("  - RETIRADO :", txtRetirado.Text)
        ticket.AddTotal("", "")
        ticket.AddTotal(" TOTAL FINAL :", TxtTotalFinal.Text)
        ticket.AddTotal("", "")

        'Nombre de la impresora de tickets
        ticket.PrintTicket(impres)
    End Sub
End Class