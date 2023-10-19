Public Class FrmAlta_Empleados
    Dim cosas As New Otros
    Dim fun As New Datos
    Dim consulta As String

    Private Sub FrmAlta_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        cosas.valida(Me.GroupBox1)
    End Sub

    Private Sub txtusuario_gotfocus(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub TxtPass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        TxtPass.Clear()
    End Sub

    Private Sub txtusuario_lostfocus(ByVal sender As Object, ByVal e As EventArgs)
        If TxtUsuario.Text = "" Then
            TxtUsuario.Text = "-----"
        End If
    End Sub

    Private Sub txtpass_lostfocus(ByVal sender As Object, ByVal e As EventArgs)
        If TxtPass.Text = "" Then
            TxtPass.Text = "-----"
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cosas.revisa_todo1(GroupBox1)) Then
            If fun.revisar_datos(TxtNombre.Text, TxtApellidos.Text, 1, 2, "select *from empleados") = False Then
                consulta = "insert into empleados(nombre,apellidos,direccion,telefono,usuario,contra,tipo_usuario) values('" & TxtNombre.Text & "','" & TxtApellidos.Text & "','" & txtDireccion.Text & "','" & TxtTelefono.Text & "','" & TxtUsuario.Text & "','" & TxtPass.Text & "','" & CmbTipo.Text & "');"
                fun.ejecutar_consulta(consulta)
                cosas.limpiar(GroupBox1) : TxtNombre.Focus()
            Else
                cosas.aviso("El empleado ya esta registrado")
                cosas.limpiar(GroupBox1)
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Desea cancelar la operación?...", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
            cosas.limpiar(GroupBox1)
        End If
    End Sub
End Class