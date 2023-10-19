Imports MySQLDriverCS
Imports System.Data


Public Class FrmVenta_Granel
    Dim dr As MySQLDataReader
    Dim consulta As String
    Public articulos(0) As String
    Dim fun As New Datos
    Dim i As Integer = 0
    Dim cosas As New Otros
    Dim cantidad As Decimal
    Dim cla As Integer
    Dim pzas() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
    Dim kgs() As String = {"1/4", "1/2", "3/4", "1", "1 1/4", "1 1/2", "1 3/4", "2", "2 1/4", "2 1/2", "2 3/4", "3", "3 1/4", "3 1/2", "3 3/4", "4", "4 1/4", "4 1/2", "4 3/4", "5"}

    Private Sub FrmVenta_Granel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FrmVentas.TxtCodigo.Focus()
    End Sub
    Private Sub FrmVenta_Granel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        llenar_lista("select descripcion from articulos_2 where existencia>0 order by descripcion", Me.lstarticulos)
        Me.Icon = New Icon(Application.StartupPath & "\img\otros.ico")

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\img\search.png")

    End Sub

    Public Sub llenar_lista(ByVal cad As String, ByVal lista As ListBox)
        Dim ttb As New DataTable
        ttb = fun.r_datos(cad)
        If ttb.Rows.Count > 0 Then
            Try
                For Each fila As DataRow In ttb.Rows                
                    lista.Items.Add(fila(0).ToString())
                Next
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCantidad.SelectedIndexChanged
        importe()
    End Sub

    Private Sub importe()
        If TxtPrecio.Text <> "" Then
            cantidad = cosas.cantidad_kg(CmbCantidad.Text)
            TxtImporte.Text = Math.Round(Convert.ToDecimal(Convert.ToDecimal(TxtPrecio.Text) * cantidad), 2)
        Else
            cosas.aviso("Debe elegir un producto")
        End If
    End Sub

    Private Sub btnAccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgrega.Click
        If TxtImporte.Text <> "" Then
            FrmVentas.DgvLista_venta.Rows.Add(cla, cantidad, LblPresentacion.Text & " " & "de" & " " & TxtDescripcion.Text, TxtExistencia.Text, TxtPrecio.Text, TxtImporte.Text)
            FrmVentas.calc_total()
            cosas.limpiar(GroupBox2) : TxtImporte.Clear()
        Else
            cosas.aviso("Primero debe agregar un articulo")
        End If
    End Sub

    Private Sub lstarticulos_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstarticulos.MouseDoubleClick
        If lstarticulos.SelectedIndex >= 0 Then
            consulta = "select *from articulos_2 where descripcion='" & lstarticulos.SelectedItem.ToString() & "';"

            Dim dar As New DataTable()
            dar = fun.r_datos(consulta)
            If dar.Rows.Count > 0 Then
                Try
                    For Each fila As DataRow In dar.Rows
                        cla = fila(0).ToString()
                        TxtDescripcion.Text = fila(1).ToString().ToString
                        LblPresentacion.Text = fila(2).ToString().ToString
                        TxtPrecio.Text = CDec(fila(3).ToString())
                        TxtExistencia.Text = cosas.int_decimal((fila(4).ToString()))
                    Next
                Catch ex As Exception
                End Try
            End If

            Select Case LblPresentacion.Text
                Case "Pza."
                    CmbCantidad.DataSource = pzas
                Case "Kg."
                    CmbCantidad.DataSource = kgs
            End Select
            importe()
            If Convert.ToDecimal(TxtExistencia.Text) <= 0 Then
                cosas.aviso("Este artículo esta agotado, no se puede realizar la venta")
                cosas.limpiar(GroupBox2)
                TxtImporte.Clear()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        Dim cad As String = "select descripcion from articulos_2 where descripcion like '%" & TxtBuscar.Text & "%' order by descripcion"
        lstarticulos.Items.Clear()
        llenar_lista(cad, Me.lstarticulos)
    End Sub
End Class