Imports MySQLDriverCS

Public Class FrmInventario_Normal
    Dim dr As MySQLDataReader
    Dim consulta As String
    Dim fun As New Datos
    Dim cosas As New Otros
    Public inv As Decimal

    Private Sub FrmInventario_Normal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        articulos()
        FrmInventario_Granel.articulos()
        LblInver_total.Text = CDec(FrmInventario_Granel.inb + LblArticulos.Text)
        DgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
  
    End Sub

    Public Sub articulos()
        consulta = "select codigo as Codigo, presentacion as Presentación, precio as Precio, existencia as Existencia from articulos order by presentacion"
        DgvArticulos.DataSource = fun.r_datos(consulta)

        Dim cantidad As Integer

        For Each fila As DataGridViewRow In DgvArticulos.Rows

            cantidad = cantidad + Convert.ToInt32(fila.Cells(3).Value.ToString())
        Next
        LblArticulos.Text = cantidad.ToString()
    End Sub


End Class