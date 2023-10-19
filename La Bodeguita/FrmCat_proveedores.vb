Imports MySQLDriverCS
Imports System.Data


Public Class FrmCat_proveedores
    Dim cosas As New Otros
    Dim consulta As String
    Dim dr As MySQLDataReader
    Dim fun As New Datos
    Dim clave_prov As Integer

    Private Sub FrmBaja_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consulta = "select id_proveedor, nombre as Nombre,direccion as Direccion,telefono as Tel,rfc as RFC,mail as Correo from proveedores order by nombre"
        llenar_datagrid(consulta)
        DgvLista_Proveedores.ContextMenuStrip = Me.cmscambio
        cosas.valida(Me.GroupBox2)
        cosas.asing_tooltip(Txtbuscar, "Escriba el Nombre del proveedor a buscar...")
    End Sub

    Private Sub llenar_datagrid(ByVal consulta As String)
        Dim dt As DataTable = fun.r_datos(consulta)
        If (dt.Rows.Count > 0) Then
            DgvLista_Proveedores.DataSource = dt
        End If
        DgvLista_Proveedores.Columns(0).Visible = False
    End Sub

    Public Function revis_prov_art(ByVal consulta As String, ByVal id_prov As Integer) As Boolean
        Dim respuesta As Boolean
        Dim DT As DataTable = fun.r_datos(consulta)
        If (DT.Rows.Count > 0) Then
            For Each tr In DT.Rows
                If (tr(0).ToString = id_prov.ToString()) Then
                    respuesta = False : Exit For
                End If
            Next
        End If
        Return respuesta
    End Function

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CambiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarToolStripMenuItem.Click
        If DgvLista_Proveedores.SelectedRows.Count >= 0 Then
            For Each fila As DataGridViewRow In DgvLista_Proveedores.SelectedRows
                clave_prov = fila.Cells(0).Value
                Txtnombre.Text = fila.Cells(1).Value
                TxtDireccion.Text = fila.Cells(2).Value
                TxtTelefono.Text = fila.Cells(3).Value
                TxtRfc.Text = fila.Cells(4).Value
                TxtMail.Text = fila.Cells(5).Value
            Next
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        If DgvLista_Proveedores.SelectedRows.Count >= 0 Then
            For Each fila As DataGridViewRow In DgvLista_Proveedores.SelectedRows
                clave_prov = fila.Cells(0).Value
                Exit For
            Next
            If FrmPrincipal.usuario <> "" And FrmPrincipal.tipo_u = "Administrador" Then
                If clave_prov > 0 Then
                    If MessageBox.Show("Desea eliminar este proveedor?...", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.Yes Then
                        If revis_prov_art("select id_proveedor from articulos", clave_prov) = False And revis_prov_art("select id_proveedor from articulos2", clave_prov) = False Then
                            consulta = "delete from proveedores where id_proveedor=" & clave_prov & ";"
                            fun.ejecutar_consulta(consulta)
                            cosas.limpiar(GroupBox2)
                            consulta = "select id_proveedor, nombre as Nombre,direccion as Direccion,telefono as Tel,rfc as RFC,mail as Correo from proveedores order by nombre"
                            llenar_datagrid(consulta)
                        Else
                            cosas.aviso("No puede eliminar este proveedor, porque aun existen articulos relacionados")
                            cosas.limpiar(GroupBox2)
                        End If
                    Else
                        Txtnombre.Focus()
                    End If
                Else
                    cosas.aviso("Necesita elegir un proveedor de la lista")
                    Txtnombre.Focus()
                End If

            Else
                cosas.aviso("Necesita privilegios de administrador para realizar esta acción")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtbuscar.TextChanged
        consulta = "select id_proveedor, nombre as Nombre,direccion as Direccion,telefono as Tel,rfc as RFC,mail as Correo from proveedores where nombre like '%" & Txtbuscar.Text & "%';"
        llenar_datagrid(consulta)
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If cosas.revisa_todo1(Me.GroupBox2) Then
            consulta = "update proveedores set nombre='" & Txtnombre.Text & "', direccion='" & TxtDireccion.Text & "', telefono='" & TxtTelefono.Text & "', rfc='" & TxtRfc.Text & "', mail='" & TxtMail.Text & "' where id_proveedor=" & clave_prov & ";"
            fun.ejecutar_consulta(consulta)
            consulta = "select id_proveedor, nombre as Nombre,direccion as Direccion,telefono as Tel,rfc as RFC,mail as Correo from proveedores order by nombre"
            llenar_datagrid(consulta) : cosas.limpiar(GroupBox2)
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        cosas.limpiar(GroupBox2)
    End Sub
End Class