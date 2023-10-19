Imports System.IO

Public Class FrmEnCaja

    Dim fun As New Datos
    Dim cosas As New Otros
    Dim consulta As String
    Dim fecha As String = Date.Now.Year.ToString() & "-" & Date.Now.Month.ToString() & "-" & Date.Now.Day.ToString()
    Dim caja As String
    Dim actualizar As Boolean = False

    Private Sub btnGuarda_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click
        If TxtCaja.Text <> "" Then
            If Convert.ToDecimal(TxtCaja.Text) > 0 Then
                If actualizar = True Then
                    consulta = "update inicia set monto=(monto + " & TxtCaja.Text & ") where fecha='" & fecha & "' and caja=" & caja & ";"
                ElseIf actualizar = False Then
                    consulta = "insert into inicia(fecha,caja,monto) values('" & fecha & "'," & caja & "," & TxtCaja.Text & ");"
                End If
                fun.ejecutar_consulta(consulta)
                cosas.aviso("Cantidad Guardada como Dinero inicial en Caja")
            End If
        End If
    End Sub

    Private Sub FrmEnCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cosas.valida(GroupBox1)
        caja = cosas.no_caja()
        If revisa_inicio() Then
            Dim res = MessageBox.Show("Ya se ha ingresado un monto en caja, desea agregar mas efectivo a esta caja?", "Atención", MessageBoxButtons.YesNo)

            If res = Windows.Forms.DialogResult.Yes Then
                actualizar = True
                TxtCaja.Enabled = True
            Else
                TxtCaja.Enabled = False
                actualizar = False
            End If



        End If
    End Sub

    Public Function revisa_inicio() As Boolean
        Dim tbla As New DataTable()
        Dim total As Decimal = 0
        consulta = "select monto from inicia where caja=" & caja & " and fecha='" & fecha & "'"
        tbla = fun.r_datos(consulta)
        If tbla.Rows.Count > 0 Then
            Try
                For Each fila As DataRow In tbla.Rows
                    total = fila("monto")
                Next
                If total > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try           
        End If        
    End Function
End Class