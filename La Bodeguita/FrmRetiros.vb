Imports System.IO
Imports System.Data


Public Class FrmRetiros

    Dim fun As New Otros
    Dim func2 As New Datos()
    Dim fecha As String = Date.Now.Year.ToString() & "-" & Date.Now.Month.ToString() & "-" & Date.Now.Day.ToString()
    Dim caja As String
    Dim consulta As String


    Private Sub FrmRetiros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fun.valida(GroupBox3)
        caja = fun.no_caja()
        lblcaja.Text = caja
        txtVentas.Text = total_ventas().ToString()
        txtRetirado.Text = retiros()
        calcula_()
        Me.AcceptButton = BtnRetiro
    End Sub

    Private Sub BtnRetiro_Click(sender As Object, e As EventArgs) Handles BtnRetiro.Click
        If fun.revisa_todo1(GroupBox3) Then
            If Convert.ToDecimal(txtretiro.Text) <= Convert.ToDecimal(txtDsiponible.Text) Then
                If Convert.ToDecimal(txtretiro.Text) > 0 Then
                    consulta = "insert into retiros(fecha,caja,monto,motivo) values('" & fecha & "'," & caja & "," & txtretiro.Text & ",'" & txtnota.Text & "');"
                    func2.ejecutar_consulta(consulta)
                    FrmVentas.abre_cajon()
                    fun.aviso("Información Guardada, Retire el efectivo")
                    fun.limpiar(GroupBox3)
                End If
            Else
                fun.aviso("No puede retirar una cantidad mayor a lo Disponible")
                txtretiro.Clear()            
            End If

        End If
    End Sub

    Public Function total_ventas() As Decimal
        Dim tbla As New DataTable()
        Dim total As Decimal = 0
        consulta = "select sum(total) as total from ventas where caja=" & caja & " and fecha='" & fecha & "'"
        tbla = func2.r_datos(consulta)
        If tbla.Rows.Count = 0 Then
            Return 0
        Else
            Try
                For Each fila As DataRow In tbla.Rows
                    total = fila("total")
                Next
                Return total
            Catch ex As Exception
                Return 0
            End Try
        End If

    End Function

    Public Function retiros() As Decimal
        Dim mitbl As New DataTable
        Dim ret As Decimal
        consulta = "select sum(monto) as total from retiros where caja=" & caja & " and fecha='" & fecha & "'"
        mitbl = func2.r_datos(consulta)
        If mitbl.Rows.Count > 0 Then
            Try
                For Each fila As DataRow In mitbl.Rows
                    ret = fila("total")
                Next
                Return ret
            Catch ex As Exception
                Return 0
            End Try
        End If
    End Function

    Private Sub calcula_()
        txtDsiponible.Text = (Convert.ToDecimal(txtVentas.Text) - Convert.ToDecimal(txtRetirado.Text)).ToString()
        If Convert.ToDecimal(txtDsiponible.Text) <= 0 Then
            txtretiro.Enabled = False
            txtnota.Enabled = False
            fun.aviso("No es posible retirar")
        End If
    End Sub
End Class