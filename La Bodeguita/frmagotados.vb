Public Class frmagotados

    Dim fun As New Datos
    Dim tab As New DataTable

    Private Sub frmagotados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        articulos()
        articulos1()
    End Sub

    Public Sub articulos()
        consulta = "select presentacion,precio,existencia from articulos where existencia=0 order by presentacion"
        tab = fun.r_datos(consulta)
        vaciar_datos(tab)

    End Sub

    Public Sub articulos1()
        consulta = "select descripcion,precio,existencia from articulos_2 where existencia=0 order by presentacion"
        tab = fun.r_datos(consulta)
        vaciar_datos(tab)
    End Sub

    Private Sub vaciar_datos(ByVal tabla As DataTable)
        If tabla.Rows.Count > 0 Then
            Try
                For Each fila As DataRow In tabla.Rows
                    DgvArticulos.Rows.Add(fila(0).ToString(), fila(1).ToString(), fila(2).ToString())
                Next
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class