Imports MySQLDriverCS

Public Class FrmInventario_Granel
    Dim fun As New Datos
    Dim consulta As String
    Dim dr As MySQLDataReader
    Dim cosas As New Otros
    Public inb As Decimal
    Dim normal As New FrmInventario_Normal

    Private Sub FrmInventario_Granel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        articulos()
        LblInver_total.Text = CDec(normal.inv + Lblinversion.Text)
        DgvArticulos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    
    End Sub

    Public Sub articulos()
        consulta = "select descripcion as Descripción, presentacion as Presentación, precio as Precio, existencia as Existencia from articulos_2 order by descripcion"
        DgvArticulos2.DataSource = fun.r_datos(consulta)
    End Sub

End Class