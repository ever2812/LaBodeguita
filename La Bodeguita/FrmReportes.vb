Imports MySQLDriverCS
Imports System.Data
Imports System.IO

Public Class FrmReportes

    Dim dr As MySQLDataReader
    Dim consulta As String
    Dim fecha As String = ""
    Dim f As Date
    Dim caja As String
    Dim funciones As New Otros()

    Private Sub FrmReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        f = Date.Now.Date()
        caja = funciones.no_caja()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        Me.f = DtpFecha.Value
        Dim consulta As String = "select a.folio as Folio, a.fecha as Fecha, a.total as Importe, b.nombre as Usuario, a.caja from ventas a, empleados b where a.id_empleado=b.id_empleado and a.caja=" & caja & " and fecha='" & f.ToString("yyyy/MM/dd") & "'"
        Dim dt = New Datos

        Dim tabl As DataTable
        tabl = dt.r_datos(consulta)
        DataGridView1.DataSource = tabl
    End Sub

End Class