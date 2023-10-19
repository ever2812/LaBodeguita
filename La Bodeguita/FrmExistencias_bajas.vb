Imports MySQLDriverCS

Public Class FrmExistencias_bajas
    Dim dr As MySQLDataReader
    Dim fun As New Datos
    Dim cosas As New Otros
    Dim band As Decimal = 0
    Dim band2 As Decimal = 0
    Private Sub FrmExistencias_bajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carga_articulos("")
        carga_articulos2("")        
    End Sub
    Private Sub carga_articulos(ByVal consulta As String)
        DgvCn_codigos.Rows.Clear()
        consulta = "select a.codigo,a.presentacion,a.precio,a.existencia,b.nombre from articulos a, proveedores b where a.existencia<=2 and a.id_proveedor=b.id_proveedor order by a.presentacion;"
        dr = fun.leer_datos(consulta)
        While dr.Read
            DgvCn_codigos.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
            band += 1
        End While
    End Sub

    Private Sub carga_articulos2(ByVal consulta As String)
        DgvGranel.Rows.Clear()
        consulta = "select a.id_articulo,a.descripcion,a.presentacion,a.precio,a.existencia,b.nombre from articulos_2 a, proveedores b where a.existencia<=2 and a.id_proveedor=b.Id_proveedor;"
        dr = fun.leer_datos(consulta)
        While dr.Read
            DgvGranel.Rows.Add(dr(0), dr(1), dr(2), dr(3), cosas.int_decimal(dr(4).ToString), dr(5))
            band2 += 1
        End While
    End Sub
End Class