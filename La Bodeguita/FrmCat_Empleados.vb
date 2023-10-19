Imports MySQLDriverCS
Imports System.Data


Public Class FrmCat_Empleados
    Dim cosas As New Otros
    Dim dr As MySQLDataReader
    Dim consulta As String
    Dim fun As New Datos
    Dim clave_emp As Integer
    Dim lln(0, 0) As String
    Dim emp As New FrmCat_proveedores

    Private Sub FrmBaja_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consulta = "select id_empleado, nombre as Nombre, apellidos as Apellidos, direccion as Direccion,telefono as Telefono, usuario as Login, contra as Password, tipo_usuario as Tipo from empleados order by nombre"
        llena_empleados(consulta)
        Txtcontra.PasswordChar = "*"
        If FrmPrincipal.usuario <> "" And FrmPrincipal.tipo_u = "Administrador" Then
            Txtusuario.ReadOnly = False
            Txtcontra.ReadOnly = False
            CmbTipo.Enabled = True
        ElseIf FrmPrincipal.tipo_u <> "Administrador" Then
            Txtusuario.ReadOnly = True
            Txtcontra.ReadOnly = True
            CmbTipo.Enabled = False
        End If
        DgvLista_Empleados.ContextMenuStrip = Me.cmscambio
        DgvLista_Empleados.Columns.Item(6).Visible = False

        cosas.valida(Me.GroupBox2)
        cosas.asing_tooltip(txtbuscar, "Escriba el nombre del empleado a buscar...")
    End Sub

    Private Sub llena_empleados(ByVal consulta As String)        
        Dim dt As DataTable = fun.r_datos(consulta)
        DgvLista_Empleados.DataSource = dt
        DgvLista_Empleados.Columns(0).Visible = False        
    End Sub

    Private Sub CambiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarToolStripMenuItem.Click
        For Each fila As DataGridViewRow In DgvLista_Empleados.SelectedRows
            clave_emp = fila.Cells(0).Value
            TxtNombre.Text = fila.Cells(1).Value
            Txtapellidos.Text = fila.Cells(2).Value
            TxtDireccion.Text = fila.Cells(3).Value
            TxtTelefono.Text = fila.Cells(4).Value
            Txtusuario.Text = fila.Cells(5).Value
            Txtcontra.Text = fila.Cells(6).Value
            CmbTipo.Text = fila.Cells(7).Value
        Next
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        For Each fila As DataGridViewRow In DgvLista_Empleados.SelectedRows
            clave_emp = fila.Cells(0).Value           
        Next
        If FrmPrincipal.usuario <> "" And FrmPrincipal.tipo_u = "Administrador" Then
            If clave_emp > 0 Then
                If emp.revis_prov_art("select id_empleado from ventas", clave_emp) = False Then
                    If MessageBox.Show("Desea eliminar este empleado?...", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.Yes Then
                        consulta = "delete from empleados where id_empleado=" & clave_emp & ""
                        fun.ejecutar_consulta(consulta)
                        cosas.limpiar(GroupBox2)
                        consulta = "select id_empleado, nombre as Nombre, apellidos as Apellidos, direccion as Direccion,telefono as Telefono, usuario as Login, contra as Password, tipo_usuario as Tipo from empleados order by nombre"
                        llena_empleados(consulta)
                    Else
                        TxtNombre.Focus()
                    End If
                Else
                    cosas.aviso("No puede eliminar este empleado, existen ventas realizadas por el")
                End If

            Else
                cosas.aviso("Necesita elegir un empleado de la lista")
            End If
        Else
            cosas.aviso("Necesita provilegios de administrador")
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged        
        consulta = "select id_empleado, nombre as Nombre, apellidos as Apellidos, direccion as Direccion,telefono as Telefono, usuario as Login, contra as Password, tipo_usuario as Tipo from empleados where nombre like '%" & txtbuscar.Text & "%';"
        llena_empleados(consulta)
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If cosas.revisa_todo1(Me.GroupBox2) Then
            consulta = "update empleados set nombre='" & TxtNombre.Text & "', apellidos='" & Txtapellidos.Text & "', direccion='" & TxtDireccion.Text & "', telefono='" & TxtTelefono.Text & "', usuario='" & Txtusuario.Text & "', contra='" & Txtcontra.Text & "', tipo_usuario='" & CmbTipo.Text & "' where Id_empleado=" & clave_emp & ";"
            fun.ejecutar_consulta(consulta)
            cosas.limpiar(GroupBox2)
            consulta = "select id_empleado, nombre as Nombre, apellidos as Apellidos, direccion as Direccion,telefono as Telefono, usuario as Login, contra as Password, tipo_usuario as Tipo from empleados order by nombre"
            llena_empleados(consulta)
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        cosas.limpiar(GroupBox2)
    End Sub
End Class